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
            scanTicketsWelcomeLabel.Location = new Point(94, 75);
            scanTicketsWelcomeLabel.Margin = new Padding(2, 0, 2, 0);
            scanTicketsWelcomeLabel.Name = "scanTicketsWelcomeLabel";
            scanTicketsWelcomeLabel.Size = new Size(357, 32);
            scanTicketsWelcomeLabel.TabIndex = 1;
            scanTicketsWelcomeLabel.Text = "Welcome to Beaver Stadium for:";
            // 
            // scanTicketTextBox
            // 
            scanTicketTextBox.BeforeTouchSize = new Size(104, 39);
            scanTicketTextBox.Font = new Font("Segoe UI", 18F);
            scanTicketTextBox.Location = new Point(269, 213);
            scanTicketTextBox.Margin = new Padding(2, 2, 2, 2);
            scanTicketTextBox.Name = "scanTicketTextBox";
            scanTicketTextBox.Size = new Size(104, 39);
            scanTicketTextBox.TabIndex = 2;
            // 
            // scanTicketIdLabel
            // 
            scanTicketIdLabel.Font = new Font("Segoe UI", 18F);
            scanTicketIdLabel.Location = new Point(138, 213);
            scanTicketIdLabel.Margin = new Padding(2, 0, 2, 0);
            scanTicketIdLabel.Name = "scanTicketIdLabel";
            scanTicketIdLabel.Size = new Size(112, 32);
            scanTicketIdLabel.TabIndex = 5;
            scanTicketIdLabel.Text = "Ticket ID:";
            // 
            // scanTicketEventName
            // 
            scanTicketEventName.AutoSize = false;
            scanTicketEventName.Font = new Font("Segoe UI", 18F);
            scanTicketEventName.Location = new Point(41, 120);
            scanTicketEventName.Margin = new Padding(2, 0, 2, 0);
            scanTicketEventName.Name = "scanTicketEventName";
            scanTicketEventName.Size = new Size(433, 56);
            scanTicketEventName.TabIndex = 6;
            scanTicketEventName.Text = "event name";
            scanTicketEventName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scanTicketMessageLabel
            // 
            scanTicketMessageLabel.AutoSize = false;
            scanTicketMessageLabel.Font = new Font("Segoe UI", 24F);
            scanTicketMessageLabel.Location = new Point(41, 406);
            scanTicketMessageLabel.Margin = new Padding(2, 0, 2, 0);
            scanTicketMessageLabel.Name = "scanTicketMessageLabel";
            scanTicketMessageLabel.Size = new Size(433, 50);
            scanTicketMessageLabel.TabIndex = 7;
            scanTicketMessageLabel.Text = "message label";
            scanTicketMessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            scanTicketMessageLabel.Visible = false;
            // 
            // scanTicketCancelButton
            // 
            scanTicketCancelButton.Font = new Font("Segoe UI Semibold", 12F);
            scanTicketCancelButton.Location = new Point(59, 295);
            scanTicketCancelButton.Margin = new Padding(2, 2, 2, 2);
            scanTicketCancelButton.Name = "scanTicketCancelButton";
            scanTicketCancelButton.Size = new Size(185, 44);
            scanTicketCancelButton.TabIndex = 8;
            scanTicketCancelButton.Text = "Cancel";
            scanTicketCancelButton.Click += scanTicketCancelButton_Click;
            // 
            // scanTicketScanButton
            // 
            scanTicketScanButton.Font = new Font("Segoe UI Semibold", 12F);
            scanTicketScanButton.Location = new Point(262, 295);
            scanTicketScanButton.Margin = new Padding(2, 2, 2, 2);
            scanTicketScanButton.Name = "scanTicketScanButton";
            scanTicketScanButton.Size = new Size(185, 44);
            scanTicketScanButton.TabIndex = 9;
            scanTicketScanButton.Text = "Scan";
            scanTicketScanButton.Click += scanTicketScanButton_Click;
            // 
            // ScanTicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 533);
            Controls.Add(scanTicketScanButton);
            Controls.Add(scanTicketCancelButton);
            Controls.Add(scanTicketMessageLabel);
            Controls.Add(scanTicketEventName);
            Controls.Add(scanTicketIdLabel);
            Controls.Add(scanTicketTextBox);
            Controls.Add(scanTicketsWelcomeLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "ScanTicketForm";
            StartPosition = FormStartPosition.CenterScreen;
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