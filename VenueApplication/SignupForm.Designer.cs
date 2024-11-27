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

        private Label signupFirstNameLabel;
        private Label SignupInstructionsLabel;
        private Label signupLastNameLabel;
        private Label signupBirthdayLabel;
        private Label signupUsernameLabel;
        private Label signupPasswordLabel;
        private Label signupEmailLabel;
        private Label signupConfirmPasswordLabel;
        private Label signupErrorLabel;
        private Syncfusion.WinForms.Controls.SfButton signupCreateButton;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt signupFirstNameTextBox;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt signupLastNameTextBox;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt signupEmailTextBox;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt signupUsernameTextBox;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt signupPasswordTextBox;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt signupConfirmPasswordTextBox;
        private Syncfusion.WinForms.Input.SfDateTimeEdit signupBirthdayDateTimeEdit;
        private Syncfusion.WinForms.Controls.SfButton signpGoBackButton;
    }
}