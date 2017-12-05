namespace TransManager
{
    partial class frmDestinationAdd
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
            this.cboDestinationType = new System.Windows.Forms.ComboBox();
            this.mskPostCode = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.cboDestination = new System.Windows.Forms.ComboBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.btnAddDestType = new System.Windows.Forms.Button();
            this.txtDestinationID = new System.Windows.Forms.TextBox();
            this.gbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboDestinationType
            // 
            this.cboDestinationType.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cboDestinationType.FormattingEnabled = true;
            this.cboDestinationType.Location = new System.Drawing.Point(118, 211);
            this.cboDestinationType.Margin = new System.Windows.Forms.Padding(2);
            this.cboDestinationType.Name = "cboDestinationType";
            this.cboDestinationType.Size = new System.Drawing.Size(144, 21);
            this.cboDestinationType.TabIndex = 1;
            // 
            // mskPostCode
            // 
            this.mskPostCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mskPostCode.BeepOnError = true;
            this.mskPostCode.Location = new System.Drawing.Point(118, 179);
            this.mskPostCode.Mask = ">LCCC 9LL";
            this.mskPostCode.Name = "mskPostCode";
            this.mskPostCode.Size = new System.Drawing.Size(56, 20);
            this.mskPostCode.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destination Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Postcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtTown
            // 
            this.txtTown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTown.Location = new System.Drawing.Point(118, 147);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(144, 20);
            this.txtTown.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtName.Location = new System.Drawing.Point(118, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 20);
            this.txtName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Town";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address Line 1";
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(118, 115);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(144, 20);
            this.txtAddressLine2.TabIndex = 6;
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAddressLine1.Location = new System.Drawing.Point(118, 83);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(144, 20);
            this.txtAddressLine1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address Line 2";
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.SystemColors.Control;
            this.lblCaption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.Red;
            this.lblCaption.Location = new System.Drawing.Point(287, 58);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.lblCaption.Size = new System.Drawing.Size(85, 45);
            this.lblCaption.TabIndex = 54;
            this.lblCaption.Text = "All the yellow boxes need to be filled.";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(118, 252);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 25);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add Destination";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.cboDestination);
            this.gbDetails.Controls.Add(this.lblDestination);
            this.gbDetails.Controls.Add(this.btnAddDestType);
            this.gbDetails.Controls.Add(this.cboDestinationType);
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Controls.Add(this.lblCaption);
            this.gbDetails.Controls.Add(this.txtName);
            this.gbDetails.Controls.Add(this.mskPostCode);
            this.gbDetails.Controls.Add(this.label2);
            this.gbDetails.Controls.Add(this.label3);
            this.gbDetails.Controls.Add(this.btnAdd);
            this.gbDetails.Controls.Add(this.label8);
            this.gbDetails.Controls.Add(this.txtAddressLine1);
            this.gbDetails.Controls.Add(this.txtTown);
            this.gbDetails.Controls.Add(this.label6);
            this.gbDetails.Controls.Add(this.label7);
            this.gbDetails.Controls.Add(this.txtAddressLine2);
            this.gbDetails.Location = new System.Drawing.Point(12, 12);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(406, 283);
            this.gbDetails.TabIndex = 55;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Enter destination details:";
            // 
            // cboDestination
            // 
            this.cboDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDestination.FormattingEnabled = true;
            this.cboDestination.Location = new System.Drawing.Point(118, 18);
            this.cboDestination.Margin = new System.Windows.Forms.Padding(2);
            this.cboDestination.Name = "cboDestination";
            this.cboDestination.Size = new System.Drawing.Size(258, 20);
            this.cboDestination.TabIndex = 57;
            this.cboDestination.SelectedIndexChanged += new System.EventHandler(this.cboDestination_SelectedIndexChanged);
            this.cboDestination.SelectionChangeCommitted += new System.EventHandler(this.cboDestination_SelectionChangeCommitted);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(35, 21);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(60, 13);
            this.lblDestination.TabIndex = 56;
            this.lblDestination.Text = "Destination";
            // 
            // btnAddDestType
            // 
            this.btnAddDestType.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDestType.Location = new System.Drawing.Point(273, 211);
            this.btnAddDestType.Name = "btnAddDestType";
            this.btnAddDestType.Size = new System.Drawing.Size(103, 21);
            this.btnAddDestType.TabIndex = 55;
            this.btnAddDestType.Text = "Add Destination Type";
            this.btnAddDestType.UseVisualStyleBackColor = true;
            this.btnAddDestType.Click += new System.EventHandler(this.btnAddDestType_Click);
            // 
            // txtDestinationID
            // 
            this.txtDestinationID.Location = new System.Drawing.Point(276, 305);
            this.txtDestinationID.Name = "txtDestinationID";
            this.txtDestinationID.Size = new System.Drawing.Size(28, 20);
            this.txtDestinationID.TabIndex = 58;
            this.txtDestinationID.Visible = false;
            // 
            // frmDestinationAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 337);
            this.Controls.Add(this.txtDestinationID);
            this.Controls.Add(this.gbDetails);
            this.Name = "frmDestinationAdd";
            this.Text = "Destination Maintenance";
            this.Load += new System.EventHandler(this.frmDestinationAdd_Load);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskPostCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboDestinationType;
        private System.Windows.Forms.RichTextBox lblCaption;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Button btnAddDestType;
        private System.Windows.Forms.ComboBox cboDestination;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtDestinationID;
    }
}