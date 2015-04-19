using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountLibrary; // From the account library
using DataLibrary; // From the data library
using Phidgets; //Needed for the RFID class and the PhidgetException class
using Phidgets.Events; //Needed for the phidget event handling classes

namespace MaterialRentalSysteem
{
    public partial class Form1 : Form
    {
        private RFID rfid;
        private SuperManager supermanager;
        public Form1()
        {
            InitializeComponent();
            supermanager = new SuperManager();
            UpdateLb(supermanager.GetAvaillableItems());
            try{lbInfo.SelectedIndex = 0;}
            catch { }
        }
        /// <summary>
        /// Add an item and check for illegal data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArtikelVoegToe_Click(object sender, EventArgs e)
        {
            List<string> Iteminfo = new List<string>();
            if (tbAddName.Text == "" || tbAddType.Text == "" || tbAddStock.Text == "" || tbAddPrice.Text == "")
            {
                MessageBox.Show("Vul alle velden in aub");
                return;
            }
            try
            {
                Convert.ToDecimal(tbAddPrice.Text);
            }
            catch
            {
                MessageBox.Show("Voer een geldige prijs in, aub.");
                return;
            }
            try
            {
                Convert.ToInt32(tbAddStock.Text);
            }
            catch
            {
                MessageBox.Show("Voer een geldig aantal in, aub.");
                return;
            }
            Iteminfo.Add(tbAddName.Text);
            Iteminfo.Add(tbAddType.Text);
            Iteminfo.Add(tbAddStock.Text);
            Iteminfo.Add(tbAddPrice.Text);
            supermanager.AddItem(Iteminfo);
            UpdateLb(supermanager.GetAllItems());

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rfid = new RFID();

            rfid.Attach += new AttachEventHandler(rfid_Attach);
            rfid.Detach += new DetachEventHandler(rfid_Detach);

            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);

