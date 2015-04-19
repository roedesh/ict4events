namespace MaterialRentalSysteem
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRentItem = new System.Windows.Forms.Button();
            this.tbRentCount = new System.Windows.Forms.TextBox();
            this.tbRentItemRFID = new System.Windows.Forms.TextBox();
            this.tbRentItemID = new System.Windows.Forms.TextBox();
            this.tbRentPersonName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnArtikelPasAan = new System.Windows.Forms.Button();
            this.tbChangeCount = new System.Windows.Forms.TextBox();
            this.btnArtikelVerwijder = new System.Windows.Forms.Button();
            this.tbChangePrice = new System.Windows.Forms.TextBox();
            this.tbChangeType = new System.Windows.Forms.TextBox();
            this.tbChangeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTakeRental = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbAddStock = new System.Windows.Forms.TextBox();
            this.tbAddPrice = new System.Windows.Forms.TextBox();
            this.btnArtikelVoegToe = new System.Windows.Forms.Button();
            this.tbAddType = new System.Windows.Forms.TextBox();
            this.tbAddName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpRentItemEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnItemRentSearchPerson = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnSearchSelect = new System.Windows.Forms.Button();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbSearchPerson = new System.Windows.Forms.TextBox();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Vul hier het aantal in:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Naam:";
            // 
            // btnRentItem
            // 
            this.btnRentItem.Location = new System.Drawing.Point(7, 130);
            this.btnRentItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnRentItem.Name = "btnRentItem";
            this.btnRentItem.Size = new System.Drawing.Size(256, 51);
            this.btnRentItem.TabIndex = 59;
            this.btnRentItem.Text = "Leen uit";
            this.btnRentItem.UseVisualStyleBackColor = true;
            this.btnRentItem.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // tbRentCount
            // 
            this.tbRentCount.Location = new System.Drawing.Point(131, 67);
            this.tbRentCount.Margin = new System.Windows.Forms.Padding(2);
            this.tbRentCount.Name = "tbRentCount";
            this.tbRentCount.Size = new System.Drawing.Size(123, 20);
            this.tbRentCount.TabIndex = 63;
            // 
            // tbRentItemRFID
            // 
            this.tbRentItemRFID.Location = new System.Drawing.Point(4, 67);
            this.tbRentItemRFID.Margin = new System.Windows.Forms.Padding(2);
            this.tbRentItemRFID.Name = "tbRentItemRFID";
            this.tbRentItemRFID.ReadOnly = true;
            this.tbRentItemRFID.Size = new System.Drawing.Size(123, 20);
            this.tbRentItemRFID.TabIndex = 55;
            // 
            // tbRentItemID
            // 
            this.tbRentItemID.Location = new System.Drawing.Point(131, 21);
            this.tbRentItemID.Margin = new System.Windows.Forms.Padding(2);
            this.tbRentItemID.Name = "tbRentItemID";
            this.tbRentItemID.ReadOnly = true;
            this.tbRentItemID.Size = new System.Drawing.Size(123, 20);
            this.tbRentItemID.TabIndex = 61;
            // 
            // tbRentPersonName
            // 
            this.tbRentPersonName.Location = new System.Drawing.Point(4, 22);
            this.tbRentPersonName.Margin = new System.Windows.Forms.Padding(2);
            this.tbRentPersonName.Name = "tbRentPersonName";
            this.tbRentPersonName.ReadOnly = true;
            this.tbRentPersonName.Size = new System.Drawing.Size(123, 20);
            this.tbRentPersonName.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "RFID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnArtikelPasAan);
            this.tabPage2.Controls.Add(this.tbChangeCount);
            this.tabPage2.Controls.Add(this.btnArtikelVerwijder);
            this.tabPage2.Controls.Add(this.tbChangePrice);
            this.tabPage2.Controls.Add(this.tbChangeType);
            this.tabPage2.Controls.Add(this.tbChangeName);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(275, 230);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Artikel aanpassen/verwijderen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Vul hier het aantal in:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Vul hier de naam in:";
            // 
            // btnArtikelPasAan
            // 
            this.btnArtikelPasAan.Location = new System.Drawing.Point(7, 154);
            this.btnArtikelPasAan.Margin = new System.Windows.Forms.Padding(2);
            this.btnArtikelPasAan.Name = "btnArtikelPasAan";
            this.btnArtikelPasAan.Size = new System.Drawing.Size(261, 34);
            this.btnArtikelPasAan.TabIndex = 47;
            this.btnArtikelPasAan.Text = "Pas aan";
            this.btnArtikelPasAan.UseVisualStyleBackColor = true;
            this.btnArtikelPasAan.Click += new System.EventHandler(this.btnArtikelPasAan_Click);
            // 
            // tbChangeCount
            // 
            this.tbChangeCount.Location = new System.Drawing.Point(4, 132);
            this.tbChangeCount.Margin = new System.Windows.Forms.Padding(2);
            this.tbChangeCount.Name = "tbChangeCount";
            this.tbChangeCount.Size = new System.Drawing.Size(254, 20);
            this.tbChangeCount.TabIndex = 51;
            // 
            // btnArtikelVerwijder
            // 
            this.btnArtikelVerwijder.Location = new System.Drawing.Point(7, 193);
            this.btnArtikelVerwijder.Margin = new System.Windows.Forms.Padding(2);
            this.btnArtikelVerwijder.Name = "btnArtikelVerwijder";
            this.btnArtikelVerwijder.Size = new System.Drawing.Size(261, 34);
            this.btnArtikelVerwijder.TabIndex = 48;
            this.btnArtikelVerwijder.Text = "Verwijder";
            this.btnArtikelVerwijder.UseVisualStyleBackColor = true;
            this.btnArtikelVerwijder.Click += new System.EventHandler(this.btnArtikelVerwijder_Click);
            // 
            // tbChangePrice
            // 
            this.tbChangePrice.Location = new System.Drawing.Point(4, 58);
            this.tbChangePrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbChangePrice.Name = "tbChangePrice";
            this.tbChangePrice.Size = new System.Drawing.Size(254, 20);
            this.tbChangePrice.TabIndex = 43;
            // 
            // tbChangeType
            // 
            this.tbChangeType.Location = new System.Drawing.Point(4, 95);
            this.tbChangeType.Margin = new System.Windows.Forms.Padding(2);
            this.tbChangeType.Name = "tbChangeType";
            this.tbChangeType.Size = new System.Drawing.Size(254, 20);
            this.tbChangeType.TabIndex = 49;
            // 
            // tbChangeName
            // 
            this.tbChangeName.Location = new System.Drawing.Point(4, 22);
            this.tbChangeName.Margin = new System.Windows.Forms.Padding(2);
            this.tbChangeName.Name = "tbChangeName";
            this.tbChangeName.Size = new System.Drawing.Size(254, 20);
            this.tbChangeName.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Vul hier de prijs in:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Vul hier het type in:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 6);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "ItemID:";
            // 
            // btnTakeRental
            // 
            this.btnTakeRental.Location = new System.Drawing.Point(4, 117);
            this.btnTakeRental.Margin = new System.Windows.Forms.Padding(2);
            this.btnTakeRental.Name = "btnTakeRental";
            this.btnTakeRental.Size = new System.Drawing.Size(267, 34);
            this.btnTakeRental.TabIndex = 73;
            this.btnTakeRental.Text = "Neem in";
            this.btnTakeRental.UseVisualStyleBackColor = true;
            this.btnTakeRental.Click += new System.EventHandler(this.btnTakeRental_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.tbAddStock);
            this.tabPage1.Controls.Add(this.tbAddPrice);
            this.tabPage1.Controls.Add(this.btnArtikelVoegToe);
            this.tabPage1.Controls.Add(this.tbAddType);
            this.tabPage1.Controls.Add(this.tbAddName);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(275, 230);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Artikel toevoegen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Vul hier het aantal in:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 6);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Artikel naam:";
            // 
            // tbAddStock
            // 
            this.tbAddStock.Location = new System.Drawing.Point(4, 132);
            this.tbAddStock.Margin = new System.Windows.Forms.Padding(2);
            this.tbAddStock.Name = "tbAddStock";
            this.tbAddStock.Size = new System.Drawing.Size(254, 20);
            this.tbAddStock.TabIndex = 51;
            // 
            // tbAddPrice
            // 
            this.tbAddPrice.Location = new System.Drawing.Point(4, 58);
            this.tbAddPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbAddPrice.Name = "tbAddPrice";
            this.tbAddPrice.Size = new System.Drawing.Size(254, 20);
            this.tbAddPrice.TabIndex = 43;
            // 
            // btnArtikelVoegToe
            // 
            this.btnArtikelVoegToe.Location = new System.Drawing.Point(7, 194);
            this.btnArtikelVoegToe.Margin = new System.Windows.Forms.Padding(2);
            this.btnArtikelVoegToe.Name = "btnArtikelVoegToe";
            this.btnArtikelVoegToe.Size = new System.Drawing.Size(261, 33);
            this.btnArtikelVoegToe.TabIndex = 52;
            this.btnArtikelVoegToe.Text = "Voeg toe";
            this.btnArtikelVoegToe.UseVisualStyleBackColor = true;
            this.btnArtikelVoegToe.Click += new System.EventHandler(this.btnArtikelVoegToe_Click);
            // 
            // tbAddType
            // 
            this.tbAddType.Location = new System.Drawing.Point(4, 95);
            this.tbAddType.Margin = new System.Windows.Forms.Padding(2);
            this.tbAddType.Name = "tbAddType";
            this.tbAddType.Size = new System.Drawing.Size(254, 20);
            this.tbAddType.TabIndex = 49;
            // 
            // tbAddName
            // 
            this.tbAddName.Location = new System.Drawing.Point(4, 22);
            this.tbAddName.Margin = new System.Windows.Forms.Padding(2);
            this.tbAddName.Name = "tbAddName";
            this.tbAddName.Size = new System.Drawing.Size(254, 20);
            this.tbAddName.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 42);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Vul hier de prijs in:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Vul hier het type in:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.dtpRentItemEndDate);
            this.tabPage3.Controls.Add(this.btnItemRentSearchPerson);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btnRentItem);
            this.tabPage3.Controls.Add(this.tbRentCount);
            this.tabPage3.Controls.Add(this.tbRentItemRFID);
            this.tabPage3.Controls.Add(this.tbRentItemID);
            this.tabPage3.Controls.Add(this.tbRentPersonName);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(275, 230);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Leen uit";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(45, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 13);
            this.label17.TabIndex = 68;
            this.label17.Text = "Eind datum verhuring:";
            // 
            // dtpRentItemEndDate
            // 
            this.dtpRentItemEndDate.Location = new System.Drawing.Point(48, 105);
            this.dtpRentItemEndDate.Name = "dtpRentItemEndDate";
            this.dtpRentItemEndDate.Size = new System.Drawing.Size(174, 20);
            this.dtpRentItemEndDate.TabIndex = 67;
            // 
            // btnItemRentSearchPerson
            // 
            this.btnItemRentSearchPerson.Location = new System.Drawing.Point(76, 186);
            this.btnItemRentSearchPerson.Name = "btnItemRentSearchPerson";
            this.btnItemRentSearchPerson.Size = new System.Drawing.Size(126, 39);
            this.btnItemRentSearchPerson.TabIndex = 66;
            this.btnItemRentSearchPerson.Text = "Zoek Persoon";
            this.btnItemRentSearchPerson.UseVisualStyleBackColor = true;
            this.btnItemRentSearchPerson.Click += new System.EventHandler(this.btnItemRentSearchPerson_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbInfo);
            this.groupBox1.Location = new System.Drawing.Point(296, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(392, 257);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gevonden gegevens";
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.Location = new System.Drawing.Point(5, 18);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(378, 238);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.SelectedIndexChanged += new System.EventHandler(this.lbInfo_SelectedIndexChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Location = new System.Drawing.Point(9, 9);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(283, 256);
            this.tabControl.TabIndex = 12;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnTakeRental);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(275, 230);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Neem in";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnSearchSelect);
            this.tabPage5.Controls.Add(this.btnSearchPerson);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.tbSearchPerson);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(275, 230);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Zoek persoon";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnSearchSelect
            // 
            this.btnSearchSelect.Location = new System.Drawing.Point(6, 144);
            this.btnSearchSelect.Name = "btnSearchSelect";
            this.btnSearchSelect.Size = new System.Drawing.Size(249, 47);
            this.btnSearchSelect.TabIndex = 5;
            this.btnSearchSelect.Text = "Selecteer persoon";
            this.btnSearchSelect.UseVisualStyleBackColor = true;
            this.btnSearchSelect.Click += new System.EventHandler(this.btnSearchSelect_Click);
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.Location = new System.Drawing.Point(6, 91);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(249, 47);
            this.btnSearchPerson.TabIndex = 4;
            this.btnSearchPerson.Text = "Zoek persoon";
            this.btnSearchPerson.UseVisualStyleBackColor = true;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Persoon naam:";
            // 
            // tbSearchPerson
            // 
            this.tbSearchPerson.Location = new System.Drawing.Point(6, 51);
            this.tbSearchPerson.Name = "tbSearchPerson";
            this.tbSearchPerson.Size = new System.Drawing.Size(249, 20);
            this.tbSearchPerson.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 277);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Material Rental System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRentItem;
        private System.Windows.Forms.TextBox tbRentCount;
        private System.Windows.Forms.TextBox tbRentItemRFID;
        private System.Windows.Forms.TextBox tbRentItemID;
        private System.Windows.Forms.TextBox tbRentPersonName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnArtikelPasAan;
        private System.Windows.Forms.TextBox tbChangeCount;
        private System.Windows.Forms.Button btnArtikelVerwijder;
        private System.Windows.Forms.TextBox tbChangePrice;
        private System.Windows.Forms.TextBox tbChangeType;
        private System.Windows.Forms.TextBox tbChangeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTakeRental;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbAddStock;
        private System.Windows.Forms.TextBox tbAddPrice;
        private System.Windows.Forms.Button btnArtikelVoegToe;
        private System.Windows.Forms.TextBox tbAddType;
        private System.Windows.Forms.TextBox tbAddName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnItemRentSearchPerson;
        private System.Windows.Forms.DateTimePicker dtpRentItemEndDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbSearchPerson;
        private System.Windows.Forms.Button btnSearchSelect;
        private System.Windows.Forms.Button btnSearchPerson;
    }
}

