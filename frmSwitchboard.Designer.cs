namespace TransManager
{
    partial class frmSwitchboard
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
            this.Configuration = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.rtbLicenceExpire = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbInsuranceExpire = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbJobSummary = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLicenceExpiry = new System.Windows.Forms.Button();
            this.btnInsuranceExpiry = new System.Windows.Forms.Button();
            this.btnDriverAdd = new System.Windows.Forms.Button();
            this.btnDriverEdit = new System.Windows.Forms.Button();
            this.gbClients = new System.Windows.Forms.GroupBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnJobsExpired = new System.Windows.Forms.Button();
            this.btnJobQueue = new System.Windows.Forms.Button();
            this.btnJobEdit = new System.Windows.Forms.Button();
            this.btnJobAdd = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnJobStatus = new System.Windows.Forms.Button();
            this.btnDriverAttributes = new System.Windows.Forms.Button();
            this.btnTitles = new System.Windows.Forms.Button();
            this.btnCarMake = new System.Windows.Forms.Button();
            this.btnCarType = new System.Windows.Forms.Button();
            this.tabDestination = new System.Windows.Forms.TabPage();
            this.gbDestination = new System.Windows.Forms.GroupBox();
            this.btnDestinationCategory = new System.Windows.Forms.Button();
            this.btnDestDelete = new System.Windows.Forms.Button();
            this.btnDestUpdate = new System.Windows.Forms.Button();
            this.btnDestAdd = new System.Windows.Forms.Button();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.btnSetScale = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.tbFontSize = new System.Windows.Forms.TrackBar();
            this.lblScaleHeight = new System.Windows.Forms.Label();
            this.tbScaleHeight = new System.Windows.Forms.TrackBar();
            this.lblScaleWidth = new System.Windows.Forms.Label();
            this.tbScaleWidth = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Configuration.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbClients.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabDestination.SuspendLayout();
            this.gbDestination.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // Configuration
            // 
            this.Configuration.Controls.Add(this.tabInfo);
            this.Configuration.Controls.Add(this.tabPage1);
            this.Configuration.Controls.Add(this.tabPage2);
            this.Configuration.Controls.Add(this.tabPage3);
            this.Configuration.Controls.Add(this.tabDestination);
            this.Configuration.Controls.Add(this.tabConfig);
            this.Configuration.Location = new System.Drawing.Point(31, 71);
            this.Configuration.Margin = new System.Windows.Forms.Padding(4);
            this.Configuration.Name = "Configuration";
            this.Configuration.SelectedIndex = 0;
            this.Configuration.Size = new System.Drawing.Size(569, 386);
            this.Configuration.TabIndex = 1;
            // 
            // tabInfo
            // 
            this.tabInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabInfo.Controls.Add(this.rtbLicenceExpire);
            this.tabInfo.Controls.Add(this.label5);
            this.tabInfo.Controls.Add(this.rtbInsuranceExpire);
            this.tabInfo.Controls.Add(this.label4);
            this.tabInfo.Controls.Add(this.label2);
            this.tabInfo.Controls.Add(this.rtbJobSummary);
            this.tabInfo.Location = new System.Drawing.Point(4, 26);
            this.tabInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Size = new System.Drawing.Size(561, 356);
            this.tabInfo.TabIndex = 4;
            this.tabInfo.Text = "Info";
            this.tabInfo.Click += new System.EventHandler(this.tabInfo_Click);
            // 
            // rtbLicenceExpire
            // 
            this.rtbLicenceExpire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rtbLicenceExpire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLicenceExpire.ForeColor = System.Drawing.Color.Blue;
            this.rtbLicenceExpire.Location = new System.Drawing.Point(275, 201);
            this.rtbLicenceExpire.Margin = new System.Windows.Forms.Padding(4);
            this.rtbLicenceExpire.Name = "rtbLicenceExpire";
            this.rtbLicenceExpire.Size = new System.Drawing.Size(251, 130);
            this.rtbLicenceExpire.TabIndex = 13;
            this.rtbLicenceExpire.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pending Licence Expiries:";
            // 
            // rtbInsuranceExpire
            // 
            this.rtbInsuranceExpire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rtbInsuranceExpire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInsuranceExpire.ForeColor = System.Drawing.Color.Blue;
            this.rtbInsuranceExpire.Location = new System.Drawing.Point(275, 39);
            this.rtbInsuranceExpire.Margin = new System.Windows.Forms.Padding(4);
            this.rtbInsuranceExpire.Name = "rtbInsuranceExpire";
            this.rtbInsuranceExpire.Size = new System.Drawing.Size(251, 123);
            this.rtbInsuranceExpire.TabIndex = 11;
            this.rtbInsuranceExpire.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pending Insurance Expiries:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Job Summary:";
            // 
            // rtbJobSummary
            // 
            this.rtbJobSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rtbJobSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbJobSummary.ForeColor = System.Drawing.Color.Blue;
            this.rtbJobSummary.Location = new System.Drawing.Point(25, 39);
            this.rtbJobSummary.Margin = new System.Windows.Forms.Padding(4);
            this.rtbJobSummary.Name = "rtbJobSummary";
            this.rtbJobSummary.Size = new System.Drawing.Size(223, 292);
            this.rtbJobSummary.TabIndex = 8;
            this.rtbJobSummary.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gbClients);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(561, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clients & Drivers";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLicenceExpiry);
            this.groupBox1.Controls.Add(this.btnInsuranceExpiry);
            this.groupBox1.Controls.Add(this.btnDriverAdd);
            this.groupBox1.Controls.Add(this.btnDriverEdit);
            this.groupBox1.Location = new System.Drawing.Point(281, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(208, 281);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drivers";
            // 
            // btnLicenceExpiry
            // 
            this.btnLicenceExpiry.Location = new System.Drawing.Point(26, 215);
            this.btnLicenceExpiry.Margin = new System.Windows.Forms.Padding(4);
            this.btnLicenceExpiry.Name = "btnLicenceExpiry";
            this.btnLicenceExpiry.Size = new System.Drawing.Size(157, 30);
            this.btnLicenceExpiry.TabIndex = 9;
            this.btnLicenceExpiry.Text = "Licence Expiry";
            this.btnLicenceExpiry.UseVisualStyleBackColor = true;
            this.btnLicenceExpiry.Click += new System.EventHandler(this.btnLicenceExpiry_Click);
            // 
            // btnInsuranceExpiry
            // 
            this.btnInsuranceExpiry.Location = new System.Drawing.Point(25, 157);
            this.btnInsuranceExpiry.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsuranceExpiry.Name = "btnInsuranceExpiry";
            this.btnInsuranceExpiry.Size = new System.Drawing.Size(157, 30);
            this.btnInsuranceExpiry.TabIndex = 8;
            this.btnInsuranceExpiry.Text = "Insurance Expiry";
            this.btnInsuranceExpiry.UseVisualStyleBackColor = true;
            this.btnInsuranceExpiry.Click += new System.EventHandler(this.btnInsuranceExpiry_Click);
            // 
            // btnDriverAdd
            // 
            this.btnDriverAdd.Location = new System.Drawing.Point(25, 41);
            this.btnDriverAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnDriverAdd.Name = "btnDriverAdd";
            this.btnDriverAdd.Size = new System.Drawing.Size(157, 30);
            this.btnDriverAdd.TabIndex = 1;
            this.btnDriverAdd.Text = "Add Driver";
            this.btnDriverAdd.UseVisualStyleBackColor = true;
            this.btnDriverAdd.Click += new System.EventHandler(this.btnDriverAdd_Click);
            // 
            // btnDriverEdit
            // 
            this.btnDriverEdit.Location = new System.Drawing.Point(25, 99);
            this.btnDriverEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnDriverEdit.Name = "btnDriverEdit";
            this.btnDriverEdit.Size = new System.Drawing.Size(157, 30);
            this.btnDriverEdit.TabIndex = 2;
            this.btnDriverEdit.Text = "Edit Driver";
            this.btnDriverEdit.UseVisualStyleBackColor = true;
            this.btnDriverEdit.Click += new System.EventHandler(this.btnDriverEdit_Click);
            // 
            // gbClients
            // 
            this.gbClients.Controls.Add(this.btnAddClient);
            this.gbClients.Controls.Add(this.btnEditClient);
            this.gbClients.Location = new System.Drawing.Point(29, 31);
            this.gbClients.Margin = new System.Windows.Forms.Padding(4);
            this.gbClients.Name = "gbClients";
            this.gbClients.Padding = new System.Windows.Forms.Padding(4);
            this.gbClients.Size = new System.Drawing.Size(208, 281);
            this.gbClients.TabIndex = 3;
            this.gbClients.TabStop = false;
            this.gbClients.Text = "Clients";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(25, 43);
            this.btnAddClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(157, 30);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(25, 99);
            this.btnEditClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(157, 30);
            this.btnEditClient.TabIndex = 2;
            this.btnEditClient.Text = "Edit Client";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.btnJobsExpired);
            this.tabPage2.Controls.Add(this.btnJobQueue);
            this.tabPage2.Controls.Add(this.btnJobEdit);
            this.tabPage2.Controls.Add(this.btnJobAdd);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(561, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Jobs";
            // 
            // btnJobsExpired
            // 
            this.btnJobsExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobsExpired.Location = new System.Drawing.Point(200, 88);
            this.btnJobsExpired.Margin = new System.Windows.Forms.Padding(4);
            this.btnJobsExpired.Name = "btnJobsExpired";
            this.btnJobsExpired.Size = new System.Drawing.Size(157, 46);
            this.btnJobsExpired.TabIndex = 5;
            this.btnJobsExpired.Text = "View Expired/Cancelled Jobs";
            this.btnJobsExpired.UseVisualStyleBackColor = true;
            this.btnJobsExpired.Click += new System.EventHandler(this.btnJobsExpired_Click);
            // 
            // btnJobQueue
            // 
            this.btnJobQueue.Location = new System.Drawing.Point(200, 43);
            this.btnJobQueue.Margin = new System.Windows.Forms.Padding(4);
            this.btnJobQueue.Name = "btnJobQueue";
            this.btnJobQueue.Size = new System.Drawing.Size(157, 30);
            this.btnJobQueue.TabIndex = 4;
            this.btnJobQueue.Text = "Manage Queue";
            this.btnJobQueue.UseVisualStyleBackColor = true;
            this.btnJobQueue.Click += new System.EventHandler(this.btnJobQueue_Click);
            // 
            // btnJobEdit
            // 
            this.btnJobEdit.Location = new System.Drawing.Point(35, 94);
            this.btnJobEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnJobEdit.Name = "btnJobEdit";
            this.btnJobEdit.Size = new System.Drawing.Size(157, 30);
            this.btnJobEdit.TabIndex = 3;
            this.btnJobEdit.Text = "Edit Job";
            this.btnJobEdit.UseVisualStyleBackColor = true;
            this.btnJobEdit.Click += new System.EventHandler(this.btnJobEdit_Click);
            // 
            // btnJobAdd
            // 
            this.btnJobAdd.Location = new System.Drawing.Point(35, 43);
            this.btnJobAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnJobAdd.Name = "btnJobAdd";
            this.btnJobAdd.Size = new System.Drawing.Size(157, 30);
            this.btnJobAdd.TabIndex = 2;
            this.btnJobAdd.Text = "Add Job";
            this.btnJobAdd.UseVisualStyleBackColor = true;
            this.btnJobAdd.Click += new System.EventHandler(this.btnJobAdd_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(561, 356);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Maintenance";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnJobStatus);
            this.groupBox2.Controls.Add(this.btnDriverAttributes);
            this.groupBox2.Controls.Add(this.btnTitles);
            this.groupBox2.Controls.Add(this.btnCarMake);
            this.groupBox2.Controls.Add(this.btnCarType);
            this.groupBox2.Location = new System.Drawing.Point(8, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(427, 310);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pull down lists";
            // 
            // btnJobStatus
            // 
            this.btnJobStatus.Location = new System.Drawing.Point(213, 41);
            this.btnJobStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnJobStatus.Name = "btnJobStatus";
            this.btnJobStatus.Size = new System.Drawing.Size(157, 30);
            this.btnJobStatus.TabIndex = 5;
            this.btnJobStatus.Text = "Job Status";
            this.btnJobStatus.UseVisualStyleBackColor = true;
            this.btnJobStatus.Click += new System.EventHandler(this.btnJobStatus_Click);
            // 
            // btnDriverAttributes
            // 
            this.btnDriverAttributes.Location = new System.Drawing.Point(25, 213);
            this.btnDriverAttributes.Margin = new System.Windows.Forms.Padding(4);
            this.btnDriverAttributes.Name = "btnDriverAttributes";
            this.btnDriverAttributes.Size = new System.Drawing.Size(157, 30);
            this.btnDriverAttributes.TabIndex = 3;
            this.btnDriverAttributes.Text = "Driver Attributes";
            this.btnDriverAttributes.UseVisualStyleBackColor = true;
            this.btnDriverAttributes.Visible = false;
            this.btnDriverAttributes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTitles
            // 
            this.btnTitles.Location = new System.Drawing.Point(25, 41);
            this.btnTitles.Margin = new System.Windows.Forms.Padding(4);
            this.btnTitles.Name = "btnTitles";
            this.btnTitles.Size = new System.Drawing.Size(157, 30);
            this.btnTitles.TabIndex = 0;
            this.btnTitles.Text = "Titles";
            this.btnTitles.UseVisualStyleBackColor = true;
            this.btnTitles.Click += new System.EventHandler(this.btnTitles_Click);
            // 
            // btnCarMake
            // 
            this.btnCarMake.Location = new System.Drawing.Point(25, 98);
            this.btnCarMake.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarMake.Name = "btnCarMake";
            this.btnCarMake.Size = new System.Drawing.Size(157, 30);
            this.btnCarMake.TabIndex = 1;
            this.btnCarMake.Text = "Car Make";
            this.btnCarMake.UseVisualStyleBackColor = true;
            this.btnCarMake.Click += new System.EventHandler(this.btnCarMake_Click);
            // 
            // btnCarType
            // 
            this.btnCarType.Location = new System.Drawing.Point(25, 156);
            this.btnCarType.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarType.Name = "btnCarType";
            this.btnCarType.Size = new System.Drawing.Size(157, 30);
            this.btnCarType.TabIndex = 2;
            this.btnCarType.Text = "Car Model";
            this.btnCarType.UseVisualStyleBackColor = true;
            this.btnCarType.Click += new System.EventHandler(this.btnCarType_Click);
            // 
            // tabDestination
            // 
            this.tabDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabDestination.Controls.Add(this.gbDestination);
            this.tabDestination.Location = new System.Drawing.Point(4, 26);
            this.tabDestination.Margin = new System.Windows.Forms.Padding(4);
            this.tabDestination.Name = "tabDestination";
            this.tabDestination.Padding = new System.Windows.Forms.Padding(4);
            this.tabDestination.Size = new System.Drawing.Size(561, 356);
            this.tabDestination.TabIndex = 3;
            this.tabDestination.Text = "Destinations";
            // 
            // gbDestination
            // 
            this.gbDestination.Controls.Add(this.btnDestinationCategory);
            this.gbDestination.Controls.Add(this.btnDestDelete);
            this.gbDestination.Controls.Add(this.btnDestUpdate);
            this.gbDestination.Controls.Add(this.btnDestAdd);
            this.gbDestination.Location = new System.Drawing.Point(27, 27);
            this.gbDestination.Margin = new System.Windows.Forms.Padding(4);
            this.gbDestination.Name = "gbDestination";
            this.gbDestination.Padding = new System.Windows.Forms.Padding(4);
            this.gbDestination.Size = new System.Drawing.Size(197, 300);
            this.gbDestination.TabIndex = 0;
            this.gbDestination.TabStop = false;
            this.gbDestination.Text = "Destinations:";
            // 
            // btnDestinationCategory
            // 
            this.btnDestinationCategory.Location = new System.Drawing.Point(10, 222);
            this.btnDestinationCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnDestinationCategory.Name = "btnDestinationCategory";
            this.btnDestinationCategory.Size = new System.Drawing.Size(157, 51);
            this.btnDestinationCategory.TabIndex = 5;
            this.btnDestinationCategory.Text = "Destination Categories";
            this.btnDestinationCategory.UseVisualStyleBackColor = true;
            this.btnDestinationCategory.Click += new System.EventHandler(this.btnDestinationCategory_Click);
            // 
            // btnDestDelete
            // 
            this.btnDestDelete.Location = new System.Drawing.Point(8, 170);
            this.btnDestDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDestDelete.Name = "btnDestDelete";
            this.btnDestDelete.Size = new System.Drawing.Size(159, 30);
            this.btnDestDelete.TabIndex = 2;
            this.btnDestDelete.Text = "Delete Destination";
            this.btnDestDelete.UseVisualStyleBackColor = true;
            this.btnDestDelete.Click += new System.EventHandler(this.btnDestDelete_Click);
            // 
            // btnDestUpdate
            // 
            this.btnDestUpdate.Location = new System.Drawing.Point(8, 106);
            this.btnDestUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnDestUpdate.Name = "btnDestUpdate";
            this.btnDestUpdate.Size = new System.Drawing.Size(159, 30);
            this.btnDestUpdate.TabIndex = 1;
            this.btnDestUpdate.Text = "Update Destination";
            this.btnDestUpdate.UseVisualStyleBackColor = true;
            this.btnDestUpdate.Click += new System.EventHandler(this.btnDestUpdate_Click);
            // 
            // btnDestAdd
            // 
            this.btnDestAdd.Location = new System.Drawing.Point(8, 39);
            this.btnDestAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnDestAdd.Name = "btnDestAdd";
            this.btnDestAdd.Size = new System.Drawing.Size(159, 30);
            this.btnDestAdd.TabIndex = 0;
            this.btnDestAdd.Text = "Add Destination";
            this.btnDestAdd.UseVisualStyleBackColor = true;
            this.btnDestAdd.Click += new System.EventHandler(this.btnDestAdd_Click);
            // 
            // tabConfig
            // 
            this.tabConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabConfig.Controls.Add(this.btnSetScale);
            this.tabConfig.Controls.Add(this.btnLogin);
            this.tabConfig.Controls.Add(this.groupBox3);
            this.tabConfig.Location = new System.Drawing.Point(4, 26);
            this.tabConfig.Margin = new System.Windows.Forms.Padding(4);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(4);
            this.tabConfig.Size = new System.Drawing.Size(561, 356);
            this.tabConfig.TabIndex = 5;
            this.tabConfig.Text = "Configuration";
            // 
            // btnSetScale
            // 
            this.btnSetScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetScale.Location = new System.Drawing.Point(202, 280);
            this.btnSetScale.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetScale.Name = "btnSetScale";
            this.btnSetScale.Size = new System.Drawing.Size(157, 39);
            this.btnSetScale.TabIndex = 7;
            this.btnSetScale.Text = "Save settings as default";
            this.btnSetScale.UseVisualStyleBackColor = true;
            this.btnSetScale.Click += new System.EventHandler(this.btnSetScale_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(20, 22);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(157, 30);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "User Logins";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblFontSize);
            this.groupBox3.Controls.Add(this.tbFontSize);
            this.groupBox3.Controls.Add(this.lblScaleHeight);
            this.groupBox3.Controls.Add(this.tbScaleHeight);
            this.groupBox3.Controls.Add(this.lblScaleWidth);
            this.groupBox3.Controls.Add(this.tbScaleWidth);
            this.groupBox3.Location = new System.Drawing.Point(19, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 262);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Set sizing of forms and text";
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Location = new System.Drawing.Point(26, 148);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(119, 17);
            this.lblFontSize.TabIndex = 10;
            this.lblFontSize.Text = "Font Size = 100%";
            // 
            // tbFontSize
            // 
            this.tbFontSize.Location = new System.Drawing.Point(40, 172);
            this.tbFontSize.Margin = new System.Windows.Forms.Padding(4);
            this.tbFontSize.Maximum = 200;
            this.tbFontSize.Minimum = 50;
            this.tbFontSize.Name = "tbFontSize";
            this.tbFontSize.Size = new System.Drawing.Size(439, 45);
            this.tbFontSize.TabIndex = 9;
            this.tbFontSize.Value = 100;
            this.tbFontSize.Scroll += new System.EventHandler(this.tbFontSize_Scroll);
            // 
            // lblScaleHeight
            // 
            this.lblScaleHeight.AutoSize = true;
            this.lblScaleHeight.Location = new System.Drawing.Point(27, 91);
            this.lblScaleHeight.Name = "lblScaleHeight";
            this.lblScaleHeight.Size = new System.Drawing.Size(138, 17);
            this.lblScaleHeight.TabIndex = 8;
            this.lblScaleHeight.Text = "Scale height = 100%";
            // 
            // tbScaleHeight
            // 
            this.tbScaleHeight.Location = new System.Drawing.Point(41, 114);
            this.tbScaleHeight.Margin = new System.Windows.Forms.Padding(4);
            this.tbScaleHeight.Maximum = 200;
            this.tbScaleHeight.Minimum = 50;
            this.tbScaleHeight.Name = "tbScaleHeight";
            this.tbScaleHeight.Size = new System.Drawing.Size(439, 45);
            this.tbScaleHeight.TabIndex = 7;
            this.tbScaleHeight.Value = 100;
            this.tbScaleHeight.Scroll += new System.EventHandler(this.tbScaleHeight_Scroll);
            // 
            // lblScaleWidth
            // 
            this.lblScaleWidth.AutoSize = true;
            this.lblScaleWidth.Location = new System.Drawing.Point(27, 25);
            this.lblScaleWidth.Name = "lblScaleWidth";
            this.lblScaleWidth.Size = new System.Drawing.Size(131, 17);
            this.lblScaleWidth.TabIndex = 6;
            this.lblScaleWidth.Text = "Scale width = 100%";
            // 
            // tbScaleWidth
            // 
            this.tbScaleWidth.Location = new System.Drawing.Point(41, 47);
            this.tbScaleWidth.Margin = new System.Windows.Forms.Padding(4);
            this.tbScaleWidth.Maximum = 200;
            this.tbScaleWidth.Minimum = 50;
            this.tbScaleWidth.Name = "tbScaleWidth";
            this.tbScaleWidth.Size = new System.Drawing.Size(438, 45);
            this.tbScaleWidth.TabIndex = 5;
            this.tbScaleWidth.Value = 100;
            this.tbScaleWidth.Scroll += new System.EventHandler(this.tbScaleWidth_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(535, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "version 1.2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(60, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Didcot Volunteer Services";
            // 
            // frmSwitchboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(641, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Configuration);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSwitchboard";
            this.Text = "DVC Transport Manager";
            this.Activated += new System.EventHandler(this.frmSwitchboard_Activated);
            this.Load += new System.EventHandler(this.Switchboard_Load);
            this.Configuration.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbClients.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabDestination.ResumeLayout(false);
            this.gbDestination.ResumeLayout(false);
            this.tabConfig.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private contactDataSet contactDataSet;
        //private TransManager.contactDataSetTableAdapters.clinical_emptyTableAdapter clinical_emptyTableAdapter;
        //private TransManager.contactDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        //private TransManager.contactDataSetTableAdapters.consultantsTableAdapter consultantsTableAdapter;
        //private TransManager.contactDataSetTableAdapters.detailsTableAdapter detailsTableAdapter;
        private System.Windows.Forms.TabControl Configuration;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDriverAdd;
        private System.Windows.Forms.Button btnDriverEdit;
        private System.Windows.Forms.GroupBox gbClients;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTitles;
        private System.Windows.Forms.Button btnCarMake;
        private System.Windows.Forms.Button btnCarType;
        private System.Windows.Forms.Button btnDriverAttributes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabDestination;
        private System.Windows.Forms.GroupBox gbDestination;
        private System.Windows.Forms.Button btnDestUpdate;
        private System.Windows.Forms.Button btnDestAdd;
        private System.Windows.Forms.Button btnDestDelete;
        private System.Windows.Forms.Button btnJobAdd;
        private System.Windows.Forms.Button btnJobEdit;
        private System.Windows.Forms.Button btnJobStatus;
        private System.Windows.Forms.Button btnJobQueue;
        private System.Windows.Forms.Button btnJobsExpired;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbJobSummary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbInsuranceExpire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbLicenceExpire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblScaleHeight;
        private System.Windows.Forms.TrackBar tbScaleHeight;
        private System.Windows.Forms.Label lblScaleWidth;
        private System.Windows.Forms.TrackBar tbScaleWidth;
        private System.Windows.Forms.Button btnInsuranceExpiry;
        private System.Windows.Forms.Button btnLicenceExpiry;
        private System.Windows.Forms.Button btnDestinationCategory;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.TrackBar tbFontSize;
        private System.Windows.Forms.Button btnSetScale;
    }
}

