namespace TransManager
{
    partial class frmDonation
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
            this.radDonationDelete = new System.Windows.Forms.RadioButton();
            this.radDonationUpdate = new System.Windows.Forms.RadioButton();
            this.radDonationAdd = new System.Windows.Forms.RadioButton();
            this.lvDonations = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.mskAmount = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlDonation = new System.Windows.Forms.Panel();
            this.txtDonationID = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDonation.SuspendLayout();
            this.SuspendLayout();
            // 
            // radDonationDelete
            // 
            this.radDonationDelete.AutoSize = true;
            this.radDonationDelete.Location = new System.Drawing.Point(179, 133);
            this.radDonationDelete.Name = "radDonationDelete";
            this.radDonationDelete.Size = new System.Drawing.Size(56, 17);
            this.radDonationDelete.TabIndex = 35;
            this.radDonationDelete.Text = "Delete";
            this.radDonationDelete.UseVisualStyleBackColor = true;
            this.radDonationDelete.CheckedChanged += new System.EventHandler(this.radDonationDelete_CheckedChanged);
            // 
            // radDonationUpdate
            // 
            this.radDonationUpdate.AutoSize = true;
            this.radDonationUpdate.Location = new System.Drawing.Point(115, 133);
            this.radDonationUpdate.Name = "radDonationUpdate";
            this.radDonationUpdate.Size = new System.Drawing.Size(60, 17);
            this.radDonationUpdate.TabIndex = 34;
            this.radDonationUpdate.Text = "Update";
            this.radDonationUpdate.UseVisualStyleBackColor = true;
            this.radDonationUpdate.CheckedChanged += new System.EventHandler(this.radDonationUpdate_CheckedChanged);
            // 
            // radDonationAdd
            // 
            this.radDonationAdd.AutoSize = true;
            this.radDonationAdd.Checked = true;
            this.radDonationAdd.Location = new System.Drawing.Point(66, 133);
            this.radDonationAdd.Name = "radDonationAdd";
            this.radDonationAdd.Size = new System.Drawing.Size(44, 17);
            this.radDonationAdd.TabIndex = 33;
            this.radDonationAdd.TabStop = true;
            this.radDonationAdd.Text = "Add";
            this.radDonationAdd.UseVisualStyleBackColor = true;
            this.radDonationAdd.CheckedChanged += new System.EventHandler(this.radDonationAdd_CheckedChanged);
            // 
            // lvDonations
            // 
            this.lvDonations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvDonations.Enabled = false;
            this.lvDonations.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDonations.FullRowSelect = true;
            this.lvDonations.GridLines = true;
            this.lvDonations.HideSelection = false;
            this.lvDonations.Location = new System.Drawing.Point(22, 11);
            this.lvDonations.Name = "lvDonations";
            this.lvDonations.Size = new System.Drawing.Size(248, 117);
            this.lvDonations.TabIndex = 32;
            this.lvDonations.UseCompatibleStateImageBehavior = false;
            this.lvDonations.View = System.Windows.Forms.View.Details;
            this.lvDonations.SelectedIndexChanged += new System.EventHandler(this.lvDonations_SelectedIndexChanged);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "ID";
            this.columnHeader0.Width = 25;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Payment Date";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Reference";
            this.columnHeader3.Width = 110;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(97, 158);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 31);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete Donation";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(11, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 62;
            this.label15.Text = "Payment Date:";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(100, 28);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(100, 20);
            this.dtpPaymentDate.TabIndex = 61;
            this.dtpPaymentDate.Value = new System.DateTime(2016, 5, 19, 0, 0, 0, 0);
            // 
            // mskAmount
            // 
            this.mskAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mskAmount.Location = new System.Drawing.Point(100, 52);
            this.mskAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskAmount.Mask = "£##0.00";
            this.mskAmount.Name = "mskAmount";
            this.mskAmount.PromptChar = ' ';
            this.mskAmount.Size = new System.Drawing.Size(101, 20);
            this.mskAmount.TabIndex = 63;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(42, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 64;
            this.label16.Text = "Amount:";
            // 
            // txtReference
            // 
            this.txtReference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtReference.Location = new System.Drawing.Point(100, 75);
            this.txtReference.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(101, 20);
            this.txtReference.TabIndex = 65;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(30, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 66;
            this.label17.Text = "Reference:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(100, 98);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 19);
            this.btnAdd.TabIndex = 67;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlDonation
            // 
            this.pnlDonation.Controls.Add(this.txtDonationID);
            this.pnlDonation.Controls.Add(this.label1);
            this.pnlDonation.Controls.Add(this.btnAdd);
            this.pnlDonation.Controls.Add(this.label17);
            this.pnlDonation.Controls.Add(this.txtReference);
            this.pnlDonation.Controls.Add(this.label16);
            this.pnlDonation.Controls.Add(this.mskAmount);
            this.pnlDonation.Controls.Add(this.dtpPaymentDate);
            this.pnlDonation.Controls.Add(this.label15);
            this.pnlDonation.Location = new System.Drawing.Point(22, 158);
            this.pnlDonation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDonation.Name = "pnlDonation";
            this.pnlDonation.Size = new System.Drawing.Size(248, 135);
            this.pnlDonation.TabIndex = 3;
            // 
            // txtDonationID
            // 
            this.txtDonationID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDonationID.Enabled = false;
            this.txtDonationID.Location = new System.Drawing.Point(100, 7);
            this.txtDonationID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonationID.Name = "txtDonationID";
            this.txtDonationID.Size = new System.Drawing.Size(101, 20);
            this.txtDonationID.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Donation ID:";
            // 
            // frmDonation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 327);
            this.Controls.Add(this.radDonationDelete);
            this.Controls.Add(this.radDonationUpdate);
            this.Controls.Add(this.radDonationAdd);
            this.Controls.Add(this.lvDonations);
            this.Controls.Add(this.pnlDonation);
            this.Controls.Add(this.btnDelete);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDonation";
            this.Text = "frmDonation";
            this.Load += new System.EventHandler(this.frmDonation_Load);
            this.pnlDonation.ResumeLayout(false);
            this.pnlDonation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radDonationDelete;
        private System.Windows.Forms.RadioButton radDonationUpdate;
        private System.Windows.Forms.RadioButton radDonationAdd;
        private System.Windows.Forms.ListView lvDonations;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.MaskedTextBox mskAmount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txtReference;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlDonation;
        private System.Windows.Forms.MaskedTextBox txtDonationID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader0;
    }
}