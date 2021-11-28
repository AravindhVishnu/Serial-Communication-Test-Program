using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialCommTestApplication
{
    class Common
    {
        private Int32 _port_name_combo_box_index;
        private Int32 _bit_rate_combo_box_index;
        private Int32 _parity_combo_box_index;
        private Int32 _stop_bits_combo_box_index;
        private Int32 _data_bits_combo_box_index;
        private String _read_timeout_text;
        private String _write_timeout_text;
        private bool _config_done;

        public Common()
        {
            this.PortNameComboBoxIndex = 0;
            this.BitRateComboBoxIndex = 0;
            this.ParityComboBoxIndex = 0;
            this.StopBitsComboBoxIndex = 0;
            this.DataBitsComboBoxIndex = 0;
            this.ReadTimeoutText = "1000";
            this.WriteTimeoutText = "1000";
            _config_done = false;
        }

        ~Common()
        {
        }

        public Int32 PortNameComboBoxIndex
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
        public Int32 BitRateComboBoxIndex
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
        public Int32 ParityComboBoxIndex
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
        public Int32 StopBitsComboBoxIndex
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
        public Int32 DataBitsComboBoxIndex
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
