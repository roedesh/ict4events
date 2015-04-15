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
        public CategoryForm(string destination)
        {
            InitializeComponent();
            this.destination = destination;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text != "")
            {
                Console.WriteLine(destination + @"\" + tb_Name.Text);

                Directory.CreateDirectory(@"C:/users/Jeroen/Desktop/" + destination + @"\" + tb_Name.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Vul een geldige naam in: ");
            }

        }

    }
}
