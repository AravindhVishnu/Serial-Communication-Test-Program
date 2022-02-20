using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialCommTestApplication
{
    using System.IO;
    using System.IO.Ports;

    // This class is a wrapper around the System.IO.Ports.SerialPort class
    class ComPorts
    {
        private SerialPort _selected_port;
        internal static String[] _name_array;
        private String _com_status;
        bool _com_port_detected;

        public ComPorts()
        {
            _selected_port = new SerialPort();
            init_config();
        }

        ~ComPorts()
        {
        }

        internal SerialPort SelectedPort
        {
            get
            {
                return _selected_port;
            }
            set
            {
                _selected_port = value;
            }
        }

        public String[] get_port_names()
        {
            try
            {
                _name_array = SerialPort.GetPortNames();
                if (_name_array.Length == 0)
                {
                    _name_array = new String[1];
                    _name_array[0] = "N/A";
                    _com_port_detected = false;
                }
                else
                {
                    _com_port_detected = true;
                }
            }
            catch (Exception err)
            {
                _name_array = new String[1];
                _name_array[0] = "N/A";
                _com_port_detected = false;
                ComStatus = "Error " + this.SelectedPort.PortName + ": " + err.Message;
            }

            Array.Sort(_name_array);
            return _name_array;
        }

        private void init_config()
        {
            String[] name_array;
            name_array = get_port_names();

            if (_com_port_detected == true)
            {
                if (!(_selected_port.IsOpen))
                {
                    // Read user parameter values from Settings.settings database
                    this.SelectedPort.PortName = Properties.Settings.Default.PortName;
                    this.SelectedPort.BaudRate = Properties.Settings.Default.BaudRate;
                    this.SelectedPort.Parity = Properties.Settings.Default.Parity;
                    this.SelectedPort.DataBits = Properties.Settings.Default.DataBits;
                    this.SelectedPort.StopBits = Properties.Settings.Default.StopBits;
                    this.SelectedPort.ReadTimeout = Properties.Settings.Default.ReadTimeout;
                    this.SelectedPort.WriteTimeout = Properties.Settings.Default.WriteTimeout;
                    ComStatus = "Initial configuration of COM port done";
                }
                else
                {
                    ComStatus = "Error - cannot configure port when it is open";
                }
            }
            else
            {
                ComStatus = "Error - No COM port detected";
            }
        }

        public bool configure_port(String port_name, String bit_rate, String parity, String stop_bits, String data_bits, String read_timeout, String write_timeout)
        {
            if (!(_selected_port.IsOpen))
            {
                ComStatus = "Starting configuration";
                bool config_error = false;

                // Port
                if (_com_port_detected == true)
                {
                    this.SelectedPort.PortName = port_name;
                }
                else
                {
                    ComStatus = "Error - No COM port detected";
                    return false;
                }

                // Bit rate
                int temp = Convert.ToInt32(bit_rate);
                if (temp > 115200 || temp < 9600)
                {
                    config_error = true;
                    ComStatus = "Error - Bit rate configuration failed";
                    return false;
                }
                else
                {
                    this.SelectedPort.BaudRate = temp;
                }

                // Parity
                switch (parity)
                {
                    case "None":
                        this.SelectedPort.Parity = Parity.None;
                        break;

                    case "Odd":
                        this.SelectedPort.Parity = Parity.Odd;
                        break;

                    case "Even":
                        this.SelectedPort.Parity = Parity.Even;
                        break;

                    case "Mark":
                        this.SelectedPort.Parity = Parity.Mark;
                        break;

                    case "Space":
                        this.SelectedPort.Parity = Parity.Space;
                        break;

                    default:
                        config_error = true;
                        break;
                }
                if (config_error)
                {
                    ComStatus = "Error - Parity configuration failed";
                    return false;
                }

                // Stop bits
                switch (stop_bits)
                {
                    case "1":
                        this.SelectedPort.StopBits = StopBits.One;
                        break;

                    case "1.5":
                        this.SelectedPort.StopBits = StopBits.OnePointFive;
                        break;

                    case "2":
                        this.SelectedPort.StopBits = StopBits.Two;
                        break;

                    default:
                        config_error = true;
                        break;
                }
                if (config_error)
                {
                    ComStatus = "Error - stop bits configuration failed";
                    return false;
                }

                // Data bits
                temp = Convert.ToInt32(data_bits);
                if (temp > 8 || temp < 5)
                {
                    config_error = true;
                    ComStatus = "Error - Data bits configuration failed";
                    return false;
                }
                else
                {
                    this.SelectedPort.DataBits = temp;
                }
                
                // Read timeout
                temp = Convert.ToInt32(read_timeout);
                this.SelectedPort.ReadTimeout = temp;

                // Write timeout
                temp = Convert.ToInt32(write_timeout);
                this.SelectedPort.WriteTimeout = temp;

                if (config_error)
                {
                    ComStatus = "Error - Port configuration failed";
                    return false;
                }
                else
                {
                    ComStatus = "Port configuration done";
                    return true;
                }
            }
            else
            {
                ComStatus = "Error - cannot configure port when it is open";
                return false;
            }
        }

        public bool open_port()
        {
            if (_com_port_detected)
            {
                if (!(_selected_port.IsOpen))
                {
                    _selected_port.Open();
                    ComStatus = "Port opened";
                    return true;
                }
                else
                {
                    ComStatus = "Error - cannot open port";
                    return false;
                }
            }
            else
            {
                ComStatus = "Error - No COM port detected";
                return false;
            }
        }

        public bool is_open()
        {
            if (_com_port_detected)
            {
                if (_selected_port.IsOpen)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool send_message(byte[] data, Int32 offset, Int32 size)
        {
            try
            {
                this.SelectedPort.Write(data, offset, size);
                ComStatus = "Data sent";
                return true;
            }
            catch (Exception err)
            {
                ComStatus = "Error sending data " + this.SelectedPort.PortName + ": " + err.Message;
                return false;
            }
        }

        public bool read_message(ref byte[] message, Int32 offset, Int32 size)
        {
            try
            {
                this.SelectedPort.Read(message, offset, size);
                ComStatus = "Data read";
                return true;
            }
            catch (Exception err)
            {
                ComStatus = "Error reading data " + this.SelectedPort.PortName + ": " + err.Message;
                return false;
            }
        }

        public bool close_port()
        {
            if (_com_port_detected == true)
            {
                if (!(_selected_port == null))
                {
                    if (_selected_port.IsOpen)
                    {
                        while (_selected_port.BytesToWrite > 0)
                        {
                        }

                        _selected_port.Dispose();
                        ComStatus = "Port closed";
                        return true;
                    }
                    else
                    {
                        ComStatus = "Error - cannot close port";
                        return false;
                    }
                }
                else
                {
                    ComStatus = "Error - cannot close port";
                    return false;
                }
            }
            else
            {
                ComStatus = "Error - No COM port detected";
                return false;
            }

        }

        internal String ComStatus
        {
            get
            {
                return _com_status;
            }
            set
            {
                _com_status = value;
            }
        }

        internal Int32 BytesToRead
        {
            get
            {
                try
                {
                    return _selected_port.BytesToRead;
                }
                catch (Exception err)
                {
                    ComStatus = "Error " + this.SelectedPort.PortName + ": " + err.Message;
                    return 0;
                }
            }
        }

        internal Int32 BytesToWrite
        {
            get
            {
                try
                {
                    return _selected_port.BytesToWrite;
                }
                catch (Exception err)
                {
                    ComStatus = "Error " + this.SelectedPort.PortName + ": " + err.Message;
                    return 0;
                }
            }
        }
        public void clear_read_buffer()
        {
            try
            {
                this.SelectedPort.DiscardInBuffer();
                ComStatus = "Receive buffer cleared";
            }
            catch (Exception err)
            {
                ComStatus = "Error clearing receive buffer " + this.SelectedPort.PortName + ": " + err.Message;
            }
        }

        public void clear_write_buffer()
        {
            try
            {
                this.SelectedPort.DiscardOutBuffer();
                ComStatus = "Transmit buffer cleared";
            }
            catch (Exception err)
            {
                ComStatus = "Error clearing transmit buffer " + this.SelectedPort.PortName + ": " + err.Message;
            }
        }

        public String PortName
        {
            get
            {
                return this.SelectedPort.PortName;
            }
        }

        public int BaudRate
        {
            get
            {
                return this.SelectedPort.BaudRate;
            }
        }

        public Parity Parity
        {
            get
            {
                return this.SelectedPort.Parity;
            }
        }

        public int DataBits
        {
            get
            {
                return this.SelectedPort.DataBits;
            }
        }

        public StopBits StopBits
        {
            get
            {
                return this.SelectedPort.StopBits;
            }
        }

        public int ReadTimeout
        {
            get
            {
                return this.SelectedPort.ReadTimeout;
            }
        }

        public int WriteTimeout
        {
            get
            {
                return this.SelectedPort.WriteTimeout;
            }
        }
    }
}