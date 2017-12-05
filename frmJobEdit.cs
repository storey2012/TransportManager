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
    public partial class frmJobEdit : Form
    {
        Job job;
        Client client;
        Combo objCombo = new Combo();
        Boolean bApptChange = false;
        DateTime dtAppt;

        public frmJobEdit()
        {
            InitializeComponent();
        }

        private void frmJobEdit_Load(object sender, EventArgs e)
        {
            objCombo.PopulateCombo(this.cboDriverLeg1, Combo.ComboName.Drivers, "");
            //objCombo.PopulateCombo(this.cboDriverLeg2, Combo.ComboName.Drivers, "<Optional Leg 2 Driver>");
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
            objCombo.PopulateCombo(this.cboJobs, Combo.ComboName.Jobs, "<Select Job>");
                
            this.rad2Leg.Checked = true;
       }

        private void AllValidations() {

            /**ValidatePickUpTimes(cboPickUp2Hour, cboPickUp2Minute);
            
            **/
            ValidateDestinations(cboLeg1From, cboLeg1To);
            ValidateDestinations(cboLeg2From, cboLeg2To);
            
        }

        
        private void SetJourney() {
            this.cboLeg2To.Enabled = this.cboLeg2From.Enabled = true;
            this.cboLeg2To.Enabled = this.cboLeg2From.Enabled = this.rad2Leg.Checked;
            
            AllValidations();
        }

        private void radOneWay_CheckedChanged(object sender, EventArgs e)
        {
            if (job.joblegs.Count > 1 && radOneWay.Checked) {
                DialogResult dialogresult = MessageBox.Show("Changing from 2 legs to 1 leg will permanently remove Leg 2 - Do you want to continue?", "Update Job", MessageBoxButtons.YesNo);
                if (dialogresult != DialogResult.Yes)
                {
                    job.DeleteJobLeg(1);
                }
                
            }
            SetJourney();
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
            if (start.Enabled)
            {
                if (start.SelectedIndex == finish.SelectedIndex || start.SelectedIndex==-1 || finish.SelectedIndex == -1)
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

            //btnAllocateJob.Enabled = (Convert.ToInt32(cboLeg1To.Tag) + ((cboLeg2To.Enabled) ? Convert.ToInt32(cboLeg2To.Tag) : 0) + Convert.ToInt32(cboPickUp1Minute.Tag) + ((cboPickUp2Minute.Enabled) ? Convert.ToInt32(cboPickUp2Minute.Tag) : 0) == 0);

        }

        private void btnAllocateJob_Click(object sender, EventArgs e)
        {
            if (this.cboJobs.SelectedIndex < 1) {
                MessageBox.Show("No job has been selected!", "Unable to save job");
                return;
            }
            if ((cboLeg1To.SelectedIndex==cboLeg1From.SelectedIndex) && (cboAppt1Hour.SelectedIndex + cboAppt1Minute.SelectedIndex + cboPickUp1Hour.SelectedIndex + cboPickUp1Minute.SelectedIndex) == 0)
            {
                MessageBox.Show("No valid details for Leg 1 have been entered!","Unable to save job",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (!ValidateAppointmentTime(cboAppt1Hour, cboAppt1Minute, cboPickUp1Hour, cboPickUp1Minute))
            {
                MessageBox.Show("Pick up time must be before appointment time", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
    
            job.DVCWheelchair = radWheelchairYes.Checked;
            job.JobDate = dtpLeg1.Value;
            job.Notes = rtbNotes.Text;
            
            job.joblegs[0].AppointmentTime = job.JobDate.AddHours(Convert.ToDouble(cboAppt1Hour.SelectedValue)).AddMinutes(Convert.ToDouble(cboAppt1Minute.SelectedValue));
            job.joblegs[0].PickUpTime = job.JobDate.AddHours(Convert.ToDouble(cboPickUp1Hour.SelectedValue)).AddMinutes(Convert.ToDouble(cboPickUp1Minute.SelectedValue));
            job.joblegs[0].PickUpDestinationID = Convert.ToInt32(cboLeg1From.SelectedValue) == -1 ? 0 : Convert.ToInt32(cboLeg1From.SelectedValue);
            job.joblegs[0].DropDestinationID = Convert.ToInt32(cboLeg1To.SelectedValue) == -1 ? 0 : Convert.ToInt32(cboLeg1To.SelectedValue);
            //job.joblegs[0].DriverID = Convert.ToInt32(cboDriverLeg1.SelectedValue);
            if (radOneWay.Checked && job.joblegs.Count > 1) {
                job.DeleteJobLeg(1);
                if (job.joblegs.Count > 1) {
                    job.DeleteJobLeg(1);
                }
            }
            if (!radOneWay.Checked)
            {
                if (job.joblegs.Count == 1)
                {
                    job.joblegs.Add(new JobLeg());
                }
                job.joblegs[1].PickUpTime = job.JobDate.AddHours(Convert.ToInt32(cboPickUp2Hour.SelectedValue) == -1 ? 0 : Convert.ToInt32(cboPickUp2Hour.SelectedValue)).AddMinutes(Convert.ToInt32(cboPickUp2Minute.SelectedValue) == -1 ? 0 : Convert.ToInt32(cboPickUp2Minute.SelectedValue));
                job.joblegs[1].DriverID = Convert.ToInt32(cboDriverLeg1.SelectedValue);
                job.joblegs[1].PickUpDestinationID = Convert.ToInt32(cboLeg2From.SelectedValue) == -1 ? 0 : Convert.ToInt32(cboLeg2From.SelectedValue);
                job.joblegs[1].DropDestinationID = Convert.ToInt32(cboLeg2To.SelectedValue) == -1 ? 0 : Convert.ToInt32(cboLeg2To.SelectedValue);
            }
            
            string msg = job.UpdateJob((!(dtAppt == job.joblegs[0].AppointmentTime)) && Convert.ToInt32(cboDriverLeg1.SelectedValue)>0);
            MessageBox.Show(msg);
            if (msg == "Successfully added job")
            {
                ResetForm();
            }

        }

        private bool ValidateAppointmentTime(ComboBox boxHourA, ComboBox boxMinA, ComboBox boxHourPU, ComboBox boxMinPU)
        {
            if (boxHourA.SelectedValue == null || boxMinA.SelectedValue == null || boxHourPU.SelectedValue == null || boxMinPU.SelectedValue == null)
            {
                epError.SetError(boxMinPU, string.Empty);
                epTick.SetError(boxMinPU, string.Empty);
                return true;
            }
            if (Convert.ToInt32(boxHourA.SelectedValue) < 0 || Convert.ToInt32(boxMinA.SelectedValue) < 0 || Convert.ToInt32(boxHourPU.SelectedValue) < 0 || Convert.ToInt32(boxMinPU.SelectedValue) < 0)
            {
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
            else
            {
                epError.SetError(boxMinPU, "");

                epTick.SetError(boxMinPU, "OK");

                boxMinPU.Tag = 0;
                return true;
            }


        }

        

        private void ResetForm() {
            rtbClientDetails.Clear();
            
        }

        private void LoadAttributes()
        {
            clbAttributes.Items.Clear();
            foreach (Attribute attribute in client.Attributes)
            {
                this.clbAttributes.Items.Add(attribute.Description, attribute.Checked);

            }

        }

        private void cboLeg1From_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDestinationAddress(cboLeg1From, rtbLeg1From);
            ValidateDestinations(cboLeg1From, cboLeg1To);
            SetJourney();
        }

        private void SetDestinationAddress(ComboBox cboBox, RichTextBox rtbBox) {
            SetDestinationAddress(cboBox, rtbBox, false);
        }

        private void SetDestinationAddress(ComboBox cboBox, RichTextBox rtbBox, Boolean blnName)
        {
            rtbBox.Clear();
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
                    if (job != null)
                    {
                        rtbBox.Text += job.ClientAddressLine1 + Environment.NewLine + ((job.ClientAddressLine2 == string.Empty) ? "" : job.ClientAddressLine2 + Environment.NewLine) + job.ClientTown + Environment.NewLine + job.ClientPostCode;
                    }
                }
            }
        }

        private void cboLeg2From_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDestinationAddress(cboLeg2From, rtbLeg2From);

            ValidateDestinations(cboLeg2From, cboLeg2To);
        }
        private void cboLeg2To_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDestinationAddress(cboLeg2To, rtbLeg2To);
            ValidateDestinations(cboLeg2From, cboLeg2To);
        }

        private void cboPickUp1Hour_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ValidatePickUpTimes(cboPickUp1Hour, cboPickUp1Minute);
        }

        private void cboPickUp1Minute_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ValidatePickUpTimes(cboPickUp1Hour, cboPickUp1Minute);
        }

        private void cboDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboDriverLeg1.Tag.ToString() == "clean") {
            //    if (cboDriverLeg1.SelectedIndex > 0)
            //    {
            //        cboDriverLeg1.Tag = "dirty";
            //        cboDriverLeg2.SelectedIndex = cboDriverLeg1.SelectedIndex;
            //        cboDriverLeg2.Enabled = true;
            //    }
            //}
        }

        private void cboJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpLeg1.Enabled = cboJobs.SelectedIndex > 0;

            if (this.cboJobs.SelectedIndex > 0)
            {
                SetUpJob(Convert.ToInt32(cboJobs.SelectedValue));
            }
            
        }

        private void SetUpJob(int jobid) {

            job = new Job(jobid);
            client = new Client(job.ClientID, true);

            dtAppt = job.JobDate.AddHours(job.joblegs[0].PickUpTime.Hour).AddMinutes(job.joblegs[0].PickUpTime.Minute);
            client.LoadAttributes();
            LoadAttributes();
            this.rtbClientDetails.Text = job.ClientName + Environment.NewLine + job.ClientAddressLine1 + Environment.NewLine + ((job.ClientAddressLine2 == string.Empty) ? "" : job.ClientAddressLine2 + Environment.NewLine);
            this.rtbClientDetails.Text += job.ClientTown + Environment.NewLine + job.ClientPostCode;
            this.dtpLeg1.Value = job.JobDate;
            this.radWheelchairYes.Checked = job.DVCWheelchair;
            this.cboDriverLeg1.SelectedValue = job.joblegs[0].DriverID;
            
            this.rtbNotes.Text = job.Notes;
            //this.cboJobStatus.SelectedValue = job.StatusID;
            this.radOneWay.Checked = (job.joblegs.Count == 1);
            //this.rad2Leg.Checked = (!this.radOneWay.Checked && !this.radReturn.Checked);
            this.cboPickUp1Hour.SelectedValue = job.joblegs[0].PickUpTime.Hour;
            this.cboPickUp1Minute.SelectedValue = job.joblegs[0].PickUpTime.Minute;
            this.cboAppt1Hour.SelectedValue = job.joblegs[0].AppointmentTime.Hour;
            this.cboAppt1Minute.SelectedValue = job.joblegs[0].AppointmentTime.Minute;
            
            this.cboLeg1From.SelectedValue = job.joblegs[0].PickUpDestinationID == 0 ? -1 : job.joblegs[0].PickUpDestinationID;
            this.cboLeg1To.SelectedValue = job.joblegs[0].DropDestinationID == 0 ? -1 : job.joblegs[0].DropDestinationID;
            

            if (job.joblegs.Count > 1)
            {
                this.cboPickUp2Hour.SelectedValue = job.joblegs[1].PickUpTime.Hour;
                this.cboPickUp2Minute.SelectedValue = job.joblegs[1].PickUpTime.Minute;
                this.cboLeg2From.SelectedValue = job.joblegs[1].PickUpDestinationID == 0 ? -1 : job.joblegs[1].PickUpDestinationID;
                this.cboLeg2To.SelectedValue = job.joblegs[1].DropDestinationID==0 ? -1 : job.joblegs[1].DropDestinationID;
                
                cboLeg2From_SelectedIndexChanged(new object(), new EventArgs());
                cboLeg2To_SelectedIndexChanged(new object(), new EventArgs());
            }
            
            //cboLeg1To_SelectedIndexChanged(new object(), new EventArgs());

            radOneWay.Checked = job.joblegs.Count == 1;
            dtpLeg1.Enabled = !(job.joblegs[0].DriverID > 0);
            lblDateChange1.Visible = lblDateChange2.Visible = lblDateChange3.Visible = job.joblegs[0].DriverID > 0;
           
            cboLeg1To.Enabled = true;
            cboLeg1From.Enabled = true;
            cboLeg1From_SelectedIndexChanged(new object(), new EventArgs());
        }

        private void cboLeg1From_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SetDestinationAddress(cboLeg1From, rtbLeg1From);
            ValidateDestinations(cboLeg1From, cboLeg1To);
            SetJourney();
        }

        private void btnJobSearch_Click(object sender, EventArgs e)
        {
            frmJobSearch jobsearch = new frmJobSearch();
            jobsearch.StartPosition = FormStartPosition.Manual;

            jobsearch.ShowDialog();
            
        }

        private void cboAppt1Hour_SelectedIndexChanged(object sender, EventArgs e)
        {
            bApptChange = true;
            ValidateAppointmentTime(cboAppt1Hour, cboAppt1Minute, cboPickUp1Hour, cboPickUp1Minute);
        }

        private void cboAppt1Minute_SelectedIndexChanged(object sender, EventArgs e)
        {
            bApptChange = false;
            ValidateAppointmentTime(cboAppt1Hour, cboAppt1Minute, cboPickUp1Hour, cboPickUp1Minute);
        }

        private void dtpLeg1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void cboPickUp1Hour_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ValidateAppointmentTime(cboAppt1Hour, cboAppt1Minute, cboPickUp1Hour, cboPickUp1Minute);
        }

        private void cboPickUp1Minute_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ValidateAppointmentTime(cboAppt1Hour, cboAppt1Minute, cboPickUp1Hour, cboPickUp1Minute);
        }

        private void dtpLeg1_Validating(object sender, CancelEventArgs e)
        {
            //MessageBox.Show("nope");
            //e.Cancel = true;
        }

        private void dtpLeg1_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show("nope");
        }

        private void dtpLeg1_MouseMove(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("nope");
        }

        private void grpLeg1_Enter(object sender, EventArgs e)
        {

        }

        private void cboDriverLeg1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ValidateAll();
        }
    }

}
