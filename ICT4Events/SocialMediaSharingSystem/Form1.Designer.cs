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
            this.tv_Directories = new System.Windows.Forms.TreeView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_MediaBrowser = new System.Windows.Forms.GroupBox();
            this.btn_AddFile = new System.Windows.Forms.Button();
            this.btn_AddCategory = new System.Windows.Forms.Button();
            this.gb_MediaInfo = new System.Windows.Forms.GroupBox();
            this.lbl_FileFlags = new System.Windows.Forms.Label();
            this.btn_RemoveFile = new System.Windows.Forms.Button();
            this.lbl_Preview = new System.Windows.Forms.Label();
            this.pb_Preview = new System.Windows.Forms.PictureBox();
            this.lbl_Likes = new System.Windows.Forms.Label();
            this.lbl_UploadDate = new System.Windows.Forms.Label();
            this.btn_FileFlag = new System.Windows.Forms.Button();
            this.btn_FileLike = new System.Windows.Forms.Button();
            this.lbl_Uploader = new System.Windows.Forms.Label();
            this.btn_Download = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lb_Comments = new System.Windows.Forms.ListBox();
            this.gb_Comments = new System.Windows.Forms.GroupBox();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.lbl_Sorting = new System.Windows.Forms.Label();
            this.cb_SortingMethod = new System.Windows.Forms.ComboBox();
            this.lbl_CommentFlags = new System.Windows.Forms.Label();
            this.btn_RemoveComment = new System.Windows.Forms.Button();
            this.lbl_CommentLikes = new System.Windows.Forms.Label();
            this.btn_CommentFlag = new System.Windows.Forms.Button();
            this.btn_CommentLike = new System.Windows.Forms.Button();
            this.tb_CommentOutput = new System.Windows.Forms.TextBox();
            this.lbl_CurrentAccount = new System.Windows.Forms.Label();
            this.chk_WithComment = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Title = new System.Windows.Forms.TextBox();
            this.tb_Comment = new System.Windows.Forms.TextBox();
            this.btn_PlaceComment = new System.Windows.Forms.Button();
            this.gb_NewComment = new System.Windows.Forms.GroupBox();
            this.gb_MediaBrowser.SuspendLayout();
            this.gb_MediaInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Preview)).BeginInit();
            this.gb_Comments.SuspendLayout();
            this.gb_NewComment.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv_Directories
            // 
            this.tv_Directories.Location = new System.Drawing.Point(6, 48);
            this.tv_Directories.Name = "tv_Directories";
            this.tv_Directories.Size = new System.Drawing.Size(312, 381);
            this.tv_Directories.TabIndex = 2;
            this.tv_Directories.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_Directories_NodeMouseDoubleClick);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(257, 19);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(61, 23);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // gb_MediaBrowser
            // 
            this.gb_MediaBrowser.Controls.Add(this.btn_AddFile);
            this.gb_MediaBrowser.Controls.Add(this.btn_AddCategory);
            this.gb_MediaBrowser.Controls.Add(this.tv_Directories);
            this.gb_MediaBrowser.Controls.Add(this.btn_Refresh);
            this.gb_MediaBrowser.Location = new System.Drawing.Point(12, 41);
            this.gb_MediaBrowser.Name = "gb_MediaBrowser";
            this.gb_MediaBrowser.Size = new System.Drawing.Size(324, 435);
            this.gb_MediaBrowser.TabIndex = 4;
            this.gb_MediaBrowser.TabStop = false;
            this.gb_MediaBrowser.Text = "Media browser";
            // 
            // btn_AddFile
            // 
            this.btn_AddFile.Location = new System.Drawing.Point(6, 19);
            this.btn_AddFile.Name = "btn_AddFile";
            this.btn_AddFile.Size = new System.Drawing.Size(113, 23);
            this.btn_AddFile.TabIndex = 5;
            this.btn_AddFile.Text = "Voeg bestand toe";
            this.btn_AddFile.UseVisualStyleBackColor = true;
            this.btn_AddFile.Click += new System.EventHandler(this.btn_AddFile_Click);
            // 
            // btn_AddCategory
            // 
            this.btn_AddCategory.Location = new System.Drawing.Point(125, 19);
            this.btn_AddCategory.Name = "btn_AddCategory";
            this.btn_AddCategory.Size = new System.Drawing.Size(111, 23);
            this.btn_AddCategory.TabIndex = 4;
            this.btn_AddCategory.Text = "Voeg categorie toe";
            this.btn_AddCategory.UseVisualStyleBackColor = true;
            this.btn_AddCategory.Click += new System.EventHandler(this.btn_AddCategory_Click);
            // 
            // gb_MediaInfo
            // 
            this.gb_MediaInfo.Controls.Add(this.lbl_FileFlags);
            this.gb_MediaInfo.Controls.Add(this.btn_RemoveFile);
            this.gb_MediaInfo.Controls.Add(this.lbl_Preview);
            this.gb_MediaInfo.Controls.Add(this.pb_Preview);
            this.gb_MediaInfo.Controls.Add(this.lbl_Likes);
            this.gb_MediaInfo.Controls.Add(this.lbl_UploadDate);
            this.gb_MediaInfo.Controls.Add(this.btn_FileFlag);
            this.gb_MediaInfo.Controls.Add(this.btn_FileLike);
            this.gb_MediaInfo.Controls.Add(this.lbl_Uploader);
            this.gb_MediaInfo.Controls.Add(this.btn_Download);
            this.gb_MediaInfo.Controls.Add(this.lbl_Title);
            this.gb_MediaInfo.Enabled = false;
            this.gb_MediaInfo.Location = new System.Drawing.Point(336, 12);
            this.gb_MediaInfo.Name = "gb_MediaInfo";
            this.gb_MediaInfo.Size = new System.Drawing.Size(491, 464);
            this.gb_MediaInfo.TabIndex = 5;
            this.gb_MediaInfo.TabStop = false;
            this.gb_MediaInfo.Text = "Media Info";
            // 
            // lbl_FileFlags
            // 
            this.lbl_FileFlags.AutoSize = true;
            this.lbl_FileFlags.Location = new System.Drawing.Point(23, 77);
            this.lbl_FileFlags.Name = "lbl_FileFlags";
            this.lbl_FileFlags.Size = new System.Drawing.Size(65, 13);
            this.lbl_FileFlags.TabIndex = 12;
            this.lbl_FileFlags.Text = "Aantal flags:";
            this.lbl_FileFlags.Visible = false;
            // 
            // btn_RemoveFile
            // 
            this.btn_RemoveFile.Location = new System.Drawing.Point(282, 435);
            this.btn_RemoveFile.Name = "btn_RemoveFile";
            this.btn_RemoveFile.Size = new System.Drawing.Size(107, 23);
            this.btn_RemoveFile.TabIndex = 11;
            this.btn_RemoveFile.Text = "Verwijder bestand";
            this.btn_RemoveFile.UseVisualStyleBackColor = true;
            this.btn_RemoveFile.Visible = false;
            this.btn_RemoveFile.Click += new System.EventHandler(this.btn_RemoveFile_Click);
            // 
            // lbl_Preview
            // 
            this.lbl_Preview.AutoSize = true;
            this.lbl_Preview.Location = new System.Drawing.Point(24, 99);
            this.lbl_Preview.Name = "lbl_Preview";
            this.lbl_Preview.Size = new System.Drawing.Size(58, 13);
            this.lbl_Preview.TabIndex = 10;
            this.lbl_Preview.Text = "Voorbeeld:";
            // 
            // pb_Preview
            // 
            this.pb_Preview.Location = new System.Drawing.Point(111, 99);
            this.pb_Preview.Name = "pb_Preview";
            this.pb_Preview.Size = new System.Drawing.Size(374, 330);
            this.pb_Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Preview.TabIndex = 9;
            this.pb_Preview.TabStop = false;
            // 
            // lbl_Likes
            // 
            this.lbl_Likes.AutoSize = true;
            this.lbl_Likes.Location = new System.Drawing.Point(24, 63);
            this.lbl_Likes.Name = "lbl_Likes";
            this.lbl_Likes.Size = new System.Drawing.Size(64, 13);
            this.lbl_Likes.TabIndex = 8;
            this.lbl_Likes.Text = "Aantal likes:";
            // 
            // lbl_UploadDate
            // 
            this.lbl_UploadDate.AutoSize = true;
            this.lbl_UploadDate.Location = new System.Drawing.Point(192, 63);
            this.lbl_UploadDate.Name = "lbl_UploadDate";
            this.lbl_UploadDate.Size = new System.Drawing.Size(73, 13);
            this.lbl_UploadDate.TabIndex = 7;
            this.lbl_UploadDate.Text = "Uploaddatum:";
            // 
            // btn_FileFlag
            // 
            this.btn_FileFlag.Location = new System.Drawing.Point(443, 435);
            this.btn_FileFlag.Name = "btn_FileFlag";
            this.btn_FileFlag.Size = new System.Drawing.Size(42, 23);
            this.btn_FileFlag.TabIndex = 4;
            this.btn_FileFlag.Text = "Flag";
            this.btn_FileFlag.UseVisualStyleBackColor = true;
            this.btn_FileFlag.Click += new System.EventHandler(this.btn_FileFlag_Click);
            // 
            // btn_FileLike
            // 
            this.btn_FileLike.Location = new System.Drawing.Point(395, 435);
            this.btn_FileLike.Name = "btn_FileLike";
            this.btn_FileLike.Size = new System.Drawing.Size(42, 23);
            this.btn_FileLike.TabIndex = 3;
            this.btn_FileLike.Text = "Like";
            this.btn_FileLike.UseVisualStyleBackColor = true;
            this.btn_FileLike.Click += new System.EventHandler(this.btn_FileLike_Click);
            // 
            // lbl_Uploader
            // 
            this.lbl_Uploader.AutoSize = true;
            this.lbl_Uploader.Location = new System.Drawing.Point(192, 29);
            this.lbl_Uploader.Name = "lbl_Uploader";
            this.lbl_Uploader.Size = new System.Drawing.Size(56, 13);
            this.lbl_Uploader.TabIndex = 2;
            this.lbl_Uploader.Text = "Uploader: ";
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(6, 435);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(118, 23);
            this.btn_Download.TabIndex = 1;
            this.btn_Download.Text = "Download bestand";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(24, 29);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(30, 13);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Titel:";
            // 
            // lb_Comments
            // 
            this.lb_Comments.FormattingEnabled = true;
            this.lb_Comments.HorizontalScrollbar = true;
            this.lb_Comments.Location = new System.Drawing.Point(6, 23);
            this.lb_Comments.Name = "lb_Comments";
            this.lb_Comments.Size = new System.Drawing.Size(280, 199);
            this.lb_Comments.TabIndex = 6;
            this.lb_Comments.SelectedIndexChanged += new System.EventHandler(this.lb_Comments_SelectedIndexChanged);
            // 
            // gb_Comments
            // 
            this.gb_Comments.Controls.Add(this.btn_Sort);
            this.gb_Comments.Controls.Add(this.lbl_Sorting);
            this.gb_Comments.Controls.Add(this.cb_SortingMethod);
            this.gb_Comments.Controls.Add(this.lbl_CommentFlags);
            this.gb_Comments.Controls.Add(this.btn_RemoveComment);
            this.gb_Comments.Controls.Add(this.lbl_CommentLikes);
            this.gb_Comments.Controls.Add(this.btn_CommentFlag);
            this.gb_Comments.Controls.Add(this.btn_CommentLike);
            this.gb_Comments.Controls.Add(this.tb_CommentOutput);
            this.gb_Comments.Controls.Add(this.lb_Comments);
            this.gb_Comments.Enabled = false;
            this.gb_Comments.Location = new System.Drawing.Point(840, 12);
            this.gb_Comments.Name = "gb_Comments";
            this.gb_Comments.Size = new System.Drawing.Size(292, 464);
            this.gb_Comments.TabIndex = 6;
            this.gb_Comments.TabStop = false;
            this.gb_Comments.Text = "Reactieoverzicht";
            // 
            // btn_Sort
            // 
            this.btn_Sort.Location = new System.Drawing.Point(228, 234);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(57, 23);
            this.btn_Sort.TabIndex = 18;
            this.btn_Sort.Text = "Sorteer";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // lbl_Sorting
            // 
            this.lbl_Sorting.AutoSize = true;
            this.lbl_Sorting.Location = new System.Drawing.Point(12, 239);
            this.lbl_Sorting.Name = "lbl_Sorting";
            this.lbl_Sorting.Size = new System.Drawing.Size(59, 13);
            this.lbl_Sorting.TabIndex = 17;
            this.lbl_Sorting.Text = "Sorteer op:";
            // 
            // cb_SortingMethod
            // 
            this.cb_SortingMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SortingMethod.FormattingEnabled = true;
            this.cb_SortingMethod.Items.AddRange(new object[] {
            "Datum",
            "Titel",
            "Aantal likes"});
            this.cb_SortingMethod.Location = new System.Drawing.Point(77, 236);
            this.cb_SortingMethod.Name = "cb_SortingMethod";
            this.cb_SortingMethod.Size = new System.Drawing.Size(101, 21);
            this.cb_SortingMethod.TabIndex = 16;
            // 
            // lbl_CommentFlags
            // 
            this.lbl_CommentFlags.AutoSize = true;
            this.lbl_CommentFlags.Location = new System.Drawing.Point(6, 440);
            this.lbl_CommentFlags.Name = "lbl_CommentFlags";
            this.lbl_CommentFlags.Size = new System.Drawing.Size(65, 13);
            this.lbl_CommentFlags.TabIndex = 13;
            this.lbl_CommentFlags.Text = "Aantal flags:";
            this.lbl_CommentFlags.Visible = false;
            // 
            // btn_RemoveComment
            // 
            this.btn_RemoveComment.Location = new System.Drawing.Point(97, 435);
            this.btn_RemoveComment.Name = "btn_RemoveComment";
            this.btn_RemoveComment.Size = new System.Drawing.Size(93, 23);
            this.btn_RemoveComment.TabIndex = 12;
            this.btn_RemoveComment.Text = "Verwijder reactie";
            this.btn_RemoveComment.UseVisualStyleBackColor = true;
            this.btn_RemoveComment.Visible = false;
            this.btn_RemoveComment.Click += new System.EventHandler(this.btn_RemoveComment_Click);
            // 
            // lbl_CommentLikes
            // 
            this.lbl_CommentLikes.AutoSize = true;
            this.lbl_CommentLikes.Location = new System.Drawing.Point(7, 427);
            this.lbl_CommentLikes.Name = "lbl_CommentLikes";
            this.lbl_CommentLikes.Size = new System.Drawing.Size(64, 13);
            this.lbl_CommentLikes.TabIndex = 15;
            this.lbl_CommentLikes.Text = "Aantal likes:";
            // 
            // btn_CommentFlag
            // 
            this.btn_CommentFlag.Location = new System.Drawing.Point(244, 435);
            this.btn_CommentFlag.Name = "btn_CommentFlag";
            this.btn_CommentFlag.Size = new System.Drawing.Size(42, 23);
            this.btn_CommentFlag.TabIndex = 11;
            this.btn_CommentFlag.Text = "Flag";
            this.btn_CommentFlag.UseVisualStyleBackColor = true;
            this.btn_CommentFlag.Click += new System.EventHandler(this.btn_CommentFlag_Click);
            // 
            // btn_CommentLike
            // 
            this.btn_CommentLike.Location = new System.Drawing.Point(196, 435);
            this.btn_CommentLike.Name = "btn_CommentLike";
            this.btn_CommentLike.Size = new System.Drawing.Size(42, 23);
            this.btn_CommentLike.TabIndex = 14;
            this.btn_CommentLike.Text = "Like";
            this.btn_CommentLike.UseVisualStyleBackColor = true;
            this.btn_CommentLike.Click += new System.EventHandler(this.btn_CommentLike_Click);
            // 
            // tb_CommentOutput
            // 
            this.tb_CommentOutput.Location = new System.Drawing.Point(6, 275);
            this.tb_CommentOutput.Multiline = true;
            this.tb_CommentOutput.Name = "tb_CommentOutput";
            this.tb_CommentOutput.ReadOnly = true;
            this.tb_CommentOutput.Size = new System.Drawing.Size(279, 149);
            this.tb_CommentOutput.TabIndex = 12;
            // 
            // lbl_CurrentAccount
            // 
            this.lbl_CurrentAccount.AutoSize = true;
            this.lbl_CurrentAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentAccount.Location = new System.Drawing.Point(8, 9);
            this.lbl_CurrentAccount.Name = "lbl_CurrentAccount";
            this.lbl_CurrentAccount.Size = new System.Drawing.Size(103, 20);
            this.lbl_CurrentAccount.TabIndex = 7;
            this.lbl_CurrentAccount.Text = "Ingelogd als: ";
            // 
            // chk_WithComment
            // 
            this.chk_WithComment.AutoSize = true;
            this.chk_WithComment.Location = new System.Drawing.Point(134, 236);
            this.chk_WithComment.Name = "chk_WithComment";
            this.chk_WithComment.Size = new System.Drawing.Size(72, 17);
            this.chk_WithComment.TabIndex = 19;
            this.chk_WithComment.Text = "Bij reactie";
            this.chk_WithComment.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Bericht:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Titel:";
            // 
            // tb_Title
            // 
            this.tb_Title.Location = new System.Drawing.Point(53, 20);
            this.tb_Title.Name = "tb_Title";
            this.tb_Title.Size = new System.Drawing.Size(258, 20);
            this.tb_Title.TabIndex = 16;
            // 
            // tb_Comment
            // 
            this.tb_Comment.Location = new System.Drawing.Point(53, 47);
            this.tb_Comment.Multiline = true;
            this.tb_Comment.Name = "tb_Comment";
            this.tb_Comment.Size = new System.Drawing.Size(258, 179);
            this.tb_Comment.TabIndex = 14;
            // 
            // btn_PlaceComment
            // 
            this.btn_PlaceComment.Location = new System.Drawing.Point(53, 232);
            this.btn_PlaceComment.Name = "btn_PlaceComment";
            this.btn_PlaceComment.Size = new System.Drawing.Size(75, 23);
            this.btn_PlaceComment.TabIndex = 15;
            this.btn_PlaceComment.Text = "Plaats!";
            this.btn_PlaceComment.UseVisualStyleBackColor = true;
            this.btn_PlaceComment.Click += new System.EventHandler(this.btn_PlaceComment_Click);
            // 
            // gb_NewComment
            // 
            this.gb_NewComment.Controls.Add(this.label1);
            this.gb_NewComment.Controls.Add(this.chk_WithComment);
            this.gb_NewComment.Controls.Add(this.btn_PlaceComment);
            this.gb_NewComment.Controls.Add(this.label2);
            this.gb_NewComment.Controls.Add(this.tb_Comment);
            this.gb_NewComment.Controls.Add(this.tb_Title);
            this.gb_NewComment.Enabled = false;
            this.gb_NewComment.Location = new System.Drawing.Point(1138, 12);
            this.gb_NewComment.Name = "gb_NewComment";
            this.gb_NewComment.Size = new System.Drawing.Size(321, 464);
            this.gb_NewComment.TabIndex = 20;
            this.gb_NewComment.TabStop = false;
            this.gb_NewComment.Text = "Nieuwe reactie";
            // 
            // frm_SocialMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 482);
            this.Controls.Add(this.gb_NewComment);
            this.Controls.Add(this.lbl_CurrentAccount);
            this.Controls.Add(this.gb_Comments);
            this.Controls.Add(this.gb_MediaInfo);
            this.Controls.Add(this.gb_MediaBrowser);
            this.Name = "frm_SocialMedia";
            this.Text = "Social Media Sharing";
            this.Activated += new System.EventHandler(this.frm_SocialMedia_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_SocialMedia_FormClosed);
            this.gb_MediaBrowser.ResumeLayout(false);
            this.gb_MediaInfo.ResumeLayout(false);
            this.gb_MediaInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Preview)).EndInit();
            this.gb_Comments.ResumeLayout(false);
            this.gb_Comments.PerformLayout();
            this.gb_NewComment.ResumeLayout(false);
            this.gb_NewComment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv_Directories;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.GroupBox gb_MediaBrowser;
        private System.Windows.Forms.GroupBox gb_MediaInfo;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.Label lbl_Uploader;
        private System.Windows.Forms.ListBox lb_Comments;
        private System.Windows.Forms.Button btn_FileFlag;
        private System.Windows.Forms.Button btn_FileLike;
        private System.Windows.Forms.Label lbl_Likes;
        private System.Windows.Forms.Label lbl_UploadDate;
        private System.Windows.Forms.GroupBox gb_Comments;
        private System.Windows.Forms.PictureBox pb_Preview;
        private System.Windows.Forms.Label lbl_CurrentAccount;
        private System.Windows.Forms.Button btn_AddFile;
        private System.Windows.Forms.Button btn_AddCategory;
        private System.Windows.Forms.Label lbl_Preview;
        private System.Windows.Forms.TextBox tb_CommentOutput;
        private System.Windows.Forms.Button btn_CommentLike;
        private System.Windows.Forms.Button btn_CommentFlag;
        private System.Windows.Forms.Label lbl_CommentLikes;
        private System.Windows.Forms.CheckBox chk_WithComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Title;
        private System.Windows.Forms.TextBox tb_Comment;
        private System.Windows.Forms.Button btn_PlaceComment;
        private System.Windows.Forms.GroupBox gb_NewComment;
        private System.Windows.Forms.Button btn_RemoveFile;
        private System.Windows.Forms.Button btn_RemoveComment;
        private System.Windows.Forms.Label lbl_FileFlags;
        private System.Windows.Forms.Label lbl_CommentFlags;
        private System.Windows.Forms.Label lbl_Sorting;
        private System.Windows.Forms.ComboBox cb_SortingMethod;
        private System.Windows.Forms.Button btn_Sort;

    }
}

