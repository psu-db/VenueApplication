namespace VenueApplication.Forms
{
    partial class CloseEventForm
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
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            closeEventEventNameLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            closeEventDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            closeEventCancelButton = new Syncfusion.WinForms.Controls.SfButton();
            closeEventCloseButton = new Syncfusion.WinForms.Controls.SfButton();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            closeEventTicketsSoldLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            closeEventTicketRevenue = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            closeEventMessageLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)closeEventDataGrid).BeginInit();
            SuspendLayout();
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Segoe UI", 18F);
            autoLabel1.Location = new Point(59, 53);
            autoLabel1.Margin = new Padding(2, 0, 2, 0);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(143, 32);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Close Event:";
            // 
            // closeEventEventNameLabel
            // 
            closeEventEventNameLabel.Font = new Font("Segoe UI", 18F);
            closeEventEventNameLabel.Location = new Point(200, 53);
            closeEventEventNameLabel.Margin = new Padding(2, 0, 2, 0);
            closeEventEventNameLabel.Name = "closeEventEventNameLabel";
            closeEventEventNameLabel.Size = new Size(143, 32);
            closeEventEventNameLabel.TabIndex = 1;
            closeEventEventNameLabel.Text = "Close Event:";
            // 
            // closeEventDataGrid
            // 
            closeEventDataGrid.AccessibleName = "Table";
            closeEventDataGrid.AllowEditing = false;
            closeEventDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            closeEventDataGrid.Location = new Point(59, 222);
            closeEventDataGrid.Margin = new Padding(2);
            closeEventDataGrid.Name = "closeEventDataGrid";
            closeEventDataGrid.PreviewRowHeight = 49;
            closeEventDataGrid.Size = new Size(558, 178);
            closeEventDataGrid.Style.BorderColor = Color.FromArgb(100, 100, 100);
            closeEventDataGrid.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(0, 120, 215);
            closeEventDataGrid.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(0, 120, 215);
            closeEventDataGrid.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(0, 120, 215);
            closeEventDataGrid.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(0, 120, 215);
            closeEventDataGrid.TabIndex = 3;
            closeEventDataGrid.Text = "sfDataGrid1";
            // 
            // closeEventCancelButton
            // 
            closeEventCancelButton.Font = new Font("Segoe UI Semibold", 12F);
            closeEventCancelButton.Location = new Point(59, 421);
            closeEventCancelButton.Margin = new Padding(2);
            closeEventCancelButton.Name = "closeEventCancelButton";
            closeEventCancelButton.Size = new Size(166, 67);
            closeEventCancelButton.TabIndex = 4;
            closeEventCancelButton.Text = "Cancel";
            closeEventCancelButton.Click += closeEventCancelButton_Click;
            // 
            // closeEventCloseButton
            // 
            closeEventCloseButton.Font = new Font("Segoe UI Semibold", 12F);
            closeEventCloseButton.Location = new Point(240, 421);
            closeEventCloseButton.Margin = new Padding(2);
            closeEventCloseButton.Name = "closeEventCloseButton";
            closeEventCloseButton.Size = new Size(166, 67);
            closeEventCloseButton.TabIndex = 5;
            closeEventCloseButton.Text = "Close Event";
            closeEventCloseButton.Click += closeEventCloseButton_Click;
            // 
            // autoLabel2
            // 
            autoLabel2.Font = new Font("Segoe UI", 16F);
            autoLabel2.Location = new Point(59, 111);
            autoLabel2.Margin = new Padding(2, 0, 2, 0);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(128, 30);
            autoLabel2.TabIndex = 6;
            autoLabel2.Text = "Attendance:";
            // 
            // closeEventTicketsSoldLabel
            // 
            closeEventTicketsSoldLabel.Font = new Font("Segoe UI", 16F);
            closeEventTicketsSoldLabel.Location = new Point(191, 111);
            closeEventTicketsSoldLabel.Margin = new Padding(2, 0, 2, 0);
            closeEventTicketsSoldLabel.Name = "closeEventTicketsSoldLabel";
            closeEventTicketsSoldLabel.Size = new Size(93, 30);
            closeEventTicketsSoldLabel.TabIndex = 7;
            closeEventTicketsSoldLabel.Text = "temptex";
            // 
            // closeEventTicketRevenue
            // 
            closeEventTicketRevenue.Font = new Font("Segoe UI", 16F);
            closeEventTicketRevenue.Location = new Point(279, 169);
            closeEventTicketRevenue.Margin = new Padding(2, 0, 2, 0);
            closeEventTicketRevenue.Name = "closeEventTicketRevenue";
            closeEventTicketRevenue.Size = new Size(64, 30);
            closeEventTicketRevenue.TabIndex = 9;
            closeEventTicketRevenue.Text = "temp";
            // 
            // autoLabel4
            // 
            autoLabel4.Font = new Font("Segoe UI", 16F);
            autoLabel4.Location = new Point(59, 169);
            autoLabel4.Margin = new Padding(2, 0, 2, 0);
            autoLabel4.Name = "autoLabel4";
            autoLabel4.Size = new Size(216, 30);
            autoLabel4.TabIndex = 8;
            autoLabel4.Text = "Total Ticket Revenue:";
            // 
            // closeEventMessageLabel
            // 
            closeEventMessageLabel.Font = new Font("Segoe UI", 18F);
            closeEventMessageLabel.Location = new Point(59, 499);
            closeEventMessageLabel.Margin = new Padding(2, 0, 2, 0);
            closeEventMessageLabel.Name = "closeEventMessageLabel";
            closeEventMessageLabel.Size = new Size(143, 32);
            closeEventMessageLabel.TabIndex = 10;
            closeEventMessageLabel.Text = "Close Event:";
            // 
            // CloseEventForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(650, 556);
            Controls.Add(closeEventMessageLabel);
            Controls.Add(closeEventTicketRevenue);
            Controls.Add(autoLabel4);
            Controls.Add(closeEventTicketsSoldLabel);
            Controls.Add(autoLabel2);
            Controls.Add(closeEventCloseButton);
            Controls.Add(closeEventCancelButton);
            Controls.Add(closeEventDataGrid);
            Controls.Add(closeEventEventNameLabel);
            Controls.Add(autoLabel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "CloseEventForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CloseEventForm";
            ((System.ComponentModel.ISupportInitialize)closeEventDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel closeEventEventNameLabel;
        private Syncfusion.WinForms.DataGrid.SfDataGrid closeEventDataGrid;
        private Syncfusion.WinForms.Controls.SfButton closeEventCancelButton;
        private Syncfusion.WinForms.Controls.SfButton closeEventCloseButton;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel closeEventTicketsSoldLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel closeEventTicketRevenue;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel closeEventMessageLabel;
    }
}