namespace TransManager
{
    partial class frmClient
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.clientid = new System.Windows.Forms.ColumnHeader();
            this.title = new System.Windows.Forms.ColumnHeader();
            this.FirstName = new System.Windows.Forms.ColumnHeader();
            this.Initial = new System.Windows.Forms.ColumnHeader();
            this.AddressLine1 = new System.Windows.Forms.ColumnHeader("(none)");
            this.AddressLine2 = new System.Windows.Forms.ColumnHeader();
            this.Town = new System.Windows.Forms.ColumnHeader();
            this.Postcode = new System.Windows.Forms.ColumnHeader();
                       
            this.txtSearchSurname = new System.Windows.Forms.TextBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblSearchTown = new System.Windows.Forms.Label();
            this.txtSearchTown = new System.Windows.Forms.TextBox();
            this.lblSearchAddressLine1 = new System.Windows.Forms.Label();
            this.txtSearchAddressLine1 = new System.Windows.Forms.TextBox();
            this.gbActive = new System.Windows.Forms.GroupBox();
            this.radActiveAll = new System.Windows.Forms.RadioButton();
            this.radActiveTrue = new System.Windows.Forms.RadioButton();
            this.radActiveFalse = new System.Windows.Forms.RadioButton();
            this.lblSearchSurname = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.grpSearch.SuspendLayout();
            this.gbActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clientid,
            this.title,
            this.FirstName,
            this.Initial,
            this.AddressLine1,
            this.AddressLine2,
            this.Town,
            this.Postcode});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 206);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(847, 347);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clientid
            // 
            this.clientid.Text = "ClientID";
            this.clientid.Width = 52;
            // 
            // title
            // 
            this.title.Text = "title";
            this.title.Width = 37;
            // 
            // FirstName
            // 
            this.FirstName.Text = "firstname";
            this.FirstName.Width = 72;
            // 
            // Initial
            // 
            this.Initial.Text = "surname";
            this.Initial.Width = 83;
            // 
            // AddressLine1
            // 
            this.AddressLine1.Text = "AddressLine1";
            this.AddressLine1.Width = 188;
            // 
            // AddressLine2
            // 
            this.AddressLine2.Text = "AddressLine2";
            this.AddressLine2.Width = 187;
            // 
            // Town
            // 
            this.Town.Text = "Town";
            this.Town.Width = 101;
            // 
            // Postcode
            // 
            this.Postcode.Text = "Postcode";
            this.Postcode.Width = 70;
            // 
            // txtSearchSurname
            // 
            this.txtSearchSurname.Location = new System.Drawing.Point(6, 36);
            this.txtSearchSurname.Name = "txtSearchSurname";
            this.txtSearchSurname.Size = new System.Drawing.Size(137, 20);
            this.txtSearchSurname.TabIndex = 3;
            this.txtSearchSurname.TextChanged += new System.EventHandler(this.txtSearchSurname_TextChanged);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.lblSearchTown);
            this.grpSearch.Controls.Add(this.txtSearchTown);
            this.grpSearch.Controls.Add(this.lblSearchAddressLine1);
            this.grpSearch.Controls.Add(this.txtSearchAddressLine1);
            this.grpSearch.Controls.Add(this.gbActive);
            this.grpSearch.Controls.Add(this.lblSearchSurname);
            this.grpSearch.Controls.Add(this.txtSearchSurname);
            this.grpSearch.Location = new System.Drawing.Point(13, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(378, 168);
            this.grpSearch.TabIndex = 4;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Filters";
            // 
            // lblSearchTown
            // 
            this.lblSearchTown.AutoSize = true;
            this.lblSearchTown.Location = new System.Drawing.Point(6, 119);
            this.lblSearchTown.Name = "lblSearchTown";
            this.lblSearchTown.Size = new System.Drawing.Size(73, 13);
            this.lblSearchTown.TabIndex = 11;
            this.lblSearchTown.Text = "filter by Town:";
            // 
            // txtSearchTown
            // 
            this.txtSearchTown.Location = new System.Drawing.Point(6, 135);
            this.txtSearchTown.Name = "txtSearchTown";
            this.txtSearchTown.Size = new System.Drawing.Size(137, 20);
            this.txtSearchTown.TabIndex = 10;
            this.txtSearchTown.TextChanged += new System.EventHandler(this.txtSearchTown_TextChanged);
            // 
            // lblSearchAddressLine1
            // 
            this.lblSearchAddressLine1.AutoSize = true;
            this.lblSearchAddressLine1.Location = new System.Drawing.Point(6, 65);
            this.lblSearchAddressLine1.Name = "lblSearchAddressLine1";
            this.lblSearchAddressLine1.Size = new System.Drawing.Size(110, 13);
            this.lblSearchAddressLine1.TabIndex = 9;
            this.lblSearchAddressLine1.Text = "filter by AddressLine1:";
            // 
            // txtSearchAddressLine1
            // 
            this.txtSearchAddressLine1.Location = new System.Drawing.Point(6, 81);
            this.txtSearchAddressLine1.Name = "txtSearchAddressLine1";
            this.txtSearchAddressLine1.Size = new System.Drawing.Size(137, 20);
            this.txtSearchAddressLine1.TabIndex = 8;
            this.txtSearchAddressLine1.TextChanged += new System.EventHandler(this.txtSearchAddressLine1_TextChanged);
            // 
            // gbActive
            // 
            this.gbActive.Controls.Add(this.radActiveAll);
            this.gbActive.Controls.Add(this.radActiveTrue);
            this.gbActive.Controls.Add(this.radActiveFalse);
            this.gbActive.Location = new System.Drawing.Point(189, 19);
            this.gbActive.Name = "gbActive";
            this.gbActive.Size = new System.Drawing.Size(124, 90);
            this.gbActive.TabIndex = 7;
            this.gbActive.TabStop = false;
            this.gbActive.Text = "Active/Inactive:";
            // 
            // radActiveAll
            // 
            this.radActiveAll.AutoSize = true;
            this.radActiveAll.Location = new System.Drawing.Point(8, 67);
            this.radActiveAll.Name = "radActiveAll";
            this.radActiveAll.Size = new System.Drawing.Size(36, 17);
            this.radActiveAll.TabIndex = 7;
            this.radActiveAll.Text = "All";
            this.radActiveAll.UseVisualStyleBackColor = true;
            this.radActiveAll.CheckedChanged += new System.EventHandler(this.radActiveAll_CheckedChanged);
            // 
            // radActiveTrue
            // 
            this.radActiveTrue.AutoSize = true;
            this.radActiveTrue.Checked = true;
            this.radActiveTrue.Location = new System.Drawing.Point(8, 19);
            this.radActiveTrue.Name = "radActiveTrue";
            this.radActiveTrue.Size = new System.Drawing.Size(88, 17);
            this.radActiveTrue.TabIndex = 5;
            this.radActiveTrue.TabStop = true;
            this.radActiveTrue.Text = "Active clients";
            this.radActiveTrue.UseVisualStyleBackColor = true;
            this.radActiveTrue.CheckedChanged += new System.EventHandler(this.radActiveTrue_CheckedChanged);
            // 
            // radActiveFalse
            // 
            this.radActiveFalse.AutoSize = true;
            this.radActiveFalse.Location = new System.Drawing.Point(8, 42);
            this.radActiveFalse.Name = "radActiveFalse";
            this.radActiveFalse.Size = new System.Drawing.Size(96, 17);
            this.radActiveFalse.TabIndex = 6;
            this.radActiveFalse.Text = "Inactive clients";
            this.radActiveFalse.UseVisualStyleBackColor = true;
            this.radActiveFalse.CheckedChanged += new System.EventHandler(this.radActiveFalse_CheckedChanged);
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
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.richTextBox1.Location = new System.Drawing.Point(444, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(400, 159);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "Full Client Details:\nTitle: \nFirstname:\nMiddleName:\nSurname:\nAddress Line 1:\nAddr" +
                "ess Line2: ";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 565);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.listView1);
            this.Name = "frmClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.gbActive.ResumeLayout(false);
            this.gbActive.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clientid;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader Initial;
        
        private System.Windows.Forms.ColumnHeader AddressLine1;
        private System.Windows.Forms.ColumnHeader AddressLine2;
        private System.Windows.Forms.ColumnHeader Town;
        private System.Windows.Forms.ColumnHeader Postcode;
        private System.Windows.Forms.TextBox txtSearchSurname;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblSearchSurname;
        private System.Windows.Forms.RadioButton radActiveFalse;
        private System.Windows.Forms.RadioButton radActiveTrue;
        
        private System.Windows.Forms.GroupBox gbActive;
        private System.Windows.Forms.RadioButton radActiveAll;
        private System.Windows.Forms.Label lblSearchAddressLine1;
        private System.Windows.Forms.TextBox txtSearchAddressLine1;
        private System.Windows.Forms.Label lblSearchTown;
        private System.Windows.Forms.TextBox txtSearchTown;
        private System.Windows.Forms.RichTextBox richTextBox1;


    }
}