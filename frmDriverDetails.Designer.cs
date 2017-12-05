namespace TransManager
{
    partial class frmDriverDetails
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
            this.grpCarDetails = new System.Windows.Forms.GroupBox();
            this.lblChooser = new System.Windows.Forms.Label();
            this.pnCarDetails = new System.Windows.Forms.Panel();
            this.gbInsurance = new System.Windows.Forms.GroupBox();
            this.dtpInsExpire = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpInsStart = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPolicyHolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPolicyNo = new System.Windows.Forms.TextBox();
            this.txtInsuranceID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbCar = new System.Windows.Forms.GroupBox();
            this.txtSeats = new System.Windows.Forms.MaskedTextBox();
            this.lblSearchAddressLine1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMake = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.lblCarID = new System.Windows.Forms.Label();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radUnassign = new System.Windows.Forms.RadioButton();
            this.btnAssign = new System.Windows.Forms.Button();
            this.cboCarExisting = new System.Windows.Forms.ComboBox();
            this.lbCars = new System.Windows.Forms.ListBox();
            this.radAssign = new System.Windows.Forms.RadioButton();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.radExisting = new System.Windows.Forms.RadioButton();
            this.gbAbsence = new System.Windows.Forms.GroupBox();
            this.lvAbsence = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnAbsence = new System.Windows.Forms.Panel();
            this.mskTo = new System.Windows.Forms.MaskedTextBox();
            this.mskFrom = new System.Windows.Forms.MaskedTextBox();
            this.radAbsenceDelete = new System.Windows.Forms.RadioButton();
            this.radAbsenceUpdate = new System.Windows.Forms.RadioButton();
            this.radAbsenceAdd = new System.Windows.Forms.RadioButton();
            this.btnModify = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbExclusion = new System.Windows.Forms.GroupBox();
            this.btnClientRemove = new System.Windows.Forms.Button();
            this.radExclusionRemove = new System.Windows.Forms.RadioButton();
            this.radExclusionAdd = new System.Windows.Forms.RadioButton();
            this.lvClientExclusions = new System.Windows.Forms.ListView();
            this.ClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Reason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbExclusionAdd = new System.Windows.Forms.GroupBox();
            this.btnClientExclude = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cboClientName = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtExclusionReason = new System.Windows.Forms.TextBox();
            this.gbAttributes = new System.Windows.Forms.GroupBox();
            this.btnUpdateAttributes = new System.Windows.Forms.Button();
            this.clbAttributes = new System.Windows.Forms.CheckedListBox();
            this.lblFooter = new System.Windows.Forms.Label();
            this.grpCarDetails.SuspendLayout();
            this.pnCarDetails.SuspendLayout();
            this.gbInsurance.SuspendLayout();
            this.gbCar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbAbsence.SuspendLayout();
            this.pnAbsence.SuspendLayout();
            this.gbExclusion.SuspendLayout();
            this.gbExclusionAdd.SuspendLayout();
            this.gbAttributes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCarDetails
            // 
            this.grpCarDetails.Controls.Add(this.lblChooser);
            this.grpCarDetails.Controls.Add(this.pnCarDetails);
            this.grpCarDetails.Controls.Add(this.label11);
            this.grpCarDetails.Controls.Add(this.panel1);
            this.grpCarDetails.Location = new System.Drawing.Point(28, 12);
            this.grpCarDetails.Name = "grpCarDetails";
            this.grpCarDetails.Size = new System.Drawing.Size(422, 385);
            this.grpCarDetails.TabIndex = 5;
            this.grpCarDetails.TabStop = false;
            this.grpCarDetails.Text = "Car Details";
            // 
            // lblChooser
            // 
            this.lblChooser.AutoSize = true;
            this.lblChooser.ForeColor = System.Drawing.Color.Red;
            this.lblChooser.Location = new System.Drawing.Point(200, 16);
            this.lblChooser.Name = "lblChooser";
            this.lblChooser.Size = new System.Drawing.Size(132, 13);
            this.lblChooser.TabIndex = 24;
            this.lblChooser.Text = "Choose Vehicle to update:";
            // 
            // pnCarDetails
            // 
            this.pnCarDetails.Controls.Add(this.gbInsurance);
            this.pnCarDetails.Controls.Add(this.btnUpdate);
            this.pnCarDetails.Controls.Add(this.gbCar);
            this.pnCarDetails.Location = new System.Drawing.Point(18, 143);
            this.pnCarDetails.Name = "pnCarDetails";
            this.pnCarDetails.Size = new System.Drawing.Size(385, 242);
            this.pnCarDetails.TabIndex = 23;
            // 
            // gbInsurance
            // 
            this.gbInsurance.Controls.Add(this.dtpInsExpire);
            this.gbInsurance.Controls.Add(this.label10);
            this.gbInsurance.Controls.Add(this.dtpInsStart);
            this.gbInsurance.Controls.Add(this.label9);
            this.gbInsurance.Controls.Add(this.label8);
            this.gbInsurance.Controls.Add(this.txtCompany);
            this.gbInsurance.Controls.Add(this.label7);
            this.gbInsurance.Controls.Add(this.txtPolicyHolder);
            this.gbInsurance.Controls.Add(this.label5);
            this.gbInsurance.Controls.Add(this.txtPolicyNo);
            this.gbInsurance.Controls.Add(this.txtInsuranceID);
            this.gbInsurance.Location = new System.Drawing.Point(185, 3);
            this.gbInsurance.Name = "gbInsurance";
            this.gbInsurance.Size = new System.Drawing.Size(189, 194);
            this.gbInsurance.TabIndex = 24;
            this.gbInsurance.TabStop = false;
            this.gbInsurance.Text = "Insurance Details:";
            // 
            // dtpInsExpire
            // 
            this.dtpInsExpire.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInsExpire.Location = new System.Drawing.Point(96, 142);
            this.dtpInsExpire.Name = "dtpInsExpire";
            this.dtpInsExpire.Size = new System.Drawing.Size(88, 20);
            this.dtpInsExpire.TabIndex = 19;
            this.dtpInsExpire.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Policy Expire:";
            // 
            // dtpInsStart
            // 
            this.dtpInsStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInsStart.Location = new System.Drawing.Point(96, 113);
            this.dtpInsStart.Name = "dtpInsStart";
            this.dtpInsStart.Size = new System.Drawing.Size(88, 20);
            this.dtpInsStart.TabIndex = 18;
            this.dtpInsStart.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Policy Start:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Company:";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(96, 54);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(88, 20);
            this.txtCompany.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 87);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Policy Holder:";
            // 
            // txtPolicyHolder
            // 
            this.txtPolicyHolder.Location = new System.Drawing.Point(96, 83);
            this.txtPolicyHolder.Name = "txtPolicyHolder";
            this.txtPolicyHolder.Size = new System.Drawing.Size(88, 20);
            this.txtPolicyHolder.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 27);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Policy No:";
            // 
            // txtPolicyNo
            // 
            this.txtPolicyNo.Location = new System.Drawing.Point(96, 25);
            this.txtPolicyNo.Name = "txtPolicyNo";
            this.txtPolicyNo.Size = new System.Drawing.Size(88, 20);
            this.txtPolicyNo.TabIndex = 15;
            this.txtPolicyNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPolicyNo_KeyUp);
            // 
            // txtInsuranceID
            // 
            this.txtInsuranceID.Enabled = false;
            this.txtInsuranceID.Location = new System.Drawing.Point(114, 28);
            this.txtInsuranceID.Name = "txtInsuranceID";
            this.txtInsuranceID.Size = new System.Drawing.Size(61, 20);
            this.txtInsuranceID.TabIndex = 7;
            this.txtInsuranceID.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(197, 203);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(162, 24);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbCar
            // 
            this.gbCar.Controls.Add(this.txtSeats);
            this.gbCar.Controls.Add(this.lblSearchAddressLine1);
            this.gbCar.Controls.Add(this.label15);
            this.gbCar.Controls.Add(this.txtColour);
            this.gbCar.Controls.Add(this.label4);
            this.gbCar.Controls.Add(this.cboMake);
            this.gbCar.Controls.Add(this.cboType);
            this.gbCar.Controls.Add(this.label3);
            this.gbCar.Controls.Add(this.label2);
            this.gbCar.Controls.Add(this.txtModel);
            this.gbCar.Controls.Add(this.label1);
            this.gbCar.Controls.Add(this.txtReg);
            this.gbCar.Controls.Add(this.lblCarID);
            this.gbCar.Controls.Add(this.txtCarID);
            this.gbCar.Location = new System.Drawing.Point(9, 7);
            this.gbCar.Name = "gbCar";
            this.gbCar.Size = new System.Drawing.Size(170, 229);
            this.gbCar.TabIndex = 25;
            this.gbCar.TabStop = false;
            this.gbCar.Text = "Car Details:";
            // 
            // txtSeats
            // 
            this.txtSeats.Location = new System.Drawing.Point(75, 155);
            this.txtSeats.Margin = new System.Windows.Forms.Padding(2);
            this.txtSeats.Mask = "00";
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(89, 20);
            this.txtSeats.TabIndex = 13;
            // 
            // lblSearchAddressLine1
            // 
            this.lblSearchAddressLine1.AutoSize = true;
            this.lblSearchAddressLine1.Location = new System.Drawing.Point(13, 45);
            this.lblSearchAddressLine1.Name = "lblSearchAddressLine1";
            this.lblSearchAddressLine1.Size = new System.Drawing.Size(47, 13);
            this.lblSearchAddressLine1.TabIndex = 0;
            this.lblSearchAddressLine1.Text = "Reg No:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Colour:";
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(76, 183);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(88, 20);
            this.txtColour.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seats:";
            // 
            // cboMake
            // 
            this.cboMake.BackColor = System.Drawing.SystemColors.Window;
            this.cboMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMake.FormattingEnabled = true;
            this.cboMake.Location = new System.Drawing.Point(76, 69);
            this.cboMake.Name = "cboMake";
            this.cboMake.Size = new System.Drawing.Size(88, 21);
            this.cboMake.TabIndex = 10;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(74, 126);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(90, 21);
            this.cboType.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Model:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(76, 98);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(88, 20);
            this.txtModel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make:";
            // 
            // txtReg
            // 
            this.txtReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtReg.Location = new System.Drawing.Point(76, 41);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(88, 20);
            this.txtReg.TabIndex = 9;
            this.txtReg.TextChanged += new System.EventHandler(this.txtReg_TextChanged);
            // 
            // lblCarID
            // 
            this.lblCarID.AutoSize = true;
            this.lblCarID.Location = new System.Drawing.Point(20, 16);
            this.lblCarID.Name = "lblCarID";
            this.lblCarID.Size = new System.Drawing.Size(40, 13);
            this.lblCarID.TabIndex = 0;
            this.lblCarID.Text = "Car ID:";
            // 
            // txtCarID
            // 
            this.txtCarID.Enabled = false;
            this.txtCarID.Location = new System.Drawing.Point(76, 13);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(88, 20);
            this.txtCarID.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(18, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Choose option to update:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radUnassign);
            this.panel1.Controls.Add(this.btnAssign);
            this.panel1.Controls.Add(this.cboCarExisting);
            this.panel1.Controls.Add(this.lbCars);
            this.panel1.Controls.Add(this.radAssign);
            this.panel1.Controls.Add(this.radAdd);
            this.panel1.Controls.Add(this.radExisting);
            this.panel1.Location = new System.Drawing.Point(18, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 105);
            this.panel1.TabIndex = 22;
            // 
            // radUnassign
            // 
            this.radUnassign.AutoSize = true;
            this.radUnassign.Location = new System.Drawing.Point(12, 47);
            this.radUnassign.Name = "radUnassign";
            this.radUnassign.Size = new System.Drawing.Size(147, 17);
            this.radUnassign.TabIndex = 3;
            this.radUnassign.TabStop = true;
            this.radUnassign.Text = "Remove assigned vehicle";
            this.radUnassign.UseVisualStyleBackColor = true;
            this.radUnassign.CheckedChanged += new System.EventHandler(this.radUnassign_CheckedChanged);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(184, 43);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(125, 23);
            this.btnAssign.TabIndex = 6;
            this.btnAssign.Text = "Assign ";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Visible = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // cboCarExisting
            // 
            this.cboCarExisting.FormattingEnabled = true;
            this.cboCarExisting.Location = new System.Drawing.Point(183, 13);
            this.cboCarExisting.Name = "cboCarExisting";
            this.cboCarExisting.Size = new System.Drawing.Size(150, 21);
            this.cboCarExisting.TabIndex = 5;
            this.cboCarExisting.Visible = false;
            this.cboCarExisting.SelectedIndexChanged += new System.EventHandler(this.cboCarExisting_SelectedIndexChanged);
            // 
            // lbCars
            // 
            this.lbCars.FormattingEnabled = true;
            this.lbCars.Location = new System.Drawing.Point(184, 13);
            this.lbCars.Name = "lbCars";
            this.lbCars.Size = new System.Drawing.Size(136, 56);
            this.lbCars.TabIndex = 7;
            this.lbCars.SelectedIndexChanged += new System.EventHandler(this.lbCars_SelectedIndexChanged);
            // 
            // radAssign
            // 
            this.radAssign.AutoSize = true;
            this.radAssign.Location = new System.Drawing.Point(12, 25);
            this.radAssign.Name = "radAssign";
            this.radAssign.Size = new System.Drawing.Size(133, 17);
            this.radAssign.TabIndex = 2;
            this.radAssign.TabStop = true;
            this.radAssign.Text = "Assign Existing Vehicle";
            this.radAssign.UseVisualStyleBackColor = true;
            this.radAssign.CheckedChanged += new System.EventHandler(this.radAssign_CheckedChanged);
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Location = new System.Drawing.Point(12, 3);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(104, 17);
            this.radAdd.TabIndex = 1;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "Add new vehicle";
            this.radAdd.UseVisualStyleBackColor = true;
            this.radAdd.CheckedChanged += new System.EventHandler(this.radAdd_CheckedChanged);
            // 
            // radExisting
            // 
            this.radExisting.AutoSize = true;
            this.radExisting.Location = new System.Drawing.Point(12, 69);
            this.radExisting.Name = "radExisting";
            this.radExisting.Size = new System.Drawing.Size(142, 17);
            this.radExisting.TabIndex = 4;
            this.radExisting.TabStop = true;
            this.radExisting.Text = "Update assigned vehicle";
            this.radExisting.UseVisualStyleBackColor = true;
            this.radExisting.CheckedChanged += new System.EventHandler(this.radExisting_CheckedChanged);
            // 
            // gbAbsence
            // 
            this.gbAbsence.Controls.Add(this.lvAbsence);
            this.gbAbsence.Controls.Add(this.pnAbsence);
            this.gbAbsence.Location = new System.Drawing.Point(752, 11);
            this.gbAbsence.Name = "gbAbsence";
            this.gbAbsence.Size = new System.Drawing.Size(258, 324);
            this.gbAbsence.TabIndex = 7;
            this.gbAbsence.TabStop = false;
            this.gbAbsence.Text = "Absence Details";
            // 
            // lvAbsence
            // 
            this.lvAbsence.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAbsence.FullRowSelect = true;
            this.lvAbsence.GridLines = true;
            this.lvAbsence.HideSelection = false;
            this.lvAbsence.Location = new System.Drawing.Point(20, 24);
            this.lvAbsence.Name = "lvAbsence";
            this.lvAbsence.Size = new System.Drawing.Size(219, 97);
            this.lvAbsence.TabIndex = 0;
            this.lvAbsence.UseCompatibleStateImageBehavior = false;
            this.lvAbsence.View = System.Windows.Forms.View.Details;
            this.lvAbsence.SelectedIndexChanged += new System.EventHandler(this.lvAbsence_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date From";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date To";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Reason";
            this.columnHeader3.Width = 110;
            // 
            // pnAbsence
            // 
            this.pnAbsence.Controls.Add(this.mskTo);
            this.pnAbsence.Controls.Add(this.mskFrom);
            this.pnAbsence.Controls.Add(this.radAbsenceDelete);
            this.pnAbsence.Controls.Add(this.radAbsenceUpdate);
            this.pnAbsence.Controls.Add(this.radAbsenceAdd);
            this.pnAbsence.Controls.Add(this.btnModify);
            this.pnAbsence.Controls.Add(this.label13);
            this.pnAbsence.Controls.Add(this.txtReason);
            this.pnAbsence.Controls.Add(this.label6);
            this.pnAbsence.Controls.Add(this.label12);
            this.pnAbsence.Location = new System.Drawing.Point(20, 143);
            this.pnAbsence.Name = "pnAbsence";
            this.pnAbsence.Size = new System.Drawing.Size(220, 163);
            this.pnAbsence.TabIndex = 29;
            // 
            // mskTo
            // 
            this.mskTo.Location = new System.Drawing.Point(83, 63);
            this.mskTo.Margin = new System.Windows.Forms.Padding(2);
            this.mskTo.Mask = "00/00/0000";
            this.mskTo.Name = "mskTo";
            this.mskTo.Size = new System.Drawing.Size(76, 20);
            this.mskTo.TabIndex = 32;
            this.mskTo.ValidatingType = typeof(System.DateTime);
            // 
            // mskFrom
            // 
            this.mskFrom.Location = new System.Drawing.Point(83, 38);
            this.mskFrom.Margin = new System.Windows.Forms.Padding(2);
            this.mskFrom.Mask = "00/00/0000";
            this.mskFrom.Name = "mskFrom";
            this.mskFrom.Size = new System.Drawing.Size(76, 20);
            this.mskFrom.TabIndex = 30;
            this.mskFrom.ValidatingType = typeof(System.DateTime);
            // 
            // radAbsenceDelete
            // 
            this.radAbsenceDelete.AutoSize = true;
            this.radAbsenceDelete.Location = new System.Drawing.Point(142, 12);
            this.radAbsenceDelete.Name = "radAbsenceDelete";
            this.radAbsenceDelete.Size = new System.Drawing.Size(56, 17);
            this.radAbsenceDelete.TabIndex = 31;
            this.radAbsenceDelete.Text = "Delete";
            this.radAbsenceDelete.UseVisualStyleBackColor = true;
            this.radAbsenceDelete.CheckedChanged += new System.EventHandler(this.radAbsenceDelete_CheckedChanged);
            // 
            // radAbsenceUpdate
            // 
            this.radAbsenceUpdate.AutoSize = true;
            this.radAbsenceUpdate.Location = new System.Drawing.Point(83, 12);
            this.radAbsenceUpdate.Name = "radAbsenceUpdate";
            this.radAbsenceUpdate.Size = new System.Drawing.Size(60, 17);
            this.radAbsenceUpdate.TabIndex = 30;
            this.radAbsenceUpdate.Text = "Update";
            this.radAbsenceUpdate.UseVisualStyleBackColor = true;
            this.radAbsenceUpdate.CheckedChanged += new System.EventHandler(this.radAbsenceUpdate_CheckedChanged);
            // 
            // radAbsenceAdd
            // 
            this.radAbsenceAdd.AutoSize = true;
            this.radAbsenceAdd.Checked = true;
            this.radAbsenceAdd.Location = new System.Drawing.Point(28, 12);
            this.radAbsenceAdd.Name = "radAbsenceAdd";
            this.radAbsenceAdd.Size = new System.Drawing.Size(44, 17);
            this.radAbsenceAdd.TabIndex = 29;
            this.radAbsenceAdd.TabStop = true;
            this.radAbsenceAdd.Text = "Add";
            this.radAbsenceAdd.UseVisualStyleBackColor = true;
            this.radAbsenceAdd.CheckedChanged += new System.EventHandler(this.radAbsenceAdd_CheckedChanged);
            // 
            // btnModify
            // 
            this.btnModify.Enabled = false;
            this.btnModify.Location = new System.Drawing.Point(69, 115);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(82, 27);
            this.btnModify.TabIndex = 28;
            this.btnModify.Text = "Add";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Reason:";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(83, 89);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(119, 20);
            this.txtReason.TabIndex = 27;
            this.txtReason.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Date To:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Date From:";
            // 
            // gbExclusion
            // 
            this.gbExclusion.Controls.Add(this.btnClientRemove);
            this.gbExclusion.Controls.Add(this.radExclusionRemove);
            this.gbExclusion.Controls.Add(this.radExclusionAdd);
            this.gbExclusion.Controls.Add(this.lvClientExclusions);
            this.gbExclusion.Controls.Add(this.gbExclusionAdd);
            this.gbExclusion.Location = new System.Drawing.Point(468, 12);
            this.gbExclusion.Name = "gbExclusion";
            this.gbExclusion.Size = new System.Drawing.Size(278, 298);
            this.gbExclusion.TabIndex = 6;
            this.gbExclusion.TabStop = false;
            this.gbExclusion.Text = "Client Exclusions:";
            this.gbExclusion.Enter += new System.EventHandler(this.gbAttributes_Enter);
            // 
            // btnClientRemove
            // 
            this.btnClientRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClientRemove.Location = new System.Drawing.Point(80, 123);
            this.btnClientRemove.Name = "btnClientRemove";
            this.btnClientRemove.Size = new System.Drawing.Size(132, 23);
            this.btnClientRemove.TabIndex = 25;
            this.btnClientRemove.Text = "Remove";
            this.btnClientRemove.UseVisualStyleBackColor = true;
            this.btnClientRemove.Visible = false;
            this.btnClientRemove.Click += new System.EventHandler(this.btnClientRemove_Click);
            // 
            // radExclusionRemove
            // 
            this.radExclusionRemove.AutoSize = true;
            this.radExclusionRemove.Location = new System.Drawing.Point(162, 99);
            this.radExclusionRemove.Name = "radExclusionRemove";
            this.radExclusionRemove.Size = new System.Drawing.Size(65, 17);
            this.radExclusionRemove.TabIndex = 24;
            this.radExclusionRemove.Text = "Remove";
            this.radExclusionRemove.UseVisualStyleBackColor = true;
            this.radExclusionRemove.CheckedChanged += new System.EventHandler(this.radExclusionRemove_CheckedChanged);
            // 
            // radExclusionAdd
            // 
            this.radExclusionAdd.AutoSize = true;
            this.radExclusionAdd.Checked = true;
            this.radExclusionAdd.Location = new System.Drawing.Point(80, 100);
            this.radExclusionAdd.Name = "radExclusionAdd";
            this.radExclusionAdd.Size = new System.Drawing.Size(44, 17);
            this.radExclusionAdd.TabIndex = 23;
            this.radExclusionAdd.TabStop = true;
            this.radExclusionAdd.Text = "Add";
            this.radExclusionAdd.UseVisualStyleBackColor = true;
            this.radExclusionAdd.CheckedChanged += new System.EventHandler(this.radExclusionAdd_CheckedChanged);
            // 
            // lvClientExclusions
            // 
            this.lvClientExclusions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClientName,
            this.Reason});
            this.lvClientExclusions.Enabled = false;
            this.lvClientExclusions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvClientExclusions.FullRowSelect = true;
            this.lvClientExclusions.GridLines = true;
            this.lvClientExclusions.Location = new System.Drawing.Point(20, 24);
            this.lvClientExclusions.MultiSelect = false;
            this.lvClientExclusions.Name = "lvClientExclusions";
            this.lvClientExclusions.Size = new System.Drawing.Size(246, 66);
            this.lvClientExclusions.TabIndex = 22;
            this.lvClientExclusions.UseCompatibleStateImageBehavior = false;
            this.lvClientExclusions.View = System.Windows.Forms.View.Details;
            this.lvClientExclusions.SelectedIndexChanged += new System.EventHandler(this.lvClientExclusions_SelectedIndexChanged);
            // 
            // ClientName
            // 
            this.ClientName.Text = "Client Name";
            this.ClientName.Width = 100;
            // 
            // Reason
            // 
            this.Reason.Text = "Exclusion Reason";
            this.Reason.Width = 114;
            // 
            // gbExclusionAdd
            // 
            this.gbExclusionAdd.Controls.Add(this.btnClientExclude);
            this.gbExclusionAdd.Controls.Add(this.label16);
            this.gbExclusionAdd.Controls.Add(this.cboClientName);
            this.gbExclusionAdd.Controls.Add(this.label17);
            this.gbExclusionAdd.Controls.Add(this.txtExclusionReason);
            this.gbExclusionAdd.ForeColor = System.Drawing.Color.Red;
            this.gbExclusionAdd.Location = new System.Drawing.Point(20, 151);
            this.gbExclusionAdd.Name = "gbExclusionAdd";
            this.gbExclusionAdd.Size = new System.Drawing.Size(246, 133);
            this.gbExclusionAdd.TabIndex = 26;
            this.gbExclusionAdd.TabStop = false;
            this.gbExclusionAdd.Text = "Exclude client from this driver";
            // 
            // btnClientExclude
            // 
            this.btnClientExclude.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClientExclude.Location = new System.Drawing.Point(83, 95);
            this.btnClientExclude.Name = "btnClientExclude";
            this.btnClientExclude.Size = new System.Drawing.Size(132, 23);
            this.btnClientExclude.TabIndex = 26;
            this.btnClientExclude.Text = "Add to exclusions";
            this.btnClientExclude.UseVisualStyleBackColor = true;
            this.btnClientExclude.Click += new System.EventHandler(this.btnClientExclude_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(26, 57);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Reason:";
            // 
            // cboClientName
            // 
            this.cboClientName.FormattingEnabled = true;
            this.cboClientName.Location = new System.Drawing.Point(83, 23);
            this.cboClientName.Name = "cboClientName";
            this.cboClientName.Size = new System.Drawing.Size(132, 21);
            this.cboClientName.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(6, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Client Name:";
            // 
            // txtExclusionReason
            // 
            this.txtExclusionReason.Location = new System.Drawing.Point(83, 57);
            this.txtExclusionReason.Name = "txtExclusionReason";
            this.txtExclusionReason.Size = new System.Drawing.Size(132, 20);
            this.txtExclusionReason.TabIndex = 25;
            // 
            // gbAttributes
            // 
            this.gbAttributes.Controls.Add(this.btnUpdateAttributes);
            this.gbAttributes.Controls.Add(this.clbAttributes);
            this.gbAttributes.Location = new System.Drawing.Point(468, 316);
            this.gbAttributes.Margin = new System.Windows.Forms.Padding(2);
            this.gbAttributes.Name = "gbAttributes";
            this.gbAttributes.Padding = new System.Windows.Forms.Padding(2);
            this.gbAttributes.Size = new System.Drawing.Size(279, 132);
            this.gbAttributes.TabIndex = 27;
            this.gbAttributes.TabStop = false;
            this.gbAttributes.Text = "Additional Driver Attributes:";
            // 
            // btnUpdateAttributes
            // 
            this.btnUpdateAttributes.Enabled = false;
            this.btnUpdateAttributes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateAttributes.Location = new System.Drawing.Point(170, 46);
            this.btnUpdateAttributes.Name = "btnUpdateAttributes";
            this.btnUpdateAttributes.Size = new System.Drawing.Size(83, 37);
            this.btnUpdateAttributes.TabIndex = 27;
            this.btnUpdateAttributes.Text = "Update attributes";
            this.btnUpdateAttributes.UseVisualStyleBackColor = true;
            this.btnUpdateAttributes.Click += new System.EventHandler(this.btnUpdateAttributes_Click);
            // 
            // clbAttributes
            // 
            this.clbAttributes.CheckOnClick = true;
            this.clbAttributes.FormattingEnabled = true;
            this.clbAttributes.Location = new System.Drawing.Point(20, 17);
            this.clbAttributes.Margin = new System.Windows.Forms.Padding(2);
            this.clbAttributes.Name = "clbAttributes";
            this.clbAttributes.Size = new System.Drawing.Size(128, 94);
            this.clbAttributes.TabIndex = 1;
            this.clbAttributes.ThreeDCheckBoxes = true;
            this.clbAttributes.Click += new System.EventHandler(this.clbAttributes_Click);
            this.clbAttributes.SelectedIndexChanged += new System.EventHandler(this.clbAttributes_SelectedIndexChanged);
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.Color.Red;
            this.lblFooter.Location = new System.Drawing.Point(25, 421);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(61, 16);
            this.lblFooter.TabIndex = 28;
            this.lblFooter.Text = "lblFooter";
            // 
            // frmDriverDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 459);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.gbAttributes);
            this.Controls.Add(this.gbExclusion);
            this.Controls.Add(this.gbAbsence);
            this.Controls.Add(this.grpCarDetails);
            this.Name = "frmDriverDetails";
            this.Text = "Driver Details";
            this.Load += new System.EventHandler(this.frmDriverDetails_Load);
            this.grpCarDetails.ResumeLayout(false);
            this.grpCarDetails.PerformLayout();
            this.pnCarDetails.ResumeLayout(false);
            this.gbInsurance.ResumeLayout(false);
            this.gbInsurance.PerformLayout();
            this.gbCar.ResumeLayout(false);
            this.gbCar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbAbsence.ResumeLayout(false);
            this.pnAbsence.ResumeLayout(false);
            this.pnAbsence.PerformLayout();
            this.gbExclusion.ResumeLayout(false);
            this.gbExclusion.PerformLayout();
            this.gbExclusionAdd.ResumeLayout(false);
            this.gbExclusionAdd.PerformLayout();
            this.gbAttributes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCarDetails;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblSearchAddressLine1;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.Label lblCarID;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMake;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPolicyHolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPolicyNo;
        private System.Windows.Forms.TextBox txtInsuranceID;
        private System.Windows.Forms.DateTimePicker dtpInsExpire;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpInsStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.RadioButton radExisting;
        private System.Windows.Forms.RadioButton radAssign;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbCars;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.ComboBox cboCarExisting;
        private System.Windows.Forms.Panel pnCarDetails;
        private System.Windows.Forms.Label lblChooser;
        private System.Windows.Forms.GroupBox gbAbsence;
        private System.Windows.Forms.RadioButton radUnassign;
        private System.Windows.Forms.ListView lvAbsence;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Panel pnAbsence;
        private System.Windows.Forms.RadioButton radAbsenceAdd;
        private System.Windows.Forms.RadioButton radAbsenceDelete;
        private System.Windows.Forms.RadioButton radAbsenceUpdate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.MaskedTextBox txtSeats;
        private System.Windows.Forms.GroupBox gbExclusion;
        private System.Windows.Forms.Button btnClientRemove;
        private System.Windows.Forms.RadioButton radExclusionRemove;
        private System.Windows.Forms.RadioButton radExclusionAdd;
        private System.Windows.Forms.ListView lvClientExclusions;
        private System.Windows.Forms.ColumnHeader ClientName;
        private System.Windows.Forms.ColumnHeader Reason;
        private System.Windows.Forms.GroupBox gbExclusionAdd;
        private System.Windows.Forms.Button btnClientExclude;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboClientName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtExclusionReason;
        private System.Windows.Forms.MaskedTextBox mskFrom;
        private System.Windows.Forms.MaskedTextBox mskTo;
        private System.Windows.Forms.GroupBox gbAttributes;
        private System.Windows.Forms.CheckedListBox clbAttributes;
        private System.Windows.Forms.Button btnUpdateAttributes;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.GroupBox gbInsurance;
        private System.Windows.Forms.GroupBox gbCar;
    }
}