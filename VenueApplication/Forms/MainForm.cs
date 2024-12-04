using VenueApplication.DataAccess;
using Syncfusion.Windows.Forms;
using VenueApplication.Models;
using VenueApplication.Forms;
using VenueApplication.Services;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics;
using Syncfusion.WinForms.DataGrid;

namespace VenueApplication
{
    public partial class MainForm : MetroForm
    {
        public DatabaseManager databaseManager;
        public LoginForm loginForm;
        public app_user user;
        public user_wallet user_wallet;
        public venue_event selected_event;

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
            InitializeEventManager();
            adminToolsTab.TabVisible = false;
            homeTab.TabVisible = false;
            myTicketsTab.TabVisible = false;
            profileTab.TabVisible = false;
            adminToolsSelectionTab.TabVisible = false;
            createNewEventTab.TabVisible = false;
            eventManagerTab.TabVisible = false;

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
            List<payment_info> paymentMethods = InitializePaymentMethods();
            paymentMethodsComboBox.DataSource = paymentMethods;
        }

        public void InitializeEventManager()
        {
            List<venue_event> venue_events = InitializeEvents();
            manageEventDataGrid.AutoGenerateColumns = false;
            manageEventDataGrid.DataSource = venue_events;

            manageEventDataGrid.Columns.Add(new GridTextColumn
            {
                MappingName = "event_type",
                HeaderText = "Event Type",
            });

            manageEventDataGrid.Columns.Add(new GridTextColumn
            {
                MappingName = "event_description",
                HeaderText = "Event Description",
            });

            manageEventDataGrid.Columns.Add(new GridTextColumn
            {
                MappingName = "event_date",
                HeaderText = "Event Date",
                Format = "MM/dd/yyyy" // Optional formatting
            });

            manageEventDataGrid.Columns.Add(new GridTextColumn
            {
                MappingName = "event_time",
                HeaderText = "Event Time",
                Format = "hh\\:mm tt" // Optional formatting
            });
            manageEventDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;

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
                            Debug.WriteLine("Initialize payment methods failed");
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
    }
}
