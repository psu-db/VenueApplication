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
using VenueApplication.DataAccess;
using VenueApplication.Models;
using VenueApplication.Services;


namespace VenueApplication.Forms
{
    public partial class ManageTicketsForm : MetroForm
    {

        private MainForm mainForm;
        public DatabaseManager databaseManager;
        public venue_event selectedEvent;
        public venue_ticket selectedTicket;
        public ManageTicketsForm(MainForm mainForm, DatabaseManager databaseManager, venue_event selectedEvent)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.databaseManager = databaseManager;
            this.selectedEvent = selectedEvent;

            manageTicketsEventNameLabel.Text = this.selectedEvent.event_description;
            refreshTicketTable();

        }

        private void manageTicketsCancelButton_Click(object sender, EventArgs e)
        {
            mainForm.InitializeEventManager();
            this.Close();
        }

        private void manageTicketsCreateButton_Click(object sender, EventArgs e)
        {
            string section = manageTicketsSectionComboBoxAdv.Text;
            decimal price = manageTicketsCurrencyTextBox.DecimalValue;
            int eventIDFK = this.selectedEvent.event_id;
            string ticketStatusCode = "SAL";

            if (section != "" && price >= 0 && eventIDFK >= 0 && ticketStatusCode != "")
            {
                bool ticketInsertAttemptResult = TicketService.AttemptTicketCreation(eventIDFK, section, price, ticketStatusCode, databaseManager);

                if (ticketInsertAttemptResult)
                {
                    manageTicketsEventNameLabel.Text = "";
                    manageTicketsCurrencyTextBox.DecimalValue = 1.00m;
                    manageTicketsSectionComboBoxAdv.Text = "";
                    manageTicketsErrorLabel.Text = "Successfully inserted event";
                    manageTicketsErrorLabel.ForeColor = Color.Green;
                    manageTicketsErrorLabel.Visible = true;
                    manageTicketsErrorLabel.Refresh();
                }
                else
                {
                    manageTicketsErrorLabel.Text = "An error occured during the insert process. Please wait and try again.";
                    manageTicketsErrorLabel.Visible = true;
                    manageTicketsErrorLabel.Refresh();
                }

            }
            else
            {
                manageTicketsErrorLabel.Text = "All fields must be filled in order to manage tickets";
                manageTicketsErrorLabel.Visible = true;
                manageTicketsErrorLabel.Refresh();
            }
        }



