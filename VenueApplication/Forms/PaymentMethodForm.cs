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

namespace VenueApplication.Forms
{
    public partial class PaymentMethodForm : MetroForm
    {
        MainForm mainForm;
        public PaymentMethodForm(MainForm mainForm)
        {
            InitializeComponent();
            this.Text = "New Payment Method Form";
            this.mainForm = mainForm;
        }

        private void paymentMethodFormCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
