using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Collections;



namespace TransManager
{
    public partial class frmClientEdit : Form
    {
        Clients collClient;

        Boolean bDirty = false;

        IEnumerable<Client> querybySurname;
        IEnumerable<Client> querybyAddress;
        IEnumerable<Client> querybyTown;
        IEnumerable<Client> querybyID;
        IEnumerable<Client> queryCurrent;

        
        public frmClientEdit()
        {
            InitializeComponent();
            
        }

        

        private void Client_Load(object sender, EventArgs e)
        {
                    
            collClient = new Clients();
            
            querybySurname = collClient.Where(s => s.isActive == this.radActiveTrue.Checked || s.isActive == (this.radActiveTrue.Checked || this.radActiveAll.Checked)).Where(s => s.Surname.ToString().ToUpper().StartsWith(this.txtSearchSurname.Text.ToUpper())).OrderBy(id => id.Surname);
            querybyAddress = collClient.Where(s => s.isActive == this.radActiveTrue.Checked || s.isActive == (this.radActiveTrue.Checked || this.radActiveAll.Checked)).Where(s => s.AddressLine1.ToUpper().Contains(this.txtSearchAddressLine1.Text.ToUpper())).OrderBy(id => id.Surname);
            querybyTown = collClient.Where(s => s.isActive == this.radActiveTrue.Checked || s.isActive == (this.radActiveTrue.Checked || this.radActiveAll.Checked)).Where(s => s.Town.ToUpper().Contains(this.txtSearchTown.Text.ToUpper())).OrderBy(id => id.Surname);
            if (listView1.SelectedItems.Count > 0)
            {
                querybyID = collClient.Where(s => s.ClientID.ToString() == (listView1.SelectedItems[0].SubItems[0].Text==null ? this.txtClientID.Text : listView1.SelectedItems[0].SubItems[0].Text));
            }
            queryCurrent = querybySurname;
            
            LoadListView(queryCurrent);
            LoadTitleCombo();
        }

        private void LoadAttributes(Client client)
        {
            clbAttributes.Items.Clear();
            foreach (Attribute attribute in client.Attributes)
            {
                this.clbAttributes.Items.Add(attribute.Description, attribute.Checked);

            }
            
        }

        private void LoadTitleCombo() {
            Combo objCombo = new Combo();
            objCombo.PopulateCombo(this.cboTitle, Combo.ComboName.Title);
        }

        private void LoadListView(IEnumerable<Client> query){

            listView1.Items.Clear();
            listView1.ListViewItemSorter = null;

            foreach (Client client in query)
            {
                        ListViewItem lvi = listView1.Items.Add(client.ClientID.ToString());
                        lvi.SubItems.Add(client.Title);
                        lvi.SubItems.Add(client.FirstName);
                        lvi.SubItems.Add(client.Surname);
                        lvi.SubItems.Add(client.AddressLine1);
                        lvi.SubItems.Add(client.AddressLine2);
                        lvi.SubItems.Add(client.Town);
                        lvi.SubItems.Add(client.Postcode);
                        lvi.BackColor = System.Drawing.Color.LightSalmon;
                        if (!client.isActive)
                        {
                            lvi.BackColor = System.Drawing.Color.Bisque;
                        }
            }
        }

        private void radActiveTrue_CheckedChanged(object sender, EventArgs e)
        {
            LoadListView(queryCurrent);
        }

        private void radActiveFalse_CheckedChanged(object sender, EventArgs e)
        {

            LoadListView(queryCurrent);
        }

        private void radActiveAll_CheckedChanged(object sender, EventArgs e)
        {
            
            LoadListView(queryCurrent);
        }

        private void txtSearchSurname_TextChanged(object sender, EventArgs e)
        {
            this.txtSearchAddressLine1.Text = "";
            this.txtSearchTown.Text = "";
            queryCurrent = querybySurname;
            LoadListView(queryCurrent);
        }
        
        private void txtSearchAddressLine1_TextChanged(object sender, EventArgs e)
        {
            this.txtSearchSurname.Text = "";
            this.txtSearchTown.Text = "";
            queryCurrent = querybyAddress;            
            LoadListView(queryCurrent);
        }

        private void txtSearchTown_TextChanged(object sender, EventArgs e)
        {
            this.txtSearchAddressLine1.Text = "";
            this.txtSearchSurname.Text = "";
            queryCurrent = querybyTown;
            LoadListView(queryCurrent);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (querybyID == null)
                {
                    querybyID = collClient.Where(s => s.ClientID.ToString() == (listView1.SelectedItems.Count == 0 ? this.txtClientID.Text : listView1.SelectedItems[0].SubItems[0].Text));
                }
                LoadClient(querybyID);
                this.btnNotes.Enabled = true;
                bDirty = false;
            }
            
            
            
        }

