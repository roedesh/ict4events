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
        public AccountManager tempAccountManager = new AccountManager();
        public ExtraPersons()
        {
            InitializeComponent();
            btSubmitForm.DialogResult = DialogResult.OK;
            btCancelForm.DialogResult = DialogResult.Cancel;
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
            foreach (Account a in tempAccountManager.Accounts)
            {
                lstPersons.Items.Add(a.ToString());
            }
        }

        private void lstPersons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
