using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransManager
{
    public partial class frmMaintenanceLogIn : Form
    {
        User user = new User();
        Combo combo = new Combo();
        string msg;

        public frmMaintenanceLogIn()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User name should be the windows login name id of intended user", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = !(txtPassword.Text == string.Empty || txtUserName.Text == string.Empty || cboAccessLevel.SelectedIndex < 1);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = !(txtPassword.Text == string.Empty || txtUserName.Text == string.Empty || cboAccessLevel.SelectedIndex < 1);
        }

        private void frmMaintenanceLogIn_Load(object sender, EventArgs e)
        {
            combo.PopulateCombo(cboAccessLevel, Combo.ComboName.UserAccess, "<Choose Level>");
            combo.PopulateCombo(cboUAccessLevel, Combo.ComboName.UserAccess, "<Choose Level>");
            combo.PopulateCombo(cboUpdateUser, Combo.ComboName.Users, "<Select User>");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(user.Add(txtUserName.Text, txtPassword.Text, Convert.ToInt32(cboAccessLevel.SelectedValue)), this.Text);
            ResetForm();
        }

        private void cboAccessLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = !(txtPassword.Text == string.Empty || txtUserName.Text == string.Empty || cboAccessLevel.SelectedIndex < 1);
        }

        private void cboUpdateUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            User updateuser = new User();

            try
            {
                updateuser.LoadUser(Convert.ToInt32(cboUpdateUser.SelectedValue));
            }
            catch (System.Exception err) {
                string x = err.Message; //we dont want to do anything with this other than catch on load
            }
            txtUPassword.Text = updateuser.Password;
            txtUUserName.Text = updateuser.UserName;
            cboUAccessLevel.SelectedValue = updateuser.AccessLevel;
            btnUpdateUser.Enabled=  btnDeleteUser.Enabled = !(txtUPassword.Text == string.Empty || txtUUserName.Text == string.Empty || cboUpdateUser.SelectedIndex < 1);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Are you sure you want to delete this user?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                msg = user.Delete(Convert.ToInt32(cboUpdateUser.SelectedValue));
                MessageBox.Show(msg, this.Text);

                if (msg == "Successfully deleted user")
                {
                    ResetForm();

                }
                
            }
        }

        private void txtUUserName_TextChanged(object sender, EventArgs e)
        {
            btnUpdateUser.Enabled = btnDeleteUser.Enabled = !(txtUPassword.Text == string.Empty || txtUUserName.Text == string.Empty || cboUpdateUser.SelectedIndex < 1);
        }

        private void txtUPassword_TextChanged(object sender, EventArgs e)
        {
            btnUpdateUser.Enabled = btnDeleteUser.Enabled = !(txtUPassword.Text == string.Empty || txtUUserName.Text == string.Empty || cboUpdateUser.SelectedIndex < 1);
        }

        private void cboUAccessLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdateUser.Enabled = btnDeleteUser.Enabled = !(txtUPassword.Text == string.Empty || txtUUserName.Text == string.Empty || cboUpdateUser.SelectedIndex < 1);
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            
            msg = user.Update(Convert.ToInt32(cboUpdateUser.SelectedValue), txtUUserName.Text, txtUPassword.Text, Convert.ToInt32(cboUAccessLevel.SelectedValue));
            MessageBox.Show(msg, this.Text);
            if (msg == "Successfully updated user")
            {
                ResetForm();
            }
        }
        private void ResetForm() {
            combo.PopulateCombo(cboUpdateUser, Combo.ComboName.Users, "<Choose User>");
            combo.PopulateCombo(cboAccessLevel, Combo.ComboName.UserAccess, "<Choose Level>");
            combo.PopulateCombo(cboUAccessLevel, Combo.ComboName.UserAccess, "<Choose Level>");


            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUUserName.Text = string.Empty;
            txtUPassword.Text = string.Empty;
        }
    }
}
