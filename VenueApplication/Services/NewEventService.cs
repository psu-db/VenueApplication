using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using VenueApplication.DataAccess;
using VenueApplication.Models;

namespace VenueApplication.Services
{
    internal static class NewEventService
    {
        public static bool AttemptEventCreation(DateOnly? eventDate, TimeOnly eventTime, string eventType, string eventDescription, DatabaseManager databaseManager)
        {
            // Create necessary related objects
            venue_event newEvent = new venue_event(eventDate, eventTime, eventType, eventDescription, databaseManager);

            // Generate the SQL query
            string query = newEvent.CreateSQLInsertQuery();

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
                            command = newEvent.AddWithValues(command);

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
