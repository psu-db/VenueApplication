namespace VenueApplication.Forms
{
    partial class ScanTicketForm
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
            scanTicketsWelcomeLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            scanTicketTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            scanTicketIdLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            scanTicketEventName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            scanTicketMessageLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            scanTicketCancelButton = new Syncfusion.WinForms.Controls.SfButton();
            scanTicketScanButton = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)scanTicketTextBox).BeginInit();
            SuspendLayout();
            // 
            // scanTicketsWelcomeLabel
            // 
            scanTicketsWelcomeLabel.Font = new Font("Segoe UI", 18F);
            scanTicketsWelcomeLabel.Location = new Point(661, 100);
            scanTicketsWelcomeLabel.Name = "scanTicketsWelcomeLabel";
            scanTicketsWelcomeLabel.Size = new Size(620, 57);
            scanTicketsWelcomeLabel.TabIndex = 1;
            scanTicketsWelcomeLabel.Text = "Welcome to Beaver Stadium for:";
            // 
            // scanTicketTextBox
            // 
            scanTicketTextBox.BeforeTouchSize = new Size(175, 63);
            scanTicketTextBox.Font = new Font("Segoe UI", 18F);
            scanTicketTextBox.Location = new Point(993, 452);
            scanTicketTextBox.Name = "scanTicketTextBox";
            scanTicketTextBox.Size = new Size(175, 63);
            scanTicketTextBox.TabIndex = 2;
            scanTicketTextBox.KeyPress += scanTicketTextBox_KeyPress;
            // 
            // scanTicketIdLabel
            // 
            scanTicketIdLabel.Font = new Font("Segoe UI", 18F);
            scanTicketIdLabel.Location = new Point(768, 452);
            scanTicketIdLabel.Name = "scanTicketIdLabel";
            scanTicketIdLabel.Size = new Size(194, 57);
            scanTicketIdLabel.TabIndex = 5;
            scanTicketIdLabel.Text = "Ticket ID:";
            // 
            // scanTicketEventName
            // 
            scanTicketEventName.AutoSize = false;
            scanTicketEventName.Font = new Font("Segoe UI", 18F);
            scanTicketEventName.Location = new Point(1, 228);
            scanTicketEventName.Name = "scanTicketEventName";
            scanTicketEventName.Size = new Size(1936, 113);
            scanTicketEventName.TabIndex = 6;
            scanTicketEventName.Text = "event name";
            scanTicketEventName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scanTicketMessageLabel
            // 
            scanTicketMessageLabel.AutoSize = false;
            scanTicketMessageLabel.Font = new Font("Segoe UI", 24F);
            scanTicketMessageLabel.Location = new Point(12, 825);
            scanTicketMessageLabel.Name = "scanTicketMessageLabel";
            scanTicketMessageLabel.Size = new Size(1925, 82);
            scanTicketMessageLabel.TabIndex = 7;
            scanTicketMessageLabel.Text = "message label";
            scanTicketMessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            scanTicketMessageLabel.Visible = false;
            // 
            // scanTicketCancelButton
            // 
            scanTicketCancelButton.Font = new Font("Segoe UI Semibold", 12F);
            scanTicketCancelButton.Location = new Point(633, 615);
            scanTicketCancelButton.Name = "scanTicketCancelButton";
            scanTicketCancelButton.Size = new Size(317, 88);
            scanTicketCancelButton.TabIndex = 8;
            scanTicketCancelButton.Text = "Cancel";
            scanTicketCancelButton.Click += scanTicketCancelButton_Click;
            // 
            // scanTicketScanButton
            // 
            scanTicketScanButton.Font = new Font("Segoe UI Semibold", 12F);
            scanTicketScanButton.Location = new Point(981, 615);
            scanTicketScanButton.Name = "scanTicketScanButton";
            scanTicketScanButton.Size = new Size(317, 88);
            scanTicketScanButton.TabIndex = 9;
            scanTicketScanButton.Text = "Scan";
            scanTicketScanButton.Click += scanTicketScanButton_Click;
            // 
            // ScanTicketForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1949, 1065);
            Controls.Add(scanTicketScanButton);
            Controls.Add(scanTicketCancelButton);
            Controls.Add(scanTicketMessageLabel);
            Controls.Add(scanTicketEventName);
            Controls.Add(scanTicketIdLabel);
            Controls.Add(scanTicketTextBox);
            Controls.Add(scanTicketsWelcomeLabel);
            Name = "ScanTicketForm";
            Text = "ScanTicketForm";
            ((System.ComponentModel.ISupportInitialize)scanTicketTextBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel scanTicketsWelcomeLabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt scanTicketTextBox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel scanTicketIdLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel scanTicketEventName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel scanTicketMessageLabel;
        private Syncfusion.WinForms.Controls.SfButton scanTicketCancelButton;
        private Syncfusion.WinForms.Controls.SfButton scanTicketScanButton;
    }
}