using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenueApplication.DataAccess;
using static Syncfusion.Windows.Forms.Tools.NavigationView;

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

        public login_credentials(string lgn_username, string lgn_password, string lgn_email, DatabaseManager databaseManager)
        {
            this.lgn_username = lgn_username;
            this.lgn_password = lgn_password;
            this.lgn_email = lgn_email;
            this.databaseManager = databaseManager;
        }

        public string CreateSQLInsertQuery()
        {
            string query = VenueApplication.Properties.Resource.userLoginCreds_INSERT;

            return query;
        }

        public NpgsqlCommand AddWithValues(NpgsqlCommand command)
        {
            try
            {
                command.Parameters.AddWithValue("@username", lgn_username);
                command.Parameters.AddWithValue("@password", lgn_password);
                command.Parameters.AddWithValue("@email", lgn_email);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error while trying to add replace values in LOGIN_CREDENTIALS query: " + ex.Message);
            }

            return command;

        }
    }
}
