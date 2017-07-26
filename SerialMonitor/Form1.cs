using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialMonitor
{
    public partial class Form1 : Form
    {

        public static readonly String[] BAUDS = { "9600", "11200" };

        public Form1()
        {
            InitializeComponent();
            setAvailablePorts();
            setBaudSelect();

            device.DataReceived += new SerialDataReceivedEventHandler(serialPortDataRecieved);
        }

        private void serialPortDataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            Invoke(new EventHandler(DisplaySerialData));
        }

        private void DisplaySerialData(object sender, EventArgs e)
        {
            receivedTextBox.AppendText(device.ReadExisting());
        }

        private void disconnectDevice()
        {
            if (device.IsOpen)
            {
                device.Close();

            }
        }

        private void setAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            portSelect.Items.AddRange(ports);
        }

        private void setBaudSelect()
        {
            baudSelect.Items.AddRange(BAUDS);
        }

        private void checkPortSettings()
        {
            bool portSelected = !string.IsNullOrWhiteSpace(portSelect.Text);
            bool baudSelected = !string.IsNullOrWhiteSpace(baudSelect.Text);

            if (portSelected && baudSelected)
            {
                connectButton.Enabled = true;
            } else
            {
                connectButton.Enabled = false;
            }
        }

        private void Form1_FormClosing(Object sender, FormClosedEventArgs e)
        {
            disconnectDevice();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            setAvailablePorts();
        }

        private void portSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkPortSettings();
        }

        private void baudSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkPortSettings();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            device.PortName = portSelect.SelectedItem.ToString();
            device.BaudRate = Convert.ToInt32(baudSelect.SelectedItem);
            device.Open();
            disconnectButton.Enabled = true;
            connectButton.Enabled = false;
            portSelect.Enabled = false;
            baudSelect.Enabled = false;
            scanButton.Enabled = false;
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            disconnectDevice();
            disconnectButton.Enabled = false;
            portSelect.Enabled = true;
            baudSelect.Enabled = true;
            scanButton.Enabled = true;
        }
    }
}
