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
            if (InputData.Contains("#0099")) MessageBox.Show(new Form { TopMost = true }, "Run complete");
            if (InputData != String.Empty)
            {
                this.BeginInvoke(new SetTextCallback(SetText), new object[] { InputData });
            }
        }

        private void SetText(string text)
        {
            this.labelRxCommand.Text = text;
        }

        private void numericUpDownRate_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0001,{0:0000}", numericUpDownRate.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void numericUpDownInitialDelay_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0011,{0:0000}", numericUpDownInitialDelay.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
            decimal acquire = numericUpDownInitialDelay.Value + numericUpDownShutterOpen.Value + numericUpDownLongCamera.Value * numericUpDownImagingExposures.Value + (numericUpDownImagingExposures.Value - 1) * numericUpDownCameraDelay.Value + numericUpDownShutterClose.Value;
            labelAcquireTime.Text = acquire.ToString();
        }

        private void numericUpDownShutterOpen_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0012,{0:0000}", numericUpDownShutterOpen.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
            decimal acquire = numericUpDownInitialDelay.Value + numericUpDownShutterOpen.Value + numericUpDownLongCamera.Value * numericUpDownImagingExposures.Value + (numericUpDownImagingExposures.Value - 1) * numericUpDownCameraDelay.Value + numericUpDownShutterClose.Value;
            labelAcquireTime.Text = acquire.ToString();
        }

        private void numericUpDownLongCamera_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0013,{0:0000}", numericUpDownLongCamera.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
            decimal acquire = numericUpDownInitialDelay.Value + numericUpDownShutterOpen.Value + numericUpDownLongCamera.Value * numericUpDownImagingExposures.Value + (numericUpDownImagingExposures.Value - 1) * numericUpDownCameraDelay.Value + numericUpDownShutterClose.Value;
            labelAcquireTime.Text = acquire.ToString();
        }

        private void numericUpDownCameraDelay_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0014,{0:0000}", numericUpDownCameraDelay.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
            decimal acquire = numericUpDownInitialDelay.Value + numericUpDownShutterOpen.Value + numericUpDownLongCamera.Value * numericUpDownImagingExposures.Value + (numericUpDownImagingExposures.Value - 1) * numericUpDownCameraDelay.Value + numericUpDownShutterClose.Value;
            labelAcquireTime.Text = acquire.ToString();
        }

        private void numericUpDownShutterClose_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0015,{0:0000}", numericUpDownShutterClose.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
            decimal acquire = numericUpDownInitialDelay.Value + numericUpDownShutterOpen.Value + numericUpDownLongCamera.Value * numericUpDownImagingExposures.Value + (numericUpDownImagingExposures.Value - 1) * numericUpDownCameraDelay.Value + numericUpDownShutterClose.Value;
            labelAcquireTime.Text = acquire.ToString();
        }

        private void numericUpDownImagingExposures_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0021,{0:0000}", numericUpDownImagingExposures.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
            decimal acquire = numericUpDownInitialDelay.Value + numericUpDownShutterOpen.Value + numericUpDownLongCamera.Value * numericUpDownImagingExposures.Value + (numericUpDownImagingExposures.Value - 1) * numericUpDownCameraDelay.Value + numericUpDownShutterClose.Value;
            labelAcquireTime.Text = acquire.ToString();
        }

        private void numericUpDownImagingRepeats_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0022,{0:0000}", numericUpDownImagingRepeats.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void numericUpDownImagingFlats_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0023,{0:0000}", numericUpDownImagingFlats.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void numericUpDownRxDelay_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0031,{0:0000}", numericUpDownRxDelay.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void numericUpDownRxPulse_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0032,{0:0000}", numericUpDownRxPulse.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void numericUpDownRxRepeats_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#0002,0033,{0:0000}", numericUpDownRxRepeats.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void checkBoxInternalTrigger_CheckedChanged(object sender, EventArgs e)
        {
            string command;
            if (checkBoxInternalTrigger.Checked)
            {
                command = "#0001,0052";
                checkBoxInternalTrigger.ForeColor = Color.Red;
            }

            else
            {
                command = "#0001,0051";
                checkBoxInternalTrigger.ForeColor = Color.Black;
            }
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string command = "#0001,0061";
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string command = "#0001,0062";
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void btnAcquireOne_Click(object sender, EventArgs e)
        {
            string command = "#0001,0063";
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void btnAcquireFlats_Click(object sender, EventArgs e)
        {
            string command = "#0001,0064";
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            string command = "#0001,0065";
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void checkBoxShutterOpen_CheckedChanged(object sender, EventArgs e)
        {
            string command;
            if (checkBoxShutterOpen.Checked)
            {
                command = "#0001,0071";
                checkBoxShutterOpen.ForeColor = Color.Red;
            }   
            else
            {
                command = "#0001,0072";
                checkBoxShutterOpen.ForeColor = Color.Black;
            }  
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void checkBoxManualRx_CheckedChanged(object sender, EventArgs e)
        {
            string command;
            if (checkBoxManualRx.Checked)
            {
                command = "#0001,0073";
                checkBoxManualRx.ForeColor = Color.Red;
            }
            else
            {
                command = "#0001,0074";
                checkBoxManualRx.ForeColor = Color.Black;
            }
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void checkBoxRxActive_CheckedChanged(object sender, EventArgs e)
        {
            string command;
            if (checkBoxRxActive.Checked)
            {
                command = "#0001,0075";
                checkBoxRxActive.ForeColor = Color.Black;
            }
            else
            {
                command = "#0001,0076";
                checkBoxRxActive.ForeColor = Color.Red;
            }
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void textBoxImagingStarts_Leave(object sender, EventArgs e)
        {
            string[] imagingTimes = textBoxImagingStarts.Text.Split(',');
            for (int i = 0; i < imagingTimes.Length; i++) imagingTimes[i] = imagingTimes[i].PadLeft(4, '0');
            string command = string.Format("#{0:0000},0024,{1:0000}", imagingTimes.Length + 1, string.Join(",", imagingTimes));
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void textBoxRxStarts_Leave(object sender, EventArgs e)
        {
            string[] rxTimes = textBoxRxStarts.Text.Split(',');
            for (int i = 0; i < rxTimes.Length; i++) rxTimes[i] = rxTimes[i].PadLeft(4, '0');
            string command = string.Format("#{0:0000},0034,{1:0000}", rxTimes.Length + 1, string.Join(",", rxTimes));
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }
    }
}