            openCmdLine(rfid);
        }
        void rfid_Attach(object sender, AttachEventArgs e)
        {
            RFID attached = (RFID)sender;

            switch (attached.ID)
            {
                case Phidget.PhidgetID.RFID_2OUTPUT_READ_WRITE:
                    break;
                case Phidget.PhidgetID.RFID:
                case Phidget.PhidgetID.RFID_2OUTPUT:
                default:
                    break;
            }

        }
        void rfid_Detach(object sender, DetachEventArgs e)
        {
            RFID detached = (RFID)sender;

        }
        /// <summary>
        /// Whenever an rfid is found update the gui.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void rfid_Tag(object sender, TagEventArgs e)
        {
            //e.Tag
            foreach(Guest guest in supermanager.SearchPersonRFID(e.Tag))
            {
                tbRentPersonName.Text = guest.Name;
                tbRentItemRFID.Text = guest.RFID;
            }
        }
        void rfid_TagLost(object sender, TagEventArgs e)
        {
            // Add code here for when a tag is no longen in the scanner range.
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            rfid.Attach -= new AttachEventHandler(rfid_Attach);
            rfid.Detach -= new DetachEventHandler(rfid_Detach);
            rfid.Tag -= new TagEventHandler(rfid_Tag);
            rfid.TagLost -= new TagEventHandler(rfid_TagLost);

            //run any events in the message queue - otherwise close will hang if there are any outstanding events
            Application.DoEvents();

            rfid.close();
        }
        #region Command line open functions
        private void openCmdLine(Phidget p)
        {
            openCmdLine(p, null);
        }
        private void openCmdLine(Phidget p, String pass)
        {
            int serial = -1;
            String logFile = null;
            int port = 5001;
            String host = null;
            bool remote = false, remoteIP = false;
            string[] args = Environment.GetCommandLineArgs();
            String appName = args[0];

            try
            { //Parse the flags
                for (int i = 1; i < args.Length; i++)
                {
                    if (args[i].StartsWith("-"))
                        switch (args[i].Remove(0, 1).ToLower())
                        {
                            case "l":
                                logFile = (args[++i]);
                                break;
                            case "n":
                                serial = int.Parse(args[++i]);
                                break;
                            case "r":
                                remote = true;
                                break;
                            case "s":
                                remote = true;
                                host = args[++i];
                                break;
                            case "p":
                                pass = args[++i];
                                break;
                            case "i":
                                remoteIP = true;
                                host = args[++i];
                                if (host.Contains(":"))
                                {
                                    port = int.Parse(host.Split(':')[1]);
                                    host = host.Split(':')[0];
                                }
                                break;
                            default:
                                goto usage;
                        }
                    else
                        goto usage;
                }
                if (logFile != null)
                    Phidget.enableLogging(Phidget.LogLevel.PHIDGET_LOG_INFO, logFile);
                if (remoteIP)
                    p.open(serial, host, port, pass);
                else if (remote)
                    p.open(serial, host, pass);
                else
                    p.open(serial);
                return; //success
            }
            catch { }
        usage:
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Invalid Command line arguments." + Environment.NewLine);
            sb.AppendLine("Usage: " + appName + " [Flags...]");
            sb.AppendLine("Flags:\t-n   serialNumber\tSerial Number, omit for any serial");
            sb.AppendLine("\t-l   logFile\tEnable phidget21 logging to logFile.");
            sb.AppendLine("\t-r\t\tOpen remotely");
            sb.AppendLine("\t-s   serverID\tServer ID, omit for any server");
            sb.AppendLine("\t-i   ipAddress:port\tIp Address and Port. Port is optional, defaults to 5001");
            sb.AppendLine("\t-p   password\tPassword, omit for no password" + Environment.NewLine);
            sb.AppendLine("Examples: ");
            sb.AppendLine(appName + " -n 50098");
            sb.AppendLine(appName + " -r");
            sb.AppendLine(appName + " -s myphidgetserver");
            sb.AppendLine(appName + " -n 45670 -i 127.0.0.1:5001 -p paswrd");
            MessageBox.Show(sb.ToString(), "Argument Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Application.Exit();
        }
        #endregion
        private void UpdateLb(List<Item> items)
        {
            lbInfo.Items.Clear();
            foreach(Item item in items)
            {
                lbInfo.Items.Add(item);
            }
        }

        private void btnAvaillableItems_Click(object sender, EventArgs e)
        {
            UpdateLb(supermanager.GetAvaillableItems());
        }

        private void btnUnavaillableItems_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();
            foreach (Rental r in supermanager.GetAllRentedItems())
            {
                lbInfo.Items.Add(r);
            }
        }
        /// <summary>
        /// Whenever the tab is changed this changes the info in the gui.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedIndex == 0)
                {
                    UpdateLb(supermanager.GetAvaillableItems());
                    lbInfo.SelectedIndex = 0;
                }
                else if (tabControl.SelectedIndex == 1)
                {
                    lbInfo.Items.Clear();
                    foreach (Rental r in supermanager.GetAllRentedItems())
                    {
                        lbInfo.Items.Add(r);
                    }
                    try
                    {
                        lbInfo.SelectedIndex = 0;
                    }
                    catch
                    {
                        return;
                    }
                }
                else if (tabControl.SelectedIndex == 2)
                {
                    UpdateLb(supermanager.GetAllItems());
                }
                else if (tabControl.SelectedIndex == 3)
                {
                    UpdateLb(supermanager.GetAllItems());
                    lbInfo.SelectedIndex = 0;
                    Item item = lbInfo.SelectedItem as Item;
                    tbChangeName.Text = item.Name.ToString();
                    tbChangePrice.Text = item.Price.ToString();
                    tbChangeType.Text = item.Type.ToString();
                    tbChangeCount.Text = item.Stock.ToString();
                }
                else if (tabControl.SelectedIndex == 4)
                {
                    lbInfo.Items.Clear();
                    foreach (Guest guest in supermanager.GetAllGuests())
                    {
                        lbInfo.Items.Add(guest);
                    }
                    try
                    {
                        lbInfo.SelectedIndex = 0;
                    }
                    catch
                    {
                        lbInfo.Items.Add("Niemand Aanwezig");
                    }
                }
            }
            catch { }
        }
        /// <summary>
        /// Whenever an object in the listbox is selected this updates the gui.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = lbInfo.SelectedItem as Item;
            if(tabControl.SelectedIndex == 0)
            {
                tbRentItemID.Text = item.ID.ToString();
            }
            else if(tabControl.SelectedIndex == 1)
            {

            }
            else if (tabControl.SelectedIndex == 2)
            {
                tbAddName.Text = item.Name;
                tbAddPrice.Text = item.Price.ToString();
                tbAddStock.Text = item.Stock.ToString();
                tbAddType.Text = item.Type;
            }
            else if(tabControl.SelectedIndex == 3)
            {
                tbChangeName.Text = item.Name;
                tbChangePrice.Text = item.Price.ToString();
                tbChangeType.Text = item.Type;
                tbChangeCount.Text = item.Stock.ToString();
            }
            else if(tabControl.SelectedIndex == 4)
            {
            }
        }

        private void btnArtikelPasAan_Click(object sender, EventArgs e)
        {
            int index = lbInfo.SelectedIndex;
            try
            {
                Convert.ToInt32(tbChangeCount.Text);
                Convert.ToDecimal(tbAddPrice.Text);
            }
            catch
            {
                MessageBox.Show("Voer geldige data in aub");
                return;
            }
            try
            {
                Item item = lbInfo.SelectedItem as Item;
                List<string> Iteminfo = new List<string>();
                string id = item.ID.ToString();
                string name = tbChangeName.Text;
                string type = tbChangeType.Text;
                string stock = tbChangeCount.Text;
                string price = tbChangePrice.Text;
                Iteminfo.Add(name);
                Iteminfo.Add(type);
                Iteminfo.Add(stock);
                Iteminfo.Add(price);
                supermanager.ChangeItem(Iteminfo, id);
                UpdateLb(supermanager.GetAllItems());
                MessageBox.Show("Artikel Veranderd");
            }
            catch
            {
                MessageBox.Show("Selecteer een item, aub.");
            }
            lbInfo.SelectedIndex = index;
        }

        private void btnArtikelVerwijder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u dit item volledig wilt verwijderen?", "item verwijderen", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int index = lbInfo.SelectedIndex;
                    supermanager.DeleteItem(lbInfo.SelectedItem as Item);
                    UpdateLb(supermanager.GetAllItems());
                    lbInfo.SelectedIndex = index;
                }
                catch
                {
                    return;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Item item = lbInfo.SelectedItem as Item;
            string endDate = dtpRentItemEndDate.Value.ToShortDateString();
            string amount = tbRentCount.Text;
            try
            {
                Convert.ToInt32(amount);
            }
            catch
            {
                MessageBox.Show("Voer een geldig aantal in");
                return;
            }
            bool succes = false;
            try
            {
                foreach (Guest guest in supermanager.SearchPersonRFID(tbRentItemRFID.Text))
                {
                    if (item.Stock < Convert.ToInt32(amount))
                    {
                        MessageBox.Show("Niet voldoende in voorraad");
                        return;
                    }
                    supermanager.RentItem(item, guest, endDate, amount);
                    UpdateLb(supermanager.GetAvaillableItems());
                    lbInfo.SelectedIndex = 0;
                    succes = true;
                }
            }
            catch
            {
                MessageBox.Show("Selecteer een item");
                return;
            }
            if (succes)
            {
                MessageBox.Show("Item uitgeleend!");
            }
            else
            {
                MessageBox.Show("Selecteer een gast");
            }
        }

        private void btnTakeRental_Click(object sender, EventArgs e)
        {
            try
            {
                Rental rental = lbInfo.SelectedItem as Rental;
                supermanager.TakeRental(rental.ID.ToString());
                Item item = supermanager.GetItem(rental.ItemID.ToString());
                int newStock = item.Stock + rental.Amount;
                List<string> info = new List<string>();
                info.Add(item.Name);
                info.Add(item.Type);
                info.Add(newStock.ToString());
                info.Add(item.Price.ToString());
                supermanager.ChangeItem(info, item.ID.ToString());
                lbInfo.Items.Clear();
                foreach (Rental r in supermanager.GetAllRentedItems())
                {
                    lbInfo.Items.Add(r);
                }
            }
            catch
            {
                MessageBox.Show("Kies een lening");
            }
            try
            {
                lbInfo.SelectedIndex = 0;
            }
            catch
            {
                return;
            }

            
        }

        private void btnItemRentSearchPerson_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            string name = tbSearchPerson.Text;
            bool succes = false;
            foreach (Guest guest in supermanager.SearchPersonName(name))
            {
                lbInfo.Items.Clear();
                lbInfo.Items.Add(guest);
                lbInfo.SelectedIndex = 0;
                succes = true;
            }
            if (!succes)
            {
                lbInfo.Items.Clear();
                lbInfo.Items.Add("Niemand gevonden");
            }

        }

        private void btnSearchSelect_Click(object sender, EventArgs e)
        {
            Guest guest = lbInfo.SelectedItem as Guest;
            tbRentPersonName.Text = guest.Name;
            tbRentItemRFID.Text = guest.RFID;
            tabControl.SelectedIndex = 0;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
