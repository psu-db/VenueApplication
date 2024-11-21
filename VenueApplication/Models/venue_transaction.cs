using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenueApplication.DataAccess;

namespace VenueApplication.Models
{
    internal class venue_transaction
    {
        #region Table Attributes
        // Primary key
        public int trans_id { get; set; } // DBMS will auto-generate this

        public int trans_pymt_info_id { get; set; }
        public int trans_itmpur_loc_id { get; set; }
        public int trans_event_id { get; set; }
        public DateTime trans_timestamp { get; set; }
        public int trans_quantity { get; set; }

        #endregion

        DatabaseManager databaseManager { get; set; }

        public venue_transaction(int trans_pymt_info_id, int trans_itmpur_loc_id, int trans_event_id, DateTime trans_timestamp, int trans_quantity, DatabaseManager databaseManager)
        {
            this.trans_pymt_info_id = trans_pymt_info_id;
            this.trans_itmpur_loc_id = trans_itmpur_loc_id;
            this.trans_event_id = trans_event_id;
            this.trans_timestamp = trans_timestamp;
            this.trans_quantity = trans_quantity;
            this.databaseManager = databaseManager;
        }
    }
}
