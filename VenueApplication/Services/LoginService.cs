using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenueApplication.DataAccess;

namespace VenueApplication.Services
{
    internal static class LoginService
    {
        public static bool attemptLogin(string username, string password, DatabaseManager databaseManager)
        {

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
                                string lgn_username = reader.GetString(reader.GetOrdinal("lgn_username"));
                                string lgn_password = reader.GetString(reader.GetOrdinal("lgn_password"));

                                // Debug output
                                Debug.WriteLine($"lgn_username: {lgn_username}, lgn_password: {lgn_password}");
                            }

                            Debug.WriteLine("Successful Login!");
                            return true;
                        }
                        else
                        {
                            Debug.WriteLine("Login Failed");
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing query: {ex.Message}");

                    return false;
                }
            }
        }
    }
}