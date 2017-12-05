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
    public partial class frmDonation : Form
    {
        int _clientid;
        Client client;

        public frmDonation(int clientid)
        {
            InitializeComponent();
            _clientid = clientid;

        }

        private void frmDonation_Load(object sender, EventArgs e)
        {
            client = new Client(_clientid, false, true);
            LoadDonations();
        }
        private void LoadDonations() {
            client.LoadDonations();
            this.lvDonations.Items.Clear();

            foreach (Donation donation in client.Donations)
            {
                ListViewItem lvi = this.lvDonations.Items.Add(new ListViewItem(donation.DonationID.ToString()));
                lvi.SubItems.Add(donation.PaymentDate.ToShortDateString());
                lvi.SubItems.Add(donation.Amount.ToString("£0.00"));
                lvi.SubItems.Add(donation.Reference);

            }
        }

        private void lvDonations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDonations.SelectedItems.Count > 0)
            {
                txtDonationID.Text = lvDonations.SelectedItems[0].SubItems[0].Text;
                dtpPaymentDate.Value = Convert.ToDateTime(lvDonations.SelectedItems[0].SubItems[1].Text);
                char pad = ' ';
                mskAmount.Text = lvDonations.SelectedItems[0].SubItems[2].Text.PadLeft(7,pad);
                txtReference.Text = lvDonations.SelectedItems[0].SubItems[3].Text;
                btnAdd.Enabled = true;
                pnlDonation.Enabled = true;
            }
        }

        private void radDonationAdd_CheckedChanged(object sender, EventArgs e)
        {

            btnAdd.Text = "Add";
            SetForm();
        }
        private void SetForm() {
            pnlDonation.Visible = !radDonationDelete.Checked;
            btnDelete.Visible = radDonationDelete.Checked;
            lvDonations.Enabled = !radDonationAdd.Checked;
            lvDonations.SelectedItems.Clear();
            mskAmount.Text = string.Empty;
            txtReference.Text = string.Empty;
            dtpPaymentDate.Value = System.DateTime.Now;
            txtDonationID.Text = string.Empty;
            pnlDonation.Enabled = radDonationAdd.Checked;
        }

        private void radDonationUpdate_CheckedChanged(object sender, EventArgs e)
        {
            SetForm();
            btnAdd.Text = "Update";
        }

        private void radDonationDelete_CheckedChanged(object sender, EventArgs e)
        {
            SetForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvDonations.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete donation " + txtDonationID.Text, "Donations maintenance", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    Donations donations = new Donations(_clientid);
                    string msg = donations.DeleteDonation(Convert.ToInt32(lvDonations.SelectedItems[0].SubItems[0].Text));
                    if (msg == "Successfully deleted donation")
                    {
                        lvDonations.SelectedItems[0].Remove();
                    }
                    else
                    {
                        MessageBox.Show(msg, "Donation deletion");
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string msg;
            if (txtReference.Text == string.Empty || mskAmount.Text == string.Empty)
            {
                MessageBox.Show("All yellow fields must be completed!");
                return;
            }
            if (btnAdd.Text == "Add")
            {
                msg = client.Donations.AddDonation(_clientid, dtpPaymentDate.Value, Convert.ToDecimal(mskAmount.Text.Replace("£", "").Replace(" ", string.Empty)), txtReference.Text);
            }
            else {
                msg = client.Donations.UpdateDonation(Convert.ToInt32(txtDonationID.Text), dtpPaymentDate.Value, Convert.ToDecimal(mskAmount.Text.Replace("£", "").Replace(" ", string.Empty)), txtReference.Text);
            }
            MessageBox.Show(msg, "Maintain donations");
            if (msg.Contains("Successfully")) {
                radDonationAdd.Checked = true;
                LoadDonations();
                SetForm();
            }
        }
    }
}
