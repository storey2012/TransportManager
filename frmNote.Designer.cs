namespace TransManager
{
    partial class frmNote
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
            this.lvNotes = new System.Windows.Forms.ListView();
            this.NoteID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rtxtNote = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEnteredAt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoteID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEnteredBy = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtClientDetails = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvNotes
            // 
            this.lvNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvNotes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NoteID,
            this.Note});
            this.lvNotes.FullRowSelect = true;
            this.lvNotes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvNotes.HideSelection = false;
            this.lvNotes.Location = new System.Drawing.Point(30, 227);
            this.lvNotes.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lvNotes.Name = "lvNotes";
            this.lvNotes.Size = new System.Drawing.Size(483, 158);
            this.lvNotes.TabIndex = 0;
            this.lvNotes.UseCompatibleStateImageBehavior = false;
            this.lvNotes.View = System.Windows.Forms.View.Details;
            this.lvNotes.SelectedIndexChanged += new System.EventHandler(this.lvNotes_SelectedIndexChanged);
            // 
            // NoteID
            // 
            this.NoteID.DisplayIndex = 1;
            this.NoteID.Width = 0;
            // 
            // Note
            // 
            this.Note.DisplayIndex = 0;
            this.Note.Text = "Note History (click row to select)";
            this.Note.Width = 483;
            // 
            // rtxtNote
            // 
            this.rtxtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(92)))));
            this.rtxtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtNote.Location = new System.Drawing.Point(212, 50);
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(301, 133);
            this.rtxtNote.TabIndex = 3;
            this.rtxtNote.Text = "";
            this.rtxtNote.TextChanged += new System.EventHandler(this.rtxtNote_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Entered At:";
            // 
            // txtEnteredAt
            // 
            this.txtEnteredAt.Enabled = false;
            this.txtEnteredAt.Location = new System.Drawing.Point(95, 73);
            this.txtEnteredAt.Name = "txtEnteredAt";
            this.txtEnteredAt.Size = new System.Drawing.Size(101, 20);
            this.txtEnteredAt.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "NoteID:";
            // 
            // txtNoteID
            // 
            this.txtNoteID.Enabled = false;
            this.txtNoteID.Location = new System.Drawing.Point(95, 27);
            this.txtNoteID.Name = "txtNoteID";
            this.txtNoteID.Size = new System.Drawing.Size(101, 20);
            this.txtNoteID.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Entered By:";
            // 
            // txtEnteredBy
            // 
            this.txtEnteredBy.Enabled = false;
            this.txtEnteredBy.Location = new System.Drawing.Point(95, 50);
            this.txtEnteredBy.Name = "txtEnteredBy";
            this.txtEnteredBy.Size = new System.Drawing.Size(101, 20);
            this.txtEnteredBy.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(212, 189);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Add a Note";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(382, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // rtxtClientDetails
            // 
            this.rtxtClientDetails.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtClientDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtClientDetails.Location = new System.Drawing.Point(95, 99);
            this.rtxtClientDetails.Name = "rtxtClientDetails";
            this.rtxtClientDetails.Size = new System.Drawing.Size(100, 96);
            this.rtxtClientDetails.TabIndex = 15;
            this.rtxtClientDetails.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Notes for:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(322, 189);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Enter notes below:";
            // 
            // frmNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 424);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtClientDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEnteredAt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNoteID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEnteredBy);
            this.Controls.Add(this.rtxtNote);
            this.Controls.Add(this.lvNotes);
            this.Name = "frmNote";
            this.Text = "Notes";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvNotes;
        private System.Windows.Forms.ColumnHeader Note;
        private System.Windows.Forms.RichTextBox rtxtNote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEnteredAt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNoteID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEnteredBy;
        private System.Windows.Forms.ColumnHeader NoteID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtClientDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
    }
}