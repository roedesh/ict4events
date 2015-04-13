using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountLibrary;

namespace ReservationSystem
{

    public partial class Form1 : Form
    {
        Account account;
        SuperManager s = new SuperManager();
        public Form1()
        {
            InitializeComponent();
            DateTime date = new DateTime(2014, 1, 18);
            account = new Account(1, "000001", "Ruud Schroën", "Stationsstraat 30a", "Heythuysen", "6093BL", date, "schroenruud@gmail.com", "0612345678", Account.AccountRole.Admin);
            Console.WriteLine(account.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btAddPersons_Click(object sender, EventArgs e)
        {
            ExtraPersons epForm = new ExtraPersons();
            var result = epForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                AccountManager tempAccountManager = epForm.tempAccountManager;
                foreach (Account a in tempAccountManager.Accounts){
                    Console.WriteLine(a.ToString());
                }
            }
        }

        private void btCheckPlace_Click(object sender, EventArgs e)
        {
            if (s.CheckPlace(txtCheckPlace.Text))
            {
                MessageBox.Show(String.Format("Plaatsnummer {0} is al bezet!", txtCheckPlace.Text));
            }
            else
            {
                MessageBox.Show(String.Format("Plaatsnummer {0} is nog beschikbaar!", txtCheckPlace.Text));
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
