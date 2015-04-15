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
        private int accountID;
        private string sourceFilePath;
        private string destFilePath;
        private string fileName;

        SuperManager superManager;

        public UploadForm(int accountID, string destFile)
        {
            this.destFilePath = destFile;
            this.accountID = accountID;
            superManager = new SuperManager();
            InitializeComponent();
        }

        private void btn_Upload2_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = frm_SocialMedia.BASEPATH + destFilePath + '/' + fileName;
                superManager.AddFile(0, accountID, 0, DateTime.Now, tb_Title.Text, filePath, sourceFilePath);
            }
            catch (FormatException)
            {
                MessageBox.Show("Geen geldige invoer.");
            }
            finally
            {
                // refresh main form
                this.Close();
            }

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
