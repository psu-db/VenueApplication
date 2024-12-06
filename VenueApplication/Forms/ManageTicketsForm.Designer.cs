namespace VenueApplication.Forms
{
    partial class ManageTicketsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            manageTicketLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            manageTicketsEventNameLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            manageTicketsDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            manageTicketsSectionComboBoxAdv = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            manageTicketsSectionLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            manageTicketsPriceLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            manageTicketsCurrencyTextBox = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            manageTicketsCancelButton = new Syncfusion.WinForms.Controls.SfButton();
            manageTicketsCreateButton = new Syncfusion.WinForms.Controls.SfButton();
            manageTicketsErrorLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            manageTicketsDeleteButton = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)manageTicketsDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)manageTicketsSectionComboBoxAdv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)manageTicketsCurrencyTextBox).BeginInit();
            SuspendLayout();
            // 
            // manageTicketLabel
            // 
            manageTicketLabel.Font = new Font("Segoe UI", 16F);
            manageTicketLabel.Location = new Point(79, 61);
            manageTicketLabel.Name = "manageTicketLabel";
            manageTicketLabel.Size = new Size(444, 51);
            manageTicketLabel.TabIndex = 0;
            manageTicketLabel.Text = "Manage tickets for event:";
            // 
            // manageTicketsEventNameLabel
            // 
            manageTicketsEventNameLabel.Font = new Font("Segoe UI", 16F);
            manageTicketsEventNameLabel.Location = new Point(540, 61);
            manageTicketsEventNameLabel.Name = "manageTicketsEventNameLabel";
            manageTicketsEventNameLabel.Size = new Size(206, 51);
            manageTicketsEventNameLabel.TabIndex = 1;
            manageTicketsEventNameLabel.Text = "autoLabel1";
            // 
            // manageTicketsDataGrid
            // 
            manageTicketsDataGrid.AccessibleName = "Table";
            manageTicketsDataGrid.Location = new Point(79, 142);
            manageTicketsDataGrid.Name = "manageTicketsDataGrid";
            manageTicketsDataGrid.PreviewRowHeight = 49;
            manageTicketsDataGrid.Size = new Size(2010, 656);
            manageTicketsDataGrid.Style.BorderColor = Color.FromArgb(100, 100, 100);
            manageTicketsDataGrid.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(0, 120, 215);
            manageTicketsDataGrid.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(0, 120, 215);
            manageTicketsDataGrid.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(0, 120, 215);
            manageTicketsDataGrid.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(0, 120, 215);
            manageTicketsDataGrid.TabIndex = 2;
            manageTicketsDataGrid.Text = "sfDataGrid1";
            manageTicketsDataGrid.SelectionChanged += manageTicketsDataGrid_SelectionChanged;
            // 
            // manageTicketsSectionComboBoxAdv
            // 
            manageTicketsSectionComboBoxAdv.BeforeTouchSize = new Size(212, 46);
            manageTicketsSectionComboBoxAdv.Font = new Font("Segoe UI", 12F);
            manageTicketsSectionComboBoxAdv.Items.AddRange(new object[] { "EB", "EF", "NL", "NG", "NC", "WH", "WD", "SK", "SF", "EAU", "EEU", "EJU", "NHU", "NDU", "WHU", "WEU", "WAU", "SLU", "SGU", "SCU" });
            manageTicketsSectionComboBoxAdv.Location = new Point(311, 828);
            manageTicketsSectionComboBoxAdv.Name = "manageTicketsSectionComboBoxAdv";
            manageTicketsSectionComboBoxAdv.Size = new Size(212, 46);
            manageTicketsSectionComboBoxAdv.TabIndex = 3;
            // 
            // manageTicketsSectionLabel
            // 
            manageTicketsSectionLabel.Font = new Font("Segoe UI", 12F);
            manageTicketsSectionLabel.Location = new Point(161, 828);
            manageTicketsSectionLabel.Name = "manageTicketsSectionLabel";
            manageTicketsSectionLabel.Size = new Size(114, 38);
            manageTicketsSectionLabel.TabIndex = 4;
            manageTicketsSectionLabel.Text = "Section:";
            // 
            // manageTicketsPriceLabel
            // 
            manageTicketsPriceLabel.Font = new Font("Segoe UI", 12F);
            manageTicketsPriceLabel.Location = new Point(161, 970);
            manageTicketsPriceLabel.Name = "manageTicketsPriceLabel";
            manageTicketsPriceLabel.Size = new Size(84, 38);
            manageTicketsPriceLabel.TabIndex = 5;
            manageTicketsPriceLabel.Text = "Price:";
            // 
            // manageTicketsCurrencyTextBox
            // 
            manageTicketsCurrencyTextBox.AccessibilityEnabled = true;
            manageTicketsCurrencyTextBox.BeforeTouchSize = new Size(175, 45);
            manageTicketsCurrencyTextBox.DecimalValue = new decimal(new int[] { 100, 0, 0, 131072 });
            manageTicketsCurrencyTextBox.Font = new Font("Segoe UI", 12F);
            manageTicketsCurrencyTextBox.Location = new Point(311, 973);
            manageTicketsCurrencyTextBox.Name = "manageTicketsCurrencyTextBox";
            manageTicketsCurrencyTextBox.Size = new Size(175, 45);
            manageTicketsCurrencyTextBox.TabIndex = 7;
            manageTicketsCurrencyTextBox.Text = "$1.00";
            // 
            // manageTicketsCancelButton
            // 
            manageTicketsCancelButton.Font = new Font("Segoe UI Semibold", 9F);
            manageTicketsCancelButton.Location = new Point(1190, 1073);
            manageTicketsCancelButton.Name = "manageTicketsCancelButton";
            manageTicketsCancelButton.Size = new Size(267, 113);
            manageTicketsCancelButton.TabIndex = 8;
            manageTicketsCancelButton.Text = "Cancel";
            manageTicketsCancelButton.Click += manageTicketsCancelButton_Click;
            // 
            // manageTicketsCreateButton
            // 
            manageTicketsCreateButton.Font = new Font("Segoe UI Semibold", 9F);
            manageTicketsCreateButton.Location = new Point(1511, 1073);
            manageTicketsCreateButton.Name = "manageTicketsCreateButton";
            manageTicketsCreateButton.Size = new Size(267, 113);
            manageTicketsCreateButton.TabIndex = 9;
            manageTicketsCreateButton.Text = "Create";
            manageTicketsCreateButton.Click += manageTicketsCreateButton_Click;
            // 
            // manageTicketsErrorLabel
            // 
            manageTicketsErrorLabel.Font = new Font("Segoe UI", 16F);
            manageTicketsErrorLabel.ForeColor = Color.Red;
            manageTicketsErrorLabel.Location = new Point(144, 1112);
            manageTicketsErrorLabel.Name = "manageTicketsErrorLabel";
            manageTicketsErrorLabel.Size = new Size(206, 51);
            manageTicketsErrorLabel.TabIndex = 10;
            manageTicketsErrorLabel.Text = "autoLabel1";
            manageTicketsErrorLabel.Visible = false;
            // 
            // manageTicketsDeleteButton
            // 
            manageTicketsDeleteButton.Font = new Font("Segoe UI Semibold", 9F);
            manageTicketsDeleteButton.Location = new Point(1835, 1073);
            manageTicketsDeleteButton.Name = "manageTicketsDeleteButton";
            manageTicketsDeleteButton.Size = new Size(267, 113);
            manageTicketsDeleteButton.TabIndex = 11;
            manageTicketsDeleteButton.Text = "Delete";
            manageTicketsDeleteButton.Click += manageTicketsDeleteButton_Click;
            // 
            // ManageTicketsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2190, 1235);
            Controls.Add(manageTicketsDeleteButton);
            Controls.Add(manageTicketsErrorLabel);
            Controls.Add(manageTicketsCreateButton);
            Controls.Add(manageTicketsCancelButton);
            Controls.Add(manageTicketsCurrencyTextBox);
            Controls.Add(manageTicketsPriceLabel);
            Controls.Add(manageTicketsSectionLabel);
            Controls.Add(manageTicketsSectionComboBoxAdv);
            Controls.Add(manageTicketsDataGrid);
            Controls.Add(manageTicketsEventNameLabel);
            Controls.Add(manageTicketLabel);
            Name = "ManageTicketsForm";
            Text = "ManageTicketsForm";
            ((System.ComponentModel.ISupportInitialize)manageTicketsDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)manageTicketsSectionComboBoxAdv).EndInit();
            ((System.ComponentModel.ISupportInitialize)manageTicketsCurrencyTextBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel manageTicketLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel manageTicketsEventNameLabel;
        private Syncfusion.WinForms.DataGrid.SfDataGrid manageTicketsDataGrid;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv manageTicketsSectionComboBoxAdv;
        private Syncfusion.Windows.Forms.Tools.AutoLabel manageTicketsSectionLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel manageTicketsPriceLabel;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox manageTicketsCurrencyTextBox;
        private Syncfusion.WinForms.Controls.SfButton manageTicketsCancelButton;
        private Syncfusion.WinForms.Controls.SfButton manageTicketsCreateButton;
        private Syncfusion.Windows.Forms.Tools.AutoLabel manageTicketsErrorLabel;
        private Syncfusion.WinForms.Controls.SfButton manageTicketsDeleteButton;
    }
}