        private void LoadClient(IEnumerable<Client> querybyID){
            Client client = querybyID.FirstOrDefault();
            this.cboTitle.SelectedValue = client.TitleID;
            this.txtClientID.Text = client.ClientID.ToString();
            this.txtFirstName.Text = client.FirstName;
            this.txtMiddleName.Text = client.MiddleName;
            this.txtSurname.Text = client.Surname;
            this.txtAddressLine1.Text = client.AddressLine1;
            this.txtAddressLine2.Text = client.AddressLine2;
            this.txtTown.Text = client.Town;
            this.txtHomePhone.Text = client.HomePhone;
            this.txtMobilePhone.Text = client.MobilePhone;
            this.mskPostCode.Text = client.Postcode;
            this.dtpDOB.Value = client.DateOfBirth;
            this.txtEmail.Text = client.Email;
            this.radActiveYes.Checked = client.isActive;
            this.radActiveNo.Checked = !client.isActive;
            client.LoadAttributes();
            LoadAttributes(client);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtSearchTown.Text="";
            this.txtSearchSurname.Text = "";
            this.txtSearchAddressLine1.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.txtClientID.Text == "0") {
                MessageBox.Show("No client has been selected", "Client Edit");
                bDirty = false;
                return;
            }

            Client client = querybyID.FirstOrDefault();
            client.Title = this.cboTitle.SelectedText.ToString();
            client.TitleID = System.Convert.ToInt32(this.cboTitle.SelectedValue.ToString());
            client.FirstName = this.txtFirstName.Text;
            client.MiddleName = this.txtMiddleName.Text;
            client.Surname = this.txtSurname.Text;
            client.AddressLine1 = this.txtAddressLine1.Text;
            client.AddressLine2 = this.txtAddressLine2.Text;
            client.Town = this.txtTown.Text;
            client.HomePhone = this.txtHomePhone.Text;
            client.MobilePhone = this.txtMobilePhone.Text;
            client.Postcode = this.mskPostCode.Text;
            client.DateOfBirth = this.dtpDOB.Value;
            client.Email = this.txtEmail.Text;
            client.isActive = this.radActiveYes.Checked;
            client.LoadAttributes();

            string msg = client.Update();
                        
            //now add in the attributes.
            for (Int32 i = 0; i < this.clbAttributes.Items.Count; i++)
            {
                client.Attributes[i].CheckedNew = this.clbAttributes.GetItemChecked(i);
                client.Attributes[i].LinkID = client.ClientID;
                client.Attributes[i].Update(Attribute.AttributeType.client);

            }

            collClient.PopulateClients();

            if (msg == "Successfully updated Client")
            {
                MessageBox.Show(client.Update(), "client update");
                bDirty = false;
            }

            LoadListView(queryCurrent);

        
       }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            frmNote clientNote = new frmNote(System.Convert.ToInt32(txtClientID.Text), Notes.NoteType.Client);
            clientNote.FormClosing += delegate { this.Show(); };
            Sizer.ResizeForm(clientNote);
            clientNote.StartPosition = FormStartPosition.Manual;
            clientNote.ShowDialog();
            
        }

        private void txtClientID_TextChanged(object sender, EventArgs e)
        {
            this.btnDonations.Enabled = this.btnNotes.Enabled = txtClientID.Text != "";
            
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            listView1.Sorting = listView1.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column, this.listView1.Sorting);
                       
        }

        

        class ListViewItemComparer : System.Collections.IComparer
        {
            private int col;
            private SortOrder _sortorder;

            public ListViewItemComparer()
            {
                col = 0;
            }
            public ListViewItemComparer(int column, SortOrder sortorder)
            {
                col = column;
                _sortorder = sortorder;
            }
            
            public int Compare(object x, object y)
            {
                try
                {
                    if (_sortorder == SortOrder.Ascending)
                    {
                        return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                    }
                    else
                    {
                        return -String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                    }
                }
                catch (SystemException e) {
                    MessageBox.Show(e.Message);
                    return 1;
                }
            }
        }

        private void cboTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void btnDonations_Click(object sender, EventArgs e)
        {
            frmDonation clientDonation = new frmDonation(System.Convert.ToInt32(txtClientID.Text));
            clientDonation.FormClosed += delegate { this.Show(); };
            clientDonation.StartPosition = FormStartPosition.Manual;
            Sizer.ResizeForm(clientDonation);
            clientDonation.Show();
        }

        private void frmClientEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bDirty && Convert.ToInt32(txtClientID.Text) > 0 )
            {
                DialogResult dialogResult = MessageBox.Show("Data has not been saved - click Yes if you still want to close form.", "Client Edit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                    this.Activate();
                    this.Focus();
                }
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void txtAddressLine1_TextChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void txtAddressLine2_TextChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void txtTown_TextChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void mskPostCode_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            bDirty = true;
        }

        private void txtHomePhone_TextChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void txtMobilePhone_TextChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radActiveYes_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void clbAttributes_SelectedIndexChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }
    }
}
