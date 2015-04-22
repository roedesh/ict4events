using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AccountLibrary;

namespace SocialMediaSharingSystem
{
    public partial class frm_SocialMedia : Form
    {
        // Basepath to the root of the shared folder (for testing purposes it points at the local desktop + \test).
        public static string BASEPATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";

        SuperManager superManager = new SuperManager();

        private File currentFile;
        private Comment currentComment;

        public frm_SocialMedia(List<Dictionary<string, string>> account)
        {
            InitializeComponent();
            
            // Create the root directory if it does not exist.
            if (!Directory.Exists(BASEPATH + "Test"))
            {
                Directory.CreateDirectory(BASEPATH + "Test");
            }

            ListDirectory(tv_Directories, BASEPATH + "Test");

            superManager.SetLoginAccount(account);
            lbl_CurrentAccount.Text = String.Format("Ingelogd als: {0} ({1})", superManager.CurrentAccount.Name, superManager.IsEmployee ? "medewerker" : "gast");
            
            // Show certain controls if an employee is logged in.
            if (superManager.IsEmployee)
            {
                btn_RemoveFile.Visible = true;
                btn_RemoveComment.Visible = true;
                lbl_CommentFlags.Visible = true;
                lbl_FileFlags.Visible = true;
            }

            // Select the default sorting method.
            cb_SortingMethod.SelectedIndex = 0;
        }

        /// <summary>
        /// Start building the treeview by recursively calling CreateDirectoryNode.
        /// </summary>
        /// <param name="treeView"> The treeview control</param>
        /// <param name="path"></param>
        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        /// <summary>
        /// Create a node for the tree view.
        /// Depending on the directory contents subnodes are being added.
        /// </summary>
        /// <param name="directoryInfo"></param>
        /// <returns></returns>
        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);

            foreach (var directory in directoryInfo.GetDirectories())
            {
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            }

            foreach (var file in directoryInfo.GetFiles())
            {
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            }

