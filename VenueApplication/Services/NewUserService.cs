using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using VenueApplication.DataAccess;
using VenueApplication.Models;

namespace VenueApplication.Services
{

    internal static class NewUserService
    {
        public static bool attemptSignup(string firstname, string lastname, string email, DateOnly? birthday, string username, string password, DatabaseManager databaseManager)
        {
            // Create necessary related objects
            login_credentials loginCreds = new login_credentials(username, password, email, databaseManager);
            user_wallet wallet = new user_wallet(databaseManager);
            app_user newUser = new app_user(firstname, lastname, birthday, 0m, "USER", loginCreds, wallet, databaseManager);

            // Generate the SQL query
            string query = newUser.CreateSQLInsertQuery();

            using (var dbConnection = databaseManager.GetConnection())
            {

                try
                {
                    dbConnection.Open();

                    // Start a transaction
                    using (var transaction = dbConnection.BeginTransaction())
                    {
                        try
                        {
                            // Create a command object to execute the query
                            var command = new NpgsqlCommand(query, dbConnection, transaction);

                            // Add parameters to the query
                            command = newUser.AddWithValues(command);
                            command = loginCreds.AddWithValues(command);

                            int rowsAffected = command.ExecuteNonQuery();

                            // Commit the transaction if everything is successful
                            transaction.Commit();

                            return true;
                        }
                        catch (Exception ex)
                        {
                            // Rollback the transaction in case of error
                            transaction.Rollback();
                            MessageBox.Show($"Error executing query: {ex.Message}");
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Connection error: {ex.Message}");
                    return false;
                }
            }
        }


    }
}
