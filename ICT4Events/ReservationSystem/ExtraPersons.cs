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
        public int currentExistingAccountID = 0;
        public Account mainBooker;
        public AccountManager tempAccountManager = new AccountManager();

        public ExtraPersons()
        {
            InitializeComponent();
        }

        private void btAddPerson_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
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
        }

        private void btSearchAccount_Click(object sender, EventArgs e)
        {
            string val = tbAccountEntry.Text;
            string accountInfo = "<geen account gevonden>";
            if (IsDigitsOnly(val))
            {
                //TODO: zoek op ID
            }
            else
            {
                //TODO: zoek op gebruikersnaam
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
                btAddMainBooker.Enabled = false;
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
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
