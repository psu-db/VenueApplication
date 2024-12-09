namespace VenueApplication.Forms
{
    partial class EditEventForm
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
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            EditEventCancelButton = new Syncfusion.WinForms.Controls.SfButton();
            editEventUpdateButton = new Syncfusion.WinForms.Controls.SfButton();
            editEventDateLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            editEventTypeLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            editEventTimeLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            editEventDescriptionLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            editEventCalender = new Syncfusion.WinForms.Input.SfCalendar();
            editEventHourComboBoxAdv = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            editEventMinuteComboBoxAdv = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            editEventAMPMComboBoxAdv = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            editEventColonLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            editEventTypeComboBoxAdv = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            editEventDescriptionTextBoxExt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            editEventErrorLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)editEventHourComboBoxAdv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editEventMinuteComboBoxAdv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editEventAMPMComboBoxAdv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editEventTypeComboBoxAdv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editEventDescriptionTextBoxExt).BeginInit();
            SuspendLayout();
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Segoe UI", 18F);
            autoLabel1.Location = new Point(32, 26);
            autoLabel1.Margin = new Padding(2, 0, 2, 0);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(120, 32);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Edit Event";
            // 
            // EditEventCancelButton
            // 
            EditEventCancelButton.Font = new Font("Segoe UI Semibold", 9F);
            EditEventCancelButton.Location = new Point(29, 521);
            EditEventCancelButton.Margin = new Padding(2, 2, 2, 2);
            EditEventCancelButton.Name = "EditEventCancelButton";
            EditEventCancelButton.Size = new Size(157, 44);
            EditEventCancelButton.TabIndex = 3;
            EditEventCancelButton.Text = "Cancel";
            EditEventCancelButton.Click += sfButton3_Click;
            // 
            // editEventUpdateButton
            // 
            editEventUpdateButton.Font = new Font("Segoe UI Semibold", 9F);
            editEventUpdateButton.Location = new Point(197, 521);
            editEventUpdateButton.Margin = new Padding(2, 2, 2, 2);
            editEventUpdateButton.Name = "editEventUpdateButton";
            editEventUpdateButton.Size = new Size(157, 44);
            editEventUpdateButton.TabIndex = 4;
            editEventUpdateButton.Text = "Update";
            editEventUpdateButton.Click += editEventUpdateButton_Click;
            // 
            // editEventDateLabel
            // 
            editEventDateLabel.Font = new Font("Segoe UI", 14F);
            editEventDateLabel.Location = new Point(207, 75);
            editEventDateLabel.Margin = new Padding(2, 0, 2, 0);
            editEventDateLabel.Name = "editEventDateLabel";
            editEventDateLabel.Size = new Size(106, 25);
            editEventDateLabel.TabIndex = 6;
            editEventDateLabel.Text = "Event Date:";
            // 
            // editEventTypeLabel
            // 
            editEventTypeLabel.Font = new Font("Segoe UI", 14F);
            editEventTypeLabel.Location = new Point(32, 410);
            editEventTypeLabel.Margin = new Padding(2, 0, 2, 0);
            editEventTypeLabel.Name = "editEventTypeLabel";
            editEventTypeLabel.Size = new Size(106, 25);
            editEventTypeLabel.TabIndex = 7;
            editEventTypeLabel.Text = "Event Type:";
            // 
            // editEventTimeLabel
            // 
            editEventTimeLabel.Font = new Font("Segoe UI", 14F);
            editEventTimeLabel.Location = new Point(32, 360);
            editEventTimeLabel.Margin = new Padding(2, 0, 2, 0);
            editEventTimeLabel.Name = "editEventTimeLabel";
            editEventTimeLabel.Size = new Size(108, 25);
            editEventTimeLabel.TabIndex = 8;
            editEventTimeLabel.Text = "Event Time:";
            // 
            // editEventDescriptionLabel
            // 
            editEventDescriptionLabel.Font = new Font("Segoe UI", 14F);
            editEventDescriptionLabel.Location = new Point(30, 463);
            editEventDescriptionLabel.Margin = new Padding(2, 0, 2, 0);
            editEventDescriptionLabel.Name = "editEventDescriptionLabel";
            editEventDescriptionLabel.Size = new Size(163, 25);
            editEventDescriptionLabel.TabIndex = 9;
            editEventDescriptionLabel.Text = "Event Description:";
            // 
            // editEventCalender
            // 
            editEventCalender.Location = new Point(142, 114);
            editEventCalender.Margin = new Padding(2, 2, 2, 2);
            editEventCalender.Name = "editEventCalender";
            editEventCalender.Size = new Size(231, 201);
            editEventCalender.TabIndex = 10;
            editEventCalender.Text = "sfCalendar1";
            // 
            // editEventHourComboBoxAdv
            // 
            editEventHourComboBoxAdv.BeforeTouchSize = new Size(73, 29);
            editEventHourComboBoxAdv.Font = new Font("Segoe UI", 12F);
            editEventHourComboBoxAdv.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            editEventHourComboBoxAdv.Location = new Point(141, 359);
            editEventHourComboBoxAdv.Margin = new Padding(2, 2, 2, 2);
            editEventHourComboBoxAdv.Name = "editEventHourComboBoxAdv";
            editEventHourComboBoxAdv.Size = new Size(73, 29);
            editEventHourComboBoxAdv.TabIndex = 11;
            // 
            // editEventMinuteComboBoxAdv
            // 
            editEventMinuteComboBoxAdv.BeforeTouchSize = new Size(79, 29);
            editEventMinuteComboBoxAdv.Font = new Font("Segoe UI", 12F);
            editEventMinuteComboBoxAdv.Items.AddRange(new object[] { "00", "15", "30", "45" });
            editEventMinuteComboBoxAdv.Location = new Point(255, 360);
            editEventMinuteComboBoxAdv.Margin = new Padding(2, 2, 2, 2);
            editEventMinuteComboBoxAdv.Name = "editEventMinuteComboBoxAdv";
            editEventMinuteComboBoxAdv.Size = new Size(79, 29);
            editEventMinuteComboBoxAdv.TabIndex = 12;
            // 
            // editEventAMPMComboBoxAdv
            // 
            editEventAMPMComboBoxAdv.BeforeTouchSize = new Size(70, 29);
            editEventAMPMComboBoxAdv.Font = new Font("Segoe UI", 12F);
            editEventAMPMComboBoxAdv.Items.AddRange(new object[] { "AM", "PM" });
            editEventAMPMComboBoxAdv.Location = new Point(357, 360);
            editEventAMPMComboBoxAdv.Margin = new Padding(2, 2, 2, 2);
            editEventAMPMComboBoxAdv.Name = "editEventAMPMComboBoxAdv";
            editEventAMPMComboBoxAdv.Size = new Size(70, 29);
            editEventAMPMComboBoxAdv.TabIndex = 13;
            // 
            // editEventColonLabel
            // 
            editEventColonLabel.Font = new Font("Segoe UI", 12F);
            editEventColonLabel.Location = new Point(228, 360);
            editEventColonLabel.Margin = new Padding(2, 0, 2, 0);
            editEventColonLabel.Name = "editEventColonLabel";
            editEventColonLabel.Size = new Size(13, 21);
            editEventColonLabel.TabIndex = 14;
            editEventColonLabel.Text = ":";
            // 
            // editEventTypeComboBoxAdv
            // 
            editEventTypeComboBoxAdv.BeforeTouchSize = new Size(152, 29);
            editEventTypeComboBoxAdv.Font = new Font("Segoe UI", 12F);
            editEventTypeComboBoxAdv.Items.AddRange(new object[] { "Football", "Concert", "Other" });
            editEventTypeComboBoxAdv.Location = new Point(142, 410);
            editEventTypeComboBoxAdv.Margin = new Padding(2, 2, 2, 2);
            editEventTypeComboBoxAdv.Name = "editEventTypeComboBoxAdv";
            editEventTypeComboBoxAdv.Size = new Size(152, 29);
            editEventTypeComboBoxAdv.TabIndex = 15;
            // 
            // editEventDescriptionTextBoxExt
            // 
            editEventDescriptionTextBoxExt.BeforeTouchSize = new Size(335, 29);
            editEventDescriptionTextBoxExt.Font = new Font("Segoe UI", 12F);
            editEventDescriptionTextBoxExt.Location = new Point(197, 463);
            editEventDescriptionTextBoxExt.Margin = new Padding(2, 2, 2, 2);
            editEventDescriptionTextBoxExt.Name = "editEventDescriptionTextBoxExt";
            editEventDescriptionTextBoxExt.Size = new Size(335, 29);
            editEventDescriptionTextBoxExt.TabIndex = 16;
            editEventDescriptionTextBoxExt.Text = "textBoxExt1";
            // 
            // editEventErrorLabel
            // 
            editEventErrorLabel.Font = new Font("Segoe UI", 12F);
            editEventErrorLabel.ForeColor = Color.Red;
            editEventErrorLabel.Location = new Point(30, 584);
            editEventErrorLabel.Margin = new Padding(2, 0, 2, 0);
            editEventErrorLabel.Name = "editEventErrorLabel";
            editEventErrorLabel.Size = new Size(82, 21);
            editEventErrorLabel.TabIndex = 17;
            editEventErrorLabel.Text = "error label";
            editEventErrorLabel.Visible = false;
            // 
            // EditEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 627);
            Controls.Add(editEventErrorLabel);
            Controls.Add(editEventDescriptionTextBoxExt);
            Controls.Add(editEventTypeComboBoxAdv);
            Controls.Add(editEventColonLabel);
            Controls.Add(editEventAMPMComboBoxAdv);
            Controls.Add(editEventMinuteComboBoxAdv);
            Controls.Add(editEventHourComboBoxAdv);
            Controls.Add(editEventCalender);
            Controls.Add(editEventDescriptionLabel);
            Controls.Add(editEventTimeLabel);
            Controls.Add(editEventTypeLabel);
            Controls.Add(editEventDateLabel);
            Controls.Add(editEventUpdateButton);
            Controls.Add(EditEventCancelButton);
            Controls.Add(autoLabel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "EditEventForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditEventForm";
            ((System.ComponentModel.ISupportInitialize)editEventHourComboBoxAdv).EndInit();
            ((System.ComponentModel.ISupportInitialize)editEventMinuteComboBoxAdv).EndInit();
            ((System.ComponentModel.ISupportInitialize)editEventAMPMComboBoxAdv).EndInit();
            ((System.ComponentModel.ISupportInitialize)editEventTypeComboBoxAdv).EndInit();
            ((System.ComponentModel.ISupportInitialize)editEventDescriptionTextBoxExt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.Controls.SfButton EditEventCancelButton;
        private Syncfusion.WinForms.Controls.SfButton editEventUpdateButton;
        private Syncfusion.Windows.Forms.Tools.AutoLabel editEventDateLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel editEventTypeLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel editEventTimeLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel editEventDescriptionLabel;
        private Syncfusion.WinForms.Input.SfCalendar editEventCalender;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv editEventHourComboBoxAdv;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv editEventMinuteComboBoxAdv;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv editEventAMPMComboBoxAdv;
        private Syncfusion.Windows.Forms.Tools.AutoLabel editEventColonLabel;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv editEventTypeComboBoxAdv;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt editEventDescriptionTextBoxExt;
        private Syncfusion.Windows.Forms.Tools.AutoLabel editEventErrorLabel;
    }
}