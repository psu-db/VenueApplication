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
    public partial class ManageStoreItemsForm : MetroForm
    {

        private MainForm mainForm;
        public DatabaseManager databaseManager;
        private SfDataGrid manageStoreItemsDataGrid;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel manageStoreItemsStoreNameLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt manageStoreItemsNameTextBox;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox manageStoreItemsPriceCurrencyTextBox;
        private IContainer components;
        private Syncfusion.WinForms.Controls.SfButton manageStoreItemsCreateButton;
        private Syncfusion.WinForms.Controls.SfButton manageStoreItemsUpdateButton;
        private Syncfusion.WinForms.Controls.SfButton manageStoreItemsDeleteButton;
        private Syncfusion.WinForms.Controls.SfButton manageStoreItemsCancelButton;
        private Syncfusion.Windows.Forms.Tools.AutoLabel manageStoreItemsMessageLabel;
        public venue_store selectedStore;

        private void InitializeComponent()
        {
            components = new Container();
            manageStoreItemsDataGrid = new SfDataGrid();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            manageStoreItemsStoreNameLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            manageStoreItemsNameTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            manageStoreItemsPriceCurrencyTextBox = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            manageStoreItemsCreateButton = new Syncfusion.WinForms.Controls.SfButton();
            manageStoreItemsUpdateButton = new Syncfusion.WinForms.Controls.SfButton();
            manageStoreItemsDeleteButton = new Syncfusion.WinForms.Controls.SfButton();
            manageStoreItemsCancelButton = new Syncfusion.WinForms.Controls.SfButton();
            manageStoreItemsMessageLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((ISupportInitialize)manageStoreItemsDataGrid).BeginInit();
            ((ISupportInitialize)manageStoreItemsNameTextBox).BeginInit();
            ((ISupportInitialize)manageStoreItemsPriceCurrencyTextBox).BeginInit();
            SuspendLayout();
            // 
            // manageStoreItemsDataGrid
            // 
            manageStoreItemsDataGrid.AccessibleName = "Table";
            manageStoreItemsDataGrid.Location = new Point(145, 121);
            manageStoreItemsDataGrid.Name = "manageStoreItemsDataGrid";
            manageStoreItemsDataGrid.PreviewRowHeight = 49;
            manageStoreItemsDataGrid.Size = new Size(2058, 375);
            manageStoreItemsDataGrid.Style.BorderColor = Color.FromArgb(100, 100, 100);
            manageStoreItemsDataGrid.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(0, 120, 215);
            manageStoreItemsDataGrid.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(0, 120, 215);
            manageStoreItemsDataGrid.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(0, 120, 215);
            manageStoreItemsDataGrid.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(0, 120, 215);
            manageStoreItemsDataGrid.TabIndex = 0;
            manageStoreItemsDataGrid.Text = "sfDataGrid1";
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Segoe UI", 16F);
            autoLabel1.Location = new Point(145, 9);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(332, 51);
            autoLabel1.TabIndex = 1;
            autoLabel1.Text = "Showing items for:";
            // 
            // autoLabel2
            // 
            autoLabel2.Font = new Font("Segoe UI", 16F);
            autoLabel2.Location = new Point(145, 628);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(216, 51);
            autoLabel2.TabIndex = 2;
            autoLabel2.Text = "Item Name:";
            // 
            // manageStoreItemsStoreNameLabel
            // 
            manageStoreItemsStoreNameLabel.Font = new Font("Segoe UI", 16F);
            manageStoreItemsStoreNameLabel.Location = new Point(483, 9);
            manageStoreItemsStoreNameLabel.Name = "manageStoreItemsStoreNameLabel";
            manageStoreItemsStoreNameLabel.Size = new Size(0, 51);
            manageStoreItemsStoreNameLabel.TabIndex = 3;
            // 
            // autoLabel3
            // 
            autoLabel3.Font = new Font("Segoe UI", 16F);
            autoLabel3.Location = new Point(145, 783);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(197, 51);
            autoLabel3.TabIndex = 4;
            autoLabel3.Text = "Item Price:";
            // 
            // manageStoreItemsNameTextBox
            // 
            manageStoreItemsNameTextBox.BeforeTouchSize = new Size(175, 57);
            manageStoreItemsNameTextBox.Font = new Font("Segoe UI", 16F);
            manageStoreItemsNameTextBox.Location = new Point(387, 628);
            manageStoreItemsNameTextBox.Name = "manageStoreItemsNameTextBox";
            manageStoreItemsNameTextBox.Size = new Size(336, 57);
            manageStoreItemsNameTextBox.TabIndex = 5;
            // 
            // manageStoreItemsPriceCurrencyTextBox
            // 
            manageStoreItemsPriceCurrencyTextBox.AccessibilityEnabled = true;
            manageStoreItemsPriceCurrencyTextBox.BeforeTouchSize = new Size(175, 57);
            manageStoreItemsPriceCurrencyTextBox.DecimalValue = new decimal(new int[] { 100, 0, 0, 131072 });
            manageStoreItemsPriceCurrencyTextBox.Font = new Font("Segoe UI", 16F);
            manageStoreItemsPriceCurrencyTextBox.Location = new Point(387, 783);
            manageStoreItemsPriceCurrencyTextBox.Name = "manageStoreItemsPriceCurrencyTextBox";
            manageStoreItemsPriceCurrencyTextBox.Size = new Size(175, 57);
            manageStoreItemsPriceCurrencyTextBox.TabIndex = 6;
            manageStoreItemsPriceCurrencyTextBox.Text = "$1.00";
            // 
            // manageStoreItemsCreateButton
            // 
            manageStoreItemsCreateButton.Font = new Font("Segoe UI Semibold", 16F);
            manageStoreItemsCreateButton.Location = new Point(1234, 933);
            manageStoreItemsCreateButton.Name = "manageStoreItemsCreateButton";
            manageStoreItemsCreateButton.Size = new Size(307, 110);
            manageStoreItemsCreateButton.TabIndex = 7;
            manageStoreItemsCreateButton.Text = "Create";
            manageStoreItemsCreateButton.Click += manageStoreItemsCreateButton_Click;
            // 
            // manageStoreItemsUpdateButton
            // 
            manageStoreItemsUpdateButton.Font = new Font("Segoe UI Semibold", 16F);
            manageStoreItemsUpdateButton.Location = new Point(1594, 933);
            manageStoreItemsUpdateButton.Name = "manageStoreItemsUpdateButton";
            manageStoreItemsUpdateButton.Size = new Size(307, 110);
            manageStoreItemsUpdateButton.TabIndex = 8;
            manageStoreItemsUpdateButton.Text = "Update";
            // 
            // manageStoreItemsDeleteButton
            // 
            manageStoreItemsDeleteButton.Font = new Font("Segoe UI Semibold", 16F);
            manageStoreItemsDeleteButton.Location = new Point(1955, 933);
            manageStoreItemsDeleteButton.Name = "manageStoreItemsDeleteButton";
            manageStoreItemsDeleteButton.Size = new Size(307, 110);
            manageStoreItemsDeleteButton.TabIndex = 9;
            manageStoreItemsDeleteButton.Text = "Delete";
            // 
            // manageStoreItemsCancelButton
            // 
            manageStoreItemsCancelButton.Font = new Font("Segoe UI Semibold", 12F);
            manageStoreItemsCancelButton.Location = new Point(2119, 1098);
            manageStoreItemsCancelButton.Name = "manageStoreItemsCancelButton";
            manageStoreItemsCancelButton.Size = new Size(143, 57);
            manageStoreItemsCancelButton.TabIndex = 10;
            manageStoreItemsCancelButton.Text = "Cancel";
            manageStoreItemsCancelButton.Click += manageStoreItemsCancelButton_Click;
            // 
            // manageStoreItemsMessageLabel
            // 
            manageStoreItemsMessageLabel.Font = new Font("Segoe UI", 16F);
            manageStoreItemsMessageLabel.Location = new Point(145, 974);
            manageStoreItemsMessageLabel.Name = "manageStoreItemsMessageLabel";
            manageStoreItemsMessageLabel.Size = new Size(257, 51);
            manageStoreItemsMessageLabel.TabIndex = 11;
            manageStoreItemsMessageLabel.Text = "message label";
            manageStoreItemsMessageLabel.Visible = false;
            // 
            // ManageStoreItemsForm
            // 
            ClientSize = new Size(2380, 1182);
            Controls.Add(manageStoreItemsMessageLabel);
            Controls.Add(manageStoreItemsCancelButton);
            Controls.Add(manageStoreItemsDeleteButton);
            Controls.Add(manageStoreItemsUpdateButton);
            Controls.Add(manageStoreItemsCreateButton);
            Controls.Add(manageStoreItemsPriceCurrencyTextBox);
            Controls.Add(manageStoreItemsNameTextBox);
            Controls.Add(autoLabel3);
            Controls.Add(manageStoreItemsStoreNameLabel);
            Controls.Add(autoLabel2);
            Controls.Add(autoLabel1);
            Controls.Add(manageStoreItemsDataGrid);
            Name = "ManageStoreItemsForm";
            ((ISupportInitialize)manageStoreItemsDataGrid).EndInit();
            ((ISupportInitialize)manageStoreItemsNameTextBox).EndInit();
            ((ISupportInitialize)manageStoreItemsPriceCurrencyTextBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public ManageStoreItemsForm(MainForm mainForm, DatabaseManager databaseManager, venue_store selectedStore)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.databaseManager = databaseManager;
            this.selectedStore = selectedStore;

            manageStoreItemsStoreNameLabel.Text = this.selectedStore.store_name;
            //refreshItemsTable();

        }
        //private List<venue_item> InitializeItems()
        //{
            //List<venue_item> venue_items = new List<venue_item>();
            //string query = VenueApplication.Properties.Resource.venue_items_for_store_SELECT;

            //using (var dbConnection = databaseManager.GetConnection())
            //{
            //    // Create a command object to execute the query
            //    var command = new NpgsqlCommand(query, dbConnection);

            //    // Add parameters to the query
            //    try
            //    {
            //        dbConnection.Open();

            //        // Execute the query and get a reader to read the results
            //        using (var reader = command.ExecuteReader())
            //        {
            //            // Check if there are any rows (meaning the username/password pair is valid)
            //            if (reader.HasRows)
            //            {
            //                while (reader.Read())
            //                {

            //                    int? item_id = reader.IsDBNull(reader.GetOrdinal("item_id")) ? null : reader.GetInt32(reader.GetOrdinal("item_id"));
            //                    string? item_name = reader.IsDBNull(reader.GetOrdinal("item_name")) ? null : reader.GetString(reader.GetOrdinal("item_name"));
            //                    string? store_section_location = reader.IsDBNull(reader.GetOrdinal("store_section_location")) ? null : reader.GetString(reader.GetOrdinal("store_section_location"));
            //                    string? store_type = reader.IsDBNull(reader.GetOrdinal("store_type")) ? null : reader.GetString(reader.GetOrdinal("store_type"));

            //                    venue_store venueStore = new venue_store((int)store_id, store_name, store_section_location, store_type, databaseManager);
            //                    venue_stores.Add(venueStore);

            //                }

            //                return venue_stores;
            //            }
            //            else
            //            {
            //                Debug.WriteLine("Initialize events failed");
            //                return venue_stores;
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error executing query: {ex.Message}");

            //        return venue_stores;
            //    }
            //}

        //}
        //public void refreshItemsTable()
        //{
        //    manageStoreItemsDataGrid.DataSource = null;
        //    List<venue_item> venue_items = InitializeItems();
        //    manageStoreItemsDataGrid.AutoGenerateColumns = false;
        //    manageStoreItemsDataGrid.DataSource = venue_items;
        //    FormatDataGridForStores();
        //    manageStoreItemsDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
        //}

        private void manageStoreItemsCancelButton_Click(object sender, EventArgs e)
        {
            mainForm.InitializeEventManager();
            this.Close();
        }

        private void manageStoreItemsCreateButton_Click(object sender, EventArgs e)
        {
            string item_name = manageStoreItemsNameTextBox.Text;
            decimal price = manageStoreItemsPriceCurrencyTextBox.DecimalValue;
            int storeIDFK = this.selectedStore.store_id;

            if (item_name != "" && price >= 0 && storeIDFK >= 0)
            {
                bool itemAttemptResult = ItemService.AttemptItemCreation(item_name, price, databaseManager);

                if (itemAttemptResult)
                {
                    //manageTicketsEventNameLabel.Text = "";
                    //manageTicketsCurrencyTextBox.DecimalValue = 1.00m;
                    //manageTicketsSectionComboBoxAdv.Text = "";
                    //manageTicketsErrorLabel.Text = "Successfully inserted event";
                    //manageTicketsErrorLabel.ForeColor = Color.Green;
                    //manageTicketsErrorLabel.Visible = true;
                    //manageTicketsErrorLabel.Refresh();
                }
                else
                {
                    //manageTicketsErrorLabel.Text = "An error occured during the insert process. Please wait and try again.";
                    //manageTicketsErrorLabel.Visible = true;
                    //manageTicketsErrorLabel.Refresh();
                }

            }
            else
            {
                //manageTicketsErrorLabel.Text = "All fields must be filled in order to manage tickets";
                //manageTicketsErrorLabel.Visible = true;
                //manageTicketsErrorLabel.Refresh();
            }
        }






        //private List<venue_ticket> InitializeTicketsForEvent(venue_event venueEvent)
        //{
        //    List<venue_ticket> eventTickets = new List<venue_ticket>();
        //    string query = VenueApplication.Properties.Resource.ticketsForEvent_SELECT;
        //    using (var dbConnection = databaseManager.GetConnection())
        //    {
        //        // Create a command object to execute the query
        //        var command = new NpgsqlCommand(query, dbConnection);
        //        // Add parameters to the query
        //        command.Parameters.AddWithValue("@event_id", venueEvent.event_id);
        //        command.Parameters.AddWithValue("@status1", "SAL");
        //        command.Parameters.AddWithValue("@status2", "RSL");
        //        try
        //        {
        //            dbConnection.Open();
        //            // Execute the query and get a reader to read the results
        //            using (var reader = command.ExecuteReader())
        //            {
        //                // Check if there are any rows (meaning the username/password pair is valid)
        //                if (reader.HasRows)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        int? tkt_id = reader.IsDBNull(reader.GetOrdinal("tkt_id")) ? null : reader.GetInt32(reader.GetOrdinal("tkt_id"));
        //                        int? tkt_event_id = reader.IsDBNull(reader.GetOrdinal("tkt_event_id")) ? null : reader.GetInt32(reader.GetOrdinal("tkt_event_id"));
        //                        string? tkt_section = reader.IsDBNull(reader.GetOrdinal("tkt_section")) ? null : reader.GetString(reader.GetOrdinal("tkt_section"));
        //                        int? tkt_row = reader.IsDBNull(reader.GetOrdinal("tkt_row")) ? null : reader.GetInt32(reader.GetOrdinal("tkt_row"));
        //                        int? tkt_seat_num = reader.IsDBNull(reader.GetOrdinal("tkt_seat_num")) ? null : reader.GetInt32(reader.GetOrdinal("tkt_seat_num"));
        //                        decimal? tkt_price = reader.IsDBNull(reader.GetOrdinal("tkt_price")) ? null : reader.GetDecimal(reader.GetOrdinal("tkt_price"));
        //                        string? tkt_status = reader.IsDBNull(reader.GetOrdinal("tkt_status")) ? null : reader.GetString(reader.GetOrdinal("tkt_status"));
        //                        venue_ticket ticket = new venue_ticket((int)tkt_id, (int)tkt_event_id, tkt_section, (int)tkt_row, (int)tkt_seat_num, (decimal)tkt_price, tkt_status, databaseManager);
        //                        eventTickets.Add(ticket);
        //                    }
        //                    return eventTickets;
        //                }
        //                else
        //                {
        //                    Debug.WriteLine("Initialize tickets for event failed");
        //                    return eventTickets;
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error executing query: {ex.Message}");
        //            return eventTickets;
        //        }
        //    }
        //}

        //public void FormatDataGridForTickets()
        //{

        //    manageTicketsDataGrid.Columns.Clear();

        //    if (!manageTicketsDataGrid.Columns.Any(c => c.MappingName == "tkt_section"))
        //    {
        //        manageTicketsDataGrid.Columns.Add(new GridTextColumn
        //        {
        //            MappingName = "tkt_section",
        //            HeaderText = "Section",
        //        });
        //    }

        //    // Check for 'event_description' column
        //    if (!manageTicketsDataGrid.Columns.Any(c => c.MappingName == "tkt_row"))
        //    {
        //        manageTicketsDataGrid.Columns.Add(new GridTextColumn
        //        {
        //            MappingName = "tkt_row",
        //            HeaderText = "Row",
        //        });
        //    }

        //    // Check for 'event_date' column
        //    if (!manageTicketsDataGrid.Columns.Any(c => c.MappingName == "tkt_seat_num"))
        //    {
        //        manageTicketsDataGrid.Columns.Add(new GridTextColumn
        //        {
        //            MappingName = "tkt_seat_num",
        //            HeaderText = "Seat Number",
        //        });
        //    }

        //    // Check for 'event_time' column
        //    if (!manageTicketsDataGrid.Columns.Any(c => c.MappingName == "tkt_price"))
        //    {
        //        manageTicketsDataGrid.Columns.Add(new GridTextColumn
        //        {
        //            MappingName = "tkt_price",
        //            HeaderText = "Price",
        //        });
        //    }
        //}

        //private void refreshTicketTable()
        //{
        //    //initialize the table of tickets for the event
        //    manageTicketsDataGrid.DataSource = null;
        //    List<venue_ticket> eventTickets = InitializeTicketsForEvent(this.selectedEvent);
        //    manageTicketsDataGrid.AutoGenerateColumns = false;
        //    FormatDataGridForTickets();
        //    manageTicketsDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
        //    manageTicketsDataGrid.DataSource = eventTickets;
        //    manageTicketsErrorLabel.Visible = false;
        //}

        //private void manageTicketsDataGrid_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        //{
        //    this.selectedTicket = (venue_ticket)manageTicketsDataGrid.SelectedItem;
        //}

        //private void manageTicketsDeleteButton_Click(object sender, EventArgs e)
        //{

        //    if (this.selectedTicket == null)
        //    {
        //        manageTicketsErrorLabel.Text = "Select a ticket";
        //        manageTicketsErrorLabel.Visible = true;
        //        return;
        //    }

        //    int ticketID = this.selectedTicket.tkt_id;

        //    if (ticketID != null)
        //    {
        //        bool ticketDeleteAttemptResult = TicketService.AttemptTicketDeletion(ticketID, databaseManager);

        //        if (ticketDeleteAttemptResult)
        //        {

        //            refreshTicketTable();
        //            manageTicketsErrorLabel.Text = "Successfully deleted ticket";
        //            manageTicketsErrorLabel.ForeColor = Color.Green;
        //            manageTicketsErrorLabel.Visible = true;
        //            manageTicketsErrorLabel.Refresh();


        //        }
        //        else
        //        {
        //            manageTicketsErrorLabel.Text = "An error occured during the insert process. Please wait and try again.";
        //            manageTicketsErrorLabel.Visible = true;
        //            manageTicketsErrorLabel.Refresh();
        //        }

        //    }
        //    else
        //    {
        //        manageTicketsErrorLabel.Text = "All fields must be filled in order to manage tickets";
        //        manageTicketsErrorLabel.Visible = true;
        //        manageTicketsErrorLabel.Refresh();
        //    }


        //}
    }
}
