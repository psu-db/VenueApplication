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
    public class report_data
    {
        #region Table Attributes
        public string email { get; set; }
        public string item_name { get; set; }
        public string store_name { get; set; }
        public string payment_type { get; set; }
        public decimal total_spent { get; set; }


        #endregion

        DatabaseManager databaseManager { get; set; }

        public report_data(string email, string item_name, string store_name, string payment_type, decimal total_spent, DatabaseManager databaseManager)
        {
            this.email = email;
            this.item_name = item_name;
            this.store_name = store_name;
            this.payment_type = payment_type;
            this.total_spent = total_spent;


            this.databaseManager = databaseManager;
        }

        public string CreateSQLSelect()
        {
            string query = Properties.Resource.eventDataTransactions_SELECT;
            return query;
        }


        

        //public NpgsqlCommand AddWithValuesId(NpgsqlCommand command)
        //{
        //    try
        //    {
        //        command.Parameters.AddWithValue("@itemid", item_id);
        //        command.Parameters.AddWithValue("@itemname", item_name);
        //        command.Parameters.AddWithValue("@itemprice", item_price);
        //        command.Parameters.AddWithValue("@itemstoreid", item_store_id);
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine("Error while trying to add replace values in query: " + ex.Message);
        //    }

        //    return command;

        //}

        

    }
}

