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
            cbMedewerkersRole.DataSource = Enum.GetValues(typeof(AccountLibrary.Employee.AccountRole));
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
            showAllAccounts = superManager.ShowGuestAccounts();
            dataGridView.DataSource = showAllAccounts;
        }

        private void btnMedewerkersShowAllEmployee_Click(object sender, EventArgs e)
        {

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
                if (tabControl.SelectedTab == tabControl.TabPages["Medewerkers"])
                {
                    tbMedewerkerName.Text = row.Cells["Name"].Value.ToString();
                    tbMedewerkerAddress.Text = row.Cells["Address"].Value.ToString();
                    tbMedewerkerCity.Text = row.Cells["City"].Value.ToString();
                    tbMedewerkerPostalcode.Text = row.Cells["PostalCode"].Value.ToString();
                    tbMedewerkerDateOfBirth.Text = row.Cells["DateOfBirth"].Value.ToString();
                    tbMedewerkerEmail.Text = row.Cells["Email"].Value.ToString();
                    tbMedewerkerPhonenumber.Text = row.Cells["Phone"].Value.ToString();
                    tbMedewerkerAccountID.Text = row.Cells["ID"].Value.ToString();

                    cbMedewerkersRole.SelectedIndex = cbMedewerkersRole.FindStringExact("Guest");
                }
                if (tabControl.SelectedTab == tabControl.TabPages["Events"])
                {
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
}
