namespace VenueApplication
{
    partial class LoginForm
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
            usernameTextBoxEdit = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            passwordTextBoxEdit = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            usernameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Syncfusion.WinForms.Controls.SfButton();
            label1 = new Label();
            newUserSignUpLinkLabel = new LinkLabel();
            loginErrorLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            loginControlsPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)usernameTextBoxEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordTextBoxEdit).BeginInit();
            loginControlsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // usernameTextBoxEdit
            // 
            usernameTextBoxEdit.BackColor = SystemColors.Window;
            usernameTextBoxEdit.BeforeTouchSize = new Size(155, 23);
            usernameTextBoxEdit.Location = new Point(148, 61);
            usernameTextBoxEdit.Name = "usernameTextBoxEdit";
            usernameTextBoxEdit.Size = new Size(155, 23);
            usernameTextBoxEdit.TabIndex = 0;
            // 
            // passwordTextBoxEdit
            // 
            passwordTextBoxEdit.BeforeTouchSize = new Size(155, 23);
            passwordTextBoxEdit.Location = new Point(148, 101);
            passwordTextBoxEdit.Name = "passwordTextBoxEdit";
            passwordTextBoxEdit.Size = new Size(155, 23);
            passwordTextBoxEdit.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(51, 63);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(91, 21);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(51, 103);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(86, 21);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password:";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.LightGray;
            loginButton.Font = new Font("Segoe UI Semibold", 9F);
            loginButton.Location = new Point(51, 141);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(252, 28);
            loginButton.Style.BackColor = Color.LightGray;
            loginButton.TabIndex = 4;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 193);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 5;
            label1.Text = "Don't have an account?";
            // 
            // newUserSignUpLinkLabel
            // 
            newUserSignUpLinkLabel.AutoSize = true;
            newUserSignUpLinkLabel.Location = new Point(215, 193);
            newUserSignUpLinkLabel.Name = "newUserSignUpLinkLabel";
            newUserSignUpLinkLabel.Size = new Size(48, 15);
            newUserSignUpLinkLabel.TabIndex = 6;
            newUserSignUpLinkLabel.TabStop = true;
            newUserSignUpLinkLabel.Text = "Sign Up";
            newUserSignUpLinkLabel.Click += newUserSignUpLinkLabel_Click;
            // 
            // loginErrorLabel
            // 
            loginErrorLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginErrorLabel.ForeColor = Color.Red;
            loginErrorLabel.Location = new Point(106, 30);
            loginErrorLabel.Name = "loginErrorLabel";
            loginErrorLabel.Size = new Size(146, 15);
            loginErrorLabel.TabIndex = 7;
            loginErrorLabel.Text = "Template Log In Error Text";
            // 
            // loginControlsPanel
            // 
            loginControlsPanel.BackColor = Color.White;
            loginControlsPanel.BorderStyle = BorderStyle.FixedSingle;
            loginControlsPanel.Controls.Add(usernameTextBoxEdit);
            loginControlsPanel.Controls.Add(loginErrorLabel);
            loginControlsPanel.Controls.Add(passwordTextBoxEdit);
            loginControlsPanel.Controls.Add(newUserSignUpLinkLabel);
            loginControlsPanel.Controls.Add(usernameLabel);
            loginControlsPanel.Controls.Add(label1);
            loginControlsPanel.Controls.Add(passwordLabel);
            loginControlsPanel.Controls.Add(loginButton);
            loginControlsPanel.Location = new Point(210, 90);
            loginControlsPanel.Name = "loginControlsPanel";
            loginControlsPanel.Size = new Size(355, 247);
            loginControlsPanel.TabIndex = 8;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resource.beaverStaidumLoginBackgroundImage_webp;
            ClientSize = new Size(792, 450);
            Controls.Add(loginControlsPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LoginForm";
            ShowIcon = false;
            ShowMaximizeBox = false;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)usernameTextBoxEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordTextBoxEdit).EndInit();
            loginControlsPanel.ResumeLayout(false);
            loginControlsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt usernameTextBoxEdit;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt passwordTextBoxEdit;
        private Label usernameLabel;
        private Label passwordLabel;
        private Syncfusion.WinForms.Controls.SfButton loginButton;
        private Label label1;
        private LinkLabel newUserSignUpLinkLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel loginErrorLabel;
        private Panel loginControlsPanel;
    }
}