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

            while (!((ArrayComPortsNames[index] == ComPortName)
                          || (index == ArrayComPortsNames.GetUpperBound(0))));
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

            }
            else if (btnPortState.Text == "Close")
            {
                btnPortState.Text = "Open";
                ComPort.Close();
            }
        }

        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            InputData = ComPort.ReadLine();
            if (InputData.Contains("#99")) MessageBox.Show("Complete");
            if (InputData != String.Empty)
            {
                this.BeginInvoke(new SetTextCallback(SetText), new object[] { InputData });
            }
        }

        private void SetText(string text)
        {
            this.labelRxCommand.Text = text;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string command = "#3,61\n";
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            string command = "#3,65\n";
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string command = "#3,62\n";
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void btnAcquireFlats_Click(object sender, EventArgs e)
        {
            string command = "#3,64\n";
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void btnAcquireOne_Click(object sender, EventArgs e)
        {
            string command = "#3,63\n";
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void numericUpDownRate_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#1,01,{0:0000}", numericUpDownRate.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void checkBoxInternalTrigger_CheckedChanged(object sender, EventArgs e)
        {
            string command;
            if (checkBoxInternalTrigger.Checked)
            {
                command = "#3,52\n";
                checkBoxInternalTrigger.ForeColor = Color.Red;
            }
            
            else
            {
                command = "#3,51\n";
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
                command = "#3,71\n";
                checkBoxShutterOpen.ForeColor = Color.Red;
            }   
            else
            {
                command = "#3,72\n";
                checkBoxShutterOpen.ForeColor = Color.Black;
            }  
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void checkBoxManualRx_CheckedChanged(object sender, EventArgs e)
        {
            string command;
            if (checkBoxManualRx.Checked) command = "#3,73\n";
            else command = "#3,74\n";
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void checkBoxRxActive_CheckedChanged(object sender, EventArgs e)
        {
            string command;
            if (checkBoxRxActive.Checked) command = "#3,75\n";
            else command = "#3,76\n";
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void numericUpDownInitialDelay_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#1,11,{0:0000}", numericUpDownInitialDelay.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
            decimal acquire = numericUpDownInitialDelay.Value + numericUpDownShutterOpen.Value + numericUpDownLongCamera.Value * numericUpDownImagingExposures.Value + (numericUpDownImagingExposures.Value - 1) * numericUpDownCameraDelay.Value + numericUpDownShutterClose.Value;
            labelAcquireTime.Text = acquire.ToString();
        }

        private void numericUpDownShutterOpen_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#1,12,{0:0000}", numericUpDownShutterOpen.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
            decimal acquire = numericUpDownInitialDelay.Value + numericUpDownShutterOpen.Value + numericUpDownLongCamera.Value * numericUpDownImagingExposures.Value + (numericUpDownImagingExposures.Value - 1) * numericUpDownCameraDelay.Value + numericUpDownShutterClose.Value;
            labelAcquireTime.Text = acquire.ToString();
        }

        private void numericUpDownLongCamera_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#1,13,{0:0000}", numericUpDownLongCamera.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
            decimal acquire = numericUpDownInitialDelay.Value + numericUpDownShutterOpen.Value + numericUpDownLongCamera.Value * numericUpDownImagingExposures.Value + (numericUpDownImagingExposures.Value - 1) * numericUpDownCameraDelay.Value + numericUpDownShutterClose.Value;
            labelAcquireTime.Text = acquire.ToString();
        }

        private void numericUpDownCameraDelay_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#1,14,{0:0000}", numericUpDownCameraDelay.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
            decimal acquire = numericUpDownInitialDelay.Value + numericUpDownShutterOpen.Value + numericUpDownLongCamera.Value * numericUpDownImagingExposures.Value + (numericUpDownImagingExposures.Value - 1) * numericUpDownCameraDelay.Value + numericUpDownShutterClose.Value;
            labelAcquireTime.Text = acquire.ToString();
        }

        private void numericUpDownShutterClose_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#1,15,{0:0000}", numericUpDownShutterClose.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
            decimal acquire = numericUpDownInitialDelay.Value + numericUpDownShutterOpen.Value + numericUpDownLongCamera.Value * numericUpDownImagingExposures.Value + (numericUpDownImagingExposures.Value - 1) * numericUpDownCameraDelay.Value + numericUpDownShutterClose.Value;
            labelAcquireTime.Text = acquire.ToString();
        }

        private void numericUpDownImagingExposures_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#1,21,{0:0000}", numericUpDownImagingExposures.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
            decimal acquire = numericUpDownInitialDelay.Value + numericUpDownShutterOpen.Value + numericUpDownLongCamera.Value * numericUpDownImagingExposures.Value + (numericUpDownImagingExposures.Value - 1) * numericUpDownCameraDelay.Value + numericUpDownShutterClose.Value;
            labelAcquireTime.Text = acquire.ToString();
        }

        private void numericUpDownImagingRepeats_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#1,22,{0:0000}", numericUpDownImagingRepeats.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void numericUpDownImagingFlats_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#1,23,{0:0000}", numericUpDownImagingFlats.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void numericUpDownRxDelay_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#1,31,{0:0000}", numericUpDownRxDelay.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void numericUpDownRxPulse_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#1,32,{0:0000}", numericUpDownRxPulse.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }

        private void numericUpDownRxRepeats_ValueChanged(object sender, EventArgs e)
        {
            string command = string.Format("#1,33,{0:0000}", numericUpDownRxRepeats.Value);
            ComPort.Write(command);
            labelTxCommand.Text = command;
        }
    }
}
