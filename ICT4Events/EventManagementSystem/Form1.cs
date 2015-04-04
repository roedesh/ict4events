using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class Form1 : Form
    {
        SuperManager superManager = new SuperManager();
        public Form1()
        {
            InitializeComponent();

        }

        private void btnEventsAdd_Click(object sender, EventArgs e)
        {
            try
            {
                superManager.AddEvent(tbEventName.Text, tbEventAdress.Text, tbEventCity.Text, tbEventPostalCode.Text, Convert.ToDecimal(tbEventPrice.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Prijs moet uit cijfers bestaan");
            }
        }





    }
}
