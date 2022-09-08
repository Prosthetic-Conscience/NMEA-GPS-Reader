namespace BMS_GPS_Reader
{
    partial class GPSGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPSGUI));
            this.selectedSerialPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comPortStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.serialMonStartStop = new System.Windows.Forms.Button();
            this.baudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gpsStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SatsTracked = new System.Windows.Forms.TextBox();
            this.FixTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Altitude = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Longitude = new System.Windows.Forms.TextBox();
            this.Lattitude = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.raw_NMEA_Data = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SNR11 = new System.Windows.Forms.TextBox();
            this.SNR10 = new System.Windows.Forms.TextBox();
            this.SNR9 = new System.Windows.Forms.TextBox();
            this.SNR8 = new System.Windows.Forms.TextBox();
            this.SNR7 = new System.Windows.Forms.TextBox();
            this.SNR6 = new System.Windows.Forms.TextBox();
            this.SNR5 = new System.Windows.Forms.TextBox();
            this.SNR4 = new System.Windows.Forms.TextBox();
            this.SNR3 = new System.Windows.Forms.TextBox();
            this.SNR2 = new System.Windows.Forms.TextBox();
            this.SNR1 = new System.Windows.Forms.TextBox();
            this.SNR0 = new System.Windows.Forms.TextBox();
            this.SatNumberDisplay11 = new System.Windows.Forms.TextBox();
            this.SatNumberDisplay10 = new System.Windows.Forms.TextBox();
            this.SatNumberDisplay9 = new System.Windows.Forms.TextBox();
            this.SatNumberDisplay8 = new System.Windows.Forms.TextBox();
            this.SatNumberDisplay7 = new System.Windows.Forms.TextBox();
            this.SatNumberDisplay6 = new System.Windows.Forms.TextBox();
            this.SatNumberDisplay5 = new System.Windows.Forms.TextBox();
            this.SatNumberDisplay4 = new System.Windows.Forms.TextBox();
            this.SatNumberDisplay3 = new System.Windows.Forms.TextBox();
            this.SatNumberDisplay2 = new System.Windows.Forms.TextBox();
            this.SatNumberDisplay1 = new System.Windows.Forms.TextBox();
            this.SatIndicator11 = new System.Windows.Forms.ProgressBar();
            this.SatIndicator10 = new System.Windows.Forms.ProgressBar();
            this.SatIndicator9 = new System.Windows.Forms.ProgressBar();
            this.SatIndicator8 = new System.Windows.Forms.ProgressBar();
            this.SatIndicator7 = new System.Windows.Forms.ProgressBar();
            this.SatIndicator6 = new System.Windows.Forms.ProgressBar();
            this.SatIndicator5 = new System.Windows.Forms.ProgressBar();
            this.SatIndicator4 = new System.Windows.Forms.ProgressBar();
            this.SatIndicator3 = new System.Windows.Forms.ProgressBar();
            this.SatIndicator2 = new System.Windows.Forms.ProgressBar();
            this.SatIndicator1 = new System.Windows.Forms.ProgressBar();
            this.SatNumberDisplay0 = new System.Windows.Forms.TextBox();
            this.SatIndicator0 = new System.Windows.Forms.ProgressBar();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.SatDisplayBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectedSerialPort
            // 
            this.selectedSerialPort.FormattingEnabled = true;
            this.selectedSerialPort.Location = new System.Drawing.Point(136, 28);
            this.selectedSerialPort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.selectedSerialPort.Name = "selectedSerialPort";
            this.selectedSerialPort.Size = new System.Drawing.Size(186, 32);
            this.selectedSerialPort.TabIndex = 0;
            this.selectedSerialPort.DropDown += new System.EventHandler(this.selectedSerialPort_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial Port";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comPortStatus);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.serialMonStartStop);
            this.groupBox1.Controls.Add(this.baudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.selectedSerialPort);
            this.groupBox1.Location = new System.Drawing.Point(22, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(339, 262);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com settings";
            // 
            // comPortStatus
            // 
            this.comPortStatus.Enabled = false;
            this.comPortStatus.Location = new System.Drawing.Point(136, 196);
            this.comPortStatus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comPortStatus.Name = "comPortStatus";
            this.comPortStatus.Size = new System.Drawing.Size(116, 29);
            this.comPortStatus.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 201);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Status";
            // 
            // serialMonStartStop
            // 
            this.serialMonStartStop.Location = new System.Drawing.Point(141, 133);
            this.serialMonStartStop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.serialMonStartStop.Name = "serialMonStartStop";
            this.serialMonStartStop.Size = new System.Drawing.Size(183, 42);
            this.serialMonStartStop.TabIndex = 4;
            this.serialMonStartStop.Text = "Start Reading";
            this.serialMonStartStop.UseVisualStyleBackColor = true;
            this.serialMonStartStop.Click += new System.EventHandler(this.serialMonStartStop_Click);
            // 
            // baudRate
            // 
            this.baudRate.FormattingEnabled = true;
            this.baudRate.Items.AddRange(new object[] {
            "600",
            "1200",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baudRate.Location = new System.Drawing.Point(141, 83);
            this.baudRate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(180, 32);
            this.baudRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.gpsStatus);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.SatsTracked);
            this.groupBox2.Controls.Add(this.FixTime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Altitude);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Longitude);
            this.groupBox2.Controls.Add(this.Lattitude);
            this.groupBox2.Location = new System.Drawing.Point(20, 277);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(339, 366);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GPS Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 295);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Status";
            // 
            // gpsStatus
            // 
            this.gpsStatus.Enabled = false;
            this.gpsStatus.Location = new System.Drawing.Point(143, 290);
            this.gpsStatus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gpsStatus.Name = "gpsStatus";
            this.gpsStatus.Size = new System.Drawing.Size(110, 29);
            this.gpsStatus.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sats Tracked";
            // 
            // SatsTracked
            // 
            this.SatsTracked.BackColor = System.Drawing.SystemColors.Window;
            this.SatsTracked.Enabled = false;
            this.SatsTracked.Location = new System.Drawing.Point(141, 238);
            this.SatsTracked.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatsTracked.Name = "SatsTracked";
            this.SatsTracked.Size = new System.Drawing.Size(180, 29);
            this.SatsTracked.TabIndex = 8;
            // 
            // FixTime
            // 
            this.FixTime.BackColor = System.Drawing.SystemColors.Window;
            this.FixTime.Enabled = false;
            this.FixTime.Location = new System.Drawing.Point(141, 190);
            this.FixTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FixTime.Name = "FixTime";
            this.FixTime.Size = new System.Drawing.Size(180, 29);
            this.FixTime.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fix time";
            // 
            // Altitude
            // 
            this.Altitude.BackColor = System.Drawing.SystemColors.Window;
            this.Altitude.Enabled = false;
            this.Altitude.Location = new System.Drawing.Point(141, 137);
            this.Altitude.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Altitude.Name = "Altitude";
            this.Altitude.Size = new System.Drawing.Size(180, 29);
            this.Altitude.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Altitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Longitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lattitude";
            // 
            // Longitude
            // 
            this.Longitude.BackColor = System.Drawing.SystemColors.Window;
            this.Longitude.Enabled = false;
            this.Longitude.Location = new System.Drawing.Point(141, 85);
            this.Longitude.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Longitude.Name = "Longitude";
            this.Longitude.Size = new System.Drawing.Size(180, 29);
            this.Longitude.TabIndex = 1;
            // 
            // Lattitude
            // 
            this.Lattitude.BackColor = System.Drawing.SystemColors.Window;
            this.Lattitude.Enabled = false;
            this.Lattitude.Location = new System.Drawing.Point(141, 37);
            this.Lattitude.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Lattitude.Name = "Lattitude";
            this.Lattitude.Size = new System.Drawing.Size(180, 29);
            this.Lattitude.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.raw_NMEA_Data);
            this.groupBox3.Location = new System.Drawing.Point(20, 654);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(1071, 336);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Raw Data";
            // 
            // raw_NMEA_Data
            // 
            this.raw_NMEA_Data.Location = new System.Drawing.Point(11, 30);
            this.raw_NMEA_Data.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.raw_NMEA_Data.MaxLength = 47483647;
            this.raw_NMEA_Data.Name = "raw_NMEA_Data";
            this.raw_NMEA_Data.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.raw_NMEA_Data.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.raw_NMEA_Data.Size = new System.Drawing.Size(1025, 277);
            this.raw_NMEA_Data.TabIndex = 0;
            this.raw_NMEA_Data.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SNR11);
            this.groupBox4.Controls.Add(this.SNR10);
            this.groupBox4.Controls.Add(this.SNR9);
            this.groupBox4.Controls.Add(this.SNR8);
            this.groupBox4.Controls.Add(this.SNR7);
            this.groupBox4.Controls.Add(this.SNR6);
            this.groupBox4.Controls.Add(this.SNR5);
            this.groupBox4.Controls.Add(this.SNR4);
            this.groupBox4.Controls.Add(this.SNR3);
            this.groupBox4.Controls.Add(this.SNR2);
            this.groupBox4.Controls.Add(this.SNR1);
            this.groupBox4.Controls.Add(this.SNR0);
            this.groupBox4.Controls.Add(this.SatNumberDisplay11);
            this.groupBox4.Controls.Add(this.SatNumberDisplay10);
            this.groupBox4.Controls.Add(this.SatNumberDisplay9);
            this.groupBox4.Controls.Add(this.SatNumberDisplay8);
            this.groupBox4.Controls.Add(this.SatNumberDisplay7);
            this.groupBox4.Controls.Add(this.SatNumberDisplay6);
            this.groupBox4.Controls.Add(this.SatNumberDisplay5);
            this.groupBox4.Controls.Add(this.SatNumberDisplay4);
            this.groupBox4.Controls.Add(this.SatNumberDisplay3);
            this.groupBox4.Controls.Add(this.SatNumberDisplay2);
            this.groupBox4.Controls.Add(this.SatNumberDisplay1);
            this.groupBox4.Controls.Add(this.SatIndicator11);
            this.groupBox4.Controls.Add(this.SatIndicator10);
            this.groupBox4.Controls.Add(this.SatIndicator9);
            this.groupBox4.Controls.Add(this.SatIndicator8);
            this.groupBox4.Controls.Add(this.SatIndicator7);
            this.groupBox4.Controls.Add(this.SatIndicator6);
            this.groupBox4.Controls.Add(this.SatIndicator5);
            this.groupBox4.Controls.Add(this.SatIndicator4);
            this.groupBox4.Controls.Add(this.SatIndicator3);
            this.groupBox4.Controls.Add(this.SatIndicator2);
            this.groupBox4.Controls.Add(this.SatIndicator1);
            this.groupBox4.Controls.Add(this.SatNumberDisplay0);
            this.groupBox4.Controls.Add(this.SatIndicator0);
            this.groupBox4.Location = new System.Drawing.Point(358, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Size = new System.Drawing.Size(326, 639);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Satellite Data";
            // 
            // SNR11
            // 
            this.SNR11.Enabled = false;
            this.SNR11.Location = new System.Drawing.Point(83, 574);
            this.SNR11.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SNR11.Name = "SNR11";
            this.SNR11.Size = new System.Drawing.Size(90, 29);
            this.SNR11.TabIndex = 46;
            this.SNR11.Visible = false;
            // 
            // SNR10
            // 
            this.SNR10.Enabled = false;
            this.SNR10.Location = new System.Drawing.Point(83, 524);
            this.SNR10.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SNR10.Name = "SNR10";
            this.SNR10.Size = new System.Drawing.Size(90, 29);
            this.SNR10.TabIndex = 45;
            this.SNR10.Visible = false;
            // 
            // SNR9
            // 
            this.SNR9.Enabled = false;
            this.SNR9.Location = new System.Drawing.Point(83, 474);
            this.SNR9.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SNR9.Name = "SNR9";
            this.SNR9.Size = new System.Drawing.Size(90, 29);
            this.SNR9.TabIndex = 44;
            this.SNR9.Visible = false;
            // 
            // SNR8
            // 
            this.SNR8.Enabled = false;
            this.SNR8.Location = new System.Drawing.Point(83, 425);
            this.SNR8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SNR8.Name = "SNR8";
            this.SNR8.Size = new System.Drawing.Size(90, 29);
            this.SNR8.TabIndex = 43;
            this.SNR8.Visible = false;
            // 
            // SNR7
            // 
            this.SNR7.Enabled = false;
            this.SNR7.Location = new System.Drawing.Point(83, 375);
            this.SNR7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SNR7.Name = "SNR7";
            this.SNR7.Size = new System.Drawing.Size(90, 29);
            this.SNR7.TabIndex = 42;
            this.SNR7.Visible = false;
            // 
            // SNR6
            // 
            this.SNR6.Enabled = false;
            this.SNR6.Location = new System.Drawing.Point(83, 321);
            this.SNR6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SNR6.Name = "SNR6";
            this.SNR6.Size = new System.Drawing.Size(90, 29);
            this.SNR6.TabIndex = 41;
            this.SNR6.Visible = false;
            // 
            // SNR5
            // 
            this.SNR5.Enabled = false;
            this.SNR5.Location = new System.Drawing.Point(83, 273);
            this.SNR5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SNR5.Name = "SNR5";
            this.SNR5.Size = new System.Drawing.Size(90, 29);
            this.SNR5.TabIndex = 40;
            this.SNR5.Visible = false;
            // 
            // SNR4
            // 
            this.SNR4.Enabled = false;
            this.SNR4.Location = new System.Drawing.Point(83, 227);
            this.SNR4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SNR4.Name = "SNR4";
            this.SNR4.Size = new System.Drawing.Size(90, 29);
            this.SNR4.TabIndex = 39;
            this.SNR4.Visible = false;
            // 
            // SNR3
            // 
            this.SNR3.Enabled = false;
            this.SNR3.Location = new System.Drawing.Point(83, 179);
            this.SNR3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SNR3.Name = "SNR3";
            this.SNR3.Size = new System.Drawing.Size(90, 29);
            this.SNR3.TabIndex = 38;
            this.SNR3.Visible = false;
            // 
            // SNR2
            // 
            this.SNR2.Enabled = false;
            this.SNR2.Location = new System.Drawing.Point(83, 129);
            this.SNR2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SNR2.Name = "SNR2";
            this.SNR2.Size = new System.Drawing.Size(90, 29);
            this.SNR2.TabIndex = 37;
            this.SNR2.Visible = false;
            // 
            // SNR1
            // 
            this.SNR1.Enabled = false;
            this.SNR1.Location = new System.Drawing.Point(83, 79);
            this.SNR1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SNR1.Name = "SNR1";
            this.SNR1.Size = new System.Drawing.Size(90, 29);
            this.SNR1.TabIndex = 36;
            this.SNR1.Visible = false;
            // 
            // SNR0
            // 
            this.SNR0.Enabled = false;
            this.SNR0.Location = new System.Drawing.Point(83, 30);
            this.SNR0.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SNR0.Name = "SNR0";
            this.SNR0.Size = new System.Drawing.Size(90, 29);
            this.SNR0.TabIndex = 35;
            this.SNR0.Visible = false;
            // 
            // SatNumberDisplay11
            // 
            this.SatNumberDisplay11.Enabled = false;
            this.SatNumberDisplay11.Location = new System.Drawing.Point(11, 572);
            this.SatNumberDisplay11.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatNumberDisplay11.Name = "SatNumberDisplay11";
            this.SatNumberDisplay11.Size = new System.Drawing.Size(57, 29);
            this.SatNumberDisplay11.TabIndex = 34;
            this.SatNumberDisplay11.Visible = false;
            // 
            // SatNumberDisplay10
            // 
            this.SatNumberDisplay10.Enabled = false;
            this.SatNumberDisplay10.Location = new System.Drawing.Point(11, 522);
            this.SatNumberDisplay10.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatNumberDisplay10.Name = "SatNumberDisplay10";
            this.SatNumberDisplay10.Size = new System.Drawing.Size(57, 29);
            this.SatNumberDisplay10.TabIndex = 33;
            this.SatNumberDisplay10.Visible = false;
            // 
            // SatNumberDisplay9
            // 
            this.SatNumberDisplay9.Enabled = false;
            this.SatNumberDisplay9.Location = new System.Drawing.Point(11, 473);
            this.SatNumberDisplay9.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatNumberDisplay9.Name = "SatNumberDisplay9";
            this.SatNumberDisplay9.Size = new System.Drawing.Size(57, 29);
            this.SatNumberDisplay9.TabIndex = 32;
            this.SatNumberDisplay9.Visible = false;
            // 
            // SatNumberDisplay8
            // 
            this.SatNumberDisplay8.Enabled = false;
            this.SatNumberDisplay8.Location = new System.Drawing.Point(11, 421);
            this.SatNumberDisplay8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatNumberDisplay8.Name = "SatNumberDisplay8";
            this.SatNumberDisplay8.Size = new System.Drawing.Size(57, 29);
            this.SatNumberDisplay8.TabIndex = 31;
            this.SatNumberDisplay8.Visible = false;
            // 
            // SatNumberDisplay7
            // 
            this.SatNumberDisplay7.Enabled = false;
            this.SatNumberDisplay7.Location = new System.Drawing.Point(11, 373);
            this.SatNumberDisplay7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatNumberDisplay7.Name = "SatNumberDisplay7";
            this.SatNumberDisplay7.Size = new System.Drawing.Size(57, 29);
            this.SatNumberDisplay7.TabIndex = 30;
            this.SatNumberDisplay7.Visible = false;
            // 
            // SatNumberDisplay6
            // 
            this.SatNumberDisplay6.Enabled = false;
            this.SatNumberDisplay6.Location = new System.Drawing.Point(11, 321);
            this.SatNumberDisplay6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatNumberDisplay6.Name = "SatNumberDisplay6";
            this.SatNumberDisplay6.Size = new System.Drawing.Size(57, 29);
            this.SatNumberDisplay6.TabIndex = 29;
            this.SatNumberDisplay6.Visible = false;
            // 
            // SatNumberDisplay5
            // 
            this.SatNumberDisplay5.Enabled = false;
            this.SatNumberDisplay5.Location = new System.Drawing.Point(11, 273);
            this.SatNumberDisplay5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatNumberDisplay5.Name = "SatNumberDisplay5";
            this.SatNumberDisplay5.Size = new System.Drawing.Size(57, 29);
            this.SatNumberDisplay5.TabIndex = 28;
            this.SatNumberDisplay5.Visible = false;
            // 
            // SatNumberDisplay4
            // 
            this.SatNumberDisplay4.Enabled = false;
            this.SatNumberDisplay4.Location = new System.Drawing.Point(11, 229);
            this.SatNumberDisplay4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatNumberDisplay4.Name = "SatNumberDisplay4";
            this.SatNumberDisplay4.Size = new System.Drawing.Size(57, 29);
            this.SatNumberDisplay4.TabIndex = 27;
            this.SatNumberDisplay4.Visible = false;
            // 
            // SatNumberDisplay3
            // 
            this.SatNumberDisplay3.Enabled = false;
            this.SatNumberDisplay3.Location = new System.Drawing.Point(11, 177);
            this.SatNumberDisplay3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatNumberDisplay3.Name = "SatNumberDisplay3";
            this.SatNumberDisplay3.Size = new System.Drawing.Size(57, 29);
            this.SatNumberDisplay3.TabIndex = 26;
            this.SatNumberDisplay3.Visible = false;
            // 
            // SatNumberDisplay2
            // 
            this.SatNumberDisplay2.Enabled = false;
            this.SatNumberDisplay2.Location = new System.Drawing.Point(11, 127);
            this.SatNumberDisplay2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatNumberDisplay2.Name = "SatNumberDisplay2";
            this.SatNumberDisplay2.Size = new System.Drawing.Size(57, 29);
            this.SatNumberDisplay2.TabIndex = 25;
            this.SatNumberDisplay2.Visible = false;
            // 
            // SatNumberDisplay1
            // 
            this.SatNumberDisplay1.Enabled = false;
            this.SatNumberDisplay1.Location = new System.Drawing.Point(11, 76);
            this.SatNumberDisplay1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatNumberDisplay1.Name = "SatNumberDisplay1";
            this.SatNumberDisplay1.Size = new System.Drawing.Size(57, 29);
            this.SatNumberDisplay1.TabIndex = 24;
            this.SatNumberDisplay1.Visible = false;
            // 
            // SatIndicator11
            // 
            this.SatIndicator11.Location = new System.Drawing.Point(187, 574);
            this.SatIndicator11.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatIndicator11.MarqueeAnimationSpeed = 0;
            this.SatIndicator11.Maximum = 80;
            this.SatIndicator11.Name = "SatIndicator11";
            this.SatIndicator11.Size = new System.Drawing.Size(128, 39);
            this.SatIndicator11.TabIndex = 23;
            this.SatIndicator11.Visible = false;
            // 
            // SatIndicator10
            // 
            this.SatIndicator10.Location = new System.Drawing.Point(187, 524);
            this.SatIndicator10.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatIndicator10.MarqueeAnimationSpeed = 0;
            this.SatIndicator10.Maximum = 80;
            this.SatIndicator10.Name = "SatIndicator10";
            this.SatIndicator10.Size = new System.Drawing.Size(128, 39);
            this.SatIndicator10.TabIndex = 22;
            this.SatIndicator10.Visible = false;
            // 
            // SatIndicator9
            // 
            this.SatIndicator9.Location = new System.Drawing.Point(187, 473);
            this.SatIndicator9.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatIndicator9.MarqueeAnimationSpeed = 0;
            this.SatIndicator9.Maximum = 80;
            this.SatIndicator9.Name = "SatIndicator9";
            this.SatIndicator9.Size = new System.Drawing.Size(128, 39);
            this.SatIndicator9.TabIndex = 21;
            this.SatIndicator9.Visible = false;
            // 
            // SatIndicator8
            // 
            this.SatIndicator8.Location = new System.Drawing.Point(187, 425);
            this.SatIndicator8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatIndicator8.MarqueeAnimationSpeed = 0;
            this.SatIndicator8.Maximum = 80;
            this.SatIndicator8.Name = "SatIndicator8";
            this.SatIndicator8.Size = new System.Drawing.Size(128, 39);
            this.SatIndicator8.TabIndex = 20;
            this.SatIndicator8.Visible = false;
            // 
            // SatIndicator7
            // 
            this.SatIndicator7.Location = new System.Drawing.Point(187, 375);
            this.SatIndicator7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatIndicator7.MarqueeAnimationSpeed = 0;
            this.SatIndicator7.Maximum = 80;
            this.SatIndicator7.Name = "SatIndicator7";
            this.SatIndicator7.Size = new System.Drawing.Size(128, 39);
            this.SatIndicator7.TabIndex = 19;
            this.SatIndicator7.Visible = false;
            // 
            // SatIndicator6
            // 
            this.SatIndicator6.Location = new System.Drawing.Point(187, 319);
            this.SatIndicator6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatIndicator6.MarqueeAnimationSpeed = 0;
            this.SatIndicator6.Maximum = 80;
            this.SatIndicator6.Name = "SatIndicator6";
            this.SatIndicator6.Size = new System.Drawing.Size(128, 39);
            this.SatIndicator6.TabIndex = 18;
            this.SatIndicator6.Visible = false;
            // 
            // SatIndicator5
            // 
            this.SatIndicator5.Location = new System.Drawing.Point(187, 271);
            this.SatIndicator5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatIndicator5.MarqueeAnimationSpeed = 0;
            this.SatIndicator5.Maximum = 80;
            this.SatIndicator5.Name = "SatIndicator5";
            this.SatIndicator5.Size = new System.Drawing.Size(128, 39);
            this.SatIndicator5.TabIndex = 17;
            this.SatIndicator5.Visible = false;
            // 
            // SatIndicator4
            // 
            this.SatIndicator4.Location = new System.Drawing.Point(187, 223);
            this.SatIndicator4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatIndicator4.MarqueeAnimationSpeed = 0;
            this.SatIndicator4.Maximum = 80;
            this.SatIndicator4.Name = "SatIndicator4";
            this.SatIndicator4.Size = new System.Drawing.Size(128, 39);
            this.SatIndicator4.TabIndex = 16;
            this.SatIndicator4.Visible = false;
            // 
            // SatIndicator3
            // 
            this.SatIndicator3.Location = new System.Drawing.Point(187, 177);
            this.SatIndicator3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatIndicator3.MarqueeAnimationSpeed = 0;
            this.SatIndicator3.Maximum = 80;
            this.SatIndicator3.Name = "SatIndicator3";
            this.SatIndicator3.Size = new System.Drawing.Size(128, 39);
            this.SatIndicator3.TabIndex = 15;
            this.SatIndicator3.Visible = false;
            // 
            // SatIndicator2
            // 
            this.SatIndicator2.Location = new System.Drawing.Point(187, 127);
            this.SatIndicator2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatIndicator2.MarqueeAnimationSpeed = 0;
            this.SatIndicator2.Maximum = 80;
            this.SatIndicator2.Name = "SatIndicator2";
            this.SatIndicator2.Size = new System.Drawing.Size(128, 39);
            this.SatIndicator2.TabIndex = 14;
            this.SatIndicator2.Visible = false;
            // 
            // SatIndicator1
            // 
            this.SatIndicator1.Location = new System.Drawing.Point(187, 78);
            this.SatIndicator1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatIndicator1.MarqueeAnimationSpeed = 0;
            this.SatIndicator1.Maximum = 80;
            this.SatIndicator1.Name = "SatIndicator1";
            this.SatIndicator1.Size = new System.Drawing.Size(128, 39);
            this.SatIndicator1.TabIndex = 13;
            this.SatIndicator1.Visible = false;
            // 
            // SatNumberDisplay0
            // 
            this.SatNumberDisplay0.Enabled = false;
            this.SatNumberDisplay0.Location = new System.Drawing.Point(11, 28);
            this.SatNumberDisplay0.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatNumberDisplay0.Name = "SatNumberDisplay0";
            this.SatNumberDisplay0.Size = new System.Drawing.Size(57, 29);
            this.SatNumberDisplay0.TabIndex = 12;
            this.SatNumberDisplay0.Visible = false;
            // 
            // SatIndicator0
            // 
            this.SatIndicator0.ForeColor = System.Drawing.Color.Lime;
            this.SatIndicator0.Location = new System.Drawing.Point(187, 28);
            this.SatIndicator0.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatIndicator0.Maximum = 80;
            this.SatIndicator0.Name = "SatIndicator0";
            this.SatIndicator0.Size = new System.Drawing.Size(128, 39);
            this.SatIndicator0.TabIndex = 0;
            this.SatIndicator0.Visible = false;
            // 
            // SatDisplayBox
            // 
            this.SatDisplayBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SatDisplayBox.BackgroundImage")));
            this.SatDisplayBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SatDisplayBox.Location = new System.Drawing.Point(695, 4);
            this.SatDisplayBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatDisplayBox.Name = "SatDisplayBox";
            this.SatDisplayBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SatDisplayBox.Size = new System.Drawing.Size(414, 410);
            this.SatDisplayBox.TabIndex = 6;
            this.SatDisplayBox.TabStop = false;
            this.SatDisplayBox.Text = "Satellite Locations";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(955, 995);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "© BMS Inc 2011";
            // 
            // GPSGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 1021);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SatDisplayBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "GPSGUI";
            this.Text = "GPS Reader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectedSerialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox baudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button serialMonStartStop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Lattitude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Longitude;
        private System.Windows.Forms.TextBox Altitude;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FixTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SatsTracked;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox raw_NMEA_Data;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar SatIndicator0;
        private System.Windows.Forms.TextBox SatNumberDisplay0;
        private System.Windows.Forms.TextBox comPortStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox gpsStatus;
        private System.Windows.Forms.ProgressBar SatIndicator11;
        private System.Windows.Forms.ProgressBar SatIndicator10;
        private System.Windows.Forms.ProgressBar SatIndicator9;
        private System.Windows.Forms.ProgressBar SatIndicator8;
        private System.Windows.Forms.ProgressBar SatIndicator7;
        private System.Windows.Forms.ProgressBar SatIndicator6;
        private System.Windows.Forms.ProgressBar SatIndicator5;
        private System.Windows.Forms.ProgressBar SatIndicator4;
        private System.Windows.Forms.ProgressBar SatIndicator3;
        private System.Windows.Forms.ProgressBar SatIndicator2;
        private System.Windows.Forms.ProgressBar SatIndicator1;
        private System.Windows.Forms.TextBox SatNumberDisplay11;
        private System.Windows.Forms.TextBox SatNumberDisplay10;
        private System.Windows.Forms.TextBox SatNumberDisplay9;
        private System.Windows.Forms.TextBox SatNumberDisplay8;
        private System.Windows.Forms.TextBox SatNumberDisplay7;
        private System.Windows.Forms.TextBox SatNumberDisplay6;
        private System.Windows.Forms.TextBox SatNumberDisplay5;
        private System.Windows.Forms.TextBox SatNumberDisplay4;
        private System.Windows.Forms.TextBox SatNumberDisplay3;
        private System.Windows.Forms.TextBox SatNumberDisplay2;
        private System.Windows.Forms.TextBox SatNumberDisplay1;
        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.TextBox SNR11;
        private System.Windows.Forms.TextBox SNR10;
        private System.Windows.Forms.TextBox SNR9;
        private System.Windows.Forms.TextBox SNR8;
        private System.Windows.Forms.TextBox SNR7;
        private System.Windows.Forms.TextBox SNR6;
        private System.Windows.Forms.TextBox SNR5;
        private System.Windows.Forms.TextBox SNR4;
        private System.Windows.Forms.TextBox SNR3;
        private System.Windows.Forms.TextBox SNR2;
        private System.Windows.Forms.TextBox SNR1;
        private System.Windows.Forms.TextBox SNR0;
        private System.Windows.Forms.GroupBox SatDisplayBox;
        private System.Windows.Forms.Label label10;
    }
}

