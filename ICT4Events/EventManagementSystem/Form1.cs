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
           /* cbPersoonRole.DataSource = Enum.GetValues(typeof(AccountLibrary.Account.AccountRole));
            cbMedewerkersRole.DataSource = Enum.GetValues(typeof(AccountLibrary.Account.AccountRole));*/
        }



        private void btnEventsShow_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.Refresh();
            List<Event> showAllEvents = new List<Event>();
            showAllEvents = superManager.ShowEvents();
            dataGridView.DataSource = showAllEvents;
        }

        private void btnEventsAdd_Click(object sender, EventArgs e)
        {
            try
            {
                superManager.AddEvent(Convert.ToInt32(tbEventEventID.Text), tbEventLocatie.Text,
                    tbEventBeginDatum.Text, tbEventEindDatum.Text, tbEventBeschrijving.Text,
                    Convert.ToDecimal(tbEventPrijs.Text));
                MessageBox.Show("Event " + tbEventEventID.Text + " toegevoegd");
            }
            catch (FormatException)
            {
                MessageBox.Show("Niet de juiste invoer: EventID en prijs moeten uit nummers bestaan");
            }
            finally
            {
                btnEventsShow_Click(sender, e);
            }
        }
        
        private void btnEventsDelete_Click(object sender, EventArgs e)
        {
            try
            {
                superManager.DeleteEvent(tbEventEventID.Text);
                MessageBox.Show("Event " + tbEventEventID.Text + " verwijderd");
            }
            catch
            {
            
            }
            finally
            {
                btnEventsShow_Click(sender, e);
            }

        }

        private void btnEventsEdit_Click(object sender, EventArgs e)
        {
            try
            {
                superManager.EditEvent(Convert.ToInt32(tbEventEventID.Text), tbEventLocatie.Text,
                    tbEventBeginDatum.Text, tbEventEindDatum.Text, tbEventBeschrijving.Text,
                    Convert.ToDecimal(tbEventPrijs.Text));
                MessageBox.Show("Event " + tbEventEventID.Text + " aangepast");
            }
            catch
            {

            }
            finally
            {
                btnEventsShow_Click(sender, e);
            }
        }

        private void btnMedewerkersShowAllGuest_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.Refresh();
            List<Account> showAllAccounts = new List<Account>();
            showAllAccounts = superManager.ShowAccounts();
            dataGridView.DataSource = showAllAccounts;
        }
       

        private void btnPlaatsEdit_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                tbEventEventID.Text = row.Cells["ID"].Value.ToString();
                tbEventLocatie.Text = row.Cells["Location"].Value.ToString();
                tbEventBeginDatum.Text = row.Cells["StartDate"].Value.ToString();
                tbEventEindDatum.Text = row.Cells["EndDate"].Value.ToString();
                tbEventBeschrijving.Text = row.Cells["Description"].Value.ToString();
                tbEventPrijs.Text = row.Cells["AdmissionFee"].Value.ToString();
            }

        }














    }
}
