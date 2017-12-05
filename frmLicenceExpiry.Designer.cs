namespace TransManager
{
    partial class frmLicenceExpiry
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
            this.cboDriver = new System.Windows.Forms.ComboBox();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.gbDriverContact = new System.Windows.Forms.GroupBox();
            this.rad46 = new System.Windows.Forms.RadioButton();
            this.rad45 = new System.Windows.Forms.RadioButton();
            this.rad44 = new System.Windows.Forms.RadioButton();
            this.gbDriverPhone = new System.Windows.Forms.GroupBox();
            this.radPhoneOther = new System.Windows.Forms.RadioButton();
            this.radPhoneMobile = new System.Windows.Forms.RadioButton();
            this.radPhoneHome = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbEdit.SuspendLayout();
            this.gbDriverContact.SuspendLayout();
            this.gbDriverPhone.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboDriver
            // 
            this.cboDriver.FormattingEnabled = true;
            this.cboDriver.Location = new System.Drawing.Point(20, 19);
            this.cboDriver.Name = "cboDriver";
            this.cboDriver.Size = new System.Drawing.Size(200, 21);
            this.cboDriver.TabIndex = 0;
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.gbDriverContact);
            this.gbEdit.Controls.Add(this.gbDriverPhone);
            this.gbEdit.Controls.Add(this.cboDriver);
            this.gbEdit.Location = new System.Drawing.Point(26, 52);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(232, 331);
            this.gbEdit.TabIndex = 3;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Edit/Delete Existing entry:";
            // 
            // gbDriverContact
            // 
            this.gbDriverContact.Controls.Add(this.rad46);
            this.gbDriverContact.Controls.Add(this.rad45);
            this.gbDriverContact.Controls.Add(this.rad44);
            this.gbDriverContact.Location = new System.Drawing.Point(33, 69);
            this.gbDriverContact.Margin = new System.Windows.Forms.Padding(2);
            this.gbDriverContact.Name = "gbDriverContact";
            this.gbDriverContact.Padding = new System.Windows.Forms.Padding(2);
            this.gbDriverContact.Size = new System.Drawing.Size(166, 107);
            this.gbDriverContact.TabIndex = 36;
            this.gbDriverContact.TabStop = false;
            this.gbDriverContact.Text = "Enter contact outcome:";
            // 
            // rad46
            // 
            this.rad46.AutoSize = true;
            this.rad46.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad46.Location = new System.Drawing.Point(8, 73);
            this.rad46.Margin = new System.Windows.Forms.Padding(2);
            this.rad46.Name = "rad46";
            this.rad46.Size = new System.Drawing.Size(110, 16);
            this.rad46.TabIndex = 7;
            this.rad46.TabStop = true;
            this.rad46.Tag = "46";
            this.rad46.Text = "Answered - Informed";
            this.rad46.UseVisualStyleBackColor = true;
            // 
            // rad45
            // 
            this.rad45.AutoSize = true;
            this.rad45.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad45.Location = new System.Drawing.Point(8, 47);
            this.rad45.Margin = new System.Windows.Forms.Padding(2);
            this.rad45.Name = "rad45";
            this.rad45.Size = new System.Drawing.Size(62, 16);
            this.rad45.TabIndex = 6;
            this.rad45.TabStop = true;
            this.rad45.Tag = "45";
            this.rad45.Text = "Text Sent";
            this.rad45.UseVisualStyleBackColor = true;
            // 
            // rad44
            // 
            this.rad44.AutoSize = true;
            this.rad44.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad44.Location = new System.Drawing.Point(8, 21);
            this.rad44.Margin = new System.Windows.Forms.Padding(2);
            this.rad44.Name = "rad44";
            this.rad44.Size = new System.Drawing.Size(137, 16);
            this.rad44.TabIndex = 1;
            this.rad44.TabStop = true;
            this.rad44.Tag = "44";
            this.rad44.Text = "Unanswered - Message left";
            this.rad44.UseVisualStyleBackColor = true;
            // 
            // gbDriverPhone
            // 
            this.gbDriverPhone.Controls.Add(this.radPhoneOther);
            this.gbDriverPhone.Controls.Add(this.radPhoneMobile);
            this.gbDriverPhone.Controls.Add(this.radPhoneHome);
            this.gbDriverPhone.Location = new System.Drawing.Point(33, 196);
            this.gbDriverPhone.Name = "gbDriverPhone";
            this.gbDriverPhone.Size = new System.Drawing.Size(166, 107);
            this.gbDriverPhone.TabIndex = 37;
            this.gbDriverPhone.TabStop = false;
            this.gbDriverPhone.Text = "Contact driver on:";
            // 
            // radPhoneOther
            // 
            this.radPhoneOther.AutoSize = true;
            this.radPhoneOther.Location = new System.Drawing.Point(8, 72);
            this.radPhoneOther.Name = "radPhoneOther";
            this.radPhoneOther.Size = new System.Drawing.Size(122, 17);
            this.radPhoneOther.TabIndex = 2;
            this.radPhoneOther.TabStop = true;
            this.radPhoneOther.Tag = "*";
            this.radPhoneOther.Text = "other (enter in notes)";
            this.radPhoneOther.UseVisualStyleBackColor = true;
            // 
            // radPhoneMobile
            // 
            this.radPhoneMobile.AutoSize = true;
            this.radPhoneMobile.Location = new System.Drawing.Point(8, 44);
            this.radPhoneMobile.Name = "radPhoneMobile";
            this.radPhoneMobile.Size = new System.Drawing.Size(88, 17);
            this.radPhoneMobile.TabIndex = 1;
            this.radPhoneMobile.TabStop = true;
            this.radPhoneMobile.Tag = "M";
            this.radPhoneMobile.Text = "mobile phone";
            this.radPhoneMobile.UseVisualStyleBackColor = true;
            // 
            // radPhoneHome
            // 
            this.radPhoneHome.AutoSize = true;
            this.radPhoneHome.Location = new System.Drawing.Point(8, 16);
            this.radPhoneHome.Name = "radPhoneHome";
            this.radPhoneHome.Size = new System.Drawing.Size(84, 17);
            this.radPhoneHome.TabIndex = 0;
            this.radPhoneHome.TabStop = true;
            this.radPhoneHome.Tag = "H";
            this.radPhoneHome.Text = "home phone";
            this.radPhoneHome.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(281, 69);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 38);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Confirm contact made";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmLicenceExpiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 406);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbEdit);
            this.Name = "frmLicenceExpiry";
            this.Text = "Expiry Contact";
            this.Load += new System.EventHandler(this.frmLicenceExpiry_Load);
            this.gbEdit.ResumeLayout(false);
            this.gbDriverContact.ResumeLayout(false);
            this.gbDriverContact.PerformLayout();
            this.gbDriverPhone.ResumeLayout(false);
            this.gbDriverPhone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboDriver;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbDriverContact;
        private System.Windows.Forms.RadioButton rad46;
        private System.Windows.Forms.RadioButton rad45;
        private System.Windows.Forms.RadioButton rad44;
        private System.Windows.Forms.GroupBox gbDriverPhone;
        private System.Windows.Forms.RadioButton radPhoneOther;
        private System.Windows.Forms.RadioButton radPhoneMobile;
        private System.Windows.Forms.RadioButton radPhoneHome;
    }
}