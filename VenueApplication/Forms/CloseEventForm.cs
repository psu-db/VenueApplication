using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Events;
using VenueApplication.DataAccess;
using VenueApplication.Models;
using VenueApplication.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace VenueApplication.Forms
{
    public partial class CloseEventForm : MetroForm
    {

        private MainForm mainForm;
        public DatabaseManager databaseManager;
        public venue_event selectedEvent;
        public CloseEventForm(MainForm mainForm, DatabaseManager databaseManager, venue_event selectedEvent)
        {

            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.mainForm = mainForm;
            this.databaseManager = databaseManager;
            this.selectedEvent = selectedEvent;

            closeEventCloseButton.Enabled = true;
            closeEventTicketRevenue.Text = "0";
            closeEventTicketsSoldLabel.Text = "0";
            initializeFinancialData();

            closeEventDataGrid.AutoGenerateColumns = false;
            List<report_data> reportDataSet = initializeTransactionData();
            closeEventDataGrid.DataSource = reportDataSet;
            FormatDataGridForReport();

            closeEventEventNameLabel.Text = selectedEvent.event_description;
        }

        private void initializeFinancialData()
        {
            List<decimal> results = new List<decimal>();
            string query = VenueApplication.Properties.Resource.eventSelectTicketData_SELECT;
            using (var dbConnection = databaseManager.GetConnection())
            {
                // Create a command object to execute the query
                var command = new NpgsqlCommand(query, dbConnection);
                // Add parameters to the query
                command.Parameters.AddWithValue("@eventid", this.selectedEvent.event_id);

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
                                int? num_tickets_sold = reader.IsDBNull(reader.GetOrdinal("num_tickets_sold")) ? null : reader.GetInt32(reader.GetOrdinal("num_tickets_sold"));
                                decimal? total_ticket_revenue = reader.IsDBNull(reader.GetOrdinal("total_ticket_revenue")) ? null : reader.GetDecimal(reader.GetOrdinal("total_ticket_revenue"));
                                if (num_tickets_sold == null || total_ticket_revenue == null)
                                {
                                    closeEventMessageLabel.Text = "Error loading event data";
                                    closeEventMessageLabel.ForeColor = Color.Red;
                                    return;
                                }
                                results.Add((decimal)num_tickets_sold);
                                results.Add((decimal)total_ticket_revenue);
                            }
                        }
                        else
                        {
                            Debug.WriteLine("Loading data failed");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing query: {ex.Message}");
                }
            }


            if (results.Count != 2)
            {
                closeEventMessageLabel.Text = "error returning data";
                closeEventMessageLabel.ForeColor = Color.Red;
                return;
            }

            closeEventTicketsSoldLabel.Text = results[0].ToString();
            closeEventTicketRevenue.Text = results[1].ToString();

        }

        private List<report_data> initializeTransactionData()
        {
            List<report_data> results = new List<report_data>();
            string query = VenueApplication.Properties.Resource.eventDataTransactions_SELECT;
            using (var dbConnection = databaseManager.GetConnection())
            {
                // Create a command object to execute the query
                var command = new NpgsqlCommand(query, dbConnection);
                // Add parameters to the query
                command.Parameters.AddWithValue("@transeventid", this.selectedEvent.event_id);

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
                                string? email = reader.IsDBNull(reader.GetOrdinal("lgn_email")) ? null : reader.GetString(reader.GetOrdinal("lgn_email"));
                                string? item_name = reader.IsDBNull(reader.GetOrdinal("item_name")) ? null : reader.GetString(reader.GetOrdinal("item_name"));
                                string? store_name = reader.IsDBNull(reader.GetOrdinal("store_name")) ? null : reader.GetString(reader.GetOrdinal("store_name"));
                                string? payment_info_type = reader.IsDBNull(reader.GetOrdinal("pymt_info_type")) ? null : reader.GetString(reader.GetOrdinal("pymt_info_type"));
                                decimal? total_spent = reader.IsDBNull(reader.GetOrdinal("total_spent")) ? null : reader.GetDecimal(reader.GetOrdinal("total_spent"));


                                if (email == null || item_name == null || store_name == null || payment_info_type == null || total_spent == null)
                                {
                                    closeEventMessageLabel.Text = "Error loading event data";
                                    closeEventMessageLabel.ForeColor = Color.Red;
                                    return results;
                                }

                                report_data newReportData = new report_data(email, item_name, store_name, payment_info_type, (decimal)total_spent, databaseManager);
                                results.Add(newReportData);
                            }
                            return results;
                        }
                        else
                        {
                            Debug.WriteLine("Loading data failed");
                            return results;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing query: {ex.Message}");
                    return results;
                }
            }
        }

        public void FormatDataGridForReport()
        {
            closeEventDataGrid.Columns.Clear();

            if (!closeEventDataGrid.Columns.Any(c => c.MappingName == "email"))
            {
                closeEventDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "email",
                    HeaderText = "User Email",
                });
            }


            // Check for 'item_name' column
            if (!closeEventDataGrid.Columns.Any(c => c.MappingName == "item_name"))
            {
                closeEventDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "item_name",
                    HeaderText = "Item name",
                });
            }

            // Check for 'store_name' column
            if (!closeEventDataGrid.Columns.Any(c => c.MappingName == "store_name"))
            {
                closeEventDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "store_name",
                    HeaderText = "Store Name",
                });
            }

            // Check for 'pymt_info_type' column
            if (!closeEventDataGrid.Columns.Any(c => c.MappingName == "payment_type"))
            {
                closeEventDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "payment_type",
                    HeaderText = "Payment Type",
                });
            }

            // Check for 'stototal_spentre_type' column
            if (!closeEventDataGrid.Columns.Any(c => c.MappingName == "total_spent"))
            {
                closeEventDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "total_spent",
                    HeaderText = "Total Spent",
                });
            }

            closeEventDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;

        }
        private void closeEventCancelButton_Click(object sender, EventArgs e)
        {
            mainForm.InitializeEventManager();
            this.Close();
        }

        public static bool attemptDeleteTicketsForEvent(int event_id, DatabaseManager databaseManager)
        {

            // Generate the SQL query
            string query = Properties.Resource.close_event_DELETE;

            using (var dbConnection = databaseManager.GetConnection())
            {

                try
                {
                    dbConnection.Open();

                    // Start a transaction
                    using (var transaction = dbConnection.BeginTransaction(System.Data.IsolationLevel.Serializable))
                    {
                        try
                        {
                            // Create a command object to execute the query
                            var command = new NpgsqlCommand(query, dbConnection, transaction);

                            // Add parameters to the query
                            command.Parameters.AddWithValue("@eventid", event_id);

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

        private void closeEventCloseButton_Click(object sender, EventArgs e)
        {
            bool deleteResults = attemptDeleteTicketsForEvent(this.selectedEvent.event_id, databaseManager);
            if (deleteResults)
            {
                closeEventMessageLabel.Text = "Successfully deleted event";
                closeEventMessageLabel.ForeColor = Color.Green;
                closeEventCloseButton.Enabled = false;
            }
            else
            {
                closeEventMessageLabel.Text = "Error deleting event";
                closeEventMessageLabel.ForeColor = Color.Red;
                closeEventCloseButton.Enabled = false;
            }
        }

    }
}
