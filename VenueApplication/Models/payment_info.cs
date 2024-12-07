using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenueApplication.DataAccess;

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
            try
            {
                command.Parameters.AddWithValue("@user_id", pymt_info_user_id);
                command.Parameters.AddWithValue("@card_type", pymt_info_type);
                command.Parameters.AddWithValue("@card_number", pymt_info_card_number);
                command.Parameters.AddWithValue("@card_cvv", pymt_info_card_cvv);
                command.Parameters.AddWithValue("@exp_date", pymt_info_expiration_date);
                command.Parameters.AddWithValue("@address", pymt_info_address);
                command.Parameters.AddWithValue("@state", pymt_info_address_state);
                command.Parameters.AddWithValue("@zipcode", pymt_info_zipcode);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error while trying to add replace values in query: " + ex.Message);
            }

            return command;

        }

        public override string ToString()
        {
            return $"{pymt_info_type} Ending in {pymt_info_card_number.Substring(pymt_info_card_number.Length - 4)}";
        }

    }
}
