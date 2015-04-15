namespace SocialMediaSharingSystem
{
    partial class UploadForm
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Upload2 = new System.Windows.Forms.Button();
            this.tb_Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_FilePath = new System.Windows.Forms.TextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(12, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(30, 13);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Titel:";
            // 
            // btn_Upload2
            // 
            this.btn_Upload2.Location = new System.Drawing.Point(15, 103);
            this.btn_Upload2.Name = "btn_Upload2";
            this.btn_Upload2.Size = new System.Drawing.Size(75, 23);
            this.btn_Upload2.TabIndex = 1;
            this.btn_Upload2.Text = "Upload";
            this.btn_Upload2.UseVisualStyleBackColor = true;
            this.btn_Upload2.Click += new System.EventHandler(this.btn_Upload2_Click);
            // 
            // tb_Title
            // 
            this.tb_Title.Location = new System.Drawing.Point(12, 25);
            this.tb_Title.Name = "tb_Title";
            this.tb_Title.Size = new System.Drawing.Size(179, 20);
            this.tb_Title.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bestandspad:";
            // 
            // tb_FilePath
            // 
            this.tb_FilePath.Location = new System.Drawing.Point(12, 64);
            this.tb_FilePath.Name = "tb_FilePath";
            this.tb_FilePath.Size = new System.Drawing.Size(179, 20);
            this.tb_FilePath.TabIndex = 4;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(197, 64);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse.TabIndex = 5;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // UploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 135);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.tb_FilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Title);
            this.Controls.Add(this.btn_Upload2);
            this.Controls.Add(this.lbl_Title);
            this.Name = "UploadForm";
            this.Text = "Upload een bestand.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Upload2;
        private System.Windows.Forms.TextBox tb_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_FilePath;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}