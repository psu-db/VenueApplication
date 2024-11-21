using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenueApplication.DataAccess;

namespace VenueApplication.Models
{
    internal class user_wallet
    {
        #region Table Attributes
        // Primary key
        public int wallet_id { get; set; } // DBMS will auto-generate this

        public int wallet_user_id { get; set; }

        #endregion

        DatabaseManager databaseManager { get; set; }

        public user_wallet(int wallet_user_id, DatabaseManager databaseManager)
        {
            this.wallet_user_id = wallet_user_id;
            this.databaseManager = databaseManager;
        }
    }
}
