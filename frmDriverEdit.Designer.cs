using System.Configuration;
namespace TransManager
{
    partial class frmDriverEdit
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.DriverID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Initial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressLine1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressLine2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Town = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Postcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearchSurname = new System.Windows.Forms.TextBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.cboCarMake = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSearchTown = new System.Windows.Forms.Label();
            this.txtSearchTown = new System.Windows.Forms.TextBox();
            this.lblSearchAddressLine1 = new System.Windows.Forms.Label();
            this.txtSearchAddressLine1 = new System.Windows.Forms.TextBox();
            this.gbActive = new System.Windows.Forms.GroupBox();
            this.radActiveAll = new System.Windows.Forms.RadioButton();
            this.radActiveTrue = new System.Windows.Forms.RadioButton();
            this.radActiveFalse = new System.Windows.Forms.RadioButton();
            this.lblSearchSurname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbEditControls = new System.Windows.Forms.GroupBox();
            this.dtpLicenceExpiry = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.txtLicenceNo = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.chkSession14 = new System.Windows.Forms.CheckBox();
            this.label30 = new System.Windows.Forms.Label();
            this.chkSession13 = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.chkSession12 = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.chkSession11 = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.chkSession10 = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.chkSession9 = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.chkSession8 = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.chkSession7 = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.chkSession6 = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.chkSession5 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.chkSession4 = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.chkSession3 = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.chkSession2 = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chkSession1 = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnDriver = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radActiveYes = new System.Windows.Forms.RadioButton();
            this.radActiveNo = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.mskPostCode = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDriverID = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.grpSearch.SuspendLayout();
            this.gbActive.SuspendLayout();
            this.gbEditControls.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DriverID,
            this.title,
            this.FirstName,
            this.Initial,
            this.AddressLine1,
            this.AddressLine2,
            this.Town,
            this.Postcode});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 321);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(847, 258);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // DriverID
            // 
            this.DriverID.Text = "DriverID";
            this.DriverID.Width = 67;
            // 
            // title
            // 
            this.title.Text = "title";
            this.title.Width = 64;
            // 
            // FirstName
            // 
            this.FirstName.Text = "firstname";
            this.FirstName.Width = 86;
            // 
            // Initial
            // 
            this.Initial.Text = "surname";
            this.Initial.Width = 107;
            // 
            // AddressLine1
            // 
            this.AddressLine1.Text = "AddressLine1";
            this.AddressLine1.Width = 188;
            // 
            // AddressLine2
            // 
            this.AddressLine2.Text = "AddressLine2";
            this.AddressLine2.Width = 100;
            // 
            // Town
            // 
            this.Town.Text = "Town";
            this.Town.Width = 220;
            // 
            // Postcode
            // 
            this.Postcode.Text = "Postcode";
            this.Postcode.Width = 109;
            // 
            // txtSearchSurname
            // 
            this.txtSearchSurname.Location = new System.Drawing.Point(6, 36);
            this.txtSearchSurname.Name = "txtSearchSurname";
            this.txtSearchSurname.Size = new System.Drawing.Size(88, 20);
            this.txtSearchSurname.TabIndex = 1;
            this.txtSearchSurname.TextChanged += new System.EventHandler(this.txtSearchSurname_TextChanged);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.cboCarMake);
            this.grpSearch.Controls.Add(this.label38);
            this.grpSearch.Controls.Add(this.btnClear);
            this.grpSearch.Controls.Add(this.lblSearchTown);
            this.grpSearch.Controls.Add(this.txtSearchTown);
            this.grpSearch.Controls.Add(this.lblSearchAddressLine1);
            this.grpSearch.Controls.Add(this.txtSearchAddressLine1);
            this.grpSearch.Controls.Add(this.gbActive);
            this.grpSearch.Controls.Add(this.lblSearchSurname);
            this.grpSearch.Controls.Add(this.txtSearchSurname);
            this.grpSearch.Location = new System.Drawing.Point(12, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(281, 237);
            this.grpSearch.TabIndex = 4;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Filters";
            // 
            // cboCarMake
            // 
            this.cboCarMake.FormattingEnabled = true;
            this.cboCarMake.Location = new System.Drawing.Point(9, 179);
            this.cboCarMake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCarMake.Name = "cboCarMake";
            this.cboCarMake.Size = new System.Drawing.Size(107, 21);
            this.cboCarMake.TabIndex = 85;
            this.cboCarMake.Visible = false;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 165);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(92, 13);
            this.label38.TabIndex = 5;
            this.label38.Text = "filter by Car Make:";
            this.label38.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(135, 116);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 33);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear all filters";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSearchTown
            // 
            this.lblSearchTown.AutoSize = true;
            this.lblSearchTown.Location = new System.Drawing.Point(6, 112);
            this.lblSearchTown.Name = "lblSearchTown";
            this.lblSearchTown.Size = new System.Drawing.Size(73, 13);
            this.lblSearchTown.TabIndex = 0;
            this.lblSearchTown.Text = "filter by Town:";
            // 
            // txtSearchTown
            // 
            this.txtSearchTown.Location = new System.Drawing.Point(6, 128);
            this.txtSearchTown.Name = "txtSearchTown";
            this.txtSearchTown.Size = new System.Drawing.Size(88, 20);
            this.txtSearchTown.TabIndex = 3;
            this.txtSearchTown.TextChanged += new System.EventHandler(this.txtSearchTown_TextChanged);
            // 
            // lblSearchAddressLine1
            // 
            this.lblSearchAddressLine1.AutoSize = true;
            this.lblSearchAddressLine1.Location = new System.Drawing.Point(6, 65);
            this.lblSearchAddressLine1.Name = "lblSearchAddressLine1";
            this.lblSearchAddressLine1.Size = new System.Drawing.Size(110, 13);
            this.lblSearchAddressLine1.TabIndex = 0;
            this.lblSearchAddressLine1.Text = "filter by AddressLine1:";
            // 
            // txtSearchAddressLine1
            // 
            this.txtSearchAddressLine1.Location = new System.Drawing.Point(6, 81);
            this.txtSearchAddressLine1.Name = "txtSearchAddressLine1";
            this.txtSearchAddressLine1.Size = new System.Drawing.Size(88, 20);
            this.txtSearchAddressLine1.TabIndex = 2;
            this.txtSearchAddressLine1.TextChanged += new System.EventHandler(this.txtSearchAddressLine1_TextChanged);
            // 
            // gbActive
            // 
            this.gbActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbActive.Controls.Add(this.radActiveAll);
            this.gbActive.Controls.Add(this.radActiveTrue);
            this.gbActive.Controls.Add(this.radActiveFalse);
            this.gbActive.Location = new System.Drawing.Point(135, 19);
            this.gbActive.Name = "gbActive";
            this.gbActive.Size = new System.Drawing.Size(124, 90);
            this.gbActive.TabIndex = 0;
            this.gbActive.TabStop = false;
            this.gbActive.Text = "Active/Inactive:";
            // 
            // radActiveAll
            // 
            this.radActiveAll.AutoSize = true;
            this.radActiveAll.Location = new System.Drawing.Point(8, 67);
            this.radActiveAll.Name = "radActiveAll";
            this.radActiveAll.Size = new System.Drawing.Size(36, 17);
            this.radActiveAll.TabIndex = 0;
            this.radActiveAll.Text = "All";
            this.radActiveAll.UseVisualStyleBackColor = true;
            this.radActiveAll.CheckedChanged += new System.EventHandler(this.radActiveAll_CheckedChanged);
            // 
            // radActiveTrue
            // 
            this.radActiveTrue.AutoSize = true;
            this.radActiveTrue.Checked = true;
            this.radActiveTrue.Location = new System.Drawing.Point(8, 19);
            this.radActiveTrue.Name = "radActiveTrue";
            this.radActiveTrue.Size = new System.Drawing.Size(91, 17);
            this.radActiveTrue.TabIndex = 0;
            this.radActiveTrue.TabStop = true;
            this.radActiveTrue.Text = "Active Drivers";
            this.radActiveTrue.UseVisualStyleBackColor = true;
            this.radActiveTrue.CheckedChanged += new System.EventHandler(this.radActiveTrue_CheckedChanged);
            // 
            // radActiveFalse
            // 
            this.radActiveFalse.AutoSize = true;
            this.radActiveFalse.Location = new System.Drawing.Point(8, 42);
            this.radActiveFalse.Name = "radActiveFalse";
            this.radActiveFalse.Size = new System.Drawing.Size(99, 17);
            this.radActiveFalse.TabIndex = 0;
            this.radActiveFalse.Text = "Inactive Drivers";
            this.radActiveFalse.UseVisualStyleBackColor = true;
            this.radActiveFalse.CheckedChanged += new System.EventHandler(this.radActiveFalse_CheckedChanged);
            // 
            // lblSearchSurname
            // 
            this.lblSearchSurname.AutoSize = true;
            this.lblSearchSurname.Location = new System.Drawing.Point(6, 20);
            this.lblSearchSurname.Name = "lblSearchSurname";
            this.lblSearchSurname.Size = new System.Drawing.Size(88, 13);
            this.lblSearchSurname.TabIndex = 0;
            this.lblSearchSurname.Text = "filter by Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // gbEditControls
            // 
            this.gbEditControls.Controls.Add(this.dtpLicenceExpiry);
            this.gbEditControls.Controls.Add(this.label14);
            this.gbEditControls.Controls.Add(this.label39);
            this.gbEditControls.Controls.Add(this.txtLicenceNo);
            this.gbEditControls.Controls.Add(this.label37);
            this.gbEditControls.Controls.Add(this.label36);
            this.gbEditControls.Controls.Add(this.label35);
            this.gbEditControls.Controls.Add(this.label34);
            this.gbEditControls.Controls.Add(this.label33);
            this.gbEditControls.Controls.Add(this.label32);
            this.gbEditControls.Controls.Add(this.label31);
            this.gbEditControls.Controls.Add(this.label29);
            this.gbEditControls.Controls.Add(this.chkSession14);
            this.gbEditControls.Controls.Add(this.label30);
            this.gbEditControls.Controls.Add(this.chkSession13);
            this.gbEditControls.Controls.Add(this.label27);
            this.gbEditControls.Controls.Add(this.chkSession12);
            this.gbEditControls.Controls.Add(this.label28);
            this.gbEditControls.Controls.Add(this.chkSession11);
            this.gbEditControls.Controls.Add(this.label25);
            this.gbEditControls.Controls.Add(this.chkSession10);
            this.gbEditControls.Controls.Add(this.label26);
            this.gbEditControls.Controls.Add(this.chkSession9);
            this.gbEditControls.Controls.Add(this.label23);
            this.gbEditControls.Controls.Add(this.chkSession8);
            this.gbEditControls.Controls.Add(this.label24);
            this.gbEditControls.Controls.Add(this.chkSession7);
            this.gbEditControls.Controls.Add(this.label21);
            this.gbEditControls.Controls.Add(this.chkSession6);
            this.gbEditControls.Controls.Add(this.label22);
            this.gbEditControls.Controls.Add(this.chkSession5);
            this.gbEditControls.Controls.Add(this.label19);
            this.gbEditControls.Controls.Add(this.chkSession4);
            this.gbEditControls.Controls.Add(this.label20);
            this.gbEditControls.Controls.Add(this.chkSession3);
            this.gbEditControls.Controls.Add(this.label18);
            this.gbEditControls.Controls.Add(this.chkSession2);
            this.gbEditControls.Controls.Add(this.label17);
            this.gbEditControls.Controls.Add(this.chkSession1);
            this.gbEditControls.Controls.Add(this.label16);
            this.gbEditControls.Controls.Add(this.btnDriver);
            this.gbEditControls.Controls.Add(this.panel2);
            this.gbEditControls.Controls.Add(this.label15);
            this.gbEditControls.Controls.Add(this.cboTitle);
            this.gbEditControls.Controls.Add(this.btnNotes);
            this.gbEditControls.Controls.Add(this.btnUpdate);
            this.gbEditControls.Controls.Add(this.mskPostCode);
            this.gbEditControls.Controls.Add(this.label13);
            this.gbEditControls.Controls.Add(this.txtDriverID);
            this.gbEditControls.Controls.Add(this.dtpDOB);
            this.gbEditControls.Controls.Add(this.label9);
            this.gbEditControls.Controls.Add(this.label10);
            this.gbEditControls.Controls.Add(this.txtHomePhone);
            this.gbEditControls.Controls.Add(this.label11);
            this.gbEditControls.Controls.Add(this.txtMobilePhone);
            this.gbEditControls.Controls.Add(this.label12);
            this.gbEditControls.Controls.Add(this.txtEmail);
            this.gbEditControls.Controls.Add(this.label8);
            this.gbEditControls.Controls.Add(this.txtSurname);
            this.gbEditControls.Controls.Add(this.label2);
            this.gbEditControls.Controls.Add(this.txtTown);
            this.gbEditControls.Controls.Add(this.label3);
            this.gbEditControls.Controls.Add(this.label7);
            this.gbEditControls.Controls.Add(this.txtFirstName);
            this.gbEditControls.Controls.Add(this.label5);
            this.gbEditControls.Controls.Add(this.txtAddressLine1);
            this.gbEditControls.Controls.Add(this.label4);
            this.gbEditControls.Controls.Add(this.txtAddressLine2);
            this.gbEditControls.Controls.Add(this.label1);
            this.gbEditControls.Location = new System.Drawing.Point(315, 12);
            this.gbEditControls.Name = "gbEditControls";
            this.gbEditControls.Size = new System.Drawing.Size(519, 303);
            this.gbEditControls.TabIndex = 0;
            this.gbEditControls.TabStop = false;
            this.gbEditControls.Text = "Edit Driver:";
            this.gbEditControls.Enter += new System.EventHandler(this.gbEditControls_Enter);
            // 
            // dtpLicenceExpiry
            // 
            this.dtpLicenceExpiry.Location = new System.Drawing.Point(377, 153);
            this.dtpLicenceExpiry.Name = "dtpLicenceExpiry";
            this.dtpLicenceExpiry.Size = new System.Drawing.Size(119, 20);
            this.dtpLicenceExpiry.TabIndex = 21;
            this.dtpLicenceExpiry.Value = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.dtpLicenceExpiry.ValueChanged += new System.EventHandler(this.dtpLicenceExpiry_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(281, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 86;
            this.label14.Text = "Licence Expiry";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(281, 131);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(62, 13);
            this.label39.TabIndex = 85;
            this.label39.Text = "Licence No";
            // 
            // txtLicenceNo
            // 
            this.txtLicenceNo.Location = new System.Drawing.Point(377, 130);
            this.txtLicenceNo.Name = "txtLicenceNo";
            this.txtLicenceNo.Size = new System.Drawing.Size(101, 20);
            this.txtLicenceNo.TabIndex = 20;
            this.txtLicenceNo.TextChanged += new System.EventHandler(this.txtLicenceNo_TextChanged);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(429, 211);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(26, 13);
            this.label37.TabIndex = 84;
            this.label37.Text = "Sun";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(377, 211);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(23, 13);
            this.label36.TabIndex = 83;
            this.label36.Text = "Sat";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(330, 211);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(18, 13);
            this.label35.TabIndex = 82;
            this.label35.Text = "Fri";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(275, 211);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(26, 13);
            this.label34.TabIndex = 81;
            this.label34.Text = "Thu";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(216, 211);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(30, 13);
            this.label33.TabIndex = 80;
            this.label33.Text = "Wed";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(161, 211);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(26, 13);
            this.label32.TabIndex = 79;
            this.label32.Text = "Tue";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(104, 211);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(28, 13);
            this.label31.TabIndex = 78;
            this.label31.Text = "Mon";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(445, 224);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(27, 13);
            this.label29.TabIndex = 77;
            this.label29.Text = "p.m.";
            // 
            // chkSession14
            // 
            this.chkSession14.AutoSize = true;
            this.chkSession14.Checked = true;
            this.chkSession14.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSession14.Location = new System.Drawing.Point(449, 240);
            this.chkSession14.Name = "chkSession14";
            this.chkSession14.Size = new System.Drawing.Size(15, 14);
            this.chkSession14.TabIndex = 76;
            this.chkSession14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkSession14.UseVisualStyleBackColor = true;
            this.chkSession14.CheckedChanged += new System.EventHandler(this.chkSession14_CheckedChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(418, 224);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(27, 13);
            this.label30.TabIndex = 75;
            this.label30.Text = "a.m.";
            // 
            // chkSession13
            // 
            this.chkSession13.AutoSize = true;
            this.chkSession13.Checked = true;
            this.chkSession13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSession13.Location = new System.Drawing.Point(422, 240);
            this.chkSession13.Name = "chkSession13";
            this.chkSession13.Size = new System.Drawing.Size(15, 14);
            this.chkSession13.TabIndex = 74;
            this.chkSession13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkSession13.UseVisualStyleBackColor = true;
            this.chkSession13.CheckedChanged += new System.EventHandler(this.chkSession13_CheckedChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(391, 224);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(27, 13);
            this.label27.TabIndex = 73;
            this.label27.Text = "p.m.";
            // 
            // chkSession12
            // 
            this.chkSession12.AutoSize = true;
            this.chkSession12.Checked = true;
            this.chkSession12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSession12.Location = new System.Drawing.Point(395, 240);
            this.chkSession12.Name = "chkSession12";
            this.chkSession12.Size = new System.Drawing.Size(15, 14);
            this.chkSession12.TabIndex = 72;
            this.chkSession12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkSession12.UseVisualStyleBackColor = true;
            this.chkSession12.CheckedChanged += new System.EventHandler(this.chkSession12_CheckedChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(364, 224);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(27, 13);
            this.label28.TabIndex = 71;
            this.label28.Text = "a.m.";
            // 
            // chkSession11
            // 
            this.chkSession11.AutoSize = true;
            this.chkSession11.Checked = true;
            this.chkSession11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSession11.Location = new System.Drawing.Point(368, 240);
            this.chkSession11.Name = "chkSession11";
            this.chkSession11.Size = new System.Drawing.Size(15, 14);
            this.chkSession11.TabIndex = 70;
            this.chkSession11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkSession11.UseVisualStyleBackColor = true;
            this.chkSession11.CheckedChanged += new System.EventHandler(this.chkSession11_CheckedChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(337, 224);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(27, 13);
            this.label25.TabIndex = 69;
            this.label25.Text = "p.m.";
            // 
            // chkSession10
            // 
            this.chkSession10.AutoSize = true;
            this.chkSession10.Checked = true;
            this.chkSession10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSession10.Location = new System.Drawing.Point(341, 240);
            this.chkSession10.Name = "chkSession10";
            this.chkSession10.Size = new System.Drawing.Size(15, 14);
            this.chkSession10.TabIndex = 68;
            this.chkSession10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkSession10.UseVisualStyleBackColor = true;
            this.chkSession10.CheckedChanged += new System.EventHandler(this.chkSession10_CheckedChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(310, 224);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(27, 13);
            this.label26.TabIndex = 67;
            this.label26.Text = "a.m.";
            // 
            // chkSession9
            // 
            this.chkSession9.AutoSize = true;
            this.chkSession9.Checked = true;
            this.chkSession9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSession9.Location = new System.Drawing.Point(314, 240);
            this.chkSession9.Name = "chkSession9";
            this.chkSession9.Size = new System.Drawing.Size(15, 14);
            this.chkSession9.TabIndex = 66;
            this.chkSession9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkSession9.UseVisualStyleBackColor = true;
            this.chkSession9.CheckedChanged += new System.EventHandler(this.chkSession9_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(283, 224);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(27, 13);
            this.label23.TabIndex = 65;
            this.label23.Text = "p.m.";
            // 
            // chkSession8
            // 
            this.chkSession8.AutoSize = true;
            this.chkSession8.Checked = true;
            this.chkSession8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSession8.Location = new System.Drawing.Point(287, 240);
            this.chkSession8.Name = "chkSession8";
            this.chkSession8.Size = new System.Drawing.Size(15, 14);
            this.chkSession8.TabIndex = 64;
            this.chkSession8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkSession8.UseVisualStyleBackColor = true;
            this.chkSession8.CheckedChanged += new System.EventHandler(this.chkSession8_CheckedChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(256, 224);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(27, 13);
            this.label24.TabIndex = 63;
            this.label24.Text = "a.m.";
            // 
            // chkSession7
            // 
            this.chkSession7.AutoSize = true;
            this.chkSession7.Checked = true;
            this.chkSession7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSession7.Location = new System.Drawing.Point(260, 240);
            this.chkSession7.Name = "chkSession7";
            this.chkSession7.Size = new System.Drawing.Size(15, 14);
            this.chkSession7.TabIndex = 62;
            this.chkSession7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkSession7.UseVisualStyleBackColor = true;
            this.chkSession7.CheckedChanged += new System.EventHandler(this.chkSession7_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(229, 224);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 61;
            this.label21.Text = "p.m.";
            // 
            // chkSession6
            // 
            this.chkSession6.AutoSize = true;
            this.chkSession6.Checked = true;
            this.chkSession6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSession6.Location = new System.Drawing.Point(233, 240);
            this.chkSession6.Name = "chkSession6";
            this.chkSession6.Size = new System.Drawing.Size(15, 14);
            this.chkSession6.TabIndex = 60;
            this.chkSession6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkSession6.UseVisualStyleBackColor = true;
            this.chkSession6.CheckedChanged += new System.EventHandler(this.chkSession6_CheckedChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(202, 224);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(27, 13);
            this.label22.TabIndex = 59;
            this.label22.Text = "a.m.";
            // 
            // chkSession5
            // 
            this.chkSession5.AutoSize = true;
            this.chkSession5.Checked = true;
            this.chkSession5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSession5.Location = new System.Drawing.Point(206, 240);
            this.chkSession5.Name = "chkSession5";
            this.chkSession5.Size = new System.Drawing.Size(15, 14);
            this.chkSession5.TabIndex = 58;
            this.chkSession5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkSession5.UseVisualStyleBackColor = true;
            this.chkSession5.CheckedChanged += new System.EventHandler(this.chkSession5_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(175, 224);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 57;
            this.label19.Text = "p.m.";
            // 
            // chkSession4
            // 
            this.chkSession4.AutoSize = true;
            this.chkSession4.Checked = true;
            this.chkSession4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSession4.Location = new System.Drawing.Point(179, 240);
            this.chkSession4.Name = "chkSession4";
            this.chkSession4.Size = new System.Drawing.Size(15, 14);
            this.chkSession4.TabIndex = 56;
            this.chkSession4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkSession4.UseVisualStyleBackColor = true;
            this.chkSession4.CheckedChanged += new System.EventHandler(this.chkSession4_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(148, 224);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 13);
            this.label20.TabIndex = 55;
            this.label20.Text = "a.m.";
            // 
            // chkSession3
            // 
            this.chkSession3.AutoSize = true;
            this.chkSession3.Checked = true;
            this.chkSession3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSession3.Location = new System.Drawing.Point(152, 240);
            this.chkSession3.Name = "chkSession3";
            this.chkSession3.Size = new System.Drawing.Size(15, 14);
            this.chkSession3.TabIndex = 54;
            this.chkSession3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkSession3.UseVisualStyleBackColor = true;
            this.chkSession3.CheckedChanged += new System.EventHandler(this.chkSession3_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(121, 224);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 13);
            this.label18.TabIndex = 53;
            this.label18.Text = "p.m.";
            // 
            // chkSession2
            // 
            this.chkSession2.AutoSize = true;
            this.chkSession2.Checked = true;
            this.chkSession2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSession2.Location = new System.Drawing.Point(125, 240);
            this.chkSession2.Name = "chkSession2";
            this.chkSession2.Size = new System.Drawing.Size(15, 14);
            this.chkSession2.TabIndex = 52;
            this.chkSession2.Tag = "2";
            this.chkSession2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkSession2.UseVisualStyleBackColor = true;
            this.chkSession2.CheckedChanged += new System.EventHandler(this.chkSession2_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(94, 224);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 51;
            this.label17.Text = "a.m.";
            // 
            // chkSession1
            // 
            this.chkSession1.AutoSize = true;
            this.chkSession1.Checked = true;
            this.chkSession1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSession1.Location = new System.Drawing.Point(98, 240);
            this.chkSession1.Name = "chkSession1";
            this.chkSession1.Size = new System.Drawing.Size(15, 14);
            this.chkSession1.TabIndex = 50;
            this.chkSession1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkSession1.UseVisualStyleBackColor = true;
            this.chkSession1.CheckedChanged += new System.EventHandler(this.chkSession1_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 233);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "Availability";
            // 
            // btnDriver
            // 
            this.btnDriver.Location = new System.Drawing.Point(17, 267);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(125, 30);
            this.btnDriver.TabIndex = 48;
            this.btnDriver.Text = "See Driver Details";
            this.btnDriver.UseVisualStyleBackColor = true;
            this.btnDriver.Click += new System.EventHandler(this.btnDriver_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radActiveYes);
            this.panel2.Controls.Add(this.radActiveNo);
            this.panel2.Location = new System.Drawing.Point(97, 179);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 23);
            this.panel2.TabIndex = 47;
            // 
            // radActiveYes
            // 
            this.radActiveYes.AutoSize = true;
            this.radActiveYes.Location = new System.Drawing.Point(2, 3);
            this.radActiveYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radActiveYes.Name = "radActiveYes";
            this.radActiveYes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radActiveYes.Size = new System.Drawing.Size(43, 17);
            this.radActiveYes.TabIndex = 42;
            this.radActiveYes.TabStop = true;
            this.radActiveYes.Text = "Yes";
            this.radActiveYes.UseVisualStyleBackColor = true;
            this.radActiveYes.CheckedChanged += new System.EventHandler(this.radActiveYes_CheckedChanged);
            // 
            // radActiveNo
            // 
            this.radActiveNo.AutoSize = true;
            this.radActiveNo.Location = new System.Drawing.Point(53, 3);
            this.radActiveNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radActiveNo.Name = "radActiveNo";
            this.radActiveNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radActiveNo.Size = new System.Drawing.Size(39, 17);
            this.radActiveNo.TabIndex = 43;
            this.radActiveNo.TabStop = true;
            this.radActiveNo.Text = "No";
            this.radActiveNo.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 184);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "Active Driver?";
            // 
            // cboTitle
            // 
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Location = new System.Drawing.Point(97, 15);
            this.cboTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(56, 21);
            this.cboTitle.TabIndex = 38;
            this.cboTitle.SelectedIndexChanged += new System.EventHandler(this.cboTitle_SelectedIndexChanged);
            // 
            // btnNotes
            // 
            this.btnNotes.Enabled = false;
            this.btnNotes.Location = new System.Drawing.Point(185, 267);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(125, 30);
            this.btnNotes.TabIndex = 37;
            this.btnNotes.Text = "See Driver Notes";
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(351, 267);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 30);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update Driver";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // mskPostCode
            // 
            this.mskPostCode.BeepOnError = true;
            this.mskPostCode.Location = new System.Drawing.Point(98, 153);
            this.mskPostCode.Mask = ">LCCC 9LL";
            this.mskPostCode.Name = "mskPostCode";
            this.mskPostCode.Size = new System.Drawing.Size(101, 20);
            this.mskPostCode.TabIndex = 35;
            this.mskPostCode.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskPostCode_MaskInputRejected);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(281, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Driver ID";
            // 
            // txtDriverID
            // 
            this.txtDriverID.Enabled = false;
            this.txtDriverID.Location = new System.Drawing.Point(377, 15);
            this.txtDriverID.Name = "txtDriverID";
            this.txtDriverID.Size = new System.Drawing.Size(101, 20);
            this.txtDriverID.TabIndex = 15;
            this.txtDriverID.Text = "0";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(377, 84);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(119, 20);
            this.dtpDOB.TabIndex = 18;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Date of Birth";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(281, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Home Phone";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(377, 38);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(101, 20);
            this.txtHomePhone.TabIndex = 16;
            this.txtHomePhone.TextChanged += new System.EventHandler(this.txtHomePhone_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(281, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mobile Phone";
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.Location = new System.Drawing.Point(377, 61);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(101, 20);
            this.txtMobilePhone.TabIndex = 17;
            this.txtMobilePhone.TextChanged += new System.EventHandler(this.txtMobilePhone_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(281, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Email Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(377, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(134, 20);
            this.txtEmail.TabIndex = 19;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(98, 62);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(101, 20);
            this.txtSurname.TabIndex = 10;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Town";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(98, 130);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(101, 20);
            this.txtTown.TabIndex = 13;
            this.txtTown.TextChanged += new System.EventHandler(this.txtTown_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "PostCode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(97, 39);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(101, 20);
            this.txtFirstName.TabIndex = 8;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address Line 1";
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(98, 84);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(161, 20);
            this.txtAddressLine1.TabIndex = 11;
            this.txtAddressLine1.TextChanged += new System.EventHandler(this.txtAddressLine1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address Line 2";
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(98, 107);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(161, 20);
            this.txtAddressLine2.TabIndex = 12;
            this.txtAddressLine2.TextChanged += new System.EventHandler(this.txtAddressLine2_TextChanged);
            // 
            // frmDriverEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 591);
            this.Controls.Add(this.gbEditControls);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.grpSearch);
            this.Name = "frmDriverEdit";
            this.Text = "Edit Driver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDriverEdit_FormClosing);
            this.Load += new System.EventHandler(this.frmDriverEdit_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.gbActive.ResumeLayout(false);
            this.gbActive.PerformLayout();
            this.gbEditControls.ResumeLayout(false);
            this.gbEditControls.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader DriverID;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader Initial;
        private System.Windows.Forms.ColumnHeader AddressLine1;
        private System.Windows.Forms.ColumnHeader AddressLine2;
        private System.Windows.Forms.ColumnHeader Town;
        private System.Windows.Forms.ColumnHeader Postcode;
        private System.Windows.Forms.TextBox txtSearchSurname;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblSearchSurname;
        private System.Windows.Forms.RadioButton radActiveFalse;
        private System.Windows.Forms.RadioButton radActiveTrue;
        private System.Windows.Forms.GroupBox gbActive;
        private System.Windows.Forms.RadioButton radActiveAll;
        private System.Windows.Forms.Label lblSearchAddressLine1;
        private System.Windows.Forms.TextBox txtSearchAddressLine1;
        private System.Windows.Forms.Label lblSearchTown;
        private System.Windows.Forms.TextBox txtSearchTown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbEditControls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDriverID;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MaskedTextBox mskPostCode;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.ComboBox cboTitle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton radActiveNo;
        private System.Windows.Forms.RadioButton radActiveYes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDriver;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkSession1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox chkSession14;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.CheckBox chkSession13;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox chkSession12;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.CheckBox chkSession11;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox chkSession10;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox chkSession9;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox chkSession8;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox chkSession7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox chkSession6;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox chkSession5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox chkSession4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox chkSession3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox chkSession2;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox cboCarMake;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.DateTimePicker dtpLicenceExpiry;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtLicenceNo;
    }
}