using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenueApplication.DataAccess;

namespace VenueApplication.Models
{
    internal class payment_info
    {
        #region Table Attributes
        // Primary key
        public int pymt_info_id { get; set; } // DBMS will auto-generate this

        public int pymt_info_user_id { get; set; }
        public string pymt_info_type { get; set; }
        public string pymt_info_card_number { get; set; }
        public string pymt_info_card_cvv { get; set; }
        public string pymt_info_expiration_date { get; set; } // FORMAT MM/YY
        public string pymt_info_address { get; set; }
        public string pymt_info_address_state { get; set; }
        public string pymt_info_zipcode { get; set; }

        #endregion

        DatabaseManager databaseManager { get; set; }

        public payment_info(int pymt_info_user_id, string pymt_info_type, string pymt_info_card_number, string pymt_info_card_cvv, string pymt_info_expiration_date, string pymt_info_address, string pymt_info_address_state, string pymt_info_zipcode, DatabaseManager databaseManager)
        {
            this.pymt_info_user_id = pymt_info_user_id;
            this.pymt_info_type = pymt_info_type;
            this.pymt_info_card_number = pymt_info_card_number;
            this.pymt_info_card_cvv = pymt_info_card_cvv;
            this.pymt_info_expiration_date = pymt_info_expiration_date;
            this.pymt_info_address = pymt_info_address;
            this.pymt_info_address_state = pymt_info_address_state;
            this.pymt_info_zipcode = pymt_info_zipcode;
            this.databaseManager = databaseManager;
        }

        /*
        public string CreateSQLInsertQuery()
        {
            string query = VenueApplication.Properties.Resource.userCreate_INSERT;


            return query;
        }
        */
    }
}
