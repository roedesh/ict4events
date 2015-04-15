namespace SocialMediaSharingSystem
{
    partial class frm_SocialMedia
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
            this.components = new System.ComponentModel.Container();
            this.tv_Directories = new System.Windows.Forms.TreeView();
            this.cms_FileViewer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uploadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_MediaBrowser = new System.Windows.Forms.GroupBox();
            this.gb_MediaInfo = new System.Windows.Forms.GroupBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Download = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Like = new System.Windows.Forms.Button();
            this.btn_Flag = new System.Windows.Forms.Button();
            this.lbl_Comments = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cms_FileViewer.SuspendLayout();
            this.gb_MediaBrowser.SuspendLayout();
            this.gb_MediaInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv_Directories
            // 
            this.tv_Directories.Location = new System.Drawing.Point(6, 48);
            this.tv_Directories.Name = "tv_Directories";
            this.tv_Directories.Size = new System.Drawing.Size(312, 366);
            this.tv_Directories.TabIndex = 2;
            this.tv_Directories.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_Directories_NodeMouseClick);
            this.tv_Directories.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_Directories_NodeMouseDoubleClick);
            // 
            // cms_FileViewer
            // 
            this.cms_FileViewer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadFileToolStripMenuItem,
            this.addCatToolStripMenuItem});
            this.cms_FileViewer.Name = "cms_FileViewer";
            this.cms_FileViewer.Size = new System.Drawing.Size(174, 48);
            // 
            // uploadFileToolStripMenuItem
            // 
            this.uploadFileToolStripMenuItem.Name = "uploadFileToolStripMenuItem";
            this.uploadFileToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.uploadFileToolStripMenuItem.Text = "Voeg bestand toe";
            this.uploadFileToolStripMenuItem.Click += new System.EventHandler(this.uploadFileToolStripMenuItem_Click);
            // 
            // addCatToolStripMenuItem
            // 
            this.addCatToolStripMenuItem.Name = "addCatToolStripMenuItem";
            this.addCatToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addCatToolStripMenuItem.Text = "Voeg categorie toe";
            this.addCatToolStripMenuItem.Click += new System.EventHandler(this.addCatToolStripMenuItem_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(6, 19);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // gb_MediaBrowser
            // 
            this.gb_MediaBrowser.Controls.Add(this.tv_Directories);
            this.gb_MediaBrowser.Controls.Add(this.btn_Refresh);
            this.gb_MediaBrowser.Location = new System.Drawing.Point(12, 12);
            this.gb_MediaBrowser.Name = "gb_MediaBrowser";
            this.gb_MediaBrowser.Size = new System.Drawing.Size(324, 420);
            this.gb_MediaBrowser.TabIndex = 4;
            this.gb_MediaBrowser.TabStop = false;
            this.gb_MediaBrowser.Text = "Media browser";
            // 
            // gb_MediaInfo
            // 
            this.gb_MediaInfo.Controls.Add(this.listBox1);
            this.gb_MediaInfo.Controls.Add(this.lbl_Comments);
            this.gb_MediaInfo.Controls.Add(this.btn_Flag);
            this.gb_MediaInfo.Controls.Add(this.btn_Like);
            this.gb_MediaInfo.Controls.Add(this.label1);
            this.gb_MediaInfo.Controls.Add(this.btn_Download);
            this.gb_MediaInfo.Controls.Add(this.lbl_Title);
            this.gb_MediaInfo.Location = new System.Drawing.Point(342, 12);
            this.gb_MediaInfo.Name = "gb_MediaInfo";
            this.gb_MediaInfo.Size = new System.Drawing.Size(491, 420);
            this.gb_MediaInfo.TabIndex = 5;
            this.gb_MediaInfo.TabStop = false;
            this.gb_MediaInfo.Text = "Media Info";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(7, 20);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(30, 13);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Titel:";
            // 
            // btn_Download
            // 
            this.btn_Download.Enabled = false;
            this.btn_Download.Location = new System.Drawing.Point(10, 143);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(75, 23);
            this.btn_Download.TabIndex = 1;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Uploader: ";
            // 
            // btn_Like
            // 
            this.btn_Like.Location = new System.Drawing.Point(264, 143);
            this.btn_Like.Name = "btn_Like";
            this.btn_Like.Size = new System.Drawing.Size(42, 23);
            this.btn_Like.TabIndex = 3;
            this.btn_Like.Text = "Like";
            this.btn_Like.UseVisualStyleBackColor = true;
            // 
            // btn_Flag
            // 
            this.btn_Flag.Location = new System.Drawing.Point(312, 143);
            this.btn_Flag.Name = "btn_Flag";
            this.btn_Flag.Size = new System.Drawing.Size(42, 23);
            this.btn_Flag.TabIndex = 4;
            this.btn_Flag.Text = "Flag";
            this.btn_Flag.UseVisualStyleBackColor = true;
            // 
            // lbl_Comments
            // 
            this.lbl_Comments.AutoSize = true;
            this.lbl_Comments.Location = new System.Drawing.Point(13, 199);
            this.lbl_Comments.Name = "lbl_Comments";
            this.lbl_Comments.Size = new System.Drawing.Size(52, 13);
            this.lbl_Comments.TabIndex = 5;
            this.lbl_Comments.Text = "Reacties:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 216);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(472, 199);
            this.listBox1.TabIndex = 6;
            // 
            // frm_SocialMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 444);
            this.Controls.Add(this.gb_MediaInfo);
            this.Controls.Add(this.gb_MediaBrowser);
            this.Name = "frm_SocialMedia";
            this.Text = "Social Media Sharing";
            this.cms_FileViewer.ResumeLayout(false);
            this.gb_MediaBrowser.ResumeLayout(false);
            this.gb_MediaInfo.ResumeLayout(false);
            this.gb_MediaInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv_Directories;
        private System.Windows.Forms.ContextMenuStrip cms_FileViewer;
        private System.Windows.Forms.ToolStripMenuItem uploadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCatToolStripMenuItem;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.GroupBox gb_MediaBrowser;
        private System.Windows.Forms.GroupBox gb_MediaInfo;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_Comments;
        private System.Windows.Forms.Button btn_Flag;
        private System.Windows.Forms.Button btn_Like;

    }
}

