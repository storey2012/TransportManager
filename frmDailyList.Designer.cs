namespace TransManager
{
    partial class frmDailyList
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Linked Jobs", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Unlinked Jobs", System.Windows.Forms.HorizontalAlignment.Left);
            this.lvJobs = new System.Windows.Forms.ListView();
            this.JobID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientaddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.appt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.destination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.destAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jobDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Link = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rtbJobNotes = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLink = new System.Windows.Forms.Button();
            this.lblLink1 = new System.Windows.Forms.Label();
            this.rtbLink1 = new System.Windows.Forms.RichTextBox();
            this.lblLink2 = new System.Windows.Forms.Label();
            this.rtbLink2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvJobs
            // 
            this.lvJobs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.JobID,
            this.client,
            this.clientaddress,
            this.appt,
            this.destination,
            this.destAddress,
            this.jobDate,
            this.Link});
            this.lvJobs.FullRowSelect = true;
            this.lvJobs.GridLines = true;
            listViewGroup1.Header = "Linked Jobs";
            listViewGroup1.Name = "lvgLinked";
            listViewGroup2.Header = "Unlinked Jobs";
            listViewGroup2.Name = "lvgUnLinked";
            this.lvJobs.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lvJobs.Location = new System.Drawing.Point(25, 12);
            this.lvJobs.Name = "lvJobs";
            this.lvJobs.Size = new System.Drawing.Size(905, 259);
            this.lvJobs.TabIndex = 0;
            this.lvJobs.UseCompatibleStateImageBehavior = false;
            this.lvJobs.View = System.Windows.Forms.View.Details;
            this.lvJobs.SelectedIndexChanged += new System.EventHandler(this.lvJobs_SelectedIndexChanged);
            // 
            // JobID
            // 
            this.JobID.Text = "Job ID";
            this.JobID.Width = 43;
            // 
            // client
            // 
            this.client.Text = "Client Name";
            this.client.Width = 99;
            // 
            // clientaddress
            // 
            this.clientaddress.Text = "Pick Up Address";
            this.clientaddress.Width = 196;
            // 
            // appt
            // 
            this.appt.DisplayIndex = 4;
            this.appt.Text = "Appt Time";
            this.appt.Width = 65;
            // 
            // destination
            // 
            this.destination.DisplayIndex = 3;
            this.destination.Text = "Destination";
            this.destination.Width = 150;
            // 
            // destAddress
            // 
            this.destAddress.Text = "Destination Address";
            this.destAddress.Width = 200;
            // 
            // jobDate
            // 
            this.jobDate.Text = "Job Date";
            this.jobDate.Width = 93;
            // 
            // Link
            // 
            this.Link.Text = "Link";
            // 
            // rtbJobNotes
            // 
            this.rtbJobNotes.BackColor = System.Drawing.Color.LightYellow;
            this.rtbJobNotes.Location = new System.Drawing.Point(25, 338);
            this.rtbJobNotes.Name = "rtbJobNotes";
            this.rtbJobNotes.Size = new System.Drawing.Size(268, 120);
            this.rtbJobNotes.TabIndex = 1;
            this.rtbJobNotes.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(25, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Job Notes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(478, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jobs highlighted with blue background may be linked and have different drivers.";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(335, 305);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnLink);
            this.splitContainer1.Panel1.Controls.Add(this.lblLink1);
            this.splitContainer1.Panel1.Controls.Add(this.rtbLink1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblLink2);
            this.splitContainer1.Panel2.Controls.Add(this.rtbLink2);
            this.splitContainer1.Size = new System.Drawing.Size(595, 166);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(231, 72);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(63, 44);
            this.btnLink.TabIndex = 9;
            this.btnLink.Text = "Link the Jobs";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // lblLink1
            // 
            this.lblLink1.AutoSize = true;
            this.lblLink1.Location = new System.Drawing.Point(13, 17);
            this.lblLink1.Name = "lblLink1";
            this.lblLink1.Size = new System.Drawing.Size(63, 13);
            this.lblLink1.TabIndex = 6;
            this.lblLink1.Text = "Link this job";
            // 
            // rtbLink1
            // 
            this.rtbLink1.BackColor = System.Drawing.Color.LightYellow;
            this.rtbLink1.Location = new System.Drawing.Point(16, 33);
            this.rtbLink1.Name = "rtbLink1";
            this.rtbLink1.Size = new System.Drawing.Size(209, 120);
            this.rtbLink1.TabIndex = 5;
            this.rtbLink1.Tag = "0";
            this.rtbLink1.Text = "No Job Selected";
            // 
            // lblLink2
            // 
            this.lblLink2.AutoSize = true;
            this.lblLink2.Location = new System.Drawing.Point(14, 17);
            this.lblLink2.Name = "lblLink2";
            this.lblLink2.Size = new System.Drawing.Size(62, 13);
            this.lblLink2.TabIndex = 7;
            this.lblLink2.Text = "with this job";
            // 
            // rtbLink2
            // 
            this.rtbLink2.BackColor = System.Drawing.Color.LightYellow;
            this.rtbLink2.Location = new System.Drawing.Point(17, 33);
            this.rtbLink2.Name = "rtbLink2";
            this.rtbLink2.Size = new System.Drawing.Size(209, 120);
            this.rtbLink2.TabIndex = 6;
            this.rtbLink2.Tag = "0";
            this.rtbLink2.Text = "No Job Selected";
            // 
            // frmDailyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 496);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbJobNotes);
            this.Controls.Add(this.lvJobs);
            this.Name = "frmDailyList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Daily Job List";
            this.Load += new System.EventHandler(this.frmDailyList_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvJobs;
        private System.Windows.Forms.ColumnHeader client;
        private System.Windows.Forms.ColumnHeader clientaddress;
        private System.Windows.Forms.ColumnHeader destination;
        private System.Windows.Forms.ColumnHeader appt;
        private System.Windows.Forms.ColumnHeader JobID;
        private System.Windows.Forms.ColumnHeader destAddress;
        private System.Windows.Forms.RichTextBox rtbJobNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader jobDate;
        private System.Windows.Forms.ColumnHeader Link;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtbLink1;
        private System.Windows.Forms.Label lblLink1;
        private System.Windows.Forms.Label lblLink2;
        private System.Windows.Forms.RichTextBox rtbLink2;
        private System.Windows.Forms.Button btnLink;
    }
}