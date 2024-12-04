using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenueApplication.DataAccess;
using VenueApplication.Models;

namespace VenueApplication.Services
{
    internal static class LoginService
    {
        public static (bool, user_wallet?, login_credentials?, app_user?) AttemptLogin(string username, string password, DatabaseManager databaseManager)
        {
            //this is the local branch
            string query = VenueApplication.Properties.Resource.userLogin_SELECT;

            using (var dbConnection = databaseManager.GetConnection())
            {
                // Create a command object to execute the query
                var command = new NpgsqlCommand(query, dbConnection);

                // Add parameters to the query
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                try
                {
                    dbConnection.Open();

                    // Execute the query and get a reader to read the results
                    using (var reader = command.ExecuteReader())
                    {
                        // Check if there are any rows (meaning the username/password pair is valid)
                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {
                                #region gets app_user properties

                                // Properties for a app_user object
                                int? user_id = reader.IsDBNull(reader.GetOrdinal("user_id")) ? null : reader.GetInt32(reader.GetOrdinal("user_id"));
                                string? user_fname = reader.IsDBNull(reader.GetOrdinal("user_fname")) ? null : reader.GetString(reader.GetOrdinal("user_fname"));
                                string? user_lname = reader.IsDBNull(reader.GetOrdinal("user_lname")) ? null : reader.GetString(reader.GetOrdinal("user_lname"));
                                string? user_type = reader.IsDBNull(reader.GetOrdinal("user_type")) ? null : reader.GetString(reader.GetOrdinal("user_type"));

                                // Nullable DateOnly for user_birthday
                                DateOnly? user_birthday = null;
                                if (!reader.IsDBNull(reader.GetOrdinal("user_birthday")))
                                {
                                    user_birthday = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("user_birthday")));
                                }

                                // Decimal for user_balance
                                decimal user_balance = 0;
                                if (!reader.IsDBNull(reader.GetOrdinal("user_balance")))
                                {
                                    user_balance = reader.GetDecimal(reader.GetOrdinal("user_balance"));
                                }

                                #endregion

                                #region gets login_creds properties

                                int? lgn_creds_id = reader.IsDBNull(reader.GetOrdinal("lgn_creds_id")) ? null : reader.GetInt32(reader.GetOrdinal("lgn_creds_id"));
                                int? lgn_user_id = reader.IsDBNull(reader.GetOrdinal("lgn_user_id")) ? null : reader.GetInt32(reader.GetOrdinal("lgn_user_id"));
                                string? lgn_username = reader.IsDBNull(reader.GetOrdinal("lgn_username")) ? null : reader.GetString(reader.GetOrdinal("lgn_username"));
                                string? lgn_password = reader.IsDBNull(reader.GetOrdinal("lgn_password")) ? null : reader.GetString(reader.GetOrdinal("lgn_password"));
                                string? lgn_email = reader.IsDBNull(reader.GetOrdinal("lgn_email")) ? null : reader.GetString(reader.GetOrdinal("lgn_email"));

                                #endregion

                                #region gets user_wallet properties

                                int? wallet_id = reader.IsDBNull(reader.GetOrdinal("wallet_id")) ? null : reader.GetInt32(reader.GetOrdinal("wallet_id"));
                                int? wallet_user_id = reader.IsDBNull(reader.GetOrdinal("wallet_user_id")) ? null : reader.GetInt32(reader.GetOrdinal("wallet_user_id"));

                                #endregion

                                user_wallet wallet = new user_wallet((int)wallet_id, (int)wallet_user_id, databaseManager);
                                login_credentials lgn_creds = new login_credentials((int)lgn_creds_id, (int)lgn_user_id, lgn_username, lgn_password, lgn_email, databaseManager);
                                app_user user = new app_user((int)user_id, user_fname, user_lname, user_birthday, user_balance, user_type, lgn_creds, wallet, databaseManager);

                                Debug.WriteLine("Successful Login!");
                                return (true, wallet, lgn_creds, user);
                            }

                            
                        }
                        else
                        {
                            Debug.WriteLine("Login Failed");
                            return (false, null, null, null);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing query: {ex.Message}");

                    return (false, null, null, null);
                }
            }

            return (false, null, null, null);
        }
    }
}