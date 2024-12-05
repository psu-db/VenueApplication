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
    internal class venue_ticket
    {
        #region Table Attributes
        // Primary key
        public int tkt_id { get; set; } // DBMS will auto-generate this

        public int tkt_event_id { get; set; }
        public string tkt_section { get; set; }
        public int tkt_row { get; set; }
        public int tkt_seat_num { get; set; }
        public decimal  tkt_price { get; set; }
        public string tkt_status { get; set; }

        #endregion

        DatabaseManager databaseManager { get; set; }

        public venue_ticket(int tkt_event_id, string tkt_section, int tkt_row, int tkt_seat_num, decimal tkt_price, string tkt_status, DatabaseManager databaseManager)
        {
            this.tkt_event_id = tkt_event_id;
            this.tkt_section = tkt_section;
            this.tkt_row = tkt_row;
            this.tkt_seat_num = tkt_seat_num;
            this.tkt_price = tkt_price;
            this.tkt_status = tkt_status;
            this.databaseManager = databaseManager;
        }

        public venue_ticket(int tkt_event_id, string tkt_section, decimal tkt_price, string tkt_status, DatabaseManager databaseManager)
        {
            this.tkt_event_id = tkt_event_id;
            this.tkt_section = tkt_section;
            this.tkt_price = tkt_price;
            this.tkt_status = tkt_status;
            this.databaseManager = databaseManager;
        }


        public string CreateSQLBulkInsertQuery()
        {
            string query = VenueApplication.Properties.Resource.ticketCreate_BULKINSERT;

            return query;
        }



        public NpgsqlCommand AddWithValues(NpgsqlCommand command)
        {
            try
            {
                command.Parameters.AddWithValue("@eventid", tkt_event_id);
                command.Parameters.AddWithValue("@ticketsection", tkt_section);
                command.Parameters.AddWithValue("@ticketprice", tkt_price);
                command.Parameters.AddWithValue("@ticketstatus", tkt_status);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error while trying to add replace values in query: " + ex.Message);
            }

            return command;

        }
    }
}
