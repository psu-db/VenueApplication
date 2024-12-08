using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using VenueApplication.DataAccess;

namespace VenueApplication.Models
{
    public class venue_event
    {
        #region Table Attributes
        // Primary key
        public int event_id { get; set; } // DBMS will auto-generate this

        public DateOnly? event_date { get; set; }
        public TimeOnly event_time { get; set; }
        public string event_type { get; set; }
        public string event_description { get; set; }

        #endregion

        DatabaseManager databaseManager { get; set; }


        public venue_event(int event_id, DateOnly? event_date, TimeOnly event_time, string event_type, string event_description, DatabaseManager databaseManager)
        {
            this.event_id = event_id;
            this.event_date = event_date;
            this.event_time = event_time;
            this.event_type = event_type;
            this.event_description = event_description;
            this.databaseManager = databaseManager;
        }
        public venue_event(DateOnly? event_date, TimeOnly event_time, string event_type, string event_description, DatabaseManager databaseManager)
        {
            this.event_date = event_date;
            this.event_time = event_time;
            this.event_type = event_type;
            this.event_description = event_description;
            this.databaseManager = databaseManager;
        }


        public string CreateSQLInsertQuery()
        {
            string query = VenueApplication.Properties.Resource.eventCreate_INSERT;

            return query;
        }

        public string CreateSQLUpdateQuery()
        {
            string query = VenueApplication.Properties.Resource.eventCreate_UPDATE;

            return query;
        }
        public string CreateSQLGetTicketData()
        {
            string query = VenueApplication.Properties.Resource.eventSelectTicketData_SELECT;

            return query;
        }

        public NpgsqlCommand AddWithValues(NpgsqlCommand command)
        {
            try
            {
                command.Parameters.AddWithValue("@eventdate", event_date);
                command.Parameters.AddWithValue("@eventtime", event_time);
                command.Parameters.AddWithValue("@eventtype", event_type);
                command.Parameters.AddWithValue("@eventdescription", event_description);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error while trying to add replace values in query: " + ex.Message);
            }

            return command;

        }

        public NpgsqlCommand AddWithValuesID(NpgsqlCommand command)
        {
            try
            {
                command.Parameters.AddWithValue("@eventid", event_id);
                command.Parameters.AddWithValue("@eventdate", event_date);
                command.Parameters.AddWithValue("@eventtime", event_time);
                command.Parameters.AddWithValue("@eventtype", event_type);
                command.Parameters.AddWithValue("@eventdescription", event_description);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error while trying to add replace values in query: " + ex.Message);
            }

            return command;

        }
    }
}
