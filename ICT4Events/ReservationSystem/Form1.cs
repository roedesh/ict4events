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

    public partial class Form1 : Form
    {
        SuperManager s = new SuperManager();
        bool isValidPlace = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btAddPersons_Click(object sender, EventArgs e)
        {
            ExtraPersons epForm = new ExtraPersons(s.mainBooker, s.tempAccountManager);
            var result = epForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                s.tempAccountManager = epForm.s.tempAccountManager;
                s.mainBooker = epForm.s.mainBooker;
                int count = s.tempAccountManager.Accounts.Count() + 1;
                txtAmountPersons.Text = Convert.ToString(count);
                if (count > 0)
                    btAddPersons.Text = "Personen bewerken";
            }
        }

        private void btCheckPlace_Click(object sender, EventArgs e)
        {
            if (s.CheckPlace(txtCheckPlace.Text))
            {
                txtPlaceStatus.Text = String.Format("Plaatsnummer {0} is nog beschikbaar!", txtCheckPlace.Text);
                txtPlaceStatus.ForeColor = Color.Green;
                isValidPlace = true;
            }
            else
            {
                txtPlaceStatus.Text = String.Format("Plaatsnummer {0} is al bezet!", txtCheckPlace.Text);
                txtPlaceStatus.ForeColor = Color.Red;
                isValidPlace = false;
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Weet u zeker dat u alles wilt resetten?", "Bevestiging", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                txtCheckPlace.Clear();
                txtAmountPersons.Text = "0";
                s.mainBooker = null;
                s.tempAccountManager.Accounts.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValidPlace == false)
            {
                MessageBox.Show("Ongeldig plaatsnummer!");
            }
            else if (dtpStartDate.Value.Date == dtpEndDate.Value.Date){
                MessageBox.Show("Start en einddatum mag niet hetzelfde zijn!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Weet u zeker dat alle gegevens kloppen?", "Reservering plaatsen", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    List<int> accountsToAdd = new List<int>();
                    foreach (Account a in s.tempAccountManager.Accounts)
                    {
                        if (a.ID == 0)
                        {
                            List<string> accountParams = new List<string>() ;
                            accountParams.Add(Convert.ToString(a.EventID));
                            accountParams.Add(a.Username);
                            accountParams.Add(a.Password);
                            accountParams.Add(a.Name);
                            accountParams.Add(a.Address);
                            accountParams.Add(a.City);
                            accountParams.Add(a.PostalCode);
                            accountParams.Add(a.DateOfBirth.ToShortDateString());
                            accountParams.Add(a.Email);
                            accountParams.Add(a.Phone);
                            int ID = s.SetAccount(accountParams);
                            accountsToAdd.Add(ID);
                        }
                        else
                        {
                            accountsToAdd.Add(a.ID);
                        }
                    }

                    List<string> mainBookerParams = new List<string>();
                    mainBookerParams.Add(Convert.ToString(s.mainBooker.EventID));
                    mainBookerParams.Add(s.mainBooker.Username);
                    mainBookerParams.Add(s.mainBooker.Password);
                    mainBookerParams.Add(s.mainBooker.Name);
                    mainBookerParams.Add(s.mainBooker.Address);
                    mainBookerParams.Add(s.mainBooker.City);
                    mainBookerParams.Add(s.mainBooker.PostalCode);
                    mainBookerParams.Add(s.mainBooker.DateOfBirth.ToShortDateString());
                    mainBookerParams.Add(s.mainBooker.Email);
                    mainBookerParams.Add(s.mainBooker.Phone);
                    int mainBookerID = s.SetAccount(mainBookerParams);
                    accountsToAdd.Add(mainBookerID);
                    s.SetReservation();




                }
            }
        }

    }
}
