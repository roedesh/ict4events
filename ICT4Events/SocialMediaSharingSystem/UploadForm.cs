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
using DataLibrary;

namespace SocialMediaSharingSystem
{
    public partial class UploadForm : Form
    {

        private int currentAccountID;
        private string sourceFilePath;
        private string destFilePath;
        private string fileName;

        DataManager dManager = new DataManager();

        public UploadForm(int accountID, string destFile)
        {
            this.destFilePath = destFile;
            currentAccountID = accountID;
            InitializeComponent();
        }

        private void btn_Upload2_Click(object sender, EventArgs e)
        {
            System.IO.File.Copy(sourceFilePath, @"C:/users/Jeroen/Desktop/" + destFilePath + '/' + fileName  , true);

            // Send to DB   
            
            this.Close();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                tb_FilePath.Text = path;
                sourceFilePath = path;

                string[] splits = path.Split('\\');
                fileName = splits.Last();


            }
        }
    }
}
