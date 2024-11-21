using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenueApplication.DataAccess;

namespace VenueApplication.Models
{
    internal class app_user
    {
        #region Table Attributes
        // Primary key
        public int user_id { get; set; } // DBMS will auto-generate this

        public string user_fname { get; set; }
        public string user_lname { get; set; }
        public DateTime user_birthday { get; set; }
        public decimal user_balance { get; set; }
        public string user_type { get; set; }

        #endregion

        DatabaseManager databaseManager { get; set; }

        public app_user(string user_fname, string user_lname, DateTime user_birthday, decimal user_balance, string user_type, DatabaseManager databaseManager)
        {
            this.user_fname = user_fname;
            this.user_lname = user_lname;
            this.user_birthday = user_birthday;
            this.user_balance = user_balance;
            this.user_type = user_type;
            this.databaseManager = databaseManager;
        }
    }
}
