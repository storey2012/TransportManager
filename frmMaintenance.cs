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
    public partial class frmMaintenance : Form
    {
        Combo.ComboName _comboname;
        
        public frmMaintenance(Combo.ComboName comboname)
        {
            InitializeComponent();
            LoadTitleCombo(comboname);
            _comboname = comboname;
        }

        

        private void LoadTitleCombo(Combo.ComboName comboname)
        {
            Combo objCombo = new Combo();
            objCombo.PopulateCombo(this.cboChooser, comboname, true);

        }

        private void cboChooser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboChooser.SelectedIndex == 0)
            {
                this.btnSave.Enabled = this.btnDelete.Enabled= this.txtEdit.Enabled = false;
                this.txtEdit.Text = "";
            }
            else {
                this.btnSave.Enabled = this.txtEdit.Enabled = this.btnDelete.Enabled = true;
                this.txtEdit.Text = cboChooser.Text;
                
            }
        }

        private void frmMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Combo objCombo = new Combo();
           if( objCombo.UpdateComboItem(_comboname, (int)cboChooser.SelectedValue, this.txtEdit.Text))
            {
                objCombo.PopulateCombo(this.cboChooser, _comboname, true);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Combo objCombo = new Combo();
            string msg = objCombo.AddItemToCombo(_comboname, this.txtAdd.Text); 
            if(msg=="Successfully added item")
            {
                MessageBox.Show(msg, "Pull down lists");
                objCombo.PopulateCombo(this.cboChooser, _comboname, true);
                this.txtAdd.Text = "";

            }
            else {
                MessageBox.Show("Item has not been added - " + msg, "Pull down lists");
            }
        }

        private void radEdit_CheckedChanged(object sender, EventArgs e)
        {
            this.gbEdit.Enabled = this.radEdit.Checked;
            this.gbAdd.Enabled = this.radAdd.Checked;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete [" + this.txtEdit.Text + "] from the list?", "Pull down list maintenance", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                Combo objCombo = new Combo();
                MessageBox.Show(objCombo.RemoveItem((int)cboChooser.SelectedValue, _comboname), "Pull down list maintenance");
                objCombo.PopulateCombo(this.cboChooser, _comboname);
            }
            
        }
    }
}