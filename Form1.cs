using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using System.IO.Ports;

namespace Display_set
{
    public partial class Form1 : Form
    {
        const string OutputVID = "1A86", OutputPID = "7523";
        string rec_data = "";

        string UsbPortName;
        bool UsbDetected = false;

        public const string _DISPLAY_BLINK = "d";
        public const string _DISPLAY = "u";
        public const string _CLOSE = "c";
        public const string _OPEN = "o";
        public const string _CLEAR = "r";

        public Form1()
        {
            InitializeComponent();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            string text = txtMsg.Text;
            if (text.Length >=0)
            {
                display(text);
            }
            else
            {
                MessageBox.Show("الرجاء إدخال صيغة صحيحة","تنبيه",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
            }
        }

        private void btnSend2_Click(object sender, EventArgs e)
        {
            string adress = nudAddress.Text;
            string param = nudNumber.Text;
            Symbole sb = (Symbole)(cbSymbol.SelectedItem);

            display(nudAddress.Text, sb.s, cbChar.Text + nudNumber.Text);
        }

        void display(string Address, string Symbole, string Param)
        {
            string ToSend = "";
            if (Address.Length == 1)
            {
                Address = "00" + Address;
            }
            else if (Address.Length == 2)
            {
                Address = "0" + Address;
            }
            if (Address.Length == 3)
            {
                if (Symbole == _DISPLAY_BLINK || Symbole == _DISPLAY)
                {
                    ToSend = "*2" + Address + Symbole + Param + "#";
                }
                else if (Symbole == _OPEN || Symbole == _CLOSE || Symbole == _CLEAR)
                {
                    ToSend = "*2" + Address + Symbole + "0000#";
                }
            }
            if (USB.IsOpen)
            {
                USB.WriteLine(ToSend);
            }
            else
            {
                MessageBox.Show("غير متصل بالمأخذ", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        public void display(string ToSend)
        {
            if (USB.IsOpen)
            {
                USB.WriteLine(ToSend);
            }
            else
            {
                MessageBox.Show("غير متصل بالمأخذ", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //nextIdPhraseLbl.Visible = false;
            //nextIdLbl.Visible = false;
            
            //cbSymbol.Items.Add(new Symbole("d", "Display"));
            //cbSymbol.Items.Add(new Symbole("u", "Update"));
            //cbSymbol.Items.Add(new Symbole("c", "Close"));
            //cbSymbol.Items.Add(new Symbole("o", "Open"));
            //cbSymbol.Items.Add(new Symbole("r", "Erase"));

            cbSymbol.Items.Add(new Symbole(_DISPLAY_BLINK, "إظهار"));
            cbSymbol.Items.Add(new Symbole(_DISPLAY, "تحديث"));
            cbSymbol.Items.Add(new Symbole(_CLOSE, "مغلق"));
            cbSymbol.Items.Add(new Symbole(_OPEN, "مفتوح"));
            cbSymbol.Items.Add(new Symbole(_CLEAR, "محو"));
            cbSymbol.SelectedIndex = 0;

            cbChar.SelectedIndex = 0;
            
        }

        private void USB_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            rec_data += USB.ReadExisting();
            System.Console.WriteLine(rec_data);

            if (rec_data.Contains("nextid=") && rec_data.Split('=')[1].Contains("\n"))
            {
                String nextId = rec_data.Split('=')[1].Split('.')[0];
                this.Invoke(new MethodInvoker(delegate ()
                {
                    nextIdLbl.Text = "";
                    nextIdLbl.Text = nextId;
                    if (!nextIdPhraseLbl.Visible)
                    {
                        nextIdPhraseLbl.Visible = true;
                        nextIdLbl.Visible = true;
                    }
                }));
                rec_data = "";
            }
        }

        private void txtMsg_Enter(object sender, EventArgs e)
        {
            if (txtMsg.Text.Equals("2003dA555") || txtMsg.Text.Equals(""))
            {
                //txtMsg.ForeColor = Color.Gray;
                txtMsg.ForeColor = Color.Black;
                txtMsg.Text = "";
            }
        }

        private void txtMsg_Leave(object sender, EventArgs e)
        {
            if (txtMsg.Text.Equals("2003dA555"))
            {
                txtMsg.ForeColor = Color.Gray;
            }
            else if (txtMsg.Text.Equals(""))
            {
                txtMsg.ForeColor = Color.Gray;
                txtMsg.Text="2003dA555";
            }
            else
            {
                txtMsg.ForeColor = Color.Black;
            }
        }

        private void tmrUsbCheck_Tick(object sender, EventArgs e)
        {
            try
            {
                String pattern = String.Format("^VID_{0}.PID_{1}", OutputVID, OutputPID);
                Regex _rx = new Regex(pattern, RegexOptions.IgnoreCase);
                RegistryKey rk1 = Registry.LocalMachine;
                RegistryKey rk2 = rk1.OpenSubKey("SYSTEM\\CurrentControlSet\\Enum");
                UsbPortName = null;

                foreach (String s3 in rk2.GetSubKeyNames())
                {
                    RegistryKey rk3 = rk2.OpenSubKey(s3);
                    foreach (String s in rk3.GetSubKeyNames())
                    {
                        if (_rx.Match(s).Success)
                        {
                            RegistryKey rk4 = rk3.OpenSubKey(s);
                            foreach (String s2 in rk4.GetSubKeyNames())
                            {
                                RegistryKey rk5 = rk4.OpenSubKey(s2);
                                string location = (string)rk5.GetValue("LocationInformation");
                                RegistryKey rk6 = rk5.OpenSubKey("Device Parameters");
                                string portName = (string)rk6.GetValue("PortName");
                                bool t = false;
                                foreach (string p in SerialPort.GetPortNames())
                                {
                                    if (p == portName)
                                        t = true;
                                }
                                if (!String.IsNullOrEmpty(portName) && t)
                                {
                                    UsbPortName = (string)rk6.GetValue("PortName");
                                    USB.PortName = UsbPortName;
                                   
                                }
                            }
                        }
                    }
                }
                UsbDetected = !String.IsNullOrEmpty(UsbPortName);
                if (UsbDetected)
                {
                    img_usb.BackgroundImage = Display_set.Properties.Resources.usb_gold;
                    lblPort.Text = UsbPortName;
                    lblPort.Visible = true;
                }
                else
                {
                    img_usb.BackgroundImage = Display_set.Properties.Resources.usb_black;
                    lblPort.Visible = false;
                }
                    if (!USB.IsOpen)
                    try
                    {
                        USB.Open();
                    }
                    catch 
                    {

                    }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }
    }
}
