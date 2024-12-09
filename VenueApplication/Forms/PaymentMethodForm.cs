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

namespace VenueApplication.Forms
{
    public partial class PaymentMethodForm : MetroForm
    {
        MainForm mainForm;
        DatabaseManager databaseManager;
        public PaymentMethodForm(MainForm mainForm, DatabaseManager databaseManager)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.databaseManager = databaseManager;
        }

        #region Events

        private void paymentMethodFormCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.EnableAddNewPaymentButton();
        }

        private void savePaymentMethodButton_Click(object sender, EventArgs e)
        {
            string cardType = cardTypeComboBox.Text;
            string cardNumber = cardNumberTextEdit.Text;
            string cardCVV = cardCVVTextEdit.Text;
            string cardExpDate = cardExpDateTextEdit.Text; // needs to be in MM/YY format (add checks for this later)
            string address = addressTextEdit.Text;
            string state = selectStateComboBox.Text;
            string zipcode = zipcodeTextEdit.Text;

            bool AttemptAddNewPaymentMethodResult = NewPaymentMethodService.AttemptAddNewPaymentMethod(cardType, cardNumber, cardCVV, cardExpDate, address, state, zipcode, databaseManager);

            if (AttemptAddNewPaymentMethodResult)
            {
                mainForm.EnableAddNewPaymentButton();
                mainForm.InitializeProfilePage(); // Refresh and show newly added payment method in combobox
                this.Close();
            }
            else
            {
                paymentFormErrorLabel.Text = "An error occured. Please wait and try again.";
                paymentFormErrorLabel.Visible = true;
                paymentFormErrorLabel.Refresh();
            }
        }

        #endregion
    }
}
