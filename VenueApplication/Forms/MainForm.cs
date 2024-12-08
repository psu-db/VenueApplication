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
using Syncfusion.Windows.Forms.Tools;
using Microsoft.VisualBasic.Logging;

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
        public venue_ticket myTicket_selectedTicket;
        public venue_store manageStores_selectedStore;
        public payment_info selectedPayment;

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
            purchaseItemsTab.TabVisible = false;

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
            InitializeHomePage();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            InitializeProfilePage();
            tabControlAdv1.SelectedTab = profileTab;
        }

        private void ticketWalletButton_Click(object sender, EventArgs e)
        {
            tabControlAdv1.SelectedTab = myTicketsTab;
        }

        #endregion

        #region Methods

        public void InitializeProfilePage(decimal? newBalance = 0)
        {
            firstlastNameLabel.Text = $"{user.user_fname} {user.user_lname}";
            
            if (newBalance != 0)
            {
                
                profileAccountBalanceValueLabel.Text = $"${newBalance.ToString()}";
            }
            else
            {
                profileAccountBalanceValueLabel.Text = $"${user.user_balance.ToString()}";
            }

            decimal new_balance = SelectAccountBalance(LoginForm.USER_ID);
            profileAccountBalanceValueLabel.Text = $"${new_balance.ToString()}";

            List<payment_info> paymentMethods = InitializePaymentMethods();
            paymentMethodsComboBox.DataSource = paymentMethods;

            bool hasAccount = false;

            foreach (var paymentMethod in paymentMethods)
            {
                if (paymentMethod.pymt_info_type == "ACCOUNT")
                {
                    hasAccount = true;
                    break;
                }
            }

            if (!hasAccount)
            {
                NewPaymentMethodService.AttemptAddNewPaymentMethod("ACCOUNT", "0000000000000000", "000", "01/24", "Address 123 Street.", "Pennsylvania", "12345", databaseManager);
                payment_info accountPayment = new payment_info(LoginForm.USER_ID, "ACCOUNT", "0000000000000000", "000", "01/24", "Address 123 Steet.", "Pennsylvania", "12345", databaseManager);
                paymentMethods.Add(accountPayment);
            }


            InitializeUsersSelectedPaymentInfo();
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

        public void InitializeUsersSelectedPaymentInfo()
        {
            if (paymentMethodsComboBox.SelectedItem != null)
            {
                selectedPayment = paymentMethodsComboBox.SelectedItem as payment_info;
            }
            else
            {
                selectedPayment = null;
            }
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
            sfDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
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

        public void FormatDataGridForStoresItemPurchase()
        {
            purhaseItemsStoresDataGrid.Columns.Clear();

            if (!purhaseItemsStoresDataGrid.Columns.Any(c => c.MappingName == "store_name"))
            {
                purhaseItemsStoresDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "store_name",
                    HeaderText = "Store Name",
                });
            }


            // Check for 'store_section_location' column
            if (!purhaseItemsStoresDataGrid.Columns.Any(c => c.MappingName == "store_section_location"))
            {
                purhaseItemsStoresDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "store_section_location",
                    HeaderText = "Section Location",
                });
            }

            // Check for 'store_type' column
            if (!purhaseItemsStoresDataGrid.Columns.Any(c => c.MappingName == "store_type"))
            {
                purhaseItemsStoresDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "store_type",
                    HeaderText = "Store Type",
                });
            }
        }

        public void InitializeEventManager()
        {

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
                                int? pymt_info_id = reader.IsDBNull(reader.GetOrdinal("pymt_info_id")) ? null : reader.GetInt32(reader.GetOrdinal("pymt_info_id"));
                                int? pymt_info_user_id = reader.IsDBNull(reader.GetOrdinal("pymt_info_user_id")) ? null : reader.GetInt32(reader.GetOrdinal("pymt_info_user_id"));
                                string? pymt_info_type = reader.IsDBNull(reader.GetOrdinal("pymt_info_type")) ? null : reader.GetString(reader.GetOrdinal("pymt_info_type"));
                                string? pymt_info_card_number = reader.IsDBNull(reader.GetOrdinal("pymt_info_card_number")) ? null : reader.GetString(reader.GetOrdinal("pymt_info_card_number"));
                                string? pymt_info_card_cvv = reader.IsDBNull(reader.GetOrdinal("pymt_info_card_cvv")) ? null : reader.GetString(reader.GetOrdinal("pymt_info_card_cvv"));
                                string? pymt_info_expiration_date = reader.IsDBNull(reader.GetOrdinal("pymt_info_expiration_date")) ? null : reader.GetString(reader.GetOrdinal("pymt_info_expiration_date"));
                                string? pymt_info_address = reader.IsDBNull(reader.GetOrdinal("pymt_info_address")) ? null : reader.GetString(reader.GetOrdinal("pymt_info_address"));
                                string? pymt_info_address_state = reader.IsDBNull(reader.GetOrdinal("pymt_info_address_state")) ? null : reader.GetString(reader.GetOrdinal("pymt_info_address_state"));
                                string? pymt_info_zipcode = reader.IsDBNull(reader.GetOrdinal("pymt_info_zipcode")) ? null : reader.GetString(reader.GetOrdinal("pymt_info_zipcode"));

                                payment_info paymentMethod = new payment_info((int)pymt_info_id, (int)pymt_info_user_id, pymt_info_type, pymt_info_card_number, pymt_info_card_cvv, pymt_info_expiration_date, pymt_info_address, pymt_info_address_state, pymt_info_zipcode, databaseManager);
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

        private int SelectEventForScannedTickets()
        {
            string query = VenueApplication.Properties.Resource.ticketPurchase_SELECTSCANNED;
            int event_id = 0;
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
                                int? tkt_event_id = reader.IsDBNull(reader.GetOrdinal("tkt_event_id")) ? null : reader.GetInt32(reader.GetOrdinal("tkt_event_id"));
                                //Debug.WriteLine("the returned event id is");
                                //Debug.WriteLine(tkt_event_id);

                                return (int)tkt_event_id;
                            }
                            return event_id;
                        }
                        else
                        {
                            Debug.WriteLine("Initialize tickets for MyTickets failed");
                            return event_id;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing query: {ex.Message}");

                    return event_id;
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
                    InitializeHomePage();
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

            try
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
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        private void homeViewEventTicketsButton_Click(object sender, EventArgs e)
        {
            if (homeViewEventTicketsButton.Text == "View Tickets For Selected Event" && homePage_selectedEvent != null)
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

            bool purchaseTicketStatus = TicketService.AttemptPurchaseTicket(homePage_selectedTicket, this, databaseManager);

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
                myTicketsDataGrid.DataSource = myTickets;

                homePage_selectedTicket = null;


            }
            else
            {
                homePageErrorLabel.Visible = true;
                homePageErrorLabel.Text = "Error while trying to purchase ticket. Please wait and try again.";
            }


        }



        //item purchase tab

        private void refreshItemTable()
        {
            //initialize the table of tickets for the event
            purchaseItemsItemDataGrid.DataSource = null;
            List<venue_item> storeItems = InitializeItemsForStore((venue_store)purhaseItemsStoresDataGrid.SelectedItem);
            purchaseItemsItemDataGrid.AutoGenerateColumns = false;
            FormatDataGridForItems();
            purchaseItemsItemDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            purchaseItemsItemDataGrid.DataSource = storeItems;
        }


        private List<venue_item> InitializeItemsForStore(venue_store venueStore)
        {
            List<venue_item> storeItems = new List<venue_item>();
            string query = VenueApplication.Properties.Resource.item_on_store_SELECT;
            using (var dbConnection = databaseManager.GetConnection())
            {
                // Create a command object to execute the query
                var command = new NpgsqlCommand(query, dbConnection);
                // Add parameters to the query
                command.Parameters.AddWithValue("@itemstoreid", venueStore.store_id);

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
                                int? item_id = reader.IsDBNull(reader.GetOrdinal("item_id")) ? null : reader.GetInt32(reader.GetOrdinal("item_id"));
                                string? item_name = reader.IsDBNull(reader.GetOrdinal("item_name")) ? null : reader.GetString(reader.GetOrdinal("item_name"));
                                decimal? item_price = reader.IsDBNull(reader.GetOrdinal("item_price")) ? null : reader.GetDecimal(reader.GetOrdinal("item_price"));
                                int? item_store_id = reader.IsDBNull(reader.GetOrdinal("item_store_id")) ? null : reader.GetInt32(reader.GetOrdinal("item_store_id"));

                                venue_item returnedItem = new venue_item((int)item_id, item_name, (decimal)item_price, (int)item_store_id, databaseManager);
                                storeItems.Add(returnedItem);
                            }
                            return storeItems;
                        }
                        else
                        {
                            Debug.WriteLine("Initialize items for store failed");
                            return storeItems;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing query: {ex.Message}");
                    return storeItems;
                }
            }
        }

        public void FormatDataGridForItems()
        {

            purchaseItemsItemDataGrid.Columns.Clear();

            if (!purchaseItemsItemDataGrid.Columns.Any(c => c.MappingName == "item_name"))
            {
                purchaseItemsItemDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "item_name",
                    HeaderText = "Item Name",
                });
            }

            // Check for 'item_price' column
            if (!purchaseItemsItemDataGrid.Columns.Any(c => c.MappingName == "item_price"))
            {
                purchaseItemsItemDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "item_price",
                    HeaderText = "Item Price",
                });
            }
            purchaseItemsItemDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;

        }


        private void itemPurchaseControlButton_Click(object sender, EventArgs e)
        {
            refreshStoreItemPurchaseTable();
            purchaseItemsQuantityLabel.Visible = false;
            purchaseItemsItemDataGrid.Visible = false;
            itemPurchaseQuantityTextBox.Visible = false;
            itemPurchasePurchaseButton.Visible = false;
            purchaseItemsPaymentMethodLabel.Visible = false;
            purchseItemsPaymentMethodComboBox.Visible = false;
            tabControlAdv1.SelectedTab = purchaseItemsTab;

        }

        public void refreshStoreItemPurchaseTable()
        {
            manageStoresDataGrid.DataSource = null;
            List<venue_store> venue_stores = InitializeStores();
            purhaseItemsStoresDataGrid.AutoGenerateColumns = false;
            purhaseItemsStoresDataGrid.DataSource = venue_stores;
            FormatDataGridForStoresItemPurchase();
            purhaseItemsStoresDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
        }

        private void purhaseItemsStoresDataGrid_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            purchaseItemsQuantityLabel.Visible = true;
            purchaseItemsItemDataGrid.Visible = true;
            itemPurchaseQuantityTextBox.Visible = true;
            itemPurchasePurchaseButton.Visible = true;
            Debug.WriteLine(purhaseItemsStoresDataGrid.SelectedIndex);
            refreshItemTable();
        }

        private void itemPurchaseCancelButton_Click(object sender, EventArgs e)
        {
            tabControlAdv1.SelectedTab = homeTab;
        }


        private bool updateAccountBalance(int user_id, decimal new_balance)
        {            // Create necessary related objects
            //venue_store newStore = new venue_store(store_id, storeName, storeSectionLocation, storeType, databaseManager);

            // Generate the SQL query
            string query = Properties.Resource.account_balance_UPDATE;

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
                            command.Parameters.AddWithValue("@newbalance", new_balance);
                            command.Parameters.AddWithValue("@userid", user_id);

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
        private void itemPurchasePurchaseButton_Click(object sender, EventArgs e)
        {


            //payment info functionality not started yet
            int trans_pymt_info_id = 0;
            payment_info payment_selection = (payment_info)purchseItemsPaymentMethodComboBox.SelectedItem;
            if (payment_selection != null)
            {
                trans_pymt_info_id = payment_selection.pymt_info_id;
            }
            else
            {
                itemPurchaseMessageLabel.Text = "Please select a payment method";
                itemPurchaseMessageLabel.ForeColor = Color.Red;
                itemPurchaseMessageLabel.Visible = true;
                return;

            }

            //search through my tickets that are scanned to find the event
            int trans_event_id = SelectEventForScannedTickets();

            //set the current time
            DateTime currentTime = DateTime.Now;
            //TimeOnly currentTimeOnly = TimeOnly.FromTimeSpan(currentTime.TimeOfDay);


            //set quantity
            string quantity = itemPurchaseQuantityTextBox.Text;
            int trans_quantity = int.Parse(quantity);

            if (trans_quantity < 1)
            {
                itemPurchaseMessageLabel.Text = "Please provide a quantity";
                itemPurchaseMessageLabel.ForeColor = Color.Red;
                itemPurchaseMessageLabel.Visible = true;
                return;
            }

            int trans_item_id = -1;
            venue_item selectedItem = null;
            if (purchaseItemsItemDataGrid.SelectedItem != null)
            {
                selectedItem = (venue_item)purchaseItemsItemDataGrid.SelectedItem;
                trans_item_id = selectedItem.item_id;
            }
            else
            {
                return;
            }
            if (trans_event_id == 0)
            {
                itemPurchaseMessageLabel.Text = "You must be at an event to purchase";
                itemPurchaseMessageLabel.Visible = true;
                itemPurchaseMessageLabel.ForeColor = Color.Red;
                itemPurchaseMessageLabel.Refresh();
                return;
            }


           

            if (trans_pymt_info_id > 0 && trans_event_id > 0 && trans_quantity > 0 && trans_item_id > 0)
            {

                //check if user used account balance, then check if they have enough in account
                if (payment_selection.pymt_info_type == "ACCOUNT")
                {
                    int user_id = LoginForm.USER_ID;
                    Debug.WriteLine("user Id is");
                    Debug.WriteLine(user_id);

                    decimal currentBalance = SelectAccountBalance(user_id);
                    Debug.WriteLine("current balance is");
                    Debug.WriteLine(currentBalance);
                    decimal costDifference = currentBalance - selectedItem.item_price * trans_quantity;
                    if (costDifference >= 0)
                    {
                        Debug.WriteLine("enough money in account");
                        Debug.WriteLine(costDifference);
                        Debug.WriteLine("updating to");
                        Debug.WriteLine(costDifference);
                        updateAccountBalance(this.user.user_id, costDifference);
                    }
                    else
                    {

                        Debug.WriteLine("broe boy");
                        itemPurchaseMessageLabel.Text = "Your account balance is too low";
                        itemPurchaseMessageLabel.Visible = true;
                        itemPurchaseMessageLabel.ForeColor = Color.Red;
                        return;
                    }
                }

                bool transactionCreateAttempt = TransactionService.AttemptTransactionCreation(trans_pymt_info_id, trans_event_id, currentTime, trans_quantity, trans_item_id, databaseManager);

                if (transactionCreateAttempt)
                {
                    itemPurchaseQuantityTextBox.Text = "1";
                    itemPurchaseMessageLabel.Text = "Successfully purchased item(s)";
                    itemPurchaseMessageLabel.ForeColor = Color.Green;
                    itemPurchaseMessageLabel.Visible = true;
                    itemPurchaseMessageLabel.Refresh();
                    refreshItemTable();
                }
                else
                {
                    itemPurchaseMessageLabel.Text = "An error occured. Please wait and try again.";
                    itemPurchaseMessageLabel.Visible = true;
                    itemPurchaseMessageLabel.ForeColor = Color.Red;
                    itemPurchaseMessageLabel.Refresh();
                }

            }
            else
            {
                itemPurchaseMessageLabel.Text = "All fields must be filled";
                itemPurchaseMessageLabel.Visible = true;
                itemPurchaseMessageLabel.ForeColor = Color.Red;
                itemPurchaseMessageLabel.Refresh();
            }
        }

        private void myTicketsDataGrid_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            myTicket_selectedTicket = (venue_ticket)myTicketsDataGrid.SelectedItem;
        }

        private void sellSelectedTicketButton_Click(object sender, EventArgs e)
        {
            bool sellTicketStatus = TicketService.AttemptSellTicket(myTicket_selectedTicket, databaseManager);

            if (sellTicketStatus)
            {
                myTicketsErrorLabel.Visible = true;
                myTicketsErrorLabel.ForeColor = Color.Green;
                myTicketsErrorLabel.Text = "Successfully listed ticket for sale";

                List<venue_ticket> myTickets = InitializeTicketsForMyTickets();
                FormatDataGridForTickets(myTicketsDataGrid);
                myTicketsDataGrid.DataSource = myTickets;

                InitializeHomePage();
            }
            else
            {
                myTicketsErrorLabel.Visible = true;
                myTicketsErrorLabel.Text = "Error selling ticket. Please try again.";
            }

        }

        private void paymentMethodsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedPayment = paymentMethodsComboBox.SelectedItem as payment_info;
        }

        private void purchaseItemsItemDataGrid_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            purchaseItemsPaymentMethodLabel.Visible = true;
            purchseItemsPaymentMethodComboBox.Visible = true;

            List<payment_info> paymentMethods = InitializePaymentMethods();
            purchseItemsPaymentMethodComboBox.DataSource = paymentMethods;

        }

        private decimal SelectAccountBalance(int user_id)
        {
            int balance = 0;
            string query = VenueApplication.Properties.Resource.account_balance_SELECT;
            using (var dbConnection = databaseManager.GetConnection())
            {
                // Create a command object to execute the query
                var command = new NpgsqlCommand(query, dbConnection);

                // Add parameters to the query
                command.Parameters.AddWithValue("@userid", user_id);

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
                                decimal? user_balance = reader.IsDBNull(reader.GetOrdinal("user_balance")) ? null : reader.GetDecimal(reader.GetOrdinal("user_balance"));
                                return (decimal)user_balance;
                            }
                            return balance;
                        }
                        else
                        {
                            Debug.WriteLine("Initialize tickets for MyTickets failed");
                            return balance;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error executing query: {ex.Message}");

                    return balance;
                }
            }

        }

        private void manageEventCloseEventButton_Click(object sender, EventArgs e)
        {
            if (this.selected_event != null)
            {
                CloseEventForm closeEventForm = new CloseEventForm(this, databaseManager, this.selected_event);
                closeEventForm.Show();
            }
            else
            {
                eventManagerErrorLabel.Text = "Please select an event to continue";
                eventManagerErrorLabel.Visible = true;
            }
        }
    }

}
