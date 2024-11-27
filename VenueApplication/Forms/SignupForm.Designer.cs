namespace VenueApplication.Forms
{
    partial class SignupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNameTextBoxEdit = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            firstnameLabel = new Label();
            lastNameLabel = new Label();
            lastNameTextBoxEdit = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            emailLabel = new Label();
            emailTextBoxEdit = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            birthdayLabel = new Label();
            singUpFormDateTimeEdit = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            signUpUserNameLabel = new Label();
            signUpUserNameTextEdit = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            signUpPasswordLabel = new Label();
            signUpPasswordTextEdit = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            reTypePasswordLabel = new Label();
            reTypePasswordTextEdit = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            signUpCancelButton = new Syncfusion.WinForms.Controls.SfButton();
            signUpButton = new Syncfusion.WinForms.Controls.SfButton();
            signUpFormErrorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)firstNameTextBoxEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lastNameTextBoxEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emailTextBoxEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)signUpUserNameTextEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)signUpPasswordTextEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reTypePasswordTextEdit).BeginInit();
            SuspendLayout();
            // 
            // firstNameTextBoxEdit
            // 
            firstNameTextBoxEdit.BeforeTouchSize = new Size(129, 23);
            firstNameTextBoxEdit.Location = new Point(146, 52);
            firstNameTextBoxEdit.Name = "firstNameTextBoxEdit";
            firstNameTextBoxEdit.Size = new Size(129, 23);
            firstNameTextBoxEdit.TabIndex = 0;
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstnameLabel.Location = new Point(46, 52);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new Size(96, 21);
            firstnameLabel.TabIndex = 1;
            firstnameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameLabel.Location = new Point(46, 112);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(94, 21);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBoxEdit
            // 
            lastNameTextBoxEdit.BeforeTouchSize = new Size(129, 23);
            lastNameTextBoxEdit.Location = new Point(146, 112);
            lastNameTextBoxEdit.Name = "lastNameTextBoxEdit";
            lastNameTextBoxEdit.Size = new Size(129, 23);
            lastNameTextBoxEdit.TabIndex = 3;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(46, 175);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(57, 21);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // emailTextBoxEdit
            // 
            emailTextBoxEdit.BeforeTouchSize = new Size(129, 23);
            emailTextBoxEdit.Location = new Point(146, 175);
            emailTextBoxEdit.Name = "emailTextBoxEdit";
            emailTextBoxEdit.Size = new Size(199, 23);
            emailTextBoxEdit.TabIndex = 5;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            birthdayLabel.Location = new Point(46, 233);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(79, 21);
            birthdayLabel.TabIndex = 6;
            birthdayLabel.Text = "Birthday:";
            // 
            // singUpFormDateTimeEdit
            // 
            singUpFormDateTimeEdit.DateTimeIcon = null;
            singUpFormDateTimeEdit.Location = new Point(146, 231);
            singUpFormDateTimeEdit.Name = "singUpFormDateTimeEdit";
            singUpFormDateTimeEdit.Size = new Size(199, 23);
            singUpFormDateTimeEdit.TabIndex = 7;
            singUpFormDateTimeEdit.ToolTipText = "";
            // 
            // signUpUserNameLabel
            // 
            signUpUserNameLabel.AutoSize = true;
            signUpUserNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signUpUserNameLabel.Location = new Point(46, 295);
            signUpUserNameLabel.Name = "signUpUserNameLabel";
            signUpUserNameLabel.Size = new Size(91, 21);
            signUpUserNameLabel.TabIndex = 8;
            signUpUserNameLabel.Text = "Username:";
            // 
            // signUpUserNameTextEdit
            // 
            signUpUserNameTextEdit.BeforeTouchSize = new Size(129, 23);
            signUpUserNameTextEdit.Location = new Point(146, 293);
            signUpUserNameTextEdit.Name = "signUpUserNameTextEdit";
            signUpUserNameTextEdit.Size = new Size(129, 23);
            signUpUserNameTextEdit.TabIndex = 9;
            // 
            // signUpPasswordLabel
            // 
            signUpPasswordLabel.AutoSize = true;
            signUpPasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signUpPasswordLabel.Location = new Point(46, 349);
            signUpPasswordLabel.Name = "signUpPasswordLabel";
            signUpPasswordLabel.Size = new Size(86, 21);
            signUpPasswordLabel.TabIndex = 10;
            signUpPasswordLabel.Text = "Password:";
            // 
            // signUpPasswordTextEdit
            // 
            signUpPasswordTextEdit.BeforeTouchSize = new Size(129, 23);
            signUpPasswordTextEdit.Location = new Point(146, 349);
            signUpPasswordTextEdit.Name = "signUpPasswordTextEdit";
            signUpPasswordTextEdit.Size = new Size(129, 23);
            signUpPasswordTextEdit.TabIndex = 11;
            // 
            // reTypePasswordLabel
            // 
            reTypePasswordLabel.AutoSize = true;
            reTypePasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reTypePasswordLabel.Location = new Point(46, 397);
            reTypePasswordLabel.Name = "reTypePasswordLabel";
            reTypePasswordLabel.Size = new Size(151, 21);
            reTypePasswordLabel.TabIndex = 12;
            reTypePasswordLabel.Text = "Re-Type Password:";
            // 
            // reTypePasswordTextEdit
            // 
            reTypePasswordTextEdit.BeforeTouchSize = new Size(129, 23);
            reTypePasswordTextEdit.Location = new Point(203, 397);
            reTypePasswordTextEdit.Name = "reTypePasswordTextEdit";
            reTypePasswordTextEdit.Size = new Size(129, 23);
            reTypePasswordTextEdit.TabIndex = 13;
            // 
            // signUpCancelButton
            // 
            signUpCancelButton.Font = new Font("Segoe UI Semibold", 9F);
            signUpCancelButton.Location = new Point(131, 467);
            signUpCancelButton.Name = "signUpCancelButton";
            signUpCancelButton.Size = new Size(113, 39);
            signUpCancelButton.TabIndex = 14;
            signUpCancelButton.Text = "Cancel";
            signUpCancelButton.Click += signUpCancelButton_Click;
            // 
            // signUpButton
            // 
            signUpButton.Font = new Font("Segoe UI Semibold", 9F);
            signUpButton.Location = new Point(250, 467);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(113, 39);
            signUpButton.TabIndex = 15;
            signUpButton.Text = "Sign Up";
            signUpButton.Click += signUpButton_Click;
            // 
            // signUpFormErrorLabel
            // 
            signUpFormErrorLabel.AutoSize = true;
            signUpFormErrorLabel.ForeColor = Color.Red;
            signUpFormErrorLabel.Location = new Point(46, 9);
            signUpFormErrorLabel.Name = "signUpFormErrorLabel";
            signUpFormErrorLabel.Size = new Size(110, 15);
            signUpFormErrorLabel.TabIndex = 16;
            signUpFormErrorLabel.Text = "TempError Message";
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 533);
            Controls.Add(signUpFormErrorLabel);
            Controls.Add(signUpButton);
            Controls.Add(signUpCancelButton);
            Controls.Add(reTypePasswordTextEdit);
            Controls.Add(reTypePasswordLabel);
            Controls.Add(signUpPasswordTextEdit);
            Controls.Add(signUpPasswordLabel);
            Controls.Add(signUpUserNameTextEdit);
            Controls.Add(signUpUserNameLabel);
            Controls.Add(singUpFormDateTimeEdit);
            Controls.Add(birthdayLabel);
            Controls.Add(emailTextBoxEdit);
            Controls.Add(emailLabel);
            Controls.Add(lastNameTextBoxEdit);
            Controls.Add(lastNameLabel);
            Controls.Add(firstnameLabel);
            Controls.Add(firstNameTextBoxEdit);
            Name = "SignupForm";
            Text = "SignupForm";
            ((System.ComponentModel.ISupportInitialize)firstNameTextBoxEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)lastNameTextBoxEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)emailTextBoxEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)signUpUserNameTextEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)signUpPasswordTextEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)reTypePasswordTextEdit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt firstNameTextBoxEdit;
        private Label firstnameLabel;
        private Label lastNameLabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt lastNameTextBoxEdit;
        private Label emailLabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt emailTextBoxEdit;
        private Label birthdayLabel;
        private Syncfusion.WinForms.Input.SfDateTimeEdit singUpFormDateTimeEdit;
        private Label signUpUserNameLabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt signUpUserNameTextEdit;
        private Label signUpPasswordLabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt signUpPasswordTextEdit;
        private Label reTypePasswordLabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt reTypePasswordTextEdit;
        private Syncfusion.WinForms.Controls.SfButton signUpCancelButton;
        private Syncfusion.WinForms.Controls.SfButton signUpButton;
        private Label signUpFormErrorLabel;
    }
}