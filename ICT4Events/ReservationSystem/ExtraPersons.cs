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
        public int currentExistingAccountID = 0; // Holds the ID of a existing account that has been found
        public Account mainBooker;
        public AccountManager tempAccountManager = new AccountManager();
        public SuperManager s = new SuperManager();

        public ExtraPersons()
        {
            InitializeComponent();
        }

        private void btAddPerson_Click(object sender, EventArgs e)
        {
            if (IsFilledIn())
            {
                Account newAccount = new Account(
                    txtName.Text,
                    txtAddress.Text,
                    txtCity.Text,
                    txtPostalCode.Text,
                    dtpDateOfBirth.Value.Date,
                    txtEmail.Text,
                    txtPhone.Text
                );
                tempAccountManager.AddAccount(newAccount);
                RefreshList();
                EmptyTextboxes();
            }
        }

        private void btAddMainBooker_Click(object sender, EventArgs e)
        {
            if (IsFilledIn())
            {
                Account newAccount = new Account(
                    txtName.Text,
                    txtAddress.Text,
                    txtCity.Text,
                    txtPostalCode.Text,
                    dtpDateOfBirth.Value.Date,
                    txtEmail.Text,
                    txtPhone.Text
                );
                mainBooker = newAccount;
                btAddMainBooker.Enabled = false;
                RefreshList();
                EmptyTextboxes();
            } 
        }

        public void RefreshList()
        {
            lstPersons.Items.Clear();
            if (mainBooker != null)
            {
                lstPersons.Items.Add(mainBooker.ToString());
            }
            foreach (Account a in tempAccountManager.Accounts)
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
            string val = tbAccountEntry.Text;
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
                    s.GetAccount(Convert.ToInt32(val));
                }
                else
                {
                    // Search account by username
                    s.GetAccount(val);
                }
            }         
            lblFoundAccountInfo.Text = accountInfo;
        }

        private void btAddExistingAccount_Click(object sender, EventArgs e)
        {
            if (currentExistingAccountID != 0)
            {
                //TODO: voeg bestaand account toe aan reservering
            }
            RefreshList();
        }

        private void btDeleteAccount_Click(object sender, EventArgs e)
        {
            if (mainBooker != null & mainBooker.ToString() == lstPersons.SelectedItem.ToString())
            {
                mainBooker = null;
                btAddMainBooker.Enabled = true;
            }
            else
            {
                Account account = tempAccountManager.Accounts.Find(a => a.ToString() == lstPersons.SelectedItem.ToString());
                if (account != null)
                {
                    tempAccountManager.Accounts.Remove(account);
                }
            }
            RefreshList();
        }

        private void btSubmitForm_Click(object sender, EventArgs e)
        {
            if (mainBooker == null)
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
    }
}
