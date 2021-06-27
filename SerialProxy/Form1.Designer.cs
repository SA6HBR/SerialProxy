
namespace SerialProxy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ComPortConnect2 = new System.Windows.Forms.Button();
            this.ComPortDisconnect1 = new System.Windows.Forms.Button();
            this.ComPortConnect1 = new System.Windows.Forms.Button();
            this.ComPortNumber1 = new System.Windows.Forms.ComboBox();
            this.label_port_name2 = new System.Windows.Forms.Label();
            this.ComPortDisconnect2 = new System.Windows.Forms.Button();
            this.ComPortNumber2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TrashButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DSR2 = new System.Windows.Forms.CheckBox();
            this.CTS2 = new System.Windows.Forms.CheckBox();
            this.CTS1 = new System.Windows.Forms.CheckBox();
            this.DSR1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RTS1 = new System.Windows.Forms.CheckBox();
            this.DTR1 = new System.Windows.Forms.CheckBox();
            this.DumpDataLog = new System.Windows.Forms.CheckBox();
            this.PinChangeLog = new System.Windows.Forms.CheckBox();
            this.RTS2 = new System.Windows.Forms.CheckBox();
            this.DTR2 = new System.Windows.Forms.CheckBox();
            this.BREAK1 = new System.Windows.Forms.CheckBox();
            this.BREAK2 = new System.Windows.Forms.CheckBox();
            this.CD1 = new System.Windows.Forms.CheckBox();
            this.CD2 = new System.Windows.Forms.CheckBox();
            this.ComBaudRates1 = new System.Windows.Forms.ComboBox();
            this.ComBaudRates2 = new System.Windows.Forms.ComboBox();
            this.ComDataBit1 = new System.Windows.Forms.ComboBox();
            this.ComDataBit2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ComStopBit1 = new System.Windows.Forms.ComboBox();
            this.ComStopBit2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ComParity1 = new System.Windows.Forms.ComboBox();
            this.ComParity2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ComHandshake1 = new System.Windows.Forms.ComboBox();
            this.ComHandshake2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComPortConnect2
            // 
            this.ComPortConnect2.Location = new System.Drawing.Point(475, 199);
            this.ComPortConnect2.Name = "ComPortConnect2";
            this.ComPortConnect2.Size = new System.Drawing.Size(72, 23);
            this.ComPortConnect2.TabIndex = 86;
            this.ComPortConnect2.Text = "Connect";
            this.ComPortConnect2.UseVisualStyleBackColor = true;
            this.ComPortConnect2.Click += new System.EventHandler(this.ComPortConnect2_Click);
            // 
            // ComPortDisconnect1
            // 
            this.ComPortDisconnect1.Enabled = false;
            this.ComPortDisconnect1.Location = new System.Drawing.Point(553, 169);
            this.ComPortDisconnect1.Name = "ComPortDisconnect1";
            this.ComPortDisconnect1.Size = new System.Drawing.Size(72, 23);
            this.ComPortDisconnect1.TabIndex = 84;
            this.ComPortDisconnect1.Text = "Disconnect";
            this.ComPortDisconnect1.UseVisualStyleBackColor = true;
            this.ComPortDisconnect1.Click += new System.EventHandler(this.ComPortDisconnect1_Click);
            // 
            // ComPortConnect1
            // 
            this.ComPortConnect1.Location = new System.Drawing.Point(475, 169);
            this.ComPortConnect1.Name = "ComPortConnect1";
            this.ComPortConnect1.Size = new System.Drawing.Size(72, 23);
            this.ComPortConnect1.TabIndex = 82;
            this.ComPortConnect1.Text = "Connect";
            this.ComPortConnect1.UseVisualStyleBackColor = true;
            this.ComPortConnect1.Click += new System.EventHandler(this.ComPortConnect1_Click);
            // 
            // ComPortNumber1
            // 
            this.ComPortNumber1.FormattingEnabled = true;
            this.ComPortNumber1.Location = new System.Drawing.Point(58, 171);
            this.ComPortNumber1.Name = "ComPortNumber1";
            this.ComPortNumber1.Size = new System.Drawing.Size(62, 21);
            this.ComPortNumber1.TabIndex = 80;
            // 
            // label_port_name2
            // 
            this.label_port_name2.AutoSize = true;
            this.label_port_name2.Location = new System.Drawing.Point(10, 204);
            this.label_port_name2.Name = "label_port_name2";
            this.label_port_name2.Size = new System.Drawing.Size(46, 13);
            this.label_port_name2.TabIndex = 88;
            this.label_port_name2.Text = "Program";
            // 
            // ComPortDisconnect2
            // 
            this.ComPortDisconnect2.Enabled = false;
            this.ComPortDisconnect2.Location = new System.Drawing.Point(553, 199);
            this.ComPortDisconnect2.Name = "ComPortDisconnect2";
            this.ComPortDisconnect2.Size = new System.Drawing.Size(72, 23);
            this.ComPortDisconnect2.TabIndex = 87;
            this.ComPortDisconnect2.Text = "Disconnect";
            this.ComPortDisconnect2.UseVisualStyleBackColor = true;
            this.ComPortDisconnect2.Click += new System.EventHandler(this.ComPortDisconnect2_Click);
            // 
            // ComPortNumber2
            // 
            this.ComPortNumber2.FormattingEnabled = true;
            this.ComPortNumber2.Location = new System.Drawing.Point(57, 201);
            this.ComPortNumber2.Name = "ComPortNumber2";
            this.ComPortNumber2.Size = new System.Drawing.Size(62, 21);
            this.ComPortNumber2.TabIndex = 85;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(7, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(649, 103);
            this.textBox1.TabIndex = 89;
            // 
            // TrashButton
            // 
            this.TrashButton.Image = ((System.Drawing.Image)(resources.GetObject("TrashButton.Image")));
            this.TrashButton.Location = new System.Drawing.Point(722, 30);
            this.TrashButton.Name = "TrashButton";
            this.TrashButton.Size = new System.Drawing.Size(34, 34);
            this.TrashButton.TabIndex = 90;
            this.TrashButton.UseVisualStyleBackColor = true;
            this.TrashButton.Click += new System.EventHandler(this.TrashButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.Location = new System.Drawing.Point(673, 30);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(34, 34);
            this.RefreshButton.TabIndex = 91;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // DSR2
            // 
            this.DSR2.AutoSize = true;
            this.DSR2.Enabled = false;
            this.DSR2.Location = new System.Drawing.Point(561, 244);
            this.DSR2.Name = "DSR2";
            this.DSR2.Size = new System.Drawing.Size(49, 17);
            this.DSR2.TabIndex = 132;
            this.DSR2.Text = "DSR";
            this.DSR2.UseVisualStyleBackColor = true;
            // 
            // CTS2
            // 
            this.CTS2.AutoSize = true;
            this.CTS2.Enabled = false;
            this.CTS2.Location = new System.Drawing.Point(508, 244);
            this.CTS2.Name = "CTS2";
            this.CTS2.Size = new System.Drawing.Size(47, 17);
            this.CTS2.TabIndex = 131;
            this.CTS2.Text = "CTS";
            this.CTS2.UseVisualStyleBackColor = true;
            // 
            // CTS1
            // 
            this.CTS1.AutoSize = true;
            this.CTS1.Enabled = false;
            this.CTS1.Location = new System.Drawing.Point(198, 244);
            this.CTS1.Name = "CTS1";
            this.CTS1.Size = new System.Drawing.Size(47, 17);
            this.CTS1.TabIndex = 130;
            this.CTS1.Text = "CTS";
            this.CTS1.UseVisualStyleBackColor = true;
            // 
            // DSR1
            // 
            this.DSR1.AutoSize = true;
            this.DSR1.Enabled = false;
            this.DSR1.Location = new System.Drawing.Point(251, 244);
            this.DSR1.Name = "DSR1";
            this.DSR1.Size = new System.Drawing.Size(49, 17);
            this.DSR1.TabIndex = 129;
            this.DSR1.Text = "DSR";
            this.DSR1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(386, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 127;
            this.label5.Text = "Program";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(80, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 126;
            this.label2.Text = "Radio";
            // 
            // RTS1
            // 
            this.RTS1.AutoSize = true;
            this.RTS1.Enabled = false;
            this.RTS1.Location = new System.Drawing.Point(251, 266);
            this.RTS1.Name = "RTS1";
            this.RTS1.Size = new System.Drawing.Size(48, 17);
            this.RTS1.TabIndex = 125;
            this.RTS1.Text = "RTS";
            this.RTS1.UseVisualStyleBackColor = true;
            // 
            // DTR1
            // 
            this.DTR1.AutoSize = true;
            this.DTR1.Enabled = false;
            this.DTR1.Location = new System.Drawing.Point(198, 266);
            this.DTR1.Name = "DTR1";
            this.DTR1.Size = new System.Drawing.Size(49, 17);
            this.DTR1.TabIndex = 124;
            this.DTR1.Text = "DTR";
            this.DTR1.UseVisualStyleBackColor = true;
            // 
            // DumpDataLog
            // 
            this.DumpDataLog.AutoSize = true;
            this.DumpDataLog.Checked = true;
            this.DumpDataLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DumpDataLog.Location = new System.Drawing.Point(673, 116);
            this.DumpDataLog.Name = "DumpDataLog";
            this.DumpDataLog.Size = new System.Drawing.Size(95, 17);
            this.DumpDataLog.TabIndex = 123;
            this.DumpDataLog.Text = "DumpDataLog";
            this.DumpDataLog.UseVisualStyleBackColor = true;
            // 
            // PinChangeLog
            // 
            this.PinChangeLog.AutoSize = true;
            this.PinChangeLog.Checked = true;
            this.PinChangeLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PinChangeLog.Location = new System.Drawing.Point(673, 93);
            this.PinChangeLog.Name = "PinChangeLog";
            this.PinChangeLog.Size = new System.Drawing.Size(96, 17);
            this.PinChangeLog.TabIndex = 122;
            this.PinChangeLog.Text = "PinChangeLog";
            this.PinChangeLog.UseVisualStyleBackColor = true;
            // 
            // RTS2
            // 
            this.RTS2.AutoSize = true;
            this.RTS2.Enabled = false;
            this.RTS2.Location = new System.Drawing.Point(561, 266);
            this.RTS2.Name = "RTS2";
            this.RTS2.Size = new System.Drawing.Size(48, 17);
            this.RTS2.TabIndex = 120;
            this.RTS2.Text = "RTS";
            this.RTS2.UseVisualStyleBackColor = true;
            // 
            // DTR2
            // 
            this.DTR2.AutoSize = true;
            this.DTR2.Enabled = false;
            this.DTR2.Location = new System.Drawing.Point(508, 266);
            this.DTR2.Name = "DTR2";
            this.DTR2.Size = new System.Drawing.Size(49, 17);
            this.DTR2.TabIndex = 119;
            this.DTR2.Text = "DTR";
            this.DTR2.UseVisualStyleBackColor = true;
            // 
            // BREAK1
            // 
            this.BREAK1.AutoSize = true;
            this.BREAK1.Enabled = false;
            this.BREAK1.Location = new System.Drawing.Point(130, 266);
            this.BREAK1.Name = "BREAK1";
            this.BREAK1.Size = new System.Drawing.Size(62, 17);
            this.BREAK1.TabIndex = 133;
            this.BREAK1.Text = "BREAK";
            this.BREAK1.UseVisualStyleBackColor = true;
            // 
            // BREAK2
            // 
            this.BREAK2.AutoSize = true;
            this.BREAK2.Enabled = false;
            this.BREAK2.Location = new System.Drawing.Point(439, 266);
            this.BREAK2.Name = "BREAK2";
            this.BREAK2.Size = new System.Drawing.Size(62, 17);
            this.BREAK2.TabIndex = 134;
            this.BREAK2.Text = "BREAK";
            this.BREAK2.UseVisualStyleBackColor = true;
            // 
            // CD1
            // 
            this.CD1.AutoSize = true;
            this.CD1.Enabled = false;
            this.CD1.Location = new System.Drawing.Point(130, 244);
            this.CD1.Name = "CD1";
            this.CD1.Size = new System.Drawing.Size(41, 17);
            this.CD1.TabIndex = 135;
            this.CD1.Text = "CD";
            this.CD1.UseVisualStyleBackColor = true;
            // 
            // CD2
            // 
            this.CD2.AutoSize = true;
            this.CD2.Enabled = false;
            this.CD2.Location = new System.Drawing.Point(439, 244);
            this.CD2.Name = "CD2";
            this.CD2.Size = new System.Drawing.Size(41, 17);
            this.CD2.TabIndex = 136;
            this.CD2.Text = "CD";
            this.CD2.UseVisualStyleBackColor = true;
            // 
            // ComBaudRates1
            // 
            this.ComBaudRates1.FormattingEnabled = true;
            this.ComBaudRates1.Location = new System.Drawing.Point(126, 171);
            this.ComBaudRates1.Name = "ComBaudRates1";
            this.ComBaudRates1.Size = new System.Drawing.Size(62, 21);
            this.ComBaudRates1.TabIndex = 137;
            // 
            // ComBaudRates2
            // 
            this.ComBaudRates2.FormattingEnabled = true;
            this.ComBaudRates2.Location = new System.Drawing.Point(125, 201);
            this.ComBaudRates2.Name = "ComBaudRates2";
            this.ComBaudRates2.Size = new System.Drawing.Size(62, 21);
            this.ComBaudRates2.TabIndex = 138;
            // 
            // ComDataBit1
            // 
            this.ComDataBit1.FormattingEnabled = true;
            this.ComDataBit1.Location = new System.Drawing.Point(194, 171);
            this.ComDataBit1.Name = "ComDataBit1";
            this.ComDataBit1.Size = new System.Drawing.Size(44, 21);
            this.ComDataBit1.TabIndex = 139;
            // 
            // ComDataBit2
            // 
            this.ComDataBit2.FormattingEnabled = true;
            this.ComDataBit2.Location = new System.Drawing.Point(193, 201);
            this.ComDataBit2.Name = "ComDataBit2";
            this.ComDataBit2.Size = new System.Drawing.Size(44, 21);
            this.ComDataBit2.TabIndex = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 141;
            this.label3.Text = "Radio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 142;
            this.label1.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 143;
            this.label4.Text = "Baud";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 144;
            this.label6.Text = "DataBits";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 147;
            this.label7.Text = "StopBits";
            // 
            // ComStopBit1
            // 
            this.ComStopBit1.FormattingEnabled = true;
            this.ComStopBit1.Location = new System.Drawing.Point(244, 171);
            this.ComStopBit1.Name = "ComStopBit1";
            this.ComStopBit1.Size = new System.Drawing.Size(43, 21);
            this.ComStopBit1.TabIndex = 145;
            // 
            // ComStopBit2
            // 
            this.ComStopBit2.FormattingEnabled = true;
            this.ComStopBit2.Location = new System.Drawing.Point(243, 201);
            this.ComStopBit2.Name = "ComStopBit2";
            this.ComStopBit2.Size = new System.Drawing.Size(43, 21);
            this.ComStopBit2.TabIndex = 146;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 150;
            this.label8.Text = "Parity";
            // 
            // ComParity1
            // 
            this.ComParity1.FormattingEnabled = true;
            this.ComParity1.Location = new System.Drawing.Point(293, 171);
            this.ComParity1.Name = "ComParity1";
            this.ComParity1.Size = new System.Drawing.Size(61, 21);
            this.ComParity1.TabIndex = 148;
            // 
            // ComParity2
            // 
            this.ComParity2.FormattingEnabled = true;
            this.ComParity2.Location = new System.Drawing.Point(292, 201);
            this.ComParity2.Name = "ComParity2";
            this.ComParity2.Size = new System.Drawing.Size(61, 21);
            this.ComParity2.TabIndex = 149;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 153;
            this.label9.Text = "Handshake";
            // 
            // ComHandshake1
            // 
            this.ComHandshake1.FormattingEnabled = true;
            this.ComHandshake1.Location = new System.Drawing.Point(360, 171);
            this.ComHandshake1.Name = "ComHandshake1";
            this.ComHandshake1.Size = new System.Drawing.Size(103, 21);
            this.ComHandshake1.TabIndex = 151;
            // 
            // ComHandshake2
            // 
            this.ComHandshake2.FormattingEnabled = true;
            this.ComHandshake2.Location = new System.Drawing.Point(359, 201);
            this.ComHandshake2.Name = "ComHandshake2";
            this.ComHandshake2.Size = new System.Drawing.Size(103, 21);
            this.ComHandshake2.TabIndex = 152;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(586, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 16);
            this.label10.TabIndex = 154;
            this.label10.Text = "software @ SA6HBR . se";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 293);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ComHandshake1);
            this.Controls.Add(this.ComHandshake2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ComParity1);
            this.Controls.Add(this.ComParity2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComStopBit1);
            this.Controls.Add(this.ComStopBit2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComDataBit1);
            this.Controls.Add(this.ComDataBit2);
            this.Controls.Add(this.ComBaudRates1);
            this.Controls.Add(this.ComBaudRates2);
            this.Controls.Add(this.CD2);
            this.Controls.Add(this.CD1);
            this.Controls.Add(this.BREAK2);
            this.Controls.Add(this.BREAK1);
            this.Controls.Add(this.DSR2);
            this.Controls.Add(this.CTS2);
            this.Controls.Add(this.CTS1);
            this.Controls.Add(this.DSR1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RTS1);
            this.Controls.Add(this.DTR1);
            this.Controls.Add(this.DumpDataLog);
            this.Controls.Add(this.PinChangeLog);
            this.Controls.Add(this.RTS2);
            this.Controls.Add(this.DTR2);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.TrashButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ComPortConnect2);
            this.Controls.Add(this.ComPortDisconnect1);
            this.Controls.Add(this.ComPortConnect1);
            this.Controls.Add(this.ComPortNumber1);
            this.Controls.Add(this.label_port_name2);
            this.Controls.Add(this.ComPortDisconnect2);
            this.Controls.Add(this.ComPortNumber2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SerialProxy - SA6HBR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ComPortConnect2;
        private System.Windows.Forms.Button ComPortDisconnect1;
        private System.Windows.Forms.Button ComPortConnect1;
        private System.Windows.Forms.ComboBox ComPortNumber1;
        private System.Windows.Forms.Label label_port_name2;
        private System.Windows.Forms.Button ComPortDisconnect2;
        private System.Windows.Forms.ComboBox ComPortNumber2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button TrashButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.CheckBox DSR2;
        private System.Windows.Forms.CheckBox CTS2;
        private System.Windows.Forms.CheckBox CTS1;
        private System.Windows.Forms.CheckBox DSR1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox RTS1;
        private System.Windows.Forms.CheckBox DTR1;
        private System.Windows.Forms.CheckBox DumpDataLog;
        private System.Windows.Forms.CheckBox PinChangeLog;
        private System.Windows.Forms.CheckBox RTS2;
        private System.Windows.Forms.CheckBox DTR2;
        private System.Windows.Forms.CheckBox BREAK1;
        private System.Windows.Forms.CheckBox BREAK2;
        private System.Windows.Forms.CheckBox CD1;
        private System.Windows.Forms.CheckBox CD2;
        private System.Windows.Forms.ComboBox ComBaudRates1;
        private System.Windows.Forms.ComboBox ComBaudRates2;
        private System.Windows.Forms.ComboBox ComDataBit1;
        private System.Windows.Forms.ComboBox ComDataBit2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComStopBit1;
        private System.Windows.Forms.ComboBox ComStopBit2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComParity1;
        private System.Windows.Forms.ComboBox ComParity2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ComHandshake1;
        private System.Windows.Forms.ComboBox ComHandshake2;
        private System.Windows.Forms.Label label10;
    }
}

