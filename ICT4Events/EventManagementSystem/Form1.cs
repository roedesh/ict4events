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
        bool isEmployee;
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
            List<Account> showAllGuestAccounts = new List<Account>();
            showAllGuestAccounts = superManager.ShowGuestAccounts();
            dataGridView.DataSource = showAllGuestAccounts;
            cbMedewerkersRole.SelectedIndex = cbMedewerkersRole.FindStringExact("Guest");
            cbMedewerkersRole.Enabled = false;
            isEmployee = false;
        }

        private void btnMedewerkersShowAllEmployee_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.Refresh();
            List<Employee> showAllEmployeeAccounts = new List<Employee>();
            showAllEmployeeAccounts = superManager.ShowEmployeeAccounts();
            dataGridView.DataSource = showAllEmployeeAccounts;
            cbMedewerkersRole.Enabled = true;
            isEmployee = true;
        }

        
        private void btnMedewerkersEdit_Click(object sender, EventArgs e)
        {
           
            //check if it is a Guest
            if (cbMedewerkersRole.SelectedItem.ToString() == "Guest")
            {
                superManager.EditGuest(Convert.ToInt32(tbMedewerkerAccountID.Text),
                    Convert.ToInt32(tbMedewerkersEventID.Text), tbMedewerkerUsername.Text,
                    tbMedewerkerPassword.Text, tbMedewerkerName.Text, tbMedewerkerAddress.Text,
                    tbMedewerkerCity.Text, tbMedewerkerPostalcode.Text, tbMedewerkerDateOfBirth.Text,
                    tbMedewerkerEmail.Text, Convert.ToInt32(tbMedewerkerPhonenumber.Text));
                MessageBox.Show("Persoon " + tbMedewerkerName.Text + " aangepast");
                isEmployee = false;
                btnMedewerkersShowAllGuest_Click(sender, e);
            }
            else // it's an Employee
            {
                    superManager.EditEmployee(Convert.ToInt32(tbMedewerkerAccountID.Text),
                    Convert.ToInt32(tbMedewerkersEventID.Text), tbMedewerkerUsername.Text,
                    tbMedewerkerPassword.Text, tbMedewerkerName.Text, tbMedewerkerAddress.Text,
                    tbMedewerkerCity.Text, tbMedewerkerPostalcode.Text, tbMedewerkerDateOfBirth.Text,
                    tbMedewerkerEmail.Text, Convert.ToInt32(tbMedewerkerPhonenumber.Text),
                    Convert.ToInt32(tbMedewerkerEmployeeID.Text), cbMedewerkersRole.SelectedIndex);
                    MessageBox.Show("Medewerker " + tbMedewerkerName.Text + " aangepast");
                    isEmployee = true;
                    btnMedewerkersShowAllEmployee_Click(sender, e);
            }
        }

        private void btnMedewerkersAdd_Click(object sender, EventArgs e)
        {
            try
            {
                superManager.AddEmployee(Convert.ToInt32(tbMedewerkerAccountID.Text),
                    Convert.ToInt32(tbMedewerkersEventID.Text), tbMedewerkerUsername.Text,
                    tbMedewerkerPassword.Text, tbMedewerkerName.Text, tbMedewerkerAddress.Text,
                    tbMedewerkerCity.Text, tbMedewerkerPostalcode.Text, tbMedewerkerDateOfBirth.Text,
                    tbMedewerkerEmail.Text, Convert.ToInt32(tbMedewerkerPhonenumber.Text),
                    Convert.ToInt32(tbMedewerkerEmployeeID.Text), cbMedewerkersRole.SelectedIndex);
                MessageBox.Show("Medewerker " + tbEventEventID.Text + " toegevoegd");
            }
            /*catch ()
            {
                
            }*/
            finally
            {
                isEmployee = true;
                btnMedewerkersShowAllEmployee_Click(sender, e);
            }
            
        }

        private void btnMedewerkersDelete_Click(object sender, EventArgs e)
        {
            //check if it is a Guest
            if (cbMedewerkersRole.SelectedItem.ToString() == "Guest")
            {
                superManager.DeleteAccountGuest(Convert.ToInt32(tbMedewerkerAccountID.Text));
                btnMedewerkersShowAllGuest_Click(sender, e);
                isEmployee = false;
            }
            else // it's an Employee
            {
                superManager.DeleteAccountEmployee(Convert.ToInt32(tbMedewerkerAccountID.Text));
                btnMedewerkersShowAllEmployee_Click(sender, e);
                isEmployee = true;
            }
        }

        //nog doen
        private void btnPlaatsEdit_Click(object sender, EventArgs e)
        {
        }

        private void btnPlaatsShowAllLocations_Click(object sender, EventArgs e)
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
                if (tabControl.SelectedTab == tabControl.TabPages["tpMedewerkers"])
                {
                    tbMedewerkerUsername.Text = row.Cells["Username"].Value.ToString();
                    tbMedewerkerPassword.Text = row.Cells["Password"].Value.ToString();
                    tbMedewerkerName.Text = row.Cells["Name"].Value.ToString();
                    tbMedewerkerAddress.Text = row.Cells["Address"].Value.ToString();
                    tbMedewerkerCity.Text = row.Cells["City"].Value.ToString();
                    tbMedewerkerPostalcode.Text = row.Cells["PostalCode"].Value.ToString();
                    tbMedewerkerDateOfBirth.Text = row.Cells["DateOfBirth"].Value.ToString();
                    tbMedewerkerEmail.Text = row.Cells["Email"].Value.ToString();
                    tbMedewerkerPhonenumber.Text = row.Cells["Phone"].Value.ToString();
                    tbMedewerkersEventID.Text = row.Cells["EventID"].Value.ToString();
                    tbMedewerkerAccountID.Text = row.Cells["ID"].Value.ToString();
                    if (isEmployee)
                    {
                        string enumCast = row.Cells["Role"].Value.ToString();
                        int enumID = superManager.getEnum(enumCast);
                        tbMedewerkerRoleID.Text = enumID.ToString();
                        cbMedewerkersRole.SelectedIndex = cbMedewerkersRole.FindStringExact(row.Cells["Role"].Value.ToString());
                    }
                    

                   
                }
                if (tabControl.SelectedTab == tabControl.TabPages["tpEvents"])
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
