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
        private Panel panel1;
        public venue_item selectedItem;

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
            panel1 = new Panel();
            ((ISupportInitialize)manageStoreItemsDataGrid).BeginInit();
            ((ISupportInitialize)manageStoreItemsNameTextBox).BeginInit();
            ((ISupportInitialize)manageStoreItemsPriceCurrencyTextBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // manageStoreItemsDataGrid
            // 
            manageStoreItemsDataGrid.AccessibleName = "Table";
            manageStoreItemsDataGrid.AllowEditing = false;
            manageStoreItemsDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            manageStoreItemsDataGrid.Location = new Point(58, 69);
            manageStoreItemsDataGrid.Name = "manageStoreItemsDataGrid";
            manageStoreItemsDataGrid.PreviewRowHeight = 49;
            manageStoreItemsDataGrid.Size = new Size(769, 307);
            manageStoreItemsDataGrid.Style.BorderColor = Color.FromArgb(100, 100, 100);
            manageStoreItemsDataGrid.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(0, 120, 215);
            manageStoreItemsDataGrid.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(0, 120, 215);
            manageStoreItemsDataGrid.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(0, 120, 215);
            manageStoreItemsDataGrid.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(0, 120, 215);
            manageStoreItemsDataGrid.TabIndex = 0;
            manageStoreItemsDataGrid.Text = "sfDataGrid1";
            manageStoreItemsDataGrid.SelectionChanged += manageStoreItemsDataGrid_SelectionChanged;
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Segoe UI", 16F);
            autoLabel1.Location = new Point(58, 9);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(193, 30);
            autoLabel1.TabIndex = 1;
            autoLabel1.Text = "Showing items for:";
            // 
            // autoLabel2
            // 
            autoLabel2.Font = new Font("Segoe UI", 16F);
            autoLabel2.Location = new Point(23, 29);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(126, 30);
            autoLabel2.TabIndex = 2;
            autoLabel2.Text = "Item Name:";
            // 
            // manageStoreItemsStoreNameLabel
            // 
            manageStoreItemsStoreNameLabel.Font = new Font("Segoe UI", 16F);
            manageStoreItemsStoreNameLabel.Location = new Point(245, 9);
            manageStoreItemsStoreNameLabel.Name = "manageStoreItemsStoreNameLabel";
            manageStoreItemsStoreNameLabel.Size = new Size(0, 30);
            manageStoreItemsStoreNameLabel.TabIndex = 3;
            // 
            // autoLabel3
            // 
            autoLabel3.Font = new Font("Segoe UI", 16F);
            autoLabel3.Location = new Point(23, 99);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(115, 30);
            autoLabel3.TabIndex = 4;
            autoLabel3.Text = "Item Price:";
            // 
            // manageStoreItemsNameTextBox
            // 
            manageStoreItemsNameTextBox.BeforeTouchSize = new Size(175, 36);
            manageStoreItemsNameTextBox.Font = new Font("Segoe UI", 16F);
            manageStoreItemsNameTextBox.Location = new Point(155, 29);
            manageStoreItemsNameTextBox.Name = "manageStoreItemsNameTextBox";
            manageStoreItemsNameTextBox.Size = new Size(336, 36);
            manageStoreItemsNameTextBox.TabIndex = 5;
            // 
            // manageStoreItemsPriceCurrencyTextBox
            // 
            manageStoreItemsPriceCurrencyTextBox.AccessibilityEnabled = true;
            manageStoreItemsPriceCurrencyTextBox.BeforeTouchSize = new Size(175, 36);
            manageStoreItemsPriceCurrencyTextBox.DecimalValue = new decimal(new int[] { 100, 0, 0, 131072 });
            manageStoreItemsPriceCurrencyTextBox.Font = new Font("Segoe UI", 16F);
            manageStoreItemsPriceCurrencyTextBox.Location = new Point(144, 99);
            manageStoreItemsPriceCurrencyTextBox.Name = "manageStoreItemsPriceCurrencyTextBox";
            manageStoreItemsPriceCurrencyTextBox.Size = new Size(175, 36);
            manageStoreItemsPriceCurrencyTextBox.TabIndex = 6;
            manageStoreItemsPriceCurrencyTextBox.Text = "$1.00";
            // 
            // manageStoreItemsCreateButton
            // 
            manageStoreItemsCreateButton.Font = new Font("Segoe UI Semibold", 16F);
            manageStoreItemsCreateButton.Location = new Point(26, 170);
            manageStoreItemsCreateButton.Name = "manageStoreItemsCreateButton";
            manageStoreItemsCreateButton.Size = new Size(193, 56);
            manageStoreItemsCreateButton.TabIndex = 7;
            manageStoreItemsCreateButton.Text = "Create";
            manageStoreItemsCreateButton.Click += manageStoreItemsCreateButton_Click;
            // 
            // manageStoreItemsUpdateButton
            // 
            manageStoreItemsUpdateButton.Font = new Font("Segoe UI Semibold", 16F);
            manageStoreItemsUpdateButton.Location = new Point(245, 170);
            manageStoreItemsUpdateButton.Name = "manageStoreItemsUpdateButton";
            manageStoreItemsUpdateButton.Size = new Size(193, 56);
            manageStoreItemsUpdateButton.TabIndex = 8;
            manageStoreItemsUpdateButton.Text = "Update";
            manageStoreItemsUpdateButton.Click += manageStoreItemsUpdateButton_Click;
            // 
            // manageStoreItemsDeleteButton
            // 
            manageStoreItemsDeleteButton.Font = new Font("Segoe UI Semibold", 16F);
            manageStoreItemsDeleteButton.Location = new Point(1955, 933);
            manageStoreItemsDeleteButton.Name = "manageStoreItemsDeleteButton";
            manageStoreItemsDeleteButton.Size = new Size(307, 110);
            manageStoreItemsDeleteButton.TabIndex = 9;
            manageStoreItemsDeleteButton.Text = "Delete";
            manageStoreItemsDeleteButton.Click += manageStoreItemsDeleteButton_Click;
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
            manageStoreItemsMessageLabel.Size = new Size(150, 30);
            manageStoreItemsMessageLabel.TabIndex = 11;
            manageStoreItemsMessageLabel.Text = "message label";
            manageStoreItemsMessageLabel.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(autoLabel2);
            panel1.Controls.Add(autoLabel3);
            panel1.Controls.Add(manageStoreItemsNameTextBox);
            panel1.Controls.Add(manageStoreItemsPriceCurrencyTextBox);
            panel1.Controls.Add(manageStoreItemsUpdateButton);
            panel1.Controls.Add(manageStoreItemsCreateButton);
            panel1.Location = new Point(58, 382);
            panel1.Name = "panel1";
            panel1.Size = new Size(545, 238);
            panel1.TabIndex = 12;
            // 
            // ManageStoreItemsForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(852, 632);
            Controls.Add(panel1);
            Controls.Add(manageStoreItemsMessageLabel);
            Controls.Add(manageStoreItemsCancelButton);
            Controls.Add(manageStoreItemsDeleteButton);
            Controls.Add(manageStoreItemsStoreNameLabel);
            Controls.Add(autoLabel1);
            Controls.Add(manageStoreItemsDataGrid);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ManageStoreItemsForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((ISupportInitialize)manageStoreItemsDataGrid).EndInit();
            ((ISupportInitialize)manageStoreItemsNameTextBox).EndInit();
            ((ISupportInitialize)manageStoreItemsPriceCurrencyTextBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        public ManageStoreItemsForm(MainForm mainForm, DatabaseManager databaseManager, venue_store selectedStore)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.databaseManager = databaseManager;
            this.selectedStore = selectedStore;
            this.selectedItem = null;

            manageStoreItemsStoreNameLabel.Text = this.selectedStore.store_name;
            refreshItemTable();
            manageStoreItemsDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;

        }

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

            if (item_name != "" && price > 0 && storeIDFK >= 0)
            {
                bool itemAttemptResult = ItemService.AttemptItemCreation(item_name, price, storeIDFK, databaseManager);

                if (itemAttemptResult)
                {
                    manageStoreItemsNameTextBox.Text = "";
                    manageStoreItemsPriceCurrencyTextBox.Text = "1.00";

                    manageStoreItemsMessageLabel.Text = "Successfully inserted item";
                    manageStoreItemsMessageLabel.ForeColor = Color.Green;
                    manageStoreItemsMessageLabel.Visible = true;
                    manageStoreItemsMessageLabel.Refresh();
                    refreshItemTable();
                    this.selectedItem = null;
                }
                else
                {
                    manageStoreItemsMessageLabel.Text = "An error occured during the insert process. Please wait and try again.";
                    manageStoreItemsMessageLabel.Visible = true;
                    manageStoreItemsMessageLabel.ForeColor = Color.Red;
                    manageStoreItemsMessageLabel.Refresh();
                }

            }
            else
            {
                manageStoreItemsMessageLabel.Text = "All fields must be filled";
                manageStoreItemsMessageLabel.Visible = true;
                manageStoreItemsMessageLabel.ForeColor = Color.Red;
                manageStoreItemsMessageLabel.Refresh();
            }
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
                    Debug.WriteLine($"Error executing query: {ex.Message}");
                    return storeItems;
                }
            }
        }

        public void FormatDataGridForItems()
        {

            manageStoreItemsDataGrid.Columns.Clear();

            if (!manageStoreItemsDataGrid.Columns.Any(c => c.MappingName == "item_name"))
            {
                manageStoreItemsDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "item_name",
                    HeaderText = "Item Name",
                });
            }

            // Check for 'item_price' column
            if (!manageStoreItemsDataGrid.Columns.Any(c => c.MappingName == "item_price"))
            {
                manageStoreItemsDataGrid.Columns.Add(new GridTextColumn
                {
                    MappingName = "item_price",
                    HeaderText = "Item Price",
                });
            }

        }

        private void refreshItemTable()
        {
            //initialize the table of tickets for the event
            manageStoreItemsDataGrid.DataSource = null;
            List<venue_item> storeItems = InitializeItemsForStore(this.selectedStore);
            manageStoreItemsDataGrid.AutoGenerateColumns = false;
            FormatDataGridForItems();
            manageStoreItemsDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            manageStoreItemsDataGrid.DataSource = storeItems;
        }

        private void manageStoreItemsDataGrid_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            this.selectedItem = (venue_item)manageStoreItemsDataGrid.SelectedItem;
            manageStoreItemsNameTextBox.Text = this.selectedItem.item_name;
            manageStoreItemsPriceCurrencyTextBox.DecimalValue = this.selectedItem.item_price;

            manageStoreItemsMessageLabel.Visible = false;
        }

        private void manageStoreItemsDeleteButton_Click(object sender, EventArgs e)
        {
            if (this.selectedItem == null)
            {
                manageStoreItemsMessageLabel.Text = "Select an item";
                manageStoreItemsMessageLabel.ForeColor = Color.Red;
                manageStoreItemsMessageLabel.Visible = true;
                return;
            }

            int itemID = this.selectedItem.item_id;

            if (itemID != null)
            {
                bool itemDeleteAttemptResult = ItemService.AttemptItemDeletion(itemID, databaseManager);

                if (itemDeleteAttemptResult)
                {

                    refreshItemTable();
                    manageStoreItemsMessageLabel.Text = "Successfully deleted item";
                    manageStoreItemsMessageLabel.ForeColor = Color.Green;
                    manageStoreItemsMessageLabel.Visible = true;
                    manageStoreItemsMessageLabel.Refresh();
                    this.selectedItem = null;
                    manageStoreItemsNameTextBox.Text = "";
                    manageStoreItemsPriceCurrencyTextBox.Text = "1.00";


                }
                else
                {
                    manageStoreItemsMessageLabel.Text = "An error occured. Please wait and try again.";
                    manageStoreItemsMessageLabel.Visible = true;
                    manageStoreItemsMessageLabel.ForeColor = Color.Red;
                    manageStoreItemsMessageLabel.Refresh();
                }

            }
            else
            {
                manageStoreItemsMessageLabel.Text = "All fields must be filled";
                manageStoreItemsMessageLabel.Visible = true;
                manageStoreItemsMessageLabel.Refresh();
                manageStoreItemsMessageLabel.ForeColor = Color.Red;
            }
        }

        private void manageStoreItemsUpdateButton_Click(object sender, EventArgs e)
        {
            string itemName = manageStoreItemsNameTextBox.Text;
            decimal itemPrice = manageStoreItemsPriceCurrencyTextBox.DecimalValue;
            if (this.selectedItem == null)
            {
                manageStoreItemsMessageLabel.Text = "Select an item";
                manageStoreItemsMessageLabel.ForeColor = Color.Red;
                manageStoreItemsMessageLabel.Visible = true;
                return;
            }
            int itemId = this.selectedItem.item_id;
            int storeId = this.selectedStore.store_id;


            if (itemName != null && itemPrice > 0 && itemId > 0)
            {

                bool updateEventResults = ItemService.AttemptItemUpdate(itemId, itemName, itemPrice, storeId, databaseManager);

                if (updateEventResults)
                {
                    manageStoreItemsNameTextBox.Text = "";
                    manageStoreItemsPriceCurrencyTextBox.DecimalValue = 1.00m;
                    manageStoreItemsMessageLabel.Text = "Successfully updated item";
                    manageStoreItemsMessageLabel.ForeColor = Color.Green;
                    manageStoreItemsMessageLabel.Visible = true;
                    manageStoreItemsMessageLabel.Refresh();
                    refreshItemTable();
                }
                else
                {
                    manageStoreItemsMessageLabel.Text = "An error occured. Please wait and try again.";
                    manageStoreItemsMessageLabel.Visible = true;
                    manageStoreItemsMessageLabel.Refresh();
                }


            }
            else
            {
                manageStoreItemsMessageLabel.Text = "All fields must be filled";
                manageStoreItemsMessageLabel.Visible = true;
                manageStoreItemsMessageLabel.Refresh();
            }
        }
    }
}
