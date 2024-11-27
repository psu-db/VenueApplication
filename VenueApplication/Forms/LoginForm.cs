using Syncfusion.Windows.Forms;
using VenueApplication.DataAccess;
using VenueApplication.Services;

namespace VenueApplication.Forms
{
    public partial class LoginForm : MetroForm
    {

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

        private void newUserSignUpLinkLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBoxEdit.Text;
            string password = passwordTextBoxEdit.Text;

            if (username != "" && password != "")
            {
                bool loginAttemptResult = LoginService.attemptLogin(username, password, databaseManager);

                if (loginAttemptResult)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
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
