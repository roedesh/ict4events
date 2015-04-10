namespace ReservationSystem
{
    partial class ExtraPersons
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
            this.lstPersons = new System.Windows.Forms.ListBox();
            this.gboxPersons = new System.Windows.Forms.GroupBox();
            this.btCancelForm = new System.Windows.Forms.Button();
            this.btSubmitForm = new System.Windows.Forms.Button();
            this.gboxAdd = new System.Windows.Forms.GroupBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btAddPerson = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTutorial = new System.Windows.Forms.Label();
            this.gboxPersons.SuspendLayout();
            this.gboxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPersons
            // 
            this.lstPersons.FormattingEnabled = true;
            this.lstPersons.Location = new System.Drawing.Point(4, 17);
            this.lstPersons.Margin = new System.Windows.Forms.Padding(2);
            this.lstPersons.Name = "lstPersons";
            this.lstPersons.Size = new System.Drawing.Size(416, 290);
            this.lstPersons.TabIndex = 9;
            this.lstPersons.SelectedIndexChanged += new System.EventHandler(this.lstPersons_SelectedIndexChanged);
            // 
            // gboxPersons
            // 
            this.gboxPersons.Controls.Add(this.btCancelForm);
            this.gboxPersons.Controls.Add(this.btSubmitForm);
            this.gboxPersons.Controls.Add(this.lstPersons);
            this.gboxPersons.Location = new System.Drawing.Point(252, 10);
            this.gboxPersons.Margin = new System.Windows.Forms.Padding(2);
            this.gboxPersons.Name = "gboxPersons";
            this.gboxPersons.Padding = new System.Windows.Forms.Padding(2);
            this.gboxPersons.Size = new System.Drawing.Size(424, 412);
            this.gboxPersons.TabIndex = 6;
            this.gboxPersons.TabStop = false;
            this.gboxPersons.Text = "Bijbehorende personen";
            // 
            // btCancelForm
            // 
            this.btCancelForm.Location = new System.Drawing.Point(244, 367);
            this.btCancelForm.Margin = new System.Windows.Forms.Padding(2);
            this.btCancelForm.Name = "btCancelForm";
            this.btCancelForm.Size = new System.Drawing.Size(86, 33);
            this.btCancelForm.TabIndex = 10;
            this.btCancelForm.Text = "Annuleren";
            this.btCancelForm.UseVisualStyleBackColor = true;
            // 
            // btSubmitForm
            // 
            this.btSubmitForm.Location = new System.Drawing.Point(334, 367);
            this.btSubmitForm.Margin = new System.Windows.Forms.Padding(2);
            this.btSubmitForm.Name = "btSubmitForm";
            this.btSubmitForm.Size = new System.Drawing.Size(86, 33);
            this.btSubmitForm.TabIndex = 11;
            this.btSubmitForm.Text = "Voltooien";
            this.btSubmitForm.UseVisualStyleBackColor = true;
            // 
            // gboxAdd
            // 
            this.gboxAdd.Controls.Add(this.lblPostalCode);
            this.gboxAdd.Controls.Add(this.txtPostalCode);
            this.gboxAdd.Controls.Add(this.txtAddress);
            this.gboxAdd.Controls.Add(this.lblAddress);
            this.gboxAdd.Controls.Add(this.btAddPerson);
            this.gboxAdd.Controls.Add(this.txtPhone);
            this.gboxAdd.Controls.Add(this.lblPhone);
            this.gboxAdd.Controls.Add(this.txtEmail);
            this.gboxAdd.Controls.Add(this.lblEmail);
            this.gboxAdd.Controls.Add(this.dtpDateOfBirth);
            this.gboxAdd.Controls.Add(this.lblDateOfBirth);
            this.gboxAdd.Controls.Add(this.txtCity);
            this.gboxAdd.Controls.Add(this.lblCity);
            this.gboxAdd.Controls.Add(this.txtName);
            this.gboxAdd.Controls.Add(this.lblName);
            this.gboxAdd.Controls.Add(this.lblTutorial);
            this.gboxAdd.Location = new System.Drawing.Point(13, 10);
            this.gboxAdd.Name = "gboxAdd";
            this.gboxAdd.Size = new System.Drawing.Size(234, 412);
            this.gboxAdd.TabIndex = 7;
            this.gboxAdd.TabStop = false;
            this.gboxAdd.Text = "Personen toevoegen";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(136, 165);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(55, 13);
            this.lblPostalCode.TabIndex = 14;
            this.lblPostalCode.Text = "Postcode:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(139, 181);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(87, 20);
            this.txtPostalCode.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(10, 128);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(216, 20);
            this.txtAddress.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 112);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(34, 13);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Adres";
            // 
            // btAddPerson
            // 
            this.btAddPerson.Location = new System.Drawing.Point(123, 367);
            this.btAddPerson.Margin = new System.Windows.Forms.Padding(2);
            this.btAddPerson.Name = "btAddPerson";
            this.btAddPerson.Size = new System.Drawing.Size(104, 33);
            this.btAddPerson.TabIndex = 8;
            this.btAddPerson.Text = "Voeg persoon toe";
            this.btAddPerson.UseVisualStyleBackColor = true;
            this.btAddPerson.Click += new System.EventHandler(this.btAddPerson_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(9, 282);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(219, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(7, 266);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 13);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Telefoon:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(9, 232);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 216);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(9, 333);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(218, 20);
            this.dtpDateOfBirth.TabIndex = 7;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(6, 316);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(83, 13);
            this.lblDateOfBirth.TabIndex = 5;
            this.lblDateOfBirth.Text = "Geboortedatum:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(10, 181);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(123, 20);
            this.txtCity.TabIndex = 3;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 165);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(67, 13);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "Woonplaats:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(9, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Naam:";
            // 
            // lblTutorial
            // 
            this.lblTutorial.Location = new System.Drawing.Point(7, 20);
            this.lblTutorial.Name = "lblTutorial";
            this.lblTutorial.Size = new System.Drawing.Size(221, 27);
            this.lblTutorial.TabIndex = 0;
            this.lblTutorial.Text = "Vul onderstaande gevens in om personen toe te voegen";
            // 
            // ExtraPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 433);
            this.Controls.Add(this.gboxAdd);
            this.Controls.Add(this.gboxPersons);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExtraPersons";
            this.Text = "Vul de persoonsgegevens in";
            this.gboxPersons.ResumeLayout(false);
            this.gboxAdd.ResumeLayout(false);
            this.gboxAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPersons;
        private System.Windows.Forms.GroupBox gboxPersons;
        private System.Windows.Forms.Button btCancelForm;
        private System.Windows.Forms.Button btSubmitForm;
        private System.Windows.Forms.GroupBox gboxAdd;
        private System.Windows.Forms.Label lblTutorial;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btAddPerson;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox txtPostalCode;

    }
}