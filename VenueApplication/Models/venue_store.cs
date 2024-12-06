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
    internal class venue_store
    {
        #region Table Attributes
        // Primary key
        public int store_id { get; set; } // DBMS will auto-generate this

        public string store_name { get; set; }
        public string store_section_location { get; set; }
        public string store_type { get; set; }

        #endregion

        DatabaseManager databaseManager { get; set; }

        public venue_store(string store_name, string store_section_location, string store_type, DatabaseManager databaseManager)
        {
            this.store_name = store_name;
            this.store_section_location = store_section_location;
            this.store_type = store_type;
            this.databaseManager = databaseManager;
        }


        public string CreateSQLInsertQuery()
        {
            string query = Properties.Resource.storeCreate_INSERT;

            return query;
        }


        public NpgsqlCommand AddWithValues(NpgsqlCommand command)
        {
            try
            {
                command.Parameters.AddWithValue("@storename", store_name);
                command.Parameters.AddWithValue("@storesectionlocation", store_section_location);
                command.Parameters.AddWithValue("@storetype", store_type);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error while trying to add replace values in query: " + ex.Message);
            }

            return command;

        }
    }
}
