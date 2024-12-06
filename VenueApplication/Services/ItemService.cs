using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Syncfusion.Windows.Forms.Tools.Win32API;
using VenueApplication.DataAccess;
using VenueApplication.Models;

namespace VenueApplication.Services
{
    public  static class ItemService
    {
        public static bool AttemptItemCreation(string item_name, decimal item_price, DatabaseManager databaseManager)
        {
            // Create necessary related objects
            venue_item newItem = new venue_item(item_name, item_price, databaseManager);

            // Generate the SQL query
            string query = newItem.CreateSQLInsertQuery();

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
                            command = newItem.AddWithValues(command);

                            int rowsAffected = command.ExecuteNonQuery();
                            //check if rows affected is 3


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
