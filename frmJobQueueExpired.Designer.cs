namespace TransManager
{
    partial class frmJobQueueExpired
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobQueueExpired));
            this.imgIcons = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbViewAll = new System.Windows.Forms.GroupBox();
            this.radCancelled = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.gbJobsView = new System.Windows.Forms.GroupBox();
            this.radByClient = new System.Windows.Forms.RadioButton();
            this.radByDriver = new System.Windows.Forms.RadioButton();
            this.radByDate = new System.Windows.Forms.RadioButton();
            this.tvJobs = new System.Windows.Forms.TreeView();
            this.gbContactOutcome = new System.Windows.Forms.GroupBox();
            this.radC5 = new System.Windows.Forms.RadioButton();
            this.radC4 = new System.Windows.Forms.RadioButton();
            this.radC3 = new System.Windows.Forms.RadioButton();
            this.radC2 = new System.Windows.Forms.RadioButton();
            this.radC1 = new System.Windows.Forms.RadioButton();
            this.radA1 = new System.Windows.Forms.RadioButton();
            this.btnCloseJob = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAdditional = new System.Windows.Forms.Label();
            this.rtbContactNotes = new System.Windows.Forms.RichTextBox();
            this.rtbJobDetailsL2 = new System.Windows.Forms.RichTextBox();
            this.txtJobDate = new System.Windows.Forms.TextBox();
            this.rtbJobDetailsL1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJobNotes = new System.Windows.Forms.Label();
            this.rtbJobNotes = new System.Windows.Forms.RichTextBox();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtJobStatus = new System.Windows.Forms.TextBox();
            this.lblJobStatusPrefix = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbViewAll.SuspendLayout();
            this.gbJobsView.SuspendLayout();
            this.gbContactOutcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgIcons
            // 
            this.imgIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcons.ImageStream")));
            this.imgIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcons.Images.SetKeyName(0, "AddedIcon.ico");
            this.imgIcons.Images.SetKeyName(1, "ConflictIcon.ico");
            this.imgIcons.Images.SetKeyName(2, "DeletedIcon.ico");
            this.imgIcons.Images.SetKeyName(3, "IgnoredIcon.ico");
            this.imgIcons.Images.SetKeyName(4, "LockedIcon.ico");
            this.imgIcons.Images.SetKeyName(5, "ModifiedIcon.ico");
            this.imgIcons.Images.SetKeyName(6, "NormalIcon.ico");
            this.imgIcons.Images.SetKeyName(7, "ProgressSkip.ico");
            this.imgIcons.Images.SetKeyName(8, "QuestionMark.ico");
            this.imgIcons.Images.SetKeyName(9, "ReadOnlyIcon.ico");
            this.imgIcons.Images.SetKeyName(10, "UnversionedIcon.ico");
            this.imgIcons.Images.SetKeyName(11, "yellow.ico");
            this.imgIcons.Images.SetKeyName(12, "e_red.ico");
            this.imgIcons.Images.SetKeyName(13, "c_red.ico");
            this.imgIcons.Images.SetKeyName(14, "c_blue.ico");
            this.imgIcons.Images.SetKeyName(15, "d_blue.ico");
            this.imgIcons.Images.SetKeyName(16, "o_blue.ico");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Choose Job:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(8, 11);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbViewAll);
            this.splitContainer1.Panel1.Controls.Add(this.gbJobsView);
            this.splitContainer1.Panel1.Controls.Add(this.tvJobs);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbContactOutcome);
            this.splitContainer1.Panel2.Controls.Add(this.btnCloseJob);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.lblAdditional);
            this.splitContainer1.Panel2.Controls.Add(this.rtbContactNotes);
            this.splitContainer1.Panel2.Controls.Add(this.rtbJobDetailsL2);
            this.splitContainer1.Panel2.Controls.Add(this.txtJobDate);
            this.splitContainer1.Panel2.Controls.Add(this.rtbJobDetailsL1);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.txtDriver);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txtClient);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.lblJobNotes);
            this.splitContainer1.Panel2.Controls.Add(this.rtbJobNotes);
            this.splitContainer1.Panel2.Controls.Add(this.txtJobID);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.txtJobStatus);
            this.splitContainer1.Panel2.Controls.Add(this.lblJobStatusPrefix);
            this.splitContainer1.Size = new System.Drawing.Size(958, 502);
            this.splitContainer1.SplitterDistance = 374;
            this.splitContainer1.TabIndex = 2;
            // 
            // gbViewAll
            // 
            this.gbViewAll.Controls.Add(this.radCancelled);
            this.gbViewAll.Controls.Add(this.radAll);
            this.gbViewAll.Location = new System.Drawing.Point(14, 47);
            this.gbViewAll.Margin = new System.Windows.Forms.Padding(2);
            this.gbViewAll.Name = "gbViewAll";
            this.gbViewAll.Padding = new System.Windows.Forms.Padding(2);
            this.gbViewAll.Size = new System.Drawing.Size(295, 35);
            this.gbViewAll.TabIndex = 4;
            this.gbViewAll.TabStop = false;
            this.gbViewAll.Text = "then by:";
            // 
            // radCancelled
            // 
            this.radCancelled.AutoSize = true;
            this.radCancelled.Location = new System.Drawing.Point(115, 15);
            this.radCancelled.Margin = new System.Windows.Forms.Padding(2);
            this.radCancelled.Name = "radCancelled";
            this.radCancelled.Size = new System.Drawing.Size(126, 17);
            this.radCancelled.TabIndex = 1;
            this.radCancelled.Text = "Expired no driver only";
            this.radCancelled.UseVisualStyleBackColor = true;
            this.radCancelled.CheckedChanged += new System.EventHandler(this.radExpired_CheckedChanged);
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Checked = true;
            this.radAll.Location = new System.Drawing.Point(25, 15);
            this.radAll.Margin = new System.Windows.Forms.Padding(2);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(36, 17);
            this.radAll.TabIndex = 0;
            this.radAll.TabStop = true;
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // gbJobsView
            // 
            this.gbJobsView.Controls.Add(this.radByClient);
            this.gbJobsView.Controls.Add(this.radByDriver);
            this.gbJobsView.Controls.Add(this.radByDate);
            this.gbJobsView.Location = new System.Drawing.Point(14, 2);
            this.gbJobsView.Margin = new System.Windows.Forms.Padding(2);
            this.gbJobsView.Name = "gbJobsView";
            this.gbJobsView.Padding = new System.Windows.Forms.Padding(2);
            this.gbJobsView.Size = new System.Drawing.Size(295, 38);
            this.gbJobsView.TabIndex = 3;
            this.gbJobsView.TabStop = false;
            this.gbJobsView.Text = "View jobs by:";
            // 
            // radByClient
            // 
            this.radByClient.AutoSize = true;
            this.radByClient.Location = new System.Drawing.Point(207, 15);
            this.radByClient.Margin = new System.Windows.Forms.Padding(2);
            this.radByClient.Name = "radByClient";
            this.radByClient.Size = new System.Drawing.Size(66, 17);
            this.radByClient.TabIndex = 2;
            this.radByClient.Text = "By Client";
            this.radByClient.UseVisualStyleBackColor = true;
            this.radByClient.CheckedChanged += new System.EventHandler(this.radByClient_CheckedChanged);
            // 
            // radByDriver
            // 
            this.radByDriver.AutoSize = true;
            this.radByDriver.Location = new System.Drawing.Point(115, 15);
            this.radByDriver.Margin = new System.Windows.Forms.Padding(2);
            this.radByDriver.Name = "radByDriver";
            this.radByDriver.Size = new System.Drawing.Size(68, 17);
            this.radByDriver.TabIndex = 1;
            this.radByDriver.Text = "By Driver";
            this.radByDriver.UseVisualStyleBackColor = true;
            this.radByDriver.CheckedChanged += new System.EventHandler(this.radByDriver_CheckedChanged);
            // 
            // radByDate
            // 
            this.radByDate.AutoSize = true;
            this.radByDate.Checked = true;
            this.radByDate.Location = new System.Drawing.Point(25, 15);
            this.radByDate.Margin = new System.Windows.Forms.Padding(2);
            this.radByDate.Name = "radByDate";
            this.radByDate.Size = new System.Drawing.Size(63, 17);
            this.radByDate.TabIndex = 0;
            this.radByDate.TabStop = true;
            this.radByDate.Text = "By Date";
            this.radByDate.UseVisualStyleBackColor = true;
            this.radByDate.CheckedChanged += new System.EventHandler(this.radByDate_CheckedChanged);
            // 
            // tvJobs
            // 
            this.tvJobs.HideSelection = false;
            this.tvJobs.Location = new System.Drawing.Point(13, 100);
            this.tvJobs.Margin = new System.Windows.Forms.Padding(2);
            this.tvJobs.Name = "tvJobs";
            this.tvJobs.Size = new System.Drawing.Size(345, 381);
            this.tvJobs.TabIndex = 0;
            this.tvJobs.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvJobs_BeforeExpand);
            this.tvJobs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvJobs_AfterSelect);
            // 
            // gbContactOutcome
            // 
            this.gbContactOutcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gbContactOutcome.Controls.Add(this.radC5);
            this.gbContactOutcome.Controls.Add(this.radC4);
            this.gbContactOutcome.Controls.Add(this.radC3);
            this.gbContactOutcome.Controls.Add(this.radC2);
            this.gbContactOutcome.Controls.Add(this.radC1);
            this.gbContactOutcome.Controls.Add(this.radA1);
            this.gbContactOutcome.Location = new System.Drawing.Point(386, 179);
            this.gbContactOutcome.Margin = new System.Windows.Forms.Padding(2);
            this.gbContactOutcome.Name = "gbContactOutcome";
            this.gbContactOutcome.Padding = new System.Windows.Forms.Padding(2);
            this.gbContactOutcome.Size = new System.Drawing.Size(182, 192);
            this.gbContactOutcome.TabIndex = 39;
            this.gbContactOutcome.TabStop = false;
            this.gbContactOutcome.Text = "Enter job outcome:";
            // 
            // radC5
            // 
            this.radC5.AutoSize = true;
            this.radC5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radC5.Location = new System.Drawing.Point(8, 159);
            this.radC5.Margin = new System.Windows.Forms.Padding(2);
            this.radC5.Name = "radC5";
            this.radC5.Size = new System.Drawing.Size(167, 16);
            this.radC5.TabIndex = 9;
            this.radC5.Tag = "55";
            this.radC5.Text = "CANCELLED - unable to find driver";
            this.radC5.UseVisualStyleBackColor = true;
            // 
            // radC4
            // 
            this.radC4.AutoSize = true;
            this.radC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radC4.Location = new System.Drawing.Point(8, 132);
            this.radC4.Margin = new System.Windows.Forms.Padding(2);
            this.radC4.Name = "radC4";
            this.radC4.Size = new System.Drawing.Size(159, 16);
            this.radC4.TabIndex = 8;
            this.radC4.Tag = "54";
            this.radC4.Text = "CANCELLED - not enough notice";
            this.radC4.UseVisualStyleBackColor = true;
            // 
            // radC3
            // 
            this.radC3.AutoSize = true;
            this.radC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radC3.Location = new System.Drawing.Point(8, 105);
            this.radC3.Margin = new System.Windows.Forms.Padding(2);
            this.radC3.Name = "radC3";
            this.radC3.Size = new System.Drawing.Size(142, 16);
            this.radC3.TabIndex = 7;
            this.radC3.Tag = "53";
            this.radC3.Text = "CANCELLED - operator error";
            this.radC3.UseVisualStyleBackColor = true;
            // 
            // radC2
            // 
            this.radC2.AutoSize = true;
            this.radC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radC2.Location = new System.Drawing.Point(8, 78);
            this.radC2.Margin = new System.Windows.Forms.Padding(2);
            this.radC2.Name = "radC2";
            this.radC2.Size = new System.Drawing.Size(160, 16);
            this.radC2.TabIndex = 6;
            this.radC2.Tag = "52";
            this.radC2.Text = "CANCELLED - by hospital/doctor";
            this.radC2.UseVisualStyleBackColor = true;
            this.radC2.CheckedChanged += new System.EventHandler(this.radC2_CheckedChanged);
            // 
            // radC1
            // 
            this.radC1.AutoSize = true;
            this.radC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radC1.Location = new System.Drawing.Point(8, 51);
            this.radC1.Margin = new System.Windows.Forms.Padding(2);
            this.radC1.Name = "radC1";
            this.radC1.Size = new System.Drawing.Size(121, 16);
            this.radC1.TabIndex = 4;
            this.radC1.Tag = "51";
            this.radC1.Text = "CANCELLED - by client";
            this.radC1.UseVisualStyleBackColor = true;
            this.radC1.CheckedChanged += new System.EventHandler(this.radC1_CheckedChanged);
            this.radC1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.radC1_KeyDown);
            // 
            // radA1
            // 
            this.radA1.AutoSize = true;
            this.radA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radA1.Location = new System.Drawing.Point(8, 24);
            this.radA1.Margin = new System.Windows.Forms.Padding(2);
            this.radA1.Name = "radA1";
            this.radA1.Size = new System.Drawing.Size(101, 16);
            this.radA1.TabIndex = 3;
            this.radA1.Tag = "57";
            this.radA1.Text = "JOB COMPLETED";
            this.radA1.UseVisualStyleBackColor = true;
            this.radA1.CheckedChanged += new System.EventHandler(this.radA1_CheckedChanged);
            // 
            // btnCloseJob
            // 
            this.btnCloseJob.Location = new System.Drawing.Point(426, 410);
            this.btnCloseJob.Name = "btnCloseJob";
            this.btnCloseJob.Size = new System.Drawing.Size(103, 50);
            this.btnCloseJob.TabIndex = 4;
            this.btnCloseJob.Text = "Close Job";
            this.btnCloseJob.UseVisualStyleBackColor = true;
            this.btnCloseJob.Click += new System.EventHandler(this.btnCloseJob_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 164);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Leg 2 Details:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 164);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Leg 1 Details:";
            // 
            // lblAdditional
            // 
            this.lblAdditional.AutoSize = true;
            this.lblAdditional.Location = new System.Drawing.Point(202, 321);
            this.lblAdditional.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdditional.Name = "lblAdditional";
            this.lblAdditional.Size = new System.Drawing.Size(87, 13);
            this.lblAdditional.TabIndex = 32;
            this.lblAdditional.Text = "Additional Notes:";
            // 
            // rtbContactNotes
            // 
            this.rtbContactNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rtbContactNotes.ForeColor = System.Drawing.Color.Black;
            this.rtbContactNotes.Location = new System.Drawing.Point(200, 338);
            this.rtbContactNotes.Margin = new System.Windows.Forms.Padding(2);
            this.rtbContactNotes.Name = "rtbContactNotes";
            this.rtbContactNotes.Size = new System.Drawing.Size(164, 109);
            this.rtbContactNotes.TabIndex = 31;
            this.rtbContactNotes.Text = "";
            this.rtbContactNotes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rtbContactNotes_MouseClick);
            // 
            // rtbJobDetailsL2
            // 
            this.rtbJobDetailsL2.BackColor = System.Drawing.Color.White;
            this.rtbJobDetailsL2.ForeColor = System.Drawing.Color.Blue;
            this.rtbJobDetailsL2.Location = new System.Drawing.Point(200, 179);
            this.rtbJobDetailsL2.Margin = new System.Windows.Forms.Padding(2);
            this.rtbJobDetailsL2.Name = "rtbJobDetailsL2";
            this.rtbJobDetailsL2.ReadOnly = true;
            this.rtbJobDetailsL2.Size = new System.Drawing.Size(164, 122);
            this.rtbJobDetailsL2.TabIndex = 4;
            this.rtbJobDetailsL2.Text = "";
            this.rtbJobDetailsL2.TextChanged += new System.EventHandler(this.rtbJobDetailsL2_TextChanged);
            // 
            // txtJobDate
            // 
            this.txtJobDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtJobDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJobDate.Location = new System.Drawing.Point(109, 107);
            this.txtJobDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtJobDate.Name = "txtJobDate";
            this.txtJobDate.ReadOnly = true;
            this.txtJobDate.Size = new System.Drawing.Size(144, 20);
            this.txtJobDate.TabIndex = 30;
            // 
            // rtbJobDetailsL1
            // 
            this.rtbJobDetailsL1.BackColor = System.Drawing.Color.White;
            this.rtbJobDetailsL1.ForeColor = System.Drawing.Color.Blue;
            this.rtbJobDetailsL1.Location = new System.Drawing.Point(16, 179);
            this.rtbJobDetailsL1.Margin = new System.Windows.Forms.Padding(2);
            this.rtbJobDetailsL1.Name = "rtbJobDetailsL1";
            this.rtbJobDetailsL1.ReadOnly = true;
            this.rtbJobDetailsL1.Size = new System.Drawing.Size(157, 122);
            this.rtbJobDetailsL1.TabIndex = 3;
            this.rtbJobDetailsL1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Job Date:";
            // 
            // txtDriver
            // 
            this.txtDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtDriver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDriver.Location = new System.Drawing.Point(385, 81);
            this.txtDriver.Margin = new System.Windows.Forms.Padding(2);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.ReadOnly = true;
            this.txtDriver.Size = new System.Drawing.Size(144, 20);
            this.txtDriver.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(337, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Driver:";
            // 
            // txtClient
            // 
            this.txtClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClient.Location = new System.Drawing.Point(386, 55);
            this.txtClient.Margin = new System.Windows.Forms.Padding(2);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(144, 20);
            this.txtClient.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Client:";
            // 
            // lblJobNotes
            // 
            this.lblJobNotes.AutoSize = true;
            this.lblJobNotes.Location = new System.Drawing.Point(18, 321);
            this.lblJobNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJobNotes.Name = "lblJobNotes";
            this.lblJobNotes.Size = new System.Drawing.Size(58, 13);
            this.lblJobNotes.TabIndex = 21;
            this.lblJobNotes.Text = "Job Notes:";
            // 
            // rtbJobNotes
            // 
            this.rtbJobNotes.BackColor = System.Drawing.Color.White;
            this.rtbJobNotes.ForeColor = System.Drawing.Color.Blue;
            this.rtbJobNotes.Location = new System.Drawing.Point(16, 338);
            this.rtbJobNotes.Margin = new System.Windows.Forms.Padding(2);
            this.rtbJobNotes.Name = "rtbJobNotes";
            this.rtbJobNotes.ReadOnly = true;
            this.rtbJobNotes.Size = new System.Drawing.Size(157, 109);
            this.rtbJobNotes.TabIndex = 20;
            this.rtbJobNotes.Text = "";
            // 
            // txtJobID
            // 
            this.txtJobID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtJobID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJobID.Location = new System.Drawing.Point(109, 55);
            this.txtJobID.Margin = new System.Windows.Forms.Padding(2);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.ReadOnly = true;
            this.txtJobID.Size = new System.Drawing.Size(144, 20);
            this.txtJobID.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Job ID:";
            // 
            // txtJobStatus
            // 
            this.txtJobStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtJobStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJobStatus.Location = new System.Drawing.Point(109, 81);
            this.txtJobStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtJobStatus.Name = "txtJobStatus";
            this.txtJobStatus.ReadOnly = true;
            this.txtJobStatus.Size = new System.Drawing.Size(144, 20);
            this.txtJobStatus.TabIndex = 17;
            // 
            // lblJobStatusPrefix
            // 
            this.lblJobStatusPrefix.AutoSize = true;
            this.lblJobStatusPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobStatusPrefix.Location = new System.Drawing.Point(37, 85);
            this.lblJobStatusPrefix.Name = "lblJobStatusPrefix";
            this.lblJobStatusPrefix.Size = new System.Drawing.Size(47, 13);
            this.lblJobStatusPrefix.TabIndex = 16;
            this.lblJobStatusPrefix.Text = "Status:";
            // 
            // frmJobQueueExpired
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 524);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmJobQueueExpired";
            this.Text = "frmJobQueueExpired";
            this.Load += new System.EventHandler(this.frmJobQueueExpired_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbViewAll.ResumeLayout(false);
            this.gbViewAll.PerformLayout();
            this.gbJobsView.ResumeLayout(false);
            this.gbJobsView.PerformLayout();
            this.gbContactOutcome.ResumeLayout(false);
            this.gbContactOutcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imgIcons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvJobs;
        private System.Windows.Forms.TextBox txtJobDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDriver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbJobDetailsL1;
        private System.Windows.Forms.RichTextBox rtbJobDetailsL2;
        private System.Windows.Forms.Label lblJobNotes;
        private System.Windows.Forms.RichTextBox rtbJobNotes;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtJobStatus;
        private System.Windows.Forms.Label lblJobStatusPrefix;
        private System.Windows.Forms.GroupBox gbJobsView;
        private System.Windows.Forms.RadioButton radByDriver;
        private System.Windows.Forms.RadioButton radByDate;
        private System.Windows.Forms.RadioButton radByClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAdditional;
        private System.Windows.Forms.RichTextBox rtbContactNotes;
        private System.Windows.Forms.Button btnCloseJob;
        private System.Windows.Forms.GroupBox gbViewAll;
        private System.Windows.Forms.RadioButton radCancelled;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.GroupBox gbContactOutcome;
        private System.Windows.Forms.RadioButton radC5;
        private System.Windows.Forms.RadioButton radC4;
        private System.Windows.Forms.RadioButton radC3;
        private System.Windows.Forms.RadioButton radC2;
        private System.Windows.Forms.RadioButton radC1;
        private System.Windows.Forms.RadioButton radA1;
    }
}