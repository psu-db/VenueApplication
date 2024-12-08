using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using VenueApplication.DataAccess;
using VenueApplication.Forms;
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

        public static bool AttemptPurchaseTicket(venue_ticket ticket, MainForm mainForm, DatabaseManager databaseManager)
        {
            if (ticket != null)
            {
                // Create necessary related objects
                DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);

                ticket_purchase ticketPurchase = new ticket_purchase(ticket.tkt_id, currentDate, LoginForm.USER_WALLET_ID, databaseManager);

                // Generate the SQL query
                string query = ticketPurchase.CreateSQLInsertQuery();

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

                                if (ticket.tkt_status == "RSL")
                                {
                                    command = ticketPurchase.AddWithValues(command, "RLD", ticket.tkt_id.ToString());

                                    // (IMPLEMENT): give seller their money for the ticket to their account balance
                                    (bool returnGetSellerAndTicketInfoStatus, int? user_id, decimal? tkt_price) = TicketService.AttemptGetSellerAndTicketInfo(ticket.tkt_id, databaseManager);
                                    (bool attemptUpdateBalanceStatus, decimal? newBalance) = TicketService.AttemptUpdateUserBalanceFromTicketSale(user_id, tkt_price, databaseManager);

                                    if (returnGetSellerAndTicketInfoStatus && attemptUpdateBalanceStatus)
                                    {
                                        //Update users balance
                                        mainForm.InitializeProfilePage(newBalance);
                                    }

                                }
                                else
                                {
                                    command = ticketPurchase.AddWithValues(command, "SLD", ticket.tkt_id.ToString());
                                }


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

            return false;
        }

        public static bool AttemptSellTicket(venue_ticket ticket, DatabaseManager databaseManager)
        {
            string query = VenueApplication.Properties.Resource.myTickets_UPDATE;

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
                            command.Parameters.AddWithValue("@ticket_id", ticket.tkt_id);

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

        public static (bool, int?, decimal?) AttemptGetSellerAndTicketInfo(int ticket_id, DatabaseManager databaseManager)
        {

            // Generate the SQL query
            string query = VenueApplication.Properties.Resource.ticketSellerInfo_SELECT;

            using (var dbConnection = databaseManager.GetConnection())
            {
                // Create a command object to execute the query
                var command = new NpgsqlCommand(query, dbConnection);

                // Add parameters to the query
                command.Parameters.AddWithValue("@ticket_id", ticket_id);

                try
                {
                    dbConnection.Open();

                    // Execute the query and get a reader to read the results
                    using (var reader = command.ExecuteReader())
                    {
                        // Check if there are any rows (meaning the username/password pair is valid)

                        if (reader.HasRows)
                        {
                            int? user_id = null;
                            decimal? tkt_price = null;

                            while (reader.Read())
                            {
                                user_id = reader.IsDBNull(reader.GetOrdinal("user_id")) ? null : reader.GetInt32(reader.GetOrdinal("user_id"));
                                tkt_price = reader.IsDBNull(reader.GetOrdinal("tkt_price")) ? null : reader.GetDecimal(reader.GetOrdinal("tkt_price"));

                            }

                            return (true, user_id, tkt_price);
                        }
                        else
                        {
                            Debug.WriteLine("Fetching ticket seller info failed");
                            return (false, null, null);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing query: {ex.Message}");

                    return (false, null, null);
                }
            }

        }

        public static (bool, decimal?) AttemptUpdateUserBalanceFromTicketSale(int? user_id, decimal? ticket_sold_price, DatabaseManager databaseManager)
        {
            string query = VenueApplication.Properties.Resource.ticketSellerBalance_UPDATE;

            using (var dbConnection = databaseManager.GetConnection())
            {
                // Create a command object to execute the query
                var command = new NpgsqlCommand(query, dbConnection);

                // Add parameters to the query
                command.Parameters.AddWithValue("@user_id", user_id);
                command.Parameters.AddWithValue("@ticket_sold_price", ticket_sold_price);

                try
                {
                    dbConnection.Open();

                    // Execute the query and get a reader to read the results
                    using (var reader = command.ExecuteReader())
                    {
                        // Check if there are any rows (meaning the username/password pair is valid)

                        if (reader.HasRows)
                        {
                            decimal? user_balance = null;

                            while (reader.Read())
                            {
                                user_balance = reader.IsDBNull(reader.GetOrdinal("user_balance")) ? null : reader.GetDecimal(reader.GetOrdinal("user_balance"));

                            }

                            return (true, user_balance);
                        }
                        else
                        {
                            Debug.WriteLine("Updating ticket sellers balance failed");
                            return (false, null);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing query: {ex.Message}");

                    return (false, null);
                }
            }
        }

    }

    
}