            return directoryNode;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            RefreshForm();

        }

        /// <summary>
        /// Call ShowFile when a file is doubleclicked in the treeview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tv_Directories_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Node.Text.Contains('.'))
                {
                    ShowFile(tv_Directories.SelectedNode.FullPath);
                }
            }
        }

        public void RefreshForm()
        {
            ListDirectory(tv_Directories, BASEPATH + "Test");
            PopulateCommentList();
        }


        public void PopulateCommentList()
        {
            lb_Comments.Items.Clear();
            foreach (Comment c in superManager.GetFileComments(currentFile.PostID))
            {
                lb_Comments.Items.Add("Naam: " + superManager.GetAccountName(c.AccountID) + c.ToString());
            }
        }

        /// <summary>
        /// Show the media info based on the selected file in the treeview.
        /// </summary>
        /// <param name="sourcePath"></param>
        private void ShowFile(string sourcePath)
        {
            // Get current file from the database.
            currentFile = superManager.GetFile(frm_SocialMedia.BASEPATH + sourcePath);

            // Array with image types used in the picturebox.
            string[] imageExtensions = { ".bmp", ".jpg", ".png" };

            // Enable the groupboxes
            if (!gb_MediaInfo.Enabled || !gb_Comments.Enabled || !gb_NewComment.Enabled)
            {
                gb_MediaInfo.Enabled = true;
                gb_Comments.Enabled = true;
                gb_NewComment.Enabled = true;
            }

            btn_FileFlag.Enabled = true;
            btn_FileLike.Enabled = true;

            lb_Comments.Items.Clear();

            // Check whether the current account has already liked/flagged the current file.
            List<LikeFlag> fileLikeFlags = superManager.GetLikeFlag(currentFile.PostID, "file", superManager.CurrentAccount.ID);

            foreach (LikeFlag l in fileLikeFlags)
            {
                if (l.Type == Type.Like)
                {
                    btn_FileLike.Enabled = false;
                }
                else
                {
                    btn_FileFlag.Enabled = false;
                }
            }

            // Set labels and picturebox according to currentFile.
            lbl_Title.Text = "Titel:" + currentFile.Title;
            lbl_Uploader.Text = "Uploader: " + superManager.GetAccountName(currentFile.AccountID);
            lbl_UploadDate.Text = "Uploaddatum: " + currentFile.Date.ToString();
            lbl_Likes.Text = "Aantal likes: " + currentFile.AmountOfLikes;
            lbl_FileFlags.Text = "Aantal flags: " + currentFile.AmountOfFlags;

            if (imageExtensions.Any(currentFile.FilePath.Contains))
            {
                lbl_Preview.Text = "Voorbeeld: ";
                pb_Preview.Image = Image.FromFile(currentFile.FilePath);
            }
            else
            {
                lbl_Preview.Text = "Voorbeeld: geen voorbeeld beschikbaar";
                pb_Preview.Image = null;
            }

            // Populate comment listbox for the first time (also send comments to the postManager).
            foreach (Comment c in superManager.GetFileComments(currentFile.PostID))
            {
                lb_Comments.Items.Add("Naam: " + superManager.GetAccountName(c.AccountID) + c.ToString());
            }
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            // Create a savedialog for copying the file.
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            string[] pathSplits = currentFile.FilePath.Split('\\');

            string fileName = pathSplits[pathSplits.Length - 1];

            saveFileDialog.FileName = fileName;
            saveFileDialog.Filter = "All files (*.*)|*.*";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.Copy(currentFile.FilePath, saveFileDialog.FileName);
            }
        }

        private void btn_FileLike_Click(object sender, EventArgs e)
        {
            superManager.LikeFlagPost(currentFile.PostID, superManager.CurrentAccount.ID, -1, DateTime.Now, true);
            lbl_Likes.Text = "Aantal likes: " + currentFile.AmountOfLikes;
            btn_FileLike.Enabled = false;
        }

        private void btn_FileFlag_Click(object sender, EventArgs e)
        {
            superManager.LikeFlagPost(currentFile.PostID, superManager.CurrentAccount.ID, -1, DateTime.Now, false);
            lbl_FileFlags.Text = "Aantal flags: " + currentFile.AmountOfFlags;
            btn_FileFlag.Enabled = false;
        }

        private void btn_PlaceComment_Click(object sender, EventArgs e)
        {
            string title = tb_Title.Text.Trim();
            string message = tb_Comment.Text.Trim();

            if (title.Length == 0)
            {
                MessageBox.Show("Vul een titel in.");
            }
            else
            {
                if (chk_WithComment.Checked)
                {
                    if (lb_Comments.SelectedIndex < 0)
                    {
                        MessageBox.Show("Selecteer het bijbehorend bericht.");
                    }
                    else
                    {
                        superManager.AddComment(0, currentFile.PostID, superManager.CurrentAccount.ID, currentComment.PostID, DateTime.Now, title, message);
                    }
                }
                else
                {
                    superManager.AddComment(0, currentFile.PostID, superManager.CurrentAccount.ID, 0, DateTime.Now, title, message);
                }

                tb_Title.Text = "";
                tb_Comment.Text = "";
            }
            PopulateCommentList();
        }

        private void frm_SocialMedia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_AddFile_Click(object sender, EventArgs e)
        {
            try
            {
                string destinationPath = tv_Directories.SelectedNode.FullPath;

                if (!destinationPath.Contains('.'))
                {
                    using (UploadForm uploadForm = new UploadForm(superManager.CurrentAccount.ID, destinationPath))
                    {
                        uploadForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Selecteer een categorie.");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Selecteer een categorie.");
            }
        }

        private void btn_AddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string categoryPath = tv_Directories.SelectedNode.FullPath;

                if (!categoryPath.Contains('.'))
                {
                    using (CategoryForm categoryForm = new CategoryForm(categoryPath))
                    {
                        categoryForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Selecteer een hoofdcategorie.");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Selecteer een hoofdcategorie.");
            }
        }

        private void lb_Comments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Comments.SelectedIndex >= 0)
            {
                currentComment = superManager.Comments[lb_Comments.SelectedIndex];

                btn_CommentLike.Enabled = true;
                btn_CommentFlag.Enabled = true;

                List<LikeFlag> fileLikeFlags = superManager.GetLikeFlag(currentComment.PostID, "comment", superManager.CurrentAccount.ID);

                foreach (LikeFlag l in fileLikeFlags)
                {
                    if (l.Type == Type.Like)
                    {
                        btn_CommentLike.Enabled = false;
                    }
                    else
                    {
                        btn_CommentFlag.Enabled = false;
                    }

                    if (!btn_CommentFlag.Enabled && !btn_CommentLike.Enabled)
                    {
                        return;
                    }
                }

                tb_CommentOutput.Text = String.Format("{0} ({1}) - {2} \r\n {3}", currentComment.Title, currentComment.PostID, superManager.GetAccountName(currentComment.AccountID), currentComment.Message);
                lbl_CommentLikes.Text = "Aantal likes: " + currentComment.AmountOfLikes;
                lbl_CommentFlags.Text = "Aantal flags: " + currentComment.AmountOfFlags;
            }
        }

        private void btn_CommentLike_Click(object sender, EventArgs e)
        {
            if (lb_Comments.SelectedIndex < 0)
            {
                MessageBox.Show("Selecteer eerst een reactie.");
            }
            else
            {
                superManager.LikeFlagPost(lb_Comments.SelectedIndex + 1, superManager.CurrentAccount.ID, lb_Comments.SelectedIndex, DateTime.Now, true);
                btn_CommentLike.Enabled = false;
                lbl_CommentLikes.Text = "Aantal likes: " + currentComment.AmountOfLikes;
                PopulateCommentList();
            }
        }

        private void btn_CommentFlag_Click(object sender, EventArgs e)
        {
            if (lb_Comments.SelectedIndex < 0)
            {
                MessageBox.Show("Selecteer eerst een reactie.");
            }
            else
            {
                superManager.LikeFlagPost(lb_Comments.SelectedIndex + 1, superManager.CurrentAccount.ID, lb_Comments.SelectedIndex, DateTime.Now, false);
                btn_CommentFlag.Enabled = false;
                lbl_CommentFlags.Text = "Aantal flags: " + currentComment.AmountOfFlags;
                PopulateCommentList();
            }
        }
        private void frm_SocialMedia_Activated(object sender, EventArgs e)
        {
            ListDirectory(tv_Directories, BASEPATH + "Test");
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            switch (cb_SortingMethod.Text)
            {
                case "Datum":
                    superManager.Comments.Sort((x, y) => x.Date.CompareTo(y.Date));
                    break;
                case "Titel":
                    superManager.Comments.Sort((x, y) => x.Title.CompareTo(y.Title));
                    break;
                case "Aantal likes":
                    superManager.Comments.Sort((x, y) => -x.AmountOfLikes.CompareTo(y.AmountOfLikes));
                    break;
            }
            PopulateCommentList();
        }

        private void btn_RemoveFile_Click(object sender, EventArgs e)
        {
            gb_MediaInfo.Enabled = false;
            gb_Comments.Enabled = false;
            gb_NewComment.Enabled = false;

            pb_Preview.Image.Dispose();
            pb_Preview.Image = null;

            MessageBox.Show(String.Format("Bestand ({0}) is verwijderd.", currentFile.Title));
            superManager.DeleteFile(currentFile.PostID, currentFile.FilePath);

            ListDirectory(tv_Directories, BASEPATH + "Test"); 
        }

        private void btn_RemoveComment_Click(object sender, EventArgs e)
        {
            superManager.DeleteComment(currentComment.PostID);
            PopulateCommentList();
        }
    }
}
