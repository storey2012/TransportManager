namespace TransManager
{
    partial class frmDriverAdd
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.mskPostCode = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.dtpLicenceExpiry = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.txtLicenceNo = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cboTitle);
            this.splitContainer1.Panel1.Controls.Add(this.mskPostCode);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtTown);
            this.splitContainer1.Panel1.Controls.Add(this.txtFirstName);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtAddressLine2);
            this.splitContainer1.Panel1.Controls.Add(this.txtAddressLine1);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtSurname);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtpLicenceExpiry);
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.label39);
            this.splitContainer1.Panel2.Controls.Add(this.txtLicenceNo);
            this.splitContainer1.Panel2.Controls.Add(this.lblStatus);
            this.splitContainer1.Panel2.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel2.Controls.Add(this.dtpDOB);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.txtHomePhone);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.txtMobilePhone);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.txtEmail);
            this.splitContainer1.Size = new System.Drawing.Size(580, 210);
            this.splitContainer1.SplitterDistance = 275;
            this.splitContainer1.TabIndex = 16;
            // 
            // cboTitle
            // 
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Location = new System.Drawing.Point(103, 10);
            this.cboTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(56, 21);
            this.cboTitle.TabIndex = 1;
            // 
            // mskPostCode
            // 
            this.mskPostCode.BeepOnError = true;
            this.mskPostCode.Location = new System.Drawing.Point(103, 166);
            this.mskPostCode.Mask = ">LCCC 9LL";
            this.mskPostCode.Name = "mskPostCode";
            this.mskPostCode.Size = new System.Drawing.Size(56, 20);
            this.mskPostCode.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Postcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(103, 141);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(144, 20);
            this.txtTown.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtFirstName.Location = new System.Drawing.Point(103, 37);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(114, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Town";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address Line 1";
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(103, 115);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(144, 20);
            this.txtAddressLine2.TabIndex = 6;
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAddressLine1.Location = new System.Drawing.Point(103, 89);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(144, 20);
            this.txtAddressLine1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address Line 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSurname.Location = new System.Drawing.Point(103, 63);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(114, 20);
            this.txtSurname.TabIndex = 4;
            // 
            // dtpLicenceExpiry
            // 
            this.dtpLicenceExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLicenceExpiry.Location = new System.Drawing.Point(119, 140);
            this.dtpLicenceExpiry.Name = "dtpLicenceExpiry";
            this.dtpLicenceExpiry.Size = new System.Drawing.Size(101, 20);
            this.dtpLicenceExpiry.TabIndex = 14;
            this.dtpLicenceExpiry.Value = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 90;
            this.label14.Text = "Licence Expiry";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(17, 120);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(62, 13);
            this.label39.TabIndex = 89;
            this.label39.Text = "Licence No";
            // 
            // txtLicenceNo
            // 
            this.txtLicenceNo.Location = new System.Drawing.Point(119, 114);
            this.txtLicenceNo.Name = "txtLicenceNo";
            this.txtLicenceNo.Size = new System.Drawing.Size(101, 20);
            this.txtLicenceNo.TabIndex = 13;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(28, 179);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 48;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(100, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 25);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add Driver";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(119, 62);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(101, 20);
            this.dtpDOB.TabIndex = 11;
            this.dtpDOB.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Date of Birth";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Home Phone";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(119, 10);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(101, 20);
            this.txtHomePhone.TabIndex = 9;
            this.txtHomePhone.TextChanged += new System.EventHandler(this.txtHomePhone_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Mobile Phone";
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.Location = new System.Drawing.Point(119, 36);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(101, 20);
            this.txtMobilePhone.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Email Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // frmDriverAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 237);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmDriverAdd";
            this.Text = "Add new driver";
            this.Load += new System.EventHandler(this.frmDriverAdd_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.MaskedTextBox mskPostCode;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboTitle;
        private System.Windows.Forms.DateTimePicker dtpLicenceExpiry;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtLicenceNo;
    }
}