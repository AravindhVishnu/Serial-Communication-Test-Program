﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SerialCommTestApplication
{
    // Program used to test the serial communication with an embedded device.
    // Can work both as a master or slave. In master mode, the program sends
    // a byte and expects the slave to send back the inverted byte. In slave mode,
    // the program receives the byte and sends the inverted value. If read/write
    // timeout occurs or a wrong value is received, this is logged to a file.
    public partial class Form1 : Form
    {
        internal ComPorts myComPort = new ComPorts();
        internal Common CommonVar = new Common();

        private bool _control;
        private byte _cnt;
        private Int32 _update_cnt;
        private bool _com_running;

        private const Int32 UPDATE_INTERVAL = 200;

        private MemoryStream _com_log_stream;

        // Delegates needed for the InvokeRequired code pattern which is useful in
        // multi threaded event driven GUI code
        public delegate void GUIAdd(string paramString);
        public delegate void GUIClear();
        public delegate void Label1Add(string paramString);
        public delegate void Label2Add(string paramString);

        public Form1()
        {
            // Autogenerated code for the design of the GUI
            InitializeComponent();
        }

        public void DoGUIClear()
        {
            if (this.InvokeRequired)
            {
                GUIClear delegateMethod = new GUIClear(this.DoGUIClear);
                this.Invoke(delegateMethod);
            }
            else
            {
                this.listBox1.Items.Clear();
                this.listBox1.TopIndex = this.listBox1.Items.Count - 1;
            }
        }

        public void DoGUIAdd(string paramString)
        {
            if (this.InvokeRequired)
            {
                GUIAdd delegateMethod = new GUIAdd(this.DoGUIAdd);
                this.Invoke(delegateMethod, new object[] { paramString });
            }
            else
            {
                this.listBox1.Items.Add(paramString);

                ++_update_cnt;
                if (_update_cnt >= UPDATE_INTERVAL)
                {
                    this.listBox1.TopIndex = this.listBox1.Items.Count - 1;
                    _update_cnt = 0;
                }
            }
        }

        public void DoLabel1Add(string paramString)
        {
            if (this.InvokeRequired)
            {
                Label1Add delegateMethod = new Label1Add(this.DoLabel1Add);
                this.Invoke(delegateMethod, new object[] { paramString });
            }
            else
            {
                this.LATEST_INCORRECT_DATA_LABEL.Text = paramString;
            }
        }

        public void DoLabel2Add(string paramString)
        {
            if (this.InvokeRequired)
            {
                Label2Add delegateMethod = new Label2Add(this.DoLabel2Add);
                this.Invoke(delegateMethod, new object[] { paramString });
            }
            else
            {
                LATEST_READ_TIMEOUT_LABEL.Text = paramString;
            }
        }

        private void port_settings_Click(object sender, EventArgs e)
        {
            Form2 portSettings = new Form2(this);
            portSettings.ShowDialog();
        }

        private void open_port_Click(object sender, EventArgs e)
        {
            if (CommonVar.ConfigDone == true)
            {
                if (myComPort.open_port())
                {
                    listBox1.Items.Add("Port " + myComPort.PortName + " opened");
                    listBox1.Items.Add("");
                    this.listBox1.TopIndex = this.listBox1.Items.Count - 1;
                    STATUS_LABEL.Text = "Open;";
                }
                else
                {
                    listBox1.Items.Add("Error - Port " + myComPort.PortName + " not opened");
                    listBox1.Items.Add("");
                    this.listBox1.TopIndex = this.listBox1.Items.Count - 1;
                }
            }
            else
            {
                listBox1.Items.Add("Error - Configure port before opening it");
                listBox1.Items.Add("");
            }
        }

        private void close_port_Click(object sender, MouseEventArgs e)
        {
            if (CommonVar.ConfigDone == true)
            {
                if (myComPort.close_port())
                {
                    listBox1.Items.Add("Port " + myComPort.PortName + " closed");
                    listBox1.Items.Add("");
                    this.listBox1.TopIndex = this.listBox1.Items.Count - 1;
                    STATUS_LABEL.Text = "Closed;";
                }
                else
                {
                    listBox1.Items.Add("Error - Port " + myComPort.PortName + " not closed");
                    listBox1.Items.Add("");
                    this.listBox1.TopIndex = this.listBox1.Items.Count - 1;
                }
            }
            else
            {
                listBox1.Items.Add("Error - First configure the port");
                listBox1.Items.Add("");
            }
        }

        private void FORM1_CLOSING(object sender, FormClosingEventArgs e)
        {
            // Intercepting Application exit and close the port (if it is open)
            myComPort.close_port();
            _com_log_stream.Dispose();

            // Store user parameters in the Settings.settings database
            Properties.Settings.Default.PortName = this.myComPort.PortName;
            Properties.Settings.Default.BaudRate = this.myComPort.BaudRate;
            Properties.Settings.Default.Parity = this.myComPort.Parity;
            Properties.Settings.Default.DataBits = this.myComPort.DataBits;
            Properties.Settings.Default.StopBits = this.myComPort.StopBits;
            Properties.Settings.Default.ReadTimeout = this.myComPort.ReadTimeout;
            Properties.Settings.Default.WriteTimeout = this.myComPort.WriteTimeout;
            Properties.Settings.Default.MasterEnabled = _control;
            Properties.Settings.Default.Save();

            // Store the program exit time in the event log file
            DateTime time_now = DateTime.Now;
            string time_now_text = time_now.ToString();
            string text = "Program exit at: " + time_now_text;
            Trace.WriteLine(text, "COM port terminal");
            Trace.Flush();
            Trace.Close();

            // Clear list box
            this.DoGUIClear();
        }

        private void FORM1_LOAD(object sender, EventArgs e)
        {
            // Store the program start time in the event log file
            DateTime time_now = DateTime.Now;
            string time_now_text = time_now.ToString();
            string text = "Program start at: " + time_now_text;
            Trace.WriteLine(text, "COM port terminal");

            // Reduce/prevent flicker when the list box is updated
            this.DoubleBuffered = true;

            // Read user parameter values from Settings.settings database
            PORT_NAME_LABEL.Text = Properties.Settings.Default.PortName + ";";
            STATUS_LABEL.Text = "Closed;";
            BITRATE_LABEL.Text = Properties.Settings.Default.BaudRate.ToString() + ";";
            switch (Properties.Settings.Default.Parity)
            {
                case System.IO.Ports.Parity.None:
                    PARITY_LABEL.Text = "None;";
                    break;
                case System.IO.Ports.Parity.Odd:
                    PARITY_LABEL.Text = "Odd;";
                    break;
                case System.IO.Ports.Parity.Even:
                    PARITY_LABEL.Text = "Even;";
                    break;
                case System.IO.Ports.Parity.Mark:
                    PARITY_LABEL.Text = "Mark;";
                    break;
                case System.IO.Ports.Parity.Space:
                    PARITY_LABEL.Text = "Space;";
                    break;
                default:
                    PARITY_LABEL.Text = "Unknown;";
                    break;
            }
            switch (Properties.Settings.Default.StopBits)
            {
                case System.IO.Ports.StopBits.None:
                    STOP_BITS_LABEL.Text = "None;";
                    break;
                case System.IO.Ports.StopBits.One:
                    STOP_BITS_LABEL.Text = "1;";
                    break;
                case System.IO.Ports.StopBits.Two:
                    STOP_BITS_LABEL.Text = "2;";
                    break;
                case System.IO.Ports.StopBits.OnePointFive:
                    STOP_BITS_LABEL.Text = "1.5;";
                    break;
                default:
                    STOP_BITS_LABEL.Text = "Unknown;";
                    break;
            }
            DATA_BITS_LABEL.Text = Properties.Settings.Default.DataBits.ToString() + ";";
            READ_TIMEOUT_LABEL.Text = Properties.Settings.Default.ReadTimeout.ToString() + ";";
            WRITE_TIMEOUT_LABEL.Text = Properties.Settings.Default.WriteTimeout.ToString() + ";";
            LATEST_INCORRECT_DATA_LABEL.Text = "No incorrect data recived";
            LATEST_READ_TIMEOUT_LABEL.Text = "No read timeouts detected";
            if (Properties.Settings.Default.MasterEnabled)
            {
                CONTROL_MODE_LABEL.Text = "Master;";
                button6.ForeColor = System.Drawing.Color.DarkBlue;
                button7.ForeColor = System.Drawing.Color.Black;
                _control = true;
            }
            else
            {
                CONTROL_MODE_LABEL.Text = "Slave;";
                button6.ForeColor = System.Drawing.Color.Black;
                button7.ForeColor = System.Drawing.Color.DarkBlue;
                _control = false;
            }
            _cnt = 0;
            _update_cnt = 0;
            _com_running = false;
            _com_log_stream = new MemoryStream(0);
        }

        private void stop_button_Click(object sender, MouseEventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void start_button_Click(object sender, MouseEventArgs e)
        {
            if (myComPort.is_open())
            {
                if (!backgroundWorker1.IsBusy)
                {
                    _com_running = true;
                    backgroundWorker1.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Communication already enabled");
                }
            }
            else
            {
                MessageBox.Show("Open port before starting the communication");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Int32 data_sent;
            Int32 data_sent_inverted;
            Int32 data_received;
            byte[] data_to_read = new byte[1];
            byte[] data_to_send = new byte[1];
            byte[] data_to_send_back = new byte[1];
            String compare;
            Int32 comm_fail_cnt = 0;
            Int32 read_timeout_cnt = 0;
            Int32 data_inverted = 0;
            bool com_status = false;
            String text = "";
            _cnt = 0;
            _update_cnt = UPDATE_INTERVAL;

            StreamWriter com_log_stream_writer = new StreamWriter(_com_log_stream);
            DateTime time_now = DateTime.Now;
            String time_now_text = time_now.ToString();
            text = "Communication started at: " + time_now_text;
            com_log_stream_writer.WriteLine(text);
            com_log_stream_writer.Flush();
            DoGUIAdd(text);
            Trace.WriteLine(text, "COM port terminal");

            // Clear read and write buffers
            myComPort.clear_read_buffer();
            myComPort.clear_write_buffer();

            while (e.Cancel == false)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    time_now = DateTime.Now;
                    time_now_text = time_now.ToString();
                    text = "Communication stopped at: " + time_now_text;
                    _update_cnt = UPDATE_INTERVAL;
                    DoGUIAdd(text);
                    Trace.WriteLine(text, "COM port terminal");
                    com_log_stream_writer.WriteLine(text);
                    com_log_stream_writer.Flush();
                    e.Cancel = true;
                    break;
                }
                else
                {
                    if (_control == false)  // Slave program
                    {
                        // Wait for data to be received
                        com_status = myComPort.read_message(ref data_to_read, 0, 1);
                        if (com_status == false)
                        {
                            ++read_timeout_cnt;
                            time_now = DateTime.Now;
                            time_now_text = time_now.ToString();
                            DoLabel2Add(time_now_text);
                            _update_cnt = UPDATE_INTERVAL;
                            text = myComPort.ComStatus + " Number of read timeouts: " + Convert.ToString(read_timeout_cnt) + "; " + "Read timeout occurred at: " + time_now_text + ";";
                            com_log_stream_writer.WriteLine(text);
                            com_log_stream_writer.Flush();
                            DoGUIAdd(text);
                        }
                        else
                        {
                            data_received = Convert.ToInt32(data_to_read[0]);

                            // Invert data
                            data_inverted = ~data_received & 0x000000FF;

                            // Send the inverted data
                            data_to_send_back[0] = Convert.ToByte(data_inverted);

                            com_status = myComPort.send_message(data_to_send_back, 0, 1);
                            if (com_status == false)
                            {
                                DoGUIAdd(myComPort.ComStatus);
                            }

                            // Output text
                            text = "Sent data: " + "0x" + data_to_send_back[0].ToString("X") + "; " + "Received data: " + "0x" + data_to_read[0].ToString("X") + ",";
                            DoGUIAdd(text);
                        }
                    }
                    else  // Master program
                    {
                        data_sent = Convert.ToInt32(_cnt);
                        data_sent_inverted = ~data_sent & 0x000000FF;
                        data_to_send[0] = _cnt;

                        // Send data 
                        com_status = myComPort.send_message(data_to_send, 0, 1);
                        if (com_status == false)
                        {
                            DoGUIAdd(myComPort.ComStatus);
                        }

                        // Wait for data to be received
                        com_status = myComPort.read_message(ref data_to_read, 0, 1);
                        if (com_status == false)
                        {
                            ++read_timeout_cnt;
                            time_now = DateTime.Now;
                            time_now_text = time_now.ToString();
                            DoLabel2Add(time_now_text);
                            _update_cnt = UPDATE_INTERVAL;
                            text = myComPort.ComStatus + " Number of read timeouts: " + Convert.ToString(read_timeout_cnt) + "; " + "Read timeout occurred at: " + time_now_text + ";";
                            com_log_stream_writer.WriteLine(text);
                            com_log_stream_writer.Flush();
                            DoGUIAdd(text);
                        }
                        else
                        {
                            data_received = Convert.ToInt32(data_to_read[0]);

                            // Check if data has been inverted
                            if (data_sent_inverted == data_received)
                            {
                                compare = "Correct data received; ";
                            }
                            else
                            {
                                compare = "Incorrect data received; ";
                                ++comm_fail_cnt;
                            }

                            // The values 0-255 are to be sent
                            ++_cnt;

                            // Output text
                            text = "Sent data: " + "0x" + data_to_send[0].ToString("X") + "; " + "Received data: " + "0x" + data_to_read[0].ToString("X") + ", " + compare + "Number of incorrect data received: " + Convert.ToString(comm_fail_cnt) + "; " + "Number of read timeouts: " + Convert.ToString(read_timeout_cnt) + ";";
                            DoGUIAdd(text);

                            if (data_sent_inverted != data_received)
                            {
                                time_now = DateTime.Now;
                                time_now_text = time_now.ToString();
                                DoLabel1Add(time_now_text);
                                _update_cnt = UPDATE_INTERVAL;
                                text = "Incorrect data received at: " + time_now_text + ";";
                                com_log_stream_writer.WriteLine(text);
                                com_log_stream_writer.Flush();
                                DoGUIAdd(text);
                            }
                        }
                    }
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _com_running = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _control = true;
            CONTROL_MODE_LABEL.Text = "Master;";
            button6.ForeColor = System.Drawing.Color.DarkBlue;
            button7.ForeColor = System.Drawing.Color.Black;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _control = false;
            CONTROL_MODE_LABEL.Text = "Slave;";
            button7.ForeColor = System.Drawing.Color.DarkBlue;
            button6.ForeColor = System.Drawing.Color.Black;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Check if communication is running
            if (_com_running == false)
            {
                if (_com_log_stream.Length != 0)
                {
                    {
                        // Create a file stream
                        FileStream my_file = new FileStream("C:\\Temp\\com_log.txt", FileMode.Create, FileAccess.Write);

                        // Copy all data from MemoryStream to FileStream
                        _com_log_stream.WriteTo(my_file);
                        my_file.Flush();
                        my_file.Close();
                        _com_log_stream.SetLength(0);
                    }

                    {
                        // Add info in the end
                        StreamWriter my_file = new StreamWriter("C:\\Temp\\com_log.txt", true);
                        DateTime time_now = DateTime.Now;
                        String time_now_text = time_now.ToString();
                        String text = "File created at: " + time_now_text;
                        my_file.WriteLine();
                        my_file.WriteLine(text);
                        my_file.WriteLine("Port name: " + PORT_NAME_LABEL.Text);
                        my_file.WriteLine("Bit rate: " + BITRATE_LABEL.Text);
                        my_file.WriteLine("Parity: " + PARITY_LABEL.Text);
                        my_file.WriteLine("Stop bits: " + STOP_BITS_LABEL.Text);
                        my_file.WriteLine("Data bits: " + DATA_BITS_LABEL.Text);
                        my_file.WriteLine("Read timeout time [ms]: " + READ_TIMEOUT_LABEL.Text);
                        my_file.WriteLine("Write timeout time [ms]: " + WRITE_TIMEOUT_LABEL.Text);
                        my_file.Flush();
                        my_file.Close();
                    }

                    listBox1.Items.Add("Communication log saved in file");
                    listBox1.Items.Add("");
                    _update_cnt = UPDATE_INTERVAL;

                    // After storing give messagebox that informs the user that data has been stored to a file
                    MessageBox.Show("Communication log data is saved");
                }
                else
                {
                    // Give a message box that informs the user that there are no incorrect data received/read timeouts
                    MessageBox.Show("No read timeouts or incorrect data received have occurred");
                }

            }
            else
            {
                // Give a message box that informs the user to stop the communication before storing the log to a file
                MessageBox.Show("Stop the communication before creating a log file");
            }
        }
    }
}