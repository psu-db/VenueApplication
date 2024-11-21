using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenueApplication.DataAccess;

namespace VenueApplication.Models
{
    internal class ticket_status_code
    {
        #region Table Attributes
        // Primary key
        public string tkt_status_code { get; set; }

        public int tkt_status_code_desc { get; set; }

        #endregion

        DatabaseManager databaseManager { get; set; }

        public ticket_status_code(string tkt_status_code, int tkt_status_code_desc, DatabaseManager databaseManager)
        {
            this.tkt_status_code = tkt_status_code;
            this.tkt_status_code_desc = tkt_status_code_desc;
            this.databaseManager = databaseManager;
        }
    }
}
