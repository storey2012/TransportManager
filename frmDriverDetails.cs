using System;
using System.Linq;
using System.Windows.Forms;

namespace TransManager
{
    public partial class frmDriverDetails : Form
    {
        private int _driverid;
        Driver driver;
        private int parser;
        User _user;
            

        public frmDriverDetails(int driverid, User user)
        {
            _driverid = driverid;
            _user = user;
            InitializeComponent();
            driver = new Driver(_driverid, false);
            driver.LoadCars();
            this.Text = "Driver details for " + driver.FirstName + " " + driver.Surname;
            this.lblFooter.Text = "Driver: " + driver.FirstName + " " + driver.Surname + ", " + driver.AddressLine1 + " " + driver.Postcode; 
        }

        private void frmDriverDetails_Load(object sender, EventArgs e)
        {
            Combo objCombo = new Combo();

            objCombo.PopulateCombo(this.cboType, Combo.ComboName.CarType);
            objCombo.PopulateCombo(this.cboMake, Combo.ComboName.CarMake);
            objCombo.PopulateCombo(this.cboCarExisting, Combo.ComboName.CarsAll, "<Choose existing car>");
            objCombo.PopulateCombo(this.cboClientName, Combo.ComboName.Clients, "<Choose client to exclude>",3);
            
            if (driver.hasCar)
            {
                SetEdit(0);
                LoadExistingCars(false);
                this.radExisting.Checked = true;
            }
            else {
                this.radAdd.Checked = true;
                SetAdd();    
                                
            }
            LoadAbsences();
            SetAbsence();
            LoadExistingExclusions();
            LoadAttributes();
            SetCarDetails();
            SetInsuranceDetails();


        }
        private void LoadAttributes()
        {
            driver.LoadDriverAttributes();
            foreach (Attribute attribute in driver.Attributes.Where(a => a.AccessLevel <= User.CurrentAccessLevel)) {
                this.clbAttributes.Items.Add(attribute.Description, attribute.Checked);
            }
        }
            


        private void LoadExistingExclusions()
        {
            this.lvClientExclusions.Items.Clear();
            driver.LoadClientExclusions();

            foreach (ClientExclusion exclusion in driver.exclusions)
            {
                ListViewItem lvitem = this.lvClientExclusions.Items.Add(new ListViewItem(exclusion.ClientName));
                lvitem.Tag = exclusion.DriverClientExclusionID;
                lvitem.SubItems.Add(exclusion.Reason);
            }
        }

        private void LoadAbsences() {
            this.lvAbsence.Items.Clear();
            driver.LoadAbsence();
            foreach (Absence abs in driver.Absences) {
                ListViewItem lvi = this.lvAbsence.Items.Add(new ListViewItem(abs.Start.ToShortDateString()));
                lvi.SubItems.Add(abs.End.ToShortDateString());
                lvi.SubItems.Add(abs.Reason);
                lvi.SubItems[0].Tag = abs.DriverAbsenceID;
            }
        }

        private void LoadExistingCars(bool bLatest) {
            this.lbCars.Items.Clear();
            foreach (Car car in driver.cars)
            {
                lbCars.Items.Add(car.RegNo + " - " + car.Make);
                if (car.CarID == driver.CurrentCarID) {
                    this.lbCars.SelectedIndex = lbCars.SelectedIndex = lbCars.Items.Count - 1;
                }
                
            }
            //if (driver.cars.Count > 0)
            //{
            //    this.lbCars.SelectedIndex = bLatest ? lbCars.SelectedIndex = lbCars.Items.Count-1 : 0;
            //}
        }

