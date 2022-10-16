using System;
using System.IO;  //For debug, dumping data to text file
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace BMS_GPS_Reader
{
   
public partial class GPSGUI : Form
    {
    BackgroundWorker bw = new BackgroundWorker();
    BackgroundWorker mapDraw = new BackgroundWorker();
    private const double CENTER = 113;    //center of drawing (pixels)
    private double SCALE_FACTOR = 3.2 / 90.0;  //pixels from 90deg to 0 on drawing

    Color SetColorGreen = Color.LimeGreen;
    Color SetColorYellow = Color.Yellow;
    Color SetColorRed = Color.Red;

    public GPSGUI()
        {
        InitializeComponent();
        GPSGUILoadSerialPorts();
        baudRate.SelectedIndex = 2;
        bw.WorkerSupportsCancellation = true;
        bw.WorkerReportsProgress = true;
        bw.DoWork += DownloadGpsDataFromDevice;
        bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
        }


    // a progress bar extension to override visual styles on only the progress bar
    /*
    public class ProgressBarEx : ProgressBar
    {
    public ProgressBarEx()
        {
        this.SetStyle(ControlStyles.UserPaint, true);
        }

    protected override void OnPaint(PaintEventArgs e)
        {
        LinearGradientBrush brush = null;

        Rectangle rec = new Rectangle(0, 0, this.Width, this.Height);

        if (ProgressBarRenderer.IsSupported)
            ProgressBarRenderer.DrawHorizontalBar(e.Graphics, rec);

        rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
        rec.Height -= 4;
        brush = new LinearGradientBrush(rec, this.ForeColor, this.BackColor, LinearGradientMode.Vertical);
        e.Graphics.FillRectangle(brush, 2, 2, rec.Width, rec.Height);
        }
    }
    */


        /// <summary>
        /// Enumerates the serial ports.
        /// </summary>
        private void GPSGUILoadSerialPorts()
        {
        //Clears the dropdown
        selectedSerialPort.Items.Clear();
        // scan for ports
        string[] ports = SerialPort.GetPortNames();
        //TODO grey out active ports
        //if (!(comPort.IsOpen == true)) comPort.Open();
        foreach (string port in ports)
            {
            //Adds them to dropdown
            selectedSerialPort.Items.Add(port);
            }
        }

        /// <summary>
        /// Handles the Click event of the serialMonStartStop control, starts or stops reading the serial port.
        /// </summary>
        /// <param name="sender">The start stop button.</param>
        /// <param name="e">The click event <see cref="System.EventArgs"/> None in this instance</param>
        private void serialMonStartStop_Click(object sender, EventArgs e)
        {
        if (selectedSerialPort.Text != "")
            {  
            if (serialMonStartStop.Text == "Start Reading")
                {
                raw_NMEA_Data.Text = "";
                serialMonStartStop.Text = "Stop Reading";
                comPortStatus.Text = "Running";
                selectedSerialPort.Enabled = false;
                baudRate.Enabled = false;
                TestObject test = new TestObject
                    {
                    comPortBW = selectedSerialPort.Text,
                    baudRateBW = Convert.ToInt32(baudRate.Text)
                    };
                if (!bw.IsBusy)
                    {
                    bw.RunWorkerAsync(test);
                    }
                //else 
                    //{
                    //TODO some sorta error message
                    //}
                }
            else if (serialMonStartStop.Text == "Stop Reading")
                {
                selectedSerialPort.Enabled = true;
                baudRate.Enabled = true;
                comPortStatus.Text = "Stopped";
                serialMonStartStop.Text = "Start Reading";
                bw.CancelAsync();
                }
            }
        else
            {
            MessageBox.Show("Must select a com port");
            }
        }

        /// <summary>
        /// Handles the RunWorkerCompleted event of the bw control, should never really be reached.
        /// </summary>
        /// <param name="sender">CAlled by the backgorund worker on the completed event</param>
        /// <param name="e">Sends any data via event arguments e <see cref="System.ComponentModel.RunWorkerCompletedEventArgs"/> instance containing the event data.</param>
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        //TODO add some error handling etc
        if ((e.Cancelled == true))
            { 
            //this.tbProgress.Text = "Canceled!";

            }
        else if (!(e.Error == null))
            {
            MessageBox.Show("Error: " + e.Error.Message);
            //this.tbProgress.Text = ("Error: " + e.Error.Message);
            }
        else
            {
            //this.tbProgress.Text = "Done!";
            }       
        }

        /// <summary>
        /// Degrees to radian conversion.
        /// </summary>
        /// <param name="angle">double angle.</param>
        /// <returns>radians</returns>
        private double DegreeToRadian(double angle)
        {
        return Math.PI * angle / 180.0;
        }

        /// <summary>
        /// Radians to degrees conversion.
        /// </summary>Radians</param>
        /// <returns>degrees</returns>
        private double RadianToDegree(double radians)
        {
        return radians * (180.0 / Math.PI);
        }

        /// <summary>
        /// Handles the ProgressChanged event of the bw control, updates the GUI on UI thread.
        /// </summary>
        /// <param name="sender">The Backgorund worker thread</param>
        /// <param name="e">The event argument object<see cref="System.ComponentModel.ProgressChangedEventArgs"/> instance containing the event data,the class 'CurrentStatus' is used to buffer values .</param>
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        string temp = "";
        CurrentStatus status = e.UserState as CurrentStatus;
            //Raw Data Display Section
        if (status.rawData != null && status.rawData != "")
            {
            raw_NMEA_Data.SelectionStart = raw_NMEA_Data.Text.Length;
            raw_NMEA_Data.AppendText(status.rawData);
            if (status.SatDataLine2 != null && status.SatDataLine2 != "") raw_NMEA_Data.AppendText(status.SatDataLine2);
            if (status.SatDataLine3 != null && status.SatDataLine3 != "") raw_NMEA_Data.AppendText(status.SatDataLine3);
            raw_NMEA_Data.ScrollToCaret();
            }
       
        // Recommended minimum used for locked/unlocked
        if (status.header == "RMC")
            {
            if (status.MinDataLocked == "A")
                {
                gpsStatus.Text = "Locked";
                }
            else
                {
                gpsStatus.Text = "Unlocked";
                }
            }
        // GPS Data section
        if (status.header == "GGA")
            {
            if (status.SatsTracked != null && status.SatsTracked != "")
                {
                this.SatsTracked.Text = status.SatsTracked;
                //if (Convert.ToInt32(status.SatsTracked) < 5) gpsStatus.Text = "tracking";
                //if (Convert.ToInt32(status.SatsTracked) >= 5) gpsStatus.Text = "locked";                    
                }
            if (status.SatsTracked == "" || status.SatsTracked == "0" || status.SatsTracked == "00")
                {
                this.SatsTracked.Text = "00";
                //gpsStatus.Text = "unlocked";
                }

            if (status.Lattitude != null && status.Lattitude != "")
                {
                temp = status.Lattitude.Replace(".", "");
                temp = temp.Substring(0, 2) + "." + temp.Substring(3, 3);

                //Lattitude Section
                if (status.LattitudeBearing == "N")
                    {
                    this.Lattitude.Text = temp;
                    }
                if (status.LattitudeBearing == "S")
                    {
                    this.Lattitude.Text = "-" + temp;
                    }
                }
                if (status.Lattitude == "")
                    {
                    this.Lattitude.Text = "Not locked";
                    }

                //Longitude section
                if (status.Longitude != null && status.Longitude != "")
                    {
                    temp = status.Longitude.Replace(".", "");
                    temp = temp.Substring(0, 3) + "." + temp.Substring(3, 3);
                    if (status.LongitudeBearing == "W")
                        {
                        this.Longitude.Text = "-" + temp;
                        }
                    if (status.LongitudeBearing == "E")
                        {
                        this.Longitude.Text = temp;
                        }
                    }
                if (status.Longitude == "")
                    {
                    this.Longitude.Text = "Not locked";
                    }

                //Altitude section
                if (status.Altitude != null && status.Altitude != "")
                    {
                    this.Altitude.Text = status.Altitude + " Meters";
                    }
                if (status.Altitude == "")
                    {
                    this.Altitude.Text = "Not locked";
                    }

                // GPS TIme Hack section
                if (status.FixTime != null && status.FixTime != "")
                    {
                    temp = status.FixTime;
                    temp = temp.Substring(0, 2) + ":" + temp.Substring(2, 2) + ":" + temp.Substring(4, 2) + " UMC";
                    this.FixTime.Text = temp;
                    }
                if (status.FixTime == "")
                    {
                    this.FixTime.Text = "Not locked";
                    }
                }
            //Satellite data section
            if (status.header == "GSV")
            {
            SatDisplayBox.Refresh();
            // Put all my textboxes into an array
            TextBox[] SatLabelTxt = { SatNumberDisplay0, SatNumberDisplay1, SatNumberDisplay2, SatNumberDisplay3, SatNumberDisplay4, SatNumberDisplay5, SatNumberDisplay6, SatNumberDisplay7, SatNumberDisplay8, SatNumberDisplay9, SatNumberDisplay10, SatNumberDisplay11 };
            // Put my SNR textboxes into an array
            TextBox[] SNRArray = { SNR0, SNR1, SNR2, SNR3, SNR4, SNR5, SNR6, SNR7, SNR8, SNR9, SNR10, SNR11 };
            //Put all my progress bars into an array
            ProgressBar[] RSSIArray = { SatIndicator0, SatIndicator1, SatIndicator2, SatIndicator3, SatIndicator4, SatIndicator5, SatIndicator6, SatIndicator7, SatIndicator8, SatIndicator9, SatIndicator10, SatIndicator11 };   
            temp = "";
            //TODO sometimes the GTF400 has partial lines. Look into filling them out
            //Also find out WTF is with it having an extra comma!?!?! Move all this shit to background worker section, dump into (split ",") an array, remove unneeded shite, and re-stringinate it 
            int lineCount = Convert.ToInt32((status.SatDataLine1.Substring(7, 1)));
            if (lineCount >= 1 && status.SatDataLine1 != null && status.SatDataLine1 != "") temp = temp + ((status.SatDataLine1.Remove((status.SatDataLine1.Length - 4), 4).Remove(0, 14)));
            if (lineCount == 1) temp += ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,";
            if (lineCount >= 2 && status.SatDataLine2 != null && status.SatDataLine2 != "") temp = temp + ("," + (status.SatDataLine2.Remove((status.SatDataLine2.Length - 4), 4).Remove(0, 14)));
            if (lineCount == 2) temp += ",,,,,,,,,,,,,,,,";
            if (lineCount == 3 && status.SatDataLine3 != null && status.SatDataLine3 != "") temp = temp + ("," + (status.SatDataLine3.Remove((status.SatDataLine3.Length - 4), 4).Remove(0, 14)));
            string[] satDataArray = temp.Split(',');
            //Turn any blank entries into 0s
            if (satDataArray.Length == 48)
                {
                for (int j = 0; j < satDataArray.Length; j++)
                    {
                    if (satDataArray[j] == "" || satDataArray[j] == " ")
                        {
                        satDataArray[j] = "0";
                        }
                    }
                for (int i = 0; i < 12; i++)
                    {
                    // if sat number isn't a zero (i.e. has a number)
                    if (satDataArray[(i * 4)] != "0")
                        {
                        SatLabelTxt[i].Visible = true;
                        SNRArray[i].Visible = true;
                        RSSIArray[i].Visible = true;
                        SatLabelTxt[i].Text = "#" + satDataArray[i * 4];
                        SNRArray[i].Text = "SNR " + satDataArray[(i * 4) + 3];
                        RSSIArray[i].Value = Convert.ToInt32(satDataArray[(i * 4) + 3]);
                        
                        
                        //Do my polar mapping here
                        //Elevation = (i * 4) + 1;  Note the +1 is an offset of 1 pixel
                        //Azimuth = (i * 4) +2;  Note the +2 is an offset of 2 pixels
                        double r = 90.0 - RadianToDegree((i * 4) + 1);
                        double theta = 90.0 - RadianToDegree((i * 4) + 2);
                        theta = DegreeToRadian(theta);

                        double xLocation = CENTER + SCALE_FACTOR * r * Math.Cos(theta);
                        double yLocation = CENTER + SCALE_FACTOR * r * Math.Sin(theta);
                        Point point = new Point((int)xLocation, (int)yLocation);
                        Point offsetTextpoint = new Point((int)xLocation, (int)yLocation + 4);
                        
                        if(Convert.ToInt32(satDataArray[(i * 4) + 3]) > 18 && Convert.ToInt32(satDataArray[(i * 4) + 3]) < 30 )
                            {
                            RSSIArray[i].ForeColor = Color.Yellow;
                            Graphics g = Graphics.FromHwnd(SatDisplayBox.Handle);
                            SolidBrush brush = new SolidBrush(SetColorYellow);
                            Rectangle rect = new Rectangle(point, new Size(20, 20));
                            g.FillEllipse(brush, rect);
                            g.DrawString(satDataArray[i * 4], new Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, offsetTextpoint);
                            g.Dispose();                     
                            }
                        if (Convert.ToInt32(satDataArray[(i * 4) + 3]) < 18 && Convert.ToInt32(satDataArray[(i * 4) + 3]) >= 0)
                            {
                            RSSIArray[i].ForeColor = Color.Red;
                            Graphics g = Graphics.FromHwnd(SatDisplayBox.Handle);
                            SolidBrush brush = new SolidBrush(SetColorRed);
                            Rectangle rect = new Rectangle(point, new Size(20, 20));
                            g.FillEllipse(brush, rect);
                            g.DrawString(satDataArray[i * 4], new Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, offsetTextpoint);
                            g.Dispose();                         
                            }
                        else if (Convert.ToInt32(satDataArray[(i * 4) + 3]) > 29 )
                            {
                            RSSIArray[i].ForeColor = Color.LimeGreen;
                            Graphics g = Graphics.FromHwnd(SatDisplayBox.Handle);
                            SolidBrush brush = new SolidBrush(SetColorGreen);
                            Rectangle rect = new Rectangle(point, new Size(20, 20));
                            g.FillEllipse(brush, rect);
                            g.DrawString(satDataArray[i * 4], new Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, offsetTextpoint);
                            g.Dispose();
                            }                  
                        }
                    // if sat number is a zero, therefore a blank entry
                    else if(satDataArray[(i * 4)] == "0")
                        {
                        //Make everybody invisible

                        SatLabelTxt[i].Visible = false;
                        RSSIArray[i].ForeColor = Color.LimeGreen;
                        RSSIArray[i].Value = 0;
                        RSSIArray[i].Text = "";
                        RSSIArray[i].Visible = false;
                        }
                    }
                }
            }            
        }


        /// <summary>
        /// Downloads the GPS data from serial port.
        /// </summary>
        /// <param name="sender">Background worker launched from start/stop button click</param>
        /// <param name="e">The class TestObjects values <see cref="System.ComponentModel.DoWorkEventArgs"/> Uses the class TestObject to send serial port number and baud rate</param>
        private void DownloadGpsDataFromDevice(object sender, DoWorkEventArgs e)
        {
        try
            {
            BackgroundWorker bw = sender as BackgroundWorker;

            TestObject argumentTest = e.Argument as TestObject;
            SerialPort port = new SerialPort(argumentTest.comPortBW, argumentTest.baudRateBW, Parity.None, 8, StopBits.One);
            if (!(port.IsOpen == true)) port.Open();
            for (; ; )
                {
                if ((bw.CancellationPending == true))
                    {
                    e.Cancel = true;
                    port.Close();
                    port.Dispose();
                    break;
                    }
                else
                    {
                    string s = port.ReadLine();
                    if (s.Length > 6)
                        {                  
                        CurrentStatus status = new CurrentStatus();
                        string sentencePrefix = s.Substring(3, 3);
                        //sentencePrefix = s.Substring(3, 3);
                        status.header = sentencePrefix;
                        status.rawData = s;
                        if (sentencePrefix == "GGA")
                            {
                            string[] strArr = s.Split(',');
                            status.Lattitude = strArr[2]; //Lattitude
                            status.LattitudeBearing = strArr[3]; //Lattitude E/W
                            status.Longitude = strArr[4];// Longitude
                            status.LongitudeBearing = strArr[5];// Longitude N/S
                            status.Altitude = strArr[9];// Altitude
                            status.FixTime = strArr[1];// Fix time
                            status.SatsTracked = strArr[7];
                            }
                        if (sentencePrefix == "GSV")
                            {
                            if (s.Length > 10)
                                {
                                status.SatDataLine1 = s;
                                int lineCount = Convert.ToInt32((s.Substring(7, 1)));
                                if (lineCount >= 2) status.SatDataLine2 = port.ReadLine();
                                //MessageBox.Show(status.SatDataLine2);
                                if (lineCount == 3) status.SatDataLine3 = port.ReadLine();
                                }
                            }
                        if (sentencePrefix == "RMC")
                            {
                            if (s.Length > 6)
                                {
                                string[] strArr = s.Split(',');
                                status.MinDataLocked = strArr[2];
                                }
                            }
                        bw.ReportProgress(1, status);
                        }                 
                    }
                }
            }
        catch (Exception error)
            {
            if (port.IsOpen)
                {
                port.Close();
                port.Dispose();
                }
            e.Cancel = true;
            MessageBox.Show(error.ToString());
            }
        }

        /// <summary>
        /// The class used to pass data back to UI thread
        /// </summary>
        class CurrentStatus
        {
        public string header { get; set; }
        public string rawData { get; set; }

        public string Lattitude { get; set; }
        public string LattitudeBearing { get; set; }
        public string Longitude { get; set; }
        public string LongitudeBearing { get; set; }
        public string Altitude { get; set; }
        public string FixTime { get; set; }
        public string SatsTracked { get; set; }

        public string MinDataLocked { get; set; }

        public string SatDataLine1 { get; set; }
        public string SatDataLine2 { get; set; }
        public string SatDataLine3 { get; set; }
        }

        /// <summary>
        /// The class used to send port and baud info to background worker thread
        /// </summary>
        class TestObject
        {
        public string comPortBW { get; set; }
        public int baudRateBW { get; set; }
        }

        /// <summary>
        /// Handles the DropDown event of the selectedSerialPort control, erases all values and repopulates via load serial ports function.
        /// </summary>
        /// <param name="sender">Click event of dropdown</param>
        /// <param name="e">The event  <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void selectedSerialPort_DropDown(object sender, EventArgs e)
        {
        GPSGUILoadSerialPorts();
        }      
    }

}
