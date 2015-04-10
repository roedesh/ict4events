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
        public frm_SocialMedia()
        {
            InitializeComponent();
            ListDirectoryContent(new DirectoryInfo(@"C:/users/Jeroen/Desktop/Test"));
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

        public void ListDirectoryContent(DirectoryInfo root)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;

            try
            {
                files = root.GetFiles("*.*");
            }
            catch (DirectoryNotFoundException e)
            {
                MessageBox.Show(e.Message);
            }

            if (files != null)
            {
                foreach (FileInfo f in files)
                {
                    lbFolders.Items.Add(f);
                }

                subDirs = root.GetDirectories();

                foreach (DirectoryInfo d in subDirs)
                {
                    lbFolders.Items.Add(d);
                }
            }
        }

        private void lbFolders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbFolders.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    if (lbFolders.SelectedItem is DirectoryInfo)
                    {
                        DirectoryInfo d = (DirectoryInfo)lbFolders.SelectedItem;
                        lbFolders.Items.Clear();
                        ListDirectoryContent(d);
                    }
                }
        }




    }
}
