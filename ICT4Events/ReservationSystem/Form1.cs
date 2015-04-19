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
                lbAmountPersonsValue.Text = Convert.ToString(count);
                if (count > 0)
                    btAddPersons.Text = "Personen bewerken";
            }
        }

        private void btCheckPlace_Click(object sender, EventArgs e)
        {
            if (txtCheckPlace.Text.All(char.IsDigit)){
                if (s.CheckPlace(txtCheckPlace.Text))
                {
                    lbPlaceStatus.Text = String.Format("Plaatsnummer {0} is nog beschikbaar!", txtCheckPlace.Text);
                    lbPlaceStatus.ForeColor = Color.Green;
                    isValidPlace = true;
                }
                else
                {
                    lbPlaceStatus.Text = String.Format("Plaatsnummer {0} is al bezet!", txtCheckPlace.Text);
                    lbPlaceStatus.ForeColor = Color.Red;
                    isValidPlace = false;
                }
            }
            else
            {
                MessageBox.Show("Plaatsnummer mag geen letters bevatten!");
            }
            
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Weet u zeker dat u alles wilt resetten?", "Bevestiging", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                txtCheckPlace.Clear();
                lbAmountPersonsValue.Text = "0";
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
                    List<int> guestsToAdd = new List<int>();
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
                            if (ID == 0)
                            {
                                MessageBox.Show("Er zijn geen RFID's meer beschikbaar");
                                return;
                            }
                            guestsToAdd.Add(ID);
                        }
                        else
                        {
                            guestsToAdd.Add(a.ID);
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
                    guestsToAdd.Add(mainBookerID);

                    List<string> reservationParams = new List<string>();
                    reservationParams.Add(txtCheckPlace.Text);
                    reservationParams.Add(dtpStartDate.Value.ToShortDateString());
                    reservationParams.Add(dtpEndDate.Value.ToShortDateString());
                    reservationParams.Add(Convert.ToString(guestsToAdd.Count));
                    reservationParams.Add("NOT PAID");
                    int reservationID = s.SetReservation(reservationParams);

                    foreach (int a in guestsToAdd)
                    {
                        s.SetGuestReservation(a, reservationID);
                    }

                    s.tempAccountManager.Accounts.Clear();
                    s.mainBooker = null;
                    isValidPlace = false;
                    guestsToAdd.Clear();
                    txtCheckPlace.Clear();
                    lbPlaceStatus.Text = "<vul een plaatsnummer in>";
                    lbPlaceStatus.ForeColor = Color.Black;
                    lbAmountPersonsValue.Text = "0";
                }
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

        private void btCancelReservation_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Weet u zeker dat u deze reservering(en) wil annuleren?", "Reservering annuleren", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.dgReservations.SelectedRows)
                {
                    string ID = item.Cells["RESERVATIONID"].Value.ToString();
                    dgReservations.Rows.Remove(item);
                    s.DeleteReservation(ID);
                }
            }
            

        }

        private void btSearchReservation_Click(object sender, EventArgs e)
        {
            BindingList<Reservation> reservations = s.GetReservations(Convert.ToString(cbField.SelectedItem), txtFieldValue.Text);
            if (reservations != null)
            {
                dgReservations.DataSource = reservations;
            }
            else
            {
                MessageBox.Show("Geen reserveringen gevonden!");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
