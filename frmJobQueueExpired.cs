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
    public partial class frmJobQueueExpired : Form
    {
        Boolean bDirty = false;
        IEnumerable<JobContact> queryCurrent;
        Drivers drivers = new Drivers();
        public enum LinkType { Client, Driver };
        Jobs jobs;
        //Job currentjob;
        Client client;
        string msgBoxTitle = "Job Queue Management";
        Job job = new Job();
        

        public frmJobQueueExpired()
        {
            InitializeComponent();
        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmJobQueueExpired_Load(object sender, EventArgs e)
        {
            LoadTreeView();
        }

        private void LoadTreeView()
        {
            string drivername;
            jobs = new Jobs(radAll.Checked ? Jobs.ContactView.NonCurrent : Jobs.ContactView.ExpiredNoDriver);
            tvJobs.Nodes.Clear();
            
            if (radByDate.Checked)
            {
                foreach (Job job in jobs.OrderByDescending(s => s.JobDate))
                {
                    DateTime dt;

                    drivername = job.DriverName == null || job.DriverName.Replace(" ", "") == string.Empty ? "n/a" : job.DriverName;

                    dt = job.JobDate;
                    if (tvJobs.Nodes.Find(job.JobDate.ToShortDateString(), false).Count<TreeNode>() == 0)
                    {
                        TreeNode topnode = tvJobs.Nodes.Add(job.JobDate.ToShortDateString(), job.JobDate.ToShortDateString());
                        topnode.SelectedImageIndex = topnode.ImageIndex = 11;    

                    }
                    //job.LoadJobContacts();
                    //TreeNode node = tvJobs.Nodes[job.JobDate.ToShortDateString()].Nodes.Add(job.JobID.ToString(), job.ClientName + Environment.NewLine + "-" + job.PendingStatus);
                    
                    TreeNode node = tvJobs.Nodes[job.JobDate.ToShortDateString()].Nodes.Add(job.JobID.ToString(), "Client=" + job.ClientName + ", Driver = " + drivername);
                    node.ImageIndex = job.StatusID == 18 ? 12 : job.StatusID == 50 ? 14 : 13;
                    node.Nodes.Add(" ");

                }
            }

            if (radByDriver.Checked)
            {
                foreach (Job job in jobs.OrderBy(s => s.DriverName))
                {
                    drivername = job.DriverName;

                    if(drivername==null || drivername == string.Empty || drivername == " ")
                    {
                        continue;
                    }

                    if (tvJobs.Nodes.Find(drivername, false).Count<TreeNode>() == 0)
                    {
                        tvJobs.Nodes.Add(drivername, drivername);
                    }
                    //job.LoadJobContacts();
                    //TreeNode node = tvJobs.Nodes[job.JobDate.ToShortDateString()].Nodes.Add(job.JobID.ToString(), job.ClientName + Environment.NewLine + "-" + job.PendingStatus);
                    TreeNode node = tvJobs.Nodes[drivername].Nodes.Add(job.JobID.ToString(), job.JobDate.ToShortDateString() + ", Client=" + job.ClientName);
                    node.ImageIndex = job.StatusID == 18 ? 12 : 13;
                    node.ToolTipText = job.StatusID == 18 ? "Cancelled Job" : "Expired Job";


                    node.Nodes.Add(" ");

                }
            }

            if (radByClient.Checked)
            {
                foreach (Job job in jobs.OrderBy(s => s.ClientName))
                {
                    String clientName;

                    drivername = job.DriverName;
                    clientName = job.ClientName;
                    if (tvJobs.Nodes.Find(clientName, false).Count<TreeNode>() == 0)
                    {
                        tvJobs.Nodes.Add(clientName, clientName);
                    }

                    TreeNode node = tvJobs.Nodes[clientName].Nodes.Add(job.JobID.ToString(), job.JobDate.ToShortDateString() + ", Driver = " + drivername);
                    node.ImageIndex = job.StatusID == 18 ? 12 : 13;
                    node.ToolTipText = job.StatusID == 18 ? "Cancelled Job" : "Expired Job";

                    node.Nodes.Add(" ");

                }
            }
        }

        private void tvJobs_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvJobs.SelectedNode.Level > 0)
            {
                job = new Job(Convert.ToInt32((tvJobs.SelectedNode.Level == 1) ? tvJobs.SelectedNode.Name : tvJobs.SelectedNode.Parent.Name));
                client = new Client(job.ClientID, false);
                lblAdditional.Text = "Additional Notes";
                lblAdditional.BackColor = Color.Transparent;

                //if (tvJobs.SelectedNode.Level == 1)
                //{

                try {
                    if (job.JobID != Convert.ToInt32(txtJobID.Text.ToString()))
                    {
                        LoadJobDetails(job);
                    }
                }
                catch (SystemException err) {
                    //Error means that txtJobID was not numeric so reload anyhow
                    LoadJobDetails(job);
                }

                //}

                if (tvJobs.SelectedNode.Level == 2)
                {

                    job.LoadJobContacts();
                    JobContact jobcontact = job.jobcontacts.Where(j => j.ContactID == Convert.ToInt32(tvJobs.SelectedNode.Name)).First<JobContact>();
                    LoadJobContactDetails(jobcontact);
                    lblAdditional.Text = jobcontact.Action;
                    lblAdditional.BackColor = Color.CadetBlue;
                }
                txtJobStatus.Text = job.Status;
                //btnCloseJob.Enabled =  true;
            }
        }

        private void ClearJobDetails() {
            foreach (RadioButton rad in gbContactOutcome.Controls) {
                rad.Checked = false;
                }
            txtJobID.Text = string.Empty;
            txtClient.Text = string.Empty;
            txtDriver.Text = string.Empty;
            txtJobDate.Text = string.Empty;
            rtbJobDetailsL1.Text = string.Empty;
            txtJobStatus.Clear();
        }

        private void LoadJobDetails(Job job)
        {
            ClearJobDetails();

            txtJobID.Text = job.JobID.ToString();
            txtClient.Text = job.ClientName;
            txtDriver.Text = job.joblegs[0].DriverName;
            txtJobDate.Text = job.JobDate.ToShortDateString();
            txtJobStatus.Text = job.Status;

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
            else
            {
                rtbJobDetailsL1.Text += "ONE WAY ONLY" + Environment.NewLine;
                rtbJobDetailsL2.Text = "ONE WAY ONLY" + Environment.NewLine;
            }

            rtbJobNotes.Clear();
            rtbJobNotes.Text = "Job entered by " + job.EnteredBy + " on " + job.EnteredAt.ToShortDateString() + " at " + job.EnteredAt.ToShortTimeString() + " " + job.Notes;
            
                
            rtbContactNotes.Text = "Update status here";
            rtbContactNotes.ForeColor = Color.Black;
            
            rtbContactNotes.Text = string.Empty;

            
            //if (job.StatusID == 50 || job.StatusID == 49 || job.StatusID == 19) {
            if (job.LastAttributeID > 49)
            {
                //rtbContactNotes.Enabled = btnCloseJob.Enabled = true;
                gbContactOutcome.BackColor = rtbContactNotes.BackColor = Color.Yellow;
                foreach (RadioButton rad in gbContactOutcome.Controls)
                {
                    if (Convert.ToInt32(rad.Tag) == (job.LastAttributeID))
                    {
                        rad.Checked = true;
                        
                    }
                }
            }
            //else {
            //    rtbContactNotes.Enabled = btnCloseJob.Enabled = false;
            //    gbContactOutcome.BackColor = rtbContactNotes.BackColor = Color.Gray;

            //    foreach (RadioButton rad in gbContactOutcome.Controls)
            //    {
            //        //rad.AutoCheck = false;
            //        if (Convert.ToInt32(rad.Tag) == (job.LastAttributeID))
            //        {
            //            rad.Checked = true;
            //        }
            //    }
            //}
            gbContactOutcome.BackColor = rtbContactNotes.BackColor = job.LastAttributeID == 57 ? Color.Yellow : Color.Gray;
            //btnCloseJob.Enabled = job.LastAttributeID < 51;

            txtJobStatus.Text = job.Status;

        }

        private void LoadJobContactDetails(JobContact jobcontact)
        {
            txtJobID.Text = jobcontact.JobID.ToString();
            rtbContactNotes.Clear();
            rtbContactNotes.Text = "Entered by: " + jobcontact.EnteredBy;
            rtbContactNotes.Text += Environment.NewLine + "Entered at: " + jobcontact.EnteredAt.ToShortDateString() + "  " + jobcontact.EnteredAt.ToShortTimeString().Substring(0, 5);
            rtbContactNotes.Text += Environment.NewLine + (jobcontact.PhoneUsed.ToString() == "*" ? "see below" : "Phone used: " + jobcontact.PhoneUsed.ToString());
            rtbContactNotes.Text += Environment.NewLine + "Notes:";
            rtbContactNotes.Text += Environment.NewLine + jobcontact.Note;
            
            rtbContactNotes.BackColor = Color.White;
            rtbContactNotes.ForeColor = rtbJobDetailsL1.ForeColor;
        }

        private void tvJobs_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Level == 1)
            {
                e.Node.Nodes.Clear();
                Job job = new Job(Convert.ToInt32(e.Node.Name));
                txtJobID.Text = job.JobID.ToString();
                LoadJobDetails(job);
                Client client = new Client(Convert.ToInt32(job.ClientID), false);
                job.LoadJobContacts();
                txtJobStatus.Text = job.Status;

                foreach (JobContact jobcontact in job.jobcontacts.OrderBy(dt => dt.ContactID))
                {
                    TreeNode node = e.Node.Nodes.Add(jobcontact.ContactID.ToString(), jobcontact.LinkName + " : " + jobcontact.EnteredAt.ToShortDateString().Substring(0, 5) + " - " + jobcontact.Action);
                    switch (jobcontact.LinkType)
                    {
                        case "C":
                            node.ImageIndex = 14;
                            break;
                        case "D":
                            node.ImageIndex = 15;
                            break;
                        case "O":
                            node.ImageIndex = 16;
                            break;
                   }
                }

            }
        }

        private void radByDate_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton chk = (RadioButton)sender;
            if (chk.Checked)
            {
                LoadTreeView();
                ResetRightPanel();
            }
        }

        private void radByClient_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton chk = (RadioButton)sender;
            if (chk.Checked)
            {
                LoadTreeView();
                ResetRightPanel();
            }
        }

        private void radByDriver_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton chk = (RadioButton)sender;
            if (chk.Checked)
            {
                LoadTreeView();
                ResetRightPanel();
            }
        }
        

        private void btnCloseJob_Click(object sender, EventArgs e)
        {
            RadioButton radChoice = new RadioButton();

            try {
                radChoice = gbContactOutcome.Controls.OfType<RadioButton>().First(r => r.Checked);
            }
            catch (System.Exception err) {
                string a = err.Message;
                MessageBox.Show("Please choose a reason for closing job", msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            JobContact jobcontact = new JobContact();
            jobcontact.JobID = Convert.ToInt32(job.JobID);
            jobcontact.LinkID = job.ClientID;
            jobcontact.AttributeID = Convert.ToInt32(radChoice.Tag);
            jobcontact.Note = rtbContactNotes.Text;
            job.Notes += Environment.NewLine + "Job Closure Note: " + rtbContactNotes.Text == string.Empty || rtbContactNotes.ForeColor == Color.White ? radChoice.Text : rtbContactNotes.Text;
            job.UpdateJob(false);
            
            string msg = jobcontact.AddJobContact();
            if (msg == "Successfully updated job")
            {
                MessageBox.Show(msg, msgBoxTitle);
            }
            else
            {
                MessageBox.Show(msg, msgBoxTitle);
            }
            LoadTreeView();
            ResetRightPanel();
       }

        private void radExpired_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton chk = (RadioButton)sender;
            if (chk.Checked)
            {
                LoadTreeView();
                ResetRightPanel();
            }
        }

        private void radAll_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton chk = (RadioButton)sender;
            if (chk.Checked)
            {
                LoadTreeView();
                ResetRightPanel();
            }
        }
        private void ResetRightPanel() {
            rtbContactNotes.Clear();
            rtbContactNotes.BackColor = Color.White;
            rtbJobNotes.Clear();
            rtbJobDetailsL1.Clear();
            rtbJobDetailsL2.Clear();
            //btnCloseJob.Enabled = false;
            txtJobDate.Clear();
            txtClient.Clear();
            txtDriver.Clear();
            
            txtJobID.Clear();
            txtJobStatus.Clear();
            radA1.Checked = radC1.Checked = radC2.Checked = radC3.Checked = radC4.Checked = radC5.Checked = false;
        }

        private void tvJobs_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (e.Node.TreeView.ImageList == null) {
                return;
            }

            if (e.Node.ImageIndex >= e.Node.TreeView.ImageList.Images.Count || e.Node.ImageIndex != 12) // if there is no image
            {
                int imagewidths = e.Node.TreeView.ImageList.ImageSize.Width;
                int textheight = TextRenderer.MeasureText(e.Node.Text, e.Node.NodeFont).Height;
                int x = e.Node.Bounds.Left - 3 - imagewidths / 2;
                int y = (e.Bounds.Top + e.Bounds.Bottom) / 2 + 1;

                Point point = new Point((x - imagewidths / 2)+20, y - textheight / 2); // the new location for the text to be drawn

                TextRenderer.DrawText(e.Graphics, e.Node.Text, e.Node.NodeFont, point, e.Node.ForeColor);
                
            }
            else // drawn at the default location
                TextRenderer.DrawText(e.Graphics, e.Node.Text, e.Node.TreeView.Font, e.Bounds, e.Node.ForeColor);
        }

        private void rtbContactNotes_MouseClick(object sender, MouseEventArgs e)
        {
            if (rtbContactNotes.BackColor == Color.Yellow) {
                rtbContactNotes.Text = string.Empty;
                rtbContactNotes.ForeColor = Color.Black;
                rtbContactNotes.BackColor = Color.Yellow;
                
            }
        }

        private void rtbJobDetailsL2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radC2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radC1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radC1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void radA1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
