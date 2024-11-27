using Npgsql;
using Syncfusion.Styles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenueApplication.DataAccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VenueApplication.Models
{
    internal class app_user
    {
        #region Table Attributes
        // Primary key
        public int user_id { get; set; } // DBMS will auto-generate this

        public string user_fname { get; set; }
        public string user_lname { get; set; }
        public DateOnly? user_birthday { get; set; }
        public decimal user_balance { get; set; }
        public string user_type { get; set; }

        #endregion

        #region Reference Tables

        login_credentials login_credentials { get; set; }

        #endregion

        DatabaseManager databaseManager { get; set; }

        public app_user(string user_fname, string user_lname, DateOnly? user_birthday, decimal user_balance, string user_type, login_credentials login_creds, DatabaseManager databaseManager)
        {
            this.user_fname = user_fname;
            this.user_lname = user_lname;
            this.user_birthday = user_birthday;
            this.user_balance = user_balance;
            this.user_type = user_type;
            this.login_credentials = login_creds;
            this.databaseManager = databaseManager;
        }

        /// <summary>
        /// Performs an insert of a new user and necessary child tables for a user (creates a user and login credential record for the new user)
        /// </summary>
        /// <returns> boolean, true if sql insert was successful, false if failed</returns>
        public string CreateSQLInsertQuery()
        {
            string query = VenueApplication.Properties.Resource.userCreate_INSERT;
            string loginCredsQuery = login_credentials.CreateSQLInsertQuery();
            query = query.Replace("--[INSERT LOGINCREDS]", loginCredsQuery);

            return query;
        }

        public NpgsqlCommand AddWithValues(NpgsqlCommand command)
        {
            try
            {
                command.Parameters.AddWithValue("@firstname", user_fname);
                command.Parameters.AddWithValue("@lastname", user_lname);
                command.Parameters.AddWithValue("@birthday", user_birthday);
                command.Parameters.AddWithValue("@balance", user_balance);
                command.Parameters.AddWithValue("@type", user_type);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error while trying to add replace values in query: " + ex.Message);
            }

            return command;

        }
    }
}
