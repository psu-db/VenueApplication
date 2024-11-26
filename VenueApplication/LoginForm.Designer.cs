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
            usernameTextBoxEdit.BeforeTouchSize = new Size(263, 35);
            usernameTextBoxEdit.Location = new Point(254, 122);
            usernameTextBoxEdit.Margin = new Padding(5, 6, 5, 6);
            usernameTextBoxEdit.Name = "usernameTextBoxEdit";
            usernameTextBoxEdit.Size = new Size(263, 35);
            usernameTextBoxEdit.TabIndex = 0;
            // 
            // passwordTextBoxEdit
            // 
            passwordTextBoxEdit.BeforeTouchSize = new Size(263, 35);
            passwordTextBoxEdit.Location = new Point(254, 202);
            passwordTextBoxEdit.Margin = new Padding(5, 6, 5, 6);
            passwordTextBoxEdit.Name = "passwordTextBoxEdit";
            passwordTextBoxEdit.Size = new Size(263, 35);
            passwordTextBoxEdit.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(87, 126);
            usernameLabel.Margin = new Padding(5, 0, 5, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(156, 38);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(87, 206);
            passwordLabel.Margin = new Padding(5, 0, 5, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(147, 38);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password:";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.LightGray;
            loginButton.Font = new Font("Segoe UI Semibold", 9F);
            loginButton.Location = new Point(87, 282);
            loginButton.Margin = new Padding(5, 6, 5, 6);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(432, 56);
            loginButton.Style.BackColor = Color.LightGray;
            loginButton.TabIndex = 4;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 386);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 30);
            label1.TabIndex = 5;
            label1.Text = "Don't have an account?";
            // 
            // newUserSignUpLinkLabel
            // 
            newUserSignUpLinkLabel.AutoSize = true;
            newUserSignUpLinkLabel.Location = new Point(369, 386);
            newUserSignUpLinkLabel.Margin = new Padding(5, 0, 5, 0);
            newUserSignUpLinkLabel.Name = "newUserSignUpLinkLabel";
            newUserSignUpLinkLabel.Size = new Size(85, 30);
            newUserSignUpLinkLabel.TabIndex = 6;
            newUserSignUpLinkLabel.TabStop = true;
            newUserSignUpLinkLabel.Text = "Sign Up";
            newUserSignUpLinkLabel.LinkClicked += newUserSignUpLinkLabel_LinkClicked;
            newUserSignUpLinkLabel.Click += newUserSignUpLinkLabel_Click;
            // 
            // loginErrorLabel
            // 
            loginErrorLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginErrorLabel.ForeColor = Color.Red;
            loginErrorLabel.Location = new Point(182, 60);
            loginErrorLabel.Margin = new Padding(5, 0, 5, 0);
            loginErrorLabel.Name = "loginErrorLabel";
            loginErrorLabel.Size = new Size(0, 30);
            loginErrorLabel.TabIndex = 7;
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
            loginControlsPanel.Location = new Point(360, 180);
            loginControlsPanel.Margin = new Padding(5, 6, 5, 6);
            loginControlsPanel.Name = "loginControlsPanel";
            loginControlsPanel.Size = new Size(607, 492);
            loginControlsPanel.TabIndex = 8;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resource.beaverStaidumLoginBackgroundImage_webp;
            ClientSize = new Size(1349, 888);
            Controls.Add(loginControlsPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 6, 5, 6);
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