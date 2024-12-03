using Syncfusion.Windows.Forms;
using VenueApplication.DataAccess;
using VenueApplication.Services;
using VenueApplication.Models;
using System.Diagnostics;

namespace VenueApplication.Forms
{
    public partial class LoginForm : MetroForm
    {
        #region Global Variables

        public static int USER_ID;
        public static int USER_WALLET_ID;

        #endregion

        string dbHost = Environment.GetEnvironmentVariable("DB_HOST")!;
        string dbUsername = Environment.GetEnvironmentVariable("DB_USERNAME")!;
        string dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD")!;
        string dbName = Environment.GetEnvironmentVariable("DB_NAME")!;
        public DatabaseManager databaseManager;

        #region Constructor

        public LoginForm()
        {
            InitializeComponent();
            this.Text = "Login Page";
            databaseManager = new DatabaseManager(dbHost, dbUsername, dbPassword, dbName);
        }

        #endregion

        #region Events

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBoxEdit.Text;
            string password = passwordTextBoxEdit.Text;

            if (username != "" && password != "")
            {
                (bool loginAttemptResult, user_wallet? wallet, login_credentials? credentials, app_user? user) = LoginService.attemptLogin(username, password, databaseManager);

                if (loginAttemptResult)
                {

                    if (user != null && wallet != null)
                    {
                        USER_ID = user.user_id;
                        USER_WALLET_ID = wallet.wallet_id;

                        Debug.WriteLine($"SUCCESS: USER_ID: {USER_ID} USER_WALLET_ID: {USER_WALLET_ID}");

                        this.Hide();
                        MainForm mainForm = new MainForm(user, wallet, databaseManager);
                        mainForm.Show();
                    }
                    else
                    {
                        Debug.WriteLine("ERROR: user or wallet object was null while attempting to assign global variables");
                    }

                }
                else
                {
                    // update error message
                    loginErrorLabel.Text = "Incorrect username or password. Please try again.";
                    loginErrorLabel.Refresh();
                }
            }
            else
            {
                // update error message - one or more fields are empty
                loginErrorLabel.Text = "Both username and password are required. Please enter them to continue.";
                loginErrorLabel.Refresh();
            }
        }

        private void newUserSignUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignupForm signupForm = new SignupForm(this, databaseManager);
            signupForm.Show();
        }

        #endregion

        #region Methods


        #endregion


    }
}
