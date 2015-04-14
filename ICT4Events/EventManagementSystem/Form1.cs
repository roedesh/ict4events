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

namespace EventManagementSystem
{
    public partial class Form1 : Form
    {
        SuperManager superManager = new SuperManager();
        public Form1()
        {
            InitializeComponent();

        }

        private void btnEventsAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //superManager.AddEvent();
            }
            catch (FormatException)
            {
                MessageBox.Show("Prijs moet uit cijfers bestaan");
            }
        }

        private void btnEventsShow_Click(object sender, EventArgs e)
        {
            List<Event> showEvents = new List<Event>();
            showEvents = superManager.ShowEvents();
            foreach (Event ev in showEvents)
            {
                dataGridView.Rows.Add(ev);
            }
        }

        private void btnPersoonShowAll_Click(object sender, EventArgs e)
        {
            List<string> showAllAccounts = new List<string>();
            showAllAccounts = superManager.ShowAccounts();
            foreach (string s in showAllAccounts)
            {
                dataGridView.Rows.Add(s);
            }
        }

        private void btnPersoonAdd_Click(object sender, EventArgs e)
        {
            // eventid, username, password, fullname, adress, city, postalcode, date of birth, email, phonenumber
        }

        private void btnPersoonShowAll_Click_1(object sender, EventArgs e)
        {

        }





    }
}
