namespace TransManager
{
    partial class frmMaintenanceLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintenanceLogIn));
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.cboAccessLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbHelp = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUUserName = new System.Windows.Forms.TextBox();
            this.cboUpdateUser = new System.Windows.Forms.ComboBox();
            this.cboUAccessLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.gbAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.cboAccessLevel);
            this.gbAdd.Controls.Add(this.label3);
            this.gbAdd.Controls.Add(this.pbHelp);
            this.gbAdd.Controls.Add(this.label2);
            this.gbAdd.Controls.Add(this.txtPassword);
            this.gbAdd.Controls.Add(this.label1);
            this.gbAdd.Controls.Add(this.btnAdd);
            this.gbAdd.Controls.Add(this.txtUserName);
            this.gbAdd.Location = new System.Drawing.Point(28, 17);
            this.gbAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAdd.Size = new System.Drawing.Size(333, 208);
            this.gbAdd.TabIndex = 1;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add a new user";
            // 
            // cboAccessLevel
            // 
            this.cboAccessLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cboAccessLevel.FormattingEnabled = true;
            this.cboAccessLevel.Location = new System.Drawing.Point(121, 116);
            this.cboAccessLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboAccessLevel.Name = "cboAccessLevel";
            this.cboAccessLevel.Size = new System.Drawing.Size(148, 24);
            this.cboAccessLevel.TabIndex = 5;
            this.cboAccessLevel.SelectedIndexChanged += new System.EventHandler(this.cboAccessLevel_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Access Level:";
            // 
            // pbHelp
            // 
            this.pbHelp.Image = global::TransManager.Properties.Resources.QuestionMark1;
            this.pbHelp.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbHelp.InitialImage")));
            this.pbHelp.Location = new System.Drawing.Point(279, 37);
            this.pbHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.Size = new System.Drawing.Size(21, 20);
            this.pbHelp.TabIndex = 8;
            this.pbHelp.TabStop = false;
            this.pbHelp.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPassword.Location = new System.Drawing.Point(121, 75);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(148, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(121, 158);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add User";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtUserName.Location = new System.Drawing.Point(121, 34);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(148, 22);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteUser);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtUUserName);
            this.groupBox1.Controls.Add(this.cboUpdateUser);
            this.groupBox1.Controls.Add(this.cboUAccessLevel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtUPassword);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnUpdateUser);
            this.groupBox1.Location = new System.Drawing.Point(399, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(360, 254);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update/Delete user";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Enabled = false;
            this.btnDeleteUser.Location = new System.Drawing.Point(52, 201);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(105, 28);
            this.btnDeleteUser.TabIndex = 11;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "User Name:";
            // 
            // txtUUserName
            // 
            this.txtUUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtUUserName.Location = new System.Drawing.Point(123, 75);
            this.txtUUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUUserName.Name = "txtUUserName";
            this.txtUUserName.Size = new System.Drawing.Size(148, 22);
            this.txtUUserName.TabIndex = 8;
            this.txtUUserName.TextChanged += new System.EventHandler(this.txtUUserName_TextChanged);
            // 
            // cboUpdateUser
            // 
            this.cboUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cboUpdateUser.FormattingEnabled = true;
            this.cboUpdateUser.Location = new System.Drawing.Point(123, 34);
            this.cboUpdateUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboUpdateUser.Name = "cboUpdateUser";
            this.cboUpdateUser.Size = new System.Drawing.Size(148, 24);
            this.cboUpdateUser.TabIndex = 7;
            this.cboUpdateUser.SelectedIndexChanged += new System.EventHandler(this.cboUpdateUser_SelectedIndexChanged);
            // 
            // cboUAccessLevel
            // 
            this.cboUAccessLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cboUAccessLevel.FormattingEnabled = true;
            this.cboUAccessLevel.Location = new System.Drawing.Point(121, 159);
            this.cboUAccessLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboUAccessLevel.Name = "cboUAccessLevel";
            this.cboUAccessLevel.Size = new System.Drawing.Size(148, 24);
            this.cboUAccessLevel.TabIndex = 10;
            this.cboUAccessLevel.SelectedIndexChanged += new System.EventHandler(this.cboUAccessLevel_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Access Level:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password:";
            // 
            // txtUPassword
            // 
            this.txtUPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtUPassword.Location = new System.Drawing.Point(121, 116);
            this.txtUPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUPassword.Name = "txtUPassword";
            this.txtUPassword.Size = new System.Drawing.Size(148, 22);
            this.txtUPassword.TabIndex = 9;
            this.txtUPassword.TextChanged += new System.EventHandler(this.txtUPassword_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Choose User:";
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Enabled = false;
            this.btnUpdateUser.Location = new System.Drawing.Point(165, 201);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(105, 28);
            this.btnUpdateUser.TabIndex = 12;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // frmMaintenanceLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMaintenanceLogIn";
            this.Text = "frmMaintenanceLogIn";
            this.Load += new System.EventHandler(this.frmMaintenanceLogIn_Load);
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pbHelp;
        private System.Windows.Forms.ComboBox cboAccessLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboUpdateUser;
        private System.Windows.Forms.ComboBox cboUAccessLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUUserName;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}