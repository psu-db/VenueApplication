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
using Npgsql;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using VenueApplication.DataAccess;
using VenueApplication.Models;
using VenueApplication.Services;


namespace VenueApplication.Forms
{
    public partial class ManageTicketsForm : MetroForm
    {

        private MainForm mainForm;
        public DatabaseManager databaseManager;
        public venue_event selectedEvent;
        public ManageTicketsForm(MainForm mainForm, DatabaseManager databaseManager, venue_event selectedEvent)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.databaseManager = databaseManager;
            this.selectedEvent = selectedEvent;

            manageTicketsEventNameLabel.Text = this.selectedEvent.event_description;
        }

        private void manageTicketsCancelButton_Click(object sender, EventArgs e)
        {
            mainForm.InitializeEventManager();
            this.Close();
        }

        private void manageTicketsCreateButton_Click(object sender, EventArgs e)
        {
            string section = manageTicketsSectionComboBoxAdv.Text;
            decimal price = manageTicketsCurrencyTextBox.DecimalValue;
            int eventIDFK = this.selectedEvent.event_id;
            string ticketStatusCode = "SAL";

            if (section != "" && price >= 0 && eventIDFK >= 0 && ticketStatusCode != "")
            {
                bool ticketInsertAttemptResult = TicketService.AttemptTicketCreation(eventIDFK, section, price, ticketStatusCode, databaseManager);

                if (ticketInsertAttemptResult)
                {
                    manageTicketsEventNameLabel.Text = "";
                    manageTicketsCurrencyTextBox.DecimalValue = 1.00m;
                    manageTicketsSectionComboBoxAdv.Text = "";
                    manageTicketsErrorLabel.Text = "Successfully inserted event";
                    manageTicketsErrorLabel.ForeColor = Color.Green;
                    manageTicketsErrorLabel.Visible = true;
                    manageTicketsErrorLabel.Refresh();
                }
                else
                {
                    manageTicketsErrorLabel.Text = "An error occured during the insert process. Please wait and try again.";
                    manageTicketsErrorLabel.Visible = true;
                    manageTicketsErrorLabel.Refresh();
                }

            }
            else
            {
                manageTicketsErrorLabel.Text = "All fields must be filled in order to sign up.";
                manageTicketsErrorLabel.Visible = true;
                manageTicketsErrorLabel.Refresh();
            }
        }
    }
}
