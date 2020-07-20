using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;

namespace TimingBoxController
{
    public partial class Form1 : Form
    {
        SerialPort ComPort = new SerialPort();
        delegate void SetTextCallback(string text);
        bool SerialPortOpen = false;

        public static class Variables
        {
            public static string logfilename;               // Logfile name
            public static System.IO.StreamWriter logfile;   // Logfile file ID
        }

        static class Constants
        {
            public const string SoftwareVersion = "1.4.2";
            public const int Baud = 9600;
            public const int CheckConnection = 0;

            public const int InternalTrigger = 10;
            public const int ForceShutterOpen = 11;
            public const int Rx1Manual = 12;
            public const int Rx1Active = 13;
            public const int Rx2Manual = 14;
            public const int Rx2Active = 15;

            public const int Rate = 20;
            public const int InitialDelay = 21;
            public const int ShutterOpen = 22;
            public const int Camera = 23;
            public const int CameraDelay = 24;
            public const int ShutterClose = 25;
            public const int ImagingExposures = 26;
            public const int ImagingRepeats = 27;
            public const int ImagingGap = 28;
            public const int ImagingFlats = 29;
            public const int Rx1Delay = 30;
            public const int Rx1Pulse = 31;
            public const int Rx1Repeats = 32;
            public const int Rx2Delay = 33;
            public const int Rx2Pulse = 34;
            public const int Rx2Repeats = 35;

            public const int ImagingStarts = 40;
            public const int Rx1Starts = 41;
            public const int Rx2Starts = 42;

            public const int ShutterMode = 50;

            public const int Search = 60;
            public const int OneShot = 61;
            public const int AcquireOne = 62;
            public const int Run = 63;
            public const int AcquireFlats = 64;
            public const int Stop = 65;
        }

        public Form1()
        {
            InitializeComponent();
            this.Text = "Timing Box Control v" + Constants.SoftwareVersion;

            ComPort.BaudRate = Constants.Baud;
            ComPort.DataBits = 8;
            ComPort.Parity = Parity.None;
            ComPort.StopBits = StopBits.One;
            ComPort.NewLine = "\n";
            //ComPort.Handshake = Handshake.None;
            ComPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_1);
            LoadSettings();
            
            Variables.logfile = new System.IO.StreamWriter(Variables.logfilename, append: true);
            Variables.logfile.WriteLine("-------------------------------------------------------");
            WriteLog("Timing hub version " + Constants.SoftwareVersion + " opened");

            this.ActiveControl = btnSearch;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteLog("Timing hub closed");
            Variables.logfile.Close();
            SaveSettings();
        }

        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            int serialLength, serialParameter, serialValue;
            string InputData = ComPort.ReadLine();
            Console.WriteLine(InputData);
            ThreadHelperClass.SetText(this, labelRxCommand, Convert.ToString(InputData));
            parseFromString(InputData, out serialLength, out serialParameter, out serialValue);

