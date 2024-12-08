﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VenueApplication.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VenueApplication.Properties.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap beaverStaidumLoginBackgroundImage_webp {
            get {
                object obj = ResourceManager.GetObject("beaverStaidumLoginBackgroundImage.webp", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM venue_transaction
        ///WHERE trans_event_id = @eventid;
        ///
        ///DELETE from ticket_purchase
        ///WHERE tktpur_tkt_id IN (SELECT tkt_id
        ///   FROM venue_ticket
        ///   WHERE tkt_event_id = @eventid);
        ///
        ///DELETE FROM venue_ticket
        ///WHERE tkt_event_id = @eventid;
        ///
        ///
        ///DELETE FROM venue_event
        ///WHERE event_id = @eventid;.
        /// </summary>
        internal static string close_event_DELETE {
            get {
                return ResourceManager.GetString("close_event_DELETE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO venue_event(event_date, event_time, event_type, event_description)
        ///VALUES(@eventdate, @eventtime, @eventtype, @eventdescription);.
        /// </summary>
        internal static string eventCreate_INSERT {
            get {
                return ResourceManager.GetString("eventCreate_INSERT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE venue_event
        ///SET event_date = @eventdate, event_time = @eventtime, event_type = @eventtype, event_description = @eventdescription
        ///WHERE event_id = @eventid;.
        /// </summary>
        internal static string eventCreate_UPDATE {
            get {
                return ResourceManager.GetString("eventCreate_UPDATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT 
        ///    lgn_email, 
        ///    item_name, 
        ///    store_name, 
        ///    pymt_info_type, 
        ///    SUM(item_price * trans_quantity) AS total_spent
        ///FROM venue_transaction
        ///JOIN payment_info ON trans_pymt_info_id = pymt_info_id
        ///JOIN app_user ON pymt_info_user_id = user_id
        ///JOIN venue_item ON trans_item_id = item_id
        ///JOIN venue_store ON item_store_id = store_id
        ///JOIN login_credentials ON lgn_user_id = user_id
        ///WHERE trans_event_id = 6
        ///GROUP BY 
        ///    lgn_email, 
        ///    item_name, 
        ///    store_name, 
        ///    pymt_info_type
        ///ORDER BY total_spent [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string eventDataTransactions_SELECT {
            get {
                return ResourceManager.GetString("eventDataTransactions_SELECT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT COUNT(*) AS num_tickets_sold, SUM(tkt_price) AS total_ticket_revenue
        ///FROM venue_ticket 
        ///WHERE tkt_status = &apos;SCN&apos;
        ///AND tkt_event_id = @eventid;.
        /// </summary>
        internal static string eventSelectTicketData_SELECT {
            get {
                return ResourceManager.GetString("eventSelectTicketData_SELECT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM venue_item
        ///WHERE item_id = @itemid;.
        /// </summary>
        internal static string item_DELETE {
            get {
                return ResourceManager.GetString("item_DELETE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM venue_item
        ///WHERE item_store_id = @itemstoreid;.
        /// </summary>
        internal static string item_on_store_SELECT {
            get {
                return ResourceManager.GetString("item_on_store_SELECT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE venue_item
        ///SET item_name = @itemname, item_price = @itemprice
        ///WHERE item_id = @itemid AND item_store_id = @itemstoreid;.
        /// </summary>
        internal static string item_UPDATE {
            get {
                return ResourceManager.GetString("item_UPDATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO venue_item(item_name,item_price,item_store_id)
        ///VALUES(@itemname, @itemprice,@itemstoreid);.
        /// </summary>
        internal static string itemCreate_INSERT {
            get {
                return ResourceManager.GetString("itemCreate_INSERT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE venue_ticket
        ///SET tkt_status = &apos;RSL&apos;
        ///WHERE tkt_id = @ticket_id;.
        /// </summary>
        internal static string myTickets_UPDATE {
            get {
                return ResourceManager.GetString("myTickets_UPDATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Payment_info(pymt_info_user_id, pymt_info_type, pymt_info_card_number, pymt_info_card_cvv, pymt_info_expiration_date, pymt_info_address, pymt_info_address_state, pymt_info_zipcode)
        ///VALUES(@user_id, @card_type, @card_number, @card_cvv, @exp_date, @address, @state, @zipcode); .
        /// </summary>
        internal static string paymentMethod_INSERT {
            get {
                return ResourceManager.GetString("paymentMethod_INSERT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM payment_info
        ///WHERE pymt_info_user_id = @user_id;.
        /// </summary>
        internal static string paymentMethods_SELECT {
            get {
                return ResourceManager.GetString("paymentMethods_SELECT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap pngtree_avatar_icon_profile_member_login_vector_isolated_silhouette_transparent_png_image_7111828 {
            get {
                object obj = ResourceManager.GetObject("pngtree-avatar-icon-profile-member-login-vector-isolated-silhouette-transparent-p" +
                        "ng-image_7111828", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM venue_store WHERE store_id = @storeid;.
        /// </summary>
        internal static string store_DELETE {
            get {
                return ResourceManager.GetString("store_DELETE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO venue_store(store_name, store_section_location, store_type)
        ///VALUES(@storename, @storesectionlocation, @storetype);.
        /// </summary>
        internal static string storeCreate_INSERT {
            get {
                return ResourceManager.GetString("storeCreate_INSERT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE venue_store
        ///SET store_name = @storename, store_section_location = @storesectionlocation, store_type = @storetype
        ///WHERE store_id = @storeid;.
        /// </summary>
        internal static string storeCreate_UPDATE {
            get {
                return ResourceManager.GetString("storeCreate_UPDATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO venue_ticket (tkt_event_id, tkt_section, tkt_row, tkt_seat_num, tkt_price, tkt_status)
        ///SELECT 
        ///    @eventid,
        ///    @ticketsection,
        ///    rows.row_number,
        ///    seats.seat_number, 
        ///    @ticketprice,
        ///    @ticketstatus
        ///FROM 
        ///    generate_series(1, 5) AS rows(row_number),
        ///    generate_series(1, 5) AS seats(seat_number);.
        /// </summary>
        internal static string ticketCreate_BULKINSERT {
            get {
                return ResourceManager.GetString("ticketCreate_BULKINSERT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM venue_ticket
        ///WHERE tkt_id = @tktid;.
        /// </summary>
        internal static string ticketCreate_DELETE {
            get {
                return ResourceManager.GetString("ticketCreate_DELETE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE venue_ticket
        ///SET tkt_status = &apos;SCN&apos;
        ///WHERE tkt_id = @tktid
        ///AND (tkt_status = &apos;SLD&apos; OR tkt_status = &apos;RSD&apos;);.
        /// </summary>
        internal static string ticketCreate_SCAN {
            get {
                return ResourceManager.GetString("ticketCreate_SCAN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO ticket_purchase(tktpur_tkt_id, tktpur_date, tktpur_wallet_id)
        ///VALUES(@ticket_id, @ticket_pur_date, @ticket_wallet_id);
        ///
        ///UPDATE venue_ticket
        ///SET tkt_status = @ticket_status
        ///WHERE tkt_id = @ticket_id;.
        /// </summary>
        internal static string ticketPurchase_INSERT {
            get {
                return ResourceManager.GetString("ticketPurchase_INSERT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * 
        ///FROM ticket_purchase 
        ///JOIN venue_ticket ON tktpur_tkt_id = tkt_id
        ///WHERE tktpur_wallet_id = @wallet_id AND (tkt_status != &apos;SCN&apos; AND tkt_status != &apos;RSL&apos;);.
        /// </summary>
        internal static string ticketPurchase_SELECT {
            get {
                return ResourceManager.GetString("ticketPurchase_SELECT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM ticket_purchase JOIN venue_ticket ON tktpur_tkt_id = tkt_id
        ///WHERE tktpur_wallet_id = @wallet_id AND tkt_status = &apos;SCN&apos;;.
        /// </summary>
        internal static string ticketPurchase_SELECTSCANNED {
            get {
                return ResourceManager.GetString("ticketPurchase_SELECTSCANNED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM venue_ticket WHERE tkt_event_id = @event_id AND tkt_status = @status1 OR tkt_status = @status2;.
        /// </summary>
        internal static string ticketsForEvent_SELECT {
            get {
                return ResourceManager.GetString("ticketsForEvent_SELECT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO venue_transaction(trans_pymt_info_id, trans_event_id, trans_timestamp, trans_quantity, trans_item_id)
        ///VALUES(@transpymtinfoid, @transeventid, @transtimestamp, @transquantity, @transitemid);.
        /// </summary>
        internal static string transactionCreate_INSERT {
            get {
                return ResourceManager.GetString("transactionCreate_INSERT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WITH inserted_user AS (
        ///    INSERT INTO app_user(user_fname, user_lname, user_birthday, user_balance, user_type)
        ///    VALUES (@firstname, @lastname, @birthday, @balance, @type)
        ///    RETURNING user_id
        ///),
        ///--[INSERT LOGINCREDS]
        ///--[INSERT WALLET].
        /// </summary>
        internal static string userCreate_INSERT {
            get {
                return ResourceManager.GetString("userCreate_INSERT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM login_credentials JOIN user_wallet
        ///ON user_wallet.wallet_user_id = login_credentials.lgn_user_id JOIN app_user ON app_user.user_id = user_wallet.wallet_user_id
        ///WHERE lgn_username = @username AND lgn_password = @password;.
        /// </summary>
        internal static string userLogin_SELECT {
            get {
                return ResourceManager.GetString("userLogin_SELECT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to inserted_credentials AS (
        ///    INSERT INTO login_credentials(lgn_user_id, lgn_username, lgn_password, lgn_email)
        ///    VALUES ((SELECT user_id FROM inserted_user), @username, @password, @email)
        ///).
        /// </summary>
        internal static string userLoginCreds_INSERT {
            get {
                return ResourceManager.GetString("userLoginCreds_INSERT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO user_wallet(wallet_user_id)
        ///SELECT user_id FROM inserted_user;.
        /// </summary>
        internal static string userWallet_INSERT {
            get {
                return ResourceManager.GetString("userWallet_INSERT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM venue_event;.
        /// </summary>
        internal static string venue_events_SELECT {
            get {
                return ResourceManager.GetString("venue_events_SELECT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM venue_store;.
        /// </summary>
        internal static string venue_stores_SELECT {
            get {
                return ResourceManager.GetString("venue_stores_SELECT", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM venue_store;.
        /// </summary>
        internal static string ticketSellerInfo_SELECT
        {
            get
            {
                return ResourceManager.GetString("ticketSellerInfo_SELECT", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM venue_store;.
        /// </summary>
        internal static string ticketSellerBalance_UPDATE
        {
            get
            {
                return ResourceManager.GetString("ticketSellerBalance_UPDATE", resourceCulture);
            }
        }
        
    }
}
