namespace ReservationSystem
{
    partial class Form1
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
            this.dgReservations = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbField = new System.Windows.Forms.ComboBox();
            this.txtFieldValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btSearchReservation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCancelReservation = new System.Windows.Forms.Button();
            this.txtReservationIDDelete = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btReset = new System.Windows.Forms.Button();
            this.btPlaceReservation = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbPlaceStatus = new System.Windows.Forms.Label();
            this.lbAmountPersonsValue = new System.Windows.Forms.Label();
            this.lbAmountPersons = new System.Windows.Forms.Label();
            this.btCheckPlace = new System.Windows.Forms.Button();
            this.lbPlaceNumber = new System.Windows.Forms.Label();
            this.txtCheckPlace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btAddPersons = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservations)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgReservations
            // 
            this.dgReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservations.Location = new System.Drawing.Point(4, 17);
            this.dgReservations.Margin = new System.Windows.Forms.Padding(2);
            this.dgReservations.Name = "dgReservations";
            this.dgReservations.RowTemplate.Height = 24;
            this.dgReservations.Size = new System.Drawing.Size(608, 313);
            this.dgReservations.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cbField);
            this.groupBox3.Controls.Add(this.txtFieldValue);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btSearchReservation);
            this.groupBox3.Location = new System.Drawing.Point(237, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(228, 171);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zoekfunctie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Vul gegevens in:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Selecteer je veld:";
            // 
            // cbField
            // 
            this.cbField.FormattingEnabled = true;
            this.cbField.Items.AddRange(new object[] {
            "ReservationID",
            "LocationID",
            "TotalAmount",
            "PaymentStatus"});
            this.cbField.Location = new System.Drawing.Point(4, 69);
            this.cbField.Margin = new System.Windows.Forms.Padding(2);
            this.cbField.Name = "cbField";
            this.cbField.Size = new System.Drawing.Size(220, 21);
            this.cbField.TabIndex = 9;
            // 
            // txtFieldValue
            // 
            this.txtFieldValue.Location = new System.Drawing.Point(5, 107);
            this.txtFieldValue.Margin = new System.Windows.Forms.Padding(2);
            this.txtFieldValue.Name = "txtFieldValue";
            this.txtFieldValue.Size = new System.Drawing.Size(220, 20);
            this.txtFieldValue.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Zoek hier een reservering op";
            // 
            // btSearchReservation
            // 
            this.btSearchReservation.Location = new System.Drawing.Point(136, 130);
            this.btSearchReservation.Margin = new System.Windows.Forms.Padding(2);
            this.btSearchReservation.Name = "btSearchReservation";
            this.btSearchReservation.Size = new System.Drawing.Size(86, 33);
            this.btSearchReservation.TabIndex = 1;
            this.btSearchReservation.Text = "Zoeken";
            this.btSearchReservation.UseVisualStyleBackColor = true;
            this.btSearchReservation.Click += new System.EventHandler(this.btSearchReservation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgReservations);
            this.groupBox1.Location = new System.Drawing.Point(470, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(616, 335);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gevonden gegevens";
            // 
            // btCancelReservation
            // 
            this.btCancelReservation.Location = new System.Drawing.Point(4, 119);
            this.btCancelReservation.Margin = new System.Windows.Forms.Padding(2);
            this.btCancelReservation.Name = "btCancelReservation";
            this.btCancelReservation.Size = new System.Drawing.Size(67, 33);
            this.btCancelReservation.TabIndex = 2;
            this.btCancelReservation.Text = "Annuleren";
            this.btCancelReservation.UseVisualStyleBackColor = true;
            this.btCancelReservation.Click += new System.EventHandler(this.btCancelReservation_Click);
            // 
            // txtReservationIDDelete
            // 
            this.txtReservationIDDelete.Location = new System.Drawing.Point(3, 95);
            this.txtReservationIDDelete.Margin = new System.Windows.Forms.Padding(2);
            this.txtReservationIDDelete.Name = "txtReservationIDDelete";
            this.txtReservationIDDelete.Size = new System.Drawing.Size(219, 20);
            this.txtReservationIDDelete.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Vul hier het reserveringsnummer in";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 46);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Als dit niet bekend is bij de klant";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 59);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Zoek het dan op in met de zoekfunctie";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 79);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Reserveringsnummer:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtReservationIDDelete);
            this.groupBox4.Controls.Add(this.btCancelReservation);
            this.groupBox4.Location = new System.Drawing.Point(238, 187);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(227, 158);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reservering annuleren";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btReset);
            this.groupBox2.Controls.Add(this.btPlaceReservation);
            this.groupBox2.Controls.Add(this.dtpEndDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpStartDate);
            this.groupBox2.Controls.Add(this.lbPlaceStatus);
            this.groupBox2.Controls.Add(this.lbAmountPersonsValue);
            this.groupBox2.Controls.Add(this.lbAmountPersons);
            this.groupBox2.Controls.Add(this.btCheckPlace);
            this.groupBox2.Controls.Add(this.lbPlaceNumber);
            this.groupBox2.Controls.Add(this.txtCheckPlace);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btAddPersons);
            this.groupBox2.Location = new System.Drawing.Point(11, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(218, 306);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservering";
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(4, 266);
            this.btReset.Margin = new System.Windows.Forms.Padding(2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(94, 36);
            this.btReset.TabIndex = 23;
            this.btReset.Text = "Reset alles";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btPlaceReservation
            // 
            this.btPlaceReservation.Location = new System.Drawing.Point(102, 266);
            this.btPlaceReservation.Margin = new System.Windows.Forms.Padding(2);
            this.btPlaceReservation.Name = "btPlaceReservation";
            this.btPlaceReservation.Size = new System.Drawing.Size(112, 36);
            this.btPlaceReservation.TabIndex = 22;
            this.btPlaceReservation.Text = "Plaats reservering";
            this.btPlaceReservation.UseVisualStyleBackColor = true;
            this.btPlaceReservation.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(7, 161);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(202, 20);
            this.dtpEndDate.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Einddatum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Begindatum:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(7, 111);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(202, 20);
            this.dtpStartDate.TabIndex = 18;
            // 
            // lbPlaceStatus
            // 
            this.lbPlaceStatus.AutoSize = true;
            this.lbPlaceStatus.Location = new System.Drawing.Point(4, 73);
            this.lbPlaceStatus.Name = "lbPlaceStatus";
            this.lbPlaceStatus.Size = new System.Drawing.Size(133, 13);
            this.lbPlaceStatus.TabIndex = 17;
            this.lbPlaceStatus.Text = "<vul een plaatsnummer in>";
            // 
            // lbAmountPersonsValue
            // 
            this.lbAmountPersonsValue.AutoSize = true;
            this.lbAmountPersonsValue.Location = new System.Drawing.Point(88, 197);
            this.lbAmountPersonsValue.Name = "lbAmountPersonsValue";
            this.lbAmountPersonsValue.Size = new System.Drawing.Size(13, 13);
            this.lbAmountPersonsValue.TabIndex = 16;
            this.lbAmountPersonsValue.Text = "0";
            // 
            // lbAmountPersons
            // 
            this.lbAmountPersons.AutoSize = true;
            this.lbAmountPersons.Location = new System.Drawing.Point(2, 197);
            this.lbAmountPersons.Name = "lbAmountPersons";
            this.lbAmountPersons.Size = new System.Drawing.Size(87, 13);
            this.lbAmountPersons.TabIndex = 15;
            this.lbAmountPersons.Text = "Aantal personen:";
            // 
            // btCheckPlace
            // 
            this.btCheckPlace.Location = new System.Drawing.Point(92, 43);
            this.btCheckPlace.Margin = new System.Windows.Forms.Padding(2);
            this.btCheckPlace.Name = "btCheckPlace";
            this.btCheckPlace.Size = new System.Drawing.Size(122, 27);
            this.btCheckPlace.TabIndex = 14;
            this.btCheckPlace.Text = "Controleer plaats";
            this.btCheckPlace.UseVisualStyleBackColor = true;
            this.btCheckPlace.Click += new System.EventHandler(this.btCheckPlace_Click);
            // 
            // lbPlaceNumber
            // 
            this.lbPlaceNumber.AutoSize = true;
            this.lbPlaceNumber.Location = new System.Drawing.Point(4, 31);
            this.lbPlaceNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPlaceNumber.Name = "lbPlaceNumber";
            this.lbPlaceNumber.Size = new System.Drawing.Size(76, 13);
            this.lbPlaceNumber.TabIndex = 13;
            this.lbPlaceNumber.Text = "Plaatsnummer:";
            // 
            // txtCheckPlace
            // 
            this.txtCheckPlace.Location = new System.Drawing.Point(5, 47);
            this.txtCheckPlace.Margin = new System.Windows.Forms.Padding(2);
            this.txtCheckPlace.Name = "txtCheckPlace";
            this.txtCheckPlace.Size = new System.Drawing.Size(83, 20);
            this.txtCheckPlace.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vul alle gegevens in en plaat een reservering";
            // 
            // btAddPersons
            // 
            this.btAddPersons.Location = new System.Drawing.Point(4, 212);
            this.btAddPersons.Margin = new System.Windows.Forms.Padding(2);
            this.btAddPersons.Name = "btAddPersons";
            this.btAddPersons.Size = new System.Drawing.Size(116, 36);
            this.btAddPersons.TabIndex = 0;
            this.btAddPersons.Text = "Voeg personen toe";
            this.btAddPersons.UseVisualStyleBackColor = true;
            this.btAddPersons.Click += new System.EventHandler(this.btAddPersons_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgReservations)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgReservations;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbField;
        private System.Windows.Forms.TextBox txtFieldValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btSearchReservation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCancelReservation;
        private System.Windows.Forms.TextBox txtReservationIDDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btPlaceReservation;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lbPlaceStatus;
        public System.Windows.Forms.Label lbAmountPersonsValue;
        private System.Windows.Forms.Label lbAmountPersons;
        private System.Windows.Forms.Button btCheckPlace;
        private System.Windows.Forms.Label lbPlaceNumber;
        private System.Windows.Forms.TextBox txtCheckPlace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAddPersons;

    }
}