        private void SetEdit(int carno) {
            
            Car car;
            
            if (driver.hasCar)
            {
                car = driver.cars[carno];
                this.txtCarID.Text = car.CarID.ToString();
                this.txtReg.Text = car.RegNo;
                this.txtSeats.Text = car.Seats.ToString();
                this.txtModel.Text = car.Model;
                this.txtColour.Text = car.Colour;

                this.cboMake.SelectedValue = car.MakeID;
                this.cboType.SelectedValue = car.TypeID;

                this.txtInsuranceID.Text = car.InsuranceID.ToString();
                this.txtCompany.Text = car.InsuranceCompany;
                this.txtPolicyNo.Text = car.InsurancePolicyNo;
                this.txtPolicyHolder.Text = car.InsurancePolicyHolder;
                this.dtpInsStart.Value = car.InsuranceStart;
                this.dtpInsExpire.Value = car.InsuranceExpire;
                this.cboCarExisting.Visible = this.radAssign.Checked;
                this.btnAssign.Visible = this.radAssign.Checked;
                this.lbCars.Visible = this.radExisting.Checked;
                
                
            }
            else {
                MessageBox.Show("This driver does not have a car assigned yet.");
                this.radAdd.Checked = true;
            }
            if (this.lbCars.Items.Count > 0)
            {
                this.lbCars.SelectedItem = carno;
            }
            SetAll();
            
        }

        private void SetAdd() {
            
            this.txtCarID.Text = "0";
            
            this.btnUpdate.Text = "Add car details";
            
            this.txtReg.Text = String.Empty;
            this.txtSeats.Text = String.Empty;
            this.txtModel.Text = String.Empty;
            this.txtColour.Text = String.Empty;

            

            this.cboMake.SelectedValue = -1;
            this.cboType.SelectedValue = -1;

            this.txtInsuranceID.Text = String.Empty;
            this.txtCompany.Text = String.Empty;
            this.txtPolicyNo.Text = String.Empty;
            this.txtPolicyHolder.Text = String.Empty;
            this.dtpInsStart.Value = dtpInsStart.Value;
            this.dtpInsExpire.Value = dtpInsExpire.Value;
            
            this.cboCarExisting.Visible = this.radAssign.Checked;
            this.btnAssign.Visible = this.radAssign.Checked;
            this.lbCars.Visible = this.radExisting.Checked;
            
            SetAll();
        }

        private void SetAssign() {
            SetAdd();
            
        }
        
        private void SetUnassign()
        {
            SetEdit(this.lbCars.SelectedIndex>-1 ? this.lbCars.SelectedIndex : 0);
            SetAll();
            this.btnUpdate.Text = "Un-assign this vehicle";
        }
        
        private void SetAll() {
            this.cboCarExisting.Visible = this.radAssign.Checked;
            this.btnAssign.Visible = this.radAssign.Checked;
            this.lbCars.Visible = this.radExisting.Checked || this.radUnassign.Checked;
            this.pnCarDetails.Enabled = !this.radAssign.Checked;
            this.lblChooser.Visible = !this.radAdd.Checked;
            this.lblCarID.Visible = this.txtCarID.Visible = (this.radExisting.Checked || this.radUnassign.Checked);
            
            if (this.radExisting.Checked)
            {
                this.lblChooser.Text = "Choose Vehicle to update:";
            }
            if (this.radAssign.Checked)
            {
                this.lblChooser.Text = "Choose Existing vehicle to Assign:";
            }
            
            if (this.radUnassign.Checked)
            {
                this.lblChooser.Text = "Choose Existing vehicle to Un-Assign:";
            }
            
            if (this.lbCars.Items.Count > 0) {
                this.lbCars.SelectedItem = 0;
            }
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.txtReg.Text == string.Empty) {
                MessageBox.Show("Car registration must be completed");
                return;
            }
            
            if (this.txtPolicyNo.Text == string.Empty && ((int.TryParse(this.txtInsuranceID.Text, out parser)) ? int.Parse(this.txtInsuranceID.Text) : 0) > 0) {
                MessageBox.Show("Policy number cannot be blank once it has been assigned.");
                return;
            }
            
            if (radUnassign.Checked) { 
                int carid;

                carid = Convert.ToInt32(this.txtCarID.Text);
                MessageBox.Show(driver.UnassignCar(carid));
                LoadExistingCars(false);
                return;
            }

            Car car;
            if (btnUpdate.Text == "Add car details")
            {
                car = new Car();
            }
            else {
                car = (Car)driver.cars.First(c => c.CarID == Convert.ToInt32(this.txtCarID.Text));
            }
            
            car.RegNo = this.txtReg.Text;
            
            car.Seats = (int.TryParse(this.txtSeats.Text, out parser)) ? int.Parse(this.txtSeats.Text) : 0;
            

