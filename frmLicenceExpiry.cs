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
    public partial class frmLicenceExpiry : Form
    {

        Driver driver;
        Combo objCombo = new Combo();
        Attribute.ExpiryType expirytype;
        
        public frmLicenceExpiry(Attribute.ExpiryType expiry)
        {
            InitializeComponent();
            expirytype = expiry;
        }

        private void frmLicenceExpiry_Load(object sender, EventArgs e)
        {
            
            objCombo.PopulateCombo(this.cboDriver, (expirytype == Attribute.ExpiryType.insurance) ? Combo.ComboName.InsuranceExpiry : Combo.ComboName.LicenceExpiry , "<Choose Driver>", 3);
            if (expirytype == Attribute.ExpiryType.insurance) {
                rad44.Tag = "47";
                rad45.Tag = "48";
                rad46.Tag = "49";

            }
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            RadioButton radPhone;
            RadioButton radAttribute;
            string msg;

            try {
                radAttribute = gbDriverContact.Controls.OfType<RadioButton>().First(r => r.Checked);
            }
            catch (SystemException err) {
                string x = err.Message;
                MessageBox.Show("Contact Method must be selected", this.Text);
                return;
            }

            try
            {
                radPhone = gbDriverPhone.Controls.OfType<RadioButton>().First(r => r.Checked);
            }
            catch (SystemException i)
            {
                string x = i.Message;
                MessageBox.Show("Phone must be selected", this.Text);
                return;
            }

            driver = new Driver(Convert.ToInt32(cboDriver.SelectedValue), false);
            driver.Attributes.Add(new Attribute());
            driver.Attributes[0].LinkID = driver.DriverID;
            driver.Attributes[0].AttributeID = Convert.ToInt32(radAttribute.Tag);
            driver.Attributes[0].Description = radPhone.Text;
            driver.Attributes[0].CheckedNew = true;
            try
            {
                msg = driver.Attributes[0].Update(Attribute.AttributeType.driver);
            }
            catch (SystemException errSQL) {
                MessageBox.Show(errSQL.Message, this.Name);
                return;
            }

            if (msg != "Successfully updated attribute")
            {
                MessageBox.Show(msg, this.Name);
                return;
            }
            else {
                MessageBox.Show("Driver contact added");
            }

            objCombo.PopulateCombo(cboDriver, (expirytype == Attribute.ExpiryType.insurance) ? Combo.ComboName.InsuranceExpiry : Combo.ComboName.LicenceExpiry, "<Choose Driver>", 3);
            rad44.Checked = rad45.Checked = rad46.Checked = radPhoneHome.Checked = radPhoneMobile.Checked = radPhoneOther.Checked = false;        
        }
    }
}
