namespace EventManagementSystem
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
            this.Plaats = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnPlaatsEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnMedewerkersAdd = new System.Windows.Forms.Button();
            this.btnMedewerkersShowAllEmployee = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Medewerkers = new System.Windows.Forms.TabPage();
            this.btnMedewerkersShowAllGuest = new System.Windows.Forms.Button();
            this.btnMedewerkersShowAllAcc = new System.Windows.Forms.Button();
            this.cbMedewerkersRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbMedewerkerAccountID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tbMedewerkerAddress = new System.Windows.Forms.TextBox();
            this.tbMedewerkerPhonenumber = new System.Windows.Forms.TextBox();
            this.tbMedewerkerEmail = new System.Windows.Forms.TextBox();
            this.tbMedewerkerDateOfBirth = new System.Windows.Forms.TextBox();
            this.tbMedewerkerPostalcode = new System.Windows.Forms.TextBox();
            this.tbMedewerkerCity = new System.Windows.Forms.TextBox();
            this.tbMedewerkerPassword = new System.Windows.Forms.TextBox();
            this.tbMedewerkerLoginName = new System.Windows.Forms.TextBox();
            this.tbMedewerkerName = new System.Windows.Forms.TextBox();
            this.btnMedewerkersDelete = new System.Windows.Forms.Button();
            this.btnMedewerkersEdit = new System.Windows.Forms.Button();
            this.Events = new System.Windows.Forms.TabPage();
            this.tbEventBeschrijving = new System.Windows.Forms.TextBox();
            this.tbEventPrijs = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbEventEindDatum = new System.Windows.Forms.TextBox();
            this.tbEventBeginDatum = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbEventLocatie = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEventEventID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEventsDelete = new System.Windows.Forms.Button();
            this.btnEventsEdit = new System.Windows.Forms.Button();
            this.btnEventsAdd = new System.Windows.Forms.Button();
            this.btnEventsShow = new System.Windows.Forms.Button();
            this.Plaats.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.Medewerkers.SuspendLayout();
            this.Events.SuspendLayout();
            this.SuspendLayout();
            // 
            // Plaats
            // 
            this.Plaats.Controls.Add(this.label2);
            this.Plaats.Controls.Add(this.label3);
            this.Plaats.Controls.Add(this.textBox2);
            this.Plaats.Controls.Add(this.textBox3);
            this.Plaats.Controls.Add(this.btnPlaatsEdit);
            this.Plaats.Location = new System.Drawing.Point(4, 22);
            this.Plaats.Margin = new System.Windows.Forms.Padding(2);
            this.Plaats.Name = "Plaats";
            this.Plaats.Padding = new System.Windows.Forms.Padding(2);
            this.Plaats.Size = new System.Drawing.Size(430, 330);
            this.Plaats.TabIndex = 3;
            this.Plaats.Text = "Plaats";
            this.Plaats.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Vul plaats ID in:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Vul hier de prijs in:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 59);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 83);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(251, 20);
            this.textBox3.TabIndex = 2;
            // 
            // btnPlaatsEdit
            // 
            this.btnPlaatsEdit.Location = new System.Drawing.Point(278, 107);
            this.btnPlaatsEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlaatsEdit.Name = "btnPlaatsEdit";
            this.btnPlaatsEdit.Size = new System.Drawing.Size(86, 34);
            this.btnPlaatsEdit.TabIndex = 3;
            this.btnPlaatsEdit.Text = "Pas aan";
            this.btnPlaatsEdit.UseVisualStyleBackColor = true;
            this.btnPlaatsEdit.Click += new System.EventHandler(this.btnPlaatsEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(451, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(722, 359);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gevonden gegevens";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(4, 17);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(714, 338);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // btnMedewerkersAdd
            // 
            this.btnMedewerkersAdd.Location = new System.Drawing.Point(312, 251);
            this.btnMedewerkersAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnMedewerkersAdd.Name = "btnMedewerkersAdd";
            this.btnMedewerkersAdd.Size = new System.Drawing.Size(109, 33);
            this.btnMedewerkersAdd.TabIndex = 14;
            this.btnMedewerkersAdd.Text = "Voeg toe";
            this.btnMedewerkersAdd.UseVisualStyleBackColor = true;
            // 
            // btnMedewerkersShowAllEmployee
            // 
            this.btnMedewerkersShowAllEmployee.Location = new System.Drawing.Point(311, 173);
            this.btnMedewerkersShowAllEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnMedewerkersShowAllEmployee.Name = "btnMedewerkersShowAllEmployee";
            this.btnMedewerkersShowAllEmployee.Size = new System.Drawing.Size(110, 34);
            this.btnMedewerkersShowAllEmployee.TabIndex = 12;
            this.btnMedewerkersShowAllEmployee.Text = "Toon alle medewerkers";
            this.btnMedewerkersShowAllEmployee.UseVisualStyleBackColor = true;
            this.btnMedewerkersShowAllEmployee.Click += new System.EventHandler(this.btnMedewerkersShowAllEmployee_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Medewerkers);
            this.tabControl.Controls.Add(this.Events);
            this.tabControl.Controls.Add(this.Plaats);
            this.tabControl.Location = new System.Drawing.Point(9, 10);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(438, 356);
            this.tabControl.TabIndex = 20;
            // 
            // Medewerkers
            // 
            this.Medewerkers.Controls.Add(this.btnMedewerkersShowAllGuest);
            this.Medewerkers.Controls.Add(this.btnMedewerkersShowAllAcc);
            this.Medewerkers.Controls.Add(this.cbMedewerkersRole);
            this.Medewerkers.Controls.Add(this.label4);
            this.Medewerkers.Controls.Add(this.label7);
            this.Medewerkers.Controls.Add(this.label8);
            this.Medewerkers.Controls.Add(this.label11);
            this.Medewerkers.Controls.Add(this.label12);
            this.Medewerkers.Controls.Add(this.label13);
            this.Medewerkers.Controls.Add(this.label14);
            this.Medewerkers.Controls.Add(this.label15);
            this.Medewerkers.Controls.Add(this.label16);
            this.Medewerkers.Controls.Add(this.label17);
            this.Medewerkers.Controls.Add(this.label18);
            this.Medewerkers.Controls.Add(this.tbMedewerkerAccountID);
            this.Medewerkers.Controls.Add(this.label19);
            this.Medewerkers.Controls.Add(this.textBox6);
            this.Medewerkers.Controls.Add(this.tbMedewerkerAddress);
            this.Medewerkers.Controls.Add(this.tbMedewerkerPhonenumber);
            this.Medewerkers.Controls.Add(this.tbMedewerkerEmail);
            this.Medewerkers.Controls.Add(this.tbMedewerkerDateOfBirth);
            this.Medewerkers.Controls.Add(this.tbMedewerkerPostalcode);
            this.Medewerkers.Controls.Add(this.tbMedewerkerCity);
            this.Medewerkers.Controls.Add(this.tbMedewerkerPassword);
            this.Medewerkers.Controls.Add(this.tbMedewerkerLoginName);
            this.Medewerkers.Controls.Add(this.tbMedewerkerName);
            this.Medewerkers.Controls.Add(this.btnMedewerkersDelete);
            this.Medewerkers.Controls.Add(this.btnMedewerkersEdit);
            this.Medewerkers.Controls.Add(this.btnMedewerkersAdd);
            this.Medewerkers.Controls.Add(this.btnMedewerkersShowAllEmployee);
            this.Medewerkers.Location = new System.Drawing.Point(4, 22);
            this.Medewerkers.Margin = new System.Windows.Forms.Padding(2);
            this.Medewerkers.Name = "Medewerkers";
            this.Medewerkers.Padding = new System.Windows.Forms.Padding(2);
            this.Medewerkers.Size = new System.Drawing.Size(430, 330);
            this.Medewerkers.TabIndex = 0;
            this.Medewerkers.Text = "Medewerkers";
            this.Medewerkers.UseVisualStyleBackColor = true;
            // 
            // btnMedewerkersShowAllGuest
            // 
            this.btnMedewerkersShowAllGuest.Location = new System.Drawing.Point(312, 136);
            this.btnMedewerkersShowAllGuest.Name = "btnMedewerkersShowAllGuest";
            this.btnMedewerkersShowAllGuest.Size = new System.Drawing.Size(109, 32);
            this.btnMedewerkersShowAllGuest.TabIndex = 61;
            this.btnMedewerkersShowAllGuest.Text = "Toon alle gasten";
            this.btnMedewerkersShowAllGuest.UseVisualStyleBackColor = true;
            this.btnMedewerkersShowAllGuest.Click += new System.EventHandler(this.btnMedewerkersShowAllGuest_Click);
            // 
            // btnMedewerkersShowAllAcc
            // 
            this.btnMedewerkersShowAllAcc.Location = new System.Drawing.Point(312, 98);
            this.btnMedewerkersShowAllAcc.Name = "btnMedewerkersShowAllAcc";
            this.btnMedewerkersShowAllAcc.Size = new System.Drawing.Size(109, 32);
            this.btnMedewerkersShowAllAcc.TabIndex = 60;
            this.btnMedewerkersShowAllAcc.Text = "Toon alle accounts";
            this.btnMedewerkersShowAllAcc.UseVisualStyleBackColor = true;
            // 
            // cbMedewerkersRole
            // 
            this.cbMedewerkersRole.FormattingEnabled = true;
            this.cbMedewerkersRole.Location = new System.Drawing.Point(96, 59);
            this.cbMedewerkersRole.Name = "cbMedewerkersRole";
            this.cbMedewerkersRole.Size = new System.Drawing.Size(204, 21);
            this.cbMedewerkersRole.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Rol:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Wachtwoord:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Login naam:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 301);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Account ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 273);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Reserverings ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 232);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Telefoon:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 208);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "Email adres:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 184);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Geboorte datum:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 160);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 51;
            this.label16.Text = "Postcode:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 136);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "Stad:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 113);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 49;
            this.label18.Text = "Adres:";
            // 
            // tbMedewerkerAccountID
            // 
            this.tbMedewerkerAccountID.Location = new System.Drawing.Point(96, 299);
            this.tbMedewerkerAccountID.Margin = new System.Windows.Forms.Padding(2);
            this.tbMedewerkerAccountID.Name = "tbMedewerkerAccountID";
            this.tbMedewerkerAccountID.Size = new System.Drawing.Size(204, 20);
            this.tbMedewerkerAccountID.TabIndex = 47;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 89);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 48;
            this.label19.Text = "Naam:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(96, 271);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(204, 20);
            this.textBox6.TabIndex = 46;
            // 
            // tbMedewerkerAddress
            // 
            this.tbMedewerkerAddress.Location = new System.Drawing.Point(96, 110);
            this.tbMedewerkerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbMedewerkerAddress.Name = "tbMedewerkerAddress";
            this.tbMedewerkerAddress.Size = new System.Drawing.Size(204, 20);
            this.tbMedewerkerAddress.TabIndex = 40;
            // 
            // tbMedewerkerPhonenumber
            // 
            this.tbMedewerkerPhonenumber.Location = new System.Drawing.Point(96, 230);
            this.tbMedewerkerPhonenumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbMedewerkerPhonenumber.Name = "tbMedewerkerPhonenumber";
            this.tbMedewerkerPhonenumber.Size = new System.Drawing.Size(204, 20);
            this.tbMedewerkerPhonenumber.TabIndex = 45;
            // 
            // tbMedewerkerEmail
            // 
            this.tbMedewerkerEmail.Location = new System.Drawing.Point(96, 206);
            this.tbMedewerkerEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbMedewerkerEmail.Name = "tbMedewerkerEmail";
            this.tbMedewerkerEmail.Size = new System.Drawing.Size(204, 20);
            this.tbMedewerkerEmail.TabIndex = 44;
            // 
            // tbMedewerkerDateOfBirth
            // 
            this.tbMedewerkerDateOfBirth.Location = new System.Drawing.Point(96, 182);
            this.tbMedewerkerDateOfBirth.Margin = new System.Windows.Forms.Padding(2);
            this.tbMedewerkerDateOfBirth.Name = "tbMedewerkerDateOfBirth";
            this.tbMedewerkerDateOfBirth.Size = new System.Drawing.Size(204, 20);
            this.tbMedewerkerDateOfBirth.TabIndex = 43;
            // 
            // tbMedewerkerPostalcode
            // 
            this.tbMedewerkerPostalcode.Location = new System.Drawing.Point(96, 158);
            this.tbMedewerkerPostalcode.Margin = new System.Windows.Forms.Padding(2);
            this.tbMedewerkerPostalcode.Name = "tbMedewerkerPostalcode";
            this.tbMedewerkerPostalcode.Size = new System.Drawing.Size(204, 20);
            this.tbMedewerkerPostalcode.TabIndex = 42;
            // 
            // tbMedewerkerCity
            // 
            this.tbMedewerkerCity.Location = new System.Drawing.Point(96, 134);
            this.tbMedewerkerCity.Margin = new System.Windows.Forms.Padding(2);
            this.tbMedewerkerCity.Name = "tbMedewerkerCity";
            this.tbMedewerkerCity.Size = new System.Drawing.Size(204, 20);
            this.tbMedewerkerCity.TabIndex = 41;
            // 
            // tbMedewerkerPassword
            // 
            this.tbMedewerkerPassword.Location = new System.Drawing.Point(96, 35);
            this.tbMedewerkerPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbMedewerkerPassword.Name = "tbMedewerkerPassword";
            this.tbMedewerkerPassword.Size = new System.Drawing.Size(204, 20);
            this.tbMedewerkerPassword.TabIndex = 37;
            // 
            // tbMedewerkerLoginName
            // 
            this.tbMedewerkerLoginName.Location = new System.Drawing.Point(96, 12);
            this.tbMedewerkerLoginName.Margin = new System.Windows.Forms.Padding(2);
            this.tbMedewerkerLoginName.Name = "tbMedewerkerLoginName";
            this.tbMedewerkerLoginName.Size = new System.Drawing.Size(204, 20);
            this.tbMedewerkerLoginName.TabIndex = 36;
            // 
            // tbMedewerkerName
            // 
            this.tbMedewerkerName.Location = new System.Drawing.Point(96, 86);
            this.tbMedewerkerName.Margin = new System.Windows.Forms.Padding(2);
            this.tbMedewerkerName.Name = "tbMedewerkerName";
            this.tbMedewerkerName.Size = new System.Drawing.Size(204, 20);
            this.tbMedewerkerName.TabIndex = 39;
            // 
            // btnMedewerkersDelete
            // 
            this.btnMedewerkersDelete.Location = new System.Drawing.Point(312, 288);
            this.btnMedewerkersDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnMedewerkersDelete.Name = "btnMedewerkersDelete";
            this.btnMedewerkersDelete.Size = new System.Drawing.Size(109, 33);
            this.btnMedewerkersDelete.TabIndex = 15;
            this.btnMedewerkersDelete.Text = "Verwijder";
            this.btnMedewerkersDelete.UseVisualStyleBackColor = true;
            // 
            // btnMedewerkersEdit
            // 
            this.btnMedewerkersEdit.Location = new System.Drawing.Point(312, 213);
            this.btnMedewerkersEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnMedewerkersEdit.Name = "btnMedewerkersEdit";
            this.btnMedewerkersEdit.Size = new System.Drawing.Size(109, 33);
            this.btnMedewerkersEdit.TabIndex = 13;
            this.btnMedewerkersEdit.Text = "Pas aan";
            this.btnMedewerkersEdit.UseVisualStyleBackColor = true;
            // 
            // Events
            // 
            this.Events.Controls.Add(this.tbEventBeschrijving);
            this.Events.Controls.Add(this.tbEventPrijs);
            this.Events.Controls.Add(this.label23);
            this.Events.Controls.Add(this.tbEventEindDatum);
            this.Events.Controls.Add(this.tbEventBeginDatum);
            this.Events.Controls.Add(this.label22);
            this.Events.Controls.Add(this.tbEventLocatie);
            this.Events.Controls.Add(this.label35);
            this.Events.Controls.Add(this.label10);
            this.Events.Controls.Add(this.tbEventEventID);
            this.Events.Controls.Add(this.label9);
            this.Events.Controls.Add(this.label1);
            this.Events.Controls.Add(this.btnEventsDelete);
            this.Events.Controls.Add(this.btnEventsEdit);
            this.Events.Controls.Add(this.btnEventsAdd);
            this.Events.Controls.Add(this.btnEventsShow);
            this.Events.Location = new System.Drawing.Point(4, 22);
            this.Events.Margin = new System.Windows.Forms.Padding(2);
            this.Events.Name = "Events";
            this.Events.Padding = new System.Windows.Forms.Padding(2);
            this.Events.Size = new System.Drawing.Size(430, 330);
            this.Events.TabIndex = 1;
            this.Events.Text = "Events";
            this.Events.UseVisualStyleBackColor = true;
            // 
            // tbEventBeschrijving
            // 
            this.tbEventBeschrijving.Location = new System.Drawing.Point(81, 115);
            this.tbEventBeschrijving.Multiline = true;
            this.tbEventBeschrijving.Name = "tbEventBeschrijving";
            this.tbEventBeschrijving.Size = new System.Drawing.Size(193, 102);
            this.tbEventBeschrijving.TabIndex = 5;
            // 
            // tbEventPrijs
            // 
            this.tbEventPrijs.Location = new System.Drawing.Point(81, 222);
            this.tbEventPrijs.Name = "tbEventPrijs";
            this.tbEventPrijs.Size = new System.Drawing.Size(193, 20);
            this.tbEventPrijs.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 118);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 13);
            this.label23.TabIndex = 33;
            this.label23.Text = "Beschrijving:";
            // 
            // tbEventEindDatum
            // 
            this.tbEventEindDatum.Location = new System.Drawing.Point(81, 88);
            this.tbEventEindDatum.Name = "tbEventEindDatum";
            this.tbEventEindDatum.Size = new System.Drawing.Size(193, 20);
            this.tbEventEindDatum.TabIndex = 4;
            // 
            // tbEventBeginDatum
            // 
            this.tbEventBeginDatum.Location = new System.Drawing.Point(81, 63);
            this.tbEventBeginDatum.Name = "tbEventBeginDatum";
            this.tbEventBeginDatum.Size = new System.Drawing.Size(193, 20);
            this.tbEventBeginDatum.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 225);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 13);
            this.label22.TabIndex = 33;
            this.label22.Text = "Prijs:";
            // 
            // tbEventLocatie
            // 
            this.tbEventLocatie.Location = new System.Drawing.Point(81, 37);
            this.tbEventLocatie.Name = "tbEventLocatie";
            this.tbEventLocatie.Size = new System.Drawing.Size(193, 20);
            this.tbEventLocatie.TabIndex = 2;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 91);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(63, 13);
            this.label35.TabIndex = 33;
            this.label35.Text = "Eind datum:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Begin datum:";
            // 
            // tbEventEventID
            // 
            this.tbEventEventID.Location = new System.Drawing.Point(81, 8);
            this.tbEventEventID.Name = "tbEventEventID";
            this.tbEventEventID.Size = new System.Drawing.Size(193, 20);
            this.tbEventEventID.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Locatie:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Event ID:";
            // 
            // btnEventsDelete
            // 
            this.btnEventsDelete.Location = new System.Drawing.Point(292, 209);
            this.btnEventsDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventsDelete.Name = "btnEventsDelete";
            this.btnEventsDelete.Size = new System.Drawing.Size(116, 33);
            this.btnEventsDelete.TabIndex = 10;
            this.btnEventsDelete.Text = "Verwijder";
            this.btnEventsDelete.UseVisualStyleBackColor = true;
            this.btnEventsDelete.Click += new System.EventHandler(this.btnEventsDelete_Click);
            // 
            // btnEventsEdit
            // 
            this.btnEventsEdit.Location = new System.Drawing.Point(292, 135);
            this.btnEventsEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventsEdit.Name = "btnEventsEdit";
            this.btnEventsEdit.Size = new System.Drawing.Size(116, 33);
            this.btnEventsEdit.TabIndex = 8;
            this.btnEventsEdit.Text = "Pas aan";
            this.btnEventsEdit.UseVisualStyleBackColor = true;
            this.btnEventsEdit.Click += new System.EventHandler(this.btnEventsEdit_Click);
            // 
            // btnEventsAdd
            // 
            this.btnEventsAdd.Location = new System.Drawing.Point(293, 172);
            this.btnEventsAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventsAdd.Name = "btnEventsAdd";
            this.btnEventsAdd.Size = new System.Drawing.Size(116, 33);
            this.btnEventsAdd.TabIndex = 9;
            this.btnEventsAdd.Text = "Voeg toe";
            this.btnEventsAdd.UseVisualStyleBackColor = true;
            this.btnEventsAdd.Click += new System.EventHandler(this.btnEventsAdd_Click);
            // 
            // btnEventsShow
            // 
            this.btnEventsShow.Location = new System.Drawing.Point(292, 98);
            this.btnEventsShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventsShow.Name = "btnEventsShow";
            this.btnEventsShow.Size = new System.Drawing.Size(117, 34);
            this.btnEventsShow.TabIndex = 7;
            this.btnEventsShow.Text = "Toon alle events";
            this.btnEventsShow.UseVisualStyleBackColor = true;
            this.btnEventsShow.Click += new System.EventHandler(this.btnEventsShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Event Management System";
            this.Plaats.ResumeLayout(false);
            this.Plaats.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.Medewerkers.ResumeLayout(false);
            this.Medewerkers.PerformLayout();
            this.Events.ResumeLayout(false);
            this.Events.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Plaats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnPlaatsEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnMedewerkersAdd;
        private System.Windows.Forms.Button btnMedewerkersShowAllEmployee;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Medewerkers;
        private System.Windows.Forms.TabPage Events;
        private System.Windows.Forms.Button btnEventsAdd;
        private System.Windows.Forms.Button btnEventsShow;
        private System.Windows.Forms.TextBox tbEventBeschrijving;
        private System.Windows.Forms.TextBox tbEventPrijs;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbEventEindDatum;
        private System.Windows.Forms.TextBox tbEventBeginDatum;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbEventLocatie;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEventEventID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMedewerkersDelete;
        private System.Windows.Forms.Button btnMedewerkersEdit;
        private System.Windows.Forms.Button btnEventsDelete;
        private System.Windows.Forms.Button btnEventsEdit;
        private System.Windows.Forms.ComboBox cbMedewerkersRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbMedewerkerAccountID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox tbMedewerkerAddress;
        private System.Windows.Forms.TextBox tbMedewerkerPhonenumber;
        private System.Windows.Forms.TextBox tbMedewerkerEmail;
        private System.Windows.Forms.TextBox tbMedewerkerDateOfBirth;
        private System.Windows.Forms.TextBox tbMedewerkerPostalcode;
        private System.Windows.Forms.TextBox tbMedewerkerCity;
        private System.Windows.Forms.TextBox tbMedewerkerPassword;
        private System.Windows.Forms.TextBox tbMedewerkerLoginName;
        private System.Windows.Forms.TextBox tbMedewerkerName;
        private System.Windows.Forms.Button btnMedewerkersShowAllGuest;
        private System.Windows.Forms.Button btnMedewerkersShowAllAcc;
    }
}

