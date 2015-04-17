using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary;

namespace ReservationSystem
{
    public partial class LoginForm : Form
    {
        DataManager dManager = new DataManager();
        public LoginForm()
        {
            InitializeComponent();
        }

        

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" & txtPassword.Text != "")
            {
                List<Dictionary<string, string>> account = dManager.Login(txtUsername.Text, txtPassword.Text);
                if (account.Count == 0)
                {
                    MessageBox.Show("Accountgegevens kloppen niet!");
                }
                else
                {
                    (new Form1()).Show();
                    this.Hide();
                }
            }
        }
    }
}
