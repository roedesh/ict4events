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
            InitializeComponent();

            this.destFilePath = destFile;
            this.accountID = accountID;

            superManager = new SuperManager();
        }

        /// <summary>
        /// Call superManager.AddFile based on the path chosen by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Upload2_Click(object sender, EventArgs e)
        {
            try
            {
                // Check whether textboxes are empty:
                if (tb_Title.Text.Trim().Length == 0 || tb_FilePath.Text.Trim().Length == 0)
                {
                    throw new FormatException();
                }
                // Build target filepath:
                string filePath = frm_SocialMedia.BASEPATH + destFilePath + @"\" + fileName;
                superManager.AddFile(0, accountID, 0, DateTime.Now, tb_Title.Text, filePath, sourceFilePath);
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Geen geldige invoer.");
            }
        }

        /// <summary>
        /// Open a file dialog and set a filename and filepath based on choice from the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
