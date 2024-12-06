using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using VenueApplication.DataAccess;
using VenueApplication.Models;

namespace VenueApplication.Services
{
    internal static class TicketService
    {
        public static bool AttemptTicketCreation(int eventIDFK, string section, decimal price, string ticketStatusCode, DatabaseManager databaseManager)
        {
            // Create necessary related objects
            venue_ticket newTicket = new venue_ticket(eventIDFK, section, price, ticketStatusCode, databaseManager);

            // Generate the SQL query
            string query = newTicket.CreateSQLBulkInsertQuery();

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
                            command = newTicket.AddWithValues(command);

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


        public static bool AttemptTicketDeletion(int tkt_id, DatabaseManager databaseManager)
        {
            // Create necessary related objects
            venue_ticket newTicket = new venue_ticket(tkt_id, 1, "TEM", 1, 1, 0, "TEM", databaseManager);
            // Generate the SQL query
            string query = newTicket.CreateSQLDeleteQuery();

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
                            command = newTicket.AddWithValuesDeletion(command);

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


        public static bool AttemptScan(int tkt_id, DatabaseManager databaseManager)
        {
            // Create necessary related objects
            venue_ticket newTicket = new venue_ticket(tkt_id, 1, "TEM", 1, 1, 0, "TEM", databaseManager);
            // Generate the SQL query
            string query = newTicket.CreateSQLScanQuery();

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
                            command = newTicket.AddWithValuesDeletion(command);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected != 1)
                            {
                                transaction.Rollback();
                                return false;
                            }


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
