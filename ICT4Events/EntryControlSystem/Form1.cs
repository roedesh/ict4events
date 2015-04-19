using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountLibrary; // From the Account library
using DataLibrary; // From the data library
using Phidgets; //Needed for the RFID class and the PhidgetException class
using Phidgets.Events; //Needed for the phidget event handling classes

namespace EntryControlSystem
{
    public partial class Form1 : Form
    {
        private RFID rfid;
        private SuperManager supermanager;
        private List<Guest> Guests;
        public Form1()
        {
            InitializeComponent();
            supermanager = new SuperManager();
            Guests = new List<Guest>();
        }
        /// <summary>
        /// Show all the present guests.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToonAanwezigen_Click(object sender, EventArgs e)
        {
            try
            {
                Guests = supermanager.ShowAllPresent();
                UpdateLb();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Update the listbox with all the present guests.
        /// </summary>
        private void UpdateLb()
        {
            // put list with guests into listbox
            lbInfo.Items.Clear();
            foreach (Guest guest in Guests)
            {
                lbInfo.Items.Add(guest);
            }
            try
            {
                lbInfo.SelectedItem = lbInfo.Items[0];
            }
            catch
            {
                tbRFID.Text = "";
                pbBetaalstatus.BackColor = Color.FromArgb(255, 255, 255);
                MessageBox.Show("Niemand gevonden");
            }
        }
        /// <summary>
        /// Search a person via name or id.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZoekPersoon_Click(object sender, EventArgs e)
        {
            try
            {
                Guests = supermanager.ShowSearchedPerson(tbSearch.Text);
                UpdateLb();
            }
            catch
            {
                lbInfo.Items.Clear();
                MessageBox.Show("Geen gasten gevonden");
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();
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
        /// Update the gui when a tag is found.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void rfid_Tag(object sender, TagEventArgs e)
        {
            string RFIDtag = e.Tag;
            Guests = supermanager.SearchPersonRFID(RFIDtag);
            UpdateLb();
        }

        void rfid_TagLost(object sender, TagEventArgs e)
        {
            //  Add code here for when the tag is no longer within the scanners reach.
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

        //Parses command line arguments and calls the appropriate open
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

        /// <summary>
        /// Update a guest depending on his initial presence status.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPersoonToelaten_Click(object sender, EventArgs e)
        {
            if(lbInfo.SelectedItem != null)
            {
                Guest guest = lbInfo.SelectedItem as Guest;
                string accountID = guest.ID.ToString();
                string guestID = guest.GuestID.ToString();
                string RFID = guest.RFID;
                string isPresent = guest.IsPresent;
                if(guest.IsPresent == "Y")
                {
                    supermanager.UpdatePresence(guestID,accountID,RFID, "N");
                }
                else if(guest.IsPresent == "N")
                {
                    supermanager.UpdatePresence(guestID, accountID, RFID, "Y");
                }
                lbInfo.Items.Clear();
                
            }
        }
        /// <summary>
        /// Update the gui whenever something in the listbox is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guest guest = lbInfo.SelectedItem as Guest;
            // check if selected has paid
            string RFIDtag = guest.RFID;
            tbRFID.Text = guest.RFID;
            bool hasPaid = supermanager.CheckPayment(RFIDtag);
            if (hasPaid)
            {
                pbBetaalstatus.BackColor = Color.FromArgb(0, 255, 0);
            }
            else
            {
                pbBetaalstatus.BackColor = Color.FromArgb(255, 0, 0);
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
