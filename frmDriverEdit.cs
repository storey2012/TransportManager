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
    public partial class frmDriverEdit : Form
    {
        Drivers collDriver;
        User _user;
        Boolean bDirty = false;
        string msgBoxTitle;

        IEnumerable<Driver> querybySurname;
        IEnumerable<Driver> querybyAddress;
        IEnumerable<Driver> querybyTown;
        IEnumerable<Driver> querybyID;
        //IEnumerable<Driver> querybyCarMake;
        IEnumerable<Driver> queryCurrent;


        
        public frmDriverEdit(User user)
        {
            _user = user;
            InitializeComponent();
            msgBoxTitle = this.Name;
        }

        

        private void frmDriverEdit_Load(object sender, EventArgs e)
        {
                    
            collDriver = new Drivers(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            querybySurname = collDriver.Where(s => s.isActive == this.radActiveTrue.Checked || s.isActive == (this.radActiveTrue.Checked || this.radActiveAll.Checked)).Where(s => s.Surname.ToString().ToUpper().StartsWith(this.txtSearchSurname.Text.ToUpper())).OrderBy(id => id.Surname);
            querybyAddress = collDriver.Where(s => s.isActive == this.radActiveTrue.Checked || s.isActive == (this.radActiveTrue.Checked || this.radActiveAll.Checked)).Where(s => s.AddressLine1.ToUpper().Contains(this.txtSearchAddressLine1.Text.ToUpper())).OrderBy(id => id.Surname);
            querybyTown = collDriver.Where(s => s.isActive == this.radActiveTrue.Checked || s.isActive == (this.radActiveTrue.Checked || this.radActiveAll.Checked)).Where(s => s.Town.ToUpper().Contains(this.txtSearchTown.Text.ToUpper())).OrderBy(id => id.Surname);

            queryCurrent = querybySurname;
            
            LoadListView(queryCurrent);
            LoadTitleCombo();
            
        }
        
        private void LoadTitleCombo() {
            Combo objCombo = new Combo();
            objCombo.PopulateCombo(this.cboTitle, Combo.ComboName.Title);
            objCombo.PopulateCombo(this.cboCarMake, Combo.ComboName.CarMake);
        }

        private void LoadListView(IEnumerable<Driver> query){
            this.listView1.ListViewItemSorter = null;
            listView1.Items.Clear();

            foreach (Driver driver in query)
            {
                        ListViewItem lvi = listView1.Items.Add(driver.DriverID.ToString());
                        lvi.SubItems.Add(driver.Title);
                        lvi.SubItems.Add(driver.FirstName);
                        lvi.SubItems.Add(driver.Surname);
                        lvi.SubItems.Add(driver.AddressLine1);
                        lvi.SubItems.Add(driver.AddressLine2);
                        lvi.SubItems.Add(driver.Town);
                        lvi.SubItems.Add(driver.Postcode);
                        lvi.BackColor = System.Drawing.Color.LightSalmon;
                        if (!driver.isActive)
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
            if(listView1.SelectedItems.Count>0){
                if (querybyID == null)
                {
                    querybyID = collDriver.Where(s => s.DriverID.ToString() == (listView1.SelectedItems.Count==0 ? this.txtDriverID.Text : listView1.SelectedItems[0].SubItems[0].Text));
                }
                LoadDriver(querybyID);
                this.btnNotes.Enabled = true;
                bDirty = false;
            }
        }

        private void LoadDriver(IEnumerable<Driver> querybyID){
            
            Driver driver = querybyID.FirstOrDefault();
            this.cboTitle.SelectedValue = driver.TitleID;
            this.txtDriverID.Text = driver.DriverID.ToString();
            this.txtFirstName.Text = driver.FirstName;
            
            this.txtSurname.Text = driver.Surname;
            this.txtAddressLine1.Text = driver.AddressLine1;
            this.txtAddressLine2.Text = driver.AddressLine2;
            this.txtTown.Text = driver.Town;
            this.txtHomePhone.Text = driver.HomePhone;
            this.txtMobilePhone.Text = driver.MobilePhone;
            this.mskPostCode.Text = driver.Postcode;
            this.dtpDOB.Value = driver.DateOfBirth;
            this.txtEmail.Text = driver.Email;
            this.txtLicenceNo.Text = driver.LicenceNo;
            this.dtpLicenceExpiry.Value = driver.LicenceExpiry;
            this.radActiveYes.Checked = driver.isActive;
            this.radActiveNo.Checked = !driver.isActive;
            driver.LoadDriverSessions(driver.DriverID);
            this.chkSession1.Checked = driver.Sessions[1];
            this.chkSession2.Checked = driver.Sessions[2];
            this.chkSession3.Checked = driver.Sessions[3];
            this.chkSession4.Checked = driver.Sessions[4];
            this.chkSession5.Checked = driver.Sessions[5];
            this.chkSession6.Checked = driver.Sessions[6];
            this.chkSession7.Checked = driver.Sessions[7];
            this.chkSession8.Checked = driver.Sessions[8];
            this.chkSession9.Checked = driver.Sessions[9];
            this.chkSession10.Checked = driver.Sessions[10];
            this.chkSession11.Checked = driver.Sessions[11];
            this.chkSession12.Checked = driver.Sessions[12];
            this.chkSession13.Checked = driver.Sessions[13];
            this.chkSession14.Checked = driver.Sessions[14];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtSearchTown.Text="";
            this.txtSearchSurname.Text = "";
            this.txtSearchAddressLine1.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.txtDriverID.Text == "0")
            {
                MessageBox.Show("No client has been selected", msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bDirty = false;
                return;
            }

            Driver Driver = querybyID.FirstOrDefault();
            
            Driver.Title = this.cboTitle.SelectedText.ToString();
            Driver.TitleID = System.Convert.ToInt32(this.cboTitle.SelectedValue.ToString());
            Driver.FirstName = this.txtFirstName.Text;
            
            Driver.Surname = this.txtSurname.Text;
            Driver.AddressLine1 = this.txtAddressLine1.Text;
            Driver.AddressLine2 = this.txtAddressLine2.Text;
            Driver.Town = this.txtTown.Text;
            Driver.HomePhone = this.txtHomePhone.Text;
            Driver.MobilePhone = this.txtMobilePhone.Text;
            Driver.Postcode = this.mskPostCode.Text;
            Driver.DateOfBirth = this.dtpDOB.Value;
            Driver.Email = this.txtEmail.Text;
            Driver.LicenceExpiry = this.dtpLicenceExpiry.Value;
            Driver.LicenceNo = this.txtLicenceNo.Text;
            
            Driver.isActive = this.radActiveYes.Checked;
            Driver.Sessions[1] = this.chkSession1.Checked;
            Driver.Sessions[2] = this.chkSession2.Checked;
            Driver.Sessions[3] = this.chkSession3.Checked;
            Driver.Sessions[4] = this.chkSession4.Checked;
            Driver.Sessions[5] = this.chkSession5.Checked;
            Driver.Sessions[6] = this.chkSession6.Checked;
            Driver.Sessions[7] = this.chkSession7.Checked;
            Driver.Sessions[8] = this.chkSession8.Checked;
            Driver.Sessions[9] = this.chkSession9.Checked;
            Driver.Sessions[10] = this.chkSession10.Checked;
            Driver.Sessions[11] = this.chkSession11.Checked;
            Driver.Sessions[12] = this.chkSession12.Checked;
            Driver.Sessions[13] = this.chkSession13.Checked;
            Driver.Sessions[14] = this.chkSession14.Checked;

            if (Driver.Update())
            {
                MessageBox.Show("Driver updated successfully!", msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.None);
                bDirty = false;
            }
            else {
                MessageBox.Show("Driver has not been updated!", msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                bDirty = true;
            }

            collDriver.PopulateDrivers(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            LoadListView(queryCurrent);

       }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            frmNote DriverNote = new frmNote(System.Convert.ToInt32(txtDriverID.Text), Notes.NoteType.Driver);
            DriverNote.FormClosing += delegate { this.Show(); };
            DriverNote.StartPosition = FormStartPosition.Manual;
            Sizer.ResizeForm(DriverNote);
            DriverNote.Show();
            
        }

        private void txtDriverID_TextChanged(object sender, EventArgs e)
        {
            this.btnNotes.Enabled = txtDriverID.Text != "";
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
                catch (SystemException e)
                {
                    MessageBox.Show(e.Message, "Driver Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }
            }
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            if (this.txtDriverID.Text == "0")
            {
                MessageBox.Show("No driver selected", msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmDriverDetails driverdetails = new frmDriverDetails(Convert.ToInt32(this.txtDriverID.Text), _user);
            driverdetails.FormClosing += delegate { this.Show(); };
            driverdetails.StartPosition = FormStartPosition.Manual;
            Sizer.ResizeForm(driverdetails);
            driverdetails.Show();
            this.Hide();
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void gbEditControls_Enter(object sender, EventArgs e)
        {

        }

        private void cboTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            bDirty = true;
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

        private void txtLicenceNo_TextChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void dtpLicenceExpiry_ValueChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radActiveYes_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void chkSession2_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void chkSession1_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void chkSession14_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void chkSession13_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void chkSession12_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void chkSession11_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void chkSession10_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void chkSession9_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void chkSession8_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void chkSession7_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void chkSession6_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void chkSession5_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void chkSession4_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void chkSession3_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void frmDriverEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bDirty && Convert.ToInt32(txtDriverID.Text) > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Data has not been saved - click Yes if you still want to close form.", msgBoxTitle, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                    this.Activate();
                    this.Focus();
                }
            }
        }
    }
}