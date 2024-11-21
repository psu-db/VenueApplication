using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenueApplication.DataAccess;

namespace VenueApplication.Models
{
    internal class venue_item
    {
        #region Table Attributes
        // Primary key
        public int item_id { get; set; } // DBMS will auto-generate this

        public string item_name { get; set; }
        public decimal item_price { get; set; }

        #endregion

        DatabaseManager databaseManager { get; set; }

        public venue_item(string item_name, decimal item_price, DatabaseManager databaseManager)
        {
            this.item_name = item_name;
            this.item_price = item_price;
            this.databaseManager = databaseManager;
        }
    }
}
