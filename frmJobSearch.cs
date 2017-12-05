using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransManager
{
    public partial class frmJobSearch : Form
    {
        IEnumerable<Job> querybySurname;
        IEnumerable<Job> querybyPostCode;
        IEnumerable<Job> queryCurrent;
        IEnumerable<Job> querybyID;

        Jobs collJobs;
        
        public frmJobSearch()
        {
            InitializeComponent();
            Jobs jobs = new Jobs(Jobs.ContactView.Current);
        
        }

        

        private void txtSearchSurname_TextChanged(object sender, EventArgs e)
        {
            queryCurrent = querybySurname;
            LoadListView(queryCurrent);
        }

        private void LoadListView(IEnumerable<Job> query)
        {
            this.lvSearchResults.ListViewItemSorter = null;
            lvSearchResults.Items.Clear();

            foreach (Job job in query)
            {
                ListViewItem lvi = lvSearchResults.Items.Add(job.JobID.ToString());
                lvi.SubItems.Add(job.ClientName);
                lvi.SubItems.Add(job.ClientPostCode);
                lvi.SubItems.Add(job.JobDate.ToShortDateString());
             }
        }

        private void chkJobClosed_CheckedChanged(object sender, EventArgs e)
        {
            LoadListView(queryCurrent);
        }

        private void chkJobCancelled_CheckedChanged(object sender, EventArgs e)
        {
            LoadListView(queryCurrent);
        }

        private void chkJobOpen_CheckedChanged(object sender, EventArgs e)
        {
            LoadListView(queryCurrent);
        }

        private void chkJobNeedsDriver_CheckedChanged(object sender, EventArgs e)
        {
            LoadListView(queryCurrent);
        }

        private void frmJobSearch_Load(object sender, EventArgs e)
        {
            collJobs = new Jobs(Jobs.ContactView.Current);

            querybySurname = collJobs.Where(s => (s.StatusID == 1 && chkJobCancelled.Checked) || (s.StatusID == 2 && chkJobClosed.Checked) || (s.StatusID == 3 && chkJobNeedsDriver.Checked) || (s.StatusID == 4 && chkJobOpen.Checked)).Where(s => s.ClientSurname.ToString().ToUpper().StartsWith(txtSearchSurname.Text.ToUpper())).OrderBy(id => id.ClientSurname);

            queryCurrent = querybySurname;
            LoadListView(queryCurrent);
        }

        private void txtPostCode_TextChanged(object sender, EventArgs e)
        {
            querybyPostCode = collJobs.Where(s => (s.StatusID == 1 && chkJobCancelled.Checked) || (s.StatusID == 2 && chkJobClosed.Checked) || (s.StatusID == 3 && chkJobNeedsDriver.Checked) || (s.StatusID == 4 && chkJobOpen.Checked)).Where(s => s.ClientPostCode.ToString().ToUpper().StartsWith(txtPostCode.Text.ToUpper())).OrderBy(id => id.ClientSurname);
            queryCurrent = querybyPostCode;
            LoadListView(queryCurrent);
        }
        

        private void LoadClient(IEnumerable<Job> querybyID)
        {
            Job job = querybyID.FirstOrDefault();
            txtJobID.Text = job.JobID.ToString();
            rtbClientDetails.Text = job.ClientName + Environment.NewLine;
            rtbClientDetails.Text += job.ClientAddressLine1 + Environment.NewLine;
            if (!(job.ClientAddressLine2 == string.Empty)) {
                rtbClientDetails.Text += job.ClientAddressLine2 + Environment.NewLine;
            }
            if (!(job.ClientTown == string.Empty))
            {
                rtbClientDetails.Text += job.ClientTown + Environment.NewLine;
            }
            if (!(job.ClientPostCode == string.Empty)) {
                rtbClientDetails.Text += job.ClientPostCode + Environment.NewLine;
            }
            

        }

        private void lvSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSearchResults.SelectedItems.Count > 0)
            {
                if (querybyID == null)
                {
                    querybyID = collJobs.Where(s => s.JobID.ToString() == (lvSearchResults.SelectedItems.Count == 0 ? this.txtJobID.Text : lvSearchResults.SelectedItems[0].SubItems[0].Text));
                }
                LoadClient(querybyID);
                
            }
        }
    }
}
