namespace pc_service_calc.NewObjectForms
{
    partial class NewEvent
    {
       
        private System.ComponentModel.IContainer components = null;

       
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
            this.zamowLabel = new System.Windows.Forms.Label();
            this.personLabel = new System.Windows.Forms.Label();
            this.eventTypeComboBox = new System.Windows.Forms.ComboBox();
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.paymentSumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.leaveGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.eventDateMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.newTermsGroupBox = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.termsEndMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label11 = new System.Windows.Forms.Label();
            this.newTermsPenaltyUpDown = new System.Windows.Forms.NumericUpDown();
            this.payDateUpDown = new System.Windows.Forms.NumericUpDown();
            this.newTermsPaymentUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.newPaymentSetGroupBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.newPaymentUpDown = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.customWriteOffGroupBox = new System.Windows.Forms.GroupBox();
            this.customWriteOffCommentTextBox = new System.Windows.Forms.RichTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.customWriteOffSumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.paymentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentSumUpDown)).BeginInit();
            this.newTermsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newTermsPenaltyUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payDateUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTermsPaymentUpDown)).BeginInit();
            this.newPaymentSetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPaymentUpDown)).BeginInit();
            this.customWriteOffGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customWriteOffSumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // zamowLabel
            // 
            this.zamowLabel.AutoSize = true;
            this.zamowLabel.Location = new System.Drawing.Point(17, 16);
            this.zamowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zamowLabel.Name = "zamowLabel";
            this.zamowLabel.Size = new System.Drawing.Size(44, 16);
            this.zamowLabel.TabIndex = 2;
            this.zamowLabel.Text = "label1";
            // 
            // personLabel
            // 
            this.personLabel.AutoSize = true;
            this.personLabel.Location = new System.Drawing.Point(17, 37);
            this.personLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.personLabel.Name = "personLabel";
            this.personLabel.Size = new System.Drawing.Size(44, 16);
            this.personLabel.TabIndex = 3;
            this.personLabel.Text = "label2";
            // 
            // eventTypeComboBox
            // 
            this.eventTypeComboBox.DisplayMember = "1";
            this.eventTypeComboBox.FormattingEnabled = true;
            this.eventTypeComboBox.Items.AddRange(new object[] {
            "Dokonywanie płatności",
            "Zawarcie nowej umowy",
            "Zakończenie płatności w częściach",
            "Zmiana płatności w częściach",
            "Naliczanie zmiennej części opłaty"});
            this.eventTypeComboBox.Location = new System.Drawing.Point(18, 57);
            this.eventTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.eventTypeComboBox.Name = "eventTypeComboBox";
            this.eventTypeComboBox.Size = new System.Drawing.Size(605, 24);
            this.eventTypeComboBox.TabIndex = 4;
            this.eventTypeComboBox.ValueMember = "0";
            this.eventTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.eventTypeComboBox1_SelectedIndexChanged);
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.Controls.Add(this.label7);
            this.paymentGroupBox.Controls.Add(this.label5);
            this.paymentGroupBox.Controls.Add(this.paymentSumUpDown);
            this.paymentGroupBox.Controls.Add(this.label4);
            this.paymentGroupBox.Enabled = false;
            this.paymentGroupBox.Location = new System.Drawing.Point(17, 100);
            this.paymentGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.paymentGroupBox.Size = new System.Drawing.Size(371, 215);
            this.paymentGroupBox.TabIndex = 5;
            this.paymentGroupBox.TabStop = false;
            this.paymentGroupBox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 316);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(120, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 2;
            // 
            // paymentSumUpDown
            // 
            this.paymentSumUpDown.Location = new System.Drawing.Point(13, 46);
            this.paymentSumUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.paymentSumUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.paymentSumUpDown.Name = "paymentSumUpDown";
            this.paymentSumUpDown.Size = new System.Drawing.Size(131, 22);
            this.paymentSumUpDown.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Zapłacone";
            // 
            // leaveGroupBox
            // 
            this.leaveGroupBox.Location = new System.Drawing.Point(1, 0);
            this.leaveGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.leaveGroupBox.Name = "leaveGroupBox";
            this.leaveGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.leaveGroupBox.Size = new System.Drawing.Size(372, 215);
            this.leaveGroupBox.TabIndex = 7;
            this.leaveGroupBox.TabStop = false;
            this.leaveGroupBox.Text = "Zamknięcie umowy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Data";
            // 
            // eventDateMonthCalendar
            // 
            this.eventDateMonthCalendar.Location = new System.Drawing.Point(405, 116);
            this.eventDateMonthCalendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.eventDateMonthCalendar.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.eventDateMonthCalendar.MaxSelectionCount = 1;
            this.eventDateMonthCalendar.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.eventDateMonthCalendar.Name = "eventDateMonthCalendar";
            this.eventDateMonthCalendar.ShowToday = false;
            this.eventDateMonthCalendar.ShowTodayCircle = false;
            this.eventDateMonthCalendar.TabIndex = 10;
            this.eventDateMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // newTermsGroupBox
            // 
            this.newTermsGroupBox.Controls.Add(this.leaveGroupBox);
            this.newTermsGroupBox.Controls.Add(this.label12);
            this.newTermsGroupBox.Controls.Add(this.termsEndMonthCalendar);
            this.newTermsGroupBox.Controls.Add(this.label11);
            this.newTermsGroupBox.Controls.Add(this.newTermsPenaltyUpDown);
            this.newTermsGroupBox.Controls.Add(this.payDateUpDown);
            this.newTermsGroupBox.Controls.Add(this.newTermsPaymentUpDown);
            this.newTermsGroupBox.Controls.Add(this.label8);
            this.newTermsGroupBox.Controls.Add(this.label9);
            this.newTermsGroupBox.Controls.Add(this.label10);
            this.newTermsGroupBox.Location = new System.Drawing.Point(17, 100);
            this.newTermsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.newTermsGroupBox.Name = "newTermsGroupBox";
            this.newTermsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.newTermsGroupBox.Size = new System.Drawing.Size(372, 417);
            this.newTermsGroupBox.TabIndex = 6;
            this.newTermsGroupBox.TabStop = false;
            this.newTermsGroupBox.Text = "Zawarcie umowy";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 172);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Data zakończenia umowy";
            // 
            // termsEndMonthCalendar
            // 
            this.termsEndMonthCalendar.Location = new System.Drawing.Point(16, 203);
            this.termsEndMonthCalendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.termsEndMonthCalendar.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.termsEndMonthCalendar.MaxSelectionCount = 1;
            this.termsEndMonthCalendar.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.termsEndMonthCalendar.Name = "termsEndMonthCalendar";
            this.termsEndMonthCalendar.ShowToday = false;
            this.termsEndMonthCalendar.ShowTodayCircle = false;
            this.termsEndMonthCalendar.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(320, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 202);
            this.label11.TabIndex = 24;
            this.label11.Text = "         ";
            // 
            // newTermsPenaltyUpDown
            // 
            this.newTermsPenaltyUpDown.DecimalPlaces = 5;
            this.newTermsPenaltyUpDown.Location = new System.Drawing.Point(12, 134);
            this.newTermsPenaltyUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.newTermsPenaltyUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.newTermsPenaltyUpDown.Name = "newTermsPenaltyUpDown";
            this.newTermsPenaltyUpDown.Size = new System.Drawing.Size(331, 22);
            this.newTermsPenaltyUpDown.TabIndex = 28;
            // 
            // payDateUpDown
            // 
            this.payDateUpDown.Location = new System.Drawing.Point(12, 86);
            this.payDateUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.payDateUpDown.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.payDateUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.payDateUpDown.Name = "payDateUpDown";
            this.payDateUpDown.Size = new System.Drawing.Size(331, 22);
            this.payDateUpDown.TabIndex = 27;
            this.payDateUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // newTermsPaymentUpDown
            // 
            this.newTermsPaymentUpDown.InterceptArrowKeys = false;
            this.newTermsPaymentUpDown.Location = new System.Drawing.Point(12, 41);
            this.newTermsPaymentUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.newTermsPaymentUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.newTermsPaymentUpDown.Name = "newTermsPaymentUpDown";
            this.newTermsPaymentUpDown.Size = new System.Drawing.Size(331, 22);
            this.newTermsPaymentUpDown.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Grzywna (w ułamkach dziesiętnych)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 69);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Data płatności (numer dnia w miesiącu)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Kwota płatności";
            // 
            // newPaymentSetGroupBox
            // 
            this.newPaymentSetGroupBox.Controls.Add(this.label13);
            this.newPaymentSetGroupBox.Controls.Add(this.label14);
            this.newPaymentSetGroupBox.Controls.Add(this.newPaymentUpDown);
            this.newPaymentSetGroupBox.Controls.Add(this.label15);
            this.newPaymentSetGroupBox.Enabled = false;
            this.newPaymentSetGroupBox.Location = new System.Drawing.Point(17, 100);
            this.newPaymentSetGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.newPaymentSetGroupBox.Name = "newPaymentSetGroupBox";
            this.newPaymentSetGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.newPaymentSetGroupBox.Size = new System.Drawing.Size(371, 215);
            this.newPaymentSetGroupBox.TabIndex = 11;
            this.newPaymentSetGroupBox.TabStop = false;
            this.newPaymentSetGroupBox.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 316);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(120, 46);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 28);
            this.label14.TabIndex = 2;
            // 
            // newPaymentUpDown
            // 
            this.newPaymentUpDown.Location = new System.Drawing.Point(13, 46);
            this.newPaymentUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.newPaymentUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.newPaymentUpDown.Name = "newPaymentUpDown";
            this.newPaymentUpDown.Size = new System.Drawing.Size(131, 22);
            this.newPaymentUpDown.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 25);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Nowa płatność";
            // 
            // customWriteOffGroupBox
            // 
            this.customWriteOffGroupBox.Controls.Add(this.customWriteOffCommentTextBox);
            this.customWriteOffGroupBox.Controls.Add(this.label19);
            this.customWriteOffGroupBox.Controls.Add(this.label16);
            this.customWriteOffGroupBox.Controls.Add(this.label17);
            this.customWriteOffGroupBox.Controls.Add(this.customWriteOffSumUpDown);
            this.customWriteOffGroupBox.Controls.Add(this.label18);
            this.customWriteOffGroupBox.Enabled = false;
            this.customWriteOffGroupBox.Location = new System.Drawing.Point(17, 106);
            this.customWriteOffGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.customWriteOffGroupBox.Name = "customWriteOffGroupBox";
            this.customWriteOffGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.customWriteOffGroupBox.Size = new System.Drawing.Size(371, 215);
            this.customWriteOffGroupBox.TabIndex = 12;
            this.customWriteOffGroupBox.TabStop = false;
            this.customWriteOffGroupBox.Text = "Naliczanie zmiennej części czynszu";
            this.customWriteOffGroupBox.Visible = false;
            this.customWriteOffGroupBox.Enter += new System.EventHandler(this.customWriteOffGroupBox_Enter);
            // 
            // customWriteOffCommentTextBox
            // 
            this.customWriteOffCommentTextBox.Location = new System.Drawing.Point(8, 105);
            this.customWriteOffCommentTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customWriteOffCommentTextBox.Name = "customWriteOffCommentTextBox";
            this.customWriteOffCommentTextBox.Size = new System.Drawing.Size(353, 102);
            this.customWriteOffCommentTextBox.TabIndex = 13;
            this.customWriteOffCommentTextBox.Text = "";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 85);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 16);
            this.label19.TabIndex = 12;
            this.label19.Text = "Komentarz";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 316);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 16);
            this.label16.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(120, 46);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 28);
            this.label17.TabIndex = 2;
            // 
            // customWriteOffSumUpDown
            // 
            this.customWriteOffSumUpDown.Location = new System.Drawing.Point(13, 46);
            this.customWriteOffSumUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.customWriteOffSumUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.customWriteOffSumUpDown.Name = "customWriteOffSumUpDown";
            this.customWriteOffSumUpDown.Size = new System.Drawing.Size(131, 22);
            this.customWriteOffSumUpDown.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 25);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 16);
            this.label18.TabIndex = 0;
            this.label18.Text = "Kwota";
            // 
            // NewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 565);
            this.Controls.Add(this.customWriteOffGroupBox);
            this.Controls.Add(this.newPaymentSetGroupBox);
            this.Controls.Add(this.paymentGroupBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.eventDateMonthCalendar);
            this.Controls.Add(this.newTermsGroupBox);
            this.Controls.Add(this.eventTypeComboBox);
            this.Controls.Add(this.personLabel);
            this.Controls.Add(this.zamowLabel);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "NewEvent";
            this.Text = "Nowe wydarzenie";
            this.Controls.SetChildIndex(this.zamowLabel, 0);
            this.Controls.SetChildIndex(this.personLabel, 0);
            this.Controls.SetChildIndex(this.eventTypeComboBox, 0);
            this.Controls.SetChildIndex(this.newTermsGroupBox, 0);
            this.Controls.SetChildIndex(this.eventDateMonthCalendar, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.paymentGroupBox, 0);
            this.Controls.SetChildIndex(this.newPaymentSetGroupBox, 0);
            this.Controls.SetChildIndex(this.customWriteOffGroupBox, 0);
            this.paymentGroupBox.ResumeLayout(false);
            this.paymentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentSumUpDown)).EndInit();
            this.newTermsGroupBox.ResumeLayout(false);
            this.newTermsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newTermsPenaltyUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payDateUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTermsPaymentUpDown)).EndInit();
            this.newPaymentSetGroupBox.ResumeLayout(false);
            this.newPaymentSetGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPaymentUpDown)).EndInit();
            this.customWriteOffGroupBox.ResumeLayout(false);
            this.customWriteOffGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customWriteOffSumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label zamowLabel;
        private System.Windows.Forms.Label personLabel;
        private System.Windows.Forms.ComboBox eventTypeComboBox;
        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown paymentSumUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar eventDateMonthCalendar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox newTermsGroupBox;
        private System.Windows.Forms.GroupBox leaveGroupBox;
        private System.Windows.Forms.NumericUpDown newTermsPenaltyUpDown;
        private System.Windows.Forms.NumericUpDown payDateUpDown;
        private System.Windows.Forms.NumericUpDown newTermsPaymentUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MonthCalendar termsEndMonthCalendar;
        private System.Windows.Forms.GroupBox newPaymentSetGroupBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown newPaymentUpDown;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox customWriteOffGroupBox;
        private System.Windows.Forms.RichTextBox customWriteOffCommentTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown customWriteOffSumUpDown;
        private System.Windows.Forms.Label label18;
    }
}