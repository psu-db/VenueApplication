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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace VenueApplication.Forms
{
    public partial class EditEventForm : MetroForm
    {

        private MainForm mainForm;
        public DatabaseManager databaseManager;
        public venue_event selectedEvent;
        public EditEventForm(MainForm mainForm, DatabaseManager databaseManager, venue_event selectedEvent)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.databaseManager = databaseManager;
            this.selectedEvent = selectedEvent;

            //populate the event date calender with event date
            if (this.selectedEvent.event_date.HasValue)
            {
                editEventCalender.SelectedDate = this.selectedEvent.event_date.Value.ToDateTime(TimeOnly.MinValue);

            }

            //populate the hour and minute dropdowns with the event time
            string timeHour = this.selectedEvent.event_time.Hour.ToString("D2");
            string formattedTime = this.selectedEvent.event_time.ToString("hh:mm tt");
            editEventMinuteComboBoxAdv.SelectedItem = formattedTime.Substring(3, 2);
            editEventHourComboBoxAdv.SelectedItem = formattedTime.Substring(0, 2);
            int intHour = int.Parse(timeHour);
            if (intHour > 11)
            {
                editEventAMPMComboBoxAdv.SelectedItem = "PM";
            }
            else
            {
                editEventAMPMComboBoxAdv.SelectedItem = "PM";
            }

            editEventTypeComboBoxAdv.SelectedItem = this.selectedEvent.event_type;
            editEventDescriptionTextBoxExt.Text = this.selectedEvent.event_description;
        }

        private void sfButton3_Click(object sender, EventArgs e)
        {
            mainForm.InitializeEventManager();
            this.Close();
        }

        private void editEventUpdateButton_Click(object sender, EventArgs e)
        {
            string eventHour = editEventHourComboBoxAdv.Text;
            string eventMinute = editEventMinuteComboBoxAdv.Text;
            string eventAMPM = editEventAMPMComboBoxAdv.Text;
            string eventType = editEventTypeComboBoxAdv.Text;
            string eventDescription = editEventDescriptionTextBoxExt.Text;
            DateTime? eventDate = editEventCalender.SelectedDate;
            DateOnly? eventDateOnly = null;
            int event_id = this.selectedEvent.event_id;
            if (eventDate.HasValue)
            {
                // Convert DateTime to DateOnly
                eventDateOnly = DateOnly.FromDateTime(eventDate.Value);

                // Convert DateOnly to string in the correct format (YYYY-MM-DD)
            }

            if (eventDateOnly != null && eventHour != "" && eventMinute != "" && eventAMPM != "" && eventType != "" && eventDescription != "")
            {

                string buildTime = eventHour + ":" + eventMinute + " " + eventAMPM;
                TimeOnly parsedTime = TimeOnly.Parse(buildTime);
                //string time24Hour = parsedTime.ToString("HH:mm");
                //Debug.WriteLine(time24Hour);

                bool updateEventResults = NewEventService.AttemptEventUpdate(event_id, eventDateOnly, parsedTime, eventType, eventDescription, databaseManager);

                if (updateEventResults)
                {
                    mainForm.InitializeEventManager();
                    this.Close();
                }
                else
                {
                    editEventErrorLabel.Text = "An error occured. Please wait and try again.";
                    editEventErrorLabel.Visible = true;
                    editEventErrorLabel.Refresh();
                }


            }
            else
            {
                editEventErrorLabel.Text = "All fields must be filled in order to create an event";
                editEventErrorLabel.Visible = true;
                editEventErrorLabel.Refresh();
            }
        }
    }
}
