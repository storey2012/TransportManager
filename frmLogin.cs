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
    public partial class frmLogin : Form
    {
        Boolean bValid = false;
        User _user;

        public frmLogin(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void LogIn() {
            string msg;
            Log.WriteLine("Attempting login");
            Log.WriteLine("UserName= " + txtUserName.Text);
            msg = _user.Login(txtUserName.Text, txtPassword.Text);
            if (msg == "Success")
            {
                bValid = true;
                User.CurrentUserName = txtUserName.Text;
                this.Close();

            }
            else
            {
                MessageBox.Show(msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bValid) {
                Application.Exit();
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = (!(txtPassword.Text == string.Empty) && !(txtUserName.Text == string.Empty));
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = (!(txtPassword.Text == string.Empty) && !(txtUserName.Text == string.Empty));
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (txtPassword.Text != string.Empty && txtUserName.Text != string.Empty) {
                    LogIn();       
                }
            }
        }
    }
}
