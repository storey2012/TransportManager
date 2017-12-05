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
    public partial class frmDailyList : Form
    {
        Jobs jobs;
        DateTime dtJobs;

        public frmDailyList(DateTime dt)
        {
            InitializeComponent();
            dtJobs = dt;
        }
        public frmDailyList() {
            InitializeComponent();
        }
        

        private void frmDailyList_Load(object sender, EventArgs e)
        {
            LoadListView(dtJobs);
        }


        public void LoadListView(DateTime dt)
        {
            jobs = new Jobs(Jobs.ContactView.CurrentLinker, dt);
            lvJobs.Items.Clear();
            rtbJobNotes.Clear();
            rtbLink1.Clear();
            rtbLink2.Clear();
            rtbLink1.BackColor = rtbLink2.BackColor = Color.White;
            btnLink.Enabled = false;
            btnLink.Text = "Link the Jobs";
       
            //foreach (Job j in jobs.Where(h => h.JobDate == dt.Date || ((h.JobDate.AddDays(-1) == dt.Date || h.JobDate.AddDays(1) == dt.Date) && h.HasLinkedJob)).OrderBy(s => s.ClientSurname))
            foreach(Job j in jobs.OrderBy(s => s.JobDate).OrderBy(s => s.PickUpTime))
            {
                Job job = new Job(j.JobID);
                ListViewItem lv = lvJobs.Items.Add(job.JobID.ToString());
                //ListViewItem lv = lvJobs.Groups[job.HasLinkedJob ? 0 : 1].Items.Add(job.JobID.ToString());
                lvJobs.Groups[job.HasLinkedJob ? 0 : 1].Items.Add(lv);
                lvJobs.ShowItemToolTips = true;
                lv.ToolTipText = job.JobID.ToString();
                lv.SubItems.Add(job.ClientName);
                lv.SubItems.Add(job.joblegs[0].PickUpAddressLine1 + " " + job.ClientPostCode);
                lv.SubItems.Add(job.joblegs[0].AppointmentTime==null ? "not set" : job.joblegs[0].AppointmentTime.ToShortTimeString());
                lv.SubItems.Add(job.joblegs[0].DropName);
                lv.SubItems.Add(job.joblegs[0].DropAddressLine1 + " " + job.joblegs[0].DropPostCode);
                lv.SubItems.Add(job.JobDate.ToShortDateString());
                lv.UseItemStyleForSubItems = false;
                lv.SubItems[0].BackColor = job.HasLinkedJob ? System.Drawing.Color.LightBlue : lv.BackColor;
                lv.SubItems[1].BackColor = job.HasLinkedJob ? System.Drawing.Color.LightBlue : lv.BackColor;
                lv.SubItems[2].BackColor = job.HasLinkedJob ? System.Drawing.Color.LightBlue : lv.BackColor;
                lv.SubItems[3].BackColor = job.HasLinkedJob ? System.Drawing.Color.LightBlue : lv.BackColor;
                lv.SubItems[4].BackColor = job.HasLinkedJob ? System.Drawing.Color.LightBlue : lv.BackColor;
                lv.SubItems[5].BackColor = job.HasLinkedJob ? System.Drawing.Color.LightBlue : lv.BackColor;
                lv.SubItems[6].BackColor = job.HasLinkedJob ? System.Drawing.Color.LightCoral : lv.BackColor;
                
            }
            
        }

        private void lvJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvJobs.SelectedItems.Count > 0) { 
                //Job job = jobs.Where(j => j.JobID == Convert.ToInt32(lvJobs.SelectedItems[0].Text)).First<Job>();
                Job job = new Job(Convert.ToInt32(lvJobs.SelectedItems[0].Text));
                rtbJobNotes.Text = job.Notes;
                LoadLink(job);
            }
           
        }

        private void LoadLink(Job job) {

            if (rtbLink1.Tag.ToString() == job.ClientID.ToString())
            {
                rtbLink2.Tag = rtbLink1.Tag;
                rtbLink2.Text = rtbLink1.Text;
                rtbLink2.BackColor = job.HasLinkedJob ? Color.Pink : Color.Yellow;
                splitContainer1.Panel2.Tag = splitContainer1.Panel1.Tag;
            }
            else {
                rtbLink1.Clear();
                rtbLink1.Tag=string.Empty;
                splitContainer1.Panel1.Tag = string.Empty;
                rtbLink2.Clear();
                rtbLink2.Tag=string.Empty;
                splitContainer1.Panel2.Tag = string.Empty;
                rtbLink2.BackColor = System.Drawing.Color.White;
            }

            rtbLink1.Tag = job.ClientID;
            rtbLink1.Text = "Job ID:" + job.ClientName + System.Environment.NewLine;
            rtbLink1.Text += "Client Name: " + job.ClientName + System.Environment.NewLine;
            rtbLink1.Text += "From: " + job.joblegs[0].PickUpName + System.Environment.NewLine;
            rtbLink1.Text += "To: " + job.joblegs[0].DropName + System.Environment.NewLine;
            rtbLink1.Text += "On: " + job.JobDate.ToShortDateString() + " at " + job.joblegs[0].AppointmentTime.ToShortTimeString();
            if (job.HasLinkedJob) {
                Job job1 = new Job(job.LinkedJobID);
                rtbLink2.Tag = job.ClientID;
                rtbLink2.Text = "Job ID:" + job1.ClientName + System.Environment.NewLine;
                rtbLink2.Text += "Client Name: " + job1.ClientName + System.Environment.NewLine;
                rtbLink2.Text += "From: " + job1.joblegs[0].PickUpName + System.Environment.NewLine;
                rtbLink2.Text += "To: " + job1.joblegs[0].DropName + System.Environment.NewLine;
                rtbLink2.Text += "On: " + job1.JobDate.ToShortDateString() + " at " + job1.joblegs[0].AppointmentTime.ToShortTimeString();
                rtbLink2.BackColor = Color.Pink;
                splitContainer1.Panel2.Tag = job1.JobID;
            }

            rtbLink1.BackColor = job.HasLinkedJob ? Color.Pink : Color.Yellow;
            lblLink1.Text = rtbLink1.BackColor == Color.Pink ? "Unlink this job" : "Link this job";
            lblLink2.Text = rtbLink1.BackColor == Color.Pink ? "from this job" : "to this job";
            btnLink.Text = rtbLink1.BackColor == Color.Pink ? "Unlink the Jobs" : "Link the Jobs";
            btnLink.Enabled = (rtbLink1.BackColor.Name.ToString() == rtbLink2.BackColor.Name.ToString());

            splitContainer1.Panel1.Tag = job.JobID;
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            Job job = new Job(Convert.ToInt32(splitContainer1.Panel1.Tag));

            if (job.LinkJob(Convert.ToInt32(splitContainer1.Panel2.Tag), btnLink.Text == "Unlink the Jobs"))
            {
                MessageBox.Show("Successfully linked/unlinked jobs",this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListView(dtJobs);
            }
            else {
                MessageBox.Show("Unable to link jobs",this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
