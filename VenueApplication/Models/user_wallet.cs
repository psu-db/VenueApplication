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
    public class user_wallet
    {
        #region Table Attributes
        // Primary key
        public int wallet_id { get; set; } // DBMS will auto-generate this

        public int wallet_user_id { get; set; }

        #endregion

        DatabaseManager databaseManager { get; set; }

        public user_wallet(int wallet_id, int wallet_user_id, DatabaseManager databaseManager)
        {
            this.wallet_id = wallet_id;
            this.wallet_user_id = wallet_user_id;
            this.databaseManager = databaseManager;
        }
        public user_wallet(DatabaseManager databaseManager)
        {
            this.databaseManager = databaseManager;
        }

        
        public string CreateSQLInsertQuery()
        {
            string query = VenueApplication.Properties.Resource.userWallet_INSERT;

            return query;
        }
        

    }
}
