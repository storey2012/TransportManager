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
    public partial class frmDestinationAdd : Form
    {
        private string _function = "Add";
               

        public frmDestinationAdd(string function)
        {
            InitializeComponent();
            _function = function;
            LoadDestinationsCombo();
            this.btnAdd.Text = function + " destination";
            SetDetails();
        }

        private void LoadDestinationsCombo(){
            Combo combo = new Combo();
            this.cboDestination.DataSource = null;
            this.cboDestination.DisplayMember = null;
            
            combo.PopulateCombo(this.cboDestination, Combo.ComboName.Destination, "Choose Location:");
        }
        
        private void LoadDestinationTypeCombo()
        {
            Combo combo = new Combo();
            this.cboDestinationType.DataSource = null;
            this.cboDestinationType.DisplayMember = null;

            combo.PopulateCombo(this.cboDestinationType, Combo.ComboName.DestinationType);
        }
        
        private void LoadTitleCombo()
        {
            Combo objCombo = new Combo();
            objCombo.PopulateCombo(this.cboDestinationType, Combo.ComboName.Title, "Choose Destination");
        }

        private void SetDetails() {
            this.txtName.Enabled = (_function == "Add" || _function == "Update");
            this.txtAddressLine1.Enabled = (_function == "Add" || _function == "Update");
            this.txtAddressLine2.Enabled = (_function == "Add" || _function == "Update");
            this.txtTown.Enabled = (_function == "Add" || _function == "Update");
            this.mskPostCode.Enabled = (_function == "Add" || _function == "Update");
            this.cboDestinationType.Enabled = (_function == "Add" || _function == "Update");
            this.lblCaption.Visible = (_function == "Add" || _function == "Update");
            lblDestination.Visible = cboDestination.Visible = (_function == "Update" || _function == "Delete");
            this.btnAddDestType.Visible = (_function != "Delete");
            this.btnAdd.Enabled = (_function == "Add" || (this.cboDestination.SelectedIndex != 0));
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Validate the required fields first
            if (txtName.Text == string.Empty || txtAddressLine1.Text == string.Empty || txtTown.Text == string.Empty || mskPostCode.Text == string.Empty)
            {
                MessageBox.Show("All yellow entry fields must be filled");
                return;
            }

            Destination destination = new Destination();
            destination.Name = this.txtName.Text;
            destination.AddressLine1 = this.txtAddressLine1.Text;
            destination.AddressLine2 = this.txtAddressLine2.Text;
            destination.Town = this.txtTown.Text;
            destination.Postcode = this.mskPostCode.Text;
            destination.DestinationTypeID = Convert.ToInt32(this.cboDestinationType.SelectedValue.ToString());

            if (_function=="Update") {
                destination.DestinationID = Convert.ToInt32(txtDestinationID.Text);    
                MessageBox.Show(destination.Update(), "Destination maintenance");
            }
            else if (_function == "Delete") {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete [" + this.txtName.Text + "] from the list?", "Destination maintenance", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    destination.DestinationID = Convert.ToInt32(txtDestinationID.Text);
                    MessageBox.Show(destination.Delete(), "Destination maintenance");
                    LoadDestinationsCombo();
                }
            }
            else
            {
                string strMsg = destination.Add();

                if (strMsg == "Successfully added destination")
                {
                    MessageBox.Show("Destination added", "Destination maintenance");
                    this.cboDestinationType.SelectedIndex = 0;
                    this.txtName.Text = "";
                    this.txtAddressLine1.Text = "";
                    this.txtAddressLine2.Text = "";
                    this.txtTown.Text = "";
                    this.mskPostCode.Text = "";
                }
                else
                {
                    MessageBox.Show(strMsg);
                }
            }
        }

        private void frmDestinationAdd_Load(object sender, EventArgs e)
        {
            LoadDestinationTypeCombo();
        }

        private void btnAddDestType_Click(object sender, EventArgs e)
        {
            frmMaintenanceDestinationType maint = new frmMaintenanceDestinationType();
            //maint.FormClosing += delegate { this.Show(); };
            maint.FormClosing += delegate { LoadDestinationTypeCombo();  };
            Sizer.ResizeForm(maint);
            maint.Show();
            
            
        }

        private void cboDestination_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Destination dest = new Destination((int)this.cboDestination.SelectedValue);
            this.txtName.Text = dest.Name;
            this.txtAddressLine1.Text = dest.AddressLine1;
            this.txtAddressLine2.Text = dest.AddressLine2;
            this.txtTown.Text = dest.Town;
            this.mskPostCode.Text = dest.Postcode;
            this.cboDestinationType.SelectedValue = dest.DestinationTypeID;
            this.txtDestinationID.Text = dest.DestinationID.ToString();
        }

        private void cboDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDetails();
            //this.btnAdd.Enabled = (Convert.ToInt32(this.cboDestination.SelectedIndex) != 0);
        }
    }
}
