namespace TimingBoxController
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
            this.btnGetSerialPorts = new System.Windows.Forms.Button();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.btnPortState = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnAcquireOne = new System.Windows.Forms.Button();
            this.btnAcquireFlats = new System.Windows.Forms.Button();
            this.checkBoxRx1Active = new System.Windows.Forms.CheckBox();
            this.checkBoxRx1Manual = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownRx2Repeats = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownRx2Pulse = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRx2Delay = new System.Windows.Forms.NumericUpDown();
            this.labelTxCommand = new System.Windows.Forms.Label();
            this.labelRxCommand = new System.Windows.Forms.Label();
            this.textBoxRx2Starts = new System.Windows.Forms.TextBox();
            this.textBoxRx1Starts = new System.Windows.Forms.TextBox();
            this.numericUpDownRx1Repeats = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRx1Pulse = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRx1Delay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxRx2Active = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBoxRx2Manual = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxRx2RelayActive = new System.Windows.Forms.CheckBox();
            this.labelRelayActive = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.numericUpDownImagingGap = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxImagingStarts = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownImagingRepeats = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownImagingFlats = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxShutterMode = new System.Windows.Forms.ComboBox();
            this.labelAcquireTime = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownImagingExposures = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownShutterClose = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCameraDelay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCamera = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownShutterOpen = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownInitialDelay = new System.Windows.Forms.NumericUpDown();
            this.checkBoxShutterOpen = new System.Windows.Forms.CheckBox();
            this.checkBoxInternalTrigger = new System.Windows.Forms.CheckBox();
            this.numericUpDownRate = new System.Windows.Forms.NumericUpDown();
            this.btnOneShot = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRx2Repeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRx2Pulse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRx2Delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRx1Repeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRx1Pulse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRx1Delay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImagingGap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImagingRepeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImagingFlats)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImagingExposures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShutterClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCameraDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShutterOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInitialDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetSerialPorts
            // 
            this.btnGetSerialPorts.Location = new System.Drawing.Point(7, 9);
            this.btnGetSerialPorts.Name = "btnGetSerialPorts";
            this.btnGetSerialPorts.Size = new System.Drawing.Size(65, 23);
            this.btnGetSerialPorts.TabIndex = 0;
            this.btnGetSerialPorts.Text = "Get Ports";
            this.btnGetSerialPorts.UseVisualStyleBackColor = true;
            this.btnGetSerialPorts.Click += new System.EventHandler(this.btnGetSerialPorts_Click);
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(79, 10);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(85, 21);
            this.cboPorts.TabIndex = 1;
            // 
            // btnPortState
            // 
            this.btnPortState.Location = new System.Drawing.Point(170, 9);
            this.btnPortState.Name = "btnPortState";
            this.btnPortState.Size = new System.Drawing.Size(65, 23);
            this.btnPortState.TabIndex = 2;
            this.btnPortState.Text = "Open";
            this.btnPortState.UseVisualStyleBackColor = true;
            this.btnPortState.Click += new System.EventHandler(this.btnPortState_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(7, 591);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Searc&h";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Location = new System.Drawing.Point(212, 591);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(95, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "&Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(109, 591);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(95, 23);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "&Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnAcquireOne
            // 
            this.btnAcquireOne.Location = new System.Drawing.Point(109, 620);
            this.btnAcquireOne.Name = "btnAcquireOne";
            this.btnAcquireOne.Size = new System.Drawing.Size(95, 23);
            this.btnAcquireOne.TabIndex = 8;
            this.btnAcquireOne.Text = "1 &Block";
            this.btnAcquireOne.UseVisualStyleBackColor = true;
            this.btnAcquireOne.Click += new System.EventHandler(this.btnAcquireOne_Click);
            // 
            // btnAcquireFlats
            // 
            this.btnAcquireFlats.Location = new System.Drawing.Point(212, 620);
            this.btnAcquireFlats.Name = "btnAcquireFlats";
            this.btnAcquireFlats.Size = new System.Drawing.Size(95, 23);
            this.btnAcquireFlats.TabIndex = 9;
            this.btnAcquireFlats.Text = "&Flats / Darks";
            this.btnAcquireFlats.UseVisualStyleBackColor = true;
            this.btnAcquireFlats.Click += new System.EventHandler(this.btnAcquireFlats_Click);
            // 
            // checkBoxRx1Active
            // 
            this.checkBoxRx1Active.AutoSize = true;
            this.checkBoxRx1Active.Checked = true;
            this.checkBoxRx1Active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRx1Active.Location = new System.Drawing.Point(160, 18);
            this.checkBoxRx1Active.Name = "checkBoxRx1Active";
            this.checkBoxRx1Active.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRx1Active.TabIndex = 0;
            this.checkBoxRx1Active.UseVisualStyleBackColor = true;
            this.checkBoxRx1Active.CheckedChanged += new System.EventHandler(this.checkBoxRx1Active_CheckedChanged);
            // 
            // checkBoxRx1Manual
            // 
            this.checkBoxRx1Manual.AutoSize = true;
            this.checkBoxRx1Manual.Location = new System.Drawing.Point(160, 134);
            this.checkBoxRx1Manual.Name = "checkBoxRx1Manual";
            this.checkBoxRx1Manual.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRx1Manual.TabIndex = 5;
            this.checkBoxRx1Manual.UseVisualStyleBackColor = true;
            this.checkBoxRx1Manual.CheckedChanged += new System.EventHandler(this.checkBoxRx1Manual_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Repeats (breaths)";
            // 
            // numericUpDownRx2Repeats
            // 
            this.numericUpDownRx2Repeats.Location = new System.Drawing.Point(232, 85);
            this.numericUpDownRx2Repeats.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownRx2Repeats.Name = "numericUpDownRx2Repeats";
            this.numericUpDownRx2Repeats.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownRx2Repeats.TabIndex = 9;
            this.numericUpDownRx2Repeats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRx2Repeats.ValueChanged += new System.EventHandler(this.numericUpDownRx2Repeats_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Pulse Length (ms)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Delay (ms)";
            // 
            // numericUpDownRx2Pulse
            // 
            this.numericUpDownRx2Pulse.Location = new System.Drawing.Point(232, 63);
            this.numericUpDownRx2Pulse.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownRx2Pulse.Name = "numericUpDownRx2Pulse";
            this.numericUpDownRx2Pulse.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownRx2Pulse.TabIndex = 8;
            this.numericUpDownRx2Pulse.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownRx2Pulse.ValueChanged += new System.EventHandler(this.numericUpDownRx2Pulse_ValueChanged);
            // 
            // numericUpDownRx2Delay
            // 
            this.numericUpDownRx2Delay.Location = new System.Drawing.Point(232, 41);
            this.numericUpDownRx2Delay.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownRx2Delay.Name = "numericUpDownRx2Delay";
            this.numericUpDownRx2Delay.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownRx2Delay.TabIndex = 7;
            this.numericUpDownRx2Delay.ValueChanged += new System.EventHandler(this.numericUpDownRx2Delay_ValueChanged);
            // 
            // labelTxCommand
            // 
            this.labelTxCommand.AutoSize = true;
            this.labelTxCommand.ForeColor = System.Drawing.Color.Silver;
            this.labelTxCommand.Location = new System.Drawing.Point(5, 647);
            this.labelTxCommand.Name = "labelTxCommand";
            this.labelTxCommand.Size = new System.Drawing.Size(0, 13);
            this.labelTxCommand.TabIndex = 42;
            // 
            // labelRxCommand
            // 
            this.labelRxCommand.AutoSize = true;
            this.labelRxCommand.ForeColor = System.Drawing.Color.Silver;
            this.labelRxCommand.Location = new System.Drawing.Point(4, 661);
            this.labelRxCommand.Name = "labelRxCommand";
            this.labelRxCommand.Size = new System.Drawing.Size(99, 13);
            this.labelRxCommand.TabIndex = 43;
            this.labelRxCommand.Text = "Serial port not open";
            // 
            // textBoxRx2Starts
            // 
            this.textBoxRx2Starts.Location = new System.Drawing.Point(215, 108);
            this.textBoxRx2Starts.Name = "textBoxRx2Starts";
            this.textBoxRx2Starts.Size = new System.Drawing.Size(75, 20);
            this.textBoxRx2Starts.TabIndex = 10;
            this.textBoxRx2Starts.Text = "10";
            this.textBoxRx2Starts.Leave += new System.EventHandler(this.textBoxRx2Starts_Leave);
            // 
            // textBoxRx1Starts
            // 
            this.textBoxRx1Starts.Location = new System.Drawing.Point(117, 108);
            this.textBoxRx1Starts.Name = "textBoxRx1Starts";
            this.textBoxRx1Starts.Size = new System.Drawing.Size(75, 20);
            this.textBoxRx1Starts.TabIndex = 4;
            this.textBoxRx1Starts.Text = "120";
            this.textBoxRx1Starts.Leave += new System.EventHandler(this.textBoxRx1Starts_Leave);
            // 
            // numericUpDownRx1Repeats
            // 
            this.numericUpDownRx1Repeats.Location = new System.Drawing.Point(135, 85);
            this.numericUpDownRx1Repeats.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownRx1Repeats.Name = "numericUpDownRx1Repeats";
            this.numericUpDownRx1Repeats.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownRx1Repeats.TabIndex = 3;
            this.numericUpDownRx1Repeats.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownRx1Repeats.ValueChanged += new System.EventHandler(this.numericUpDownRx1Repeats_ValueChanged);
            // 
            // numericUpDownRx1Pulse
            // 
            this.numericUpDownRx1Pulse.Location = new System.Drawing.Point(135, 63);
            this.numericUpDownRx1Pulse.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownRx1Pulse.Name = "numericUpDownRx1Pulse";
            this.numericUpDownRx1Pulse.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownRx1Pulse.TabIndex = 2;
            this.numericUpDownRx1Pulse.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownRx1Pulse.ValueChanged += new System.EventHandler(this.numericUpDownRx1Pulse_ValueChanged);
            // 
            // numericUpDownRx1Delay
            // 
            this.numericUpDownRx1Delay.Location = new System.Drawing.Point(135, 41);
            this.numericUpDownRx1Delay.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownRx1Delay.Name = "numericUpDownRx1Delay";
            this.numericUpDownRx1Delay.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownRx1Delay.TabIndex = 1;
            this.numericUpDownRx1Delay.ValueChanged += new System.EventHandler(this.numericUpDownRx1Delay_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Active on Run";
            // 
            // checkBoxRx2Active
            // 
            this.checkBoxRx2Active.AutoSize = true;
            this.checkBoxRx2Active.Checked = true;
            this.checkBoxRx2Active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRx2Active.Location = new System.Drawing.Point(257, 18);
            this.checkBoxRx2Active.Name = "checkBoxRx2Active";
            this.checkBoxRx2Active.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRx2Active.TabIndex = 6;
            this.checkBoxRx2Active.UseVisualStyleBackColor = true;
            this.checkBoxRx2Active.CheckedChanged += new System.EventHandler(this.checkBoxRx2Active_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "Manual Delivery";
            // 
            // checkBoxRx2Manual
            // 
            this.checkBoxRx2Manual.AutoSize = true;
            this.checkBoxRx2Manual.Location = new System.Drawing.Point(257, 134);
            this.checkBoxRx2Manual.Name = "checkBoxRx2Manual";
            this.checkBoxRx2Manual.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRx2Manual.TabIndex = 11;
            this.checkBoxRx2Manual.UseVisualStyleBackColor = true;
            this.checkBoxRx2Manual.CheckedChanged += new System.EventHandler(this.checkBoxRx2Manual_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxRx2RelayActive);
            this.groupBox1.Controls.Add(this.labelRelayActive);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.checkBoxRx2Manual);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.checkBoxRx2Active);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxRx1Starts);
            this.groupBox1.Controls.Add(this.numericUpDownRx1Repeats);
            this.groupBox1.Controls.Add(this.numericUpDownRx1Pulse);
            this.groupBox1.Controls.Add(this.numericUpDownRx1Delay);
            this.groupBox1.Controls.Add(this.textBoxRx2Starts);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numericUpDownRx2Repeats);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.numericUpDownRx2Pulse);
            this.groupBox1.Controls.Add(this.numericUpDownRx2Delay);
            this.groupBox1.Controls.Add(this.checkBoxRx1Manual);
            this.groupBox1.Controls.Add(this.checkBoxRx1Active);
            this.groupBox1.Location = new System.Drawing.Point(7, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 175);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Treatment 1 and 2";
            // 
            // checkBoxRx2RelayActive
            // 
            this.checkBoxRx2RelayActive.AutoSize = true;
            this.checkBoxRx2RelayActive.Location = new System.Drawing.Point(257, 153);
            this.checkBoxRx2RelayActive.Name = "checkBoxRx2RelayActive";
            this.checkBoxRx2RelayActive.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRx2RelayActive.TabIndex = 58;
            this.checkBoxRx2RelayActive.UseVisualStyleBackColor = true;
            this.checkBoxRx2RelayActive.CheckedChanged += new System.EventHandler(this.checkBoxRx2RelayActive_CheckedChanged);
            // 
            // labelRelayActive
            // 
            this.labelRelayActive.AutoSize = true;
            this.labelRelayActive.Location = new System.Drawing.Point(3, 154);
            this.labelRelayActive.Name = "labelRelayActive";
            this.labelRelayActive.Size = new System.Drawing.Size(67, 13);
            this.labelRelayActive.TabIndex = 57;
            this.labelRelayActive.Text = "Relay Active";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 55;
            this.label15.Text = "Start (breaths)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.numericUpDownImagingGap);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBoxImagingStarts);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.numericUpDownImagingRepeats);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numericUpDownImagingFlats);
            this.groupBox2.Location = new System.Drawing.Point(7, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 109);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imaging";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 13);
            this.label18.TabIndex = 58;
            this.label18.Text = "Gap (breaths)";
            // 
            // numericUpDownImagingGap
            // 
            this.numericUpDownImagingGap.Location = new System.Drawing.Point(232, 37);
            this.numericUpDownImagingGap.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownImagingGap.Name = "numericUpDownImagingGap";
            this.numericUpDownImagingGap.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownImagingGap.TabIndex = 1;
            this.numericUpDownImagingGap.ValueChanged += new System.EventHandler(this.numericUpDownImagingGap_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 56;
            this.label16.Text = "Start (breaths)";
            // 
            // textBoxImagingStarts
            // 
            this.textBoxImagingStarts.Location = new System.Drawing.Point(86, 60);
            this.textBoxImagingStarts.Name = "textBoxImagingStarts";
            this.textBoxImagingStarts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxImagingStarts.Size = new System.Drawing.Size(206, 20);
            this.textBoxImagingStarts.TabIndex = 2;
            this.textBoxImagingStarts.Text = "0,60,120,180,240,360,480,600,840,1200,1560,1920";
            this.textBoxImagingStarts.Leave += new System.EventHandler(this.textBoxImagingStarts_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Flats / Darks";
            // 
            // numericUpDownImagingRepeats
            // 
            this.numericUpDownImagingRepeats.Location = new System.Drawing.Point(232, 15);
            this.numericUpDownImagingRepeats.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownImagingRepeats.Name = "numericUpDownImagingRepeats";
            this.numericUpDownImagingRepeats.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownImagingRepeats.TabIndex = 0;
            this.numericUpDownImagingRepeats.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownImagingRepeats.ValueChanged += new System.EventHandler(this.numericUpDownImagingRepeats_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Repeats (breaths)";
            // 
            // numericUpDownImagingFlats
            // 
            this.numericUpDownImagingFlats.Location = new System.Drawing.Point(232, 83);
            this.numericUpDownImagingFlats.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownImagingFlats.Name = "numericUpDownImagingFlats";
            this.numericUpDownImagingFlats.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownImagingFlats.TabIndex = 3;
            this.numericUpDownImagingFlats.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownImagingFlats.ValueChanged += new System.EventHandler(this.numericUpDownImagingFlats_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.comboBoxShutterMode);
            this.groupBox3.Controls.Add(this.labelAcquireTime);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.numericUpDownImagingExposures);
            this.groupBox3.Controls.Add(this.numericUpDownShutterClose);
            this.groupBox3.Controls.Add(this.numericUpDownCameraDelay);
            this.groupBox3.Controls.Add(this.numericUpDownCamera);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.numericUpDownShutterOpen);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.numericUpDownInitialDelay);
            this.groupBox3.Controls.Add(this.checkBoxShutterOpen);
            this.groupBox3.Controls.Add(this.checkBoxInternalTrigger);
            this.groupBox3.Controls.Add(this.numericUpDownRate);
            this.groupBox3.Location = new System.Drawing.Point(7, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 246);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timing ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 62;
            this.label17.Text = "Shutter mode";
            // 
            // comboBoxShutterMode
            // 
            this.comboBoxShutterMode.FormattingEnabled = true;
            this.comboBoxShutterMode.Items.AddRange(new object[] {
            "Breath",
            "Image",
            "Block",
            "None"});
            this.comboBoxShutterMode.Location = new System.Drawing.Point(232, 43);
            this.comboBoxShutterMode.Name = "comboBoxShutterMode";
            this.comboBoxShutterMode.Size = new System.Drawing.Size(60, 21);
            this.comboBoxShutterMode.TabIndex = 2;
            this.comboBoxShutterMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxShutterMode_SelectedIndexChanged);
            // 
            // labelAcquireTime
            // 
            this.labelAcquireTime.AutoSize = true;
            this.labelAcquireTime.Location = new System.Drawing.Point(229, 199);
            this.labelAcquireTime.Name = "labelAcquireTime";
            this.labelAcquireTime.Size = new System.Drawing.Size(25, 13);
            this.labelAcquireTime.TabIndex = 9;
            this.labelAcquireTime.Text = "470";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 61;
            this.label13.Text = "Total Acquire Time (ms)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Imaging Exposures (per breath)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Shutter Close Delay (ms)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Pause Between Exposures (ms)";
            // 
            // numericUpDownImagingExposures
            // 
            this.numericUpDownImagingExposures.Location = new System.Drawing.Point(232, 110);
            this.numericUpDownImagingExposures.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownImagingExposures.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownImagingExposures.Name = "numericUpDownImagingExposures";
            this.numericUpDownImagingExposures.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownImagingExposures.TabIndex = 5;
            this.numericUpDownImagingExposures.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownImagingExposures.ValueChanged += new System.EventHandler(this.numericUpDownImagingExposures_ValueChanged);
            // 
            // numericUpDownShutterClose
            // 
            this.numericUpDownShutterClose.InterceptArrowKeys = false;
            this.numericUpDownShutterClose.Location = new System.Drawing.Point(232, 176);
            this.numericUpDownShutterClose.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownShutterClose.Name = "numericUpDownShutterClose";
            this.numericUpDownShutterClose.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownShutterClose.TabIndex = 8;
            this.numericUpDownShutterClose.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownShutterClose.ValueChanged += new System.EventHandler(this.numericUpDownShutterClose_ValueChanged);
            // 
            // numericUpDownCameraDelay
            // 
            this.numericUpDownCameraDelay.Location = new System.Drawing.Point(232, 154);
            this.numericUpDownCameraDelay.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownCameraDelay.Name = "numericUpDownCameraDelay";
            this.numericUpDownCameraDelay.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownCameraDelay.TabIndex = 7;
            this.numericUpDownCameraDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownCameraDelay.ValueChanged += new System.EventHandler(this.numericUpDownCameraDelay_ValueChanged);
            // 
            // numericUpDownCamera
            // 
            this.numericUpDownCamera.Location = new System.Drawing.Point(232, 132);
            this.numericUpDownCamera.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownCamera.Name = "numericUpDownCamera";
            this.numericUpDownCamera.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownCamera.TabIndex = 6;
            this.numericUpDownCamera.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownCamera.ValueChanged += new System.EventHandler(this.numericUpDownCamera_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Camera Exposure Length (ms)";
            // 
            // numericUpDownShutterOpen
            // 
            this.numericUpDownShutterOpen.Location = new System.Drawing.Point(232, 88);
            this.numericUpDownShutterOpen.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownShutterOpen.Name = "numericUpDownShutterOpen";
            this.numericUpDownShutterOpen.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownShutterOpen.TabIndex = 4;
            this.numericUpDownShutterOpen.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownShutterOpen.ValueChanged += new System.EventHandler(this.numericUpDownShutterOpen_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Shutter Open Delay (ms)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Initial Delay (ms)";
            // 
            // numericUpDownInitialDelay
            // 
            this.numericUpDownInitialDelay.Location = new System.Drawing.Point(232, 66);
            this.numericUpDownInitialDelay.Maximum = new decimal(new int[] {
            9995,
            0,
            0,
            0});
            this.numericUpDownInitialDelay.Name = "numericUpDownInitialDelay";
            this.numericUpDownInitialDelay.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownInitialDelay.TabIndex = 3;
            this.numericUpDownInitialDelay.Value = new decimal(new int[] {
            425,
            0,
            0,
            0});
            this.numericUpDownInitialDelay.ValueChanged += new System.EventHandler(this.numericUpDownInitialDelay_ValueChanged);
            // 
            // checkBoxShutterOpen
            // 
            this.checkBoxShutterOpen.AutoSize = true;
            this.checkBoxShutterOpen.Location = new System.Drawing.Point(10, 221);
            this.checkBoxShutterOpen.Name = "checkBoxShutterOpen";
            this.checkBoxShutterOpen.Size = new System.Drawing.Size(119, 17);
            this.checkBoxShutterOpen.TabIndex = 9;
            this.checkBoxShutterOpen.Text = "Force Shutter &Open";
            this.checkBoxShutterOpen.UseVisualStyleBackColor = true;
            this.checkBoxShutterOpen.CheckedChanged += new System.EventHandler(this.checkBoxShutterOpen_CheckedChanged);
            // 
            // checkBoxInternalTrigger
            // 
            this.checkBoxInternalTrigger.AutoSize = true;
            this.checkBoxInternalTrigger.Location = new System.Drawing.Point(12, 22);
            this.checkBoxInternalTrigger.Name = "checkBoxInternalTrigger";
            this.checkBoxInternalTrigger.Size = new System.Drawing.Size(117, 17);
            this.checkBoxInternalTrigger.TabIndex = 0;
            this.checkBoxInternalTrigger.Text = "&Internal Timing (ms)";
            this.checkBoxInternalTrigger.UseVisualStyleBackColor = true;
            this.checkBoxInternalTrigger.CheckedChanged += new System.EventHandler(this.checkBoxInternalTrigger_CheckedChanged);
            // 
            // numericUpDownRate
            // 
            this.numericUpDownRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownRate.Location = new System.Drawing.Point(232, 21);
            this.numericUpDownRate.Maximum = new decimal(new int[] {
            8388,
            0,
            0,
            0});
            this.numericUpDownRate.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownRate.Name = "numericUpDownRate";
            this.numericUpDownRate.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownRate.TabIndex = 1;
            this.numericUpDownRate.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownRate.ValueChanged += new System.EventHandler(this.numericUpDownRate_ValueChanged);
            // 
            // btnOneShot
            // 
            this.btnOneShot.Location = new System.Drawing.Point(7, 620);
            this.btnOneShot.Name = "btnOneShot";
            this.btnOneShot.Size = new System.Drawing.Size(95, 23);
            this.btnOneShot.TabIndex = 7;
            this.btnOneShot.Text = "&1 Shot";
            this.btnOneShot.UseVisualStyleBackColor = true;
            this.btnOneShot.Click += new System.EventHandler(this.btnOneShot_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(240, 9);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(65, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 684);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOneShot);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelRxCommand);
            this.Controls.Add(this.labelTxCommand);
            this.Controls.Add(this.btnAcquireFlats);
            this.Controls.Add(this.btnAcquireOne);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPortState);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.btnGetSerialPorts);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRx2Repeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRx2Pulse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRx2Delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRx1Repeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRx1Pulse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRx1Delay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImagingGap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImagingRepeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImagingFlats)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImagingExposures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShutterClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCameraDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShutterOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInitialDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.ComboBox comboBoxShutterMode;
        private System.Windows.Forms.Button btnGetSerialPorts;
        private System.Windows.Forms.Button btnOneShot;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPortState;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnAcquireOne;
        private System.Windows.Forms.Button btnAcquireFlats;
        private System.Windows.Forms.CheckBox checkBoxRx1Active;
        private System.Windows.Forms.CheckBox checkBoxRx1Manual;
        private System.Windows.Forms.CheckBox checkBoxRx2Active;
        private System.Windows.Forms.CheckBox checkBoxRx2Manual;
        private System.Windows.Forms.CheckBox checkBoxShutterOpen;
        private System.Windows.Forms.CheckBox checkBoxInternalTrigger;
        private System.Windows.Forms.CheckBox checkBoxRx2RelayActive;
        private System.Windows.Forms.NumericUpDown numericUpDownRx1Repeats;
        private System.Windows.Forms.NumericUpDown numericUpDownRx1Pulse;
        private System.Windows.Forms.NumericUpDown numericUpDownRx1Delay;
        private System.Windows.Forms.NumericUpDown numericUpDownRx2Repeats;
        private System.Windows.Forms.NumericUpDown numericUpDownRx2Pulse;
        private System.Windows.Forms.NumericUpDown numericUpDownRx2Delay;
        private System.Windows.Forms.NumericUpDown numericUpDownImagingRepeats;
        private System.Windows.Forms.NumericUpDown numericUpDownImagingFlats;
        private System.Windows.Forms.NumericUpDown numericUpDownRate;
        private System.Windows.Forms.NumericUpDown numericUpDownImagingExposures;
        private System.Windows.Forms.NumericUpDown numericUpDownShutterClose;
        private System.Windows.Forms.NumericUpDown numericUpDownCameraDelay;
        private System.Windows.Forms.NumericUpDown numericUpDownCamera;
        private System.Windows.Forms.NumericUpDown numericUpDownShutterOpen;
        private System.Windows.Forms.NumericUpDown numericUpDownInitialDelay;
        private System.Windows.Forms.NumericUpDown numericUpDownImagingGap;
        private System.Windows.Forms.TextBox textBoxImagingStarts;
        private System.Windows.Forms.TextBox textBoxRx2Starts;
        private System.Windows.Forms.TextBox textBoxRx1Starts;
        private System.Windows.Forms.Label labelAcquireTime;
        private System.Windows.Forms.Label labelTxCommand;
        private System.Windows.Forms.Label labelRxCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelRelayActive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

