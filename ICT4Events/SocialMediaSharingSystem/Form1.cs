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
        public frm_SocialMedia()
        {
            InitializeComponent();
            superManager.ListDirectoryContent(new DirectoryInfo(@"C:/users/Jeroen/Desktop/Test"));
            foreach (object i in superManager.Infos)
            {
                lbFolders.Items.Add(i);
            }
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



        private void lbFolders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbFolders.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    if (lbFolders.SelectedItem is DirectoryInfo)
                    {
                        DirectoryInfo d = (DirectoryInfo)lbFolders.SelectedItem;
                        lbFolders.Items.Clear();
                        superManager.ListDirectoryContent(d);

                        foreach (object o in superManager.Infos)
                        {
                            lbFolders.Items.Add(o);                            
                        }

                    }
                }
        }




    }
}
