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
            List<string> Iteminfo = new List<string>();
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
            string message = tbAddName.Text + " added.";
            lbInfo.Items.Add(message);
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
        void rfid_Tag(object sender, TagEventArgs e)
        {
            string RFIDtag = e.Tag;
            tbAddStock.Text = RFIDtag;
        }
        void rfid_TagLost(object sender, TagEventArgs e)
        {
            //  eventuele codes
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

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Item item in supermanager.GetAllItems())
            {
                lbInfo.Items.Add(item);
            }
        }

        private void btnClearLb_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();
        }
    }
}
