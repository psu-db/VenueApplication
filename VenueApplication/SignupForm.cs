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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            signupUsernameLabel = new Label();
            SuspendLayout();
            // 
            // signupUsernameLabel
            // 
            signupUsernameLabel.AutoSize = true;
            signupUsernameLabel.Location = new Point(137, 50);
            signupUsernameLabel.Name = "signupUsernameLabel";
            signupUsernameLabel.Size = new Size(114, 30);
            signupUsernameLabel.TabIndex = 0;
            signupUsernameLabel.Text = "First name:";
            // 
            // SignupForm
            // 
            ClientSize = new Size(276, 236);
            Controls.Add(signupUsernameLabel);
            Name = "SignupForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
