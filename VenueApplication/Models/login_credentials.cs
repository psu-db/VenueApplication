using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenueApplication.DataAccess;

namespace VenueApplication.Models
{
    internal class login_credentials
    {
        #region Table Attributes
        // Primary key
        public int lgn_creds_id { get; set; } // DBMS will auto-generate this

        public int lgn_user_id { get; set; }
        public string lgn_username { get; set; }
        public string lgn_password { get; set; }
        public string lgn_email { get; set; }

        #endregion

        DatabaseManager databaseManager { get; set; }

        public login_credentials(int lgn_user_id, string lgn_username, string lgn_password, string lgn_email, DatabaseManager databaseManager)
        {
            this.lgn_user_id = lgn_user_id;
            this.lgn_username = lgn_username;
            this.lgn_password = lgn_password;
            this.lgn_email = lgn_email;
            this.databaseManager = databaseManager;
        }
    }
}
