using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using VenueApplication.DataAccess;
using VenueApplication.Services;

namespace VenueApplication.Forms
{
    public partial class SignupForm : MetroForm
    {

        private LoginForm loginForm;
        public DatabaseManager databaseManager;

        #region Constructor

        public SignupForm(LoginForm loginForm, DatabaseManager databaseManager)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.databaseManager = databaseManager;
        }

        #endregion

        #region Events

        private void signUpCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }

        #endregion

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string firstname = firstNameTextBoxEdit.Text;
            string lastname = lastNameTextBoxEdit.Text;
            string email = emailTextBoxEdit.Text;
            DateTime? birthday = singUpFormDateTimeEdit.Value;
            DateOnly? birthdayDate = null;

            if (birthday.HasValue)
            {
                // Convert DateTime to DateOnly
                birthdayDate = DateOnly.FromDateTime(birthday.Value);

                // Convert DateOnly to string in the correct format (YYYY-MM-DD)
            }

            string username = signUpUserNameTextEdit.Text;
            string password = signUpPasswordTextEdit.Text;
            string retyped_password = reTypePasswordTextEdit.Text;

            if (firstname != "" && lastname != "" && email != "" && birthdayDate != null && username != "" && password != "" && retyped_password != "")
            {

                if (password == retyped_password)
                {
                    bool signupAttemptResult = NewUserService.attemptSignup(firstname, lastname, email, birthdayDate, username, password, databaseManager);

                    if (signupAttemptResult)
                    {
                        this.Close();
                        loginForm.Show();
                    }
                    else
                    {
                        signUpFormErrorLabel.Text = "An error occured during the sign up process. Please wait and try again.";
                        signUpFormErrorLabel.Visible = true;
                        signUpFormErrorLabel.Refresh();
                    }
                }
                else
                {
                    signUpFormErrorLabel.Text = "Password and re-typed password do not match.";
                    signUpFormErrorLabel.Visible = true;
                    signUpFormErrorLabel.Refresh();
                }
                
            }
            else
            {
                signUpFormErrorLabel.Text = "All fields must be filled in order to sign up.";
                signUpFormErrorLabel.Visible = true;
                signUpFormErrorLabel.Refresh();
            }
            
        }
    }
}
