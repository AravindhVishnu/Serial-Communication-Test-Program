namespace SerialCommTestApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.PORT_NAME_LABEL = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.PORT_STATUS_LABEL = new System.Windows.Forms.ToolStripLabel();
            this.STATUS_LABEL = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.BIT_RATE_LABEL = new System.Windows.Forms.ToolStripLabel();
            this.BITRATE_LABEL = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.PARITY_LABEL = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.STOP_BITS_LABEL = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.DATA_BITS_LABEL = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel11 = new System.Windows.Forms.ToolStripLabel();
            this.CONTROL_MODE_LABEL = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.READ_TIMEOUT_LABEL = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
            this.WRITE_TIMEOUT_LABEL = new System.Windows.Forms.ToolStripLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LATEST_INCORRECT_DATA_LABEL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LATEST_READ_TIMEOUT_LABEL = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 88);
            this.button2.TabIndex = 1;
            this.button2.Text = "Open port";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.open_port_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(843, 342);
            this.listBox1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 88);
            this.button3.TabIndex = 4;
            this.button3.Text = "Close port";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.close_port_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 88);
            this.button1.TabIndex = 0;
            this.button1.Text = "Port settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.port_settings_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.PORT_NAME_LABEL,
            this.toolStripLabel3,
            this.toolStripLabel4,
            this.PORT_STATUS_LABEL,
            this.STATUS_LABEL,
            this.toolStripLabel5,
            this.BIT_RATE_LABEL,
            this.BITRATE_LABEL,
            this.toolStripLabel6,
            this.PARITY_LABEL,
            this.toolStripLabel7,
            this.STOP_BITS_LABEL,
            this.toolStripLabel8,
            this.DATA_BITS_LABEL,
            this.toolStripLabel11,
            this.CONTROL_MODE_LABEL});
            this.toolStrip2.Location = new System.Drawing.Point(0, 471);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(867, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "Port:";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 22);
            // 
            // PORT_NAME_LABEL
            // 
            this.PORT_NAME_LABEL.Name = "PORT_NAME_LABEL";
            this.PORT_NAME_LABEL.Size = new System.Drawing.Size(10, 22);
            this.PORT_NAME_LABEL.Text = " ";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(66, 22);
            this.toolStripLabel3.Text = "Port status:";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(0, 22);
            // 
            // PORT_STATUS_LABEL
            // 
            this.PORT_STATUS_LABEL.Name = "PORT_STATUS_LABEL";
            this.PORT_STATUS_LABEL.Size = new System.Drawing.Size(0, 22);
            // 
            // STATUS_LABEL
            // 
            this.STATUS_LABEL.Name = "STATUS_LABEL";
            this.STATUS_LABEL.Size = new System.Drawing.Size(10, 22);
            this.STATUS_LABEL.Text = " ";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel5.Text = "Bit rate:";
            // 
            // BIT_RATE_LABEL
            // 
            this.BIT_RATE_LABEL.Name = "BIT_RATE_LABEL";
            this.BIT_RATE_LABEL.Size = new System.Drawing.Size(0, 22);
            // 
            // BITRATE_LABEL
            // 
            this.BITRATE_LABEL.Name = "BITRATE_LABEL";
            this.BITRATE_LABEL.Size = new System.Drawing.Size(10, 22);
            this.BITRATE_LABEL.Text = " ";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel6.Text = "Parity:";
            // 
            // PARITY_LABEL
            // 
            this.PARITY_LABEL.Name = "PARITY_LABEL";
            this.PARITY_LABEL.Size = new System.Drawing.Size(10, 22);
            this.PARITY_LABEL.Text = " ";
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel7.Text = "Stop bits:";
            // 
            // STOP_BITS_LABEL
            // 
            this.STOP_BITS_LABEL.Name = "STOP_BITS_LABEL";
            this.STOP_BITS_LABEL.Size = new System.Drawing.Size(10, 22);
            this.STOP_BITS_LABEL.Text = " ";
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel8.Text = "Data bits:";
            // 
            // DATA_BITS_LABEL
            // 
            this.DATA_BITS_LABEL.Name = "DATA_BITS_LABEL";
            this.DATA_BITS_LABEL.Size = new System.Drawing.Size(10, 22);
            this.DATA_BITS_LABEL.Text = " ";
            // 
            // toolStripLabel11
            // 
            this.toolStripLabel11.Name = "toolStripLabel11";
            this.toolStripLabel11.Size = new System.Drawing.Size(84, 22);
            this.toolStripLabel11.Text = "Control mode:";
            // 
            // CONTROL_MODE_LABEL
            // 
            this.CONTROL_MODE_LABEL.Name = "CONTROL_MODE_LABEL";
            this.CONTROL_MODE_LABEL.Size = new System.Drawing.Size(10, 22);
            this.CONTROL_MODE_LABEL.Text = " ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel9,
            this.READ_TIMEOUT_LABEL,
            this.toolStripLabel10,
            this.WRITE_TIMEOUT_LABEL});
            this.toolStrip1.Location = new System.Drawing.Point(0, 496);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(867, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(135, 22);
            this.toolStripLabel9.Text = "Read timeout time [ms]:";
            // 
            // READ_TIMEOUT_LABEL
            // 
            this.READ_TIMEOUT_LABEL.Name = "READ_TIMEOUT_LABEL";
            this.READ_TIMEOUT_LABEL.Size = new System.Drawing.Size(10, 22);
            this.READ_TIMEOUT_LABEL.Text = " ";
            // 
            // toolStripLabel10
            // 
            this.toolStripLabel10.Name = "toolStripLabel10";
            this.toolStripLabel10.Size = new System.Drawing.Size(137, 22);
            this.toolStripLabel10.Text = "Write timeout time [ms]:";
            // 
            // WRITE_TIMEOUT_LABEL
            // 
            this.WRITE_TIMEOUT_LABEL.Name = "WRITE_TIMEOUT_LABEL";
            this.WRITE_TIMEOUT_LABEL.Size = new System.Drawing.Size(10, 22);
            this.WRITE_TIMEOUT_LABEL.Text = " ";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(338, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 88);
            this.button4.TabIndex = 6;
            this.button4.Text = "Start";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.start_button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(442, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 88);
            this.button5.TabIndex = 7;
            this.button5.Text = "Stop";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stop_button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(549, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 42);
            this.button6.TabIndex = 8;
            this.button6.Text = "Master";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(549, 60);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 40);
            this.button7.TabIndex = 9;
            this.button7.Text = "Slave";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(659, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Time of latest incorrect data received:";
            // 
            // LATEST_INCORRECT_DATA_LABEL
            // 
            this.LATEST_INCORRECT_DATA_LABEL.AutoSize = true;
            this.LATEST_INCORRECT_DATA_LABEL.Location = new System.Drawing.Point(671, 27);
            this.LATEST_INCORRECT_DATA_LABEL.Name = "LATEST_INCORRECT_DATA_LABEL";
            this.LATEST_INCORRECT_DATA_LABEL.Size = new System.Drawing.Size(10, 13);
            this.LATEST_INCORRECT_DATA_LABEL.TabIndex = 11;
            this.LATEST_INCORRECT_DATA_LABEL.Text = " ";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(659, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 41);
            this.label2.TabIndex = 12;
            this.label2.Text = "Time of latest read timeout:";
            // 
            // LATEST_READ_TIMEOUT_LABEL
            // 
            this.LATEST_READ_TIMEOUT_LABEL.AutoSize = true;
            this.LATEST_READ_TIMEOUT_LABEL.Location = new System.Drawing.Point(671, 74);
            this.LATEST_READ_TIMEOUT_LABEL.Name = "LATEST_READ_TIMEOUT_LABEL";
            this.LATEST_READ_TIMEOUT_LABEL.Size = new System.Drawing.Size(10, 13);
            this.LATEST_READ_TIMEOUT_LABEL.TabIndex = 13;
            this.LATEST_READ_TIMEOUT_LABEL.Text = " ";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(712, 471);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(143, 41);
            this.button8.TabIndex = 14;
            this.button8.Text = "Save read timeout / incorrect data received log";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 521);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.LATEST_INCORRECT_DATA_LABEL);
            this.Controls.Add(this.LATEST_READ_TIMEOUT_LABEL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "COM port terminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORM1_CLOSING);
            this.Load += new System.EventHandler(this.FORM1_LOAD);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripLabel PORT_NAME_LABEL;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel PORT_STATUS_LABEL;
        private System.Windows.Forms.ToolStripLabel STATUS_LABEL;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        public System.Windows.Forms.ToolStripLabel BIT_RATE_LABEL;
        public System.Windows.Forms.ToolStripLabel BITRATE_LABEL;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        public System.Windows.Forms.ToolStripLabel PARITY_LABEL;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        public System.Windows.Forms.ToolStripLabel DATA_BITS_LABEL;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        public System.Windows.Forms.ToolStripLabel READ_TIMEOUT_LABEL;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        public System.Windows.Forms.ToolStripLabel STOP_BITS_LABEL;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel11;
        private System.Windows.Forms.ToolStripLabel CONTROL_MODE_LABEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ToolStripLabel WRITE_TIMEOUT_LABEL;
        public System.Windows.Forms.Label LATEST_INCORRECT_DATA_LABEL;
        public System.Windows.Forms.Label LATEST_READ_TIMEOUT_LABEL;
        private System.Windows.Forms.Button button8;
    }
}

