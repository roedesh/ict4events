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
    public partial class ExtraPersons : Form
    {
        public SuperManager s = new SuperManager();

        public ExtraPersons(Account mainBooker, AccountManager tempAccountManager)
        {
            InitializeComponent();
            if (mainBooker != null)
                s.mainBooker = mainBooker;
            if (tempAccountManager != null)
                s.tempAccountManager = tempAccountManager;
            RefreshList();
        }

        private void btAddPerson_Click(object sender, EventArgs e)
        {
            if (IsFilledIn())
            {
                if (!IsDigitsOnly(txtEventID.Text))
                {
                    Guest newAccount = new Guest(
                        txtEventID.Text,
                        txtUsername.Text,
                        txtPassword.Text,
                        txtName.Text,
                        txtAddress.Text,
                        txtCity.Text,
                        txtPostalCode.Text,
                        dtpDateOfBirth.Value.Date,
                        txtEmail.Text,
                        txtPhone.Text
                    );
                    s.tempAccountManager.AddAccount(newAccount);
                    RefreshList();
                    EmptyTextboxes();
                }
                else
                {
                    MessageBox.Show("Event ID moet een getal zijn!");
                } 
            }
            else
            {
                MessageBox.Show("Niet alles ingevuld!");
            }
        }

        private void btAddMainBooker_Click(object sender, EventArgs e)
        {
            if (IsFilledIn())
            {
                if (!IsDigitsOnly(txtEventID.Text))
                {
                    Guest newAccount = new Guest(
                        txtEventID.Text,
                        txtUsername.Text,
                        txtPassword.Text,
                        txtName.Text,
                        txtAddress.Text,
                        txtCity.Text,
                        txtPostalCode.Text,
                        dtpDateOfBirth.Value.Date,
                        txtEmail.Text,
                        txtPhone.Text
                    );
                    s.mainBooker = newAccount;
                    btAddMainBooker.Enabled = false;
                    RefreshList();
                    EmptyTextboxes();
                }
                else
                {
                    MessageBox.Show("Event ID moet een getal zijn!");
                } 
            }
            else
            {
                MessageBox.Show("Niet alles ingevuld!");
            }
        }

        public void RefreshList()
        {
            lstPersons.Items.Clear();
            if (s.mainBooker != null)
            {
                lstPersons.Items.Add("HOOFDBOEKER | " + s.mainBooker.ToString());
            }
            foreach (Account a in s.tempAccountManager.Accounts)
            {
                lstPersons.Items.Add(a.ToString());
            }
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        bool IsFilledIn()
        {
            foreach (Control tb in gboxAdd.Controls)
            {
                if (tb is TextBox)
                {
                    if (tb.Text == "" || tb.Text == null)
                    {
                        MessageBox.Show("Niet alle gegevens zijn ingevuld!");
                        return false;
                    }
                }
            }
            return true;
        }

        public void EmptyTextboxes()
        {
            foreach (Control tb in gboxAdd.Controls)
            {
                if (tb is TextBox)
                {
                    tb.Text = "";
                }
            }
        }

        private void btSearchAccount_Click(object sender, EventArgs e)
        {
            string val = txtAccountEntry.Text;
            string accountInfo = "<geen account gevonden>";
            if (val == null || val == "")
            {
                MessageBox.Show("Vul eerst een waarde in!");
            }
            else
            {
                if (IsDigitsOnly(val))
                {
                    // Search account by ID
                    s.currentExistingAccount = s.GetAccount(Convert.ToInt32(val));
                }
                else
                {
                    // Search account by username
                    s.currentExistingAccount = s.GetAccount(val);
                }
            }
            if (s.currentExistingAccount != null)
            {
                accountInfo = s.currentExistingAccount.ToString();
                btAddExistingAccount.Enabled = true;
            } 
            txtFoundAccountInfo.Text = accountInfo;
        }

        private void btAddExistingAccount_Click(object sender, EventArgs e)
        {
            if (s.currentExistingAccount != null)
            {
                s.tempAccountManager.AddAccount(s.currentExistingAccount);
                s.currentExistingAccount = null;
                txtFoundAccountInfo.Text = "<geen account gevonden>";
            }
            RefreshList();
        }

        private void btDeleteAccount_Click(object sender, EventArgs e)
        {
            if (s.mainBooker != null)
            {
                if ("HOOFDBOEKER | " + s.mainBooker.ToString() == lstPersons.SelectedItem.ToString())
                {
                    s.mainBooker = null;
                    btAddMainBooker.Enabled = true;
                }
            }
            else
            {
                Account account = s.tempAccountManager.Accounts.Find(a => a.ToString() == lstPersons.SelectedItem.ToString());
                if (account != null)
                {
                    s.tempAccountManager.Accounts.Remove(account);
                }
            }
            RefreshList();
        }

        private void btSubmitForm_Click(object sender, EventArgs e)
        {
            if (s.mainBooker == null)
            {
                MessageBox.Show("Er is geen hoofdboeker. Maak eerst een hoofdboeker aan!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Heeft u alle personen toegevoegd?", "Bevestiging", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btCancelForm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Weet u het zeker?", "Reservering annuleren", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btMakeMainBooker_Click(object sender, EventArgs e)
        {
            if (s.mainBooker == null)
            {
                Account switchAccount = s.tempAccountManager.Accounts.Find(a => a.ToString() == lstPersons.SelectedItem.ToString());
                s.tempAccountManager.RemoveAccount(switchAccount);
                s.mainBooker = switchAccount;
            }
            if (s.mainBooker != null)
            {
                if ("HOOFDBOEKER | " + s.mainBooker.ToString() != lstPersons.SelectedItem.ToString())
                {
                    s.tempAccountManager.AddAccount(s.mainBooker);
                    Account switchAccount = s.tempAccountManager.Accounts.Find(a => a.ToString() == lstPersons.SelectedItem.ToString());
                    s.tempAccountManager.RemoveAccount(switchAccount);
                    s.mainBooker = switchAccount;
                }
            }
            RefreshList();
        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }
    }
}
