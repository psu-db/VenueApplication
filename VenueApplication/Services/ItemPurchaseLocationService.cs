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
    internal static class ItemPurchaseLocationService
    {
        public static bool AttemptPurchaseLocationCreation(int itmpurItemId, int itmpurStoreId, DatabaseManager databaseManager)
        {
            // Create necessary related objects
            item_purchase_location newItemPurchaseLocation = new item_purchase_location(itmpurItemId, itmpurStoreId, databaseManager);

            // Generate the SQL query
            //string query = newItemPurchaseLocation.CreateSQLInsertQuery();



            //DEPRECATE
            string query = "";

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
                            command = newItemPurchaseLocation.AddWithValues(command);

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