        private List<venue_ticket> InitializeTicketsForEvent(venue_event venueEvent)
        {
            List<venue_ticket> eventTickets = new List<venue_ticket>();
            string query = VenueApplication.Properties.Resource.ticketsForEvent_SELECT;
            using (var dbConnection = databaseManager.GetConnection())
            {
                // Create a command object to execute the query
                var command = new NpgsqlCommand(query, dbConnection);
                // Add parameters to the query
                command.Parameters.AddWithValue("@event_id", venueEvent.event_id);
                command.Parameters.AddWithValue("@status1", "SAL");
                command.Parameters.AddWithValue("@status2", "RSL");
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
                                int? tkt_id = reader.IsDBNull(reader.GetOrdinal("tkt_id")) ? null : reader.GetInt32(reader.GetOrdinal("tkt_id"));
                                int? tkt_event_id = reader.IsDBNull(reader.GetOrdinal("tkt_event_id")) ? null : reader.GetInt32(reader.GetOrdinal("tkt_event_id"));
                                string? tkt_section = reader.IsDBNull(reader.GetOrdinal("tkt_section")) ? null : reader.GetString(reader.GetOrdinal("tkt_section"));
                                int? tkt_row = reader.IsDBNull(reader.GetOrdinal("tkt_row")) ? null : reader.GetInt32(reader.GetOrdinal("tkt_row"));
                                int? tkt_seat_num = reader.IsDBNull(reader.GetOrdinal("tkt_seat_num")) ? null : reader.GetInt32(reader.GetOrdinal("tkt_seat_num"));
                                decimal? tkt_price = reader.IsDBNull(reader.GetOrdinal("tkt_price")) ? null : reader.GetDecimal(reader.GetOrdinal("tkt_price"));
                                string? tkt_status = reader.IsDBNull(reader.GetOrdinal("tkt_status")) ? null : reader.GetString(reader.GetOrdinal("tkt_status"));
                                venue_ticket ticket = new venue_ticket((int)tkt_id, (int)tkt_event_id, tkt_section, (int)tkt_row, (int)tkt_seat_num, (decimal)tkt_price, tkt_status, databaseManager);
                                eventTickets.Add(ticket);
                            }
                            return eventTickets;
                        }
                        else
                        {
                            Debug.WriteLine("Initialize tickets for event failed");
                            return eventTickets;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing query: {ex.Message}");
                    return eventTickets;
                }
            }
        }

        public void FormatDataGridForTickets()
        {

            manageTicketsDataGrid.Columns.Clear();

            if (!manageTicketsDataGrid.Columns.Any(c => c.MappingName == "tkt_section"))
            {
                manageTicketsDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "tkt_section",
                    HeaderText = "Section",
                });
            }

            // Check for 'event_description' column
            if (!manageTicketsDataGrid.Columns.Any(c => c.MappingName == "tkt_row"))
            {
                manageTicketsDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "tkt_row",
                    HeaderText = "Row",
                });
            }

            // Check for 'event_date' column
            if (!manageTicketsDataGrid.Columns.Any(c => c.MappingName == "tkt_seat_num"))
            {
                manageTicketsDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "tkt_seat_num",
                    HeaderText = "Seat Number",
                });
            }

            // Check for 'event_time' column
            if (!manageTicketsDataGrid.Columns.Any(c => c.MappingName == "tkt_price"))
            {
                manageTicketsDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "tkt_price",
                    HeaderText = "Price",
                });
            }
        }

        private void refreshTicketTable()
        {
            //initialize the table of tickets for the event
            manageTicketsDataGrid.DataSource = null;
            List<venue_ticket> eventTickets = InitializeTicketsForEvent(this.selectedEvent);
            manageTicketsDataGrid.AutoGenerateColumns = false;
            FormatDataGridForTickets();
            manageTicketsDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            manageTicketsDataGrid.DataSource = eventTickets;
            manageTicketsErrorLabel.Visible = false;
        }

        private void manageTicketsDataGrid_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            this.selectedTicket = (venue_ticket)manageTicketsDataGrid.SelectedItem;
        }

        private void manageTicketsDeleteButton_Click(object sender, EventArgs e)
        {

            if (this.selectedTicket == null)
            {
                manageTicketsErrorLabel.Text = "Select a ticket";
                manageTicketsErrorLabel.Visible = true;
                return;
            }

            int ticketID = this.selectedTicket.tkt_id;

            if (ticketID != null)
            {
                bool ticketDeleteAttemptResult = TicketService.AttemptTicketDeletion(ticketID, databaseManager);

                if (ticketDeleteAttemptResult)
                {

                    refreshTicketTable();
                    manageTicketsErrorLabel.Text = "Successfully deleted ticket";
                    manageTicketsErrorLabel.ForeColor = Color.Green;
                    manageTicketsErrorLabel.Visible = true;
                    manageTicketsErrorLabel.Refresh();


                }
                else
                {
                    manageTicketsErrorLabel.Text = "An error occured during the insert process. Please wait and try again.";
                    manageTicketsErrorLabel.Visible = true;
                    manageTicketsErrorLabel.Refresh();
                }

            }
            else
            {
                manageTicketsErrorLabel.Text = "All fields must be filled in order to manage tickets";
                manageTicketsErrorLabel.Visible = true;
                manageTicketsErrorLabel.Refresh();
            }


        }
    }
}
