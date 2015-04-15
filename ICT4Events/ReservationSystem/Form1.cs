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
                    List<string> list = new List<string>();
                    s.SetReservation();




                }
            }
        }

    }
}
