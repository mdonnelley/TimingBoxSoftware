using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace TimingBoxController
{
    public partial class Form1 : Form
    {
        SerialPort ComPort = new SerialPort();
        string InputData = String.Empty;
        delegate void SetTextCallback(string text);

        public Form1()
        {
            InitializeComponent();
            ComPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_1);

        }

        private void btnGetSerialPorts_Click(object sender, EventArgs e)
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;

            ArrayComPortsNames = SerialPort.GetPortNames();
            do
            {
                index += 1;
                cboPorts.Items.Add(ArrayComPortsNames[index]);
            }

            while (!((ArrayComPortsNames[index] == ComPortName) || (index == ArrayComPortsNames.GetUpperBound(0))));
            Array.Sort(ArrayComPortsNames);

            //want to get first out
            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                ComPortName = ArrayComPortsNames[0];
            }
            cboPorts.Text = ArrayComPortsNames[0];
        }

        private void btnPortState_Click(object sender, EventArgs e)
        {
            if (btnPortState.Text == "Open")
            {
                btnPortState.Text = "Close";
                ComPort.PortName = Convert.ToString(cboPorts.Text);
                ComPort.Open();
                ComPort.NewLine = "\n";
                string command = "#0001,0000\n";
                ComPort.Write(command);
                labelTxCommand.Text = command;
            }
            else if (btnPortState.Text == "Close")
            {
                btnPortState.Text = "Open";
                ComPort.DiscardInBuffer();
                ComPort.Close();
            }
        }

        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            InputData = ComPort.ReadLine();
            Console.Write(InputData);
            if (InputData.Contains("#0000")) MessageBox.Show(new Form { TopMost = true }, "Successfully connected to timing box");
