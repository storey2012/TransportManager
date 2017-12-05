using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace TransManager
{
    public partial class frmJobAdd : Form
    {
        Boolean blnLoading = true;
        Boolean bDirty = false;
        Combo objCombo = new Combo();
        IEnumerable<Driver> queryDriverbyWheelchair;
        Client client;
        private Notes collNotes;
        private Notes.NoteType _notetype;
        private string msgBoxTitle = "Add Job";


        Drivers collDrivers = new Drivers(ConfigurationManager.ConnectionStrings["TransManager"].ToString());


        public frmJobAdd()
        {
            InitializeComponent();
        }

        private void frmJobAdd_Load(object sender, EventArgs e)
        {
            
            objCombo.PopulateCombo(this.cboClientName, Combo.ComboName.Clients, "<Client>");
            objCombo.PopulateCombo(this.cboDriverLeg1, Combo.ComboName.Drivers, "<Allocate Driver>");
            objCombo.PopulateCombo(this.cboLeg1From, Combo.ComboName.Destination, "<Client Home>");
            objCombo.PopulateCombo(this.cboLeg1To, Combo.ComboName.Destination, "<Client Home>");
            objCombo.PopulateCombo(this.cboLeg2From, Combo.ComboName.Destination, "<Client Home>");
            objCombo.PopulateCombo(this.cboLeg2To, Combo.ComboName.Destination, "<Client Home>");
            objCombo.PopulateCombo(this.cboPickUp1Hour, Combo.ComboName.Hours, "<HH>");
            objCombo.PopulateCombo(this.cboPickUp1Minute, Combo.ComboName.Minutes, "<MM>");
            objCombo.PopulateCombo(this.cboAppt1Hour, Combo.ComboName.Hours, "<HH>");
            objCombo.PopulateCombo(this.cboAppt1Minute, Combo.ComboName.Minutes, "<MM>");
            objCombo.PopulateCombo(this.cboPickUp2Hour, Combo.ComboName.Hours, "<HH>");
            objCombo.PopulateCombo(this.cboPickUp2Minute, Combo.ComboName.Minutes, "<MM>");
            this.radReturn.Checked = true;
            dtpJobDate.Value = DateTime.Now.AddDays(-1);
            blnLoading = false;
            bDirty = false;
               
        }

        private void ResetForm() {
            blnLoading = true;
            cboClientName.SelectedIndex = 0;
            rtbClientDetails.Text = rtbNotes.Text = "";
            
            cboAppt1Hour.SelectedIndex = cboAppt1Minute.SelectedIndex = 0;
            cboPickUp1Hour.SelectedIndex = cboPickUp2Hour.SelectedIndex = 0;
            cboPickUp1Minute.SelectedIndex = cboPickUp2Minute.SelectedIndex = 0;
            cboLeg1From.SelectedIndex = cboLeg2From.SelectedIndex = 0;
            cboDriverLeg1.SelectedIndex = cboLeg1To.SelectedIndex = cboLeg2To.SelectedIndex = 0;
            rtbLeg1From.Text = rtbLeg2From.Text = rtbLeg1To.Text = rtbLeg2To.Text = string.Empty;
            radReturn.Checked = true;
            radDVCWheelchairNo.Checked  = true;
            dtpJobDate.Value = DateTime.Now;
            lvNotes.Items.Clear();
            clbAttributes.ClearSelected();
            
            radSourceClient.Checked = radSourceDriver.Checked = radSourceOther.Checked = false;
            dtpJobDate.Value = DateTime.Now.AddDays(-1);
            blnLoading = false;
            bDirty = false;
        }

        private void AllValidations() {

            ValidateDestinations(cboLeg1From, cboLeg1To);
            if (radReturn.Checked)
            {
                ValidateDestinations(cboLeg2From, cboLeg2To);
            }
            else {
                epError.SetError(cboLeg2To, "");
                epTick.SetError(cboLeg2To, "");
            }
            ValidateJobDate();

            ValidateTimes(cboAppt1Hour, cboAppt1Minute);
            btnAllocateJob.Enabled = ValidatePage();
            ValidateSource();
        }

        private void cboClientName_SelectedChangeCommitted(object sender, EventArgs e)
        {
            bDirty = true;
            client = new Client(Convert.ToInt32(this.cboClientName.SelectedValue.ToString()), true);
            this.rtbClientDetails.Clear();
            this.rtbClientDetails.Text = client.AddressLine1 + Environment.NewLine + client.Town + Environment.NewLine + client.Postcode + Environment.NewLine + client.MobilePhone;
            this.rtbClientDetails.Tag = client.AddressLine1 + Environment.NewLine + client.Town + Environment.NewLine + client.Postcode;
            client.LoadAttributes();
            LoadAttributes();
            collNotes = client.ClientNotes;
            LoadNotestoListView();
            rtbClientPhone.Clear();
            rtbClientPhone.Text += "Home Phone = " + (client.HomePhone == null ? string.Empty : client.HomePhone) + System.Environment.NewLine;
            rtbClientPhone.Text += "MobilePhone = " + (client.MobilePhone == null ? string.Empty : client.MobilePhone) + System.Environment.NewLine;


        }

        private void cboClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            this.dtpJobDate.Enabled = (this.cboClientName.SelectedIndex > 0);
            this.gbJobDetails.Enabled = (this.cboClientName.SelectedIndex > 0 && this.dtpJobDate.Value > DateTime.Now.AddDays(-1));
            this.cboClientName.BackColor = this.cboClientName.SelectedIndex > 0 ? Color.White : Color.Yellow;
            AllValidations();
            SetDestinationAddress(cboLeg1From, rtbLeg1From);
            SetDestinationAddress(cboLeg2From, rtbLeg2From);
            SetDestinationAddress(cboLeg1To, rtbLeg1To);
            SetDestinationAddress(cboLeg2To, rtbLeg2To);
            
        }

        private void radReturn_CheckedChanged(object sender, EventArgs e)
        {
            
            SetJourney();

        }

        private void SetJourney() {
            if (!blnLoading)
            {
                if (this.radReturn.Checked && cboLeg2From.SelectedIndex < 1)
                {
                    this.cboLeg2To.SelectedIndex = this.cboLeg1From.SelectedIndex;
                    this.cboLeg2From.SelectedIndex = this.cboLeg1To.SelectedIndex;
                }
                this.cboLeg2To.Enabled = this.cboLeg2From.Enabled = this.cboPickUp2Hour.Enabled = this.cboPickUp2Minute.Enabled = this.radReturn.Checked;
                
                AllValidations();
            }
        }

        private void radOneWay_CheckedChanged(object sender, EventArgs e)
        {
            //SetJourney();
        }

        private void rad2Leg_CheckedChanged(object sender, EventArgs e)
        {

            SetJourney();
        }

        
        private void cboLeg1To_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDestinationAddress(cboLeg1To, rtbLeg1To);
            ValidateDestinations(cboLeg1From, cboLeg1To);
            SetJourney();
        }
         

        

        
        private void ValidateDestinations(ComboBox start, ComboBox finish)
        {
            //if (start.Enabled)
            //{

            if (start.SelectedIndex == finish.SelectedIndex || start.SelectedIndex == -1 || finish.SelectedIndex == -1)
            {
                epError.SetError(finish, "Start and destination are invalid");
                epTick.SetError(finish, "");
                    finish.Tag = "1";
                }
                else
                {
                    epError.SetError(finish, "");
                    epTick.SetError(finish, "OK");
                    finish.Tag = "0";
                }
                
            }
            
        

        private Boolean ValidatePage() {
            Boolean blnValid = false;
            if (radOneWay.Checked)
            {
                blnValid = Convert.ToInt32(cboLeg1To.Tag) + Convert.ToInt32(cboAppt1Minute.Tag) == 0;
            }
            if (radReturn.Checked)
            {
                blnValid = Convert.ToInt32(cboLeg1To.Tag) + Convert.ToInt32(cboLeg2To.Tag) + Convert.ToInt32(cboAppt1Minute.Tag) == 0;
            }
            blnValid = Convert.ToInt32(radSourceClient.Checked) + Convert.ToInt32(radSourceDriver.Checked) + Convert.ToInt32(radSourceOther.Checked) > 0 && blnValid;

            cboDriverLeg1.Enabled = radSourceDriver.Checked;

            return blnValid;
        }
        private void ValidateJobDate() {
            if (dtpJobDate.Value < DateTime.Now.AddDays(-1))
            {
                epError.SetError(dtpJobDate, "Job date must not be in past");
            }
            else
            {
                epError.SetError(dtpJobDate, "");
            }
        }
        private void ValidateSource()
        {
            if ((Convert.ToInt32(radSourceClient.Checked) + Convert.ToInt32(radSourceDriver.Checked) + Convert.ToInt32(radSourceOther.Checked) > 0) && ((radSourceDriver.Checked && cboDriverLeg1.SelectedIndex > 0) || (!radSourceDriver.Checked)))
            {
                epError.SetError(lblSourceCheck, "");
                epTick.SetError(lblSourceCheck, "OK");
            }
            else
            {
                epError.SetError(lblSourceCheck, "Source must be indicated");
                epTick.SetError(lblSourceCheck, "");
            }
        }

        private bool ValidateTimes(ComboBox hours, ComboBox minutes) {
            if (hours.SelectedIndex < 1 || minutes.SelectedIndex < 1)
            {
                epError.SetError(minutes, "Appointment time must be set");
                epTick.SetError(minutes, "");
                minutes.Tag = 1;
                return false;
            }
            else {
                epError.SetError(minutes, "");
                epTick.SetError(minutes, "OK");
                minutes.Tag = 0;
                return true;
            }

        }
        private void cboPickUp2Hour_Validating(object sender, CancelEventArgs e)
        {
            //ValidatePickUpTimes(cboPickUp2Hour, cboPickUp2Minute);
        }

        private void cboPickUp2Minute_Validating(object sender, CancelEventArgs e)
        {
            //ValidatePickUpTimes(cboPickUp2Hour, cboPickUp2Minute);
        }

        private void cboLeg1From_Validating(object sender, CancelEventArgs e)
        {
            //ValidateDestinations(cboLeg1From, cboLeg1To);
        }

        private void cboLeg1To_Validating(object sender, CancelEventArgs e)
        {
            //ValidateDestinations(cboLeg1From, cboLeg1To);
        }

        private void cboLeg2From_Validating(object sender, CancelEventArgs e)
        {
            //ValidateDestinations(cboLeg2From, cboLeg2To);
        }

        private void cboLeg2To_Validating(object sender, CancelEventArgs e)
        {
            //ValidateDestinations(cboLeg2From, cboLeg2To);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAllocateJob_Click(object sender, EventArgs e)
        {
            Job job = new Job();
            if (dtpJobDate.Value < DateTime.Now.AddDays(-1)) {
                MessageBox.Show("A valid job date is needed");
                return;
            }
            RadioButton radSource = new RadioButton();
            try
            {
                radSource = gbSource.Controls.OfType<RadioButton>().First(r => r.Checked);
            }
            catch (SystemException err)
            {
                MessageBox.Show("Job Source must be selected", msgBoxTitle);
                string cch = err.Message;
                return;
            }

            if (radSource.Name == "radSourceDriver" && cboDriverLeg1.SelectedIndex < 1) {
                MessageBox.Show("Driver must be entered if Driver is source of Job", msgBoxTitle,MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (radSource.Name == "radSourceDriver" && (cboPickUp1Hour.SelectedIndex < 1 || (cboPickUp2Hour.SelectedIndex < 1 && radReturn.Checked)))
            {
                MessageBox.Show("Pick up times must be entered if Driver is source of Job", msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if(!ValidateAppointmentTime(cboAppt1Hour, cboAppt1Minute, cboPickUp1Hour, cboPickUp1Minute))
            {
                MessageBox.Show("Pick up time must be after appointment time", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            job.JobDate = new DateTime(dtpJobDate.Value.Year, dtpJobDate.Value.Month, dtpJobDate.Value.Day, 0, 0, 0);
            job.DVCWheelchair = radDVCWheelchairYes.Checked;
            

            job.Notes = this.rtbNotes.Text;
            job.ClientID = Convert.ToInt32(cboClientName.SelectedValue);
            job.SourceID = Convert.ToInt32(radSource.Tag);

            job.joblegs.Add(new JobLeg());
            

            job.joblegs[0].PickUpTime = job.JobDate.AddHours(Convert.ToInt32(cboPickUp1Hour.SelectedValue)==-1 ? 0 : Convert.ToInt32(cboPickUp1Hour.SelectedValue)).AddMinutes(Convert.ToInt32(cboPickUp1Minute.SelectedValue) == -1 ? 0 : Convert.ToInt32(cboPickUp1Minute.SelectedValue));
            
            job.joblegs[0].AppointmentTime = job.JobDate.AddHours(Convert.ToInt32(cboAppt1Hour.SelectedValue) == -1 ? 0 : Convert.ToInt32(cboAppt1Hour.SelectedValue)).AddMinutes(Convert.ToInt32(cboAppt1Minute.SelectedValue) == -1 ? 0 : Convert.ToInt32(cboAppt1Minute.SelectedValue));
            job.joblegs[0].DriverID = Convert.ToInt32(cboDriverLeg1.SelectedValue);
            job.joblegs[0].PickUpDestinationID = Convert.ToInt32(cboLeg1From.SelectedValue) == -1 ? 0 : Convert.ToInt32(cboLeg1From.SelectedValue);
            job.joblegs[0].DropDestinationID = Convert.ToInt32(cboLeg1To.SelectedValue) == -1 ? 0 : Convert.ToInt32(cboLeg1To.SelectedValue);

            if (!radOneWay.Checked) {
                job.joblegs.Add(new JobLeg());
                job.joblegs[1].PickUpTime = job.JobDate.AddHours(Convert.ToInt32(cboPickUp2Hour.SelectedValue) == -1 ? 0 : Convert.ToInt32(cboPickUp2Hour.SelectedValue)).AddMinutes(Convert.ToInt32(cboPickUp2Minute.SelectedValue) == -1 ? 0 : Convert.ToInt32(cboPickUp2Minute.SelectedValue));
                job.joblegs[1].DriverID = Convert.ToInt32(cboDriverLeg1.SelectedValue);
                job.joblegs[1].PickUpDestinationID = Convert.ToInt32(cboLeg2From.SelectedValue) == -1 ? 0 : Convert.ToInt32(cboLeg2From.SelectedValue);
                job.joblegs[1].DropDestinationID = Convert.ToInt32(cboLeg2To.SelectedValue) == -1 ? 0 : Convert.ToInt32(cboLeg2To.SelectedValue);
            }

            

            string msg = job.AddJob();
            MessageBox.Show(msg, msgBoxTitle);
            if (msg == "Successfully added job")
            {
                ResetForm();    
            }
        }

        private bool ValidateAppointmentTime(ComboBox boxHourA, ComboBox boxMinA, ComboBox boxHourPU, ComboBox boxMinPU) {
            if(boxHourA.SelectedValue == null || boxMinA.SelectedValue == null || boxHourPU.SelectedValue == null || boxMinPU.SelectedValue == null)
            {
                epError.SetError(boxMinPU, string.Empty);
                epTick.SetError(boxMinPU, string.Empty);
                return true;
            }
            if (Convert.ToInt32(boxHourA.SelectedValue) < 0 || Convert.ToInt32(boxMinA.SelectedValue) < 0 || Convert.ToInt32(boxHourPU.SelectedValue) < 0 || Convert.ToInt32(boxMinPU.SelectedValue) < 0) {
                epError.SetError(boxMinPU, string.Empty);
                epTick.SetError(boxMinPU, string.Empty);
                return true;
            }

            if (DateTime.Now.AddHours(Convert.ToInt32(boxHourA.SelectedValue)).AddMinutes(Convert.ToInt32(boxMinA.SelectedValue)) <= DateTime.Now.AddHours(Convert.ToInt32(boxHourPU.SelectedValue)).AddMinutes(Convert.ToInt32(boxMinPU.SelectedValue)))
            {
                epError.SetError(boxMinPU, "Pick up time must be before appointment");
                epTick.SetError(boxMinPU, "");
                boxMinPU.Tag = 1;
                return false;
            }
            else {
                epError.SetError(boxMinPU, "");
                
                epTick.SetError(boxMinPU, "OK");

                boxMinPU.Tag = 0;
                return true;
            }

            

        }

        private void cboLeg1From_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SetDestinationAddress(cboLeg1From, rtbLeg1From);
            ValidateDestinations(cboLeg1From, cboLeg1To);
            SetJourney();
        }

        private void SetDestinationAddress(ComboBox cboBox, RichTextBox rtbBox) {
            if (cboBox.SelectedValue != null)
            {
                if (Convert.ToInt32(cboBox.SelectedIndex) > 0)
                {
                    Destination dest = new Destination(Convert.ToInt32(cboBox.SelectedValue));
                    rtbBox.Text = dest.AddressLine1;
                    if (dest.AddressLine2 != string.Empty)
                    {
                        rtbBox.Text += ", " + dest.AddressLine2;
                    }
                    rtbBox.Text += Environment.NewLine + dest.Town + Environment.NewLine + dest.Postcode;
                }
                else
                {
                    rtbBox.Text = (string)rtbClientDetails.Tag;
                }
            }
        }
        
        

        private void cboPickUp1Hour_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ValidatePickUpTimes(cboPickUp1Hour, cboPickUp1Minute);
        }

        private void cboPickUp1Minute_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ValidatePickUpTimes(cboPickUp1Hour, cboPickUp1Minute);
        }

        private void cboAppt1Hour_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateTimes(cboAppt1Hour, cboAppt1Minute);
            ValidateAppointmentTime(cboAppt1Hour, cboAppt1Minute, cboPickUp1Hour, cboPickUp1Minute);
            btnAllocateJob.Enabled = ValidatePage();
        }

        private void cboAppt1Minute_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateTimes(cboAppt1Hour, cboAppt1Minute);
            ValidateAppointmentTime(cboAppt1Hour, cboAppt1Minute, cboPickUp1Hour, cboPickUp1Minute);
            btnAllocateJob.Enabled = ValidatePage();
        }

        

        
        

        private class select
        {
            public string Text { get; set; }
            public int Value { get; set; }
        }

        

        
        

        private void frmJobAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bDirty)
            {
                DialogResult dialogResult = MessageBox.Show("Data has not been saved." + Environment.NewLine + "Return to job entry form?", "Job Additions", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    e.Cancel = true;
                    this.Activate();
                    this.Focus();
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        

        private void cboLeg2To_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDestinationAddress(cboLeg2To, rtbLeg2To);
            ValidateDestinations(cboLeg2From, cboLeg2To);
            SetJourney();
        }

        private void cboLeg2From_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDestinationAddress(cboLeg2From, rtbLeg2From);
            ValidateDestinations(cboLeg2From, cboLeg2To);
            SetJourney();
        }

        private void LoadAttributes()
        {
            clbAttributes.Items.Clear();
            foreach (Attribute attribute in client.Attributes)
            {
                this.clbAttributes.Items.Add(attribute.Description, attribute.Checked);

            }

        }

        private void LoadNotestoListView()
        {
            Int32 i = 0;
            lvNotes.Items.Clear();
            if (collNotes.Count > 0)
            {
                foreach (Note note in collNotes)
                {
                    ListViewItem lvi = lvNotes.Items.Add(note.NoteText);
                    //ListViewItem lvi = lvNotes.Items.Add(note.NoteText);
                    lvi.BackColor = (i++ % 2 == 0) ? Color.LightBlue : Color.LightCyan;
                    lvi.ToolTipText = "Entered by " + note.EnteredBy + " on " + note.EnteredAt.ToShortDateString();
                }
            }
            else
            {
                ListViewItem lvi = lvNotes.Items.Add("There are no notes for this client.");
                lvi.SubItems.Add("There are no notes for this client.");
                
            }
        }

        private void radSourceClient_CheckedChanged(object sender, EventArgs e)
        {
            if (radSourceClient.Checked)
            {
                ValidateSource();
                btnAllocateJob.Enabled = ValidatePage();

            }
        }

        private void radSourceDriver_CheckedChanged(object sender, EventArgs e)
        {
            if (radSourceDriver.Checked)
            {
                ValidateSource();
                btnAllocateJob.Enabled = ValidatePage();
                
            }
        }

        private void radSourceOther_CheckedChanged(object sender, EventArgs e)
        {
            if (radSourceOther.Checked)
            {
                ValidateSource();
                btnAllocateJob.Enabled = ValidatePage();

            }
        }

        private void grpLeg1_Enter(object sender, EventArgs e)
        {

        }

        private void lvNotes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboDriverLeg1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateSource();
            if (cboDriverLeg1.SelectedIndex > 0) {
                Driver driver = new Driver(Convert.ToInt32(cboDriverLeg1.SelectedValue), false);
                if (driver.InsuranceExpiry < dtpJobDate.Value) {
                    MessageBox.Show("Driver has out of date insurance so cannot be allocated with job on this date", msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnAllocateJob.Enabled = false;
                    cboDriverLeg1.SelectedIndex = 0;

                    return;
                }
                if (driver.LicenceExpiry < dtpJobDate.Value)
                {
                    MessageBox.Show("Driver has out of date licence so cannot be allocated with job on this date", msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnAllocateJob.Enabled = false;
                    cboDriverLeg1.SelectedIndex = 0;
                    return;
                }
            }
        }

        private void dtpJobDate_ValueChanged(object sender, EventArgs e)
        {
            if (!blnLoading)
            {
                ValidateJobDate();
                if (dtpJobDate.Value < DateTime.Now.AddDays(-1))
                {
                    MessageBox.Show("Job date cannot be in the past", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpJobDate.Value = DateTime.Now;
                }

                this.gbJobDetails.Enabled = (this.cboClientName.SelectedIndex > 0 && this.dtpJobDate.Value > DateTime.Now.AddDays(-1));

                this.cboClientName.BackColor = this.cboClientName.SelectedIndex > 0 ? Color.White : Color.Yellow;
                AllValidations();
            }
        }

        private void cboPickUp1Hour_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ValidateAppointmentTime(cboAppt1Hour, cboAppt1Minute, cboPickUp1Hour, cboPickUp1Minute);
        }

        private void cboPickUp1Minute_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ValidateAppointmentTime(cboAppt1Hour, cboAppt1Minute, cboPickUp1Hour, cboPickUp1Minute);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
