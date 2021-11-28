namespace SerialCommTestApplication
{
    partial class Form2
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
            this.BIT_RATE_SETTING_COMBO_BOX = new System.Windows.Forms.ComboBox();
            this.PORT_NAME_SETTING_COMBO_BOX = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PARITY_SETTING_COMBO_BOX = new System.Windows.Forms.ComboBox();
            this.STOP_BITS_SETTING_COMBO_BOX = new System.Windows.Forms.ComboBox();
            this.DATA_BITS_SETTING_COMBO_BOX = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.READ_TIMEOUT_SETTING_TEXT_BOX = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.WRITE_TIMEOUT_SETTING_TEXT_BOX = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // BIT_RATE_SETTING_COMBO_BOX
            // 
            this.BIT_RATE_SETTING_COMBO_BOX.FormattingEnabled = true;
            this.BIT_RATE_SETTING_COMBO_BOX.Location = new System.Drawing.Point(190, 69);
            this.BIT_RATE_SETTING_COMBO_BOX.Name = "BIT_RATE_SETTING_COMBO_BOX";
            this.BIT_RATE_SETTING_COMBO_BOX.Size = new System.Drawing.Size(117, 21);
            this.BIT_RATE_SETTING_COMBO_BOX.TabIndex = 0;
            this.BIT_RATE_SETTING_COMBO_BOX.SelectionChangeCommitted += new System.EventHandler(this.BIT_RATE_SETTING_COMBO_BOX_SelectionChangeCommitted);
            // 
            // PORT_NAME_SETTING_COMBO_BOX
            // 
            this.PORT_NAME_SETTING_COMBO_BOX.FormattingEnabled = true;
            this.PORT_NAME_SETTING_COMBO_BOX.Location = new System.Drawing.Point(14, 34);
            this.PORT_NAME_SETTING_COMBO_BOX.Name = "PORT_NAME_SETTING_COMBO_BOX";
            this.PORT_NAME_SETTING_COMBO_BOX.Size = new System.Drawing.Size(117, 21);
            this.PORT_NAME_SETTING_COMBO_BOX.TabIndex = 3;
            this.PORT_NAME_SETTING_COMBO_BOX.SelectionChangeCommitted += new System.EventHandler(this.PORT_NAME_SETTING_COMBO_BOX_SelectionChangeCommitted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 76);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 76);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CANCEL_Click);
            // 
            // PARITY_SETTING_COMBO_BOX
            // 
            this.PARITY_SETTING_COMBO_BOX.FormattingEnabled = true;
            this.PARITY_SETTING_COMBO_BOX.Location = new System.Drawing.Point(10, 34);
            this.PARITY_SETTING_COMBO_BOX.Name = "PARITY_SETTING_COMBO_BOX";
            this.PARITY_SETTING_COMBO_BOX.Size = new System.Drawing.Size(117, 21);
            this.PARITY_SETTING_COMBO_BOX.TabIndex = 7;
            this.PARITY_SETTING_COMBO_BOX.SelectedIndexChanged += new System.EventHandler(this.PARITY_SETTING_COMBO_BOX_SelectedIndexChanged);
            // 
            // STOP_BITS_SETTING_COMBO_BOX
            // 
            this.STOP_BITS_SETTING_COMBO_BOX.FormattingEnabled = true;
            this.STOP_BITS_SETTING_COMBO_BOX.Location = new System.Drawing.Point(10, 31);
            this.STOP_BITS_SETTING_COMBO_BOX.Name = "STOP_BITS_SETTING_COMBO_BOX";
            this.STOP_BITS_SETTING_COMBO_BOX.Size = new System.Drawing.Size(117, 21);
            this.STOP_BITS_SETTING_COMBO_BOX.TabIndex = 9;
            this.STOP_BITS_SETTING_COMBO_BOX.SelectedIndexChanged += new System.EventHandler(this.STOP_BITS_SETTING_COMBO_BOX_SelectedIndexChanged);
            // 
            // DATA_BITS_SETTING_COMBO_BOX
            // 
            this.DATA_BITS_SETTING_COMBO_BOX.FormattingEnabled = true;
            this.DATA_BITS_SETTING_COMBO_BOX.Location = new System.Drawing.Point(10, 31);
            this.DATA_BITS_SETTING_COMBO_BOX.Name = "DATA_BITS_SETTING_COMBO_BOX";
            this.DATA_BITS_SETTING_COMBO_BOX.Size = new System.Drawing.Size(117, 21);
            this.DATA_BITS_SETTING_COMBO_BOX.TabIndex = 11;
            this.DATA_BITS_SETTING_COMBO_BOX.SelectedIndexChanged += new System.EventHandler(this.DATA_BITS_SETTING_COMBO_BOX_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PORT_NAME_SETTING_COMBO_BOX);
            this.groupBox1.Location = new System.Drawing.Point(23, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 72);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(180, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 72);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bit rate";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PARITY_SETTING_COMBO_BOX);
            this.groupBox3.Location = new System.Drawing.Point(340, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 72);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parity";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.STOP_BITS_SETTING_COMBO_BOX);
            this.groupBox4.Location = new System.Drawing.Point(180, 132);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(142, 72);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stop bits";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DATA_BITS_SETTING_COMBO_BOX);
            this.groupBox5.Location = new System.Drawing.Point(340, 132);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(142, 72);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Data bits";
            // 
            // READ_TIMEOUT_SETTING_TEXT_BOX
            // 
            this.READ_TIMEOUT_SETTING_TEXT_BOX.Location = new System.Drawing.Point(10, 29);
            this.READ_TIMEOUT_SETTING_TEXT_BOX.Name = "READ_TIMEOUT_SETTING_TEXT_BOX";
            this.READ_TIMEOUT_SETTING_TEXT_BOX.Size = new System.Drawing.Size(117, 20);
            this.READ_TIMEOUT_SETTING_TEXT_BOX.TabIndex = 17;
            this.READ_TIMEOUT_SETTING_TEXT_BOX.TextChanged += new System.EventHandler(this.READ_TIMEOUT_SETTING_TEXT_BOX_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.READ_TIMEOUT_SETTING_TEXT_BOX);
            this.groupBox6.Location = new System.Drawing.Point(180, 226);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(142, 72);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Read timeout time [ms]";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.WRITE_TIMEOUT_SETTING_TEXT_BOX);
            this.groupBox7.Location = new System.Drawing.Point(340, 226);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(142, 72);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Write timeout time [ms]";
            // 
            // WRITE_TIMEOUT_SETTING_TEXT_BOX
            // 
            this.WRITE_TIMEOUT_SETTING_TEXT_BOX.Location = new System.Drawing.Point(10, 29);
            this.WRITE_TIMEOUT_SETTING_TEXT_BOX.Name = "WRITE_TIMEOUT_SETTING_TEXT_BOX";
            this.WRITE_TIMEOUT_SETTING_TEXT_BOX.Size = new System.Drawing.Size(117, 20);
            this.WRITE_TIMEOUT_SETTING_TEXT_BOX.TabIndex = 20;
            this.WRITE_TIMEOUT_SETTING_TEXT_BOX.TextChanged += new System.EventHandler(this.WRITE_TIMEOUT_SETTING_TEXT_BOX_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 423);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BIT_RATE_SETTING_COMBO_BOX);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Name = "Form2";
            this.Text = "Port settings";
            this.Load += new System.EventHandler(this.FORM2_LOAD);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox BIT_RATE_SETTING_COMBO_BOX;
        private System.Windows.Forms.ComboBox PORT_NAME_SETTING_COMBO_BOX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox PARITY_SETTING_COMBO_BOX;
        private System.Windows.Forms.ComboBox STOP_BITS_SETTING_COMBO_BOX;
        private System.Windows.Forms.ComboBox DATA_BITS_SETTING_COMBO_BOX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox READ_TIMEOUT_SETTING_TEXT_BOX;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox WRITE_TIMEOUT_SETTING_TEXT_BOX;
    }
}