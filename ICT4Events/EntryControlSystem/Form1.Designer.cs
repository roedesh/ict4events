namespace EntryControlSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnZoekPersoon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pbBetaalstatus = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPersoonToelaten = new System.Windows.Forms.Button();
            this.tbRFID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnToonAanwezigen = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBetaalstatus)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.Location = new System.Drawing.Point(6, 19);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(406, 160);
            this.lbInfo.TabIndex = 4;
            this.lbInfo.SelectedIndexChanged += new System.EventHandler(this.lbInfo_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnZoekPersoon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pbBetaalstatus);
            this.groupBox1.Controls.Add(this.tbSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPersoonToelaten);
            this.groupBox1.Controls.Add(this.tbRFID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnToonAanwezigen);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 182);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toegangs Controle";
            // 
            // btnZoekPersoon
            // 
            this.btnZoekPersoon.Location = new System.Drawing.Point(186, 57);
            this.btnZoekPersoon.Name = "btnZoekPersoon";
            this.btnZoekPersoon.Size = new System.Drawing.Size(100, 24);
            this.btnZoekPersoon.TabIndex = 10;
            this.btnZoekPersoon.Text = "ZoekPersoon";
            this.btnZoekPersoon.UseVisualStyleBackColor = true;
            this.btnZoekPersoon.Click += new System.EventHandler(this.btnZoekPersoon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Naam/id";
            // 
            // pbBetaalstatus
            // 
            this.pbBetaalstatus.BackColor = System.Drawing.Color.Lime;
            this.pbBetaalstatus.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbBetaalstatus.InitialImage")));
            this.pbBetaalstatus.Location = new System.Drawing.Point(113, 113);
            this.pbBetaalstatus.Name = "pbBetaalstatus";
            this.pbBetaalstatus.Size = new System.Drawing.Size(173, 63);
            this.pbBetaalstatus.TabIndex = 2;
            this.pbBetaalstatus.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(186, 31);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 20);
            this.tbSearch.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "BetaalStatus";
            // 
            // btnPersoonToelaten
            // 
            this.btnPersoonToelaten.Location = new System.Drawing.Point(186, 84);
            this.btnPersoonToelaten.Name = "btnPersoonToelaten";
            this.btnPersoonToelaten.Size = new System.Drawing.Size(100, 26);
            this.btnPersoonToelaten.TabIndex = 6;
            this.btnPersoonToelaten.Text = "Persoon toelaten";
            this.btnPersoonToelaten.UseVisualStyleBackColor = true;
            this.btnPersoonToelaten.Click += new System.EventHandler(this.btnPersoonToelaten_Click);
            // 
            // tbRFID
            // 
            this.tbRFID.Location = new System.Drawing.Point(27, 46);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.ReadOnly = true;
            this.tbRFID.Size = new System.Drawing.Size(100, 20);
            this.tbRFID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RFID Tag:";
            // 
            // btnToonAanwezigen
            // 
            this.btnToonAanwezigen.Location = new System.Drawing.Point(4, 116);
            this.btnToonAanwezigen.Name = "btnToonAanwezigen";
            this.btnToonAanwezigen.Size = new System.Drawing.Size(103, 56);
            this.btnToonAanwezigen.TabIndex = 0;
            this.btnToonAanwezigen.Text = "Toon alle aanwezigen";
            this.btnToonAanwezigen.UseVisualStyleBackColor = true;
            this.btnToonAanwezigen.Click += new System.EventHandler(this.btnToonAanwezigen_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(418, 133);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(69, 43);
            this.btnClearFields.TabIndex = 1;
            this.btnClearFields.Text = "Clear gegevens";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbInfo);
            this.groupBox2.Controls.Add(this.btnClearFields);
            this.groupBox2.Location = new System.Drawing.Point(310, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 182);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gevonden Informatie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 219);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Entry Control System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBetaalstatus)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPersoonToelaten;
        private System.Windows.Forms.TextBox tbRFID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbBetaalstatus;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnToonAanwezigen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnZoekPersoon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSearch;

    }
}

