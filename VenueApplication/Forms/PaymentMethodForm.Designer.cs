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
            paymentMethodFormCancelButton.Location = new Point(213, 410);
            paymentMethodFormCancelButton.Name = "paymentMethodFormCancelButton";
            paymentMethodFormCancelButton.Size = new Size(96, 28);
            paymentMethodFormCancelButton.TabIndex = 0;
            paymentMethodFormCancelButton.TabStop = false;
            paymentMethodFormCancelButton.Text = "Cancel";
            paymentMethodFormCancelButton.Click += paymentMethodFormCancelButton_Click;
            // 
            // savePaymentMethodButton
            // 
            savePaymentMethodButton.Font = new Font("Segoe UI Semibold", 9F);
            savePaymentMethodButton.Location = new Point(323, 410);
            savePaymentMethodButton.Name = "savePaymentMethodButton";
            savePaymentMethodButton.Size = new Size(96, 28);
            savePaymentMethodButton.TabIndex = 1;
            savePaymentMethodButton.TabStop = false;
            savePaymentMethodButton.Text = "Save";
            savePaymentMethodButton.Click += savePaymentMethodButton_Click;
            // 
            // cardTypeLabel
            // 
            cardTypeLabel.AutoSize = true;
            cardTypeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cardTypeLabel.Location = new Point(53, 51);
            cardTypeLabel.Name = "cardTypeLabel";
            cardTypeLabel.Size = new Size(89, 21);
            cardTypeLabel.TabIndex = 2;
            cardTypeLabel.Text = "Card Type:";
            // 
            // cardNumberLabel
            // 
            cardNumberLabel.AutoSize = true;
            cardNumberLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cardNumberLabel.Location = new Point(53, 103);
            cardNumberLabel.Name = "cardNumberLabel";
            cardNumberLabel.Size = new Size(117, 21);
            cardNumberLabel.TabIndex = 3;
            cardNumberLabel.Text = "Card Number:";
            // 
            // cardCVVLabel
            // 
            cardCVVLabel.AutoSize = true;
            cardCVVLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cardCVVLabel.Location = new Point(53, 151);
            cardCVVLabel.Name = "cardCVVLabel";
            cardCVVLabel.Size = new Size(85, 21);
            cardCVVLabel.TabIndex = 4;
            cardCVVLabel.Text = "Card CVV:";
            // 
            // cardExpirationDateLabel
            // 
            cardExpirationDateLabel.AutoSize = true;
            cardExpirationDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cardExpirationDateLabel.Location = new Point(53, 204);
            cardExpirationDateLabel.Name = "cardExpirationDateLabel";
            cardExpirationDateLabel.Size = new Size(172, 21);
            cardExpirationDateLabel.TabIndex = 5;
            cardExpirationDateLabel.Text = "Card Expiration Date:";
            // 
            // cardAddressLabel
            // 
            cardAddressLabel.AutoSize = true;
            cardAddressLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cardAddressLabel.Location = new Point(53, 256);
            cardAddressLabel.Name = "cardAddressLabel";
            cardAddressLabel.Size = new Size(74, 21);
            cardAddressLabel.TabIndex = 6;
            cardAddressLabel.Text = "Address:";
            // 
            // statePaymentMethodFormLabel
            // 
            statePaymentMethodFormLabel.AutoSize = true;
            statePaymentMethodFormLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            statePaymentMethodFormLabel.Location = new Point(53, 305);
            statePaymentMethodFormLabel.Name = "statePaymentMethodFormLabel";
            statePaymentMethodFormLabel.Size = new Size(53, 21);
            statePaymentMethodFormLabel.TabIndex = 7;
            statePaymentMethodFormLabel.Text = "State:";
            // 
            // cardNumberTextEdit
            // 
            cardNumberTextEdit.BeforeTouchSize = new Size(100, 23);
            cardNumberTextEdit.Location = new Point(176, 103);
            cardNumberTextEdit.Name = "cardNumberTextEdit";
            cardNumberTextEdit.Size = new Size(159, 23);
            cardNumberTextEdit.TabIndex = 9;
            // 
            // cardCVVTextEdit
            // 
            cardCVVTextEdit.BeforeTouchSize = new Size(100, 23);
            cardCVVTextEdit.Location = new Point(144, 151);
            cardCVVTextEdit.Name = "cardCVVTextEdit";
            cardCVVTextEdit.Size = new Size(81, 23);
            cardCVVTextEdit.TabIndex = 10;
            // 
            // addressTextEdit
            // 
            addressTextEdit.BeforeTouchSize = new Size(100, 23);
            addressTextEdit.Location = new Point(133, 256);
            addressTextEdit.Name = "addressTextEdit";
            addressTextEdit.Size = new Size(100, 23);
            addressTextEdit.TabIndex = 12;
            // 
            // cardTypeComboBox
            // 
            cardTypeComboBox.BeforeTouchSize = new Size(121, 23);
            cardTypeComboBox.Items.AddRange(new object[] { "Debit", "Credit" });
            cardTypeComboBox.Location = new Point(144, 51);
            cardTypeComboBox.Name = "cardTypeComboBox";
            cardTypeComboBox.Size = new Size(121, 23);
            cardTypeComboBox.TabIndex = 14;
            // 
            // selectStateComboBox
            // 
            selectStateComboBox.BeforeTouchSize = new Size(121, 23);
            selectStateComboBox.Items.AddRange(new object[] { "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" });
            selectStateComboBox.Location = new Point(112, 305);
            selectStateComboBox.Name = "selectStateComboBox";
            selectStateComboBox.Size = new Size(121, 23);
            selectStateComboBox.TabIndex = 13;
            // 
            // paymentFormErrorLabel
            // 
            paymentFormErrorLabel.AutoSize = true;
            paymentFormErrorLabel.ForeColor = Color.Red;
            paymentFormErrorLabel.Location = new Point(53, 20);
            paymentFormErrorLabel.Name = "paymentFormErrorLabel";
            paymentFormErrorLabel.Size = new Size(95, 15);
            paymentFormErrorLabel.TabIndex = 17;
            paymentFormErrorLabel.Text = "Temp Error Label";
            paymentFormErrorLabel.Visible = false;
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            zipcodeLabel.Location = new Point(53, 357);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new Size(76, 21);
            zipcodeLabel.TabIndex = 18;
            zipcodeLabel.Text = "Zipcode:";
            // 
            // zipcodeTextEdit
            // 
            zipcodeTextEdit.BeforeTouchSize = new Size(100, 23);
            zipcodeTextEdit.Location = new Point(135, 357);
            zipcodeTextEdit.Name = "zipcodeTextEdit";
            zipcodeTextEdit.Size = new Size(100, 23);
            zipcodeTextEdit.TabIndex = 14;
            // 
            // cardExpDateTextEdit
            // 
            cardExpDateTextEdit.BeforeTouchSize = new Size(100, 23);
            cardExpDateTextEdit.Location = new Point(231, 204);
            cardExpDateTextEdit.Name = "cardExpDateTextEdit";
            cardExpDateTextEdit.Size = new Size(100, 23);
            cardExpDateTextEdit.TabIndex = 11;
            // 
            // PaymentMethodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 450);
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