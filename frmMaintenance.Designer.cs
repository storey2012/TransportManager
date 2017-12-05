namespace TransManager
{
    partial class frmMaintenance
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
            this.cboChooser = new System.Windows.Forms.ComboBox();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.radEdit = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbEdit.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbAdd.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboChooser
            // 
            this.cboChooser.FormattingEnabled = true;
            this.cboChooser.Location = new System.Drawing.Point(20, 19);
            this.cboChooser.Name = "cboChooser";
            this.cboChooser.Size = new System.Drawing.Size(200, 21);
            this.cboChooser.TabIndex = 0;
            this.cboChooser.SelectedIndexChanged += new System.EventHandler(this.cboChooser_SelectedIndexChanged);
            // 
            // txtEdit
            // 
            this.txtEdit.Enabled = false;
            this.txtEdit.Location = new System.Drawing.Point(20, 57);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(200, 20);
            this.txtEdit.TabIndex = 1;
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.panel1);
            this.gbEdit.Controls.Add(this.cboChooser);
            this.gbEdit.Controls.Add(this.txtEdit);
            this.gbEdit.Location = new System.Drawing.Point(80, 16);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(232, 157);
            this.gbEdit.TabIndex = 2;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Edit/Delete Existing entry:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(20, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 35);
            this.panel1.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(105, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.btnAdd);
            this.gbAdd.Controls.Add(this.txtAdd);
            this.gbAdd.Enabled = false;
            this.gbAdd.Location = new System.Drawing.Point(80, 179);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(232, 82);
            this.gbAdd.TabIndex = 0;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add a new item to the list:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(76, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(20, 19);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(200, 20);
            this.txtAdd.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.radAdd);
            this.panel2.Controls.Add(this.radEdit);
            this.panel2.Controls.Add(this.gbAdd);
            this.panel2.Controls.Add(this.gbEdit);
            this.panel2.Location = new System.Drawing.Point(22, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 274);
            this.panel2.TabIndex = 3;
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Location = new System.Drawing.Point(36, 198);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(14, 13);
            this.radAdd.TabIndex = 4;
            this.radAdd.UseVisualStyleBackColor = true;
            // 
            // radEdit
            // 
            this.radEdit.AutoSize = true;
            this.radEdit.Checked = true;
            this.radEdit.Location = new System.Drawing.Point(36, 73);
            this.radEdit.Name = "radEdit";
            this.radEdit.Size = new System.Drawing.Size(14, 13);
            this.radEdit.TabIndex = 5;
            this.radEdit.TabStop = true;
            this.radEdit.UseVisualStyleBackColor = true;
            this.radEdit.CheckedChanged += new System.EventHandler(this.radEdit_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Edit/Delete";
            // 
            // frmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 314);
            this.Controls.Add(this.panel2);
            this.Name = "frmMaintenance";
            this.Text = "PullDown Maintenance";
            this.Load += new System.EventHandler(this.frmMaintenance_Load);
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboChooser;
        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.RadioButton radEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}