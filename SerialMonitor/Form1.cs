using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
            setDefaultSettings();

            device.DataReceived += new SerialDataReceivedEventHandler(serialPortDataRecieved);

            testChart.Series["testPoints"].Points.AddXY(1, 1);
            testChart.Series["testPoints"].Points.AddXY(2, 2);
            testChart.Series["testPoints"].Points.AddXY(3, 3);
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

        private void setDefaultSettings()
        {
            if (portSelect.Items.Count > 0)
            {
                portSelect.SelectedIndex = 0;
            }

            baudSelect.SelectedIndex = 0;
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
            sendDataButton.Enabled = true;
            sendDataTextbox.Enabled = true;
            connectButton.Enabled = false;
            portSelect.Enabled = false;
            baudSelect.Enabled = false;
            scanButton.Enabled = false;
            sendDataTextbox.Focus();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            disconnectDevice();
            disconnectButton.Enabled = false;
            sendDataTextbox.Enabled = false;
            sendDataButton.Enabled = false;
            connectButton.Enabled = true;
            portSelect.Enabled = true;
            baudSelect.Enabled = true;
            scanButton.Enabled = true;
        }

        private void sendDataButton_Click(object sender, EventArgs e)
        {
            if (device.IsOpen)
            {
                device.Write(sendDataTextbox.Text);
                sendDataTextbox.Text = "";
            }
            sendDataTextbox.Focus();
        }
    }
}
