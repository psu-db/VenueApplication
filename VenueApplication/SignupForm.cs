using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using VenueApplication.DataAccess;
using VenueApplication.Services;
using System.Security.Policy;

namespace VenueApplication
{
    public partial class SignupForm : Form
    {

        string dbHost = Environment.GetEnvironmentVariable("DB_HOST")!;
        string dbUsername = Environment.GetEnvironmentVariable("DB_USERNAME")!;
        string dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD")!;
        string dbName = Environment.GetEnvironmentVariable("DB_NAME")!;
        private DatabaseManager _databaseManager;

        public SignupForm()
        {
            InitializeComponent();
            this.Text = "Sign up Page";
            _databaseManager = new DatabaseManager(dbHost, dbUsername, dbPassword, dbName);
        }

        private void InitializeComponent()
        {
            signupFirstNameLabel = new Label();
            SignupInstructionsLabel = new Label();
            signupLastNameLabel = new Label();
            signupBirthdayLabel = new Label();
            signupUsernameLabel = new Label();
            signupPasswordLabel = new Label();
            signupEmailLabel = new Label();
            signupConfirmPasswordLabel = new Label();
            signupErrorLabel = new Label();
            signupCreateButton = new Syncfusion.WinForms.Controls.SfButton();
            signupFirstNameTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            signupLastNameTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            signupEmailTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            signupUsernameTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            signupPasswordTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            signupConfirmPasswordTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            signupBirthdayDateTimeEdit = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            signpGoBackButton = new Syncfusion.WinForms.Controls.SfButton();
            ((ISupportInitialize)signupFirstNameTextBox).BeginInit();
            ((ISupportInitialize)signupLastNameTextBox).BeginInit();
            ((ISupportInitialize)signupEmailTextBox).BeginInit();
            ((ISupportInitialize)signupUsernameTextBox).BeginInit();
            ((ISupportInitialize)signupPasswordTextBox).BeginInit();
            ((ISupportInitialize)signupConfirmPasswordTextBox).BeginInit();
            SuspendLayout();
            // 
            // signupFirstNameLabel
            // 
            signupFirstNameLabel.AutoSize = true;
            signupFirstNameLabel.Font = new Font("Segoe UI", 12F);
            signupFirstNameLabel.Location = new Point(124, 231);
            signupFirstNameLabel.Name = "signupFirstNameLabel";
            signupFirstNameLabel.Size = new Size(152, 38);
            signupFirstNameLabel.TabIndex = 0;
            signupFirstNameLabel.Text = "First name:";
            // 
            // SignupInstructionsLabel
            // 
            SignupInstructionsLabel.AutoSize = true;
            SignupInstructionsLabel.Font = new Font("Segoe UI", 18F);
            SignupInstructionsLabel.Location = new Point(162, 39);
            SignupInstructionsLabel.Name = "SignupInstructionsLabel";
            SignupInstructionsLabel.Size = new Size(937, 57);
            SignupInstructionsLabel.TabIndex = 1;
            SignupInstructionsLabel.Text = "Enter the information below to create an account";
            // 
            // signupLastNameLabel
            // 
            signupLastNameLabel.AutoSize = true;
            signupLastNameLabel.Font = new Font("Segoe UI", 12F);
            signupLastNameLabel.Location = new Point(124, 335);
            signupLastNameLabel.Name = "signupLastNameLabel";
            signupLastNameLabel.Size = new Size(148, 38);
            signupLastNameLabel.TabIndex = 2;
            signupLastNameLabel.Text = "Last name:";
            // 
            // signupBirthdayLabel
            // 
            signupBirthdayLabel.AutoSize = true;
            signupBirthdayLabel.Font = new Font("Segoe UI", 12F);
            signupBirthdayLabel.Location = new Point(124, 541);
            signupBirthdayLabel.Name = "signupBirthdayLabel";
            signupBirthdayLabel.Size = new Size(125, 38);
            signupBirthdayLabel.TabIndex = 3;
            signupBirthdayLabel.Text = "Birthday:";
            // 
            // signupUsernameLabel
            // 
            signupUsernameLabel.AutoSize = true;
            signupUsernameLabel.Font = new Font("Segoe UI", 12F);
            signupUsernameLabel.Location = new Point(698, 231);
            signupUsernameLabel.Name = "signupUsernameLabel";
            signupUsernameLabel.Size = new Size(148, 38);
            signupUsernameLabel.TabIndex = 4;
            signupUsernameLabel.Text = "Username:";
            // 
            // signupPasswordLabel
            // 
            signupPasswordLabel.AutoSize = true;
            signupPasswordLabel.Font = new Font("Segoe UI", 12F);
            signupPasswordLabel.Location = new Point(698, 335);
            signupPasswordLabel.Name = "signupPasswordLabel";
            signupPasswordLabel.Size = new Size(138, 38);
            signupPasswordLabel.TabIndex = 5;
            signupPasswordLabel.Text = "Password:";
            // 
            // signupEmailLabel
            // 
            signupEmailLabel.AutoSize = true;
            signupEmailLabel.Font = new Font("Segoe UI", 12F);
            signupEmailLabel.Location = new Point(124, 431);
            signupEmailLabel.Name = "signupEmailLabel";
            signupEmailLabel.Size = new Size(89, 38);
            signupEmailLabel.TabIndex = 6;
            signupEmailLabel.Text = "Email:";
            // 
            // signupConfirmPasswordLabel
            // 
            signupConfirmPasswordLabel.AutoSize = true;
            signupConfirmPasswordLabel.Font = new Font("Segoe UI", 12F);
            signupConfirmPasswordLabel.Location = new Point(698, 431);
            signupConfirmPasswordLabel.Name = "signupConfirmPasswordLabel";
            signupConfirmPasswordLabel.Size = new Size(246, 38);
            signupConfirmPasswordLabel.TabIndex = 7;
            signupConfirmPasswordLabel.Text = "Confirm password:";
            // 
            // signupErrorLabel
            // 
            signupErrorLabel.AutoSize = true;
            signupErrorLabel.Font = new Font("Segoe UI", 12F);
            signupErrorLabel.ForeColor = Color.Crimson;
            signupErrorLabel.Location = new Point(698, 541);
            signupErrorLabel.Name = "signupErrorLabel";
            signupErrorLabel.Size = new Size(0, 38);
            signupErrorLabel.TabIndex = 8;
            // 
            // signupCreateButton
            // 
            signupCreateButton.Font = new Font("Segoe UI Semibold", 9F);
            signupCreateButton.Location = new Point(723, 768);
            signupCreateButton.Name = "signupCreateButton";
            signupCreateButton.Size = new Size(237, 54);
            signupCreateButton.TabIndex = 9;
            signupCreateButton.Text = "Create account";
            signupCreateButton.Click += signupCreateButton_Click;
            // 
            // signupFirstNameTextBox
            // 
            signupFirstNameTextBox.BackColor = SystemColors.Window;
            signupFirstNameTextBox.BeforeTouchSize = new Size(263, 35);
            signupFirstNameTextBox.Location = new Point(284, 234);
            signupFirstNameTextBox.Margin = new Padding(5, 6, 5, 6);
            signupFirstNameTextBox.Name = "signupFirstNameTextBox";
            signupFirstNameTextBox.Size = new Size(263, 35);
            signupFirstNameTextBox.TabIndex = 10;
            // 
            // signupLastNameTextBox
            // 
            signupLastNameTextBox.BackColor = SystemColors.Window;
            signupLastNameTextBox.BeforeTouchSize = new Size(263, 35);
            signupLastNameTextBox.Location = new Point(280, 338);
            signupLastNameTextBox.Margin = new Padding(5, 6, 5, 6);
            signupLastNameTextBox.Name = "signupLastNameTextBox";
            signupLastNameTextBox.Size = new Size(263, 35);
            signupLastNameTextBox.TabIndex = 11;
            // 
            // signupEmailTextBox
            // 
            signupEmailTextBox.BackColor = SystemColors.Window;
            signupEmailTextBox.BeforeTouchSize = new Size(263, 35);
            signupEmailTextBox.Location = new Point(280, 434);
            signupEmailTextBox.Margin = new Padding(5, 6, 5, 6);
            signupEmailTextBox.Name = "signupEmailTextBox";
            signupEmailTextBox.Size = new Size(263, 35);
            signupEmailTextBox.TabIndex = 12;
            // 
            // signupUsernameTextBox
            // 
            signupUsernameTextBox.BackColor = SystemColors.Window;
            signupUsernameTextBox.BeforeTouchSize = new Size(263, 35);
            signupUsernameTextBox.Location = new Point(854, 234);
            signupUsernameTextBox.Margin = new Padding(5, 6, 5, 6);
            signupUsernameTextBox.Name = "signupUsernameTextBox";
            signupUsernameTextBox.Size = new Size(263, 35);
            signupUsernameTextBox.TabIndex = 13;
            // 
            // signupPasswordTextBox
            // 
            signupPasswordTextBox.BackColor = SystemColors.Window;
            signupPasswordTextBox.BeforeTouchSize = new Size(263, 35);
            signupPasswordTextBox.Location = new Point(854, 335);
            signupPasswordTextBox.Margin = new Padding(5, 6, 5, 6);
            signupPasswordTextBox.Name = "signupPasswordTextBox";
            signupPasswordTextBox.Size = new Size(263, 35);
            signupPasswordTextBox.TabIndex = 14;
            // 
            // signupConfirmPasswordTextBox
            // 
            signupConfirmPasswordTextBox.BackColor = SystemColors.Window;
            signupConfirmPasswordTextBox.BeforeTouchSize = new Size(263, 35);
            signupConfirmPasswordTextBox.Location = new Point(948, 434);
            signupConfirmPasswordTextBox.Margin = new Padding(5, 6, 5, 6);
            signupConfirmPasswordTextBox.Name = "signupConfirmPasswordTextBox";
            signupConfirmPasswordTextBox.Size = new Size(263, 35);
            signupConfirmPasswordTextBox.TabIndex = 15;
            // 
            // signupBirthdayDateTimeEdit
            // 
            signupBirthdayDateTimeEdit.DateTimeIcon = null;
            signupBirthdayDateTimeEdit.Format = "yyyy-MM-dd";
            signupBirthdayDateTimeEdit.Location = new Point(280, 529);
            signupBirthdayDateTimeEdit.Name = "signupBirthdayDateTimeEdit";
            signupBirthdayDateTimeEdit.Size = new Size(341, 66);
            signupBirthdayDateTimeEdit.TabIndex = 17;
            signupBirthdayDateTimeEdit.ToolTipText = "";
            // 
            // signpGoBackButton
            // 
            signpGoBackButton.Font = new Font("Segoe UI Semibold", 9F);
            signpGoBackButton.Location = new Point(480, 768);
            signpGoBackButton.Name = "signpGoBackButton";
            signpGoBackButton.Size = new Size(237, 54);
            signpGoBackButton.TabIndex = 18;
            signpGoBackButton.Text = "Go back";
            signpGoBackButton.Click += signpGoBackButton_Click;
            // 
            // SignupForm
            // 
            ClientSize = new Size(1531, 856);
            Controls.Add(signpGoBackButton);
            Controls.Add(signupBirthdayDateTimeEdit);
            Controls.Add(signupConfirmPasswordTextBox);
            Controls.Add(signupPasswordTextBox);
            Controls.Add(signupUsernameTextBox);
            Controls.Add(signupEmailTextBox);
            Controls.Add(signupLastNameTextBox);
            Controls.Add(signupFirstNameTextBox);
            Controls.Add(signupCreateButton);
            Controls.Add(signupErrorLabel);
            Controls.Add(signupConfirmPasswordLabel);
            Controls.Add(signupEmailLabel);
            Controls.Add(signupPasswordLabel);
            Controls.Add(signupUsernameLabel);
            Controls.Add(signupBirthdayLabel);
            Controls.Add(signupLastNameLabel);
            Controls.Add(SignupInstructionsLabel);
            Controls.Add(signupFirstNameLabel);
            Name = "SignupForm";
            Load += SignupForm_Load;
            ((ISupportInitialize)signupFirstNameTextBox).EndInit();
            ((ISupportInitialize)signupLastNameTextBox).EndInit();
            ((ISupportInitialize)signupEmailTextBox).EndInit();
            ((ISupportInitialize)signupUsernameTextBox).EndInit();
            ((ISupportInitialize)signupPasswordTextBox).EndInit();
            ((ISupportInitialize)signupConfirmPasswordTextBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void signpGoBackButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("trying to go back to login page now");
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();

        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private string Format_Date()
        {
            DateTime? nullableBirthday = signupBirthdayDateTimeEdit.Value;
            string birthday = nullableBirthday.ToString();
            string date = birthday.Split(' ')[0];
            string[] components = date.Split('/');
            string formattedDate = components[2] + "-" + components[0]  + "-" + components[1];
            return formattedDate;
        }

        private void signupCreateButton_Click(object sender, EventArgs e)
        {



            //do error checking before this
            //check for
            //matching password
            //birhday is > 18
            // username, email, unique
            string firstName = signupFirstNameTextBox.Text;
            string lastName = signupLastNameTextBox.Text;
            string email = signupEmailTextBox.Text;
            string birthday = Format_Date();
            string username = signupUsernameTextBox.Text;
            string password = signupPasswordTextBox.Text;
            string confirmedPassword = signupConfirmPasswordTextBox.Text;

            Debug.WriteLine(firstName);
            Debug.WriteLine(lastName);
            Debug.WriteLine(email);
            Debug.WriteLine(birthday);
            Debug.WriteLine(username);
            Debug.WriteLine(password);
            Debug.WriteLine(confirmedPassword);

            if (firstName != "" && lastName != "" && email != "" && birthday != "" && username != "" && password != "" && confirmedPassword != "")
            {
                //check if the email, username are unique, otherwise prompt user to change them

                if (password != confirmedPassword)
                {
                    signupErrorLabel.Text = "Passwords entered do not match. Try again";
                    return;
                }

                // verify the birthday is valid
                // person is at least 18 years old
                DateTime today = DateTime.Today;
                DateTime eighteenYearsAgo = today.AddYears(-18);
                DateTime parsedDate = DateTime.Parse(birthday);
                if (parsedDate > eighteenYearsAgo)
                {
                    signupErrorLabel.Text = "Users must be at least 18 years old";
                    return;
                }
                bool signupAttemptResult = NewUserService.attemptSignup(firstName, lastName, email, birthday,
                                                                        username, password, confirmedPassword,
                                                                        _databaseManager);

                if (signupAttemptResult)
                {
                    this.Hide();
                    MainForm newMainForm = new MainForm();
                    newMainForm.Show();
                }
                else
                {
                    // update error message
                    signupErrorLabel.Text = "Sign up has failed. Try again";
                    signupErrorLabel.Refresh();
                }
            }
            else
            {
                // update error message - one or more fields are empty
                signupErrorLabel.Text = "One or more fields are empty. Try again";
                signupErrorLabel.Refresh();
            }


            //this.Hide();
            //MainForm mainForm = new MainForm();
            //mainForm.Show();
        }
    }
}
