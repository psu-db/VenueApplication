using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using VenueApplication.DataAccess;
using VenueApplication.Models;
using VenueApplication.Forms;

namespace VenueApplication.Services
{
    internal static class NewPaymentMethodService
    {
        public static bool AttemptAddNewPaymentMethod(string cardType, string cardNumber, string cardCVV, string expDate, string address, string state, string zipcode, DatabaseManager databaseManager)
        {
            // Create necessary related object
            payment_info paymentInfo = new payment_info(LoginForm.USER_ID, cardType, cardNumber, cardCVV, expDate, address, state, zipcode, databaseManager);

            
            // Generate the SQL query
            string query = paymentInfo.CreateSQLInsertQuery();

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
                            command = paymentInfo.AddWithValues(command);

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

