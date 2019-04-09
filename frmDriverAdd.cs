using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TransManager
{
    public partial class frmDriverAdd : Form
    {
        public static frmDriverAdd mInst;

        private string msgBoxTitle;

        public frmDriverAdd()
        {
            InitializeComponent();
            msgBoxTitle = this.Name;
        }

        // Create a public static property that returns the state of the instance
        public static frmDriverAdd CheckInst
        {
            get
            {
                return mInst;
            }
        }

        // Create a public static property that will create an instance of the form and return it
        public static frmDriverAdd CreateInst
        {
            get
            {
                if (mInst == null)
                    mInst = new frmDriverAdd();
                return mInst;
            }
        }

        // We also need to override the OnClose event so we can set the Instance to null
        protected override void OnClosed(EventArgs e)
        {
            mInst = null;
            base.OnClosed(e);   // Always call the base of OnClose !

        }


        private void LoadTitleCombo()
        {
            Combo objCombo = new Combo();
            objCombo.PopulateCombo(this.cboTitle, Combo.ComboName.Title);
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Validate the required fields first
            if (this.txtFirstName.Text == string.Empty)
            {
                MessageBox.Show("First Name must be entered");
                return;
            }
            if (this.txtSurname.Text == string.Empty)
            {
                MessageBox.Show("Surname must be entered");
                return;
            }
            if (this.txtAddressLine1.Text == string.Empty)
            {
                MessageBox.Show("Address Line 1 must be entered");
                return;
            }


            Driver driver = new Driver();
            driver.TitleID = Convert.ToInt32(this.cboTitle.SelectedValue.ToString());
            driver.FirstName = this.txtFirstName.Text;
            driver.Surname = this.txtSurname.Text;
            driver.AddressLine1 = this.txtAddressLine1.Text;
            driver.AddressLine2 = this.txtAddressLine2.Text;
            driver.Town = this.txtTown.Text;
            driver.Postcode = this.mskPostCode.Text;
            driver.HomePhone = this.txtHomePhone.Text;
            driver.MobilePhone = this.txtMobilePhone.Text;
            driver.DateOfBirth = this.dtpDOB.Value;
            driver.Email = this.txtEmail.Text;
            driver.LicenceNo = this.txtLicenceNo.Text;
            driver.LicenceExpiry = this.dtpLicenceExpiry.Value;
            driver.isActive = true;
            
            if (driver.Add())
            {
                MessageBox.Show("Driver added", msgBoxTitle);
                this.cboTitle.SelectedIndex = 0;
                this.txtFirstName.Text = "";
                this.txtSurname.Text = "";
                this.txtAddressLine1.Text = "";
                this.txtAddressLine2.Text = "";
                this.txtTown.Text = "";
                this.mskPostCode.Text = "";
                this.txtHomePhone.Text = "";
                this.txtMobilePhone.Text = "";
                this.txtLicenceNo.Text = "";
                this.dtpDOB.Value = System.DateTime.Now;
            }
            else
            {
                MessageBox.Show("Driver not added", msgBoxTitle);
            }

        }

        private void frmDriverAdd_Load(object sender, EventArgs e)
        {
            LoadTitleCombo();
        }

        private void txtHomePhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
