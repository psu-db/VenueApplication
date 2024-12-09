namespace VenueApplication.Forms
{
    partial class PaymentMethodForm
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
            paymentMethodFormCancelButton = new Syncfusion.WinForms.Controls.SfButton();
            savePaymentMethodButton = new Syncfusion.WinForms.Controls.SfButton();
            cardTypeLabel = new Label();
            cardNumberLabel = new Label();
            cardCVVLabel = new Label();
            cardExpirationDateLabel = new Label();
            cardAddressLabel = new Label();
            statePaymentMethodFormLabel = new Label();
            cardNumberTextEdit = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            cardCVVTextEdit = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            addressTextEdit = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            cardTypeComboBox = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            selectStateComboBox = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            paymentFormErrorLabel = new Label();
            zipcodeLabel = new Label();
            zipcodeTextEdit = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            cardExpDateTextEdit = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)cardNumberTextEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardCVVTextEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addressTextEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardTypeComboBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectStateComboBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zipcodeTextEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardExpDateTextEdit).BeginInit();
            SuspendLayout();
            // 
            // paymentMethodFormCancelButton
            // 
            paymentMethodFormCancelButton.Font = new Font("Segoe UI Semibold", 9F);
            paymentMethodFormCancelButton.Location = new Point(365, 820);
            paymentMethodFormCancelButton.Margin = new Padding(5, 6, 5, 6);
            paymentMethodFormCancelButton.Name = "paymentMethodFormCancelButton";
            paymentMethodFormCancelButton.Size = new Size(165, 56);
            paymentMethodFormCancelButton.TabIndex = 0;
            paymentMethodFormCancelButton.TabStop = false;
            paymentMethodFormCancelButton.Text = "Cancel";
            paymentMethodFormCancelButton.Click += paymentMethodFormCancelButton_Click;
            // 
            // savePaymentMethodButton
            // 
            savePaymentMethodButton.Font = new Font("Segoe UI Semibold", 9F);
            savePaymentMethodButton.Location = new Point(554, 820);
            savePaymentMethodButton.Margin = new Padding(5, 6, 5, 6);
            savePaymentMethodButton.Name = "savePaymentMethodButton";
            savePaymentMethodButton.Size = new Size(165, 56);
            savePaymentMethodButton.TabIndex = 1;
            savePaymentMethodButton.TabStop = false;
            savePaymentMethodButton.Text = "Save";
            savePaymentMethodButton.Click += savePaymentMethodButton_Click;
            // 
            // cardTypeLabel
            // 
            cardTypeLabel.AutoSize = true;
            cardTypeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cardTypeLabel.Location = new Point(91, 102);
            cardTypeLabel.Margin = new Padding(5, 0, 5, 0);
            cardTypeLabel.Name = "cardTypeLabel";
            cardTypeLabel.Size = new Size(155, 38);
            cardTypeLabel.TabIndex = 2;
            cardTypeLabel.Text = "Card Type:";
            // 
            // cardNumberLabel
            // 
            cardNumberLabel.AutoSize = true;
            cardNumberLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cardNumberLabel.Location = new Point(91, 206);
            cardNumberLabel.Margin = new Padding(5, 0, 5, 0);
            cardNumberLabel.Name = "cardNumberLabel";
            cardNumberLabel.Size = new Size(202, 38);
            cardNumberLabel.TabIndex = 3;
            cardNumberLabel.Text = "Card Number:";
            // 
            // cardCVVLabel
            // 
            cardCVVLabel.AutoSize = true;
            cardCVVLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cardCVVLabel.Location = new Point(91, 302);
            cardCVVLabel.Margin = new Padding(5, 0, 5, 0);
            cardCVVLabel.Name = "cardCVVLabel";
            cardCVVLabel.Size = new Size(147, 38);
            cardCVVLabel.TabIndex = 4;
            cardCVVLabel.Text = "Card CVV:";
            // 
            // cardExpirationDateLabel
            // 
            cardExpirationDateLabel.AutoSize = true;
            cardExpirationDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cardExpirationDateLabel.Location = new Point(91, 408);
            cardExpirationDateLabel.Margin = new Padding(5, 0, 5, 0);
            cardExpirationDateLabel.Name = "cardExpirationDateLabel";
            cardExpirationDateLabel.Size = new Size(297, 38);
            cardExpirationDateLabel.TabIndex = 5;
            cardExpirationDateLabel.Text = "Card Expiration Date:";
            // 
            // cardAddressLabel
            // 
            cardAddressLabel.AutoSize = true;
            cardAddressLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cardAddressLabel.Location = new Point(91, 512);
            cardAddressLabel.Margin = new Padding(5, 0, 5, 0);
            cardAddressLabel.Name = "cardAddressLabel";
            cardAddressLabel.Size = new Size(129, 38);
            cardAddressLabel.TabIndex = 6;
            cardAddressLabel.Text = "Address:";
            // 
            // statePaymentMethodFormLabel
            // 
            statePaymentMethodFormLabel.AutoSize = true;
            statePaymentMethodFormLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            statePaymentMethodFormLabel.Location = new Point(91, 610);
            statePaymentMethodFormLabel.Margin = new Padding(5, 0, 5, 0);
            statePaymentMethodFormLabel.Name = "statePaymentMethodFormLabel";
            statePaymentMethodFormLabel.Size = new Size(92, 38);
            statePaymentMethodFormLabel.TabIndex = 7;
            statePaymentMethodFormLabel.Text = "State:";
            // 
            // cardNumberTextEdit
            // 
            cardNumberTextEdit.BeforeTouchSize = new Size(169, 35);
            cardNumberTextEdit.Location = new Point(302, 206);
            cardNumberTextEdit.Margin = new Padding(5, 6, 5, 6);
            cardNumberTextEdit.Name = "cardNumberTextEdit";
            cardNumberTextEdit.Size = new Size(270, 35);
            cardNumberTextEdit.TabIndex = 9;
            cardNumberTextEdit.KeyPress += cardNumberTextEdit_KeyPress;
            // 
            // cardCVVTextEdit
            // 
            cardCVVTextEdit.BeforeTouchSize = new Size(169, 35);
            cardCVVTextEdit.Location = new Point(247, 302);
            cardCVVTextEdit.Margin = new Padding(5, 6, 5, 6);
            cardCVVTextEdit.Name = "cardCVVTextEdit";
            cardCVVTextEdit.Size = new Size(136, 35);
            cardCVVTextEdit.TabIndex = 10;
            cardCVVTextEdit.KeyPress += cardCVVTextEdit_KeyPress;
            // 
            // addressTextEdit
            // 
            addressTextEdit.BeforeTouchSize = new Size(169, 35);
            addressTextEdit.Location = new Point(228, 512);
            addressTextEdit.Margin = new Padding(5, 6, 5, 6);
            addressTextEdit.Name = "addressTextEdit";
            addressTextEdit.Size = new Size(169, 35);
            addressTextEdit.TabIndex = 12;
            // 
            // cardTypeComboBox
            // 
            cardTypeComboBox.BeforeTouchSize = new Size(205, 38);
            cardTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cardTypeComboBox.Items.AddRange(new object[] { "Debit", "Credit" });
            cardTypeComboBox.Location = new Point(247, 102);
            cardTypeComboBox.Margin = new Padding(5, 6, 5, 6);
            cardTypeComboBox.Name = "cardTypeComboBox";
            cardTypeComboBox.Size = new Size(205, 38);
            cardTypeComboBox.TabIndex = 14;
            cardTypeComboBox.Text = "Debit";
            // 
            // selectStateComboBox
            // 
            selectStateComboBox.BeforeTouchSize = new Size(205, 38);
            selectStateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectStateComboBox.Items.AddRange(new object[] { "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" });
            selectStateComboBox.Location = new Point(192, 610);
            selectStateComboBox.Margin = new Padding(5, 6, 5, 6);
            selectStateComboBox.Name = "selectStateComboBox";
            selectStateComboBox.Size = new Size(205, 38);
            selectStateComboBox.TabIndex = 16;
            selectStateComboBox.Text = "Alabama";
            // 
            // paymentFormErrorLabel
            // 
            paymentFormErrorLabel.AutoSize = true;
            paymentFormErrorLabel.ForeColor = Color.Red;
            paymentFormErrorLabel.Location = new Point(91, 40);
            paymentFormErrorLabel.Margin = new Padding(5, 0, 5, 0);
            paymentFormErrorLabel.Name = "paymentFormErrorLabel";
            paymentFormErrorLabel.Size = new Size(168, 30);
            paymentFormErrorLabel.TabIndex = 17;
            paymentFormErrorLabel.Text = "Temp Error Label";
            paymentFormErrorLabel.Visible = false;
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            zipcodeLabel.Location = new Point(91, 714);
            zipcodeLabel.Margin = new Padding(5, 0, 5, 0);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new Size(129, 38);
            zipcodeLabel.TabIndex = 18;
            zipcodeLabel.Text = "Zipcode:";
            // 
            // zipcodeTextEdit
            // 
            zipcodeTextEdit.BeforeTouchSize = new Size(169, 35);
            zipcodeTextEdit.Location = new Point(231, 714);
            zipcodeTextEdit.Margin = new Padding(5, 6, 5, 6);
            zipcodeTextEdit.Name = "zipcodeTextEdit";
            zipcodeTextEdit.Size = new Size(169, 35);
            zipcodeTextEdit.TabIndex = 19;
            zipcodeTextEdit.KeyPress += zipcodeTextEdit_KeyPress_1;
            // 
            // cardExpDateTextEdit
            // 
            cardExpDateTextEdit.BeforeTouchSize = new Size(169, 35);
            cardExpDateTextEdit.Location = new Point(396, 408);
            cardExpDateTextEdit.Margin = new Padding(5, 6, 5, 6);
            cardExpDateTextEdit.Name = "cardExpDateTextEdit";
            cardExpDateTextEdit.Size = new Size(169, 35);
            cardExpDateTextEdit.TabIndex = 20;
            // 
            // PaymentMethodForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 888);
            Controls.Add(cardExpDateTextEdit);
            Controls.Add(zipcodeTextEdit);
            Controls.Add(zipcodeLabel);
            Controls.Add(paymentFormErrorLabel);
            Controls.Add(selectStateComboBox);
            Controls.Add(cardTypeComboBox);
            Controls.Add(addressTextEdit);
            Controls.Add(cardCVVTextEdit);
            Controls.Add(cardNumberTextEdit);
            Controls.Add(statePaymentMethodFormLabel);
            Controls.Add(cardAddressLabel);
            Controls.Add(cardExpirationDateLabel);
            Controls.Add(cardCVVLabel);
            Controls.Add(cardNumberLabel);
            Controls.Add(cardTypeLabel);
            Controls.Add(savePaymentMethodButton);
            Controls.Add(paymentMethodFormCancelButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "PaymentMethodForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Payment Method Form";
            ((System.ComponentModel.ISupportInitialize)cardNumberTextEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardCVVTextEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)addressTextEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardTypeComboBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectStateComboBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)zipcodeTextEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardExpDateTextEdit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton paymentMethodFormCancelButton;
        private Syncfusion.WinForms.Controls.SfButton savePaymentMethodButton;
        private Label cardTypeLabel;
        private Label cardNumberLabel;
        private Label cardCVVLabel;
        private Label cardExpirationDateLabel;
        private Label cardAddressLabel;
        private Label statePaymentMethodFormLabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt cardNumberTextEdit;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt cardCVVTextEdit;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt addressTextEdit;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cardTypeComboBox;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv selectStateComboBox;
        private Label paymentFormErrorLabel;
        private Label zipcodeLabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt zipcodeTextEdit;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt cardExpDateTextEdit;
    }
}