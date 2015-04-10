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
    }
}
