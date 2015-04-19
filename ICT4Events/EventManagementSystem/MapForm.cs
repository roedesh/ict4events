using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class MapForm : Form
    {
        public MapForm()
        {
            InitializeComponent();
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            OpenFileDialog newdialog = new OpenFileDialog();
            newdialog.Filter = "Jpg files or Png files (*.jpg)|*.jpg|(*.png)|*.png";
            newdialog.InitialDirectory = @"C:\";
            if (newdialog.ShowDialog() == DialogResult.OK)
            {
                pbMap.Image = Image.FromFile(newdialog.FileName);
            }
            this.Size = pbMap.Size;
        }
    }
}
