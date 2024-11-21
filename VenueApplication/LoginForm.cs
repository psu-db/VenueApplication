using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VenueApplication
{
    public partial class LoginForm : MetroForm
    {
        #region Constructor

        public LoginForm()
        {
            InitializeComponent();
            this.Text = "Login Page";
        }

        #endregion

        #region Events

        private void newUserSignUpLinkLabel_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Method will hide necessary UI components and reconfigure the UI to allow for new user signup
        /// </summary>
        private void switchToNewUserSignUpConfig()
        {

        }

        #endregion
    }
}
