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
    public partial class frmClientAdd : Form
    {
        public static frmClientAdd mInst;

        Client client;
        Boolean bDirty = false;

        public frmClientAdd()
        {
            InitializeComponent();
            client = new Client();
        }

        // Create a public static property that returns the state of the instance
        public static frmClientAdd CheckInst
        {
            get
            {
                return mInst;
            }
        }

        // Create a public static property that will create an instance of the form and return it
        public static frmClientAdd CreateInst
        {
            get
            {
                if (mInst == null)
                    mInst = new frmClientAdd();
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
            if (txtFirstName.Text == string.Empty || txtSurname.Text == string.Empty || txtAddressLine1.Text == string.Empty || txtTown.Text == string.Empty || mskPostCode.Text == string.Empty || (txtHomePhone.Text == string.Empty && txtMobilePhone.Text == string.Empty))
            {
                MessageBox.Show("All yellow entry fields plus one phone number must be entered");
                return;
            }

            if (radDonationYes.Checked && (txtReference.Text == string.Empty || mskAmount.Text == string.Empty)) {
                MessageBox.Show("Amount and Reference fields must be completed for donation.");
                return;
            }

            Clients collClient = new Clients();

            IEnumerable<Client> query;
            query = collClient.Where(s => s.Surname.ToUpper() == txtSurname.Text.ToUpper()).Where(s => s.AddressLine1.ToUpper() == txtAddressLine1.Text.ToUpper());

            Client clientdupe = new Client();
            try {
                clientdupe = query.First<Client>();
            }
            catch (SystemException a) {
                //do nowt just avoid bug
            }
                if (clientdupe.ClientID > 0) {
                DialogResult dialogResult = MessageBox.Show("A client is already registered at this address (" + clientdupe.FirstName + " " + (clientdupe.MiddleName==string.Empty ? string.Empty : clientdupe.MiddleName + string.Empty) + clientdupe.Surname + ")" + Environment.NewLine + "Continue saving this client?", "Client Additions", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }


            client.TitleID = Convert.ToInt32(this.cboTitle.SelectedValue.ToString()) < 1 ? 5 : Convert.ToInt32(this.cboTitle.SelectedValue.ToString());
            client.FirstName = this.txtFirstName.Text;
            client.MiddleName = this.txtMiddleName.Text;
            client.Surname = this.txtSurname.Text;
            client.AddressLine1 = this.txtAddressLine1.Text;
            client.AddressLine2 = this.txtAddressLine2.Text;
            client.Town = this.txtTown.Text;
            client.Postcode = this.mskPostCode.Text;
            client.HomePhone = this.txtHomePhone.Text;
            client.MobilePhone = this.txtMobilePhone.Text;
            client.DateOfBirth = this.dtpDOB.Value;
            client.Email = this.txtEmail.Text;
            
            client.isActive = true;
            string msg = client.Add();

            if (msg == "Successfully added client")
            {
                bDirty = false;
                if (rtbNotes.Text != string.Empty)
                {
                    Notes collNotes = new Notes(client.ClientID, Notes.NoteType.Client);
                    collNotes.AddNote(client.ClientID, rtbNotes.Text);
                }
                    //now add in the attributes.
                for (Int32 i = 0; i < this.clbAttributes.Items.Count; i++)
                {
                    client.Attributes[i].CheckedNew = this.clbAttributes.GetItemChecked(i);
                    client.Attributes[i].LinkID = client.ClientID;
                    client.Attributes[i].Update(Attribute.AttributeType.client);
                                        
                }

                if (radDonationYes.Checked) { 
                    Donations donations = new Donations();
                    
                    msg = donations.AddDonation(client.ClientID, dtpPaymentDate.Value, Convert.ToDecimal(mskAmount.Text.ToString().Replace("£","").Replace(" ", "")), txtReference.Text);
                    if (msg != "Successfully saved donation")
                    {
                        MessageBox.Show("Client saved but there has been a problem saving the donation - you can add the donation in the Client Edit form" + Environment.NewLine + msg, "Client Addition");
                        this.Close();
                    }
                    
                    
                    
                }

                MessageBox.Show("Successfully added Client", "Client Addition");
                this.Close();
            }
            

        }

        private void frmClientAdd_Load(object sender, EventArgs e)
        {
            LoadTitleCombo();
            LoadAttributes();
            dtpPaymentDate.Value = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
            bDirty = false;
        }

        private void LoadAttributes()
        {
            
            client.LoadAttributes();
            foreach (Attribute attribute in client.Attributes)
            {
                this.clbAttributes.Items.Add(attribute.Description, attribute.Checked);

            }
        }

        private void radDonationYes_CheckedChanged(object sender, EventArgs e)
        {
            pnlDonation.Enabled = radDonationYes.Checked;
        }

        


        private void frmClientAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bDirty)
            {
                DialogResult dialogResult = MessageBox.Show("Data has not been saved." + Environment.NewLine + "Return to client entry form?", "Client Additions", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    e.Cancel = true;
                    this.Activate();
                    this.Focus();
                }
            }
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

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void clbAttributes_SelectedIndexChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void rtbNotes_TextChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void dtpPaymentDate_ValueChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void mskAmount_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            bDirty = true;
        }

        private void txtReference_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            bDirty = true;
        }
    }
}
