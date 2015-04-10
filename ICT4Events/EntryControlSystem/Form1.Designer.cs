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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnToonAanwezigen = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.pbBetaalstatus = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPersoonToelaten = new System.Windows.Forms.Button();
            this.btnZoekPersoon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBetaalstatus)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(406, 160);
            this.listBox1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnZoekPersoon);
            this.groupBox1.Controls.Add(this.btnPersoonToelaten);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbBetaalstatus);
            this.groupBox1.Controls.Add(this.btnClearFields);
            this.groupBox1.Controls.Add(this.btnToonAanwezigen);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 182);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toegangs Controle";
            // 
            // btnToonAanwezigen
            // 
            this.btnToonAanwezigen.Location = new System.Drawing.Point(7, 60);
            this.btnToonAanwezigen.Name = "btnToonAanwezigen";
            this.btnToonAanwezigen.Size = new System.Drawing.Size(103, 53);
            this.btnToonAanwezigen.TabIndex = 0;
            this.btnToonAanwezigen.Text = "Toon alle aanwezigen";
            this.btnToonAanwezigen.UseVisualStyleBackColor = true;
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(203, 119);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(74, 53);
            this.btnClearFields.TabIndex = 1;
            this.btnClearFields.Text = "Clear gegevens";
            this.btnClearFields.UseVisualStyleBackColor = true;
            // 
            // pbBetaalstatus
            // 
            this.pbBetaalstatus.Location = new System.Drawing.Point(121, 31);
            this.pbBetaalstatus.Name = "pbBetaalstatus";
            this.pbBetaalstatus.Size = new System.Drawing.Size(156, 82);
            this.pbBetaalstatus.TabIndex = 2;
            this.pbBetaalstatus.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "BetaalStatus";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(310, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 182);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gevonden Informatie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RFID Tag:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btnPersoonToelaten
            // 
            this.btnPersoonToelaten.Location = new System.Drawing.Point(121, 119);
            this.btnPersoonToelaten.Name = "btnPersoonToelaten";
            this.btnPersoonToelaten.Size = new System.Drawing.Size(74, 53);
            this.btnPersoonToelaten.TabIndex = 6;
            this.btnPersoonToelaten.Text = "Persoon toelaten";
            this.btnPersoonToelaten.UseVisualStyleBackColor = true;
            // 
            // btnZoekPersoon
            // 
            this.btnZoekPersoon.Location = new System.Drawing.Point(8, 119);
            this.btnZoekPersoon.Name = "btnZoekPersoon";
            this.btnZoekPersoon.Size = new System.Drawing.Size(103, 53);
            this.btnZoekPersoon.TabIndex = 7;
            this.btnZoekPersoon.Text = "Zoek persoon";
            this.btnZoekPersoon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 219);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Entry Control System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBetaalstatus)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnZoekPersoon;
        private System.Windows.Forms.Button btnPersoonToelaten;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbBetaalstatus;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnToonAanwezigen;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}

