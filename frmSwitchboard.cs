using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Configuration;

namespace TransManager
{
    public partial class frmSwitchboard : Form
    {
        User user = new User();
        Utils utils = new Utils();
        frmLogin frmlogin;
        

        public frmSwitchboard()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            frmClient client = new frmClient();
            client.FormClosed += delegate { this.Show(); };
            client.StartPosition = FormStartPosition.Manual;
            Sizer.ResizeForm(client);
            client.Show();
            //this.Hide();
        }



        private void Switchboard_Load(object sender, EventArgs e)
        {
            System.Reflection.Assembly assem = System.Reflection.Assembly.GetEntryAssembly();
            System.Reflection.AssemblyName assemName = assem.GetName();
            Version ver = assemName.Version;
            
            this.label1.Text = ver.Major.ToString() + "." + ver.Minor.ToString() + "." + ver.Revision.ToString();

            UpdateCompletedJobs();    
            PopulateJobCount();
            PopulateDriverInsuranceExpire();
            PopulateDriverLicenceExpire();
            if (Control.ModifierKeys == Keys.Shift)
            {
                User.CurrentUserName = "Anon";
                User.CurrentAccessLevel = 2;
                Log.WriteLine("logging in anonymously");
            }
            else
            {
                frmlogin = new frmLogin(user);
            }
            this.tbScaleHeight.Value = (int)(Sizer.xscale * 100)+1;
            this.tbScaleWidth.Value = (int)(Sizer.yscale *100)+1;
            this.tbFontSize.Value = (int)(Sizer.fscale * 100)+1;
            this.lblScaleHeight.Text = ((int)(Sizer.xscale * 100) + 1).ToString() + "%";
            lblScaleWidth.Text = ((int)(Sizer.yscale * 100) + 1).ToString() + "%";
            lblFontSize.Text = ((int)(Sizer.fscale * 100) + 1).ToString() + "%";


        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (frmClientEdit.CheckInst == null)
            {
                frmClientEdit.CreateInst.Show();
                frmClientEdit.CreateInst.StartPosition = FormStartPosition.Manual;
                Sizer.ResizeForm(frmClientEdit.CreateInst);
            }
            else
            {
                frmClientEdit.CheckInst.WindowState = FormWindowState.Normal;
                frmClientEdit.CheckInst.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (frmClientAdd.CheckInst == null)
            {
                frmClientAdd.CreateInst.Show();
                frmClientAdd.CreateInst.StartPosition = FormStartPosition.Manual;
                Sizer.ResizeForm(frmClientAdd.CreateInst);
            }
            else
            {
                frmClientAdd.CheckInst.WindowState = FormWindowState.Normal;
                frmClientAdd.CheckInst.Focus();
            }
        }

        private void btnDriverEdit_Click(object sender, EventArgs e)
        {
            if (frmDriverEdit.CheckInst == null)
            {
                frmDriverEdit.CreateInst(user).Show();
                frmDriverEdit.CreateInst(user).StartPosition = FormStartPosition.Manual;
                Sizer.ResizeForm(frmDriverEdit.CreateInst(user));
            }
            else
            {
                frmDriverEdit.CheckInst.WindowState = FormWindowState.Normal;
                frmDriverEdit.CheckInst.Focus();
            }

        }

        private void btnDriverAdd_Click(object sender, EventArgs e)
        {
            if (frmDriverAdd.CheckInst == null)
            {
                frmDriverAdd.CreateInst.Show();
                frmDriverAdd.CreateInst.StartPosition = FormStartPosition.Manual;
                Sizer.ResizeForm(frmDriverAdd.CreateInst);
            }
            else
            {
                frmDriverAdd.CheckInst.WindowState = FormWindowState.Normal;
                frmDriverAdd.CheckInst.Focus();
            }

        }

        private void btnTitles_Click(object sender, EventArgs e)
        {
            frmMaintenance frmMaint = new frmMaintenance(Combo.ComboName.Title);
            frmMaint.FormClosed += delegate { this.Show(); };
            frmMaint.StartPosition = FormStartPosition.Manual;
            frmMaint.Show();
            Sizer.ResizeForm(frmMaint);
            frmMaint.Text = "Titles";
            //this.Hide();
        }

        private void btnCarMake_Click(object sender, EventArgs e)
        {
            frmMaintenance frmMaint = new frmMaintenance(Combo.ComboName.CarMake);
            frmMaint.FormClosed += delegate { this.Show(); };
            frmMaint.StartPosition = FormStartPosition.Manual;
            Sizer.ResizeForm(frmMaint);
            frmMaint.Show();
            //this.Hide();
        }

        private void btnCarType_Click(object sender, EventArgs e)
        {
            frmMaintenance frmMaint = new frmMaintenance(Combo.ComboName.CarType);
            frmMaint.FormClosed += delegate { this.Show(); };
            frmMaint.StartPosition = FormStartPosition.Manual;
            Sizer.ResizeForm(frmMaint);
            frmMaint.Show();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMaintenance frmMaint = new frmMaintenance(Combo.ComboName.Attributes);
            frmMaint.FormClosed += delegate { this.Show(); };
            frmMaint.StartPosition = FormStartPosition.Manual;
            Sizer.ResizeForm(frmMaint);
            frmMaint.Show();
            //this.Hide();
        }

        private void btnDestAdd_Click(object sender, EventArgs e)
        {
            frmDestinationAdd frmDest = new frmDestinationAdd("Add");
            frmDest.FormClosed += delegate { this.Show(); };
            frmDest.StartPosition = FormStartPosition.Manual;
            Sizer.ResizeForm(frmDest);
            frmDest.Show();
            //this.Hide();
        }

        private void btnDestUpdate_Click(object sender, EventArgs e)
        {
            frmDestinationAdd frmDest = new frmDestinationAdd("Update");
            frmDest.FormClosed += delegate { this.Show(); };
            frmDest.StartPosition = FormStartPosition.Manual;
            Sizer.ResizeForm(frmDest);
            frmDest.Show();
            //this.Hide();
        }

        private void btnDestDelete_Click(object sender, EventArgs e)
        {
            frmDestinationAdd frmDest = new frmDestinationAdd("Delete");
            frmDest.FormClosed += delegate { this.Show(); };
            frmDest.StartPosition = FormStartPosition.Manual;
            Sizer.ResizeForm(frmDest);
            frmDest.Show();
            //this.Hide();
        }

        private void btnDestinationCategory_Click(object sender, EventArgs e)
        {
            frmMaintenance frmMaint = new frmMaintenance(Combo.ComboName.DestinationCategory);
            frmMaint.FormClosed += delegate { this.Show(); };
            frmMaint.StartPosition = FormStartPosition.Manual;
            Sizer.ResizeForm(frmMaint);
            frmMaint.Show();
            //this.Hide();
        }

        private void btnJobAdd_Click(object sender, EventArgs e)
        {
            //frmJobAdd frmJobAdd = new frmJobAdd();
            //frmJobAdd.FormClosed += delegate { this.Show(); PopulateJobCount(); };
            if (frmJobAdd.CheckInst == null)
            {
                frmJobAdd.CreateInst.Show();
                frmJobAdd.CreateInst.StartPosition = FormStartPosition.Manual;
                Sizer.ResizeForm(frmJobAdd.CreateInst);
            }
            else {
                frmJobAdd.CheckInst.WindowState = FormWindowState.Normal;
                frmJobAdd.CheckInst.Focus();
            }
            
            ////this.Hide();
        }

        private void btnJobEdit_Click(object sender, EventArgs e)
        {
            if(frmJobEdit.CheckInst == null)
            {
                frmJobEdit.CreateInst.Show();
                frmJobEdit.CreateInst.StartPosition = FormStartPosition.Manual;
                Sizer.ResizeForm(frmJobEdit.CreateInst);
            }
            else {
                frmJobEdit.CheckInst.WindowState = FormWindowState.Normal;
                frmJobEdit.CheckInst.Focus();
            }

        }

        private void btnJobStatus_Click(object sender, EventArgs e)
        {
            frmMaintenance frmMaint = new frmMaintenance(Combo.ComboName.JobStatus);
            frmMaint.FormClosed += delegate { this.Show(); };
            frmMaint.StartPosition = FormStartPosition.Manual;
            Sizer.ResizeForm(frmMaint);
            frmMaint.Show();
            //this.Hide();
        }

        private void btnJobQueue_Click(object sender, EventArgs e)
        {
            if (frmJobQueue.CheckInst == null)
            {
                frmJobQueue.CreateInst.Show();
                frmJobQueue.CreateInst.StartPosition = FormStartPosition.Manual;
                Sizer.ResizeForm(frmJobQueue.CreateInst);
                //frmJobQueue.CheckInst.LostFocus += delegate { frmJobQueue.CheckInst.WindowState = FormWindowState.Minimized; this.Show(); PopulateJobCount(); };
            }
            else
            {
                frmJobQueue.CheckInst.WindowState = FormWindowState.Normal;
                frmJobQueue.CheckInst.Focus();
            }
        }

        private void btnJobsExpired_Click(object sender, EventArgs e)
        {
            if (frmJobQueueExpired.CheckInst == null)
            {
                frmJobQueueExpired.CreateInst.Show();
                frmJobQueueExpired.CreateInst.StartPosition = FormStartPosition.Manual;
                Sizer.ResizeForm(frmJobQueueExpired.CreateInst);
                //frmJobQueueExpired.CheckInst.LostFocus += delegate { frmJobQueueExpired.CheckInst.WindowState = FormWindowState.Minimized; this.Show(); PopulateJobCount(); };
            }
            else
            {
                frmJobQueueExpired.CheckInst.WindowState = FormWindowState.Normal;
                frmJobQueueExpired.CheckInst.Focus();
            }
        }

        private void UpdateCompletedJobs() {

            OleDbConnection sqlConnection1 = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            sqlConnection1.Open();

            using (sqlConnection1)
            {
                OleDbCommand cmd = new OleDbCommand();
                
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "exec qryUpdateExpiredCompletedJobs";
                cmd.Connection = sqlConnection1;

                cmd.ExecuteScalar();
                               
            }
        }

        private void PopulateJobCount()
        {

            OleDbConnection sqlConnection1 = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            sqlConnection1.Open();

            using (sqlConnection1)
            {
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataReader dr;

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select * from qryJobStatusCount";
                cmd.Connection = sqlConnection1;

                dr = cmd.ExecuteReader();

                rtbJobSummary.Clear();

                while (dr.Read())
                {
                    rtbJobSummary.Text += dr.GetInt32(dr.GetOrdinal("JobCount")).ToString() + " - ";
                    rtbJobSummary.Text += dr.GetValue(dr.GetOrdinal("Description"));
                    rtbJobSummary.Text += Environment.NewLine;
                }
            }
        }

        private void PopulateDriverInsuranceExpire()
        {

            OleDbConnection sqlConnection1 = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            sqlConnection1.Open();

            using (sqlConnection1)
            {
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataReader dr;

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select * from qryDriverInsuranceExpire";
                cmd.Connection = sqlConnection1;

                dr = cmd.ExecuteReader();

                rtbInsuranceExpire.Clear();

                while (dr.Read())
                {
                    rtbInsuranceExpire.Text += dr.GetValue(dr.GetOrdinal("DriverName")).ToString() + " (";
                    rtbInsuranceExpire.Text += dr.GetDateTime(dr.GetOrdinal("ExpiryDate")).ToShortDateString() + ")";
                    rtbInsuranceExpire.Text += Environment.NewLine;
                }

                rtbInsuranceExpire.Text = rtbInsuranceExpire.Text == string.Empty ? "None" : rtbInsuranceExpire.Text;
                
            }
        }

        private void PopulateDriverLicenceExpire()
        {

            OleDbConnection sqlConnection1 = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            sqlConnection1.Open();

            using (sqlConnection1)
            {
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataReader dr;

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select * from qryDriverLicenceExpire";
                cmd.Connection = sqlConnection1;

                dr = cmd.ExecuteReader();

                rtbLicenceExpire.Clear();

                while (dr.Read())
                {
                    rtbLicenceExpire.Text += dr.GetValue(dr.GetOrdinal("DriverName")).ToString() + " (";
                    rtbLicenceExpire.Text += dr.GetDateTime(dr.GetOrdinal("LicenceExpiry")).ToShortDateString() + ")";
                    rtbLicenceExpire.Text += Environment.NewLine;
                }

                rtbLicenceExpire.Text = (rtbLicenceExpire.Text == string.Empty) ? "None" : rtbLicenceExpire.Text;

            }
        }

        private void btnLicenceExpiry_Click(object sender, EventArgs e)
        {
            frmLicenceExpiry frmlicenceexpiry = new frmLicenceExpiry(Attribute.ExpiryType.insurance);
            frmlicenceexpiry.FormClosed += delegate { this.Show(); };
            frmlicenceexpiry.StartPosition = FormStartPosition.Manual;
            Sizer.ResizeForm(frmlicenceexpiry);
            frmlicenceexpiry.Show();
        }

        private void btnInsuranceExpiry_Click(object sender, EventArgs e)
        {
            frmLicenceExpiry frminsuranceexpiry = new frmLicenceExpiry(Attribute.ExpiryType.insurance);
            frminsuranceexpiry.FormClosed += delegate { this.Show(); };
            frminsuranceexpiry.StartPosition = FormStartPosition.Manual;
            Sizer.ResizeForm(frminsuranceexpiry);
            frminsuranceexpiry.Show();
            //this.Hide();
        }

        private void rtbJobSummary_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabInfo_Click(object sender, EventArgs e)
        {
            PopulateDriverInsuranceExpire();
            PopulateDriverLicenceExpire();
            PopulateJobCount();
        }
            

        private void tbScaleWidth_Scroll(object sender, EventArgs e)
        {
            lblScaleWidth.Text = "Width Scale = " + tbScaleWidth.Value.ToString() + "%";
            Sizer.xscale = (float)(tbScaleWidth.Value / 100.0);
        }

        private void tbScaleHeight_Scroll(object sender, EventArgs e)
        {
            lblScaleHeight.Text = "Height Scale = " + tbScaleHeight.Value.ToString() + "%";
            Sizer.yscale = (float)(tbScaleHeight.Value / 100.0);
        }
        //private void Show(int accesslevel) {
        //    if (accesslevel > 0)
        //    {
        //        this.Visible = true;
        //    }
        //    else {
        //        Application.Exit();
        //    }

        //}
        private void AAA() {
            this.Opacity = 109;
            if (User.CurrentAccessLevel > 1)
            {
                Configuration.TabPages[5].Show();
            }
            else {
                Configuration.TabPages[5].Hide();
            }
        }


        private void frmSwitchboard_MouseMove(object sender, MouseEventArgs e)
        {
            //if (user.AccessLevel < -1)
            //{
            //    this.Opacity = 50;
            //    this.Configuration.Enabled = false;  
            //    frmlogin.StartPosition = FormStartPosition.CenterScreen;
            //    frmlogin.ShowDialog();
            //    frmlogin.FormClosed += delegate { this.AAA(); };
            //}
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMaintenanceLogIn login = new frmMaintenanceLogIn();
            login.Show();

        }

        private void frmSwitchboard_Activated(object sender, EventArgs e)
        {
            if (User.CurrentAccessLevel < 1)
            {
                this.Opacity = 2;
                frmlogin.StartPosition = FormStartPosition.CenterScreen;
                
                frmlogin.ShowDialog();
                frmlogin.FormClosed += delegate { this.AAA(); };
            }
        }

        private void tbFontSize_Scroll(object sender, EventArgs e)
        {
            lblFontSize.Text = "Font Scale = " + tbFontSize.Value.ToString() + "%";
            Sizer.fscale = (float)(tbFontSize.Value / 100.0);
        }

        private void btnSetScale_Click(object sender, EventArgs e)
        {
           if(utils.SetScale(tbScaleWidth.Value, tbScaleHeight.Value, tbFontSize.Value)){
                MessageBox.Show("Succesfully saved scales", this.Text);
            }
            else
            {
                MessageBox.Show("Scales not saved", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}