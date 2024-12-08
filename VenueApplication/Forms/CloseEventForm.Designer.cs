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
            autoLabel1.Location = new Point(135, 113);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(248, 57);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Close Event:";
            // 
            // closeEventEventNameLabel
            // 
            closeEventEventNameLabel.Font = new Font("Segoe UI", 18F);
            closeEventEventNameLabel.Location = new Point(389, 113);
            closeEventEventNameLabel.Name = "closeEventEventNameLabel";
            closeEventEventNameLabel.Size = new Size(248, 57);
            closeEventEventNameLabel.TabIndex = 1;
            closeEventEventNameLabel.Text = "Close Event:";
            // 
            // closeEventDataGrid
            // 
            closeEventDataGrid.AccessibleName = "Table";
            closeEventDataGrid.Location = new Point(135, 540);
            closeEventDataGrid.Name = "closeEventDataGrid";
            closeEventDataGrid.PreviewRowHeight = 49;
            closeEventDataGrid.Size = new Size(2486, 355);
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
            closeEventCancelButton.Location = new Point(2023, 1004);
            closeEventCancelButton.Name = "closeEventCancelButton";
            closeEventCancelButton.Size = new Size(284, 134);
            closeEventCancelButton.TabIndex = 4;
            closeEventCancelButton.Text = "Cancel";
            closeEventCancelButton.Click += closeEventCancelButton_Click;
            // 
            // closeEventCloseButton
            // 
            closeEventCloseButton.Font = new Font("Segoe UI Semibold", 12F);
            closeEventCloseButton.Location = new Point(2337, 1004);
            closeEventCloseButton.Name = "closeEventCloseButton";
            closeEventCloseButton.Size = new Size(284, 134);
            closeEventCloseButton.TabIndex = 5;
            closeEventCloseButton.Text = "Close Event";
            closeEventCloseButton.Click += closeEventCloseButton_Click;
            // 
            // autoLabel2
            // 
            autoLabel2.Font = new Font("Segoe UI", 16F);
            autoLabel2.Location = new Point(135, 303);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(224, 51);
            autoLabel2.TabIndex = 6;
            autoLabel2.Text = "Attendance:";
            // 
            // closeEventTicketsSoldLabel
            // 
            closeEventTicketsSoldLabel.Font = new Font("Segoe UI", 16F);
            closeEventTicketsSoldLabel.Location = new Point(356, 303);
            closeEventTicketsSoldLabel.Name = "closeEventTicketsSoldLabel";
            closeEventTicketsSoldLabel.Size = new Size(160, 51);
            closeEventTicketsSoldLabel.TabIndex = 7;
            closeEventTicketsSoldLabel.Text = "temptex";
            // 
            // closeEventTicketRevenue
            // 
            closeEventTicketRevenue.Font = new Font("Segoe UI", 16F);
            closeEventTicketRevenue.Location = new Point(513, 421);
            closeEventTicketRevenue.Name = "closeEventTicketRevenue";
            closeEventTicketRevenue.Size = new Size(110, 51);
            closeEventTicketRevenue.TabIndex = 9;
            closeEventTicketRevenue.Text = "temp";
            // 
            // autoLabel4
            // 
            autoLabel4.Font = new Font("Segoe UI", 16F);
            autoLabel4.Location = new Point(135, 421);
            autoLabel4.Name = "autoLabel4";
            autoLabel4.Size = new Size(372, 51);
            autoLabel4.TabIndex = 8;
            autoLabel4.Text = "Total Ticket Revenue:";
            // 
            // closeEventMessageLabel
            // 
            closeEventMessageLabel.Font = new Font("Segoe UI", 18F);
            closeEventMessageLabel.Location = new Point(135, 1004);
            closeEventMessageLabel.Name = "closeEventMessageLabel";
            closeEventMessageLabel.Size = new Size(248, 57);
            closeEventMessageLabel.TabIndex = 10;
            closeEventMessageLabel.Text = "Close Event:";
            // 
            // CloseEventForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2689, 1250);
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
            Name = "CloseEventForm";
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