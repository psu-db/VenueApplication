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
using VenueApplication.DataAccess;
using VenueApplication.Services;

namespace VenueApplication
{
    public partial class LoginForm : MetroForm
    {

        string dbHost = Environment.GetEnvironmentVariable("DB_HOST")!;
        string dbUsername = Environment.GetEnvironmentVariable("DB_USERNAME")!;
        string dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD")!;
        string dbName = Environment.GetEnvironmentVariable("DB_NAME")!;
        private DatabaseManager _databaseManager;

        #region Constructor

        public LoginForm()
        {
            InitializeComponent();
            this.Text = "Login Page";
            _databaseManager = new DatabaseManager(dbHost, dbUsername, dbPassword, dbName);
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBoxEdit.Text;
            string password = passwordTextBoxEdit.Text;

            if (username != "" && password != "")
            {
                bool loginAttemptResult = LoginService.attemptLogin(username, password, _databaseManager);

                if (loginAttemptResult)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    // update error message
                    loginErrorLabel.Text = "Username or password is incorrect";
                    loginErrorLabel.Refresh();
                }
            }
            else
            {
                // update error message - one or more fields are empty
                loginErrorLabel.Text = "Username or password is empty";
                loginErrorLabel.Refresh();
            }
        }

        private void newUserSignUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
