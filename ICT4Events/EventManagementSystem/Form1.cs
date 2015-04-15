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
            cbPersoonRole.DataSource = Enum.GetValues(typeof(AccountLibrary.Account.AccountRole));
            cbMedewerkersRole.DataSource = Enum.GetValues(typeof(AccountLibrary.Account.AccountRole));
        }

        private void btnEventsAdd_Click(object sender, EventArgs e)
        {
            try
            {
                superManager.AddEvent(Convert.ToInt32(tbEventEventID.Text), tbEventLocatie.Text,
                    tbEventBeginDatum.Text, tbEventEindDatum.Text, tbEventBeschrijving.Text,
                    Convert.ToDecimal(tbEventPrijs.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Prijs moet uit cijfers bestaan");
            }
        }

        private void btnEventsShow_Click(object sender, EventArgs e)
        {
            List<Event> showAllEvents = new List<Event>();
            showAllEvents = superManager.ShowEvents();
            dataGridView.DataSource = showAllEvents;
        }        
        
        private void btnEventsDelete_Click(object sender, EventArgs e)
        {
            superManager.DeleteEvent(tbEventEventID.Text);
        }

        private void btnPersoonShowAll_Click(object sender, EventArgs e)
        {
        }

        private void btnPersoonAdd_Click(object sender, EventArgs e)
        {
            // eventid, username, password, fullname, adress, city, postalcode, date of birth, email, phonenumber
        }








    }
}
