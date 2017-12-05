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
    public partial class frmJobQueue : Form
    {
        Boolean bDirty = false;
        Drivers drivers = new Drivers();
        public enum LinkType { Client, Driver};
        Jobs jobs;
        //Job currentjob;
        Client client;
        string msgBoxTitle = "Job Queue Management";
        Job job = new Job();
        Driver driver;
        Notes drivernotes;
        frmDailyList frmDaily;
        private Notes collNotes;

        public frmJobQueue()
        {
            InitializeComponent();
            
            Sizer.ResizeForm(this);
            scTreeView.Panel1Collapsed = false;
            scTreeView.Panel2Collapsed = true;

        }

        private void frmJobQueue_Load(object sender, EventArgs e)
        {
            LoadTreeView();
            Combo objCombo = new Combo();
            objCombo.PopulateCombo(this.cboPickUp1Hour, Combo.ComboName.Hours, "HH");
            objCombo.PopulateCombo(this.cboPickUp1Minute, Combo.ComboName.Minutes, "MM");
            objCombo.PopulateCombo(this.cboPickUp2Hour, Combo.ComboName.Hours, "HH");
            objCombo.PopulateCombo(this.cboPickUp2Minute, Combo.ComboName.Minutes, "MM");
            objCombo.PopulateCombo(this.cboAppt1Hour, Combo.ComboName.Hours, "HH");
            objCombo.PopulateCombo(this.cboAppt1Minute, Combo.ComboName.Minutes, "MM");
            objCombo.PopulateCombo(this.cboCPickUp1Hour, Combo.ComboName.Hours, "HH");
            objCombo.PopulateCombo(this.cboCPickUp1Minute, Combo.ComboName.Minutes, "MM");
            objCombo.PopulateCombo(this.cboCPickUp2Hour, Combo.ComboName.Hours, "HH");
            objCombo.PopulateCombo(this.cboCPickUp2Minute, Combo.ComboName.Minutes, "MM");
            objCombo.PopulateCombo(this.cboCAppt1Hour, Combo.ComboName.Hours, "HH");
            objCombo.PopulateCombo(this.cboCAppt1Minute, Combo.ComboName.Minutes, "MM");
            bDirty = false;
            SetOperatorNotes(0);
            splitContainer2.Visible = false;
        }

        private void LoadTreeView() {
            jobs = new Jobs(Jobs.ContactView.Current);
            tvJobs.Nodes.Clear();
            int i = 0;
            btnJobList.Enabled = (jobs.Count > 0);
            foreach (Job job in jobs.OrderBy(s => s.JobDate))
            {
                DateTime dt;

                dt = job.JobDate;
                if (tvJobs.Nodes.Find(job.JobDate.ToShortDateString(), false).Count<TreeNode>() == 0)
                {
                    tvJobs.Nodes.Add(job.JobDate.ToShortDateString(), job.JobDate.ToShortDateString(),6);
                }
                //job.LoadJobContacts();
                //TreeNode node = tvJobs.Nodes[job.JobDate.ToShortDateString()].Nodes.Add(job.JobID.ToString(), job.ClientName + Environment.NewLine + "-" + job.PendingStatus);
                TreeNode node = tvJobs.Nodes[job.JobDate.ToShortDateString()].Nodes.Add(job.JobID.ToString(), "Client=" + job.ClientName + ", Status = " + job.Status);
                node.ForeColor = (job.StatusID != 5 && job.JobDate.AddDays(-1) < DateTime.Now ? Color.Red : Color.Black);
                node.Parent.ForeColor = (node.Parent.ForeColor == Color.Red ? Color.Red : node.ForeColor);
                node.ImageIndex = job.StatusID == 5 ? 1 : job.PriorityLevel;
                i++;
                node.Nodes.Add(" ");

            }
            
            splitContainer3.Panel2Collapsed = true;
           
        }
        

        private void tvJobs_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            if (tvJobs.SelectedNode.Level == 0) {
                splitContainer2.Visible = false;
                txtJobStatus.Text = string.Empty;
                btnPendingAction1.Enabled = btnPendingAction2.Enabled = false;
                return;
            }
            btnPendingAction1.Enabled = btnPendingAction2.Enabled = true;
            job = new Job(Convert.ToInt32((tvJobs.SelectedNode.Level == 1) ? tvJobs.SelectedNode.Name : tvJobs.SelectedNode.Parent.Name));
            client = new Client(job.ClientID, false);
            client.LoadAttributes();

            if (tvJobs.SelectedNode.Level == 1)
            {
                LoadJobDetails(job);
                tvJobs.SelectedNode.ExpandAll();
            }

            splitContainer2.Visible = false;   
            
            if (tvJobs.SelectedNode.Level == 2) {
                
                job.LoadJobContacts();
                JobContact jobcontact = job.jobcontacts.Where(j => j.ContactID == Convert.ToInt32(tvJobs.SelectedNode.Name)).First<JobContact>();
                LoadJobContactDetails(jobcontact);
                
            }

            txtJobStatus.Text = job.Status;

            SetPendingButtons();

        }

        private void SetPendingButtons() {
            btnPendingAction1.Text = job.PendingStatus;
            if (job.StatusID == 3 || job.StatusID == 4 || job.StatusID == 5)
            {
                btnPendingAction2.Text = "Driver Cancels";
            }
            else
            {
                btnPendingAction2.Text = "Cancel Job";
            }
            
            btnPendingAction2.Visible = job.StatusID < 6 || job.StatusID==8;
        }

        private void PopulatelvDrivers(Job job) {

            lvDrivers.Items.Clear();
            lvDrivers.Sorting = SortOrder.None;
            drivers.PopulateDriversForJobs(Convert.ToInt32(tvJobs.SelectedNode.Name));
            foreach (Driver dv in drivers.OrderBy(d => d.FirstName).OrderBy(d => d.Surname))
            {
                ListViewItem lvi = lvDrivers.Items.Add(dv.DriverID.ToString());

                if (dv.InsuranceExpiry < DateTime.Now)
                {
                    lvi.ImageIndex = 2;
                    lvi.ToolTipText = "Driver has no current Insurance";
                }

                if (dv.LicenceExpiry < DateTime.Now) {
                    lvi.ImageIndex = 2;
                    lvi.ToolTipText = "Driver has no valid Licence";
                }

                if ((dv.IsAbsent || dv.HasDeclined || dv.IsClientExcluded) && lvi.ImageIndex == -1)
                {
                    lvi.ImageIndex = 4;
                    lvi.IndentCount = 0;
                    lvi.ToolTipText = dv.IsAbsent ? "Driver is absent on date of job" : dv.HasDeclined ? "Job declined by driver" : "There is a client exclusion for this driver";

                }

                if (dv.JobSessionCount == 2 && lvi.ImageIndex==-1)
                {
                    lvi.ImageIndex = 4;
                    lvi.ToolTipText = "Driver does not work on this day of week.";

                }

                if (!dv.IsWheelchairEnabled && (client.isWheelchair || job.DVCWheelchair))
                {
                    lvi.ImageIndex = 1;
                    lvi.ToolTipText = "Driver is not wheelchair enabled.";
                }

                if (dv.IsLocalDrivesOnly && lvi.ImageIndex == -1)
                {
                    lvi.ImageIndex = 8;
                    lvi.ToolTipText = "Local Drives Only.";
                }

                if (dv.JobSessionCount == 1 && lvi.ImageIndex == -1)
                {
                    lvi.ImageIndex = 1;
                    lvi.ToolTipText = "Driver does not work morning and afternoon on job day.";

                }

                if (dv.OtherJob > 0) {
                    
                    lvi.ForeColor = Color.Red;
                    lvi.ToolTipText += (lvi.ToolTipText == string.Empty ? string.Empty : Environment.NewLine); 
                    lvi.ToolTipText += "Driver has a job booked on this day - see Operator notes for details.";
                    lvi.ImageIndex = 1;
                    lvi.Name = dv.OtherJob.ToString();
                   
                }

                if (lvi.ImageIndex == -1)
                {
                    lvi.ImageIndex = 0;
                    lvi.ToolTipText = "Driver valid and available";
                }

                


                lvi.SubItems.Add(dv.FirstName + " " + dv.Surname);
                lvi.SubItems.Add(dv.AddressLine1);
                lvi.SubItems.Add(dv.Town);
                lvi.SubItems.Add(dv.Postcode);
                lvi.Tag = dv.DriverID;
                
            }
        }


        private void LoadJobContactDetails(JobContact jobcontact)
        {
            txtJobID.Text = jobcontact.JobID.ToString();
            rtbJobNotes.Text = "Contact made by " + jobcontact.EnteredBy;
            rtbJobNotes.Text += " at " + jobcontact.EnteredAt.ToShortDateString() + "  " + jobcontact.EnteredAt.ToShortTimeString().Substring(0, 5);
            rtbJobNotes.Text += " on " + jobcontact.PhoneUsed.ToString();
            rtbJobNotes.Text += Environment.NewLine + "Notes: ";
            rtbJobNotes.Text += jobcontact.Note;
        }

        private void SetlvDrivers(bool showing) {

            //splitContainer2.SplitterDistance = showing ? splitContainer2.Height : 0;
            splitContainer2.Panel1Collapsed = !showing;
            splitContainer2.Panel2Collapsed = showing;

            lvDrivers.Height = showing ? splitContainer2.Height - 25  : 0;

            //lvDrivers.Enabled = showing;
            lblAllocateDrivers.Visible = showing;
            splitContainer3.Panel1Collapsed = false;
            splitContainer3.Panel2Collapsed = true;

            //tvJobs.Visible = !showing;

            //gbClientDetails.Visible = showing;

            
        }

        


        private void LoadNotes()
        {
            Int32 i = 0;
            Notes collNotes = client.ClientNotes;
            rtbLClientNotes.Clear();
            //rtbDClientNotes.Clear();

            if (collNotes.Count > 0)
            {
                foreach (Note note in collNotes)
                {
                    rtbLClientNotes.Text += note.EnteredAt.ToShortDateString();
                    rtbLClientNotes.Text += ": " + note.NoteText;
                    rtbLClientNotes.Text += Environment.NewLine;
                }
            }
            else
            {
                rtbLClientNotes.Text = "There are no notes for this client.";

            }
            //rtbDClientNotes.Text = rtbLClientNotes.Text;
        }

        private void LoadJobDetails(Job job) {
            txtJobID.Text = job.JobID.ToString();
            //rtbJobDetailsL1.Text = "Client: " + job.ClientName;
            rtbJobDetailsL1.Text = "From: " + job.joblegs[0].PickUpName + Environment.NewLine;
            rtbJobDetailsL1.Text += job.joblegs[0].PickUpAddressLine1;
            rtbJobDetailsL1.Text += job.joblegs[0].PickUpAddressLine2 == string.Empty ? string.Empty : ", " + job.joblegs[0].PickUpAddressLine2;
            rtbJobDetailsL1.Text += Environment.NewLine;
            rtbJobDetailsL1.Text += job.joblegs[0].PickUpTown;
            rtbJobDetailsL1.Text += (job.joblegs[0].PickUpPostCode == string.Empty) ? string.Empty : ", " + job.joblegs[0].PickUpPostCode;
            rtbJobDetailsL1.Text += Environment.NewLine;
            rtbJobDetailsL1.Text += "To: " + job.joblegs[0].DropName + Environment.NewLine;
            rtbJobDetailsL1.Text += job.joblegs[0].DropAddressLine1;
            rtbJobDetailsL1.Text += job.joblegs[0].DropAddressLine2 == string.Empty ? string.Empty : ", " + job.joblegs[0].DropAddressLine2;
            rtbJobDetailsL1.Text += Environment.NewLine;
            rtbJobDetailsL1.Text += job.joblegs[0].DropTown;
            rtbJobDetailsL1.Text += (job.joblegs[0].DropPostCode == string.Empty) ? string.Empty : ", " + job.joblegs[0].DropPostCode;
            rtbJobDetailsL1.Text += Environment.NewLine;
            rtbJobDetailsL1.Text += "Appointment at " + job.joblegs[0].AppointmentTime.ToLongTimeString().Substring(0, 5) + " on " + job.JobDate.ToShortDateString() + Environment.NewLine;

            if (job.joblegs.Count > 1)
            {
                //rtbJobDetailsL1.Text = "Client: " + job.ClientName;
                rtbJobDetailsL2.Text = "From: " + job.joblegs[1].PickUpName + Environment.NewLine;
                rtbJobDetailsL2.Text += job.joblegs[1].PickUpAddressLine1;
                rtbJobDetailsL2.Text += job.joblegs[1].PickUpAddressLine2 == string.Empty ? string.Empty : ", " + job.joblegs[1].PickUpAddressLine2;
                rtbJobDetailsL2.Text += Environment.NewLine;
                rtbJobDetailsL2.Text += job.joblegs[1].PickUpTown;
                rtbJobDetailsL2.Text += (job.joblegs[1].PickUpPostCode == string.Empty) ? string.Empty : ", " + job.joblegs[1].PickUpPostCode;
                rtbJobDetailsL2.Text += Environment.NewLine;
                rtbJobDetailsL2.Text += "To: " + job.joblegs[1].DropName + Environment.NewLine;
                rtbJobDetailsL2.Text += job.joblegs[1].DropAddressLine1;
                rtbJobDetailsL2.Text += job.joblegs[1].DropAddressLine2 == string.Empty ? string.Empty : ", " + job.joblegs[1].DropAddressLine2;
                rtbJobDetailsL2.Text += Environment.NewLine;
                rtbJobDetailsL2.Text += job.joblegs[1].DropTown;
                rtbJobDetailsL2.Text += (job.joblegs[1].DropPostCode == string.Empty) ? string.Empty : ", " + job.joblegs[1].DropPostCode;
                
                
            }
            else {
                rtbJobDetailsL1.Text += "ONE WAY ONLY" + Environment.NewLine;
                rtbJobDetailsL2.Text = "ONE WAY ONLY" + Environment.NewLine;
            }
            
            rtbJobNotes.Text = "Job entered by " + job.EnteredBy + " on "  + job.EnteredAt.ToShortDateString() + " at " + job.EnteredAt.ToShortTimeString() + Environment.NewLine + job.Notes;
            
            splitContainer3.Panel1Collapsed = true;
            
            txtJobStatus.Text = job.Status;
            
        }
        
        private void tvJobs_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            bDirty = false;
            if (e.Node.Level == 1) {
                e.Node.Nodes.Clear();
                Job job = new Job(Convert.ToInt32(e.Node.Name));
                txtJobID.Text = job.JobID.ToString();
                LoadJobDetails(job);
                Client client = new Client(Convert.ToInt32(job.ClientID), false);
                job.LoadJobContacts();
                txtJobStatus.Text = job.Status;
                foreach (JobContact jobcontact in job.jobcontacts.OrderBy(a => a.ContactID))
                {
                    TreeNode node = e.Node.Nodes.Add(jobcontact.ContactID.ToString(), jobcontact.LinkName + " : " + jobcontact.EnteredAt.ToShortDateString().Substring(0, 5) + " - " + jobcontact.Action, jobcontact.Action.Contains("accepted") ? 0 : 2);
                    
                }
                
            }
        }

        

        private void lvDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDrivers.SelectedItems.Count > 0)
            {
                driver = drivers.Where(s => s.DriverID.ToString() == lvDrivers.SelectedItems[0].SubItems[0].Text).First<Driver>();
                SetOperatorNotes(1);
                if (lvDrivers.SelectedItems[0].ImageIndex == 4 || lvDrivers.SelectedItems[0].ImageIndex == 2)
                {
                    MessageBox.Show(lvDrivers.SelectedItems[0].ToolTipText, msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                    
                }

                if (lvDrivers.SelectedItems[0].ImageIndex > 0) {
                    
                    DialogResult dialogresult = MessageBox.Show(lvDrivers.SelectedItems[0].ToolTipText + Environment.NewLine + "Do you want to continue?",msgBoxTitle, MessageBoxButtons.YesNo);
                    if (dialogresult != DialogResult.Yes)
                    {
                        return;
                    }
                }

                //MessageBox.Show(lvDrivers.SelectedItems[0].Name);
                               
                SetDriverPanel();
                SetlvDrivers(false);
                SetOperatorNotes(50);
                //scTreeView.Panel1Collapsed = false;
                //scTreeView.Panel2Collapsed = true;
            }
        }

        private void LoadClientAttributes(CheckedListBox clb) {
            clb.Items.Clear();
            
            foreach (Attribute attribute in client.Attributes)
            {
                clb.Items.Add(attribute.Description, attribute.Checked);
            }
        }


        private void SetDriverPanel(){

            PopulateDriverDetails(driver, rtbDriverDetails);
            SetDriverContactPage();
            driver.LoadDriverAttributes();
            driver.LoadDriverSessions();
            rtbDriverNotes.Visible = lblDriverNotes.Visible = false;
            
            collNotes = new Notes(driver.DriverID, Notes.NoteType.Driver);
            

            foreach (Attribute attribute in driver.Attributes)
            {
                this.clbAttributes.Items.Add(attribute.Description);
                this.clbAttributes.Items[clbAttributes.Items.Count-1].Checked = attribute.Checked;
                

                if (attribute.Description.Length > 10 && attribute.Description.ToUpper().Substring(0, 10) == "SEE DRIVER" && attribute.Checked)
                {
                    drivernotes = new Notes(driver.DriverID, Notes.NoteType.Driver);
                    
                    this.clbAttributes.Items[clbAttributes.Items.Count - 1].ForeColor = Color.Red;
                    this.clbAttributes.Items[clbAttributes.Items.Count - 1].BackColor = Color.Yellow;

                    rtbDriverNotes.Visible = lblDriverNotes.Visible = true;
                    rtbDriverNotes.Clear();
                    foreach (Note n in drivernotes) {
                        rtbDriverNotes.Text += n.NoteText;
                        rtbDriverNotes.Text += System.Environment.NewLine;
                    }
                    rtbDriverNotes.Text = rtbDriverNotes.Text.Substring(0, rtbDriverNotes.Text.Length - 1);
                }
            }

            //LoadClientAttributes(clbCDAttributes);
            cboPickUp1Hour.SelectedValue = job.joblegs[0].PickUpTime.Hour;
            cboPickUp1Minute.SelectedValue = job.joblegs[0].PickUpTime.Minute;
            cboAppt1Hour.SelectedValue = job.joblegs[0].AppointmentTime.Hour;
            cboAppt1Minute.SelectedValue = job.joblegs[0].AppointmentTime.Minute;
            if (job.joblegs.Count > 1) {
                cboPickUp2Hour.SelectedValue = job.joblegs[1].PickUpTime.Hour;
                cboPickUp2Minute.SelectedValue = job.joblegs[1].PickUpTime.Minute;
            }

            chkSession1.Checked = driver.Sessions[1];
            chkSession2.Checked = driver.Sessions[2];
            chkSession3.Checked = driver.Sessions[3];
            chkSession4.Checked = driver.Sessions[4];
            chkSession5.Checked = driver.Sessions[5];
            chkSession6.Checked = driver.Sessions[6];
            chkSession7.Checked = driver.Sessions[7];
            chkSession8.Checked = driver.Sessions[8];
            chkSession9.Checked = driver.Sessions[9];
            chkSession10.Checked = driver.Sessions[10];
            chkSession11.Checked = driver.Sessions[11];
            chkSession12.Checked = driver.Sessions[12];
            chkSession13.Checked = driver.Sessions[13];
            chkSession14.Checked = driver.Sessions[14];

            radDVCYes.Checked = job.DVCWheelchair;
            radDVCNo.Checked = !job.DVCWheelchair;

            lblDDriverContact.Text = "Driver = " + driver.FullName;
            lblDClientContact.Text = "Client = " + client.Title + " " + client.FirstName + " " + client.Surname;
            radInformed.Visible = job.StatusID == 6;
            //radInformed.Tag = job.StatusID == 8 ? 21 : 32;
            rtbClientContactDetails.Clear();
            rtbClientContactDetails.Text += "Home Phone = " + client.HomePhone + System.Environment.NewLine;
            rtbClientContactDetails.Text += "MobilePhone = " + client.MobilePhone + System.Environment.NewLine;
            
            radDCAAccepted.Visible = radDCADeclined.Visible = !(job.StatusID == 6);
            radDCAWaiting.Visible = !(job.StatusID == 6 || job.StatusID == 8);
        }

        private void PopulateDriverDetails(Driver dv, RichTextBox rtbBox) {
            rtbBox.Text = dv.FullName;
            rtbBox.Text += Environment.NewLine + dv.AddressLine1 + (dv.AddressLine2 == string.Empty ? string.Empty : Environment.NewLine + dv.AddressLine2);
            rtbBox.Text += Environment.NewLine + dv.Town + " " + dv.Postcode;
            
            dv.LoadCars();
            if (dv.cars.Count > 0)
            {
                rtbBox.Text += (dv.cars[0].Make == string.Empty ? string.Empty : Environment.NewLine + "car make: " + dv.cars[0].Make);
                rtbBox.Text += (dv.cars[0].Model == string.Empty ? string.Empty : Environment.NewLine + "car model: " + dv.cars[0].Model);
                rtbBox.Text += (dv.cars[0].Colour == string.Empty ? string.Empty : Environment.NewLine + "colour: " + dv.cars[0].Colour);
                rtbBox.Text += (dv.cars[0].RegNo == string.Empty ? string.Empty : Environment.NewLine + "car reg: " + dv.cars[0].RegNo);
            }
            
            
        }

        

        private void btnSaveDriverContact_Click(object sender, EventArgs e)
        {
            RadioButton radContact;

            try { 
                radContact = gbDriverContact.Controls.OfType<RadioButton>().First(r => r.Checked);
            }
            catch(SystemException raderr)
            {
                raderr = null;
                MessageBox.Show("A contact method must be chosen.", msgBoxTitle);
                return;
            }

            RadioButton radPhone = new RadioButton();
            try
            {
                radPhone = gbDriverPhone.Controls.OfType<RadioButton>().First(r => r.Checked);
            }
            catch (SystemException err)
            {
                MessageBox.Show("Phone contact number must be selected", msgBoxTitle);
                string cch = err.Message;
                return;
            }

            if (radDCAAccepted.Checked)
            {
                 
                if ((int)cboPickUp1Hour.SelectedValue < 1 && (int)cboPickUp1Minute.SelectedValue < 1)
                {
                    MessageBox.Show("Pick Up time must be entered.", this.Text);
                    return;
                }
                if (!ValidateAppointmentTime(cboAppt1Hour, cboAppt1Minute, cboPickUp1Hour, cboPickUp1Minute))
                {
                    MessageBox.Show("Pick up time must be before appointment time", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                job.joblegs[0].AppointmentTime = job.JobDate.AddHours(Convert.ToDouble(cboAppt1Hour.SelectedValue)).AddMinutes(Convert.ToDouble(cboAppt1Minute.SelectedValue));
                job.joblegs[0].PickUpTime = job.JobDate.AddHours(Convert.ToDouble(cboPickUp1Hour.SelectedValue)).AddMinutes(Convert.ToDouble(cboPickUp1Minute.SelectedValue));
                if (job.joblegs.Count > 1) {
                    job.joblegs[1].PickUpTime = job.JobDate.AddHours(Convert.ToDouble(cboPickUp2Hour.SelectedValue)).AddMinutes(Convert.ToDouble(cboPickUp2Minute.SelectedValue));
                }
                job.UpdateJob(false);
            }

            JobContact jobcontact = new JobContact();
            jobcontact.JobID = Convert.ToInt32(job.JobID);
            jobcontact.LinkID = Convert.ToInt32(driver.DriverID);
            
            jobcontact.AttributeID = Convert.ToInt32(gbDriverContact.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag.ToString());
            jobcontact.Note = (rtbDriverContactNotes.ForeColor == Color.Black ? rtbDriverContactNotes.Text : string.Empty);
            jobcontact.PhoneUsed = gbDriverPhone.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag.ToString();

            job.RefreshHasLinkedJob();
            if (job.HasLinkedJob)
            {
                MessageBox.Show(job.LinkedMessage + ".  Check that both ONE WAY jobs have driver before contacting client.", msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string msg = jobcontact.AddJobContact();
            if (msg == "Successfully updated job")
            {
                MessageBox.Show(msg, msgBoxTitle);
                client = null;
                driver = null;
                job = null;
                scTreeView.Panel1Collapsed = false;
                scTreeView.Panel2Collapsed = true;
            }
            else
            {
                MessageBox.Show(msg, msgBoxTitle);
            }
            
            LoadTreeView();
            ResetLevel1();
            splitContainer2.Visible = false;
            bDirty = false;
        }

        

        private int GetClientAttributeID()
        {
            return (radD1.Checked ? Convert.ToInt32(radD1.Tag) : 0) + (radC1.Checked ? Convert.ToInt32(radC1.Tag) : 0) + (radC2.Checked ? Convert.ToInt32(radC2.Tag) : 0) + (radC3.Checked ? Convert.ToInt32(radC3.Tag) : 0) + (radC4.Checked ? Convert.ToInt32(radC4.Tag) : 0) + (radC5.Checked ? Convert.ToInt32(radC5.Tag) : 0) + (radA1.Checked ? Convert.ToInt32(radA1.Tag) : 0) + (radCU1.Checked ? Convert.ToInt32(radCU1.Tag) : 0) + (radCU2.Checked ? Convert.ToInt32(radCU2.Tag) : 0) + (radCU3.Checked ? Convert.ToInt32(radCU3.Tag) : 0);
        }

        private void rtbDriverContactNotes_Click(object sender, EventArgs e)
        {
            if (rtbDriverContactNotes.Text == "Enter additional contact details here")
            {
                rtbDriverContactNotes.Text = string.Empty;
                rtbDriverContactNotes.ForeColor = Color.Black;
            }
        }
        private void SetOperatorReminders() {
            rtbOpInstructions.Clear();
            rtbOpInstructions.Text = job.DVCWheelchair ? "Remind driver to pick up wheelchair from DVC." : string.Empty;
        }
        

        private void ResetLevel1() {
            ResetLevel1(false);
        }

        private void ResetLevel1(Boolean resetall) {
            btnJobList.Enabled = (tvJobs.Nodes.Count > 0);

            radDCAAccepted.Checked = radDCADeclined.Checked = radDCAWaiting.Checked = radDCUBusy.Checked = radDCUNoVoicemail.Checked = radDCUVoicemail.Checked = radTextSent.Checked = false;

            rtbDriverContactNotes.Text = "Enter additional contact details here";
            rtbDriverContactNotes.ForeColor = Color.Silver;
            rtbDriverDetails.Text = string.Empty;

            rtbClientContactNotes.Text = "Enter additional contact details here";
            rtbClientContactNotes.ForeColor = Color.Silver;
            

            radPhoneMobile.Checked = radPhoneHome.Checked = radPhoneOther.Checked = false;
            gbContactOutcome.Visible = pnlAvailability.Visible = pnlTimes.Visible = true;
            //gbClientDetails.Visible = false;
            

            lblDDriverContact.Text = "Driver = not allocated";
            
            if (resetall)
            {
                txtJobID.Text = txtJobStatus.Text = string.Empty;
            }
            
        }

        
        private void btnPendingAction1_Click(object sender, EventArgs e)
        {
            ClearClientDetails();
            ClearDriverDetails();
            
            ResetLevel1();
            
            if (tvJobs.SelectedNode == null)
            {
                MessageBox.Show("Job must be selected", this.Text);
                return;
            }
            
            splitContainer2.Visible = true;
            scTreeView.Panel1Collapsed = (job.StatusID < 2);
            scTreeView.Panel2Collapsed = (job.StatusID > 1);

            SetOperatorNotes(job.StatusID == 0 ? 1 : job.StatusID);
            LoadNotes();

            if (job.StatusID < 2) {
                PopulatelvDrivers(job);
                splitContainer3.Panel2Collapsed = splitContainer2.Panel2Collapsed = true;
                                
                LoadClientAttributes(clbCLAttributes);
                
                
                SetlvDrivers(true);
                //SetDriverPanel();

            }

            if (job.StatusID == 6 || job.StatusID == 8) {
                splitContainer3.Panel2Collapsed = true;
                
                SetlvDrivers(false);
                driver = new Driver(job.joblegs[0].DriverID, true);
                SetDriverPanel();
                SetOperatorNotes(job.StatusID);
            }

            
            if (job.StatusID == 18) {
                gbClientPhone.Visible = gbContactOutcome.Visible = pnlAvailability.Visible = pnlTimes.Visible = false;
                btnClientContactNotes.Text = "Close Job";
                rtbClientContactNotes.Text = "Enter job expiry conclusion here";
            }

            if (job.StatusID > 1 && job.StatusID != 6 && job.StatusID != 8)
            {
                SetClientDetails(btnPendingAction1.Text == "Cancel Job", true);


                splitContainer3.Panel1Collapsed = splitContainer2.Panel1Collapsed = true;

                if (job.joblegs[0].DriverID > -1)
                {
                    setDriverDetails();
                }
                //radA1.Visible = radCU1.Visible = radCU2.Visible = radCU3.Visible = !(job.StatusID == 5);
                //radC1.Visible = radC2.Visible = radC3.Visible = radC4.Visible = radC5.Visible = job.StatusID != 7;
                //radD1.Visible = false;
                SetPage2PhoneNumbers(LinkType.Client);

            }
            
            radD1.Visible = false;
            gbClientPhone.Text = "Contact client on:";

            bDirty = false;
        }

        private void SetDriverContactPage() {
            radPhoneHome.Tag = radPhoneHome.Text = driver.HomePhone;
            radPhoneMobile.Tag = radPhoneMobile.Text = driver.MobilePhone;
            radPhoneHome.Visible = driver.HomePhone != string.Empty;
            radPhoneMobile.Visible = driver.MobilePhone != string.Empty;
            lblPickUp2Time.Visible = cboPickUp2Hour.Visible = cboPickUp2Minute.Visible = job.joblegs.Count > 1;

        }

        private void SetPage2PhoneNumbers(LinkType linktype)
        {
            if (linktype == LinkType.Client)
            {
                radHPhone.Tag = radHPhone.Text = client.HomePhone;
                radMPhone.Tag = radMPhone.Text = client.MobilePhone;
                radHPhone.Visible = client.HomePhone != string.Empty;
                radMPhone.Visible = client.MobilePhone != string.Empty;
            }
            if (linktype == LinkType.Driver)
            {
                radHPhone.Tag = radHPhone.Text = driver.HomePhone;
                radMPhone.Tag = radMPhone.Text = driver.MobilePhone;

                radHPhone.Visible = client.HomePhone != string.Empty;
                radMPhone.Visible = client.MobilePhone != string.Empty;
            }

        }

        private void btnPendingAction2_Click(object sender, EventArgs e)
        {
            ClearDriverDetails();
            ClearClientDetails();
            ResetLevel1();
            //scTreeView.Panel2Collapsed = !(job.StatusID > 1);
            //scTreeView.Panel1Collapsed = (job.StatusID > 1);
            scTreeView.Panel2Collapsed = true;
            scTreeView.Panel1Collapsed = false;

            if (btnPendingAction2.Text == "Cancel Job")
            {
                //this sets up to show client panel
                splitContainer3.Panel1Collapsed = splitContainer2.Panel1Collapsed = true;
                splitContainer2.Visible = true;
                SetClientDetails(true, true);
                //gbContactOutcome.Visible = (btnPendingAction2.Text == "Cancel Job");
                //gbNoDriver.Visible = !(btnPendingAction2.Text == "Cancel Job");
                //if (gbNoDriver.Visible) {
                //    SetPanel4(false, false);
                //}
                SetPage2PhoneNumbers(LinkType.Client);
            }
            else {
                //****************************************************
                //for "Driver Cancels"
                //****************************************************

                

                splitContainer2.Visible = true;
                splitContainer2.Panel1Collapsed = true;

                setDriverDetails();

                radCAck.Visible = radA1.Visible = radC1.Visible = radC2.Visible = radC3.Visible = radC4.Visible = radC5.Visible = radCU1.Visible = radCU2.Visible = radCU3.Visible = false;
                radD1.Checked = radD1.Visible = true;

                if (driver == null)
                {
                    MessageBox.Show("Cannot proceed - driver is not set.", this.Text);
                    return;
                }

                SetPage2PhoneNumbers(LinkType.Driver);

                gbClientPhone.Text = "Contact driver on:";
                
            }

            if (tvJobs.SelectedNode == null)
            {
                MessageBox.Show("Job must be selected", this.Text);
                return;
            }
            LoadNotes();

            bDirty = false;

        }

        private void SetClientDetails(Boolean cancellation, Boolean HasDriver) {
            if (job == null) {
                MessageBox.Show("Choose Job from side panel", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            lblCPickUp2Time.Visible = cboCPickUp2Hour.Visible = cboCPickUp2Minute.Visible = job.joblegs.Count > 1;
            //LoadClientAttributes(clbCAttributes);
            radCAck.Visible = (btnPendingAction1.Text == "Inform Client");
            radA1.Visible = !radCAck.Visible;
            //radC1.Visible = radC2.Visible = radC3.Visible = radC4.Visible = radC5.Visible = true;
            if (cancellation) {
                cboCPickUp1Hour.Enabled = cboCPickUp1Minute.Enabled = cboCPickUp2Hour.Enabled = cboCPickUp2Minute.Enabled = false;
                
            }

            foreach (RadioButton rad in gbContactOutcome.Controls) {
                rad.Checked = false;
            }

            //if (job.joblegs[0].DriverID> 0) {
            //    rtbCDriverDetails.Clear();
            //    clbDAttributes.SelectedItems.Clear();
            //}

            radCU1.Visible = radCU2.Visible = radCU3.Visible = radA1.Visible = radD1.Visible = !cancellation;

            radC1.Visible = radC2.Visible = radC3.Visible = radC4.Visible = radC5.Visible = true;

            gbClientPhone.Text = "Contact client on:";

                       

        }

        private void ClearDriverDetails() {
            rtbDriverDetails.Clear();
            clbAttributes.Items.Clear();
            radDCUBusy.Checked = false;
            radDCUNoVoicemail.Checked = false;
            radDCUVoicemail.Checked = false;
            radInformed.Checked = radDCAAccepted.Checked = radDCADeclined.Checked = radDCAWaiting.Checked = false;
            chkSession1.Checked = false;
            chkSession2.Checked = false;
            chkSession3.Checked = false;
            chkSession4.Checked = false;
            chkSession5.Checked = false;
            chkSession6.Checked = false;
            chkSession7.Checked = false;
            chkSession8.Checked = false;
            chkSession9.Checked = false;
            chkSession10.Checked = false;
            chkSession11.Checked = false;
            chkSession12.Checked = false;
            chkSession13.Checked = false;
            chkSession14.Checked = false;
            radDVCNo.Checked = false;
            radDVCYes.Checked = false;
            radPhoneHome.Checked = false;
            radPhoneMobile.Checked = false;
            radPhoneOther.Checked = false;

        }
        private void ClearClientDetails() {
            clbDAttributes.Items.Clear();
            //clbCAttributes.Items.Clear();
            rtbCDriverDetails.Clear();
            lblCClientContact.Text = string.Empty;
            lblCDriverContact.Text = string.Empty;
            radHPhone.Checked = radMPhone.Checked = radOPhone.Checked = false;
            rad39.Checked = rad40.Checked = rad41.Checked = rad42.Checked = false;
            chkCSession1.Checked = false;
            chkCSession2.Checked = false;
            chkCSession3.Checked = false;
            chkCSession4.Checked = false;
            chkCSession5.Checked = false;
            chkCSession6.Checked = false;
            chkCSession7.Checked = false;
            chkCSession8.Checked = false;
            chkCSession9.Checked = false;
            chkCSession10.Checked = false;
            chkCSession11.Checked = false;
            chkCSession12.Checked = false;
            chkCSession13.Checked = false;
            chkCSession14.Checked = false;
        }

        private void setDriverDetails(){
            job.LoadJobContacts();
            //driver = new Driver(job.jobcontacts.Where(a => a.AttributeID == 21 && a.AttributeLevel == 2).First<JobContact>().LinkID, false);
            driver = new Driver(job.joblegs[0].DriverID, true);
            PopulateDriverDetails(driver, rtbCDriverDetails);

            lblCDriverContact.Text = "Driver = " + driver.FullName;
            lblCClientContact.Text = "Client = " + client.Title + " " + client.FirstName + " " + client.Surname;

            driver.LoadDriverAttributes();
            clbDAttributes.Items.Clear();
            foreach (Attribute attribute in driver.Attributes)
            {
                clbDAttributes.Items.Add(attribute.Description, attribute.Checked);
            }

            cboCPickUp1Hour.SelectedValue = job.joblegs[0].PickUpTime.Hour;
            cboCPickUp1Minute.SelectedValue = job.joblegs[0].PickUpTime.Minute;
            cboCAppt1Hour.SelectedValue = job.joblegs[0].AppointmentTime.Hour;
            cboCAppt1Minute.SelectedValue = job.joblegs[0].AppointmentTime.Minute;
            if (job.joblegs.Count > 1)
            {
                cboCPickUp2Hour.SelectedValue = job.joblegs[1].PickUpTime.Hour;
                cboCPickUp2Minute.SelectedValue = job.joblegs[1].PickUpTime.Minute;
            }
            
            driver.LoadDriverSessions();
            this.chkCSession1.Checked = driver.Sessions[1];
            this.chkCSession2.Checked = driver.Sessions[2];
            this.chkCSession3.Checked = driver.Sessions[3];
            this.chkCSession4.Checked = driver.Sessions[4];
            this.chkCSession5.Checked = driver.Sessions[5];
            this.chkCSession6.Checked = driver.Sessions[6];
            this.chkCSession7.Checked = driver.Sessions[7];
            this.chkCSession8.Checked = driver.Sessions[8];
            this.chkCSession9.Checked = driver.Sessions[9];
            this.chkCSession10.Checked = driver.Sessions[10];
            this.chkCSession11.Checked = driver.Sessions[11];
            this.chkCSession12.Checked = driver.Sessions[12];
            this.chkCSession13.Checked = driver.Sessions[13];
            this.chkCSession14.Checked = driver.Sessions[14];


        }

        private void rtbClientContactNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (rtbClientContactNotes.Text == "Enter additional contact details here")
            {
                rtbClientContactNotes.Text = string.Empty;
                rtbClientContactNotes.ForeColor = Color.Black;
            }
        }

        

        private void rtbDriverContactNotes_MouseDown(object sender, MouseEventArgs e)
        {
            if (rtbDriverContactNotes.Text == "Enter additional contact details here")
            {
                rtbDriverContactNotes.Text = string.Empty;
                rtbDriverContactNotes.ForeColor = Color.Black;
            }
        }

        private void rtbClientContactNotes_MouseDown(object sender, MouseEventArgs e)
        {
            if (rtbClientContactNotes.Text == "Enter additional contact details here")
            {
                rtbClientContactNotes.Text = string.Empty;
                rtbClientContactNotes.ForeColor = Color.Black;
            }
        }
        
        

        

        private void frmJobQueue_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bDirty)
            {
                DialogResult dialogResult = MessageBox.Show("Contact information has not been saved." + Environment.NewLine + "Return to contact details form?", this.Text, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    e.Cancel = true;
                    this.Activate();
                    this.Focus();
                }
            }
            if (frmDaily != null)
            {
                frmDaily.Close();
            }
        }

        private void rtbClientContactNotes_Click(object sender, EventArgs e)
        {
            if (rtbClientContactNotes.ForeColor == Color.Silver)
            {
                rtbClientContactNotes.Text = string.Empty;
                rtbClientContactNotes.ForeColor = Color.Black;
            }
        }

        private void rtbDriverContactNotes_MouseClick(object sender, MouseEventArgs e)
        {
            bDirty = true;
            if (rtbDriverContactNotes.Text == "Enter additional contact details here")
            {
                rtbDriverContactNotes.Text = string.Empty;
                rtbDriverContactNotes.ForeColor = Color.Black;
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnClientContactNotes_Click(object sender, EventArgs e)
        {

            RadioButton radContact = new RadioButton();
            
            try
            {
                if (gbContactOutcome.Visible)
                {
                    radContact = gbContactOutcome.Controls.OfType<RadioButton>().First(r => r.Checked);
                }
                else {
                    radContact = gbNoDriver.Controls.OfType<RadioButton>().First(r => r.Checked);
                }
            }
            catch (SystemException err)
            {
                MessageBox.Show("A contact method must be chosen.", msgBoxTitle);
                string ddf = err.Message;
                return;
            }
            

            //if (GetClientAttributeID() == 0 && job.StatusID < 8)
            //{
            //    MessageBox.Show("", msgBoxTitle);
            //    return;
            //}

            RadioButton radPhone = new RadioButton();
                
            try
            {
                radPhone = gbClientPhone.Controls.OfType<RadioButton>().First(r => r.Checked);
            }
            catch (SystemException err)
            {
                MessageBox.Show("Phone contact number must be selected", msgBoxTitle);
                string cch = err.Message;
                return;
            }
            

            JobContact jobcontact = new JobContact();
            jobcontact.JobID = Convert.ToInt32(job.JobID);
            jobcontact.LinkID = radD1.Checked ? Convert.ToInt32(driver.DriverID) : Convert.ToInt32(client.ClientID);
            jobcontact.AttributeID = Convert.ToInt32(radContact.Tag);
            jobcontact.Note = rtbClientContactNotes.ForeColor == Color.Black ? rtbClientContactNotes.Text + " Contact made on phone: " + radPhone.Text : string.Empty;
            jobcontact.PhoneUsed = gbClientPhone.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag.ToString();
            
            
            string msg = jobcontact.AddJobContact();

            if (msg == "Successfully updated job")
            {
                MessageBox.Show(msg, msgBoxTitle);
                client = null;
                driver = null;
                job = null;
            }
            else
            {
                MessageBox.Show(msg, msgBoxTitle);
            }
            LoadTreeView();
            //ResetLevel1();
            splitContainer2.Visible = false;
            bDirty = false;
        }

        
        private void radCU1_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radCU2_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radCU3_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radA1_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radC1_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radC2_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radC3_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radC4_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radC5_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radD1_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radHPhone_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radMPhone_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radOPhone_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void rtbClientContactNotes_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void cboCAppt1Hour_SelectedIndexChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void cboCAppt1Minute_SelectedIndexChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void cboCPickUp1Hour_SelectedIndexChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void cboCPickUp1Minute_SelectedIndexChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void cboCPickUp2Hour_SelectedIndexChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void cboCPickUp2Minute_SelectedIndexChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtJobID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJobStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void radDCUNoVoicemail_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radDCUVoicemail_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radDCUBusy_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void gbDriverContact_Enter(object sender, EventArgs e)
        {

        }

        private void radInformed_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radDCAAccepted_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
            if (radDCAAccepted.Checked && radDVCYes.Checked) {
                MessageBox.Show("Please inform driver that the DVC wheelchair is required for this job.", msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void radDCADeclined_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radTextSent_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radPhoneHome_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radPhoneMobile_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void radPhoneOther_CheckedChanged(object sender, EventArgs e)
        {
            bDirty = true;
        }

        private void cboPickUp1Hour_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateAppointmentTime(cboAppt1Hour, cboAppt1Minute, cboPickUp1Hour, cboPickUp1Minute);
        }

        private void cboPickUp2Hour_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboPickUp1Minute_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateAppointmentTime(cboAppt1Hour, cboAppt1Minute, cboPickUp1Hour, cboPickUp1Minute);
        }

        private void cboPickUp2Minute_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rtbDriverContactNotes_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboPickUp1Hour_MouseClick(object sender, MouseEventArgs e)
        {
            bDirty = true;
        }

        private void cboPickUp1Minute_MouseClick(object sender, MouseEventArgs e)
        {
            bDirty = true;
        }

        private void cboPickUp2Hour_MouseClick(object sender, MouseEventArgs e)
        {
            bDirty = true;
        }

        private void cboPickUp2Minute_MouseClick(object sender, MouseEventArgs e)
        {
            bDirty = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetLevel1(true);
            splitContainer2.Visible = false;
            rtbJobDetailsL1.Text = rtbJobDetailsL2.Text = rtbJobNotes.Text = string.Empty;
            SetOperatorNotes(0);
            LoadTreeView();
            scTreeView.Panel1Collapsed = false;
            scTreeView.Panel2Collapsed = true;
            rtbLClientNotes.Clear();
            //rtbDClientNotes.Clear();
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
        private void SetOperatorNotes(int level)
        {
            rtbOpInstructions.Clear();
            //gbClientDetails.Visible = false;

            switch (level)
            {
                case 0:
                    rtbOpInstructions.Text = "Select Job from [Choose Job] panel.";
                    break;
                case 1:
                    rtbOpInstructions.Text = "Choose driver from list.  Drivers marked with locked symbol are not available - click to see reason." + Environment.NewLine + "Drivers with L next to name do local drives only." + Environment.NewLine + "Drivers with a red cross have expired Insurance or Driver Licence";
                    //gbClientDetails.Visible = true;
                    break;
                case 6:
                       rtbOpInstructions.Text = "Job cancelled by client - check contact details(choose job panel) for cancellation reason.";
                        break;
                case 50:
                    rtbOpInstructions.Text = "Contact outcome and phone used must be entered before updating job.";
                    rtbOpInstructions.Text += Environment.NewLine + "Pick up times must be entered if driver accepts the job.";
                    break;
            }

            if (driver != null && driver.OtherJob > 0) {
                Job jobOther = new Job(driver.OtherJob);
                rtbOpInstructions.Text += Environment.NewLine + "Driver has same day job at " + jobOther.joblegs[0].PickUpTime.ToShortTimeString() + " going to " + jobOther.joblegs[0].DropAddressLine1 + " for appointment at " + jobOther.joblegs[0].AppointmentTime.ToShortTimeString();
                if (jobOther.joblegs.Count > 1)
                {
                    rtbOpInstructions.Text += " returning at " + ((jobOther.joblegs.Count > 1) ? jobOther.joblegs[1].PickUpTime.ToShortTimeString() : " (One Way Journey Only).");
                }
            }
            if (job.DVCWheelchair) {
                rtbOpInstructions.Text += Environment.NewLine + "Please inform driver that the DVC wheelchair is required for this job.";
            }
        }

        private void btnJobList_Click(object sender, EventArgs e)
        {
            
            DateTime dtJobs;

            if (tvJobs.SelectedNode != null && tvJobs.SelectedNode.Level > 0 )
            {
                dtJobs = job.JobDate;
            }
            else
            {
                if (tvJobs.SelectedNode == null)
                {
                    dtJobs = Convert.ToDateTime(tvJobs.Nodes[0].Text);
                }
                else
                {
                    dtJobs = Convert.ToDateTime(tvJobs.SelectedNode.Text);
                }
                
            }

            if (frmDaily == null || frmDaily.IsDisposed)
            {
                frmDaily = new frmDailyList(dtJobs);
            }
            else
            {
                frmDaily.LoadListView(dtJobs);
            }

            Sizer.ResizeForm(frmDaily);
            frmDaily.Show();
            //frmDaily.TopMost = true;
            frmDaily.Focus();
            frmDaily.WindowState = FormWindowState.Normal;
        }

        

        private void frmJobQueue_MouseClick(object sender, MouseEventArgs e)
        {
            if (frmDaily != null)
            {
                frmDaily.TopMost = false;
            }
        }

        private void rtbJobDetailsL1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJobStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtJobStatus.Width.ToString());
        }

        private void clbAttributes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox s = (CheckedListBox)sender;
            if (s.SelectedItem != null)
            {
                e.NewValue = e.CurrentValue;
            }
        }

        private void clbCDAttributes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox s = (CheckedListBox)sender;
            if (s.SelectedItem != null)
            {
                e.NewValue = e.CurrentValue;
            }
        }

        private void clbDAttributes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox s = (CheckedListBox)sender;
            if (s.SelectedItem != null)
            {
                e.NewValue = e.CurrentValue;
            }
        }

        private void clbCAttributes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox s = (CheckedListBox)sender;
            if (s.SelectedItem != null)
            {
                e.NewValue = e.CurrentValue;
            }
        }
        

        private void rtbDriverDetails_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void rtbClientContactDetails_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void rtbDClientNotes_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void rtbCDriverDetails_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void clbCLAttributes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void gbDVCWheelchair_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radDCAWaiting_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbDriverPhone_Enter(object sender, EventArgs e)
        {

        }

        private void gbContactOutcome_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clbAttributes_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            
        }

        private void chkSession1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
