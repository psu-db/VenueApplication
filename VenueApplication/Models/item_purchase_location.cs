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
    internal class item_purchase_location
    {

        #region Table Attributes
        // Primary key
        public int itmpur_loc_id { get; set; } // DBMS will auto-generate this

        public int itmpur_item_id { get; set; }
        public int itmpur_store_id { get; set; }

        #endregion

        DatabaseManager databaseManager { get; set; }

        public item_purchase_location(int itmpur_item_id, int itmpur_store_id, DatabaseManager databaseManager)
        {
            this.itmpur_item_id = itmpur_item_id;
            this.itmpur_store_id = itmpur_store_id;
            this.databaseManager = databaseManager;
        }


        //public string CreateSQLInsertQuery()
        //{
        //string query = Properties.Resource.itemPurchaseLocationCreate_INSERT;
        //return query;
        //}


        public NpgsqlCommand AddWithValues(NpgsqlCommand command)
        {
            try
            {
                command.Parameters.AddWithValue("@itmpuritemid", itmpur_item_id);
                command.Parameters.AddWithValue("@itmpurstoreid", itmpur_store_id);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error while trying to add replace values in query: " + ex.Message);
            }

            return command;

        }
    }
}
