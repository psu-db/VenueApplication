using VenueApplication.DataAccess;
using Syncfusion.Windows.Forms;
using VenueApplication.Models;
using VenueApplication.Forms;
using VenueApplication.Services;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics;
using Syncfusion.WinForms.DataGrid;
using Microsoft.Extensions.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VenueApplication
{
    public partial class MainForm : MetroForm
    {
        public DatabaseManager databaseManager;
        public LoginForm loginForm;
        public app_user user;
        public user_wallet user_wallet;
        public venue_event selected_event;
        public venue_event homePage_selectedEvent;
        public venue_ticket homePage_selectedTicket;
        public venue_store manageStores_selectedStore;
        public MainForm(app_user user, user_wallet user_wallet, LoginForm loginForm, DatabaseManager databaseManager)
        {
            InitializeComponent();
            this.databaseManager = databaseManager;
            this.loginForm = loginForm;
            this.user = user;
            this.user_wallet = user_wallet;
        }

        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeProfilePage();
            InitializeHomePage();
            InitializeEventManager();

            List<venue_ticket> myTickets = InitializeTicketsForMyTickets();
            FormatDataGridForTickets(myTicketsDataGrid);
            myTicketsDataGrid.DataSource = myTickets;

            adminToolsTab.TabVisible = false;
            homeTab.TabVisible = false;
            myTicketsTab.TabVisible = false;
            profileTab.TabVisible = false;
            adminToolsSelectionTab.TabVisible = false;
            createNewEventTab.TabVisible = false;
            eventManagerTab.TabVisible = false;
            manageStoresTab.TabVisible = false;

            tabControlAdv1.SelectedTab = homeTab;

            if (user.user_type == "ADMIN")
            {
                adminControlsButton.Visible = true;
                adminControlsButton.Enabled = true;

            }
            else
            {
                adminControlsButton.Visible = false;
                adminControlsButton.Enabled = false;
            }
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }

        private void addNewPaymentMethodButton_Click(object sender, EventArgs e)
        {
            addNewPaymentMethodButton.Enabled = false;
            PaymentMethodForm paymentMethodForm = new PaymentMethodForm(this, databaseManager);
            paymentMethodForm.Show();
        }

        private void switchToCreateNewEventTabButton_Click(object sender, EventArgs e)
        {
            tabControlAdv2.SelectedTab = createNewEventTab;
        }

        private void eventManagerButton_Click(object sender, EventArgs e)
        {
            tabControlAdv2.SelectedTab = eventManagerTab;
        }

        private void adminControlsButton_Click(object sender, EventArgs e)
        {
            tabControlAdv1.SelectedTab = adminToolsTab;
            tabControlAdv2.SelectedTab = adminToolsSelectionTab;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            tabControlAdv1.SelectedTab = homeTab;
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            tabControlAdv1.SelectedTab = profileTab;
        }

        private void ticketWalletButton_Click(object sender, EventArgs e)
        {
            tabControlAdv1.SelectedTab = myTicketsTab;
        }

        #endregion

        #region Methods

        public void InitializeProfilePage()
        {
            firstlastNameLabel.Text = $"{user.user_fname} {user.user_lname}";
            profileAccountBalanceValueLabel.Text = $"${user.user_balance.ToString()}";
            List<payment_info> paymentMethods = InitializePaymentMethods();
            paymentMethodsComboBox.DataSource = paymentMethods;
        }

        public void InitializeHomePage()
        {
            homePageEventsDataGrid.DataSource = null;
            List<venue_event> venue_events = InitializeEvents();
            homePageEventsDataGrid.AutoGenerateColumns = false;
            homePageEventsDataGrid.DataSource = venue_events;


            FormatDataGridForEvents();
            homePageEventsDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.homePage_selectedEvent = null;

        }

        public void FormatDataGridForEvents()
        {
            homePageEventsDataGrid.Columns.Clear();

            if (!homePageEventsDataGrid.Columns.Any(c => c.MappingName == "event_type"))
            {
                homePageEventsDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "event_type",
                    HeaderText = "Event Type",
                });
            }

            // Check for 'event_description' column
            if (!homePageEventsDataGrid.Columns.Any(c => c.MappingName == "event_description"))
            {
                homePageEventsDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "event_description",
                    HeaderText = "Event Description",
                });
            }

            // Check for 'event_date' column
            if (!homePageEventsDataGrid.Columns.Any(c => c.MappingName == "event_date"))
            {
                homePageEventsDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "event_date",
                    HeaderText = "Event Date",
                    Format = "MM/dd/yyyy" // Optional formatting
                });
            }

            // Check for 'event_time' column
            if (!homePageEventsDataGrid.Columns.Any(c => c.MappingName == "event_time"))
            {
                homePageEventsDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "event_time",
                    HeaderText = "Event Time",
                    Format = "hh\\:mm tt" // Optional formatting
                });
            }
        }

        public void FormatDataGridForTickets(SfDataGrid sfDataGrid)
        {

            sfDataGrid.Columns.Clear();

            if (!sfDataGrid.Columns.Any(c => c.MappingName == "tkt_section"))
            {
                sfDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "tkt_section",
                    HeaderText = "Section",
                });
            }

            // Check for 'event_description' column
            if (!sfDataGrid.Columns.Any(c => c.MappingName == "tkt_row"))
            {
                sfDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "tkt_row",
                    HeaderText = "Row",
                });
            }

            // Check for 'event_date' column
            if (!sfDataGrid.Columns.Any(c => c.MappingName == "tkt_seat_num"))
            {
                sfDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "tkt_seat_num",
                    HeaderText = "Seat Number",
                });
            }

            // Check for 'event_time' column
            if (!sfDataGrid.Columns.Any(c => c.MappingName == "tkt_price"))
            {
                sfDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "tkt_price",
                    HeaderText = "Price",
                });
            }

            // Check for 'event_time' column
            if (!sfDataGrid.Columns.Any(c => c.MappingName == "tkt_status"))
            {
                sfDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "tkt_status",
                    HeaderText = "Type",
                });
            }
        }

        public void FormatDataGridForStores()
        {
            manageStoresDataGrid.Columns.Clear();

            if (!manageStoresDataGrid.Columns.Any(c => c.MappingName == "store_name"))
            {
                manageStoresDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "store_name",
                    HeaderText = "Store Name",
                });
            }

            // Check for 'store_section_location' column
            if (!manageStoresDataGrid.Columns.Any(c => c.MappingName == "store_section_location"))
            {
                manageStoresDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "store_section_location",
                    HeaderText = "Section Location",
                });
            }

            // Check for 'store_type' column
            if (!manageStoresDataGrid.Columns.Any(c => c.MappingName == "store_type"))
            {
                manageStoresDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "store_type",
                    HeaderText = "Store Type",
                });
            }
        }
        public void InitializeEventManager()
        {

            manageEventDataGrid.DataSource = null;
            List<venue_event> venue_events = InitializeEvents();
            manageEventDataGrid.AutoGenerateColumns = false;
            manageEventDataGrid.DataSource = venue_events;


            if (!manageEventDataGrid.Columns.Any(c => c.MappingName == "event_type"))
            {
                manageEventDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "event_type",
                    HeaderText = "Event Type",
                });
            }

            // Check for 'event_description' column
            if (!manageEventDataGrid.Columns.Any(c => c.MappingName == "event_description"))
            {
                manageEventDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "event_description",
                    HeaderText = "Event Description",
                });
            }

            // Check for 'event_date' column
            if (!manageEventDataGrid.Columns.Any(c => c.MappingName == "event_date"))
            {
                manageEventDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "event_date",
                    HeaderText = "Event Date",
                    Format = "MM/dd/yyyy" // Optional formatting
                });
            }

            // Check for 'event_time' column
            if (!manageEventDataGrid.Columns.Any(c => c.MappingName == "event_time"))
            {
                manageEventDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "event_time",
                    HeaderText = "Event Time",
                    Format = "hh\\:mm tt" // Optional formatting
                });
            }
            manageEventDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.selected_event = null;
            eventManagerErrorLabel.Visible = false;
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

        private List<venue_ticket> InitializeTicketsForMyTickets()
        {
            List<venue_ticket> myTickets = new List<venue_ticket>();

            string query = VenueApplication.Properties.Resource.ticketPurchase_SELECT;

            using (var dbConnection = databaseManager.GetConnection())
            {
                // Create a command object to execute the query
                var command = new NpgsqlCommand(query, dbConnection);

                // Add parameters to the query
                command.Parameters.AddWithValue("@wallet_id", LoginForm.USER_WALLET_ID);

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
                                myTickets.Add(ticket);
                            }

                            return myTickets;
                        }
                        else
                        {
                            Debug.WriteLine("Initialize tickets for MyTickets failed");
                            return myTickets;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing query: {ex.Message}");

                    return myTickets;
                }
            }

        }

        private List<payment_info> InitializePaymentMethods()
        {
            List<payment_info> paymentMethods = new List<payment_info>();

            string query = VenueApplication.Properties.Resource.paymentMethods_SELECT;

            using (var dbConnection = databaseManager.GetConnection())
            {
                // Create a command object to execute the query
                var command = new NpgsqlCommand(query, dbConnection);

                // Add parameters to the query
                command.Parameters.AddWithValue("@user_id", LoginForm.USER_ID);

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
                                int? pymt_info_user_id = reader.IsDBNull(reader.GetOrdinal("pymt_info_user_id")) ? null : reader.GetInt32(reader.GetOrdinal("pymt_info_user_id"));
                                string? pymt_info_type = reader.IsDBNull(reader.GetOrdinal("pymt_info_type")) ? null : reader.GetString(reader.GetOrdinal("pymt_info_type"));
                                string? pymt_info_card_number = reader.IsDBNull(reader.GetOrdinal("pymt_info_card_number")) ? null : reader.GetString(reader.GetOrdinal("pymt_info_card_number"));
                                string? pymt_info_card_cvv = reader.IsDBNull(reader.GetOrdinal("pymt_info_card_cvv")) ? null : reader.GetString(reader.GetOrdinal("pymt_info_card_cvv"));
                                string? pymt_info_expiration_date = reader.IsDBNull(reader.GetOrdinal("pymt_info_expiration_date")) ? null : reader.GetString(reader.GetOrdinal("pymt_info_expiration_date"));
                                string? pymt_info_address = reader.IsDBNull(reader.GetOrdinal("pymt_info_address")) ? null : reader.GetString(reader.GetOrdinal("pymt_info_address"));
                                string? pymt_info_address_state = reader.IsDBNull(reader.GetOrdinal("pymt_info_address_state")) ? null : reader.GetString(reader.GetOrdinal("pymt_info_address_state"));
                                string? pymt_info_zipcode = reader.IsDBNull(reader.GetOrdinal("pymt_info_zipcode")) ? null : reader.GetString(reader.GetOrdinal("pymt_info_zipcode"));

                                payment_info paymentMethod = new payment_info((int)pymt_info_user_id, pymt_info_type, pymt_info_card_number, pymt_info_card_cvv, pymt_info_expiration_date, pymt_info_address, pymt_info_address_state, pymt_info_zipcode, databaseManager);
                                paymentMethods.Add(paymentMethod);
                            }

                            return paymentMethods;
                        }
                        else
                        {
                            Debug.WriteLine("Initialize payment methods failed");
                            return paymentMethods;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing query: {ex.Message}");

                    return paymentMethods;
                }
            }

        }

        private List<venue_event> InitializeEvents()
        {
            List<venue_event> venue_events = new List<venue_event>();

            string query = VenueApplication.Properties.Resource.venue_events_SELECT;

            using (var dbConnection = databaseManager.GetConnection())
            {
                // Create a command object to execute the query
                var command = new NpgsqlCommand(query, dbConnection);

                // Add parameters to the query
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

                                int? event_id = reader.IsDBNull(reader.GetOrdinal("event_id")) ? null : reader.GetInt32(reader.GetOrdinal("event_id"));
                                DateTime? event_date = reader.IsDBNull(reader.GetOrdinal("event_date")) ? null : reader.GetDateTime(reader.GetOrdinal("event_date"));
                                TimeSpan? event_time = reader.IsDBNull(reader.GetOrdinal("event_time")) ? null : reader.GetTimeSpan(reader.GetOrdinal("event_time"));
                                string? event_type = reader.IsDBNull(reader.GetOrdinal("event_type")) ? null : reader.GetString(reader.GetOrdinal("event_type"));
                                string? event_description = reader.IsDBNull(reader.GetOrdinal("event_description")) ? null : reader.GetString(reader.GetOrdinal("event_description"));

                                DateOnly? eventDateOnly = null;
                                TimeOnly? eventTimeOnly = null;

                                if (event_time.HasValue)
                                {
                                    // Convert DateTime to DateOnly
                                    eventTimeOnly = TimeOnly.FromTimeSpan(event_time.Value);
                                }


                                if (event_date.HasValue)
                                {
                                    // Convert DateTime to DateOnly
                                    eventDateOnly = DateOnly.FromDateTime(event_date.Value);
                                }

                                venue_event venueEvent = new venue_event((int)event_id, eventDateOnly, (TimeOnly)eventTimeOnly, event_type, event_description, databaseManager);
                                venue_events.Add(venueEvent);

                            }

                            return venue_events;
                        }
                        else
                        {
                            Debug.WriteLine("Initialize events failed");
                            return venue_events;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing query: {ex.Message}");

                    return venue_events;
                }
            }

        }

        private List<venue_store> InitializeStores()
        {
            List<venue_store> venue_stores = new List<venue_store>();

            string query = VenueApplication.Properties.Resource.venue_stores_SELECT;

            using (var dbConnection = databaseManager.GetConnection())
            {
                // Create a command object to execute the query
                var command = new NpgsqlCommand(query, dbConnection);

                // Add parameters to the query
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

                                int? store_id = reader.IsDBNull(reader.GetOrdinal("store_id")) ? null : reader.GetInt32(reader.GetOrdinal("store_id"));
                                string? store_name = reader.IsDBNull(reader.GetOrdinal("store_name")) ? null : reader.GetString(reader.GetOrdinal("store_name"));
                                string? store_section_location = reader.IsDBNull(reader.GetOrdinal("store_section_location")) ? null : reader.GetString(reader.GetOrdinal("store_section_location"));
                                string? store_type = reader.IsDBNull(reader.GetOrdinal("store_type")) ? null : reader.GetString(reader.GetOrdinal("store_type"));

                                venue_store venueStore = new venue_store((int)store_id, store_name, store_section_location, store_type, databaseManager);
                                venue_stores.Add(venueStore);

                            }

                            return venue_stores;
                        }
                        else
                        {
                            Debug.WriteLine("Initialize events failed");
                            return venue_stores;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing query: {ex.Message}");

                    return venue_stores;
                }
            }

        }


        public void refreshStoresTable()
        {
            manageStoresDataGrid.DataSource = null;
            List<venue_store> venue_stores = InitializeStores();
            manageStoresDataGrid.AutoGenerateColumns = false;
            manageStoresDataGrid.DataSource = venue_stores;
            FormatDataGridForStores();
            manageStoresDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
        }

        public void EnableAddNewPaymentButton()
        {
            addNewPaymentMethodButton.Enabled = true;
        }

        #endregion


        private void createEventCancelButton_Click(object sender, EventArgs e)
        {
            tabControlAdv2.SelectedTab = adminToolsSelectionTab;
            createEventErrorLabel.Visible = false;
        }

        private void createEventCreateButton_Click(object sender, EventArgs e)
        {
            string eventHour = createEventHourComboDropDown.Text;
            string eventMinute = createEventMinuteComboDropDown.Text;
            string eventAMPM = createEventAMPMComboDropDown.Text;
            string eventType = createEventTypeComboDropDown.Text;
            string eventDescription = createEventDescriptionTextBox.Text;
            DateTime? eventDate = createEventCalendar.SelectedDate;
            DateOnly? eventDateOnly = null;

            if (eventDate.HasValue)
            {
                // Convert DateTime to DateOnly
                eventDateOnly = DateOnly.FromDateTime(eventDate.Value);

                // Convert DateOnly to string in the correct format (YYYY-MM-DD)
            }

            if (eventDateOnly != null && eventHour != "" && eventMinute != "" && eventAMPM != "" && eventType != "" && eventDescription != "")
            {

                string buildTime = eventHour + ":" + eventMinute + " " + eventAMPM;
                TimeOnly parsedTime = TimeOnly.Parse(buildTime);
                //string time24Hour = parsedTime.ToString("HH:mm");
                //Debug.WriteLine(time24Hour);

                bool createEventResults = NewEventService.AttemptEventCreation(eventDateOnly, parsedTime, eventType, eventDescription, databaseManager);

                if (createEventResults)
                {
                    createEventHourComboDropDown.Text = "";
                    createEventMinuteComboDropDown.Text = "";
                    createEventAMPMComboDropDown.Text = "";
                    createEventTypeComboDropDown.Text = "";
                    createEventDescriptionTextBox.Text = "";
                    createEventErrorLabel.Text = "Successfully inserted event";
                    createEventErrorLabel.ForeColor = Color.Green;
                    createEventErrorLabel.Visible = true;
                    createEventErrorLabel.Refresh();
                    InitializeEventManager();
                }
                else
                {
                    createEventErrorLabel.Text = "An error occured during the sign up process. Please wait and try again.";
                    createEventErrorLabel.Visible = true;
                    createEventErrorLabel.Refresh();
                }


            }
            else
            {
                createEventErrorLabel.Text = "All fields must be filled in order to create an event";
                createEventErrorLabel.Visible = true;
                createEventErrorLabel.Refresh();
            }
        }

        private void createNewEventTab_Leave(object sender, EventArgs e)
        {
            createEventErrorLabel.Visible = false;
        }

        private void manageEventCancelButton_Click(object sender, EventArgs e)
        {
            tabControlAdv2.SelectedTab = adminToolsSelectionTab;
        }

        private void manageEventDataGrid_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            this.selected_event = (venue_event)manageEventDataGrid.SelectedItem;

        }

        private void manageEventEditEventButton_Click(object sender, EventArgs e)
        {

            if (this.selected_event != null)
            {
                EditEventForm editEventForm = new EditEventForm(this, databaseManager, this.selected_event);
                editEventForm.Show();
            }
            else
            {
                eventManagerErrorLabel.Text = "Please select an event to continue";
                eventManagerErrorLabel.Visible = true;
            }

        }

        private void manageEventManageTicketsButton_Click(object sender, EventArgs e)
        {
            if (this.selected_event != null)
            {
                ManageTicketsForm manageTicketsForm = new ManageTicketsForm(this, databaseManager, this.selected_event);
                manageTicketsForm.Show();
            }
            else
            {
                eventManagerErrorLabel.Text = "Please select an event to continue";
                eventManagerErrorLabel.Visible = true;
            }
        }

        private void homePageEventsDataGrid_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            if (homeViewEventTicketsButton.Text == "View Tickets For Selected Event")
            {
                homePage_selectedEvent = (venue_event)homePageEventsDataGrid.SelectedItem;
            }
            else
            {
                homePage_selectedTicket = (venue_ticket)homePageEventsDataGrid.SelectedItem;
            }

        }

        private void homeViewEventTicketsButton_Click(object sender, EventArgs e)
        {
            if (homeViewEventTicketsButton.Text == "View Tickets For Selected Event")
            {
                List<venue_ticket> eventTickets = InitializeTicketsForEvent(homePage_selectedEvent);
                FormatDataGridForTickets(homePageEventsDataGrid);
                homePageEventsDataGrid.DataSource = eventTickets;

                homePagePurchaseTicketButton.Enabled = true;
                homePagePurchaseTicketButton.Visible = true;
                homePageErrorLabel.Visible = false;
                homeViewEventTicketsButton.Text = "Return To Event View";
                //homePage_selectedEvent = null;
            }
            else
            {
                InitializeHomePage();
                //switch datasource back to available events

                homePagePurchaseTicketButton.Enabled = false;
                homePagePurchaseTicketButton.Visible = false;


                if (homeViewEventTicketsButton.Text == "Return To Event View")
                {
                    //homePageErrorLabel.Text = "Select an event to view available tickets";
                    homePageErrorLabel.Visible = false;
                    homeViewEventTicketsButton.Text = "View Tickets For Selected Event";
                }
                else
                {
                    homePageErrorLabel.Visible = true;
                }

            }
        }

        private void manageEventScanTicketsButton_Click(object sender, EventArgs e)
        {
            if (this.selected_event != null)
            {
                ScanTicketForm scanTicketForm = new ScanTicketForm(this, databaseManager, this.selected_event);
                scanTicketForm.Show();
            }
            else
            {
                eventManagerErrorLabel.Text = "Please select an event to continue";
                eventManagerErrorLabel.Visible = true;
            }
        }

        private void manageStoresButton_Click(object sender, EventArgs e)
        {
            //swtich to the manage stores tab
            tabControlAdv2.SelectedTab = manageStoresTab;

            //initialize/refresh the stores table
            refreshStoresTable();
        }

        private void manageStoresDataGrid_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            this.manageStores_selectedStore = (venue_store)manageStoresDataGrid.SelectedItem;

            string store_name = this.manageStores_selectedStore.store_name;
            string store_location = this.manageStores_selectedStore.store_section_location;
            string store_type = this.manageStores_selectedStore.store_type;

            manageStoreNameTextBox.Text = store_name;
            manageStoreLocationComboBox.Text = store_location;
            manageStoreTypeComboBox.SelectedItem = store_type;


        }

        private void manageStoresCancelButton_Click(object sender, EventArgs e)
        {
            tabControlAdv2.SelectedTab = adminToolsSelectionTab;
            manageStoresLabel.Visible = false;
            this.manageStores_selectedStore = null;
        }


        public void manage_store_successul_reset()
        {
            manageStoreNameTextBox.Text = "";
            manageStoreLocationComboBox.Text = "";
            manageStoreTypeComboBox.Text = "";
            manageStoresLabel.ForeColor = Color.Green;
            manageStoresLabel.Visible = true;
            manageStoresLabel.Refresh();
            refreshStoresTable();
        }

        private void manage_store_fail_reset()
        {
            manageStoresLabel.Visible = true;
            manageStoresLabel.ForeColor = Color.Red;
            manageStoresLabel.Refresh();
        }

        private void manageStoresCreateButton_Click(object sender, EventArgs e)
        {

            //read the fields from the form
            string storeName = manageStoreNameTextBox.Text;
            string storeLocation = manageStoreLocationComboBox.Text;
            string storeType = manageStoreTypeComboBox.Text;



            if (storeName != null && storeLocation != "" && storeType != "")
            {
                bool createStoreResults = StoreService.AttemptStoreCreation(storeName, storeLocation, storeType, databaseManager);

                if (createStoreResults)
                {
                    manage_store_successul_reset();
                    manageStoresLabel.Text = "Successfully inserted store";
                }
                else
                {
                    manageStoresLabel.Text = "An error occured during the store creation process. Please wait and try again.";
                    manage_store_fail_reset();
                }


            }
            else
            {
                manageStoresLabel.Text = "All fields must be filled in order to create a store";
                manage_store_fail_reset();
            }
        }

        private void managStoresUpdateButton_Click(object sender, EventArgs e)
        {
            if (this.manageStores_selectedStore == null)
            {
                manageStoresLabel.Text = "Please select a store to update";
                manage_store_fail_reset();
                return;
            }


            string store_name = manageStoreNameTextBox.Text;
            string store_location = manageStoreLocationComboBox.Text;
            string store_type = manageStoreTypeComboBox.Text;

            int store_id = this.manageStores_selectedStore.store_id;


            if (store_name != null && store_location != "" && store_type != "")
            {

                bool updateStoreResults = StoreService.AttemptStoreUpdate(store_id, store_name, store_location, store_type, databaseManager);

                if (updateStoreResults)
                {
                    manage_store_successul_reset();
                    manageStoresLabel.Text = "Successfully updated store";
                }
                else
                {
                    manageStoresLabel.Text = "An error occured during the update process. Please wait and try again.";
                    manage_store_fail_reset();
                }


            }
            else
            {
                manageStoresLabel.Text = "All fields must be filled in order to update an event";
                manage_store_fail_reset();
            }


        }

        private void managStoresEditItemsButton_Click(object sender, EventArgs e)
        {
            if (this.manageStores_selectedStore == null)
            {
                manageStoresLabel.Text = "Please select a store to update";
                manage_store_fail_reset();
                return;
            }

            int store_id = this.manageStores_selectedStore.store_id;


            if (store_id >= 0)
            {

                //open up the manageItems form
                ManageStoreItemsForm manageStoreItemsForm = new ManageStoreItemsForm(this, databaseManager, this.manageStores_selectedStore);
                manageStoreItemsForm.Show();
                //popuate the items table to show all items for the selected event

            }
            else
            {
                manageStoresLabel.Text = "All fields must be filled in order to update an event";
                manage_store_fail_reset();
            }
        }

        private void manageStoresDeleteButton_Click(object sender, EventArgs e)
        {
            if (this.manageStores_selectedStore == null)
            {
                manageStoresLabel.Text = "Select a store";
                manageStoresLabel.Visible = true;
                manageStoresLabel.ForeColor = Color.Red;
                return;
            }

            int storeID = this.manageStores_selectedStore.store_id;

            if (storeID != null)
            {
                bool storeDeleteAttemptResult = StoreService.AttemptStoreDeletion(storeID, databaseManager);

                if (storeDeleteAttemptResult)
                {

                    refreshStoresTable();
                    manageStoresLabel.Text = "Successfully deleted store";
                    manageStoresLabel.ForeColor = Color.Green;
                    manageStoresLabel.Visible = true;
                    manageStoresLabel.Refresh();


                }
                else
                {
                    manageStoresLabel.Text = "An error occured during the insert process. Please wait and try again.";
                    manageStoresLabel.Visible = true;
                    manageStoresLabel.Refresh();
                }

            }
            else
            {
                manageStoresLabel.Text = "select a store first";
                manageStoresLabel.Visible = true;
                manageStoresLabel.Refresh();
            }
        }

        private void homePagePurchaseTicketButton_Click(object sender, EventArgs e)
        {
            if (homePage_selectedTicket == null)
            {
                homePageErrorLabel.Visible = true;
                homePageErrorLabel.Text = "You must select a ticket in order to purchase";

                return;
            }

            bool purchaseTicketStatus = TicketService.AttemptPurchaseTicket(homePage_selectedTicket, databaseManager);

            if (purchaseTicketStatus)
            {
                homePageErrorLabel.Visible = true;
                homePageErrorLabel.Text = "Successfully purchased ticket. You can now find your ticket in the \"My Tickets\" section.";
                homePageErrorLabel.ForeColor = Color.Green;

                // refresh tickets in Home Tab
                List<venue_ticket> eventTickets = InitializeTicketsForEvent(homePage_selectedEvent);
                FormatDataGridForTickets(homePageEventsDataGrid);
                homePageEventsDataGrid.DataSource = eventTickets;

                // refresh tickets in MyTickets Tab
                List<venue_ticket> myTickets = InitializeTicketsForMyTickets();
                FormatDataGridForTickets(myTicketsDataGrid);
                myTicketsDataGrid.DataSource = eventTickets;

                homePage_selectedTicket = null;


            }
            else
            {
                homePageErrorLabel.Visible = true;
                homePageErrorLabel.Text = "Error while trying to purchase ticket. Please wait and try again.";
            }


        }
    }
}