            switch (serialParameter)
            {
                case Constants.CheckConnection:
                    BeginInvoke(new EventHandler(delegate
                    {
                        SendAllSettings();
                    }));
                    WriteLog("Connected to timing hub");
                    MessageBox.Show(new Form { TopMost = true }, "Successfully connected to timing box");
                    break;
                case Constants.Search:
                    btnSearch.BackColor = Color.Green;
                    btnOneShot.BackColor = default(Color);
                    btnAcquireOne.BackColor = default(Color);
                    btnRun.BackColor = default(Color);
                    btnAcquireFlats.BackColor = default(Color);
                    btnStop.BackColor = Color.Red;
                    btnStop.Font = new Font(btnStop.Font, FontStyle.Bold);
                    break;
                case Constants.OneShot:
                    btnSearch.BackColor = default(Color);
                    btnOneShot.BackColor = Color.Green;
                    btnAcquireOne.BackColor = default(Color);
                    btnRun.BackColor = default(Color);
                    btnAcquireFlats.BackColor = default(Color);
                    btnStop.BackColor = Color.Red;
                    btnStop.Font = new Font(btnStop.Font, FontStyle.Bold);
                    break;
                case Constants.AcquireOne:
                    btnSearch.BackColor = default(Color);
                    btnOneShot.BackColor = default(Color);
                    btnAcquireOne.BackColor = Color.Green;
                    btnRun.BackColor = default(Color);
                    btnAcquireFlats.BackColor = default(Color);
                    btnStop.BackColor = Color.Red;
                    btnStop.Font = new Font(btnStop.Font, FontStyle.Bold);
                    break;
                case Constants.Run:
                    btnSearch.BackColor = default(Color);
                    btnOneShot.BackColor = default(Color);
                    btnAcquireOne.BackColor = default(Color);
                    btnRun.BackColor = Color.Green;
                    btnAcquireFlats.BackColor = default(Color);
                    btnStop.BackColor = Color.Red;
                    btnStop.Font = new Font(btnStop.Font, FontStyle.Bold);
                    break;
                case Constants.AcquireFlats:
                    btnSearch.BackColor = default(Color);
                    btnOneShot.BackColor = default(Color);
                    btnAcquireOne.BackColor = default(Color);
                    btnRun.BackColor = default(Color);
                    btnAcquireFlats.BackColor = Color.Green;
                    btnStop.BackColor = Color.Red;
                    btnStop.Font = new Font(btnStop.Font, FontStyle.Bold); break;
                case Constants.Stop:
                    btnSearch.BackColor = default(Color);
                    btnOneShot.BackColor = default(Color);
                    btnAcquireOne.BackColor = default(Color);
                    btnRun.BackColor = default(Color);
                    btnAcquireFlats.BackColor = default(Color);
                    btnStop.BackColor = default(Color);
                    btnStop.Font = new Font(btnStop.Font, FontStyle.Regular);
                    this.ActiveControl = btnStop;
                    Console.Beep(4000, 500);
                    break;
            }
        }

        public void parseFromString(string input, out int serialLength, out int serialParameter, out int serialValue)
        {
            char[] delimiterChars = { '<', ',' , '\r' };
            var split = input.Split(delimiterChars);
            serialLength = int.Parse(split[1]);
            serialParameter = 0;
            serialValue = 0;

            switch (serialLength)
            {
                case 0:
                    serialParameter = 0;
                    serialValue = 0;
                    break;
                case 1:
                    serialParameter = int.Parse(split[2]);
                    serialValue = 0;
                    break;
                default:
                    serialParameter = int.Parse(split[2]);
                    serialValue = int.Parse(split[3]);
                    break;
            }
        }

        public static class ThreadHelperClass
        {
            delegate void SetTextCallback(Form f, Control ctrl, string text);
            /// <summary>
            /// Set text property of various controls
            /// </summary>
            /// <param name="form">The calling form</param>
            /// <param name="ctrl"></param>
            /// <param name="text"></param>
            public static void SetText(Form form, Control ctrl, string text)
            {
                // InvokeRequired required compares the thread ID of the 
                // calling thread to the thread ID of the creating thread. 
                // If these threads are different, it returns true. 
                if (ctrl.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    form.Invoke(d, new object[] { form, ctrl, text });
                }
                else
                {
                    ctrl.Text = text;
                }
            }
        }

        // --------------- BUTTONS ---------------

        private void btnGetSerialPorts_Click(object sender, EventArgs e)
        {
            cboPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports) cboPorts.Items.Add(port);
            cboPorts.Text = ports[0];
        }

        private void btnPortState_Click(object sender, EventArgs e)
        {
            if (SerialPortOpen)
            {
                btnPortState.Text = "Open";
                SerialPortOpen = false;
                ComPort.DiscardInBuffer();
                ComPort.Close();
                labelRxCommand.Text = "Serial port not open";
                WriteLog("Disconnected from timing hub");
            }
            else
            {
                btnPortState.Text = "Close";
                SerialPortOpen = true;
                ComPort.PortName = Convert.ToString(cboPorts.Text);
                ComPort.Open();
                SendCommand(Constants.CheckConnection);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            LoadSettings();
            SendCommand(Constants.CheckConnection);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SendCommand(Constants.Search);
            WriteLog("SEARCH");
        }

        private void btnOneShot_Click(object sender, EventArgs e)
        {
            SendCommand(Constants.OneShot);
            WriteLog("ONESHOT");
        }

        private void btnAcquireOne_Click(object sender, EventArgs e)
        {
            SendCommand(Constants.AcquireOne);
            WriteLog("ACQUIRE ONE BLOCK");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            SendCommand(Constants.Run);
            WriteLog("RUN");
        }

        private void btnAcquireFlats_Click(object sender, EventArgs e)
        {
            SendCommand(Constants.AcquireFlats);
            WriteLog("FLAT/DARK");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            SendCommand(Constants.Stop);
            WriteLog("STOP");
        }

        // --------------- CHECKBOXES ---------------

        private void checkBoxInternalTrigger_CheckedChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.InternalTrigger, Convert.ToDecimal(checkBoxInternalTrigger.Checked));
            if (checkBoxInternalTrigger.Checked)
            {
                checkBoxInternalTrigger.ForeColor = Color.Red;
                checkBoxInternalTrigger.Font = new Font(checkBoxInternalTrigger.Font, FontStyle.Bold);
            }
            else
            {
                checkBoxInternalTrigger.ForeColor = Color.Black;
                checkBoxInternalTrigger.Font = new Font(checkBoxInternalTrigger.Font, FontStyle.Regular);
            }
        }

        private void checkBoxShutterOpen_CheckedChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.ForceShutterOpen, Convert.ToDecimal(checkBoxShutterOpen.Checked));
            if (checkBoxShutterOpen.Checked)
            {
                checkBoxShutterOpen.ForeColor = Color.Red;
                checkBoxShutterOpen.Font = new Font(checkBoxShutterOpen.Font, FontStyle.Bold);
                WriteLog("Shutter OPEN");
            }
            else
            {
                checkBoxShutterOpen.ForeColor = Color.Black;
                checkBoxShutterOpen.Font = new Font(checkBoxShutterOpen.Font, FontStyle.Regular);
                WriteLog("Shutter normal");
            }
        }

        private void checkBoxRx1Manual_CheckedChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.Rx1Manual, Convert.ToDecimal(checkBoxRx1Manual.Checked));
            if (checkBoxRx1Manual.Checked)
            {
                checkBoxRx1Manual.ForeColor = Color.Red;
                WriteLog("Rx1 ON");
            }
            else
            {
                checkBoxRx1Manual.ForeColor = Color.Black;
                WriteLog("Rx1 OFF");
            }
        }

        private void checkBoxRx2Manual_CheckedChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.Rx2Manual, Convert.ToDecimal(checkBoxRx2Manual.Checked));
            if (checkBoxRx2Manual.Checked)
            {
                checkBoxRx2Manual.ForeColor = Color.Red;
                WriteLog("Rx2 ON");
            }
            else
            {
                checkBoxRx2Manual.ForeColor = Color.Black;
                WriteLog("Rx2 OFF");
            }
        }

        private void checkBoxRx1Active_CheckedChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.Rx1Active, Convert.ToDecimal(checkBoxRx1Active.Checked));
            if (checkBoxRx1Active.Checked) checkBoxRx1Active.ForeColor = Color.Black;
            else checkBoxRx1Active.ForeColor = Color.Red; 
        }

        private void checkBoxRx2Active_CheckedChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.Rx2Active, Convert.ToDecimal(checkBoxRx2Active.Checked));
            if (checkBoxRx2Active.Checked) checkBoxRx2Active.ForeColor = Color.Black;
            else checkBoxRx2Active.ForeColor = Color.Red;
        }

        // --------------- NUMERIC UP/DOWN BOXES ---------------

        private void numericUpDownRate_ValueChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.Rate, numericUpDownRate.Value);
            UpdateAcquireTime();
        }

        private void numericUpDownInitialDelay_ValueChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.InitialDelay, numericUpDownInitialDelay.Value);
            UpdateAcquireTime();
        }

        private void numericUpDownShutterOpen_ValueChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.ShutterOpen, numericUpDownShutterOpen.Value);
            UpdateAcquireTime();
        }

        private void numericUpDownCamera_ValueChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.Camera, numericUpDownCamera.Value);
            UpdateAcquireTime();
        }

        private void numericUpDownCameraDelay_ValueChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.CameraDelay, numericUpDownCameraDelay.Value);
            UpdateAcquireTime();
        }

        private void numericUpDownShutterClose_ValueChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.ShutterClose, numericUpDownShutterClose.Value);
            UpdateAcquireTime();
        }

        private void numericUpDownImagingExposures_ValueChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.ImagingExposures, numericUpDownImagingExposures.Value);
            UpdateAcquireTime();
        }

        private void numericUpDownImagingRepeats_ValueChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.ImagingRepeats, numericUpDownImagingRepeats.Value);
            if (numericUpDownImagingRepeats.Value == 0)
            {
                SendParameterList(Constants.ImagingStarts, "0");
                textBoxImagingStarts.Enabled = false;
            }
            else
            {
                SendParameterList(Constants.ImagingStarts, textBoxImagingStarts.Text);
                textBoxImagingStarts.Enabled = true;
            }
        }

        private void numericUpDownImagingGap_ValueChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.ImagingGap, numericUpDownImagingGap.Value);
        }

        private void numericUpDownImagingFlats_ValueChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.ImagingFlats, numericUpDownImagingFlats.Value);
        }

        private void numericUpDownRx1Delay_ValueChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.Rx1Delay, numericUpDownRx1Delay.Value);
        }

        private void numericUpDownRx1Pulse_ValueChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.Rx1Pulse, numericUpDownRx1Pulse.Value);
        }

        private void numericUpDownRx1Repeats_ValueChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.Rx1Repeats, numericUpDownRx1Repeats.Value);
        }

        private void numericUpDownRx2Delay_ValueChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.Rx2Delay, numericUpDownRx2Delay.Value);
        }

        private void numericUpDownRx2Pulse_ValueChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.Rx2Pulse, numericUpDownRx2Pulse.Value);
        }

        private void numericUpDownRx2Repeats_ValueChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.Rx2Repeats, numericUpDownRx2Repeats.Value);
        }

        // --------------- TEXT BOXES ---------------

        private void textBoxImagingStarts_Leave(object sender, EventArgs e)
        {
            SendParameterList(Constants.ImagingStarts, textBoxImagingStarts.Text);
        }

        private void textBoxRx1Starts_Leave(object sender, EventArgs e)
        {
            SendParameterList(Constants.Rx1Starts, textBoxRx1Starts.Text);
        }

        private void textBoxRx2Starts_Leave(object sender, EventArgs e)
        {
            SendParameterList(Constants.Rx2Starts, textBoxRx2Starts.Text);
        }

        // --------------- COMBO BOXES ---------------

        private void comboBoxShutterMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SendParameter(Constants.ShutterMode, comboBoxShutterMode.SelectedIndex);
            UpdateAcquireTime();

            switch (comboBoxShutterMode.SelectedIndex)
            {
                //Breath
                case 0:
                    numericUpDownShutterOpen.Enabled = true;
                    numericUpDownShutterClose.Enabled = true;
                    break;
                // Image
                case 1:
                    numericUpDownShutterOpen.Enabled = true;
                    numericUpDownShutterClose.Enabled = true;
                    break;
                // Block
                case 2:
                    numericUpDownShutterOpen.Enabled = false;
                    numericUpDownShutterClose.Enabled = false;
                    break;
                // None
                case 3:
                    numericUpDownShutterOpen.Enabled = false;
                    numericUpDownShutterClose.Enabled = false;
                    break;
            }
        }

        // --------------- DIALOG BOXES ---------------

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Variables.logfilename = saveFileDialog1.FileName;
        }

        // --------------- USER FUNCTIONS ---------------

        public void SendCommand(int parameter)
        {
            string command = string.Format(">{0:0000},{1:0000}", 1, parameter);
            SerialCommand(command);
        }

        public void SendParameter(int parameter, decimal value)
        {
            string command = string.Format(">{0:0000},{1:0000},{2:0000}", 2, parameter, value);
            SerialCommand(command);
        }

        public void SendParameterList(int parameter, string times)
        {
            string[] imagingTimes = times.Split(',');
            for (int i = 0; i < imagingTimes.Length; i++) imagingTimes[i] = imagingTimes[i].PadLeft(4, '0');
            string command = string.Format(">{0:0000},{1:0000},{2:0000}", imagingTimes.Length + 1, parameter, string.Join(",", imagingTimes));
            SerialCommand(command);
        }

        public void SerialCommand(string command)
        {
            Console.WriteLine(command);
            labelTxCommand.Text = command;
            if (SerialPortOpen) ComPort.Write(command);

        }

        public void UpdateAcquireTime()
        {
            decimal acquire = 0;
            switch (comboBoxShutterMode.SelectedIndex)
            {
                //Breath
                case 0:
                    acquire =
                        numericUpDownInitialDelay.Value +
                        numericUpDownShutterOpen.Value +
                        numericUpDownCamera.Value * numericUpDownImagingExposures.Value +
                        numericUpDownCameraDelay.Value * (numericUpDownImagingExposures.Value - 1) +
                        numericUpDownShutterClose.Value;
                    break;
                // Image
                case 1:
                    acquire =
                        numericUpDownInitialDelay.Value + (
                            numericUpDownShutterOpen.Value +
                            numericUpDownCamera.Value +
                            numericUpDownShutterClose.Value) * numericUpDownImagingExposures.Value +
                        numericUpDownCameraDelay.Value * (numericUpDownImagingExposures.Value - 1);
                    break;
                // Block or None
                default:
                    acquire =
                        numericUpDownInitialDelay.Value +
                        numericUpDownCamera.Value * numericUpDownImagingExposures.Value +
                        numericUpDownCameraDelay.Value * (numericUpDownImagingExposures.Value - 1);
                    break;
            }
            labelAcquireTime.Text = acquire.ToString();

            if (acquire >= Convert.ToDecimal(numericUpDownRate.Value)) labelAcquireTime.ForeColor = Color.Red;
            else labelAcquireTime.ForeColor = Color.Black;
        }

        public void WriteLog(string button)
        {
            Variables.logfile.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff ") + button);

            if (new string[] { "SEARCH", "ONESHOT", "ACQUIRE ONE BLOCK", "RUN" }.Contains(button))
            {
                if (checkBoxInternalTrigger.Checked) Variables.logfile.WriteLine("- Internal timing period: " + numericUpDownRate.Value.ToString() + " ms");
                else Variables.logfile.WriteLine("- External trigger");
                if (checkBoxShutterOpen.Checked) Variables.logfile.WriteLine("- Shutter forced open");
                Variables.logfile.WriteLine("- Initial delay: " + numericUpDownInitialDelay.Value.ToString() + " ms");
                Variables.logfile.WriteLine("- Shutter open delay: " + numericUpDownShutterOpen.Value.ToString() + " ms");
                Variables.logfile.WriteLine("- Camera exposure length: " + numericUpDownCamera.Value.ToString() + " ms");
                Variables.logfile.WriteLine("- Shutter close delay: " + numericUpDownShutterClose.Value.ToString() + " ms");
            }

            if (new string[] { "ACQUIRE ONE BLOCK", "RUN" }.Contains(button))
            {
                switch (comboBoxShutterMode.SelectedIndex)
                {
                    case 0:
                        Variables.logfile.WriteLine("- Shutter mode: Breath");
                        break;
                    case 1:
                        Variables.logfile.WriteLine("- Shutter mode: Image");
                        break;
                    case 2:
                        Variables.logfile.WriteLine("- Shutter mode: Block");
                        break;
                    case 3:
                        Variables.logfile.WriteLine("- Shutter mode: Disabled");
                        break;
                }
                Variables.logfile.WriteLine("- Number of exposures per breath: " + numericUpDownImagingExposures.Value.ToString());
                if (numericUpDownImagingExposures.Value > 1) Variables.logfile.WriteLine("- Delay between exposures: " + numericUpDownCameraDelay.Value.ToString() + " ms");
                if (numericUpDownImagingRepeats.Value > 0) Variables.logfile.WriteLine("- Number of breaths per block: " + numericUpDownImagingRepeats.Value.ToString());
                else Variables.logfile.WriteLine("- Number of breaths per block: Continuous imaging");
                Variables.logfile.WriteLine("- Gap between images: " + numericUpDownImagingGap.Value.ToString());
            }

            if (button == "RUN")
            {
                if (numericUpDownImagingRepeats.Value > 0) Variables.logfile.WriteLine("- Imaging start breath(s): " + textBoxImagingStarts.Text);
                if (checkBoxRx1Active.Checked)
                {
                    Variables.logfile.WriteLine("- Rx1 delay: " + numericUpDownRx1Delay.Value.ToString() + " ms");
                    Variables.logfile.WriteLine("- Rx1 pulse length: " + numericUpDownRx1Pulse.Value.ToString() + " ms");
                    Variables.logfile.WriteLine("- Number of breaths to repeat Rx1: " + numericUpDownRx1Repeats.Value.ToString());
                    Variables.logfile.WriteLine("- Rx1 start breath(s): " + textBoxRx1Starts.Text);
                }
                if (checkBoxRx2Active.Checked)
                {
                    Variables.logfile.WriteLine("- Rx2 delay " + numericUpDownRx2Delay.Value.ToString() + " ms");
                    Variables.logfile.WriteLine("- Rx2 pulse length " + numericUpDownRx2Pulse.Value.ToString() + " ms");
                    Variables.logfile.WriteLine("- Number of breaths to repeat Rx2: " + numericUpDownRx2Repeats.Value.ToString());
                    Variables.logfile.WriteLine("- Rx2 start breath(s): " + textBoxRx2Starts.Text);
                }
            }
        }

        public void LoadSettings()
        {
            // Handler for settings corruption
            try
            {
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
            }
            catch (ConfigurationErrorsException ex)
            {
                string filename = ex.Filename;
                string message = "TimingBoxController has detected that your user settings file has become corrupted. " +
                                      "This may be due to a crash or improper exiting of the program. TimingBoxController must reset your " +
                                      "user settings in order to continue.\n\nClick Yes to reset your user settings and continue.\n\n" +
                                      "Click No if you wish to attempt manual repair or to rescue information before proceeding.";
                string caption = "Corrupt user settings";
                DialogResult result;

                result = MessageBox.Show(this, message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (result == DialogResult.Yes)
                {
                    System.IO.File.Delete(filename);
                    Properties.Settings.Default.Upgrade();
                }
                else
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
            }

            // Load all settings
            checkBoxInternalTrigger.Checked = Properties.Settings.Default.InternalTrigger;
            checkBoxShutterOpen.Checked = Properties.Settings.Default.ForceShutterOpen;
            checkBoxRx1Active.Checked = Properties.Settings.Default.Rx1Active;
            checkBoxRx2Active.Checked = Properties.Settings.Default.Rx2Active;
            numericUpDownRate.Value = Properties.Settings.Default.Rate;
            numericUpDownInitialDelay.Value = Properties.Settings.Default.InitialDelay;
            numericUpDownShutterOpen.Value = Properties.Settings.Default.ShutterOpen;
            numericUpDownCamera.Value = Properties.Settings.Default.Camera;
            numericUpDownCameraDelay.Value = Properties.Settings.Default.CameraDelay;
            numericUpDownShutterClose.Value = Properties.Settings.Default.ShutterClose;
            numericUpDownImagingExposures.Value = Properties.Settings.Default.ImagingExposures;
            numericUpDownImagingRepeats.Value = Properties.Settings.Default.ImagingRepeats;
            numericUpDownImagingGap.Value = Properties.Settings.Default.ImagingGap;
            numericUpDownImagingFlats.Value = Properties.Settings.Default.ImagingFlats;
            numericUpDownRx1Delay.Value = Properties.Settings.Default.Rx1Delay;
            numericUpDownRx1Pulse.Value = Properties.Settings.Default.Rx1Pulse;
            numericUpDownRx1Repeats.Value = Properties.Settings.Default.Rx1Repeats;
            numericUpDownRx2Delay.Value = Properties.Settings.Default.Rx2Delay;
            numericUpDownRx2Pulse.Value = Properties.Settings.Default.Rx2Pulse;
            numericUpDownRx2Repeats.Value = Properties.Settings.Default.Rx2Repeats;
            textBoxImagingStarts.Text = Properties.Settings.Default.ImagingStarts;
            textBoxRx1Starts.Text = Properties.Settings.Default.Rx1Starts;
            textBoxRx2Starts.Text = Properties.Settings.Default.Rx2Starts;
            comboBoxShutterMode.SelectedIndex = Properties.Settings.Default.ShutterMode;
            Variables.logfilename = Properties.Settings.Default.logfilename;
        }

        public void SaveSettings()
        {
            // Save all settings
            Properties.Settings.Default.InternalTrigger = checkBoxInternalTrigger.Checked;
            Properties.Settings.Default.ForceShutterOpen = checkBoxShutterOpen.Checked;
            Properties.Settings.Default.Rx1Active = checkBoxRx1Active.Checked;
            Properties.Settings.Default.Rx2Active = checkBoxRx2Active.Checked;
            Properties.Settings.Default.Rate = numericUpDownRate.Value;
            Properties.Settings.Default.InitialDelay = numericUpDownInitialDelay.Value;
            Properties.Settings.Default.ShutterOpen = numericUpDownShutterOpen.Value;
            Properties.Settings.Default.Camera = numericUpDownCamera.Value;
            Properties.Settings.Default.CameraDelay = numericUpDownCameraDelay.Value;
            Properties.Settings.Default.ShutterClose = numericUpDownShutterClose.Value;
            Properties.Settings.Default.ImagingExposures = numericUpDownImagingExposures.Value;
            Properties.Settings.Default.ImagingRepeats = numericUpDownImagingRepeats.Value;
            Properties.Settings.Default.ImagingGap = numericUpDownImagingGap.Value;
            Properties.Settings.Default.ImagingFlats = numericUpDownImagingFlats.Value;
            Properties.Settings.Default.Rx1Delay = numericUpDownRx1Delay.Value;
            Properties.Settings.Default.Rx1Pulse = numericUpDownRx1Pulse.Value;
            Properties.Settings.Default.Rx1Repeats = numericUpDownRx1Repeats.Value;
            Properties.Settings.Default.Rx2Delay = numericUpDownRx2Delay.Value;
            Properties.Settings.Default.Rx2Pulse = numericUpDownRx2Pulse.Value;
            Properties.Settings.Default.Rx2Repeats = numericUpDownRx2Repeats.Value;
            Properties.Settings.Default.ImagingStarts = textBoxImagingStarts.Text;
            Properties.Settings.Default.Rx1Starts = textBoxRx1Starts.Text;
            Properties.Settings.Default.Rx2Starts = textBoxRx2Starts.Text;
            Properties.Settings.Default.ShutterMode = comboBoxShutterMode.SelectedIndex;
            Properties.Settings.Default.logfilename = Variables.logfilename;
            Properties.Settings.Default.Save();
        }

        public void SendAllSettings()
        {
            // Send all parameters to update timing box to match GUI
            SendParameter(Constants.InternalTrigger, Convert.ToDecimal(checkBoxInternalTrigger.Checked));
            SendParameter(Constants.ForceShutterOpen, Convert.ToDecimal(checkBoxShutterOpen.Checked));
            SendParameter(Constants.Rx1Manual, Convert.ToDecimal(checkBoxRx1Manual.Checked));
            SendParameter(Constants.Rx1Active, Convert.ToDecimal(checkBoxRx1Active.Checked));
            SendParameter(Constants.Rx2Manual, Convert.ToDecimal(checkBoxRx2Manual.Checked));
            SendParameter(Constants.Rx2Active, Convert.ToDecimal(checkBoxRx2Active.Checked));
            SendParameter(Constants.Rate, numericUpDownRate.Value);
            SendParameter(Constants.InitialDelay, numericUpDownInitialDelay.Value);
            SendParameter(Constants.ShutterOpen, numericUpDownShutterOpen.Value);
            SendParameter(Constants.Camera, numericUpDownCamera.Value);
            SendParameter(Constants.CameraDelay, numericUpDownCameraDelay.Value);
            SendParameter(Constants.ShutterClose, numericUpDownShutterClose.Value);
            SendParameter(Constants.ImagingExposures, numericUpDownImagingExposures.Value);
            SendParameter(Constants.ImagingRepeats, numericUpDownImagingRepeats.Value);
            SendParameter(Constants.ImagingGap, numericUpDownImagingGap.Value);
            SendParameter(Constants.ImagingFlats, numericUpDownImagingFlats.Value);
            SendParameter(Constants.Rx1Delay, numericUpDownRx1Delay.Value);
            SendParameter(Constants.Rx1Pulse, numericUpDownRx1Pulse.Value);
            SendParameter(Constants.Rx1Repeats, numericUpDownRx1Repeats.Value);
            SendParameter(Constants.Rx2Delay, numericUpDownRx2Delay.Value);
            SendParameter(Constants.Rx2Pulse, numericUpDownRx2Pulse.Value);
            SendParameter(Constants.Rx2Repeats, numericUpDownRx2Repeats.Value);
            SendParameterList(Constants.ImagingStarts, textBoxImagingStarts.Text);
            SendParameterList(Constants.Rx1Starts, textBoxRx1Starts.Text);
            SendParameterList(Constants.Rx2Starts, textBoxRx2Starts.Text);
            SendParameter(Constants.ShutterMode, comboBoxShutterMode.SelectedIndex);
        }
    }
}