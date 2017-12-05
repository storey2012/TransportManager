namespace TransManager
{
    partial class frmJobEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobEdit));
            this.label17 = new System.Windows.Forms.Label();
            this.dtpLeg1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbClientDetails = new System.Windows.Forms.RichTextBox();
            this.radOneWay = new System.Windows.Forms.RadioButton();
            this.rad2Leg = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtbLeg1To = new System.Windows.Forms.RichTextBox();
            this.rtbLeg1From = new System.Windows.Forms.RichTextBox();
            this.cboAppt1Minute = new System.Windows.Forms.ComboBox();
            this.cboAppt1Hour = new System.Windows.Forms.ComboBox();
            this.cboLeg1From = new System.Windows.Forms.ComboBox();
            this.cboLeg1To = new System.Windows.Forms.ComboBox();
            this.rtbLeg2To = new System.Windows.Forms.RichTextBox();
            this.rtbLeg2From = new System.Windows.Forms.RichTextBox();
            this.cboPickUp2Minute = new System.Windows.Forms.ComboBox();
            this.cboPickUp2Hour = new System.Windows.Forms.ComboBox();
            this.cboLeg2From = new System.Windows.Forms.ComboBox();
            this.cboLeg2To = new System.Windows.Forms.ComboBox();
            this.epTick = new System.Windows.Forms.ErrorProvider(this.components);
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.radWheelchairYes = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.radWheelchairNo = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbSearchOptions = new System.Windows.Forms.GroupBox();
            this.btnAllocateJob = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDriverLeg1 = new System.Windows.Forms.ComboBox();
            this.grpLeg1 = new System.Windows.Forms.GroupBox();
            this.cboPickUp1Minute = new System.Windows.Forms.ComboBox();
            this.cboPickUp1Hour = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboJobs = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.clbAttributes = new System.Windows.Forms.CheckedListBox();
            this.lblDateChange1 = new System.Windows.Forms.Label();
            this.lblDateChange2 = new System.Windows.Forms.Label();
            this.lblDateChange3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbSearchOptions.SuspendLayout();
            this.grpLeg1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(8, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Client:";
            // 
            // dtpLeg1
            // 
            this.dtpLeg1.CalendarMonthBackground = System.Drawing.Color.Yellow;
            this.dtpLeg1.CalendarTitleBackColor = System.Drawing.Color.Yellow;
            this.dtpLeg1.CausesValidation = false;
            this.dtpLeg1.Enabled = false;
            this.dtpLeg1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLeg1.Location = new System.Drawing.Point(92, 107);
            this.dtpLeg1.Name = "dtpLeg1";
            this.dtpLeg1.Size = new System.Drawing.Size(132, 20);
            this.dtpLeg1.TabIndex = 30;
            this.dtpLeg1.ValueChanged += new System.EventHandler(this.dtpLeg1_ValueChanged);
            this.dtpLeg1.Enter += new System.EventHandler(this.dtpLeg1_Enter);
            this.dtpLeg1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dtpLeg1_MouseMove);
            this.dtpLeg1.Validating += new System.ComponentModel.CancelEventHandler(this.dtpLeg1_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(32, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Job Date:";
            // 
            // rtbClientDetails
            // 
            this.rtbClientDetails.BackColor = System.Drawing.SystemColors.Control;
            this.rtbClientDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbClientDetails.ForeColor = System.Drawing.Color.Black;
            this.rtbClientDetails.Location = new System.Drawing.Point(57, 19);
            this.rtbClientDetails.Name = "rtbClientDetails";
            this.rtbClientDetails.Size = new System.Drawing.Size(167, 75);
            this.rtbClientDetails.TabIndex = 41;
            this.rtbClientDetails.Text = "";
            // 
            // radOneWay
            // 
            this.radOneWay.AutoSize = true;
            this.radOneWay.Location = new System.Drawing.Point(16, 9);
            this.radOneWay.Name = "radOneWay";
            this.radOneWay.Size = new System.Drawing.Size(110, 17);
            this.radOneWay.TabIndex = 44;
            this.radOneWay.Text = "One Way Journey";
            this.radOneWay.UseVisualStyleBackColor = true;
            this.radOneWay.CheckedChanged += new System.EventHandler(this.radOneWay_CheckedChanged);
            // 
            // rad2Leg
            // 
            this.rad2Leg.AutoSize = true;
            this.rad2Leg.Location = new System.Drawing.Point(16, 35);
            this.rad2Leg.Name = "rad2Leg";
            this.rad2Leg.Size = new System.Drawing.Size(153, 17);
            this.rad2Leg.TabIndex = 45;
            this.rad2Leg.Text = "Multiple Destination (2 Leg)";
            this.rad2Leg.UseVisualStyleBackColor = true;
            this.rad2Leg.CheckedChanged += new System.EventHandler(this.rad2Leg_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radOneWay);
            this.panel3.Controls.Add(this.rad2Leg);
            this.panel3.Location = new System.Drawing.Point(257, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 64);
            this.panel3.TabIndex = 65;
            // 
            // rtbLeg1To
            // 
            this.rtbLeg1To.BackColor = System.Drawing.SystemColors.Control;
            this.rtbLeg1To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbLeg1To.ForeColor = System.Drawing.Color.Black;
            this.rtbLeg1To.Location = new System.Drawing.Point(235, 79);
            this.rtbLeg1To.Name = "rtbLeg1To";
            this.rtbLeg1To.Size = new System.Drawing.Size(181, 82);
            this.rtbLeg1To.TabIndex = 72;
            this.rtbLeg1To.Text = "";
            // 
            // rtbLeg1From
            // 
            this.rtbLeg1From.BackColor = System.Drawing.SystemColors.Control;
            this.rtbLeg1From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbLeg1From.ForeColor = System.Drawing.Color.Black;
            this.rtbLeg1From.Location = new System.Drawing.Point(35, 80);
            this.rtbLeg1From.Name = "rtbLeg1From";
            this.rtbLeg1From.Size = new System.Drawing.Size(181, 81);
            this.rtbLeg1From.TabIndex = 71;
            this.rtbLeg1From.Text = "";
            // 
            // cboAppt1Minute
            // 
            this.cboAppt1Minute.FormattingEnabled = true;
            this.cboAppt1Minute.Location = new System.Drawing.Point(166, 18);
            this.cboAppt1Minute.Name = "cboAppt1Minute";
            this.cboAppt1Minute.Size = new System.Drawing.Size(50, 21);
            this.cboAppt1Minute.TabIndex = 68;
            this.cboAppt1Minute.Tag = "1";
            this.cboAppt1Minute.SelectedIndexChanged += new System.EventHandler(this.cboAppt1Minute_SelectedIndexChanged);
            // 
            // cboAppt1Hour
            // 
            this.cboAppt1Hour.FormattingEnabled = true;
            this.cboAppt1Hour.Location = new System.Drawing.Point(110, 18);
            this.cboAppt1Hour.Name = "cboAppt1Hour";
            this.cboAppt1Hour.Size = new System.Drawing.Size(46, 21);
            this.cboAppt1Hour.TabIndex = 67;
            this.cboAppt1Hour.SelectedIndexChanged += new System.EventHandler(this.cboAppt1Hour_SelectedIndexChanged);
            // 
            // cboLeg1From
            // 
            this.cboLeg1From.FormattingEnabled = true;
            this.cboLeg1From.Location = new System.Drawing.Point(41, 44);
            this.cboLeg1From.Name = "cboLeg1From";
            this.cboLeg1From.Size = new System.Drawing.Size(175, 21);
            this.cboLeg1From.TabIndex = 59;
            this.cboLeg1From.SelectedIndexChanged += new System.EventHandler(this.cboLeg1From_SelectedIndexChanged_1);
            // 
            // cboLeg1To
            // 
            this.cboLeg1To.FormattingEnabled = true;
            this.cboLeg1To.Location = new System.Drawing.Point(241, 44);
            this.cboLeg1To.Name = "cboLeg1To";
            this.cboLeg1To.Size = new System.Drawing.Size(175, 21);
            this.cboLeg1To.TabIndex = 60;
            this.cboLeg1To.Tag = "1";
            this.cboLeg1To.SelectedIndexChanged += new System.EventHandler(this.cboLeg1To_SelectedIndexChanged);
            // 
            // rtbLeg2To
            // 
            this.rtbLeg2To.BackColor = System.Drawing.SystemColors.Control;
            this.rtbLeg2To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbLeg2To.ForeColor = System.Drawing.Color.Black;
            this.rtbLeg2To.Location = new System.Drawing.Point(235, 81);
            this.rtbLeg2To.Name = "rtbLeg2To";
            this.rtbLeg2To.Size = new System.Drawing.Size(180, 74);
            this.rtbLeg2To.TabIndex = 60;
            this.rtbLeg2To.Text = "";
            // 
            // rtbLeg2From
            // 
            this.rtbLeg2From.BackColor = System.Drawing.SystemColors.Control;
            this.rtbLeg2From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbLeg2From.ForeColor = System.Drawing.Color.Black;
            this.rtbLeg2From.Location = new System.Drawing.Point(35, 81);
            this.rtbLeg2From.Name = "rtbLeg2From";
            this.rtbLeg2From.Size = new System.Drawing.Size(180, 74);
            this.rtbLeg2From.TabIndex = 59;
            this.rtbLeg2From.Text = "";
            // 
            // cboPickUp2Minute
            // 
            this.cboPickUp2Minute.FormattingEnabled = true;
            this.cboPickUp2Minute.Location = new System.Drawing.Point(167, 18);
            this.cboPickUp2Minute.Name = "cboPickUp2Minute";
            this.cboPickUp2Minute.Size = new System.Drawing.Size(49, 21);
            this.cboPickUp2Minute.TabIndex = 46;
            this.cboPickUp2Minute.Tag = "1";
            // 
            // cboPickUp2Hour
            // 
            this.cboPickUp2Hour.FormattingEnabled = true;
            this.cboPickUp2Hour.Location = new System.Drawing.Point(104, 18);
            this.cboPickUp2Hour.Name = "cboPickUp2Hour";
            this.cboPickUp2Hour.Size = new System.Drawing.Size(46, 21);
            this.cboPickUp2Hour.TabIndex = 45;
            // 
            // cboLeg2From
            // 
            this.cboLeg2From.Enabled = false;
            this.cboLeg2From.FormattingEnabled = true;
            this.cboLeg2From.Location = new System.Drawing.Point(52, 44);
            this.cboLeg2From.Name = "cboLeg2From";
            this.cboLeg2From.Size = new System.Drawing.Size(164, 21);
            this.cboLeg2From.TabIndex = 26;
            this.cboLeg2From.SelectedIndexChanged += new System.EventHandler(this.cboLeg2From_SelectedIndexChanged);
            // 
            // cboLeg2To
            // 
            this.cboLeg2To.Enabled = false;
            this.cboLeg2To.FormattingEnabled = true;
            this.cboLeg2To.Location = new System.Drawing.Point(250, 44);
            this.cboLeg2To.Name = "cboLeg2To";
            this.cboLeg2To.Size = new System.Drawing.Size(166, 21);
            this.cboLeg2To.TabIndex = 27;
            this.cboLeg2To.Tag = "1";
            this.cboLeg2To.SelectedIndexChanged += new System.EventHandler(this.cboLeg2To_SelectedIndexChanged);
            // 
            // epTick
            // 
            this.epTick.ContainerControl = this;
            this.epTick.Icon = ((System.Drawing.Icon)(resources.GetObject("epTick.Icon")));
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            this.epError.Icon = ((System.Drawing.Icon)(resources.GetObject("epError.Icon")));
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // radWheelchairYes
            // 
            this.radWheelchairYes.AutoSize = true;
            this.radWheelchairYes.Location = new System.Drawing.Point(5, 4);
            this.radWheelchairYes.Name = "radWheelchairYes";
            this.radWheelchairYes.Size = new System.Drawing.Size(43, 17);
            this.radWheelchairYes.TabIndex = 13;
            this.radWheelchairYes.Text = "Yes";
            this.radWheelchairYes.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "DVC Wheelchair?";
            // 
            // radWheelchairNo
            // 
            this.radWheelchairNo.AutoSize = true;
            this.radWheelchairNo.Checked = true;
            this.radWheelchairNo.Location = new System.Drawing.Point(54, 4);
            this.radWheelchairNo.Name = "radWheelchairNo";
            this.radWheelchairNo.Size = new System.Drawing.Size(39, 17);
            this.radWheelchairNo.TabIndex = 14;
            this.radWheelchairNo.TabStop = true;
            this.radWheelchairNo.Text = "No";
            this.radWheelchairNo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radWheelchairNo);
            this.panel1.Controls.Add(this.radWheelchairYes);
            this.panel1.Location = new System.Drawing.Point(127, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 28);
            this.panel1.TabIndex = 55;
            // 
            // rtbNotes
            // 
            this.rtbNotes.BackColor = System.Drawing.SystemColors.Window;
            this.rtbNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbNotes.ForeColor = System.Drawing.Color.Red;
            this.rtbNotes.Location = new System.Drawing.Point(28, 387);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(202, 69);
            this.rtbNotes.TabIndex = 59;
            this.rtbNotes.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(34, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Notes:";
            // 
            // gbSearchOptions
            // 
            this.gbSearchOptions.Controls.Add(this.btnAllocateJob);
            this.gbSearchOptions.Controls.Add(this.label1);
            this.gbSearchOptions.Controls.Add(this.cboDriverLeg1);
            this.gbSearchOptions.Controls.Add(this.panel3);
            this.gbSearchOptions.Controls.Add(this.grpLeg1);
            this.gbSearchOptions.Controls.Add(this.groupBox2);
            this.gbSearchOptions.Controls.Add(this.label14);
            this.gbSearchOptions.Controls.Add(this.cboJobs);
            this.gbSearchOptions.Location = new System.Drawing.Point(241, 10);
            this.gbSearchOptions.Margin = new System.Windows.Forms.Padding(2);
            this.gbSearchOptions.Name = "gbSearchOptions";
            this.gbSearchOptions.Padding = new System.Windows.Forms.Padding(2);
            this.gbSearchOptions.Size = new System.Drawing.Size(476, 516);
            this.gbSearchOptions.TabIndex = 65;
            this.gbSearchOptions.TabStop = false;
            this.gbSearchOptions.Text = "Set Job:";
            // 
            // btnAllocateJob
            // 
            this.btnAllocateJob.Location = new System.Drawing.Point(192, 473);
            this.btnAllocateJob.Name = "btnAllocateJob";
            this.btnAllocateJob.Size = new System.Drawing.Size(76, 33);
            this.btnAllocateJob.TabIndex = 71;
            this.btnAllocateJob.Text = "Update Job";
            this.btnAllocateJob.UseVisualStyleBackColor = true;
            this.btnAllocateJob.Click += new System.EventHandler(this.btnAllocateJob_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Driver:";
            // 
            // cboDriverLeg1
            // 
            this.cboDriverLeg1.Enabled = false;
            this.cboDriverLeg1.FormattingEnabled = true;
            this.cboDriverLeg1.Location = new System.Drawing.Point(87, 47);
            this.cboDriverLeg1.Name = "cboDriverLeg1";
            this.cboDriverLeg1.Size = new System.Drawing.Size(144, 21);
            this.cboDriverLeg1.TabIndex = 72;
            this.cboDriverLeg1.Tag = "clean";
            this.cboDriverLeg1.SelectedIndexChanged += new System.EventHandler(this.cboDriverLeg1_SelectedIndexChanged);
            // 
            // grpLeg1
            // 
            this.grpLeg1.Controls.Add(this.rtbLeg1To);
            this.grpLeg1.Controls.Add(this.cboPickUp1Minute);
            this.grpLeg1.Controls.Add(this.rtbLeg1From);
            this.grpLeg1.Controls.Add(this.cboPickUp1Hour);
            this.grpLeg1.Controls.Add(this.label12);
            this.grpLeg1.Controls.Add(this.cboAppt1Minute);
            this.grpLeg1.Controls.Add(this.cboAppt1Hour);
            this.grpLeg1.Controls.Add(this.cboLeg1From);
            this.grpLeg1.Controls.Add(this.label15);
            this.grpLeg1.Controls.Add(this.cboLeg1To);
            this.grpLeg1.Controls.Add(this.label19);
            this.grpLeg1.Controls.Add(this.label20);
            this.grpLeg1.Location = new System.Drawing.Point(5, 90);
            this.grpLeg1.Name = "grpLeg1";
            this.grpLeg1.Size = new System.Drawing.Size(459, 182);
            this.grpLeg1.TabIndex = 71;
            this.grpLeg1.TabStop = false;
            this.grpLeg1.Text = "Leg 1";
            this.grpLeg1.Enter += new System.EventHandler(this.grpLeg1_Enter);
            // 
            // cboPickUp1Minute
            // 
            this.cboPickUp1Minute.FormattingEnabled = true;
            this.cboPickUp1Minute.Location = new System.Drawing.Point(366, 18);
            this.cboPickUp1Minute.Name = "cboPickUp1Minute";
            this.cboPickUp1Minute.Size = new System.Drawing.Size(49, 21);
            this.cboPickUp1Minute.TabIndex = 70;
            this.cboPickUp1Minute.Tag = "1";
            // 
            // cboPickUp1Hour
            // 
            this.cboPickUp1Hour.FormattingEnabled = true;
            this.cboPickUp1Hour.Location = new System.Drawing.Point(304, 18);
            this.cboPickUp1Hour.Name = "cboPickUp1Hour";
            this.cboPickUp1Hour.Size = new System.Drawing.Size(46, 21);
            this.cboPickUp1Hour.TabIndex = 69;
            this.cboPickUp1Hour.SelectedIndexChanged += new System.EventHandler(this.cboPickUp1Hour_SelectedIndexChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(230, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Pick up time:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(7, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Appointment time:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(11, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 13);
            this.label19.TabIndex = 28;
            this.label19.Text = "From:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(220, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "To:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.rtbLeg2To);
            this.groupBox2.Controls.Add(this.cboPickUp2Minute);
            this.groupBox2.Controls.Add(this.rtbLeg2From);
            this.groupBox2.Controls.Add(this.cboLeg2From);
            this.groupBox2.Controls.Add(this.cboLeg2To);
            this.groupBox2.Controls.Add(this.cboPickUp2Hour);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Location = new System.Drawing.Point(5, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 182);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leg2";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(13, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 13);
            this.label21.TabIndex = 28;
            this.label21.Text = "From:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(30, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 13);
            this.label22.TabIndex = 33;
            this.label22.Text = "Pick up time:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label23.Location = new System.Drawing.Point(224, 48);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(23, 13);
            this.label23.TabIndex = 29;
            this.label23.Text = "To:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(5, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "Choose Job:";
            // 
            // cboJobs
            // 
            this.cboJobs.BackColor = System.Drawing.Color.Yellow;
            this.cboJobs.FormattingEnabled = true;
            this.cboJobs.Location = new System.Drawing.Point(87, 18);
            this.cboJobs.Name = "cboJobs";
            this.cboJobs.Size = new System.Drawing.Size(144, 21);
            this.cboJobs.TabIndex = 59;
            this.cboJobs.SelectedIndexChanged += new System.EventHandler(this.cboJobs_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 201);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 67;
            this.label16.Text = "Client Details:";
            // 
            // clbAttributes
            // 
            this.clbAttributes.BackColor = System.Drawing.SystemColors.Menu;
            this.clbAttributes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbAttributes.CheckOnClick = true;
            this.clbAttributes.Enabled = false;
            this.clbAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbAttributes.FormattingEnabled = true;
            this.clbAttributes.Location = new System.Drawing.Point(28, 217);
            this.clbAttributes.Margin = new System.Windows.Forms.Padding(2);
            this.clbAttributes.Name = "clbAttributes";
            this.clbAttributes.Size = new System.Drawing.Size(202, 100);
            this.clbAttributes.Sorted = true;
            this.clbAttributes.TabIndex = 66;
            this.clbAttributes.ThreeDCheckBoxes = true;
            // 
            // lblDateChange1
            // 
            this.lblDateChange1.AutoSize = true;
            this.lblDateChange1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateChange1.ForeColor = System.Drawing.Color.Red;
            this.lblDateChange1.Location = new System.Drawing.Point(33, 135);
            this.lblDateChange1.Name = "lblDateChange1";
            this.lblDateChange1.Size = new System.Drawing.Size(133, 13);
            this.lblDateChange1.TabIndex = 68;
            this.lblDateChange1.Text = "Job date cannot be altered";
            this.lblDateChange1.Visible = false;
            // 
            // lblDateChange2
            // 
            this.lblDateChange2.AutoSize = true;
            this.lblDateChange2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateChange2.ForeColor = System.Drawing.Color.Red;
            this.lblDateChange2.Location = new System.Drawing.Point(33, 169);
            this.lblDateChange2.Name = "lblDateChange2";
            this.lblDateChange2.Size = new System.Drawing.Size(134, 13);
            this.lblDateChange2.TabIndex = 69;
            this.lblDateChange2.Text = "Please cancel and re-book.";
            this.lblDateChange2.Visible = false;
            // 
            // lblDateChange3
            // 
            this.lblDateChange3.AutoSize = true;
            this.lblDateChange3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateChange3.ForeColor = System.Drawing.Color.Red;
            this.lblDateChange3.Location = new System.Drawing.Point(33, 152);
            this.lblDateChange3.Name = "lblDateChange3";
            this.lblDateChange3.Size = new System.Drawing.Size(169, 13);
            this.lblDateChange3.TabIndex = 70;
            this.lblDateChange3.Text = "for existing job if driver is allocated.";
            this.lblDateChange3.Visible = false;
            // 
            // frmJobEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 537);
            this.Controls.Add(this.lblDateChange3);
            this.Controls.Add(this.lblDateChange2);
            this.Controls.Add(this.lblDateChange1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.clbAttributes);
            this.Controls.Add(this.gbSearchOptions);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtbClientDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpLeg1);
            this.Controls.Add(this.label17);
            this.Name = "frmJobEdit";
            this.Text = "Job Maintenance";
            this.Load += new System.EventHandler(this.frmJobEdit_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbSearchOptions.ResumeLayout(false);
            this.gbSearchOptions.PerformLayout();
            this.grpLeg1.ResumeLayout(false);
            this.grpLeg1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpLeg1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbClientDetails;
        private System.Windows.Forms.RadioButton radOneWay;
        private System.Windows.Forms.RadioButton rad2Leg;
        private System.Windows.Forms.ErrorProvider epTick;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radWheelchairNo;
        private System.Windows.Forms.RadioButton radWheelchairYes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.GroupBox gbSearchOptions;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboJobs;
        private System.Windows.Forms.RichTextBox rtbLeg1To;
        private System.Windows.Forms.RichTextBox rtbLeg1From;
        private System.Windows.Forms.ComboBox cboAppt1Minute;
        private System.Windows.Forms.ComboBox cboAppt1Hour;
        private System.Windows.Forms.ComboBox cboLeg1From;
        private System.Windows.Forms.ComboBox cboLeg1To;
        private System.Windows.Forms.RichTextBox rtbLeg2To;
        private System.Windows.Forms.RichTextBox rtbLeg2From;
        private System.Windows.Forms.ComboBox cboPickUp2Minute;
        private System.Windows.Forms.ComboBox cboPickUp2Hour;
        private System.Windows.Forms.ComboBox cboLeg2From;
        private System.Windows.Forms.ComboBox cboLeg2To;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckedListBox clbAttributes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDateChange2;
        private System.Windows.Forms.Label lblDateChange1;
        private System.Windows.Forms.GroupBox grpLeg1;
        private System.Windows.Forms.ComboBox cboPickUp1Minute;
        private System.Windows.Forms.ComboBox cboPickUp1Hour;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDriverLeg1;
        private System.Windows.Forms.Label lblDateChange3;
        private System.Windows.Forms.Button btnAllocateJob;
    }
}