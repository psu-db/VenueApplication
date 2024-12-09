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
using Syncfusion.Windows.Forms;
using VenueApplication.DataAccess;
using VenueApplication.Models;
using VenueApplication.Services;

namespace VenueApplication.Forms
{
    public partial class ScanTicketForm : MetroForm
    {

        private MainForm mainForm;
        public DatabaseManager databaseManager;
        public venue_event selectedEvent;
        public ScanTicketForm(MainForm mainForm, DatabaseManager databaseManager, venue_event selectedEvent)
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.mainForm = mainForm;
            this.databaseManager = databaseManager;
            this.selectedEvent = selectedEvent;


            scanTicketEventName.Text = this.selectedEvent.event_description;

        }

        private void scanTicketCancelButton_Click(object sender, EventArgs e)
        {
            mainForm.InitializeEventManager();
            this.Close();
        }

        private void showRedMessage()
        {
            scanTicketMessageLabel.Visible = true;
            scanTicketMessageLabel.ForeColor = Color.Red;
        }

        private void showGreenMessage()
        {
            scanTicketMessageLabel.Visible = true;
            scanTicketMessageLabel.ForeColor = Color.Green;
        }

        private void scanTicketScanButton_Click(object sender, EventArgs e)
        {
            int? ticketID;
            try
            {
                ticketID = int.Parse(scanTicketTextBox.Text);
            }
            catch
            {
                scanTicketMessageLabel.Text = "Enter a valid ticket ID";
                showRedMessage();
                return;
            }


            if (ticketID != null)
            {
                bool scanAttemptResult = TicketService.AttemptScan((int)ticketID, databaseManager);

                if (scanAttemptResult)
                {
                    scanTicketMessageLabel.Text = "Scan successful";
                    showGreenMessage();
                    scanTicketTextBox.Text = "";

                }
                else
                {
                    // update error message
                    scanTicketMessageLabel.Text = $"no ticket with the ID {ticketID} exists. Try again";
                    showRedMessage();
                }
            }
            else
            {
                // update error message - one or more fields are empty
                scanTicketMessageLabel.Text = "an error occurred. Try again";
                showRedMessage();
            }
        }

        private void scanTicketTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key is a letter
            if (char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Suppress the keypress
            }
        }
    }
}
