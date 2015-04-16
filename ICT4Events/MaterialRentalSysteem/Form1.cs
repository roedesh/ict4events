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
using DataLibrary;
using Phidgets; //Needed for the RFID class and the PhidgetException class
using Phidgets.Events; //Needed for the phidget event handling classes

namespace MaterialRentalSysteem
{
    public partial class Form1 : Form
    {
        private RFID rfid; //Declare an RFID object
        private SuperManager supermanager;
        public Form1()
        {
            InitializeComponent();
            supermanager = new SuperManager();
        }

        private void btnArtikelVoegToe_Click(object sender, EventArgs e)
        {

        }
    }
}
