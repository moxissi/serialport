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
using System.Threading;
using System.IO;


namespace comporttest
{
    public partial class Form1 : Form
    {
        private static string filePath = string.Empty;
        public Form1()
        {
            InitializeComponent();
            //Search for available COM ports
            string[] ports = SerialPort.GetPortNames();
            //Set status backgroud color to RED
            toolStripStatusLabel1.BackColor = Color.Red;
            ts_LogStatus.BackColor = Color.Tomato;
            //Add available COM ports
            foreach (string port in ports)
            {
                //listBox1.Items.Add(port);
                cb_Ports.Items.Add(port);
            }

            //CHECK IF SOME PORT IS AVAILABLE
            if (ports.Length>0)
            {
                cb_Ports.SelectedIndex = 0;
            }
            //SET BAUD RATE TO 115200
            cb_BaudRate.SelectedIndex = 7;
        }


        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            tb_Data.AppendText(value);

            //IF ENABLED LOG DATA
            if (cb_EnableLog.Checked)
            {
                if (File.Exists(filePath))
                {
                    File.AppendAllText(filePath, "OUTPUT: " + value);
                }
            }
        }

        //DISPLAY INCOMING DATA
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            AppendTextBox(serialPort1.ReadLine().ToString() + Environment.NewLine);
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (btn_Connect.Text == "Connect")
            {
                serialPort1.PortName = cb_Ports.SelectedItem.ToString();
                try
                {
                    serialPort1.Open();
                    btn_Connect.Text = "Disconnect";
                    toolStripStatusLabel1.Text = "Connected " + serialPort1.PortName.ToString();
                    toolStripStatusLabel1.BackColor = Color.Green;
                }
                catch (Exception)
                {
                    MessageBox.Show("Connection to " + serialPort1.PortName.ToString() + " port failed.", "Connection error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else if (btn_Connect.Text == "Disconnect")
            {
                try
                {
                    serialPort1.Close();
                    toolStripStatusLabel1.Text = "Disconected";
                    toolStripStatusLabel1.BackColor = Color.Red;
                    btn_Connect.Text = "Connect";
                }
                catch
                {
                    MessageBox.Show("Disconnecting " + serialPort1.PortName.ToString() + " port failed.", "Disconnection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            
            cb_Ports.Items.Clear();
            
            //SEARCH FOR ALL AVAILABLE SERIAL PORTS
            foreach (string port in ports)
            {
                if (!cb_Ports.Items.Contains(port))
                {
                    cb_Ports.Items.Add(port);
                }

            }

            //CHECK IF SOME PORT IS AVAILABLE
            if (ports.Length > 0)
            {
                cb_Ports.SelectedIndex = 0;
            }
        }

        private void btn_SendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(tb_SendData.Text + Environment.NewLine);
                
                if (cb_EnableLog.Checked)
                {
                    if (File.Exists(filePath))
                    {
                        File.AppendAllText(filePath, "INPUT: " + tb_SendData.Text + Environment.NewLine);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nothing port opened!", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Data.Text = "";
        }

        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                tb_LogFilePath.Text = filePath;
            }
        }

        private void cb_EnableLog_Click(object sender, EventArgs e)
        {
            if (ts_LogStatus.Text == "Log enabled")
            {
                ts_LogStatus.Text = "Log disabled";
                ts_LogStatus.BackColor = Color.Tomato;
            }
            else if (ts_LogStatus.Text == "Log disabled")
            {
                if (!filePath.Contains(".txt"))
                {
                    MessageBox.Show("First you need select .txt log file!", "Log error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cb_EnableLog.Checked = false;
                }
                else
                {
                    ts_LogStatus.Text = "Log enabled";
                    ts_LogStatus.BackColor = Color.SpringGreen;
                }
            }
        }
    }
}
