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
    public partial class frmMaintenanceDestinationType : Form
    {
        public frmMaintenanceDestinationType()
        {
            InitializeComponent();
            
        }
                
        private void SetAdd() {
            this.btnAdd.Enabled = !(this.txtAdd.Text == string.Empty || this.cboDestinationCategory.SelectedIndex == 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(this.txtAdd.Text==string.Empty || this.cboDestinationCategory.SelectedIndex == 0){
                MessageBox.Show("Type and Category must be entered", "Destination maintenance");
                return;
            }

            Destination destination = new Destination();

            destination.DestinationTypeID = (int)this.cboDestinationCategory.SelectedValue;
            destination.Name = this.txtAdd.Text;
            string msg = destination.AddDestinationType();

            if (msg == "Successfully added destination type")
            {
                MessageBox.Show(msg, "Destination maintenance");
                this.txtAdd.Text = "";
                this.cboDestinationCategory.SelectedIndex = 0;
                this.Close();
            }
            else {
                MessageBox.Show("Item has not been added - " + msg, "Destination maintenance");
            }
        }

        private void frmMaintenanceDestinationType_Load(object sender, EventArgs e)
        {
            Combo objCombo = new Combo();
            objCombo.PopulateCombo(this.cboDestinationCategory, Combo.ComboName.DestinationCategory, "Allocate to Category:");

        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {
            SetAdd();
        }

        private void cboDestinationCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetAdd();
        }
    }
}