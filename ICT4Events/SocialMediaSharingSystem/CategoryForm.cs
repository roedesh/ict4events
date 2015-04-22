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
    public partial class CategoryForm : Form
    {
        private string destination;
        private char[] chars = { '.', '\\', '/', ':', '*', '?', '"', '<', '>', '|' };
        public CategoryForm(string destination)
        {
            InitializeComponent();
            this.destination = destination;
        }

        /// <summary>
        /// Create a directory based on user input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text.Trim().Length != 0 && tb_Name.Text.IndexOfAny(chars) == -1)
            {
                Directory.CreateDirectory(frm_SocialMedia.BASEPATH + destination + @"\" + tb_Name.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Vul een geldige naam in. (Zonder tekens)");
            }
        }
    }
}
