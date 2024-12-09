using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenueApplication.DataAccess;
using System.Security.Cryptography;

namespace VenueApplication.Models
{
    public class payment_info
    {
        #region Table Attributes
        // Primary key
        public int pymt_info_id { get; set; } // DBMS will auto-generate this

        public int pymt_info_user_id { get; set; }
        public string pymt_info_type { get; set; }
        public string pymt_info_card_number { get; set; }
        public string pymt_info_card_cvv { get; set; }
        public string pymt_info_expiration_date { get; set; } // FORMAT MM/YY
        public string pymt_info_address { get; set; }
        public string pymt_info_address_state { get; set; }
        public string pymt_info_zipcode { get; set; }

        #endregion

        DatabaseManager databaseManager { get; set; }

        public payment_info(int pymt_info_id, int pymt_info_user_id, string pymt_info_type, string pymt_info_card_number, string pymt_info_card_cvv, string pymt_info_expiration_date, string pymt_info_address, string pymt_info_address_state, string pymt_info_zipcode, DatabaseManager databaseManager)
        {
            this.pymt_info_id = pymt_info_id;
            this.pymt_info_user_id = pymt_info_user_id;
            this.pymt_info_type = pymt_info_type;
            this.pymt_info_card_number = pymt_info_card_number;
            this.pymt_info_card_cvv = pymt_info_card_cvv;
            this.pymt_info_expiration_date = pymt_info_expiration_date;
            this.pymt_info_address = pymt_info_address;
            this.pymt_info_address_state = pymt_info_address_state;
            this.pymt_info_zipcode = pymt_info_zipcode;
            this.databaseManager = databaseManager;
        }
        public payment_info(int pymt_info_user_id, string pymt_info_type, string pymt_info_card_number, string pymt_info_card_cvv, string pymt_info_expiration_date, string pymt_info_address, string pymt_info_address_state, string pymt_info_zipcode, DatabaseManager databaseManager)
        {
            this.pymt_info_user_id = pymt_info_user_id;
            this.pymt_info_type = pymt_info_type;
            this.pymt_info_card_number = pymt_info_card_number;
            this.pymt_info_card_cvv = pymt_info_card_cvv;
            this.pymt_info_expiration_date = pymt_info_expiration_date;
            this.pymt_info_address = pymt_info_address;
            this.pymt_info_address_state = pymt_info_address_state;
            this.pymt_info_zipcode = pymt_info_zipcode;
            this.databaseManager = databaseManager;
        }

        public string CreateSQLInsertQuery()
        {
            string query = VenueApplication.Properties.Resource.paymentMethod_INSERT;

            return query;
        }

        public NpgsqlCommand AddWithValues(NpgsqlCommand command)
        {
            string AES_KEY = Environment.GetEnvironmentVariable("AES_KEY")!;
            string AES_IV = Environment.GetEnvironmentVariable("AES_IV")!;

            try
            {
                string encryptedCardNumber = EncryptWithAES(pymt_info_card_number, AES_KEY, AES_IV);
                string encryptedCardCVV = EncryptWithAES(pymt_info_card_cvv, AES_KEY, AES_IV);
                string encryptedAddress = EncryptWithAES(pymt_info_address, AES_KEY, AES_IV);
                string encryptedState = EncryptWithAES(pymt_info_address_state, AES_KEY, AES_IV);
                string encryptedZipcode = EncryptWithAES(pymt_info_zipcode, AES_KEY, AES_IV);

                command.Parameters.AddWithValue("@user_id", pymt_info_user_id);
                command.Parameters.AddWithValue("@card_type", pymt_info_type);
                command.Parameters.AddWithValue("@card_number", encryptedCardNumber);
                command.Parameters.AddWithValue("@card_cvv", encryptedCardCVV);
                command.Parameters.AddWithValue("@exp_date", pymt_info_expiration_date);
                command.Parameters.AddWithValue("@address", encryptedAddress);
                command.Parameters.AddWithValue("@state", encryptedState);
                command.Parameters.AddWithValue("@zipcode", encryptedZipcode);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error while trying to add replace values in query: " + ex.Message);
            }

            return command;

        }

        private string EncryptWithAES(string plaintext, string key, string iv)
        {
            if (string.IsNullOrEmpty(plaintext)) throw new ArgumentException("Plaintext cannot be null or empty.");
            if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(iv)) throw new ArgumentException("Key and IV cannot be null or empty.");

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Convert.FromBase64String(key);
                aesAlg.IV = Convert.FromBase64String(iv);
                aesAlg.Padding = PaddingMode.PKCS7; // Explicit padding mode

                using (ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV))
                {
                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt, Encoding.UTF8)) // Specify UTF-8 encoding
                            {
                                swEncrypt.Write(plaintext);
                            }
                        }
                        return Convert.ToBase64String(msEncrypt.ToArray()); // Return encrypted data as base64 string
                    }
                }
            }
        }

        private string DecryptWithAES(string encryptedText, string key, string iv)
        {
            if (string.IsNullOrEmpty(encryptedText)) throw new ArgumentException("Encrypted text cannot be null or empty.");
            if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(iv)) throw new ArgumentException("Key and IV cannot be null or empty.");

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Convert.FromBase64String(key);
                aesAlg.IV = Convert.FromBase64String(iv);
                aesAlg.Padding = PaddingMode.PKCS7; // Explicit padding mode

                using (ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV))
                {
                    using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(encryptedText)))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader reader = new StreamReader(csDecrypt, Encoding.UTF8)) // Specify UTF-8 encoding
                            {
                                return reader.ReadToEnd();
                            }
                        }
                    }
                }
            }
        }

        public override string ToString()
        {
            if (this.pymt_info_card_number != "0000000000000000")
            {
                string AES_KEY = Environment.GetEnvironmentVariable("AES_KEY")!;
                string AES_IV = Environment.GetEnvironmentVariable("AES_IV")!;

                string decryptedCardNumbers = DecryptWithAES(pymt_info_card_number, AES_KEY, AES_IV);

                return $"{pymt_info_type} Ending in {decryptedCardNumbers.Substring(decryptedCardNumbers.Length - 4)}";
            }
            else
            {
                return $"{pymt_info_type} Ending in {pymt_info_card_number.Substring(pymt_info_card_number.Length - 4)}";
            }
        }

    }
}
