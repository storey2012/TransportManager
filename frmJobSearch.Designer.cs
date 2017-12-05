namespace TransManager
{
    partial class frmJobSearch
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
            this.rtbClientDetails = new System.Windows.Forms.RichTextBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.mskTo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskFrom = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.chkJobNeedsDriver = new System.Windows.Forms.CheckBox();
            this.chkJobOpen = new System.Windows.Forms.CheckBox();
            this.chkJobCancelled = new System.Windows.Forms.CheckBox();
            this.chkJobClosed = new System.Windows.Forms.CheckBox();
            this.lblSearchTown = new System.Windows.Forms.Label();
            this.lblSearchAddressLine1 = new System.Windows.Forms.Label();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.lblSearchSurname = new System.Windows.Forms.Label();
            this.txtSearchSurname = new System.Windows.Forms.TextBox();
            this.lvSearchResults = new System.Windows.Forms.ListView();
            this.jobid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientpostcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jobdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpSearch.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbClientDetails
            // 
            this.rtbClientDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rtbClientDetails.Location = new System.Drawing.Point(437, 52);
            this.rtbClientDetails.Name = "rtbClientDetails";
            this.rtbClientDetails.Size = new System.Drawing.Size(222, 129);
            this.rtbClientDetails.TabIndex = 6;
            this.rtbClientDetails.Text = "Full Client Details:\nTitle: \nFirstname:\nMiddleName:\nSurname:\nAddress Line 1:\nAddr" +
    "ess Line2: ";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.mskTo);
            this.grpSearch.Controls.Add(this.label2);
            this.grpSearch.Controls.Add(this.mskFrom);
            this.grpSearch.Controls.Add(this.label1);
            this.grpSearch.Controls.Add(this.gbStatus);
            this.grpSearch.Controls.Add(this.lblSearchTown);
            this.grpSearch.Controls.Add(this.lblSearchAddressLine1);
            this.grpSearch.Controls.Add(this.txtPostCode);
            this.grpSearch.Controls.Add(this.lblSearchSurname);
            this.grpSearch.Controls.Add(this.txtSearchSurname);
            this.grpSearch.Location = new System.Drawing.Point(12, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(378, 215);
            this.grpSearch.TabIndex = 7;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Filters";
            // 
            // mskTo
            // 
            this.mskTo.Location = new System.Drawing.Point(67, 173);
            this.mskTo.Margin = new System.Windows.Forms.Padding(2);
            this.mskTo.Mask = "00/00/0000";
            this.mskTo.Name = "mskTo";
            this.mskTo.Size = new System.Drawing.Size(76, 20);
            this.mskTo.TabIndex = 92;
            this.mskTo.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "to:";
            // 
            // mskFrom
            // 
            this.mskFrom.Location = new System.Drawing.Point(67, 149);
            this.mskFrom.Margin = new System.Windows.Forms.Padding(2);
            this.mskFrom.Mask = "00/00/0000";
            this.mskFrom.Name = "mskFrom";
            this.mskFrom.Size = new System.Drawing.Size(76, 20);
            this.mskFrom.TabIndex = 90;
            this.mskFrom.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "from:";
            // 
            // gbStatus
            // 
            this.gbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStatus.Controls.Add(this.chkJobNeedsDriver);
            this.gbStatus.Controls.Add(this.chkJobOpen);
            this.gbStatus.Controls.Add(this.chkJobCancelled);
            this.gbStatus.Controls.Add(this.chkJobClosed);
            this.gbStatus.Location = new System.Drawing.Point(180, 20);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(145, 135);
            this.gbStatus.TabIndex = 88;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Job Status:";
            // 
            // chkJobNeedsDriver
            // 
            this.chkJobNeedsDriver.AutoSize = true;
            this.chkJobNeedsDriver.Checked = true;
            this.chkJobNeedsDriver.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJobNeedsDriver.Location = new System.Drawing.Point(11, 95);
            this.chkJobNeedsDriver.Name = "chkJobNeedsDriver";
            this.chkJobNeedsDriver.Size = new System.Drawing.Size(88, 17);
            this.chkJobNeedsDriver.TabIndex = 3;
            this.chkJobNeedsDriver.Text = "Needs Driver";
            this.chkJobNeedsDriver.UseVisualStyleBackColor = true;
            this.chkJobNeedsDriver.CheckedChanged += new System.EventHandler(this.chkJobNeedsDriver_CheckedChanged);
            // 
            // chkJobOpen
            // 
            this.chkJobOpen.AutoSize = true;
            this.chkJobOpen.Checked = true;
            this.chkJobOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJobOpen.Location = new System.Drawing.Point(11, 72);
            this.chkJobOpen.Name = "chkJobOpen";
            this.chkJobOpen.Size = new System.Drawing.Size(52, 17);
            this.chkJobOpen.TabIndex = 2;
            this.chkJobOpen.Text = "Open";
            this.chkJobOpen.UseVisualStyleBackColor = true;
            this.chkJobOpen.CheckedChanged += new System.EventHandler(this.chkJobOpen_CheckedChanged);
            // 
            // chkJobCancelled
            // 
            this.chkJobCancelled.AutoSize = true;
            this.chkJobCancelled.Location = new System.Drawing.Point(11, 49);
            this.chkJobCancelled.Name = "chkJobCancelled";
            this.chkJobCancelled.Size = new System.Drawing.Size(73, 17);
            this.chkJobCancelled.TabIndex = 1;
            this.chkJobCancelled.Text = "Cancelled";
            this.chkJobCancelled.UseVisualStyleBackColor = true;
            this.chkJobCancelled.CheckedChanged += new System.EventHandler(this.chkJobCancelled_CheckedChanged);
            // 
            // chkJobClosed
            // 
            this.chkJobClosed.AutoSize = true;
            this.chkJobClosed.Location = new System.Drawing.Point(11, 26);
            this.chkJobClosed.Name = "chkJobClosed";
            this.chkJobClosed.Size = new System.Drawing.Size(58, 17);
            this.chkJobClosed.TabIndex = 0;
            this.chkJobClosed.Text = "Closed";
            this.chkJobClosed.UseVisualStyleBackColor = true;
            this.chkJobClosed.CheckedChanged += new System.EventHandler(this.chkJobClosed_CheckedChanged);
            // 
            // lblSearchTown
            // 
            this.lblSearchTown.AutoSize = true;
            this.lblSearchTown.Location = new System.Drawing.Point(6, 119);
            this.lblSearchTown.Name = "lblSearchTown";
            this.lblSearchTown.Size = new System.Drawing.Size(69, 13);
            this.lblSearchTown.TabIndex = 11;
            this.lblSearchTown.Text = "filter by Date:";
            // 
            // lblSearchAddressLine1
            // 
            this.lblSearchAddressLine1.AutoSize = true;
            this.lblSearchAddressLine1.Location = new System.Drawing.Point(6, 65);
            this.lblSearchAddressLine1.Name = "lblSearchAddressLine1";
            this.lblSearchAddressLine1.Size = new System.Drawing.Size(91, 13);
            this.lblSearchAddressLine1.TabIndex = 9;
            this.lblSearchAddressLine1.Text = "filter by Postcode:";
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(6, 81);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(137, 20);
            this.txtPostCode.TabIndex = 8;
            this.txtPostCode.TextChanged += new System.EventHandler(this.txtPostCode_TextChanged);
            // 
            // lblSearchSurname
            // 
            this.lblSearchSurname.AutoSize = true;
            this.lblSearchSurname.Location = new System.Drawing.Point(6, 20);
            this.lblSearchSurname.Name = "lblSearchSurname";
            this.lblSearchSurname.Size = new System.Drawing.Size(88, 13);
            this.lblSearchSurname.TabIndex = 4;
            this.lblSearchSurname.Text = "filter by Surname:";
            // 
            // txtSearchSurname
            // 
            this.txtSearchSurname.Location = new System.Drawing.Point(6, 36);
            this.txtSearchSurname.Name = "txtSearchSurname";
            this.txtSearchSurname.Size = new System.Drawing.Size(137, 20);
            this.txtSearchSurname.TabIndex = 3;
            this.txtSearchSurname.TextChanged += new System.EventHandler(this.txtSearchSurname_TextChanged);
            // 
            // lvSearchResults
            // 
            this.lvSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.jobid,
            this.clientname,
            this.clientpostcode,
            this.jobdate});
            this.lvSearchResults.FullRowSelect = true;
            this.lvSearchResults.Location = new System.Drawing.Point(12, 233);
            this.lvSearchResults.MultiSelect = false;
            this.lvSearchResults.Name = "lvSearchResults";
            this.lvSearchResults.Size = new System.Drawing.Size(401, 244);
            this.lvSearchResults.TabIndex = 8;
            this.lvSearchResults.UseCompatibleStateImageBehavior = false;
            this.lvSearchResults.View = System.Windows.Forms.View.Details;
            this.lvSearchResults.SelectedIndexChanged += new System.EventHandler(this.lvSearchResults_SelectedIndexChanged);
            // 
            // jobid
            // 
            this.jobid.Text = "Job ID";
            this.jobid.Width = 43;
            // 
            // clientname
            // 
            this.clientname.Text = "Client Name";
            this.clientname.Width = 180;
            // 
            // clientpostcode
            // 
            this.clientpostcode.Text = "PostCode";
            this.clientpostcode.Width = 80;
            // 
            // jobdate
            // 
            this.jobdate.Text = "Job Date";
            this.jobdate.Width = 83;
            // 
            // txtJobID
            // 
            this.txtJobID.Enabled = false;
            this.txtJobID.Location = new System.Drawing.Point(485, 25);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(94, 20);
            this.txtJobID.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "Job ID:";
            // 
            // frmJobSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 502);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJobID);
            this.Controls.Add(this.lvSearchResults);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.rtbClientDetails);
            this.Name = "frmJobSearch";
            this.Text = "frmJobSearch";
            this.Load += new System.EventHandler(this.frmJobSearch_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbClientDetails;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblSearchTown;
        private System.Windows.Forms.Label lblSearchAddressLine1;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label lblSearchSurname;
        private System.Windows.Forms.TextBox txtSearchSurname;
        private System.Windows.Forms.ListView lvSearchResults;
        private System.Windows.Forms.ColumnHeader jobid;
        private System.Windows.Forms.ColumnHeader clientname;
        private System.Windows.Forms.ColumnHeader clientpostcode;
        private System.Windows.Forms.ColumnHeader jobdate;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.CheckBox chkJobNeedsDriver;
        private System.Windows.Forms.CheckBox chkJobOpen;
        private System.Windows.Forms.CheckBox chkJobCancelled;
        private System.Windows.Forms.CheckBox chkJobClosed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskFrom;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.Label label3;
    }
}