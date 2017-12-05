using System.Configuration;
namespace TransManager
{
    partial class frmClientEdit
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
            this.ClientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Initial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressLine1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressLine2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Town = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Postcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearchSurname = new System.Windows.Forms.TextBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
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
            this.label14 = new System.Windows.Forms.Label();
            this.clbAttributes = new System.Windows.Forms.CheckedListBox();
            this.btnDonations = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radActiveYes = new System.Windows.Forms.RadioButton();
            this.radActiveNo = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.mskPostCode = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
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
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClientID,
            this.title,
            this.FirstName,
            this.Initial,
            this.AddressLine1,
            this.AddressLine2,
            this.Town,
            this.Postcode});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 295);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(847, 258);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ClientID
            // 
            this.ClientID.Text = "ClientID";
            this.ClientID.Width = 67;
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
            this.grpSearch.Size = new System.Drawing.Size(281, 179);
            this.grpSearch.TabIndex = 4;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Filters";
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
            this.radActiveTrue.Size = new System.Drawing.Size(88, 17);
            this.radActiveTrue.TabIndex = 0;
            this.radActiveTrue.TabStop = true;
            this.radActiveTrue.Text = "Active clients";
            this.radActiveTrue.UseVisualStyleBackColor = true;
            this.radActiveTrue.CheckedChanged += new System.EventHandler(this.radActiveTrue_CheckedChanged);
            // 
            // radActiveFalse
            // 
            this.radActiveFalse.AutoSize = true;
            this.radActiveFalse.Location = new System.Drawing.Point(8, 42);
            this.radActiveFalse.Name = "radActiveFalse";
            this.radActiveFalse.Size = new System.Drawing.Size(96, 17);
            this.radActiveFalse.TabIndex = 0;
            this.radActiveFalse.Text = "Inactive clients";
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
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // gbEditControls
            // 
            this.gbEditControls.Controls.Add(this.label14);
            this.gbEditControls.Controls.Add(this.clbAttributes);
            this.gbEditControls.Controls.Add(this.btnDonations);
            this.gbEditControls.Controls.Add(this.panel2);
            this.gbEditControls.Controls.Add(this.label15);
            this.gbEditControls.Controls.Add(this.cboTitle);
            this.gbEditControls.Controls.Add(this.btnNotes);
            this.gbEditControls.Controls.Add(this.btnUpdate);
            this.gbEditControls.Controls.Add(this.mskPostCode);
            this.gbEditControls.Controls.Add(this.label13);
            this.gbEditControls.Controls.Add(this.txtClientID);
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
            this.gbEditControls.Controls.Add(this.label6);
            this.gbEditControls.Controls.Add(this.txtMiddleName);
            this.gbEditControls.Controls.Add(this.label5);
            this.gbEditControls.Controls.Add(this.txtAddressLine1);
            this.gbEditControls.Controls.Add(this.label4);
            this.gbEditControls.Controls.Add(this.txtAddressLine2);
            this.gbEditControls.Controls.Add(this.label1);
            this.gbEditControls.Location = new System.Drawing.Point(315, 12);
            this.gbEditControls.Name = "gbEditControls";
            this.gbEditControls.Size = new System.Drawing.Size(519, 276);
            this.gbEditControls.TabIndex = 0;
            this.gbEditControls.TabStop = false;
            this.gbEditControls.Text = "Edit Client:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(312, 101);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = "Client Details:";
            // 
            // clbAttributes
            // 
            this.clbAttributes.BackColor = System.Drawing.SystemColors.Menu;
            this.clbAttributes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbAttributes.CheckOnClick = true;
            this.clbAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbAttributes.FormattingEnabled = true;
            this.clbAttributes.Location = new System.Drawing.Point(311, 116);
            this.clbAttributes.Margin = new System.Windows.Forms.Padding(2);
            this.clbAttributes.Name = "clbAttributes";
            this.clbAttributes.Size = new System.Drawing.Size(191, 100);
            this.clbAttributes.Sorted = true;
            this.clbAttributes.TabIndex = 49;
            this.clbAttributes.ThreeDCheckBoxes = true;
            this.clbAttributes.SelectedIndexChanged += new System.EventHandler(this.clbAttributes_SelectedIndexChanged);
            // 
            // btnDonations
            // 
            this.btnDonations.Enabled = false;
            this.btnDonations.Location = new System.Drawing.Point(225, 166);
            this.btnDonations.Name = "btnDonations";
            this.btnDonations.Size = new System.Drawing.Size(79, 30);
            this.btnDonations.TabIndex = 48;
            this.btnDonations.Text = "Donations";
            this.btnDonations.UseVisualStyleBackColor = true;
            this.btnDonations.Click += new System.EventHandler(this.btnDonations_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radActiveYes);
            this.panel2.Controls.Add(this.radActiveNo);
            this.panel2.Location = new System.Drawing.Point(375, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 23);
            this.panel2.TabIndex = 47;
            // 
            // radActiveYes
            // 
            this.radActiveYes.AutoSize = true;
            this.radActiveYes.Location = new System.Drawing.Point(2, 3);
            this.radActiveYes.Margin = new System.Windows.Forms.Padding(2);
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
            this.radActiveNo.Margin = new System.Windows.Forms.Padding(2);
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
            this.label15.Location = new System.Drawing.Point(281, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "Active Client?";
            // 
            // cboTitle
            // 
            this.cboTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Location = new System.Drawing.Point(107, 15);
            this.cboTitle.Margin = new System.Windows.Forms.Padding(2);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(56, 21);
            this.cboTitle.TabIndex = 38;
            this.cboTitle.SelectedIndexChanged += new System.EventHandler(this.cboTitle_SelectedIndexChanged);
            // 
            // btnNotes
            // 
            this.btnNotes.Enabled = false;
            this.btnNotes.Location = new System.Drawing.Point(225, 202);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(79, 30);
            this.btnNotes.TabIndex = 37;
            this.btnNotes.Text = "Client Notes";
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(225, 239);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 30);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update Client";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // mskPostCode
            // 
            this.mskPostCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mskPostCode.BeepOnError = true;
            this.mskPostCode.Location = new System.Drawing.Point(106, 182);
            this.mskPostCode.Mask = ">LCCC 9LL";
            this.mskPostCode.Name = "mskPostCode";
            this.mskPostCode.Size = new System.Drawing.Size(57, 20);
            this.mskPostCode.TabIndex = 35;
            this.mskPostCode.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskPostCode_MaskInputRejected);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(281, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Client ID";
            // 
            // txtClientID
            // 
            this.txtClientID.Enabled = false;
            this.txtClientID.Location = new System.Drawing.Point(375, 21);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(101, 20);
            this.txtClientID.TabIndex = 15;
            this.txtClientID.Text = "0";
            this.txtClientID.TextChanged += new System.EventHandler(this.txtClientID_TextChanged);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(106, 251);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(113, 20);
            this.dtpDOB.TabIndex = 18;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Date of Birth";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Home Phone";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtHomePhone.Location = new System.Drawing.Point(106, 205);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(101, 20);
            this.txtHomePhone.TabIndex = 16;
            this.txtHomePhone.TextChanged += new System.EventHandler(this.txtHomePhone_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mobile Phone";
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtMobilePhone.Location = new System.Drawing.Point(106, 228);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(101, 20);
            this.txtMobilePhone.TabIndex = 17;
            this.txtMobilePhone.TextChanged += new System.EventHandler(this.txtMobilePhone_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(281, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Email Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(375, 46);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(127, 20);
            this.txtEmail.TabIndex = 19;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSurname.Location = new System.Drawing.Point(106, 90);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(101, 20);
            this.txtSurname.TabIndex = 10;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Town";
            // 
            // txtTown
            // 
            this.txtTown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTown.Location = new System.Drawing.Point(106, 159);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(101, 20);
            this.txtTown.TabIndex = 13;
            this.txtTown.TextChanged += new System.EventHandler(this.txtTown_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "PostCode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtFirstName.Location = new System.Drawing.Point(106, 44);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(101, 20);
            this.txtFirstName.TabIndex = 8;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Middle Name";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(106, 67);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(101, 20);
            this.txtMiddleName.TabIndex = 9;
            this.txtMiddleName.TextChanged += new System.EventHandler(this.txtMiddleName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address Line 1";
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAddressLine1.Location = new System.Drawing.Point(106, 113);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(161, 20);
            this.txtAddressLine1.TabIndex = 11;
            this.txtAddressLine1.TextChanged += new System.EventHandler(this.txtAddressLine1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address Line 2";
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(106, 136);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(161, 20);
            this.txtAddressLine2.TabIndex = 12;
            this.txtAddressLine2.TextChanged += new System.EventHandler(this.txtAddressLine2_TextChanged);
            // 
            // frmClientEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 565);
            this.Controls.Add(this.gbEditControls);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.grpSearch);
            this.Name = "frmClientEdit";
            this.Text = "Edit Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClientEdit_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
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
        private System.Windows.Forms.ColumnHeader ClientID;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMiddleName;
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
        private System.Windows.Forms.TextBox txtClientID;
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
        private System.Windows.Forms.Button btnDonations;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckedListBox clbAttributes;
    }
}