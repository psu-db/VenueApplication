using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Syncfusion.Windows.Forms.Tools.Win32API;
using VenueApplication.DataAccess;

namespace VenueApplication.Models
{
    public class venue_item
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

        public venue_item(int item_id, string item_name, decimal item_price, DatabaseManager databaseManager)
        {
            this.item_id = item_id;
            this.item_name = item_name;
            this.item_price = item_price;
            this.databaseManager = databaseManager;
        }



        public string CreateSQLInsertQuery()
        {
            string query = Properties.Resource.itemCreate_INSERT;
            return query;
        }


        public NpgsqlCommand AddWithValues(NpgsqlCommand command)
        {
            try
            {
                command.Parameters.AddWithValue("@itemname", item_name);
                command.Parameters.AddWithValue("@itemprice", item_price);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error while trying to add replace values in query: " + ex.Message);
            }

            return command;

        }

    }
}
