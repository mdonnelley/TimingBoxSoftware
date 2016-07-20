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
            this.numericUpDownRate = new System.Windows.Forms.NumericUpDown();
            this.checkBoxInternalTrigger = new System.Windows.Forms.CheckBox();
            this.checkBoxShutterOpen = new System.Windows.Forms.CheckBox();
            this.checkBoxRxActive = new System.Windows.Forms.CheckBox();
            this.checkBoxManualRx = new System.Windows.Forms.CheckBox();
            this.numericUpDownInitialDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownShutterOpen = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownLongCamera = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownImagingFlats = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownImagingExposures = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownShutterClose = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCameraDelay = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownImagingRepeats = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownRxRepeats = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownRxPulse = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRxDelay = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTxCommand = new System.Windows.Forms.Label();
            this.labelRxCommand = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelAcquireTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInitialDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShutterOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImagingFlats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImagingExposures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShutterClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCameraDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImagingRepeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRxRepeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRxPulse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRxDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetSerialPorts
            // 
            this.btnGetSerialPorts.Location = new System.Drawing.Point(14, 10);
            this.btnGetSerialPorts.Name = "btnGetSerialPorts";
            this.btnGetSerialPorts.Size = new System.Drawing.Size(75, 23);
            this.btnGetSerialPorts.TabIndex = 0;
            this.btnGetSerialPorts.Text = "Get Ports";
            this.btnGetSerialPorts.UseVisualStyleBackColor = true;
            this.btnGetSerialPorts.Click += new System.EventHandler(this.btnGetSerialPorts_Click);
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(95, 11);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(121, 21);
            this.cboPorts.TabIndex = 1;
            // 
            // btnPortState
            // 
            this.btnPortState.Location = new System.Drawing.Point(222, 10);
            this.btnPortState.Name = "btnPortState";
            this.btnPortState.Size = new System.Drawing.Size(75, 23);
            this.btnPortState.TabIndex = 2;
            this.btnPortState.Text = "Open";
            this.btnPortState.UseVisualStyleBackColor = true;
            this.btnPortState.Click += new System.EventHandler(this.btnPortState_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(14, 475);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Searc&h";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnStop
            // 
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(198, 475);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(99, 52);
            this.btnStop.TabIndex = 22;
            this.btnStop.Text = "&Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(14, 504);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 19;
            this.btnRun.Text = "&Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnAcquireOne
            // 
            this.btnAcquireOne.Location = new System.Drawing.Point(95, 504);
            this.btnAcquireOne.Name = "btnAcquireOne";
            this.btnAcquireOne.Size = new System.Drawing.Size(97, 23);
            this.btnAcquireOne.TabIndex = 21;
            this.btnAcquireOne.Text = "&Acquire 1 block";
            this.btnAcquireOne.UseVisualStyleBackColor = true;
            this.btnAcquireOne.Click += new System.EventHandler(this.btnAcquireOne_Click);
            // 
            // btnAcquireFlats
            // 
            this.btnAcquireFlats.Location = new System.Drawing.Point(95, 475);
            this.btnAcquireFlats.Name = "btnAcquireFlats";
            this.btnAcquireFlats.Size = new System.Drawing.Size(97, 23);
            this.btnAcquireFlats.TabIndex = 20;
            this.btnAcquireFlats.Text = "&Flats / Darks";
            this.btnAcquireFlats.UseVisualStyleBackColor = true;
            this.btnAcquireFlats.Click += new System.EventHandler(this.btnAcquireFlats_Click);
            // 
            // numericUpDownRate
            // 
            this.numericUpDownRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownRate.Location = new System.Drawing.Point(177, 52);
            this.numericUpDownRate.Maximum = new decimal(new int[] {
            9975,
            0,
            0,
            0});
            this.numericUpDownRate.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownRate.Name = "numericUpDownRate";
            this.numericUpDownRate.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRate.TabIndex = 3;
            this.numericUpDownRate.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownRate.ValueChanged += new System.EventHandler(this.numericUpDownRate_ValueChanged);
            // 
            // checkBoxInternalTrigger
            // 
            this.checkBoxInternalTrigger.AutoSize = true;
            this.checkBoxInternalTrigger.Location = new System.Drawing.Point(14, 53);
            this.checkBoxInternalTrigger.Name = "checkBoxInternalTrigger";
            this.checkBoxInternalTrigger.Size = new System.Drawing.Size(154, 17);
            this.checkBoxInternalTrigger.TabIndex = 13;
            this.checkBoxInternalTrigger.Text = "&Internal Trigger - Cycle (ms)";
            this.checkBoxInternalTrigger.UseVisualStyleBackColor = true;
            this.checkBoxInternalTrigger.CheckedChanged += new System.EventHandler(this.checkBoxInternalTrigger_CheckedChanged);
            // 
            // checkBoxShutterOpen
            // 
            this.checkBoxShutterOpen.AutoSize = true;
            this.checkBoxShutterOpen.Location = new System.Drawing.Point(12, 399);
            this.checkBoxShutterOpen.Name = "checkBoxShutterOpen";
            this.checkBoxShutterOpen.Size = new System.Drawing.Size(119, 17);
            this.checkBoxShutterOpen.TabIndex = 15;
            this.checkBoxShutterOpen.Text = "Force Shutter &Open";
            this.checkBoxShutterOpen.UseVisualStyleBackColor = true;
            this.checkBoxShutterOpen.CheckedChanged += new System.EventHandler(this.checkBoxShutterOpen_CheckedChanged);
            // 
            // checkBoxRxActive
            // 
            this.checkBoxRxActive.AutoSize = true;
            this.checkBoxRxActive.Checked = true;
            this.checkBoxRxActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRxActive.Location = new System.Drawing.Point(12, 445);
            this.checkBoxRxActive.Name = "checkBoxRxActive";
            this.checkBoxRxActive.Size = new System.Drawing.Size(110, 17);
            this.checkBoxRxActive.TabIndex = 17;
            this.checkBoxRxActive.Text = "R&x Active on Run";
            this.checkBoxRxActive.UseVisualStyleBackColor = true;
            this.checkBoxRxActive.CheckedChanged += new System.EventHandler(this.checkBoxRxActive_CheckedChanged);
            // 
            // checkBoxManualRx
            // 
            this.checkBoxManualRx.AutoSize = true;
            this.checkBoxManualRx.Location = new System.Drawing.Point(12, 422);
            this.checkBoxManualRx.Name = "checkBoxManualRx";
            this.checkBoxManualRx.Size = new System.Drawing.Size(160, 17);
            this.checkBoxManualRx.TabIndex = 16;
            this.checkBoxManualRx.Text = "&Manual Rx (Deliver Rx Now)";
            this.checkBoxManualRx.UseVisualStyleBackColor = true;
            this.checkBoxManualRx.CheckedChanged += new System.EventHandler(this.checkBoxManualRx_CheckedChanged);
            // 
            // numericUpDownInitialDelay
            // 
            this.numericUpDownInitialDelay.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownInitialDelay.Location = new System.Drawing.Point(177, 91);
            this.numericUpDownInitialDelay.Maximum = new decimal(new int[] {
            9995,
            0,
            0,
            0});
            this.numericUpDownInitialDelay.Name = "numericUpDownInitialDelay";
            this.numericUpDownInitialDelay.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownInitialDelay.TabIndex = 4;
            this.numericUpDownInitialDelay.Value = new decimal(new int[] {
            425,
            0,
            0,
            0});
            this.numericUpDownInitialDelay.ValueChanged += new System.EventHandler(this.numericUpDownInitialDelay_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Initial Delay (ms)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Shutter Open Delay (ms)";
            // 
            // numericUpDownShutterOpen
            // 
            this.numericUpDownShutterOpen.Location = new System.Drawing.Point(177, 113);
            this.numericUpDownShutterOpen.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownShutterOpen.Name = "numericUpDownShutterOpen";
            this.numericUpDownShutterOpen.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownShutterOpen.TabIndex = 5;
            this.numericUpDownShutterOpen.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownShutterOpen.ValueChanged += new System.EventHandler(this.numericUpDownShutterOpen_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Camera Exposure Length (ms)";
            // 
            // numericUpDownLongCamera
            // 
            this.numericUpDownLongCamera.Location = new System.Drawing.Point(177, 135);
            this.numericUpDownLongCamera.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownLongCamera.Name = "numericUpDownLongCamera";
            this.numericUpDownLongCamera.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLongCamera.TabIndex = 6;
            this.numericUpDownLongCamera.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownLongCamera.ValueChanged += new System.EventHandler(this.numericUpDownLongCamera_ValueChanged);
            // 
            // numericUpDownImagingFlats
            // 
            this.numericUpDownImagingFlats.Location = new System.Drawing.Point(177, 284);
            this.numericUpDownImagingFlats.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownImagingFlats.Name = "numericUpDownImagingFlats";
            this.numericUpDownImagingFlats.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownImagingFlats.TabIndex = 11;
            this.numericUpDownImagingFlats.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownImagingFlats.ValueChanged += new System.EventHandler(this.numericUpDownImagingFlats_ValueChanged);
            // 
            // numericUpDownImagingExposures
            // 
            this.numericUpDownImagingExposures.Location = new System.Drawing.Point(177, 240);
            this.numericUpDownImagingExposures.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownImagingExposures.Name = "numericUpDownImagingExposures";
            this.numericUpDownImagingExposures.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownImagingExposures.TabIndex = 9;
            this.numericUpDownImagingExposures.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownImagingExposures.ValueChanged += new System.EventHandler(this.numericUpDownImagingExposures_ValueChanged);
            // 
            // numericUpDownShutterClose
            // 
            this.numericUpDownShutterClose.Location = new System.Drawing.Point(177, 179);
            this.numericUpDownShutterClose.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownShutterClose.Name = "numericUpDownShutterClose";
            this.numericUpDownShutterClose.Size = new System.Drawing.Size(120, 20);
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
            this.numericUpDownCameraDelay.Location = new System.Drawing.Point(177, 157);
            this.numericUpDownCameraDelay.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownCameraDelay.Name = "numericUpDownCameraDelay";
            this.numericUpDownCameraDelay.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCameraDelay.TabIndex = 7;
            this.numericUpDownCameraDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownCameraDelay.ValueChanged += new System.EventHandler(this.numericUpDownCameraDelay_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Pause Between Exposures (ms)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Shutter Close Delay (ms)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Imaging Exposures (per breath)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Imaging Repeats (breaths)";
            // 
            // numericUpDownImagingRepeats
            // 
            this.numericUpDownImagingRepeats.Location = new System.Drawing.Point(177, 262);
            this.numericUpDownImagingRepeats.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownImagingRepeats.Name = "numericUpDownImagingRepeats";
            this.numericUpDownImagingRepeats.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownImagingRepeats.TabIndex = 10;
            this.numericUpDownImagingRepeats.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownImagingRepeats.ValueChanged += new System.EventHandler(this.numericUpDownImagingRepeats_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Rx Repeats (breaths)";
            // 
            // numericUpDownRxRepeats
            // 
            this.numericUpDownRxRepeats.Location = new System.Drawing.Point(175, 368);
            this.numericUpDownRxRepeats.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownRxRepeats.Name = "numericUpDownRxRepeats";
            this.numericUpDownRxRepeats.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRxRepeats.TabIndex = 14;
            this.numericUpDownRxRepeats.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDownRxRepeats.ValueChanged += new System.EventHandler(this.numericUpDownRxRepeats_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Rx Pulse Length (ms)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Rx Delay (ms)";
            // 
            // numericUpDownRxPulse
            // 
            this.numericUpDownRxPulse.Location = new System.Drawing.Point(176, 346);
            this.numericUpDownRxPulse.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownRxPulse.Name = "numericUpDownRxPulse";
            this.numericUpDownRxPulse.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRxPulse.TabIndex = 13;
            this.numericUpDownRxPulse.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownRxPulse.ValueChanged += new System.EventHandler(this.numericUpDownRxPulse_ValueChanged);
            // 
            // numericUpDownRxDelay
            // 
            this.numericUpDownRxDelay.Location = new System.Drawing.Point(176, 324);
            this.numericUpDownRxDelay.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownRxDelay.Name = "numericUpDownRxDelay";
            this.numericUpDownRxDelay.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRxDelay.TabIndex = 12;
            this.numericUpDownRxDelay.ValueChanged += new System.EventHandler(this.numericUpDownRxDelay_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Imaging Flats";
            // 
            // labelTxCommand
            // 
            this.labelTxCommand.AutoSize = true;
            this.labelTxCommand.Location = new System.Drawing.Point(17, 531);
            this.labelTxCommand.Name = "labelTxCommand";
            this.labelTxCommand.Size = new System.Drawing.Size(0, 13);
            this.labelTxCommand.TabIndex = 42;
            // 
            // labelRxCommand
            // 
            this.labelRxCommand.AutoSize = true;
            this.labelRxCommand.Location = new System.Drawing.Point(199, 531);
            this.labelRxCommand.Name = "labelRxCommand";
            this.labelRxCommand.Size = new System.Drawing.Size(0, 13);
            this.labelRxCommand.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Total Acquire Time (ms)";
            // 
            // labelAcquireTime
            // 
            this.labelAcquireTime.AutoSize = true;
            this.labelAcquireTime.Location = new System.Drawing.Point(177, 203);
            this.labelAcquireTime.Name = "labelAcquireTime";
            this.labelAcquireTime.Size = new System.Drawing.Size(25, 13);
            this.labelAcquireTime.TabIndex = 45;
            this.labelAcquireTime.Text = "470";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 548);
            this.Controls.Add(this.labelAcquireTime);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelRxCommand);
            this.Controls.Add(this.labelTxCommand);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDownRxRepeats);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numericUpDownRxPulse);
            this.Controls.Add(this.numericUpDownRxDelay);
            this.Controls.Add(this.numericUpDownImagingRepeats);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownImagingFlats);
            this.Controls.Add(this.numericUpDownImagingExposures);
            this.Controls.Add(this.numericUpDownShutterClose);
            this.Controls.Add(this.numericUpDownCameraDelay);
            this.Controls.Add(this.numericUpDownLongCamera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownShutterOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownInitialDelay);
            this.Controls.Add(this.checkBoxManualRx);
            this.Controls.Add(this.checkBoxRxActive);
            this.Controls.Add(this.checkBoxShutterOpen);
            this.Controls.Add(this.checkBoxInternalTrigger);
            this.Controls.Add(this.numericUpDownRate);
            this.Controls.Add(this.btnAcquireFlats);
            this.Controls.Add(this.btnAcquireOne);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPortState);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.btnGetSerialPorts);
            this.Name = "Form1";
            this.Text = "Timing Box Control";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInitialDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShutterOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImagingFlats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImagingExposures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShutterClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCameraDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImagingRepeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRxRepeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRxPulse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRxDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetSerialPorts;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.Button btnPortState;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnAcquireOne;
        private System.Windows.Forms.Button btnAcquireFlats;
        private System.Windows.Forms.NumericUpDown numericUpDownRate;
        private System.Windows.Forms.CheckBox checkBoxInternalTrigger;
        private System.Windows.Forms.CheckBox checkBoxShutterOpen;
        private System.Windows.Forms.CheckBox checkBoxRxActive;
        private System.Windows.Forms.CheckBox checkBoxManualRx;
        private System.Windows.Forms.NumericUpDown numericUpDownInitialDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownShutterOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownLongCamera;
        private System.Windows.Forms.NumericUpDown numericUpDownImagingFlats;
        private System.Windows.Forms.NumericUpDown numericUpDownImagingExposures;
        private System.Windows.Forms.NumericUpDown numericUpDownShutterClose;
        private System.Windows.Forms.NumericUpDown numericUpDownCameraDelay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownImagingRepeats;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownRxRepeats;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDownRxPulse;
        private System.Windows.Forms.NumericUpDown numericUpDownRxDelay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTxCommand;
        private System.Windows.Forms.Label labelRxCommand;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelAcquireTime;
    }
}

