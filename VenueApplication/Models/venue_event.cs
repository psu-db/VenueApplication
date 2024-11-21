using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenueApplication.DataAccess;

namespace VenueApplication.Models
{
    internal class venue_event
    {
        #region Table Attributes
        // Primary key
        public int event_id { get; set; } // DBMS will auto-generate this

        public DateOnly event_date { get; set; }
        public TimeOnly event_time { get; set; }
        public string event_type { get; set; }
        public string event_description { get; set; }

        #endregion

        DatabaseManager databaseManager { get; set; }

        public venue_event(DateOnly event_date, TimeOnly event_time, string event_type, string event_description, DatabaseManager databaseManager)
        {
            this.event_date = event_date;
            this.event_time = event_time;
            this.event_type = event_type;
            this.event_description = event_description;
            this.databaseManager = databaseManager;
        }
    }
}
