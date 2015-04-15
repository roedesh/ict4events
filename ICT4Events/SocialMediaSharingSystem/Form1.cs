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

namespace SocialMediaSharingSystem
{
    public partial class frm_SocialMedia : Form
    {
        SuperManager superManager = new SuperManager();
        private File currentFile;


        public frm_SocialMedia()
        {
            InitializeComponent();

            ListDirectory(tv_Directories, @"C:/users/Jeroen/Desktop/Test");
        }

        public void GetDirectoryInfo()
        {
            DriveInfo di = new DriveInfo("c");

            if (!di.IsReady)
            {
                MessageBox.Show("The drive {0}, could not be read", di.Name);
                return;
            }
            DirectoryInfo rootDir = di.RootDirectory;
        }


        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

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


        private void tv_Directories_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tv_Directories.SelectedNode = e.Node;

            if (e.Button == MouseButtons.Right)
            {
                if (e.Node.Text.Contains('.'))
                {
                    // Show Context menu with file options (delete, open)
                }
                else
                {
                    cms_FileViewer.Show(tv_Directories, e.Location);
                }
            }
        }

        private void uploadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string destinationPath = tv_Directories.SelectedNode.FullPath;
            UploadForm uploadForm = new UploadForm(1, destinationPath);
            var result = uploadForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //PostManager tempPostManager = uploadForm.te
            }
        }

        private void addCatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string categoryPath = tv_Directories.SelectedNode.FullPath;
            CategoryForm categoryForm = new CategoryForm(categoryPath);
            categoryForm.ShowDialog();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ListDirectory(tv_Directories, @"C:/users/Jeroen/Desktop/Test");
            this.Refresh();

        }

        private void tv_Directories_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Node.Text.Contains('.'))
                {
                    Console.WriteLine(tv_Directories.SelectedNode.FullPath);
                    ShowFile(tv_Directories.SelectedNode.FullPath);
                }

            }
        }

        private void ShowFile(string sourcePath)
        {
            currentFile = superManager.GetFile(sourcePath);

            lbl_Title.Text += (" " + currentFile.Title);
            btn_Download.Enabled = true;


        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {


            }
        }
    }
}