//            if (InputData.Contains("#0099")) MessageBox.Show(new Form { TopMost = true }, "Run complete");

            // Put handler in here for incoming data -> Read data from timing box

            if (InputData != String.Empty)
            {
                this.BeginInvoke(new SetTextCallback(SetText), new object[] { InputData });
            }
        }

        private void SetText(string text)
        {
            this.labelRxCommand.Text = text;
        }

        // --------------- CHECKBOXES ---------------

        private void checkBoxInternalTrigger_CheckedChanged(object sender, EventArgs e)
        {
            string command;
            if (checkBoxInternalTrigger.Checked)
            {
                command = "#0002,0010,0001";
                checkBoxInternalTrigger.ForeColor = Color.Red;
            }

            else
            {
                command = "#0002,0010,0000";
                checkBoxInternalTrigger.ForeColor = Color.Black;
            }
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void checkBoxShutterOpen_CheckedChanged(object sender, EventArgs e)
        {
            string command;
            if (checkBoxShutterOpen.Checked)
            {
                command = "#0002,0011,0001";
                checkBoxShutterOpen.ForeColor = Color.Red;
            }
            else
            {
                command = "#0002,0011,0000";
                checkBoxShutterOpen.ForeColor = Color.Black;
            }
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void checkBoxManualRx1_CheckedChanged(object sender, EventArgs e)
        {
            string command;
            if (checkBoxManualRx1.Checked)
            {
                command = "#0002,0012,0001";
                checkBoxManualRx1.ForeColor = Color.Red;
            }
            else
            {
                command = "#0002,0012,0000";
                checkBoxManualRx1.ForeColor = Color.Black;
            }
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void checkBoxRx1Active_CheckedChanged(object sender, EventArgs e)
        {
            string command;
            if (checkBoxRx1Active.Checked)
            {
                command = "#0002,0013,0001";
                checkBoxRx1Active.ForeColor = Color.Black;
            }
            else
            {
                command = "#0002,0013,0000";
                checkBoxRx1Active.ForeColor = Color.Red;
            }
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void checkBoxManualRx2_CheckedChanged(object sender, EventArgs e)
        {
            string command;
            if (checkBoxManualRx2.Checked)
            {
                command = "#0002,0014,0001";
                checkBoxManualRx2.ForeColor = Color.Red;
            }
            else
            {
                command = "#0002,0014,0000";
                checkBoxManualRx2.ForeColor = Color.Black;
            }
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void checkBoxRx2Active_CheckedChanged(object sender, EventArgs e)
        {
            string command;
            if (checkBoxRx2Active.Checked)
            {
                command = "#0002,0015,0001";
                checkBoxRx2Active.ForeColor = Color.Black;
            }
            else
            {
                command = "#0002,0015,0000";
                checkBoxRx2Active.ForeColor = Color.Red;
            }
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        // --------------- NUMERIC UP/DOWN BOXES ---------------

        private void numericUpDownRate_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0020,{0:0000}", numericUpDownRate.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void numericUpDownInitialDelay_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0021,{0:0000}", numericUpDownInitialDelay.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
            decimal acquire = numericUpDownInitialDelay.Value + numericUpDownShutterOpen.Value + numericUpDownCamera.Value * numericUpDownImagingExposures.Value + (numericUpDownImagingExposures.Value - 1) * numericUpDownCameraDelay.Value + numericUpDownShutterClose.Value;
            labelAcquireTime.Text = acquire.ToString();
        }

        private void numericUpDownShutterOpen_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0022,{0:0000}", numericUpDownShutterOpen.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
            decimal acquire = numericUpDownInitialDelay.Value + numericUpDownShutterOpen.Value + numericUpDownCamera.Value * numericUpDownImagingExposures.Value + (numericUpDownImagingExposures.Value - 1) * numericUpDownCameraDelay.Value + numericUpDownShutterClose.Value;
            labelAcquireTime.Text = acquire.ToString();
        }

        private void numericUpDownCamera_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0023,{0:0000}", numericUpDownCamera.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
            decimal acquire = numericUpDownInitialDelay.Value + numericUpDownShutterOpen.Value + numericUpDownCamera.Value * numericUpDownImagingExposures.Value + (numericUpDownImagingExposures.Value - 1) * numericUpDownCameraDelay.Value + numericUpDownShutterClose.Value;
            labelAcquireTime.Text = acquire.ToString();
        }

        private void numericUpDownCameraDelay_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0024,{0:0000}", numericUpDownCameraDelay.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
            decimal acquire = numericUpDownInitialDelay.Value + numericUpDownShutterOpen.Value + numericUpDownCamera.Value * numericUpDownImagingExposures.Value + (numericUpDownImagingExposures.Value - 1) * numericUpDownCameraDelay.Value + numericUpDownShutterClose.Value;
            labelAcquireTime.Text = acquire.ToString();
        }

        private void numericUpDownShutterClose_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0025,{0:0000}", numericUpDownShutterClose.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
            decimal acquire = numericUpDownInitialDelay.Value + numericUpDownShutterOpen.Value + numericUpDownCamera.Value * numericUpDownImagingExposures.Value + (numericUpDownImagingExposures.Value - 1) * numericUpDownCameraDelay.Value + numericUpDownShutterClose.Value;
            labelAcquireTime.Text = acquire.ToString();
        }

        private void numericUpDownImagingExposures_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0026,{0:0000}", numericUpDownImagingExposures.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
            decimal acquire = numericUpDownInitialDelay.Value + numericUpDownShutterOpen.Value + numericUpDownCamera.Value * numericUpDownImagingExposures.Value + (numericUpDownImagingExposures.Value - 1) * numericUpDownCameraDelay.Value + numericUpDownShutterClose.Value;
            labelAcquireTime.Text = acquire.ToString();
        }

        private void numericUpDownImagingRepeats_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0027,{0:0000}", numericUpDownImagingRepeats.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void numericUpDownImagingFlats_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0028,{0:0000}", numericUpDownImagingFlats.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void numericUpDownRx1Delay_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0029,{0:0000}", numericUpDownRx1Delay.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void numericUpDownRx1Pulse_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0030,{0:0000}", numericUpDownRx1Pulse.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void numericUpDownRx1Repeats_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0031,{0:0000}", numericUpDownRx1Repeats.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void numericUpDownRx2Delay_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0032,{0:0000}", numericUpDownRx2Delay.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void numericUpDownRx2Pulse_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0033,{0:0000}", numericUpDownRx2Pulse.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void numericUpDownRx2Repeats_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0034,{0:0000}", numericUpDownRx2Repeats.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        // --------------- TEXT BOXES ---------------

        private void textBoxImagingStarts_Leave(object sender, EventArgs e)
        {
            string[] imagingTimes = textBoxImagingStarts.Text.Split(',');
            for (int i = 0; i < imagingTimes.Length; i++) imagingTimes[i] = imagingTimes[i].PadLeft(4, '0');
            string command = string.Format("#{0:0000},0040,{1:0000}", imagingTimes.Length + 1, string.Join(",", imagingTimes));
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void textBoxRx1Starts_Leave(object sender, EventArgs e)
        {
            string[] rx1Times = textBoxRx1Starts.Text.Split(',');
            for (int i = 0; i < rx1Times.Length; i++) rx1Times[i] = rx1Times[i].PadLeft(4, '0');
            string command = string.Format("#{0:0000},0041,{1:0000}", rx1Times.Length + 1, string.Join(",", rx1Times));
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void textBoxRx2Starts_Leave(object sender, EventArgs e)
        {
            string[] rx2Times = textBoxRx2Starts.Text.Split(',');
            for (int i = 0; i < rx2Times.Length; i++) rx2Times[i] = rx2Times[i].PadLeft(4, '0');
            string command = string.Format("#{0:0000},0042,{1:0000}", rx2Times.Length + 1, string.Join(",", rx2Times));
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        // --------------- BUTTONS ---------------

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string command = "#0001,0050";
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void btnOneShot_Click(object sender, EventArgs e)
        {
            string command = "#0001,0051";
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void btnAcquireOne_Click(object sender, EventArgs e)
        {
            string command = "#0001,0052";
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string command = "#0001,0053";
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void btnAcquireFlats_Click(object sender, EventArgs e)
        {
            string command = "#0001,0054";
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            string command = "#0001,0055";
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }


    }
}
