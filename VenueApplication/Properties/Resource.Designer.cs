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
        internal static System.Drawing.Bitmap _22_Profile {
            get {
                object obj = ResourceManager.GetObject("22_Profile", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
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
        ///   Looks up a localized string similar to WITH inserted_user AS (
        ///    INSERT INTO app_user(user_fname, user_lname, user_birthday, user_balance, user_type)
        ///    VALUES (@firstname, @lastname, @birthday, @balance, @type)
        ///    RETURNING user_id
        ///),
        ///--[INSERT LOGINCREDS]
        ///INSERT INTO user_wallet(wallet_user_id)
        ///SELECT user_id FROM inserted_user;.
        /// </summary>
        internal static string userCreate_INSERT {
            get {
                return ResourceManager.GetString("userCreate_INSERT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM login_credentials
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
        ///   Looks up a localized string similar to inserted_credentials AS (
        ///    INSERT INTO login_credentials(lgn_user_id, lgn_username, lgn_password, lgn_email)
        ///    VALUES ((SELECT user_id FROM inserted_user), @username, @password, @email)
        ///).
        /// </summary>
        internal static string userWallet_INSERT
        {
            get
            {
                return ResourceManager.GetString("userWallet_INSERT", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap vecteezy_home_or_house_symbol_icon_vector_illustration_8070536 {
            get {
                object obj = ResourceManager.GetObject("vecteezy_home-or-house-symbol-icon-vector-illustration_8070536", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
