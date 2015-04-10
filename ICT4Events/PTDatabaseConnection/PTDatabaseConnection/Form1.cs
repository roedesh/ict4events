using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTDatabaseConnection
{
    public partial class Form1 : Form
    {
        List<string> results;
        public Form1()
        {
            InitializeComponent();
            DatabaseConnection con = new DatabaseConnection();
            con.Connect();
            DataManager dm = new DataManager();
            results = new List<string>();
            results = dm.GetEvent("1");            
            lb1.Text = "connected";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(results);
        }

    }
}
