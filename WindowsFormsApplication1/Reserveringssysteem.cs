using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Reserveringssysteem : Form
    {
        Form f;
        public Reserveringssysteem()
        {
            f = null;
            InitializeComponent();
        }

        private void Reserveringssysteem_Load(object sender, EventArgs e)
        {
            if (f == null)
            {
                f = new Bijpersonen();
                f.WindowState = FormWindowState.Normal;
                f.Show();
                f = null;
            }
            if (f == null)
            {
                f = new Eventbeheersysteem();
                f.WindowState = FormWindowState.Normal;
                f.Show();
                f = null;
            }
            if (f == null)
            {
                f = new Inlogform();
                f.WindowState = FormWindowState.Normal;
                f.Show();
                f = null;
            }
            if (f == null)
            {
                f = new Toegangscontrolesysteem();
                f.WindowState = FormWindowState.Normal;
                f.Show();
                f = null;
            }
            if (f == null)
            {
                f = new Materiaalbeheersysteem();
                f.WindowState = FormWindowState.Normal;
                f.Show();
                f = null;
            }
            if (f == null)
            {
                f = new Mediasharingsysteem();
                f.WindowState = FormWindowState.Normal;
                f.Show();
                f = null;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
