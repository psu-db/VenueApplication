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
            linkLabel1 = new LinkLabel();
            loginErrorLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)usernameTextBoxEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordTextBoxEdit).BeginInit();
            panel1.SuspendLayout();
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
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(215, 193);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(48, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up";
            // 
            // loginErrorLabel
            // 
            loginErrorLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginErrorLabel.ForeColor = Color.Red;
            loginErrorLabel.Location = new Point(106, 30);
            loginErrorLabel.Name = "loginErrorLabel";
            loginErrorLabel.Size = new Size(149, 15);
            loginErrorLabel.TabIndex = 7;
            loginErrorLabel.Text = "Template Loging Error Text";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(usernameTextBoxEdit);
            panel1.Controls.Add(loginErrorLabel);
            panel1.Controls.Add(passwordTextBoxEdit);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(loginButton);
            panel1.Location = new Point(210, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 247);
            panel1.TabIndex = 8;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resource.beaverStaidumLoginBackgroundImage_webp;
            ClientSize = new Size(792, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LoginForm";
            ShowIcon = false;
            ShowMaximizeBox = false;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)usernameTextBoxEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordTextBoxEdit).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt usernameTextBoxEdit;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt passwordTextBoxEdit;
        private Label usernameLabel;
        private Label passwordLabel;
        private Syncfusion.WinForms.Controls.SfButton loginButton;
        private Label label1;
        private LinkLabel linkLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel loginErrorLabel;
        private Panel panel1;
    }
}