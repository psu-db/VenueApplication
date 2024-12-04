﻿namespace VenueApplication
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            adminControlsButton = new Syncfusion.WinForms.Controls.SfButton();
            homeButton = new Syncfusion.WinForms.Controls.SfButton();
            profileButton = new Syncfusion.WinForms.Controls.SfButton();
            ticketWalletButton = new Syncfusion.WinForms.Controls.SfButton();
            dockingClientPanel1 = new Syncfusion.Windows.Forms.Tools.DockingClientPanel();
            tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            homeTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            adminToolsTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            tabControlAdv2 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            adminToolsSelectionTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            eventManagerButton = new Syncfusion.WinForms.Controls.SfButton();
            switchToCreateNewEventTabButton = new Syncfusion.WinForms.Controls.SfButton();
            createNewEventTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            createEventTypeComboDropDown = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            createEventAMPMComboDropDown = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            createEventMinuteComboDropDown = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            createEventHourComboDropDown = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            createEventColonLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            createEventCreateButton = new Syncfusion.WinForms.Controls.SfButton();
            createEventCancelButton = new Syncfusion.WinForms.Controls.SfButton();
            createEventErrorLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            createEventDescriptionTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            createEventCalendar = new Syncfusion.WinForms.Input.SfCalendar();
            createEventDescriptionLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            createEventTypeLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            createEventTimeLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            createEventDateLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            createEventButton = new Syncfusion.WinForms.Controls.SfButton();
            eventManagerTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            manageEventCloseEventButton = new Syncfusion.WinForms.Controls.SfButton();
            manageEventScanTicketsButton = new Syncfusion.WinForms.Controls.SfButton();
            manageEventManageTicketsButton = new Syncfusion.WinForms.Controls.SfButton();
            manageEventEditEventButton = new Syncfusion.WinForms.Controls.SfButton();
            manageEventCancelButton = new Syncfusion.WinForms.Controls.SfButton();
            manageEventDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            myTicketsTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            sfButton2 = new Syncfusion.WinForms.Controls.SfButton();
            profileTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            addNewPaymentMethodButton = new Syncfusion.WinForms.Controls.SfButton();
            paymentMethodsLabel = new Label();
            paymentMethodsComboBox = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            signOutButton = new Syncfusion.WinForms.Controls.SfButton();
            firstlastNameLabel = new Label();
            pictureBox1 = new PictureBox();
            eventManagerErrorLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabControlAdv1).BeginInit();
            tabControlAdv1.SuspendLayout();
            adminToolsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabControlAdv2).BeginInit();
            tabControlAdv2.SuspendLayout();
            adminToolsSelectionTab.SuspendLayout();
            createNewEventTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)createEventTypeComboDropDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)createEventAMPMComboDropDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)createEventMinuteComboDropDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)createEventHourComboDropDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)createEventDescriptionTextBox).BeginInit();
            eventManagerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)manageEventDataGrid).BeginInit();
            myTicketsTab.SuspendLayout();
            profileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)paymentMethodsComboBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 1576);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(adminControlsButton, 0, 3);
            tableLayoutPanel1.Controls.Add(homeButton, 0, 0);
            tableLayoutPanel1.Controls.Add(profileButton, 0, 1);
            tableLayoutPanel1.Controls.Add(ticketWalletButton, 0, 2);
            tableLayoutPanel1.Location = new Point(5, 140);
            tableLayoutPanel1.Margin = new Padding(5, 6, 5, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(267, 356);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // adminControlsButton
            // 
            adminControlsButton.Dock = DockStyle.Fill;
            adminControlsButton.Enabled = false;
            adminControlsButton.Font = new Font("Segoe UI Semibold", 9F);
            adminControlsButton.Location = new Point(5, 273);
            adminControlsButton.Margin = new Padding(5, 6, 5, 6);
            adminControlsButton.Name = "adminControlsButton";
            adminControlsButton.Size = new Size(278, 77);
            adminControlsButton.TabIndex = 1;
            adminControlsButton.Text = "Admin Tools";
            adminControlsButton.Visible = false;
            adminControlsButton.Click += adminControlsButton_Click;
            // 
            // homeButton
            // 
            homeButton.Dock = DockStyle.Fill;
            homeButton.Font = new Font("Segoe UI Semibold", 9F);
            homeButton.ImageAlign = ContentAlignment.MiddleRight;
            homeButton.Location = new Point(5, 6);
            homeButton.Margin = new Padding(5, 6, 5, 6);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(278, 77);
            homeButton.TabIndex = 0;
            homeButton.Text = "Home";
            homeButton.Click += homeButton_Click;
            // 
            // profileButton
            // 
            profileButton.Dock = DockStyle.Fill;
            profileButton.Font = new Font("Segoe UI Semibold", 9F);
            profileButton.Location = new Point(5, 95);
            profileButton.Margin = new Padding(5, 6, 5, 6);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(278, 77);
            profileButton.TabIndex = 1;
            profileButton.Text = "Profile";
            profileButton.Click += profileButton_Click;
            // 
            // ticketWalletButton
            // 
            ticketWalletButton.Dock = DockStyle.Fill;
            ticketWalletButton.Font = new Font("Segoe UI Semibold", 9F);
            ticketWalletButton.Location = new Point(5, 184);
            ticketWalletButton.Margin = new Padding(5, 6, 5, 6);
            ticketWalletButton.Name = "ticketWalletButton";
            ticketWalletButton.Size = new Size(278, 77);
            ticketWalletButton.TabIndex = 2;
            ticketWalletButton.Text = "My Tickets";
            ticketWalletButton.Click += ticketWalletButton_Click;
            // 
            // dockingClientPanel1
            // 
            dockingClientPanel1.Location = new Point(1277, 1078);
            dockingClientPanel1.Margin = new Padding(5, 6, 5, 6);
            dockingClientPanel1.Name = "dockingClientPanel1";
            dockingClientPanel1.Size = new Size(39, 22);
            dockingClientPanel1.TabIndex = 1;
            // 
            // tabControlAdv1
            // 
            tabControlAdv1.BeforeTouchSize = new Size(2233, 1576);
            tabControlAdv1.Controls.Add(homeTab);
            tabControlAdv1.Controls.Add(adminToolsTab);
            tabControlAdv1.Controls.Add(myTicketsTab);
            tabControlAdv1.Controls.Add(profileTab);
            tabControlAdv1.Dock = DockStyle.Fill;
            tabControlAdv1.Location = new Point(343, 0);
            tabControlAdv1.Margin = new Padding(5, 6, 5, 6);
            tabControlAdv1.Name = "tabControlAdv1";
            tabControlAdv1.Size = new Size(2233, 1576);
            tabControlAdv1.TabIndex = 2;
            // 
            // homeTab
            // 
            homeTab.Image = null;
            homeTab.ImageSize = new Size(16, 16);
            homeTab.Location = new Point(1, 43);
            homeTab.Margin = new Padding(5, 6, 5, 6);
            homeTab.Name = "homeTab";
            homeTab.ShowCloseButton = true;
            homeTab.Size = new Size(2230, 1531);
            homeTab.TabIndex = 1;
            homeTab.Text = "Home";
            homeTab.ThemesEnabled = false;
            // 
            // adminToolsTab
            // 
            adminToolsTab.Controls.Add(tabControlAdv2);
            adminToolsTab.Image = null;
            adminToolsTab.ImageSize = new Size(16, 16);
            adminToolsTab.Location = new Point(1, 43);
            adminToolsTab.Margin = new Padding(5, 6, 5, 6);
            adminToolsTab.Name = "adminToolsTab";
            adminToolsTab.ShowCloseButton = true;
            adminToolsTab.Size = new Size(2230, 1531);
            adminToolsTab.TabIndex = 4;
            adminToolsTab.Text = "Admin Tools";
            adminToolsTab.ThemesEnabled = false;
            // 
            // tabControlAdv2
            // 
            tabControlAdv2.BeforeTouchSize = new Size(2230, 1531);
            tabControlAdv2.Controls.Add(adminToolsSelectionTab);
            tabControlAdv2.Controls.Add(createNewEventTab);
            tabControlAdv2.Controls.Add(eventManagerTab);
            tabControlAdv2.Dock = DockStyle.Fill;
            tabControlAdv2.Location = new Point(0, 0);
            tabControlAdv2.Margin = new Padding(5, 6, 5, 6);
            tabControlAdv2.Name = "tabControlAdv2";
            tabControlAdv2.Size = new Size(2230, 1531);
            tabControlAdv2.TabIndex = 0;
            // 
            // adminToolsSelectionTab
            // 
            adminToolsSelectionTab.Controls.Add(eventManagerButton);
            adminToolsSelectionTab.Controls.Add(switchToCreateNewEventTabButton);
            adminToolsSelectionTab.Image = null;
            adminToolsSelectionTab.ImageSize = new Size(16, 16);
            adminToolsSelectionTab.Location = new Point(1, 43);
            adminToolsSelectionTab.Margin = new Padding(5, 6, 5, 6);
            adminToolsSelectionTab.Name = "adminToolsSelectionTab";
            adminToolsSelectionTab.ShowCloseButton = true;
            adminToolsSelectionTab.Size = new Size(2227, 1485);
            adminToolsSelectionTab.TabIndex = 1;
            adminToolsSelectionTab.Text = "Admin Tool Selection";
            adminToolsSelectionTab.ThemesEnabled = false;
            // 
            // eventManagerButton
            // 
            eventManagerButton.Font = new Font("Segoe UI Semibold", 9F);
            eventManagerButton.Location = new Point(1822, 490);
            eventManagerButton.Margin = new Padding(5, 6, 5, 6);
            eventManagerButton.Name = "eventManagerButton";
            eventManagerButton.Size = new Size(643, 656);
            eventManagerButton.TabIndex = 1;
            eventManagerButton.Text = "Manage Existing Event";
            eventManagerButton.Click += eventManagerButton_Click;
            // 
            // switchToCreateNewEventTabButton
            // 
            switchToCreateNewEventTabButton.Font = new Font("Segoe UI Semibold", 9F);
            switchToCreateNewEventTabButton.Location = new Point(670, 490);
            switchToCreateNewEventTabButton.Margin = new Padding(5, 6, 5, 6);
            switchToCreateNewEventTabButton.Name = "switchToCreateNewEventTabButton";
            switchToCreateNewEventTabButton.Size = new Size(643, 656);
            switchToCreateNewEventTabButton.TabIndex = 0;
            switchToCreateNewEventTabButton.Text = "Create New Event";
            switchToCreateNewEventTabButton.Click += switchToCreateNewEventTabButton_Click;
            // 
            // createNewEventTab
            // 
            createNewEventTab.Controls.Add(createEventTypeComboDropDown);
            createNewEventTab.Controls.Add(createEventAMPMComboDropDown);
            createNewEventTab.Controls.Add(createEventMinuteComboDropDown);
            createNewEventTab.Controls.Add(createEventHourComboDropDown);
            createNewEventTab.Controls.Add(createEventColonLabel);
            createNewEventTab.Controls.Add(createEventCreateButton);
            createNewEventTab.Controls.Add(createEventCancelButton);
            createNewEventTab.Controls.Add(createEventErrorLabel);
            createNewEventTab.Controls.Add(createEventDescriptionTextBox);
            createNewEventTab.Controls.Add(createEventCalendar);
            createNewEventTab.Controls.Add(createEventDescriptionLabel);
            createNewEventTab.Controls.Add(createEventTypeLabel);
            createNewEventTab.Controls.Add(createEventTimeLabel);
            createNewEventTab.Controls.Add(createEventDateLabel);
            createNewEventTab.Controls.Add(createEventButton);
            createNewEventTab.Image = null;
            createNewEventTab.ImageSize = new Size(16, 16);
            createNewEventTab.Location = new Point(1, 43);
            createNewEventTab.Margin = new Padding(5, 6, 5, 6);
            createNewEventTab.Name = "createNewEventTab";
            createNewEventTab.ShowCloseButton = true;
            createNewEventTab.Size = new Size(2227, 1485);
            createNewEventTab.TabIndex = 2;
            createNewEventTab.Text = "Create New Event";
            createNewEventTab.ThemesEnabled = false;
            createNewEventTab.Leave += createNewEventTab_Leave;
            // 
            // createEventTypeComboDropDown
            // 
            createEventTypeComboDropDown.BeforeTouchSize = new Size(212, 53);
            createEventTypeComboDropDown.Font = new Font("Segoe UI", 14F);
            createEventTypeComboDropDown.Items.AddRange(new object[] { "Football", "Concert", "Other" });
            createEventTypeComboDropDown.Location = new Point(491, 796);
            createEventTypeComboDropDown.Name = "createEventTypeComboDropDown";
            createEventTypeComboDropDown.Size = new Size(212, 53);
            createEventTypeComboDropDown.TabIndex = 20;
            // 
            // createEventAMPMComboDropDown
            // 
            createEventAMPMComboDropDown.BeforeTouchSize = new Size(106, 53);
            createEventAMPMComboDropDown.Font = new Font("Segoe UI", 14F);
            createEventAMPMComboDropDown.Items.AddRange(new object[] { "AM", "PM" });
            createEventAMPMComboDropDown.Location = new Point(801, 602);
            createEventAMPMComboDropDown.Name = "createEventAMPMComboDropDown";
            createEventAMPMComboDropDown.Size = new Size(106, 53);
            createEventAMPMComboDropDown.TabIndex = 19;
            // 
            // createEventMinuteComboDropDown
            // 
            createEventMinuteComboDropDown.BeforeTouchSize = new Size(103, 53);
            createEventMinuteComboDropDown.Font = new Font("Segoe UI", 14F);
            createEventMinuteComboDropDown.Items.AddRange(new object[] { "00", "15", "30", "45" });
            createEventMinuteComboDropDown.Location = new Point(660, 602);
            createEventMinuteComboDropDown.Name = "createEventMinuteComboDropDown";
            createEventMinuteComboDropDown.Size = new Size(103, 53);
            createEventMinuteComboDropDown.TabIndex = 18;
            // 
            // createEventHourComboDropDown
            // 
            createEventHourComboDropDown.BeforeTouchSize = new Size(108, 53);
            createEventHourComboDropDown.Font = new Font("Segoe UI", 14F);
            createEventHourComboDropDown.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            createEventHourComboDropDown.Location = new Point(491, 602);
            createEventHourComboDropDown.Name = "createEventHourComboDropDown";
            createEventHourComboDropDown.Size = new Size(108, 53);
            createEventHourComboDropDown.TabIndex = 17;
            // 
            // createEventColonLabel
            // 
            createEventColonLabel.Font = new Font("Segoe UI", 14F);
            createEventColonLabel.Location = new Point(617, 602);
            createEventColonLabel.Name = "createEventColonLabel";
            createEventColonLabel.Size = new Size(27, 45);
            createEventColonLabel.TabIndex = 16;
            createEventColonLabel.Text = ":";
            // 
            // createEventCreateButton
            // 
            createEventCreateButton.Font = new Font("Segoe UI Semibold", 9F);
            createEventCreateButton.Location = new Point(1761, 1078);
            createEventCreateButton.Name = "createEventCreateButton";
            createEventCreateButton.Size = new Size(194, 82);
            createEventCreateButton.TabIndex = 11;
            createEventCreateButton.Text = "Create";
            createEventCreateButton.Click += createEventCreateButton_Click;
            // 
            // createEventCancelButton
            // 
            createEventCancelButton.Font = new Font("Segoe UI Semibold", 9F);
            createEventCancelButton.Location = new Point(1499, 1078);
            createEventCancelButton.Name = "createEventCancelButton";
            createEventCancelButton.Size = new Size(189, 82);
            createEventCancelButton.TabIndex = 10;
            createEventCancelButton.Text = "Cancel";
            createEventCancelButton.Click += createEventCancelButton_Click;
            // 
            // createEventErrorLabel
            // 
            createEventErrorLabel.Font = new Font("Segoe UI", 16F);
            createEventErrorLabel.ForeColor = Color.Red;
            createEventErrorLabel.Location = new Point(102, 1133);
            createEventErrorLabel.Name = "createEventErrorLabel";
            createEventErrorLabel.Size = new Size(414, 51);
            createEventErrorLabel.TabIndex = 9;
            createEventErrorLabel.Text = "Create event error label";
            createEventErrorLabel.Visible = false;
            // 
            // createEventDescriptionTextBox
            // 
            createEventDescriptionTextBox.BeforeTouchSize = new Size(640, 45);
            createEventDescriptionTextBox.Font = new Font("Segoe UI", 12F);
            createEventDescriptionTextBox.Location = new Point(491, 992);
            createEventDescriptionTextBox.Name = "createEventDescriptionTextBox";
            createEventDescriptionTextBox.Size = new Size(640, 45);
            createEventDescriptionTextBox.TabIndex = 8;
            // 
            // createEventCalendar
            // 
            createEventCalendar.Location = new Point(439, 54);
            createEventCalendar.Name = "createEventCalendar";
            createEventCalendar.Size = new Size(679, 406);
            createEventCalendar.TabIndex = 5;
            createEventCalendar.Text = "sfCalendar1";
            // 
            // createEventDescriptionLabel
            // 
            createEventDescriptionLabel.Font = new Font("Segoe UI", 16F);
            createEventDescriptionLabel.Location = new Point(73, 979);
            createEventDescriptionLabel.Name = "createEventDescriptionLabel";
            createEventDescriptionLabel.Size = new Size(323, 51);
            createEventDescriptionLabel.TabIndex = 4;
            createEventDescriptionLabel.Text = "Event Description:";
            // 
            // createEventTypeLabel
            // 
            createEventTypeLabel.Font = new Font("Segoe UI", 16F);
            createEventTypeLabel.Location = new Point(182, 796);
            createEventTypeLabel.Name = "createEventTypeLabel";
            createEventTypeLabel.Size = new Size(210, 51);
            createEventTypeLabel.TabIndex = 3;
            createEventTypeLabel.Text = "Event Type:";
            // 
            // createEventTimeLabel
            // 
            createEventTimeLabel.Font = new Font("Segoe UI", 16F);
            createEventTimeLabel.Location = new Point(182, 596);
            createEventTimeLabel.Name = "createEventTimeLabel";
            createEventTimeLabel.Size = new Size(214, 51);
            createEventTimeLabel.TabIndex = 2;
            createEventTimeLabel.Text = "Event Time:";
            // 
            // createEventDateLabel
            // 
            createEventDateLabel.Font = new Font("Segoe UI", 16F);
            createEventDateLabel.Location = new Point(185, 197);
            createEventDateLabel.Name = "createEventDateLabel";
            createEventDateLabel.Size = new Size(211, 51);
            createEventDateLabel.TabIndex = 1;
            createEventDateLabel.Text = "Event Date:";
            // 
            // createEventButton
            // 
            createEventButton.Font = new Font("Segoe UI Semibold", 9F);
            createEventButton.Location = new Point(2470, 1400);
            createEventButton.Margin = new Padding(5, 6, 5, 6);
            createEventButton.Name = "createEventButton";
            createEventButton.Size = new Size(262, 124);
            createEventButton.TabIndex = 0;
            createEventButton.Text = "Create Event";
            // 
            // eventManagerTab
            // 
            eventManagerTab.Controls.Add(eventManagerErrorLabel);
            eventManagerTab.Controls.Add(manageEventCloseEventButton);
            eventManagerTab.Controls.Add(manageEventScanTicketsButton);
            eventManagerTab.Controls.Add(manageEventManageTicketsButton);
            eventManagerTab.Controls.Add(manageEventEditEventButton);
            eventManagerTab.Controls.Add(manageEventCancelButton);
            eventManagerTab.Controls.Add(manageEventDataGrid);
            eventManagerTab.Image = null;
            eventManagerTab.ImageSize = new Size(16, 16);
            eventManagerTab.Location = new Point(1, 43);
            eventManagerTab.Margin = new Padding(5, 6, 5, 6);
            eventManagerTab.Name = "eventManagerTab";
            eventManagerTab.ShowCloseButton = true;
            eventManagerTab.Size = new Size(2227, 1485);
            eventManagerTab.TabIndex = 3;
            eventManagerTab.Text = "Event Manager";
            eventManagerTab.ThemesEnabled = false;
            // 
            // manageEventCloseEventButton
            // 
            manageEventCloseEventButton.Font = new Font("Segoe UI Semibold", 9F);
            manageEventCloseEventButton.Location = new Point(1798, 885);
            manageEventCloseEventButton.Name = "manageEventCloseEventButton";
            manageEventCloseEventButton.Size = new Size(245, 109);
            manageEventCloseEventButton.TabIndex = 5;
            manageEventCloseEventButton.Text = "Close Event";
            // 
            // manageEventScanTicketsButton
            // 
            manageEventScanTicketsButton.Font = new Font("Segoe UI Semibold", 9F);
            manageEventScanTicketsButton.Location = new Point(1262, 885);
            manageEventScanTicketsButton.Name = "manageEventScanTicketsButton";
            manageEventScanTicketsButton.Size = new Size(245, 109);
            manageEventScanTicketsButton.TabIndex = 4;
            manageEventScanTicketsButton.Text = "Scan Tickets";
            // 
            // manageEventManageTicketsButton
            // 
            manageEventManageTicketsButton.Font = new Font("Segoe UI Semibold", 9F);
            manageEventManageTicketsButton.Location = new Point(755, 885);
            manageEventManageTicketsButton.Name = "manageEventManageTicketsButton";
            manageEventManageTicketsButton.Size = new Size(245, 109);
            manageEventManageTicketsButton.TabIndex = 3;
            manageEventManageTicketsButton.Text = "Manage Tickets";
            // 
            // manageEventEditEventButton
            // 
            manageEventEditEventButton.Font = new Font("Segoe UI Semibold", 9F);
            manageEventEditEventButton.Location = new Point(273, 885);
            manageEventEditEventButton.Name = "manageEventEditEventButton";
            manageEventEditEventButton.Size = new Size(245, 109);
            manageEventEditEventButton.TabIndex = 2;
            manageEventEditEventButton.Text = "Edit Event";
            manageEventEditEventButton.Click += manageEventEditEventButton_Click;
            // 
            // manageEventCancelButton
            // 
            manageEventCancelButton.Font = new Font("Segoe UI Semibold", 9F);
            manageEventCancelButton.Location = new Point(1817, 1337);
            manageEventCancelButton.Name = "manageEventCancelButton";
            manageEventCancelButton.Size = new Size(226, 88);
            manageEventCancelButton.TabIndex = 1;
            manageEventCancelButton.Text = "Cancel";
            manageEventCancelButton.Click += manageEventCancelButton_Click;
            // 
            // manageEventDataGrid
            // 
            manageEventDataGrid.AccessibleName = "Table";
            manageEventDataGrid.AllowResizingColumns = true;
            manageEventDataGrid.Location = new Point(273, 71);
            manageEventDataGrid.Name = "manageEventDataGrid";
            manageEventDataGrid.PreviewRowHeight = 49;
            manageEventDataGrid.Size = new Size(1770, 630);
            manageEventDataGrid.Style.BorderColor = Color.FromArgb(100, 100, 100);
            manageEventDataGrid.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(0, 120, 215);
            manageEventDataGrid.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(0, 120, 215);
            manageEventDataGrid.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(0, 120, 215);
            manageEventDataGrid.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(0, 120, 215);
            manageEventDataGrid.TabIndex = 0;
            manageEventDataGrid.Text = "sfDataGrid1";
            manageEventDataGrid.SelectionChanged += manageEventDataGrid_SelectionChanged;
            // 
            // myTicketsTab
            // 
            myTicketsTab.Controls.Add(sfButton2);
            myTicketsTab.Image = null;
            myTicketsTab.ImageSize = new Size(16, 16);
            myTicketsTab.Location = new Point(1, 43);
            myTicketsTab.Margin = new Padding(5, 6, 5, 6);
            myTicketsTab.Name = "myTicketsTab";
            myTicketsTab.ShowCloseButton = true;
            myTicketsTab.Size = new Size(2230, 1531);
            myTicketsTab.TabIndex = 3;
            myTicketsTab.Text = "My Tickets";
            myTicketsTab.ThemesEnabled = false;
            // 
            // sfButton2
            // 
            sfButton2.Font = new Font("Segoe UI Semibold", 9F);
            sfButton2.Location = new Point(351, 802);
            sfButton2.Margin = new Padding(5, 6, 5, 6);
            sfButton2.Name = "sfButton2";
            sfButton2.Size = new Size(165, 56);
            sfButton2.TabIndex = 0;
            sfButton2.Text = "sfButton2";
            // 
            // profileTab
            // 
            profileTab.Controls.Add(addNewPaymentMethodButton);
            profileTab.Controls.Add(paymentMethodsLabel);
            profileTab.Controls.Add(paymentMethodsComboBox);
            profileTab.Controls.Add(signOutButton);
            profileTab.Controls.Add(firstlastNameLabel);
            profileTab.Controls.Add(pictureBox1);
            profileTab.Image = null;
            profileTab.ImageSize = new Size(16, 16);
            profileTab.Location = new Point(1, 43);
            profileTab.Margin = new Padding(5, 6, 5, 6);
            profileTab.Name = "profileTab";
            profileTab.ShowCloseButton = true;
            profileTab.Size = new Size(2230, 1531);
            profileTab.TabIndex = 2;
            profileTab.Text = "Profile";
            profileTab.ThemesEnabled = false;
            // 
            // addNewPaymentMethodButton
            // 
            addNewPaymentMethodButton.Font = new Font("Segoe UI Semibold", 9F);
            addNewPaymentMethodButton.Location = new Point(578, 404);
            addNewPaymentMethodButton.Margin = new Padding(5, 6, 5, 6);
            addNewPaymentMethodButton.Name = "addNewPaymentMethodButton";
            addNewPaymentMethodButton.Size = new Size(269, 56);
            addNewPaymentMethodButton.TabIndex = 5;
            addNewPaymentMethodButton.Text = "Add new payment method";
            addNewPaymentMethodButton.Click += addNewPaymentMethodButton_Click;
            // 
            // paymentMethodsLabel
            // 
            paymentMethodsLabel.AutoSize = true;
            paymentMethodsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paymentMethodsLabel.Location = new Point(578, 262);
            paymentMethodsLabel.Margin = new Padding(5, 0, 5, 0);
            paymentMethodsLabel.Name = "paymentMethodsLabel";
            paymentMethodsLabel.Size = new Size(197, 30);
            paymentMethodsLabel.TabIndex = 4;
            paymentMethodsLabel.Text = "Payment Methods:";
            // 
            // paymentMethodsComboBox
            // 
            paymentMethodsComboBox.BeforeTouchSize = new Size(340, 38);
            paymentMethodsComboBox.Location = new Point(578, 316);
            paymentMethodsComboBox.Margin = new Padding(5, 6, 5, 6);
            paymentMethodsComboBox.Name = "paymentMethodsComboBox";
            paymentMethodsComboBox.Size = new Size(340, 38);
            paymentMethodsComboBox.TabIndex = 3;
            paymentMethodsComboBox.Text = "Click to view";
            // 
            // signOutButton
            // 
            signOutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            signOutButton.Font = new Font("Segoe UI Semibold", 9F);
            signOutButton.ForeColor = Color.FromArgb(192, 0, 0);
            signOutButton.Location = new Point(1885, 1420);
            signOutButton.Margin = new Padding(5, 6, 5, 6);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(307, 56);
            signOutButton.Style.ForeColor = Color.FromArgb(192, 0, 0);
            signOutButton.TabIndex = 2;
            signOutButton.Text = "Sign Out";
            signOutButton.Click += signOutButton_Click;
            // 
            // firstlastNameLabel
            // 
            firstlastNameLabel.AutoSize = true;
            firstlastNameLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstlastNameLabel.Location = new Point(578, 42);
            firstlastNameLabel.Margin = new Padding(5, 0, 5, 0);
            firstlastNameLabel.Name = "firstlastNameLabel";
            firstlastNameLabel.Size = new Size(618, 84);
            firstlastNameLabel.TabIndex = 1;
            firstlastNameLabel.Text = "Firstname Lastname";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resource.pngtree_avatar_icon_profile_member_login_vector_isolated_silhouette_transparent_png_image_7111828;
            pictureBox1.Location = new Point(5, 6);
            pictureBox1.Margin = new Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(530, 620);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // eventManagerErrorLabel
            // 
            eventManagerErrorLabel.Font = new Font("Segoe UI", 12F);
            eventManagerErrorLabel.ForeColor = Color.Red;
            eventManagerErrorLabel.Location = new Point(276, 783);
            eventManagerErrorLabel.Name = "eventManagerErrorLabel";
            eventManagerErrorLabel.Size = new Size(145, 38);
            eventManagerErrorLabel.TabIndex = 6;
            eventManagerErrorLabel.Text = "error label";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.Black;
            ClientSize = new Size(2576, 1576);
            Controls.Add(tabControlAdv1);
            Controls.Add(dockingClientPanel1);
            Controls.Add(panel1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Venue App";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabControlAdv1).EndInit();
            tabControlAdv1.ResumeLayout(false);
            adminToolsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabControlAdv2).EndInit();
            tabControlAdv2.ResumeLayout(false);
            adminToolsSelectionTab.ResumeLayout(false);
            createNewEventTab.ResumeLayout(false);
            createNewEventTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)createEventTypeComboDropDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)createEventAMPMComboDropDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)createEventMinuteComboDropDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)createEventHourComboDropDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)createEventDescriptionTextBox).EndInit();
            eventManagerTab.ResumeLayout(false);
            eventManagerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)manageEventDataGrid).EndInit();
            myTicketsTab.ResumeLayout(false);
            profileTab.ResumeLayout(false);
            profileTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)paymentMethodsComboBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Syncfusion.WinForms.Controls.SfButton homeButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.WinForms.Controls.SfButton profileButton;
        private Syncfusion.WinForms.Controls.SfButton ticketWalletButton;
        private Syncfusion.WinForms.Controls.SfButton adminControlsButton;
        private Syncfusion.Windows.Forms.Tools.DockingClientPanel dockingClientPanel1;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv homeTab;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv profileTab;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv myTicketsTab;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv adminToolsTab;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv2;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv adminToolsSelectionTab;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv createNewEventTab;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv eventManagerTab;
        private Syncfusion.WinForms.Controls.SfButton eventManagerButton;
        private Syncfusion.WinForms.Controls.SfButton switchToCreateNewEventTabButton;
        private Syncfusion.WinForms.Controls.SfButton createEventButton;
        private Syncfusion.WinForms.Controls.SfButton sfButton2;
        private PictureBox pictureBox1;
        private Label firstlastNameLabel;
        private Syncfusion.WinForms.Controls.SfButton signOutButton;
        private Label paymentMethodsLabel;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv paymentMethodsComboBox;
        private Syncfusion.WinForms.Controls.SfButton addNewPaymentMethodButton;
        private Syncfusion.WinForms.Input.SfCalendar createEventCalendar;
        private Syncfusion.Windows.Forms.Tools.AutoLabel createEventDescriptionLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel createEventTypeLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel createEventTimeLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel createEventDateLabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt createEventDescriptionTextBox;
        private Syncfusion.WinForms.Controls.SfButton createEventCreateButton;
        private Syncfusion.WinForms.Controls.SfButton createEventCancelButton;
        private Syncfusion.Windows.Forms.Tools.AutoLabel createEventErrorLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel createEventColonLabel;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv createEventMinuteComboDropDown;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv createEventHourComboDropDown;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv createEventAMPMComboDropDown;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv createEventTypeComboDropDown;
        private Syncfusion.WinForms.DataGrid.SfDataGrid manageEventDataGrid;
        private Syncfusion.WinForms.Controls.SfButton manageEventCancelButton;
        private Syncfusion.WinForms.Controls.SfButton manageEventCloseEventButton;
        private Syncfusion.WinForms.Controls.SfButton manageEventScanTicketsButton;
        private Syncfusion.WinForms.Controls.SfButton manageEventManageTicketsButton;
        private Syncfusion.WinForms.Controls.SfButton manageEventEditEventButton;
        private Syncfusion.Windows.Forms.Tools.AutoLabel eventManagerErrorLabel;
    }
}
