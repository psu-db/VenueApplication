namespace VenueApplication
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
            createEventButton = new Syncfusion.WinForms.Controls.SfButton();
            eventManagerTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            myTicketsTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            sfButton2 = new Syncfusion.WinForms.Controls.SfButton();
            profileTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            addNewPaymentMethodButton = new Syncfusion.WinForms.Controls.SfButton();
            paymentMethodsLabel = new Label();
            paymentMethodsComboBox = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            signOutButton = new Syncfusion.WinForms.Controls.SfButton();
            firstlastNameLabel = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabControlAdv1).BeginInit();
            tabControlAdv1.SuspendLayout();
            adminToolsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabControlAdv2).BeginInit();
            tabControlAdv2.SuspendLayout();
            adminToolsSelectionTab.SuspendLayout();
            createNewEventTab.SuspendLayout();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 876);
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
            tableLayoutPanel1.Location = new Point(3, 70);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(156, 178);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // adminControlsButton
            // 
            adminControlsButton.Dock = DockStyle.Fill;
            adminControlsButton.Enabled = false;
            adminControlsButton.Font = new Font("Segoe UI Semibold", 9F);
            adminControlsButton.Location = new Point(3, 135);
            adminControlsButton.Name = "adminControlsButton";
            adminControlsButton.Size = new Size(162, 40);
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
            homeButton.Location = new Point(3, 3);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(162, 38);
            homeButton.TabIndex = 0;
            homeButton.Text = "Home";
            homeButton.Click += homeButton_Click;
            // 
            // profileButton
            // 
            profileButton.Dock = DockStyle.Fill;
            profileButton.Font = new Font("Segoe UI Semibold", 9F);
            profileButton.Location = new Point(3, 47);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(162, 38);
            profileButton.TabIndex = 1;
            profileButton.Text = "Profile";
            profileButton.Click += profileButton_Click;
            // 
            // ticketWalletButton
            // 
            ticketWalletButton.Dock = DockStyle.Fill;
            ticketWalletButton.Font = new Font("Segoe UI Semibold", 9F);
            ticketWalletButton.Location = new Point(3, 91);
            ticketWalletButton.Name = "ticketWalletButton";
            ticketWalletButton.Size = new Size(162, 38);
            ticketWalletButton.TabIndex = 2;
            ticketWalletButton.Text = "My Tickets";
            ticketWalletButton.Click += ticketWalletButton_Click;
            // 
            // dockingClientPanel1
            // 
            dockingClientPanel1.Location = new Point(745, 539);
            dockingClientPanel1.Name = "dockingClientPanel1";
            dockingClientPanel1.Size = new Size(23, 11);
            dockingClientPanel1.TabIndex = 1;
            // 
            // tabControlAdv1
            // 
            tabControlAdv1.BeforeTouchSize = new Size(1647, 876);
            tabControlAdv1.Controls.Add(homeTab);
            tabControlAdv1.Controls.Add(adminToolsTab);
            tabControlAdv1.Controls.Add(myTicketsTab);
            tabControlAdv1.Controls.Add(profileTab);
            tabControlAdv1.Dock = DockStyle.Fill;
            tabControlAdv1.Location = new Point(200, 0);
            tabControlAdv1.Name = "tabControlAdv1";
            tabControlAdv1.Size = new Size(1647, 876);
            tabControlAdv1.TabIndex = 2;
            // 
            // homeTab
            // 
            homeTab.Image = null;
            homeTab.ImageSize = new Size(16, 16);
            homeTab.Location = new Point(1, 27);
            homeTab.Name = "homeTab";
            homeTab.ShowCloseButton = true;
            homeTab.Size = new Size(1644, 847);
            homeTab.TabIndex = 1;
            homeTab.Text = "Home";
            homeTab.ThemesEnabled = false;
            // 
            // adminToolsTab
            // 
            adminToolsTab.Controls.Add(tabControlAdv2);
            adminToolsTab.Image = null;
            adminToolsTab.ImageSize = new Size(16, 16);
            adminToolsTab.Location = new Point(1, 27);
            adminToolsTab.Name = "adminToolsTab";
            adminToolsTab.ShowCloseButton = true;
            adminToolsTab.Size = new Size(1644, 847);
            adminToolsTab.TabIndex = 4;
            adminToolsTab.Text = "Admin Tools";
            adminToolsTab.ThemesEnabled = false;
            // 
            // tabControlAdv2
            // 
            tabControlAdv2.BeforeTouchSize = new Size(1644, 847);
            tabControlAdv2.Controls.Add(adminToolsSelectionTab);
            tabControlAdv2.Controls.Add(createNewEventTab);
            tabControlAdv2.Controls.Add(eventManagerTab);
            tabControlAdv2.Dock = DockStyle.Fill;
            tabControlAdv2.Location = new Point(0, 0);
            tabControlAdv2.Name = "tabControlAdv2";
            tabControlAdv2.Size = new Size(1644, 847);
            tabControlAdv2.TabIndex = 0;
            // 
            // adminToolsSelectionTab
            // 
            adminToolsSelectionTab.Controls.Add(eventManagerButton);
            adminToolsSelectionTab.Controls.Add(switchToCreateNewEventTabButton);
            adminToolsSelectionTab.Image = null;
            adminToolsSelectionTab.ImageSize = new Size(16, 16);
            adminToolsSelectionTab.Location = new Point(1, 0);
            adminToolsSelectionTab.Name = "adminToolsSelectionTab";
            adminToolsSelectionTab.ShowCloseButton = true;
            adminToolsSelectionTab.Size = new Size(1641, 845);
            adminToolsSelectionTab.TabIndex = 1;
            adminToolsSelectionTab.Text = "Admin Tool Selection";
            adminToolsSelectionTab.ThemesEnabled = false;
            // 
            // eventManagerButton
            // 
            eventManagerButton.Font = new Font("Segoe UI Semibold", 9F);
            eventManagerButton.Location = new Point(1063, 245);
            eventManagerButton.Name = "eventManagerButton";
            eventManagerButton.Size = new Size(375, 328);
            eventManagerButton.TabIndex = 1;
            eventManagerButton.Text = "Manage Existing Event";
            eventManagerButton.Click += eventManagerButton_Click;
            // 
            // switchToCreateNewEventTabButton
            // 
            switchToCreateNewEventTabButton.Font = new Font("Segoe UI Semibold", 9F);
            switchToCreateNewEventTabButton.Location = new Point(391, 245);
            switchToCreateNewEventTabButton.Name = "switchToCreateNewEventTabButton";
            switchToCreateNewEventTabButton.Size = new Size(375, 328);
            switchToCreateNewEventTabButton.TabIndex = 0;
            switchToCreateNewEventTabButton.Text = "Create New Event";
            switchToCreateNewEventTabButton.Click += switchToCreateNewEventTabButton_Click;
            // 
            // createNewEventTab
            // 
            createNewEventTab.Controls.Add(createEventButton);
            createNewEventTab.Image = null;
            createNewEventTab.ImageSize = new Size(16, 16);
            createNewEventTab.Location = new Point(1, 0);
            createNewEventTab.Name = "createNewEventTab";
            createNewEventTab.ShowCloseButton = true;
            createNewEventTab.Size = new Size(1641, 845);
            createNewEventTab.TabIndex = 2;
            createNewEventTab.Text = "Create New Event";
            createNewEventTab.ThemesEnabled = false;
            // 
            // createEventButton
            // 
            createEventButton.Font = new Font("Segoe UI Semibold", 9F);
            createEventButton.Location = new Point(1441, 700);
            createEventButton.Name = "createEventButton";
            createEventButton.Size = new Size(153, 62);
            createEventButton.TabIndex = 0;
            createEventButton.Text = "Create Event";
            // 
            // eventManagerTab
            // 
            eventManagerTab.Image = null;
            eventManagerTab.ImageSize = new Size(16, 16);
            eventManagerTab.Location = new Point(1, 0);
            eventManagerTab.Name = "eventManagerTab";
            eventManagerTab.ShowCloseButton = true;
            eventManagerTab.Size = new Size(1641, 845);
            eventManagerTab.TabIndex = 3;
            eventManagerTab.Text = "Event Manager";
            eventManagerTab.ThemesEnabled = false;
            // 
            // myTicketsTab
            // 
            myTicketsTab.Controls.Add(sfButton2);
            myTicketsTab.Image = null;
            myTicketsTab.ImageSize = new Size(16, 16);
            myTicketsTab.Location = new Point(1, 27);
            myTicketsTab.Name = "myTicketsTab";
            myTicketsTab.ShowCloseButton = true;
            myTicketsTab.Size = new Size(1644, 847);
            myTicketsTab.TabIndex = 3;
            myTicketsTab.Text = "My Tickets";
            myTicketsTab.ThemesEnabled = false;
            // 
            // sfButton2
            // 
            sfButton2.Font = new Font("Segoe UI Semibold", 9F);
            sfButton2.Location = new Point(205, 401);
            sfButton2.Name = "sfButton2";
            sfButton2.Size = new Size(96, 28);
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
            profileTab.Location = new Point(1, 27);
            profileTab.Name = "profileTab";
            profileTab.ShowCloseButton = true;
            profileTab.Size = new Size(1644, 847);
            profileTab.TabIndex = 2;
            profileTab.Text = "Profile";
            profileTab.ThemesEnabled = false;
            // 
            // addNewPaymentMethodButton
            // 
            addNewPaymentMethodButton.Font = new Font("Segoe UI Semibold", 9F);
            addNewPaymentMethodButton.Location = new Point(337, 211);
            addNewPaymentMethodButton.Name = "addNewPaymentMethodButton";
            addNewPaymentMethodButton.Size = new Size(157, 28);
            addNewPaymentMethodButton.TabIndex = 5;
            addNewPaymentMethodButton.Text = "Add new payment method";
            addNewPaymentMethodButton.Click += addNewPaymentMethodButton_Click;
            // 
            // paymentMethodsLabel
            // 
            paymentMethodsLabel.AutoSize = true;
            paymentMethodsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paymentMethodsLabel.Location = new Point(337, 131);
            paymentMethodsLabel.Name = "paymentMethodsLabel";
            paymentMethodsLabel.Size = new Size(111, 15);
            paymentMethodsLabel.TabIndex = 4;
            paymentMethodsLabel.Text = "Payment Methods:";
            // 
            // paymentMethodsComboBox
            // 
            paymentMethodsComboBox.BeforeTouchSize = new Size(121, 23);
            paymentMethodsComboBox.Location = new Point(337, 158);
            paymentMethodsComboBox.Name = "paymentMethodsComboBox";
            paymentMethodsComboBox.Size = new Size(121, 23);
            paymentMethodsComboBox.TabIndex = 3;
            paymentMethodsComboBox.Text = "Click to view";
            // 
            // signOutButton
            // 
            signOutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            signOutButton.Font = new Font("Segoe UI Semibold", 9F);
            signOutButton.ForeColor = Color.FromArgb(192, 0, 0);
            signOutButton.Location = new Point(1444, 798);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(179, 28);
            signOutButton.Style.ForeColor = Color.FromArgb(192, 0, 0);
            signOutButton.TabIndex = 2;
            signOutButton.Text = "Sign Out";
            signOutButton.Click += signOutButton_Click;
            // 
            // firstlastNameLabel
            // 
            firstlastNameLabel.AutoSize = true;
            firstlastNameLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstlastNameLabel.Location = new Point(337, 21);
            firstlastNameLabel.Name = "firstlastNameLabel";
            firstlastNameLabel.Size = new Size(349, 47);
            firstlastNameLabel.TabIndex = 1;
            firstlastNameLabel.Text = "Firstname Lastname";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resource.pngtree_avatar_icon_profile_member_login_vector_isolated_silhouette_transparent_png_image_7111828;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 310);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.Black;
            ClientSize = new Size(1847, 876);
            Controls.Add(tabControlAdv1);
            Controls.Add(dockingClientPanel1);
            Controls.Add(panel1);
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
    }
}
