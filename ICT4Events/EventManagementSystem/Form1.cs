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
        Form f;
        public Form1()
        {
            InitializeComponent();
            f = null;
            cbMedewerkersRole.DataSource = Enum.GetValues(typeof(AccountLibrary.Employee.AccountRole));
            superManager.ShowEmployeeAccounts();
            superManager.ShowEvents();
            superManager.ShowGuestAccounts();
            superManager.ShowLocations();
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
                DialogResult result1 = MessageBox.Show("Weet u zeker dat u dit event wilt toevoegen?",
		"Critical Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if (result1 == DialogResult.OK)
                {
                    superManager.AddEvent(Convert.ToInt32(tbEventEventID.Text), tbEventLocatie.Text,
                        tbEventBeginDatum.Text, tbEventEindDatum.Text, tbEventBeschrijving.Text,
                        Convert.ToDecimal(tbEventPrijs.Text));
                    MessageBox.Show("Event " + tbEventEventID.Text + " toegevoegd");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Geen geldige invoer");
            }
            catch(MyException mex)
            {
                MessageBox.Show(mex.Message);
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
                DialogResult result1 = MessageBox.Show("Weet u zeker dat u dit event wilt verwijderen?",
		"Critical Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if (result1 == DialogResult.OK)
                {
                    superManager.DeleteEvent(tbEventEventID.Text);
                    MessageBox.Show("Event " + tbEventEventID.Text + " verwijderd");
                }
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
                DialogResult result1 = MessageBox.Show("Weet u zeker dat u dit event wilt bewerken?",
		"Critical Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if (result1 == DialogResult.OK)
                {
                    superManager.EditEvent(Convert.ToInt32(tbEventEventID.Text), tbEventLocatie.Text,
                        tbEventBeginDatum.Text, tbEventEindDatum.Text, tbEventBeschrijving.Text,
                        Convert.ToDecimal(tbEventPrijs.Text));
                    MessageBox.Show("Event " + tbEventEventID.Text + " aangepast");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Geen geldige invoer");
            }
            catch (MyException mex)
            {
                MessageBox.Show(mex.Message);
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
            try
            {
                //check if it is a Guest
                if (cbMedewerkersRole.SelectedItem.ToString() == "Guest")
                {
                    DialogResult result1 = MessageBox.Show("Weet u zeker dat u deze gast wilt bewerken?",
		"Critical Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                    if (result1 == DialogResult.OK)
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
                }
                else // it's an Employee
                {
                    DialogResult result1 = MessageBox.Show("Weet u zeker dat u deze medewerker wilt bewerken?",
		"Critical Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                    if (result1 == DialogResult.OK)
                    {
                        if (tbMedewerkerEmployeeID.Text == "")
                        {
                            throw new MyException("Employee ID niet ingevuld");
                        }
                        superManager.EditEmployee(Convert.ToInt32(tbMedewerkerAccountID.Text),
                    Convert.ToInt32(tbMedewerkersEventID.Text), tbMedewerkerUsername.Text,
                    tbMedewerkerPassword.Text, tbMedewerkerName.Text, tbMedewerkerAddress.Text,
                    tbMedewerkerCity.Text, tbMedewerkerPostalcode.Text, tbMedewerkerDateOfBirth.Text,
                    tbMedewerkerEmail.Text, Convert.ToInt32(tbMedewerkerPhonenumber.Text),
                    Convert.ToInt32(tbMedewerkerEmployeeID.Text), cbMedewerkersRole.SelectedIndex + 1);
                        MessageBox.Show("Medewerker " + tbMedewerkerName.Text + " aangepast");
                        isEmployee = true;
                        btnMedewerkersShowAllEmployee_Click(sender, e);
                    }
                }
            }
            catch(MyException mex)
            {
                MessageBox.Show(mex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Geen geldige invoer");
            }
        }

        private void btnMedewerkersAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result1 = MessageBox.Show("Weet u zeker dat u deze medewerker wilt toevoegen?",
		"Critical Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if (result1 == DialogResult.OK)
                {
                    superManager.AddEmployee(Convert.ToInt32(tbMedewerkerAccountID.Text),
                        Convert.ToInt32(tbMedewerkersEventID.Text), tbMedewerkerUsername.Text,
                        tbMedewerkerPassword.Text, tbMedewerkerName.Text, tbMedewerkerAddress.Text,
                        tbMedewerkerCity.Text, tbMedewerkerPostalcode.Text, tbMedewerkerDateOfBirth.Text,
                        tbMedewerkerEmail.Text, Convert.ToInt32(tbMedewerkerPhonenumber.Text),
                        Convert.ToInt32(tbMedewerkerEmployeeID.Text), cbMedewerkersRole.SelectedIndex + 1);
                    MessageBox.Show("Medewerker " + tbEventEventID.Text + " toegevoegd");
                }
            }
            catch (MyException mex)
            {
                MessageBox.Show(mex.Message);
            }
            catch(FormatException)
            {
                MessageBox.Show("Geen geldige invoer");
            }
            finally
            {
                isEmployee = true;
                btnMedewerkersShowAllEmployee_Click(sender, e);
            }
            
        }

        private void btnMedewerkersDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //check if it is a Guest
                if (cbMedewerkersRole.SelectedItem.ToString() == "Guest")
                {
                    DialogResult result1 = MessageBox.Show("Weet u zeker dat u deze gast wilt verwijderen?",
		"Critical Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                    if (result1 == DialogResult.OK)
                    {
                        superManager.DeleteAccountGuest(Convert.ToInt32(tbMedewerkerAccountID.Text));
                        btnMedewerkersShowAllGuest_Click(sender, e);
                        isEmployee = false;
                    }

                }
                else // it's an Employee
                {
                    DialogResult result1 = MessageBox.Show("Weet u zeker dat u deze medewerker wilt verwijderen?",
		"Critical Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                    if (result1 == DialogResult.OK)
                    {
                        superManager.DeleteAccountEmployee(Convert.ToInt32(tbMedewerkerAccountID.Text));
                        btnMedewerkersShowAllEmployee_Click(sender, e);
                        isEmployee = true;
                    }
                }
            }
            catch (MyException mex)
            {
                MessageBox.Show(mex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Geen geldige invoer, voer een account id in om een account te verwijderen");
            }
        }

        private void btnPlaatsEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result1 = MessageBox.Show("Weet u zeker dat u deze plaats wilt aanpassen?",
        "Critical Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result1 == DialogResult.OK)
                {
                    superManager.EditLocation(Convert.ToInt32(tbPlaatsLocationID.Text), tbPlaatsName.Text,
                        tbPlaatsDescription.Text, Convert.ToInt32(tbPlaatsPrice.Text));
                    MessageBox.Show("Plaats " + tbPlaatsName.Text + " aangepast");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Geen geldige invoer");
            }
            catch(MyException mex)
            {
                MessageBox.Show(mex.Message);
            }
            finally
            {
                btnPlaatsShowAllLocations_Click(sender, e);
            }
        }

        private void btnPlaatsShowAllLocations_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.Refresh();
            List<Location> showAllLocations = new List<Location>();
            showAllLocations = superManager.ShowLocations();
            dataGridView.DataSource = showAllLocations;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
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
                            tbMedewerkerEmployeeID.Text = row.Cells["EMPLOYEEID"].Value.ToString();
                        }
                    }
                    else if (tabControl.SelectedTab == tabControl.TabPages["tpEvents"])
                    {
                        tbEventEventID.Text = row.Cells["ID"].Value.ToString();
                        tbEventLocatie.Text = row.Cells["Location"].Value.ToString();
                        tbEventBeginDatum.Text = row.Cells["StartDate"].Value.ToString();
                        tbEventEindDatum.Text = row.Cells["EndDate"].Value.ToString();
                        tbEventBeschrijving.Text = row.Cells["Description"].Value.ToString();
                        tbEventPrijs.Text = row.Cells["AdmissionFee"].Value.ToString();
                    }
                    else
                    {
                        tbPlaatsLocationID.Text = row.Cells["ID"].Value.ToString();
                        tbPlaatsName.Text = row.Cells["NAME"].Value.ToString();
                        tbPlaatsDescription.Text = row.Cells["DESCRIPTION"].Value.ToString();
                        tbPlaatsPrice.Text = row.Cells["PRICE"].Value.ToString();
                    }



                }
            }
            catch(ArgumentException)
            {
                MessageBox.Show("U bent niet in de juiste tab");
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnShowMap_Click(object sender, EventArgs e)
        {
            if (f == null)
            {
                f = new MapForm();
                f.WindowState = FormWindowState.Normal;
                f.Show();
                f = null;
            }
        }
























    }
}
