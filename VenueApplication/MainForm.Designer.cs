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
            components = new System.ComponentModel.Container();
            backStageView1 = new Syncfusion.Windows.Forms.BackStageView(components);
            panel1 = new Panel();
            homeButton = new Syncfusion.WinForms.Controls.SfButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            profileButton = new Syncfusion.WinForms.Controls.SfButton();
            ticketWalletButton = new Syncfusion.WinForms.Controls.SfButton();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // backStageView1
            // 
            backStageView1.BackStage = null;
            backStageView1.HostControl = null;
            backStageView1.HostForm = this;
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
            // homeButton
            // 
            homeButton.Dock = DockStyle.Fill;
            homeButton.Font = new Font("Segoe UI Semibold", 9F);
            homeButton.ImageAlign = ContentAlignment.MiddleRight;
            homeButton.Location = new Point(3, 3);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(162, 37);
            homeButton.TabIndex = 0;
            homeButton.Text = "Home";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(homeButton, 0, 0);
            tableLayoutPanel1.Controls.Add(profileButton, 0, 1);
            tableLayoutPanel1.Controls.Add(ticketWalletButton, 0, 2);
            tableLayoutPanel1.Location = new Point(3, 70);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(156, 130);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // profileButton
            // 
            profileButton.Dock = DockStyle.Fill;
            profileButton.Font = new Font("Segoe UI Semibold", 9F);
            profileButton.Location = new Point(3, 46);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(162, 37);
            profileButton.TabIndex = 1;
            profileButton.Text = "Profile";
            // 
            // ticketWalletButton
            // 
            ticketWalletButton.Dock = DockStyle.Fill;
            ticketWalletButton.Font = new Font("Segoe UI Semibold", 9F);
            ticketWalletButton.Location = new Point(3, 89);
            ticketWalletButton.Name = "ticketWalletButton";
            ticketWalletButton.Size = new Size(162, 38);
            ticketWalletButton.TabIndex = 2;
            ticketWalletButton.Text = "My Tickets";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.Black;
            ClientSize = new Size(1847, 876);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.BackStageView backStageView1;
        private Panel panel1;
        private Syncfusion.WinForms.Controls.SfButton homeButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.WinForms.Controls.SfButton profileButton;
        private Syncfusion.WinForms.Controls.SfButton ticketWalletButton;
    }
}
