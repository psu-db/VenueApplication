using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
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

        public string CreateSQLInsertQuery()
        {
            string query = Properties.Resource.transactionCreate_INSERT;
            return query;
        }


        public NpgsqlCommand AddWithValues(NpgsqlCommand command)
        {
            try
            {
                command.Parameters.AddWithValue("@transpymtinfoid", trans_pymt_info_id);
                command.Parameters.AddWithValue("@transitmpurlocid", trans_itmpur_loc_id);
                command.Parameters.AddWithValue("@transeventid", trans_event_id);
                command.Parameters.AddWithValue("@transtimestamp", trans_timestamp);
                command.Parameters.AddWithValue("@transquantity", trans_quantity);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error while trying to add replace values in query: " + ex.Message);
            }

            return command;

        }
    }
}
