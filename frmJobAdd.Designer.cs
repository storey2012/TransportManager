namespace TransManager
{
    partial class frmJobAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobAdd));
            this.cboClientName = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpJobDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbClientDetails = new System.Windows.Forms.RichTextBox();
            this.btnAllocateJob = new System.Windows.Forms.Button();
            this.gbJobDetails = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbClientPhone = new System.Windows.Forms.RichTextBox();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radDVCWheelchairNo = new System.Windows.Forms.RadioButton();
            this.radDVCWheelchairYes = new System.Windows.Forms.RadioButton();
            this.gbSource = new System.Windows.Forms.GroupBox();
            this.lblSourceCheck = new System.Windows.Forms.Label();
            this.cboDriverLeg1 = new System.Windows.Forms.ComboBox();
            this.radSourceOther = new System.Windows.Forms.RadioButton();
            this.radSourceDriver = new System.Windows.Forms.RadioButton();
            this.radSourceClient = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radOneWay = new System.Windows.Forms.RadioButton();
            this.radReturn = new System.Windows.Forms.RadioButton();
            this.grpLeg1 = new System.Windows.Forms.GroupBox();
            this.cboPickUp1Minute = new System.Windows.Forms.ComboBox();
            this.cboPickUp1Hour = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbLeg1To = new System.Windows.Forms.RichTextBox();
            this.rtbLeg1From = new System.Windows.Forms.RichTextBox();
            this.cboAppt1Minute = new System.Windows.Forms.ComboBox();
            this.cboAppt1Hour = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLeg1From = new System.Windows.Forms.ComboBox();
            this.cboLeg1To = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpLeg2 = new System.Windows.Forms.GroupBox();
            this.rtbLeg2To = new System.Windows.Forms.RichTextBox();
            this.rtbLeg2From = new System.Windows.Forms.RichTextBox();
            this.cboPickUp2Minute = new System.Windows.Forms.ComboBox();
            this.cboPickUp2Hour = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboLeg2From = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboLeg2To = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.epTick = new System.Windows.Forms.ErrorProvider(this.components);
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.clbAttributes = new System.Windows.Forms.CheckedListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lvNotes = new System.Windows.Forms.ListView();
            this.Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbJobDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbSource.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpLeg1.SuspendLayout();
            this.grpLeg2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // cboClientName
            // 
            this.cboClientName.BackColor = System.Drawing.Color.Yellow;
            this.cboClientName.FormattingEnabled = true;
            this.cboClientName.Location = new System.Drawing.Point(61, 12);
            this.cboClientName.Name = "cboClientName";
            this.cboClientName.Size = new System.Drawing.Size(156, 21);
            this.cboClientName.TabIndex = 24;
            this.cboClientName.SelectedIndexChanged += new System.EventHandler(this.cboClientName_SelectedIndexChanged);
            this.cboClientName.SelectionChangeCommitted += new System.EventHandler(this.cboClientName_SelectedChangeCommitted);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(19, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Client:";
            // 
            // dtpJobDate
            // 
            this.dtpJobDate.CalendarMonthBackground = System.Drawing.Color.Yellow;
            this.dtpJobDate.CalendarTitleBackColor = System.Drawing.Color.Yellow;
            this.dtpJobDate.CalendarTitleForeColor = System.Drawing.Color.Yellow;
            this.dtpJobDate.CustomFormat = "dd/mm/yyyy";
            this.dtpJobDate.Enabled = false;
            this.dtpJobDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJobDate.Location = new System.Drawing.Point(84, 136);
            this.dtpJobDate.Name = "dtpJobDate";
            this.dtpJobDate.Size = new System.Drawing.Size(132, 20);
            this.dtpJobDate.TabIndex = 30;
            this.dtpJobDate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpJobDate.ValueChanged += new System.EventHandler(this.dtpJobDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(26, 141);
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
            this.rtbClientDetails.Location = new System.Drawing.Point(14, 47);
            this.rtbClientDetails.Name = "rtbClientDetails";
            this.rtbClientDetails.Size = new System.Drawing.Size(202, 74);
            this.rtbClientDetails.TabIndex = 41;
            this.rtbClientDetails.Text = "";
            // 
            // btnAllocateJob
            // 
            this.btnAllocateJob.Location = new System.Drawing.Point(64, 402);
            this.btnAllocateJob.Name = "btnAllocateJob";
            this.btnAllocateJob.Size = new System.Drawing.Size(123, 52);
            this.btnAllocateJob.TabIndex = 48;
            this.btnAllocateJob.Text = "Save Job";
            this.btnAllocateJob.UseVisualStyleBackColor = true;
            this.btnAllocateJob.Click += new System.EventHandler(this.btnAllocateJob_Click);
            // 
            // gbJobDetails
            // 
            this.gbJobDetails.Controls.Add(this.label10);
            this.gbJobDetails.Controls.Add(this.rtbClientPhone);
            this.gbJobDetails.Controls.Add(this.rtbNotes);
            this.gbJobDetails.Controls.Add(this.label13);
            this.gbJobDetails.Controls.Add(this.panel1);
            this.gbJobDetails.Controls.Add(this.gbSource);
            this.gbJobDetails.Controls.Add(this.groupBox1);
            this.gbJobDetails.Controls.Add(this.grpLeg1);
            this.gbJobDetails.Controls.Add(this.grpLeg2);
            this.gbJobDetails.Controls.Add(this.label6);
            this.gbJobDetails.Controls.Add(this.btnAllocateJob);
            this.gbJobDetails.Enabled = false;
            this.gbJobDetails.Location = new System.Drawing.Point(242, 10);
            this.gbJobDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gbJobDetails.Name = "gbJobDetails";
            this.gbJobDetails.Padding = new System.Windows.Forms.Padding(2);
            this.gbJobDetails.Size = new System.Drawing.Size(728, 500);
            this.gbJobDetails.TabIndex = 49;
            this.gbJobDetails.TabStop = false;
            this.gbJobDetails.Text = "Job Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(28, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 70;
            this.label10.Text = "Client Contact Details:";
            // 
            // rtbClientPhone
            // 
            this.rtbClientPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rtbClientPhone.Location = new System.Drawing.Point(30, 36);
            this.rtbClientPhone.Margin = new System.Windows.Forms.Padding(2);
            this.rtbClientPhone.Name = "rtbClientPhone";
            this.rtbClientPhone.Size = new System.Drawing.Size(198, 43);
            this.rtbClientPhone.TabIndex = 70;
            this.rtbClientPhone.Text = "";
            this.rtbClientPhone.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // rtbNotes
            // 
            this.rtbNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rtbNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbNotes.ForeColor = System.Drawing.Color.Red;
            this.rtbNotes.Location = new System.Drawing.Point(27, 295);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(201, 88);
            this.rtbNotes.TabIndex = 71;
            this.rtbNotes.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 69;
            this.label13.Text = "DVC Wheelchair?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radDVCWheelchairNo);
            this.panel1.Controls.Add(this.radDVCWheelchairYes);
            this.panel1.Location = new System.Drawing.Point(125, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 28);
            this.panel1.TabIndex = 70;
            // 
            // radDVCWheelchairNo
            // 
            this.radDVCWheelchairNo.AutoSize = true;
            this.radDVCWheelchairNo.Checked = true;
            this.radDVCWheelchairNo.Location = new System.Drawing.Point(54, 4);
            this.radDVCWheelchairNo.Name = "radDVCWheelchairNo";
            this.radDVCWheelchairNo.Size = new System.Drawing.Size(39, 17);
            this.radDVCWheelchairNo.TabIndex = 14;
            this.radDVCWheelchairNo.TabStop = true;
            this.radDVCWheelchairNo.Text = "No";
            this.radDVCWheelchairNo.UseVisualStyleBackColor = true;
            // 
            // radDVCWheelchairYes
            // 
            this.radDVCWheelchairYes.AutoSize = true;
            this.radDVCWheelchairYes.Location = new System.Drawing.Point(5, 4);
            this.radDVCWheelchairYes.Name = "radDVCWheelchairYes";
            this.radDVCWheelchairYes.Size = new System.Drawing.Size(43, 17);
            this.radDVCWheelchairYes.TabIndex = 13;
            this.radDVCWheelchairYes.Text = "Yes";
            this.radDVCWheelchairYes.UseVisualStyleBackColor = true;
            // 
            // gbSource
            // 
            this.gbSource.Controls.Add(this.lblSourceCheck);
            this.gbSource.Controls.Add(this.cboDriverLeg1);
            this.gbSource.Controls.Add(this.radSourceOther);
            this.gbSource.Controls.Add(this.radSourceDriver);
            this.gbSource.Controls.Add(this.radSourceClient);
            this.gbSource.Location = new System.Drawing.Point(27, 98);
            this.gbSource.Name = "gbSource";
            this.gbSource.Size = new System.Drawing.Size(201, 137);
            this.gbSource.TabIndex = 68;
            this.gbSource.TabStop = false;
            this.gbSource.Text = "Job Source:";
            // 
            // lblSourceCheck
            // 
            this.lblSourceCheck.AutoSize = true;
            this.lblSourceCheck.ForeColor = System.Drawing.Color.Transparent;
            this.lblSourceCheck.Location = new System.Drawing.Point(52, 39);
            this.lblSourceCheck.Name = "lblSourceCheck";
            this.lblSourceCheck.Size = new System.Drawing.Size(18, 13);
            this.lblSourceCheck.TabIndex = 70;
            this.lblSourceCheck.Text = "sc";
            // 
            // cboDriverLeg1
            // 
            this.cboDriverLeg1.Enabled = false;
            this.cboDriverLeg1.FormattingEnabled = true;
            this.cboDriverLeg1.Location = new System.Drawing.Point(16, 76);
            this.cboDriverLeg1.Name = "cboDriverLeg1";
            this.cboDriverLeg1.Size = new System.Drawing.Size(144, 21);
            this.cboDriverLeg1.TabIndex = 69;
            this.cboDriverLeg1.Tag = "clean";
            this.cboDriverLeg1.SelectedIndexChanged += new System.EventHandler(this.cboDriverLeg1_SelectedIndexChanged);
            // 
            // radSourceOther
            // 
            this.radSourceOther.AutoSize = true;
            this.radSourceOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSourceOther.Location = new System.Drawing.Point(16, 106);
            this.radSourceOther.Name = "radSourceOther";
            this.radSourceOther.Size = new System.Drawing.Size(155, 16);
            this.radSourceOther.TabIndex = 18;
            this.radSourceOther.Tag = "3";
            this.radSourceOther.Text = "Other(enter details in Job Notes)";
            this.radSourceOther.UseVisualStyleBackColor = true;
            this.radSourceOther.CheckedChanged += new System.EventHandler(this.radSourceOther_CheckedChanged);
            // 
            // radSourceDriver
            // 
            this.radSourceDriver.AutoSize = true;
            this.radSourceDriver.Location = new System.Drawing.Point(16, 50);
            this.radSourceDriver.Name = "radSourceDriver";
            this.radSourceDriver.Size = new System.Drawing.Size(53, 17);
            this.radSourceDriver.TabIndex = 17;
            this.radSourceDriver.Tag = "2";
            this.radSourceDriver.Text = "Driver";
            this.radSourceDriver.UseVisualStyleBackColor = true;
            this.radSourceDriver.CheckedChanged += new System.EventHandler(this.radSourceDriver_CheckedChanged);
            // 
            // radSourceClient
            // 
            this.radSourceClient.AutoSize = true;
            this.radSourceClient.Location = new System.Drawing.Point(16, 24);
            this.radSourceClient.Name = "radSourceClient";
            this.radSourceClient.Size = new System.Drawing.Size(51, 17);
            this.radSourceClient.TabIndex = 16;
            this.radSourceClient.Tag = "1";
            this.radSourceClient.Text = "Client";
            this.radSourceClient.UseVisualStyleBackColor = true;
            this.radSourceClient.CheckedChanged += new System.EventHandler(this.radSourceClient_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radOneWay);
            this.groupBox1.Controls.Add(this.radReturn);
            this.groupBox1.Location = new System.Drawing.Point(255, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 66);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Journey Type:";
            // 
            // radOneWay
            // 
            this.radOneWay.AutoSize = true;
            this.radOneWay.Location = new System.Drawing.Point(16, 44);
            this.radOneWay.Name = "radOneWay";
            this.radOneWay.Size = new System.Drawing.Size(110, 17);
            this.radOneWay.TabIndex = 47;
            this.radOneWay.Text = "One Way Journey";
            this.radOneWay.UseVisualStyleBackColor = true;
            this.radOneWay.CheckedChanged += new System.EventHandler(this.radOneWay_CheckedChanged);
            // 
            // radReturn
            // 
            this.radReturn.AutoSize = true;
            this.radReturn.Checked = true;
            this.radReturn.Location = new System.Drawing.Point(16, 24);
            this.radReturn.Name = "radReturn";
            this.radReturn.Size = new System.Drawing.Size(97, 17);
            this.radReturn.TabIndex = 46;
            this.radReturn.TabStop = true;
            this.radReturn.Text = "Return Journey";
            this.radReturn.UseVisualStyleBackColor = true;
            this.radReturn.CheckedChanged += new System.EventHandler(this.radReturn_CheckedChanged);
            // 
            // grpLeg1
            // 
            this.grpLeg1.Controls.Add(this.cboPickUp1Minute);
            this.grpLeg1.Controls.Add(this.cboPickUp1Hour);
            this.grpLeg1.Controls.Add(this.label4);
            this.grpLeg1.Controls.Add(this.rtbLeg1To);
            this.grpLeg1.Controls.Add(this.rtbLeg1From);
            this.grpLeg1.Controls.Add(this.cboAppt1Minute);
            this.grpLeg1.Controls.Add(this.cboAppt1Hour);
            this.grpLeg1.Controls.Add(this.label5);
            this.grpLeg1.Controls.Add(this.label1);
            this.grpLeg1.Controls.Add(this.cboLeg1From);
            this.grpLeg1.Controls.Add(this.cboLeg1To);
            this.grpLeg1.Controls.Add(this.label2);
            this.grpLeg1.Location = new System.Drawing.Point(254, 90);
            this.grpLeg1.Name = "grpLeg1";
            this.grpLeg1.Size = new System.Drawing.Size(459, 172);
            this.grpLeg1.TabIndex = 66;
            this.grpLeg1.TabStop = false;
            this.grpLeg1.Text = "Leg 1";
            this.grpLeg1.Enter += new System.EventHandler(this.grpLeg1_Enter);
            // 
            // cboPickUp1Minute
            // 
            this.cboPickUp1Minute.FormattingEnabled = true;
            this.cboPickUp1Minute.Location = new System.Drawing.Point(367, 17);
            this.cboPickUp1Minute.Name = "cboPickUp1Minute";
            this.cboPickUp1Minute.Size = new System.Drawing.Size(49, 21);
            this.cboPickUp1Minute.TabIndex = 61;
            this.cboPickUp1Minute.Tag = "1";
            this.cboPickUp1Minute.SelectedIndexChanged += new System.EventHandler(this.cboPickUp1Minute_SelectedIndexChanged_1);
            // 
            // cboPickUp1Hour
            // 
            this.cboPickUp1Hour.FormattingEnabled = true;
            this.cboPickUp1Hour.Location = new System.Drawing.Point(305, 17);
            this.cboPickUp1Hour.Name = "cboPickUp1Hour";
            this.cboPickUp1Hour.Size = new System.Drawing.Size(46, 21);
            this.cboPickUp1Hour.TabIndex = 60;
            this.cboPickUp1Hour.SelectedIndexChanged += new System.EventHandler(this.cboPickUp1Hour_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(230, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Pick up time:";
            // 
            // rtbLeg1To
            // 
            this.rtbLeg1To.BackColor = System.Drawing.SystemColors.Control;
            this.rtbLeg1To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbLeg1To.ForeColor = System.Drawing.Color.Black;
            this.rtbLeg1To.Location = new System.Drawing.Point(250, 78);
            this.rtbLeg1To.Name = "rtbLeg1To";
            this.rtbLeg1To.Size = new System.Drawing.Size(166, 75);
            this.rtbLeg1To.TabIndex = 58;
            this.rtbLeg1To.Text = "";
            // 
            // rtbLeg1From
            // 
            this.rtbLeg1From.BackColor = System.Drawing.SystemColors.Control;
            this.rtbLeg1From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbLeg1From.ForeColor = System.Drawing.Color.Black;
            this.rtbLeg1From.Location = new System.Drawing.Point(50, 78);
            this.rtbLeg1From.Name = "rtbLeg1From";
            this.rtbLeg1From.Size = new System.Drawing.Size(166, 75);
            this.rtbLeg1From.TabIndex = 57;
            this.rtbLeg1From.Text = "";
            // 
            // cboAppt1Minute
            // 
            this.cboAppt1Minute.FormattingEnabled = true;
            this.cboAppt1Minute.Location = new System.Drawing.Point(166, 19);
            this.cboAppt1Minute.Name = "cboAppt1Minute";
            this.cboAppt1Minute.Size = new System.Drawing.Size(50, 21);
            this.cboAppt1Minute.TabIndex = 46;
            this.cboAppt1Minute.Tag = "1";
            this.cboAppt1Minute.SelectedIndexChanged += new System.EventHandler(this.cboAppt1Minute_SelectedIndexChanged);
            // 
            // cboAppt1Hour
            // 
            this.cboAppt1Hour.FormattingEnabled = true;
            this.cboAppt1Hour.Location = new System.Drawing.Point(104, 19);
            this.cboAppt1Hour.Name = "cboAppt1Hour";
            this.cboAppt1Hour.Size = new System.Drawing.Size(46, 21);
            this.cboAppt1Hour.TabIndex = 45;
            this.cboAppt1Hour.Tag = "1";
            this.cboAppt1Hour.SelectedIndexChanged += new System.EventHandler(this.cboAppt1Hour_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Appointment time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "From:";
            // 
            // cboLeg1From
            // 
            this.cboLeg1From.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboLeg1From.FormattingEnabled = true;
            this.cboLeg1From.Location = new System.Drawing.Point(50, 44);
            this.cboLeg1From.Name = "cboLeg1From";
            this.cboLeg1From.Size = new System.Drawing.Size(166, 21);
            this.cboLeg1From.TabIndex = 26;
            this.cboLeg1From.SelectedIndexChanged += new System.EventHandler(this.cboLeg1From_SelectedIndexChanged_1);
            // 
            // cboLeg1To
            // 
            this.cboLeg1To.FormattingEnabled = true;
            this.cboLeg1To.Location = new System.Drawing.Point(249, 44);
            this.cboLeg1To.Name = "cboLeg1To";
            this.cboLeg1To.Size = new System.Drawing.Size(167, 21);
            this.cboLeg1To.TabIndex = 27;
            this.cboLeg1To.Tag = "1";
            this.cboLeg1To.SelectedIndexChanged += new System.EventHandler(this.cboLeg1To_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(220, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "To:";
            // 
            // grpLeg2
            // 
            this.grpLeg2.Controls.Add(this.rtbLeg2To);
            this.grpLeg2.Controls.Add(this.rtbLeg2From);
            this.grpLeg2.Controls.Add(this.cboPickUp2Minute);
            this.grpLeg2.Controls.Add(this.cboPickUp2Hour);
            this.grpLeg2.Controls.Add(this.label7);
            this.grpLeg2.Controls.Add(this.cboLeg2From);
            this.grpLeg2.Controls.Add(this.label8);
            this.grpLeg2.Controls.Add(this.cboLeg2To);
            this.grpLeg2.Controls.Add(this.label9);
            this.grpLeg2.Location = new System.Drawing.Point(255, 274);
            this.grpLeg2.Name = "grpLeg2";
            this.grpLeg2.Size = new System.Drawing.Size(459, 182);
            this.grpLeg2.TabIndex = 65;
            this.grpLeg2.TabStop = false;
            this.grpLeg2.Text = "Leg 2";
            // 
            // rtbLeg2To
            // 
            this.rtbLeg2To.BackColor = System.Drawing.SystemColors.Control;
            this.rtbLeg2To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbLeg2To.ForeColor = System.Drawing.Color.Black;
            this.rtbLeg2To.Location = new System.Drawing.Point(250, 72);
            this.rtbLeg2To.Name = "rtbLeg2To";
            this.rtbLeg2To.Size = new System.Drawing.Size(166, 75);
            this.rtbLeg2To.TabIndex = 60;
            this.rtbLeg2To.Text = "";
            // 
            // rtbLeg2From
            // 
            this.rtbLeg2From.BackColor = System.Drawing.SystemColors.Control;
            this.rtbLeg2From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbLeg2From.ForeColor = System.Drawing.Color.Black;
            this.rtbLeg2From.Location = new System.Drawing.Point(50, 71);
            this.rtbLeg2From.Name = "rtbLeg2From";
            this.rtbLeg2From.Size = new System.Drawing.Size(166, 75);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(13, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "From:";
            // 
            // cboLeg2From
            // 
            this.cboLeg2From.FormattingEnabled = true;
            this.cboLeg2From.Location = new System.Drawing.Point(52, 45);
            this.cboLeg2From.Name = "cboLeg2From";
            this.cboLeg2From.Size = new System.Drawing.Size(166, 21);
            this.cboLeg2From.TabIndex = 26;
            this.cboLeg2From.SelectedIndexChanged += new System.EventHandler(this.cboLeg2From_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(30, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Pick up time:";
            // 
            // cboLeg2To
            // 
            this.cboLeg2To.FormattingEnabled = true;
            this.cboLeg2To.Location = new System.Drawing.Point(250, 45);
            this.cboLeg2To.Name = "cboLeg2To";
            this.cboLeg2To.Size = new System.Drawing.Size(166, 21);
            this.cboLeg2To.TabIndex = 27;
            this.cboLeg2To.Tag = "1";
            this.cboLeg2To.SelectedIndexChanged += new System.EventHandler(this.cboLeg2To_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(230, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "To:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(27, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Job Notes:";
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 164);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 63;
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
            this.clbAttributes.Location = new System.Drawing.Point(14, 180);
            this.clbAttributes.Margin = new System.Windows.Forms.Padding(2);
            this.clbAttributes.Name = "clbAttributes";
            this.clbAttributes.Size = new System.Drawing.Size(202, 114);
            this.clbAttributes.Sorted = true;
            this.clbAttributes.TabIndex = 62;
            this.clbAttributes.ThreeDCheckBoxes = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(21, 303);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 68;
            this.label18.Text = "Client Notes:";
            // 
            // lvNotes
            // 
            this.lvNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvNotes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Note});
            this.lvNotes.FullRowSelect = true;
            this.lvNotes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvNotes.HideSelection = false;
            this.lvNotes.Location = new System.Drawing.Point(14, 321);
            this.lvNotes.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lvNotes.Name = "lvNotes";
            this.lvNotes.ShowItemToolTips = true;
            this.lvNotes.Size = new System.Drawing.Size(203, 158);
            this.lvNotes.TabIndex = 69;
            this.lvNotes.UseCompatibleStateImageBehavior = false;
            this.lvNotes.View = System.Windows.Forms.View.Details;
            this.lvNotes.SelectedIndexChanged += new System.EventHandler(this.lvNotes_SelectedIndexChanged);
            // 
            // Note
            // 
            this.Note.Text = "Client Notes:";
            this.Note.Width = 483;
            // 
            // frmJobAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 501);
            this.Controls.Add(this.lvNotes);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.clbAttributes);
            this.Controls.Add(this.gbJobDetails);
            this.Controls.Add(this.rtbClientDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpJobDate);
            this.Controls.Add(this.cboClientName);
            this.Controls.Add(this.label17);
            this.Name = "frmJobAdd";
            this.Text = "Job Entry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmJobAdd_FormClosing);
            this.Load += new System.EventHandler(this.frmJobAdd_Load);
            this.gbJobDetails.ResumeLayout(false);
            this.gbJobDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbSource.ResumeLayout(false);
            this.gbSource.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpLeg1.ResumeLayout(false);
            this.grpLeg1.PerformLayout();
            this.grpLeg2.ResumeLayout(false);
            this.grpLeg2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboClientName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpJobDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbClientDetails;
        private System.Windows.Forms.Button btnAllocateJob;
        private System.Windows.Forms.GroupBox gbJobDetails;
        private System.Windows.Forms.ErrorProvider epTick;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckedListBox clbAttributes;
        private System.Windows.Forms.GroupBox grpLeg1;
        private System.Windows.Forms.ComboBox cboPickUp1Minute;
        private System.Windows.Forms.ComboBox cboPickUp1Hour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbLeg1To;
        private System.Windows.Forms.RichTextBox rtbLeg1From;
        private System.Windows.Forms.ComboBox cboAppt1Minute;
        private System.Windows.Forms.ComboBox cboAppt1Hour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLeg1From;
        private System.Windows.Forms.ComboBox cboLeg1To;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpLeg2;
        private System.Windows.Forms.RichTextBox rtbLeg2To;
        private System.Windows.Forms.RichTextBox rtbLeg2From;
        private System.Windows.Forms.ComboBox cboPickUp2Minute;
        private System.Windows.Forms.ComboBox cboPickUp2Hour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboLeg2From;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboLeg2To;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListView lvNotes;
        private System.Windows.Forms.ColumnHeader Note;
        private System.Windows.Forms.GroupBox gbSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radOneWay;
        private System.Windows.Forms.RadioButton radReturn;
        private System.Windows.Forms.RadioButton radSourceOther;
        private System.Windows.Forms.RadioButton radSourceDriver;
        private System.Windows.Forms.RadioButton radSourceClient;
        private System.Windows.Forms.ComboBox cboDriverLeg1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radDVCWheelchairNo;
        private System.Windows.Forms.RadioButton radDVCWheelchairYes;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Label lblSourceCheck;
        private System.Windows.Forms.RichTextBox rtbClientPhone;
        private System.Windows.Forms.Label label10;
    }
}