using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialCommTestApplication
{
    // Common data used by both Form1 and Form2
    class Common
    {
        private int _port_name_combo_box_index;
        private int _bit_rate_combo_box_index;
        private int _parity_combo_box_index;
        private int _stop_bits_combo_box_index;
        private int _data_bits_combo_box_index;
        private String _read_timeout_text;
        private String _write_timeout_text;
        private bool _config_done;

        public Common()
        {
            // Read user parameter values from Settings.settings database
            this.PortNameComboBoxIndex = Properties.Settings.Default.PortNameComboBoxIndex;
            this.BitRateComboBoxIndex = Properties.Settings.Default.BaudRateComboBoxIndex;
            this.ParityComboBoxIndex = Properties.Settings.Default.ParityComboBoxIndex;
            this.StopBitsComboBoxIndex = Properties.Settings.Default.StopBitsComboBoxIndex;
            this.DataBitsComboBoxIndex = Properties.Settings.Default.DataBitsComboBoxIndex;
            this.ReadTimeoutText = Properties.Settings.Default.ReadTimeout.ToString();
            this.WriteTimeoutText = Properties.Settings.Default.WriteTimeout.ToString();
            _config_done = false;
        }

        ~Common()
        {
        }

        public int PortNameComboBoxIndex
        {
            get
            {
                return _port_name_combo_box_index;
            }
            set
            {
                _port_name_combo_box_index = value;
            }
        }

        public int BitRateComboBoxIndex
        {
            get
            {
                return _bit_rate_combo_box_index;
            }
            set
            {
                _bit_rate_combo_box_index = value;
            }
        }

        public int ParityComboBoxIndex
        {
            get
            {
                return _parity_combo_box_index;
            }
            set
            {
                _parity_combo_box_index = value;
            }
        }

        public int StopBitsComboBoxIndex
        {
            get
            {
                return _stop_bits_combo_box_index;
            }
            set
            {
                _stop_bits_combo_box_index = value;
            }
        }

        public int DataBitsComboBoxIndex
        {
            get
            {
                return _data_bits_combo_box_index;
            }
            set
            {
                _data_bits_combo_box_index = value;
            }
        }

        public String ReadTimeoutText
        {
            get
            {
                return _read_timeout_text;
            }
            set
            {
                _read_timeout_text = value;
            }
        }

        public String WriteTimeoutText
        {
            get
            {
                return _write_timeout_text;
            }
            set
            {
                _write_timeout_text = value;
            }
        }

        public bool ConfigDone
        {
            get
            {
                return _config_done;
            }
            set
            {
                _config_done = value;
            }
        }
    }
}