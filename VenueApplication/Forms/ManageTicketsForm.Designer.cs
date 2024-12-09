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
            manageTicketLabel.Location = new Point(46, 30);
            manageTicketLabel.Margin = new Padding(2, 0, 2, 0);
            manageTicketLabel.Name = "manageTicketLabel";
            manageTicketLabel.Size = new Size(258, 30);
            manageTicketLabel.TabIndex = 0;
            manageTicketLabel.Text = "Manage tickets for event:";
            // 
            // manageTicketsEventNameLabel
            // 
            manageTicketsEventNameLabel.Font = new Font("Segoe UI", 16F);
            manageTicketsEventNameLabel.Location = new Point(315, 30);
            manageTicketsEventNameLabel.Margin = new Padding(2, 0, 2, 0);
            manageTicketsEventNameLabel.Name = "manageTicketsEventNameLabel";
            manageTicketsEventNameLabel.Size = new Size(119, 30);
            manageTicketsEventNameLabel.TabIndex = 1;
            manageTicketsEventNameLabel.Text = "autoLabel1";
            // 
            // manageTicketsDataGrid
            // 
            manageTicketsDataGrid.AccessibleName = "Table";
            manageTicketsDataGrid.AllowEditing = false;
            manageTicketsDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            manageTicketsDataGrid.Location = new Point(46, 71);
            manageTicketsDataGrid.Margin = new Padding(2);
            manageTicketsDataGrid.Name = "manageTicketsDataGrid";
            manageTicketsDataGrid.PreviewRowHeight = 49;
            manageTicketsDataGrid.Size = new Size(740, 215);
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
            manageTicketsSectionComboBoxAdv.BeforeTouchSize = new Size(125, 29);
            manageTicketsSectionComboBoxAdv.Font = new Font("Segoe UI", 12F);
            manageTicketsSectionComboBoxAdv.Items.AddRange(new object[] { "EB", "EF", "NL", "NG", "NC", "WH", "WD", "SK", "SF", "EAU", "EEU", "EJU", "NHU", "NDU", "WHU", "WEU", "WAU", "SLU", "SGU", "SCU" });
            manageTicketsSectionComboBoxAdv.Location = new Point(114, 320);
            manageTicketsSectionComboBoxAdv.Margin = new Padding(2);
            manageTicketsSectionComboBoxAdv.Name = "manageTicketsSectionComboBoxAdv";
            manageTicketsSectionComboBoxAdv.Size = new Size(125, 29);
            manageTicketsSectionComboBoxAdv.TabIndex = 3;
            // 
            // manageTicketsSectionLabel
            // 
            manageTicketsSectionLabel.Font = new Font("Segoe UI", 12F);
            manageTicketsSectionLabel.Location = new Point(46, 320);
            manageTicketsSectionLabel.Margin = new Padding(2, 0, 2, 0);
            manageTicketsSectionLabel.Name = "manageTicketsSectionLabel";
            manageTicketsSectionLabel.Size = new Size(64, 21);
            manageTicketsSectionLabel.TabIndex = 4;
            manageTicketsSectionLabel.Text = "Section:";
            // 
            // manageTicketsPriceLabel
            // 
            manageTicketsPriceLabel.Font = new Font("Segoe UI", 12F);
            manageTicketsPriceLabel.Location = new Point(46, 378);
            manageTicketsPriceLabel.Margin = new Padding(2, 0, 2, 0);
            manageTicketsPriceLabel.Name = "manageTicketsPriceLabel";
            manageTicketsPriceLabel.Size = new Size(47, 21);
            manageTicketsPriceLabel.TabIndex = 5;
            manageTicketsPriceLabel.Text = "Price:";
            // 
            // manageTicketsCurrencyTextBox
            // 
            manageTicketsCurrencyTextBox.AccessibilityEnabled = true;
            manageTicketsCurrencyTextBox.BeforeTouchSize = new Size(104, 29);
            manageTicketsCurrencyTextBox.DecimalValue = new decimal(new int[] { 100, 0, 0, 131072 });
            manageTicketsCurrencyTextBox.Font = new Font("Segoe UI", 12F);
            manageTicketsCurrencyTextBox.Location = new Point(97, 378);
            manageTicketsCurrencyTextBox.Margin = new Padding(2);
            manageTicketsCurrencyTextBox.Name = "manageTicketsCurrencyTextBox";
            manageTicketsCurrencyTextBox.Size = new Size(104, 29);
            manageTicketsCurrencyTextBox.TabIndex = 7;
            manageTicketsCurrencyTextBox.Text = "$1.00";
            // 
            // manageTicketsCancelButton
            // 
            manageTicketsCancelButton.Font = new Font("Segoe UI Semibold", 9F);
            manageTicketsCancelButton.Location = new Point(46, 481);
            manageTicketsCancelButton.Margin = new Padding(2);
            manageTicketsCancelButton.Name = "manageTicketsCancelButton";
            manageTicketsCancelButton.Size = new Size(156, 56);
            manageTicketsCancelButton.TabIndex = 8;
            manageTicketsCancelButton.Text = "Cancel";
            manageTicketsCancelButton.Click += manageTicketsCancelButton_Click;
            // 
            // manageTicketsCreateButton
            // 
            manageTicketsCreateButton.Font = new Font("Segoe UI Semibold", 9F);
            manageTicketsCreateButton.Location = new Point(227, 481);
            manageTicketsCreateButton.Margin = new Padding(2);
            manageTicketsCreateButton.Name = "manageTicketsCreateButton";
            manageTicketsCreateButton.Size = new Size(156, 56);
            manageTicketsCreateButton.TabIndex = 9;
            manageTicketsCreateButton.Text = "Create";
            manageTicketsCreateButton.Click += manageTicketsCreateButton_Click;
            // 
            // manageTicketsErrorLabel
            // 
            manageTicketsErrorLabel.Font = new Font("Segoe UI", 16F);
            manageTicketsErrorLabel.ForeColor = Color.Red;
            manageTicketsErrorLabel.Location = new Point(46, 428);
            manageTicketsErrorLabel.Margin = new Padding(2, 0, 2, 0);
            manageTicketsErrorLabel.Name = "manageTicketsErrorLabel";
            manageTicketsErrorLabel.Size = new Size(119, 30);
            manageTicketsErrorLabel.TabIndex = 10;
            manageTicketsErrorLabel.Text = "autoLabel1";
            manageTicketsErrorLabel.Visible = false;
            // 
            // manageTicketsDeleteButton
            // 
            manageTicketsDeleteButton.Font = new Font("Segoe UI Semibold", 9F);
            manageTicketsDeleteButton.Location = new Point(416, 481);
            manageTicketsDeleteButton.Margin = new Padding(2);
            manageTicketsDeleteButton.Name = "manageTicketsDeleteButton";
            manageTicketsDeleteButton.Size = new Size(156, 56);
            manageTicketsDeleteButton.TabIndex = 11;
            manageTicketsDeleteButton.Text = "Delete";
            manageTicketsDeleteButton.Click += manageTicketsDeleteButton_Click;
            // 
            // ManageTicketsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 564);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MinimizeBox = false;
            Name = "ManageTicketsForm";
            StartPosition = FormStartPosition.CenterScreen;
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