            if (this.cboMake.SelectedValue == null)
            {
                car.MakeID = 1;
            }
            else {
                car.MakeID = Convert.ToInt32(this.cboMake.SelectedValue);
            }

            if (this.cboType.SelectedValue == null)
            {
                car.TypeID = 1;
            }
            else
            {
                car.TypeID = Convert.ToInt32(this.cboType.SelectedValue);
            }
            car.Model = this.txtModel.Text;
            car.InsurancePolicyHolder = this.txtPolicyHolder.Text;
            car.InsurancePolicyNo = this.txtPolicyNo.Text;
            car.InsuranceCompany = this.txtCompany.Text;
            car.InsuranceStart = this.dtpInsStart.Value;
            car.InsuranceExpire = this.dtpInsExpire.Value;
            
            car.Colour = this.txtColour.Text;

            if (this.btnUpdate.Text == "Update")
            {
                MessageBox.Show(car.Update());
                driver.LoadCars();
                LoadExistingCars(false);
            }
            else
            {
                MessageBox.Show(car.Add(driver.DriverID));
                driver.LoadCars();
                LoadExistingCars(false);
            }
            SetAdd();
            this.radExisting.Checked = true;
        }

        

        private void radAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radAdd.Checked)
            {
                SetAdd();
            }
                        
        }

        private void radAssign_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radAssign.Checked)
            {
                SetAssign();
            }
            

        }

        private void radUnassign_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radUnassign.Checked) {
                SetUnassign();
            }
        }


        private void radExisting_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radExisting.Checked)
            {
                btnUpdate.Text = "Update";
                SetEdit(this.lbCars.SelectedIndex>-1 ? this.lbCars.SelectedIndex : 0);
            }
           }

        private void lbCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEdit(((ListBox)sender).SelectedIndex);
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            MessageBox.Show(driver.AssignCar(System.Convert.ToInt32(this.cboCarExisting.SelectedValue.ToString())));
            LoadExistingCars(true);
            radExisting.Checked = true;                  
        }

        private void lvAbsence_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAbsence.SelectedItems.Count > 0)
            {
                this.mskFrom.Text = lvAbsence.SelectedItems[0].SubItems[0].Text;
                this.mskTo.Text = lvAbsence.SelectedItems[0].SubItems[1].Text;
                this.txtReason.Text = lvAbsence.SelectedItems[0].SubItems[2].Text;
                this.btnModify.Enabled = true;
                if (this.radAbsenceAdd.Checked) {
                    this.radAbsenceUpdate.Checked = true;
                }
            }
                       
        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {
            btnModify.Enabled = true;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (btnModify.Text == "Add") {
                Absence abs = new Absence();
                try
                {
                    abs.Start = Convert.ToDateTime(mskFrom.Text);
                    abs.End = Convert.ToDateTime(mskTo.Text);
                }
                catch (SystemException err) {
                    MessageBox.Show("Date is in wrong format");
                    return;
                }
                abs.Reason = txtReason.Text;
                MessageBox.Show(abs.Add(driver.DriverID));
                
            }
            else
            {
                Absence abs = driver.Absences[lvAbsence.SelectedIndices[0]];
                try
                {
                    abs.Start = Convert.ToDateTime(mskFrom.Text);
                    abs.End = Convert.ToDateTime(mskTo.Text);
                }
                catch (SystemException err)
                {
                    MessageBox.Show("Date is in wrong format");
                    return;
                }
                abs.Reason = txtReason.Text;
                abs.DriverAbsenceID = (int)lvAbsence.SelectedItems[0].SubItems[0].Tag;
                if (btnModify.Text == "Update")
                {
                    MessageBox.Show(abs.Update());
                }
                else
                {
                    MessageBox.Show(abs.Delete());
                }
            }
            LoadAbsences();
        }

        private void radAbsenceDelete_CheckedChanged(object sender, EventArgs e)
        {
            this.btnModify.Text = "Delete";
            SetAbsence();
        }

        private void radAbsenceUpdate_CheckedChanged(object sender, EventArgs e)
        {
            this.btnModify.Text = "Update";
            SetAbsence();
        }

        private void radAbsenceAdd_CheckedChanged(object sender, EventArgs e)
        {
            this.btnModify.Text = "Add";
            
            SetAbsence();
        }

        private void SetAbsence() {
            //only enabled for Update/delete
           // this.lvAbsence.Enabled = !this.radAbsenceAdd.Checked;
            //entry boxes only enable for add/update
            this.txtReason.Enabled = !this.radAbsenceDelete.Checked;
            this.mskFrom.Enabled = !this.radAbsenceDelete.Checked;
            this.mskTo.Enabled = !this.radAbsenceDelete.Checked;
            //button not enable for update/delete as the user will need to select an absence first.
            this.btnModify.Enabled = this.radAbsenceAdd.Checked;
            this.lvAbsence.SelectedItems.Clear();
            if (this.radAbsenceAdd.Checked)
            {
                this.mskFrom.Text = System.DateTime.Today.ToShortDateString();
                this.mskTo.Text = System.DateTime.Today.AddDays(7).ToShortDateString();
                this.txtReason.Text = string.Empty;
            }
            else {
                                
            }

        }
        private void radExclusionRemove_CheckedChanged(object sender, EventArgs e)
        {
            SetExclusions();
        }
        private void SetExclusions()
        {
            this.gbExclusionAdd.Visible = this.radExclusionAdd.Checked;
            this.lvClientExclusions.Enabled = this.btnClientRemove.Visible = this.radExclusionRemove.Checked;
            
        }

        private void radExclusionAdd_CheckedChanged(object sender, EventArgs e)
        {
            SetExclusions();
        }

        

        private void btnClientRemove_Click(object sender, EventArgs e)
        {
            if (this.lvClientExclusions.SelectedItems.Count > 0)
            {
                MessageBox.Show(driver.exclusions.RemoveExclusion(Convert.ToInt32(this.lvClientExclusions.SelectedItems[0].Tag)));
                LoadExistingExclusions();
            }
            else {
                MessageBox.Show("No client selected", "client exclusions");
            }
        }

        private void btnClientExclude_Click(object sender, EventArgs e)
        {
            MessageBox.Show(driver.exclusions.AddExclusion(driver.DriverID, Convert.ToInt32(this.cboClientName.SelectedValue), this.txtExclusionReason.Text));
            LoadExistingExclusions();
        }

        private void gbAttributes_Enter(object sender, EventArgs e)
        {

        }

        private void clbAttributes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateAttributes_Click(object sender, EventArgs e)
        {
            driver.LoadDriverAttributes();
            for (Int32 i = 0; i < this.clbAttributes.Items.Count; i++){
                //CheckState st = clbAttributes.GetItemCheckState(clbAttributes.Items[i].);

                driver.Attributes[i].CheckedNew = this.clbAttributes.GetItemChecked(i);
                //if ((driver.Attributes[i].LinkAttributeID > 0 && (!driver.Attributes[i].Checked)) || (driver.Attributes[i].LinkAttributeID==0 && driver.Attributes[i].Checked))
                //{
                //    driver.Attributes[i].Update(Attribute.AttributeType.driver);
                //}
                if (driver.Attributes[i].Checked != driver.Attributes[i].CheckedNew) {
                    driver.Attributes[i].Update(Attribute.AttributeType.driver);
                }
            }
            MessageBox.Show("Attributes updated", "Driver Details");
        }

        private void clbAttributes_Click(object sender, EventArgs e)
        {
            this.btnUpdateAttributes.Enabled = true;
        }

        private void txtPolicyNo_KeyUp(object sender, KeyEventArgs e)
        {
            SetInsuranceDetails();
        }
        private void SetInsuranceDetails() { 
            this.txtPolicyHolder.Enabled = this.dtpInsStart.Enabled = this.dtpInsExpire.Enabled = this.txtCompany.Enabled = this.txtPolicyNo.Text != string.Empty;
        }
        

        private void SetCarDetails() {
            this.txtPolicyNo.Enabled = this.cboType.Enabled = this.cboMake.Enabled = this.txtModel.Enabled = this.txtColour.Enabled = this.txtSeats.Enabled = this.txtReg.Text != string.Empty;
        }

        private void txtReg_TextChanged(object sender, EventArgs e)
        {
            SetCarDetails();
        }

        private void cboCarExisting_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvClientExclusions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}