using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenueApplication.DataAccess;

namespace VenueApplication.Models
{
    internal class ticket_purchase
    {
        #region Table Attributes
        // Primary key
        public int tktpur_id { get; set; } // DBMS will auto-generate this

        public int tktpur_tkt_id { get; set; }
        public DateOnly tktpur_date { get; set; }
        public int tktpur_wallet_id { get; set; }

        #endregion

        DatabaseManager databaseManager { get; set; }

        public ticket_purchase(int tktpur_tkt_id, DateOnly tktpur_date, int tktpur_wallet_id, DatabaseManager databaseManager)
        {
            this.tktpur_tkt_id = tktpur_tkt_id;
            this.tktpur_date = tktpur_date;
            this.tktpur_wallet_id = tktpur_wallet_id;
            this.databaseManager = databaseManager;
        }

        public string CreateSQLInsertQuery()
        {
            string query = VenueApplication.Properties.Resource.ticketPurchase_INSERT;

            return query;
        }

        public NpgsqlCommand AddWithValues(NpgsqlCommand command, string ticket_status, string ticket_id)
        {
            try
            {
                command.Parameters.AddWithValue("@ticket_id", tktpur_tkt_id);
                command.Parameters.AddWithValue("@ticket_pur_date", tktpur_date);
                command.Parameters.AddWithValue("@ticket_wallet_id", tktpur_wallet_id);
                command.Parameters.AddWithValue("@ticket_status", ticket_status);
                command.Parameters.AddWithValue("@ticket_id", ticket_id);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error while trying to add replace values in query: " + ex.Message);
            }

            return command;

        }
    }
}
