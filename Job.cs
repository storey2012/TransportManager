using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Data.OleDb;
using System.Configuration;

namespace TransManager
{
    public class Job
    {
        public Collection<JobLeg> joblegs = new Collection<JobLeg>();
        public Collection<JobContact> jobcontacts = new Collection<JobContact>();
        private int _jobid;
        private int _linkedjobid;
        private int _clientid;
        private int _sourceid;
        private int _statusid;
        private int _prioritylevel;
        private int _lastattribute;
        private int _legcount;
        private string _status;
        private string _pendingstatus;
        private DateTime _jobdate;
        private DateTime _pickuptime;
        private string _notes;
        private bool _DVCwheelchair;
        private bool _hasLinkedJob;
        private string _linkedMessage;
        private string _clientname;
        private string _clientsurname;
        private string _clientAddressLine1;
        private string _clientAddressLine2;
        private string _clientTown;
        private string _clientPostCode;
        private DateTime _enteredat;
        private string _enteredby;


        private string _driverFullName;

        public Job() { }

        public Job(int jobid) {
            OleDbConnection sqlConnection1 = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());
            
            sqlConnection1.Open();

            using (sqlConnection1)
            {
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataReader dr;
                Boolean blnLeg1 = true;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select * from vwJob where jobid=" + jobid.ToString() + " order by legid";
                cmd.Connection = sqlConnection1;

                dr = cmd.ExecuteReader();
                Log.WriteCommand(cmd);
                while (dr.Read())
                {
                    if (blnLeg1)
                    {
                        _jobid = dr.GetInt32(dr.GetOrdinal("JobID"));
                        _clientid = dr.GetInt32(dr.GetOrdinal("ClientID"));
                        _jobdate = dr.GetDateTime(dr.GetOrdinal("JobDate"));
                        _sourceid = dr.GetInt32(dr.GetOrdinal("JobSourceID"));
                        _statusid = dr.GetInt32(dr.GetOrdinal("StatusID"));
                        _status = dr.GetValue(dr.GetOrdinal("Status")).ToString();
                        _pendingstatus = dr.GetValue(dr.GetOrdinal("PendingStatus")).ToString();
                        _notes = dr.GetValue(dr.GetOrdinal("Notes")).ToString();
                        _DVCwheelchair = dr.GetBoolean(dr.GetOrdinal("DVCWheelchairNeeded"));
                        _clientname = dr.GetValue(dr.GetOrdinal("ClientName")).ToString();
                        _clientAddressLine1 = dr.GetValue(dr.GetOrdinal("AddressLine1")).ToString();
                        _clientAddressLine2 = dr.GetValue(dr.GetOrdinal("AddressLine2")).ToString();
                        _clientTown = dr.GetValue(dr.GetOrdinal("Town")).ToString();
                        _clientPostCode = dr.GetValue(dr.GetOrdinal("PostCode")).ToString();
                        _enteredat = dr.GetDateTime(dr.GetOrdinal("EnteredAt"));
                        _enteredby = dr.GetValue(dr.GetOrdinal("EnteredBy")).ToString();
                        _lastattribute = dr.GetInt32(dr.GetOrdinal("AttributeID"));
                        _hasLinkedJob = Convert.ToBoolean(dr.GetInt32(dr.GetOrdinal("HasLinkedJob")));
                        _linkedMessage = dr.GetValue(dr.GetOrdinal("LinkMessage")).ToString();
                        _linkedjobid = dr.GetInt32(dr.GetOrdinal("LinkedJobID"));
                    }
                        JobLeg jobleg = new JobLeg();
                        jobleg.JobID = _jobid;
                        jobleg.JobLegID = dr.GetInt32(dr.GetOrdinal("LegID"));
                        jobleg.JobSequenceID = dr.GetInt32(dr.GetOrdinal("JobSequenceID"));
                        if (dr.GetValue(dr.GetOrdinal("JobAppointmentTime")).ToString()!=string.Empty) { 
                            jobleg.AppointmentTime = dr.GetDateTime(dr.GetOrdinal("JobAppointmentTime"));
                        }
                    if (dr.GetValue(dr.GetOrdinal("JobPickUpTime")).ToString() != string.Empty)
                    {
                        jobleg.PickUpTime = dr.GetDateTime(dr.GetOrdinal("JobPickUpTime"));
                    }
                    jobleg.DriverID = dr.GetInt32(dr.GetOrdinal("DriverID"));
                    jobleg.PickUpName = dr.GetValue(dr.GetOrdinal("PUDestName")).ToString();
                    jobleg.PickUpAddressLine1 = dr.GetValue(dr.GetOrdinal("PUAddressLine1")).ToString();
                    jobleg.PickUpAddressLine2 = dr.GetValue(dr.GetOrdinal("PUAddressLine2")).ToString();
                    jobleg.PickUpTown = dr.GetValue(dr.GetOrdinal("PUTown")).ToString();
                    jobleg.PickUpPostCode = dr.GetValue(dr.GetOrdinal("PUPostCode")).ToString();
                    jobleg.PickUpDestinationID = dr.GetInt32(dr.GetOrdinal("DestinationStartID"));
                    jobleg.DriverName = dr.GetValue(dr.GetOrdinal("DriverName")).ToString();


                    jobleg.DropName = dr.GetValue(dr.GetOrdinal("DestDestName")).ToString();
                    jobleg.DropAddressLine1 = dr.GetValue(dr.GetOrdinal("DestAddressLine1")).ToString();
                    jobleg.DropAddressLine2 = dr.GetValue(dr.GetOrdinal("DestAddressLine2")).ToString();
                    jobleg.DropTown = dr.GetValue(dr.GetOrdinal("DestTown")).ToString();
                    jobleg.DropPostCode = dr.GetValue(dr.GetOrdinal("DestPostCode")).ToString();
                    jobleg.DropDestinationID = dr.GetInt32(dr.GetOrdinal("DestinationEndID"));


                    joblegs.Add(jobleg);
                    blnLeg1 = false;
                    }
                _driverFullName = joblegs[0].DriverName;
            }

        }

        public void RefreshHasLinkedJob()
        {
            OleDbConnection sqlConnection1 = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            sqlConnection1.Open();

            using (sqlConnection1)
            {
                _hasLinkedJob = false;
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataReader dr;
                
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select HasLinkedJob, LinkMessage from vwJobs where jobid=" + _jobid.ToString() ;
                cmd.Connection = sqlConnection1;

                dr = cmd.ExecuteReader();
                Log.WriteCommand(cmd);
                while (dr.Read())
                {
                    _hasLinkedJob = Convert.ToBoolean(dr.GetInt32(dr.GetOrdinal("HasLinkedJob")));
                    _linkedMessage = dr.GetValue(dr.GetOrdinal("LinkMessage")).ToString();
                }
            }
        }
        public Boolean LinkJob(int jobid) {
            return LinkJob(jobid, false);
        }

        public Boolean LinkJob(int jobid, Boolean unlink) {
            try
            {
                OleDbConnection sqlConnection = new OleDbConnection();

                sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

                using (sqlConnection)
                {

                    sqlConnection.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = sqlConnection;

                    if (!unlink)
                    {
                        cmd.CommandText = "UPDATE Jobs SET LinkedJobID = @var1 WHERE JobID = @var2";

                        cmd.Parameters.Add(new OleDbParameter("@var1", jobid));
                        cmd.Parameters.Add(new OleDbParameter("@var2", _jobid));

                        Log.WriteCommand(cmd);
                        cmd.ExecuteScalar();

                        cmd.Parameters.Clear();

                        cmd.Parameters.Add(new OleDbParameter("@var1", _jobid));
                        cmd.Parameters.Add(new OleDbParameter("@var2", jobid));

                        Log.WriteCommand(cmd);
                        cmd.ExecuteScalar();

                        cmd.CommandText = "UPDATE Jobs SET LinkedJobID = 0 WHERE LinkedJobID IN(@var1 , @var2) AND JobID NOT IN(@var1, @var2)";

                        cmd.Parameters.Clear();

                        cmd.Parameters.Add(new OleDbParameter("@var1", _jobid));
                        cmd.Parameters.Add(new OleDbParameter("@var2", jobid));

                        Log.WriteCommand(cmd);
                        cmd.ExecuteScalar();
                    }
                    else {
                        cmd.CommandText = "UPDATE Jobs SET LinkedJobID = 0 WHERE JobID = @var1 OR LinkedJObID = @var1";
                        cmd.Parameters.Add(new OleDbParameter("@var1", _jobid));
                        cmd.ExecuteScalar();
                        Log.WriteCommand(cmd);
                    }
                }
            }
            catch (SystemException e)
            {
                return false;
            }
            return true;
        }
        public void LoadJobContacts()
        {
            
            OleDbConnection sqlConnection = new OleDbConnection();

            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            using (sqlConnection)
            {
                jobcontacts.Clear();

                sqlConnection.Open();

                OleDbCommand cmd = new OleDbCommand();
                OleDbDataReader dr;

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM vwjobAttributes WHERE JobID = @var1 ORDER BY EnteredAt ASC";

                cmd.Parameters.Add(new OleDbParameter("@var1", _jobid));

                cmd.Connection = sqlConnection;
                Log.WriteCommand(cmd);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    JobContact jobcontact = new JobContact();
                    jobcontact.JobID = _jobid;
                    jobcontact.ContactID = dr.GetInt32(dr.GetOrdinal("JobAttributeID"));
                    jobcontact.AttributeID = dr.GetInt32(dr.GetOrdinal("AttributeID"));
                    jobcontact.LinkID = dr.GetInt32(dr.GetOrdinal("LinkID"));
                    jobcontact.LinkName = dr.GetValue(dr.GetOrdinal("LinkName")).ToString();
                    jobcontact.LinkType = dr.GetValue(dr.GetOrdinal("LinkType")).ToString();
                    jobcontact.AttributeLevel = dr.GetInt32(dr.GetOrdinal("AttributeLevel"));
                    jobcontact.AttributeID = dr.GetInt32(dr.GetOrdinal("AttributeID"));
                    jobcontact.PhoneUsed = dr.GetValue(dr.GetOrdinal("PhoneUsed")).ToString();
                    jobcontact.Note = dr.GetValue(dr.GetOrdinal("Notes")).ToString();
                    jobcontact.Action = dr.GetValue(dr.GetOrdinal("AttributeText")).ToString();
                    jobcontact.EnteredAt = dr.GetDateTime(dr.GetOrdinal("EnteredAt"));
                    jobcontact.EnteredBy = dr.GetValue(dr.GetOrdinal("EnteredBy")).ToString();
                    jobcontacts.Add(jobcontact);
                }

                sqlConnection.Close();

            }

        }

        public string UpdateJobStatus(int jobid, int linkid, int attributeid, string note) {

            try
            {
                OleDbConnection sqlConnection = new OleDbConnection();

                sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

                using (sqlConnection)
                {

                    sqlConnection.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "INSERT INTO JobContactStatus(JobID, LinkID, AttributeID, Notes) @var1, @var2, @var3, @var4";

                    cmd.Parameters.Add(new OleDbParameter("@var1", jobid));
                    cmd.Parameters.Add(new OleDbParameter("@var2", linkid));
                    cmd.Parameters.Add(new OleDbParameter("@var3", attributeid));
                    cmd.Parameters.Add(new OleDbParameter("@var4", note));
                    cmd.Connection = sqlConnection;

                    Log.WriteCommand(cmd);
                    cmd.ExecuteScalar();

                    if (attributeid == 21) {
                        //this attribute denotes job REJECTED by Driver so needs to revert any previous contacts to same
                        //driver back to zero
                        cmd.Parameters.Clear();
                        cmd.CommandText = "UPDATE JobContactStatus SET StatusLevel = 0 WHERE JobID = @var1 and LinkID = @var2 and AttributeID IN(17,18,19,22)";
                        cmd.Parameters.Add(new OleDbParameter("@var1", jobid));
                        cmd.Parameters.Add(new OleDbParameter("@var2", linkid));
                        Log.WriteCommand(cmd);
                        cmd.ExecuteScalar();

                    }

                }
            }
            catch (SystemException e)
            {
                return e.Message;
            }

            return "Successfully updated job details";

        }

        public bool DeleteJobLeg(int jobleg) {
            try
            {
                OleDbConnection sqlConnection = new OleDbConnection();

                sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

                using (sqlConnection)
                {

                    sqlConnection.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "DELETE FROM JobLegs WHERE JobSequenceID = @var1 and LegID = 2";

                    cmd.Parameters.Add(new OleDbParameter("@var1", joblegs[1].JobSequenceID));
                    cmd.Connection = sqlConnection;
                    Log.WriteCommand(cmd);
                    cmd.ExecuteScalar();

                    
                }
            }
            catch (SystemException e)
            {
                return false;
            }
            return true;
        }

        

        public string AddJob() {

            try {
                OleDbConnection sqlConnection = new OleDbConnection();

                sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

                using (sqlConnection)
                {

                    sqlConnection.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "INSERT INTO Jobs(ClientID, Notes, JobDate, DVCWheelchairNeeded, JobSourceID, EnteredBy) SELECT @var1, @var2, @var3, @var4, @var5, @var6";

                    cmd.Parameters.Add(new OleDbParameter("@var1", _clientid));
                    cmd.Parameters.Add(new OleDbParameter("@var2", _notes));
                    cmd.Parameters.Add(new OleDbParameter("@var3", _jobdate));
                    cmd.Parameters.Add(new OleDbParameter("@var4", _DVCwheelchair));
                    cmd.Parameters.Add(new OleDbParameter("@var5", _sourceid));
                    cmd.Parameters.Add(new OleDbParameter("@var6", (User.CurrentUserName == null ? "Unknown" : User.CurrentUserName)));
                    cmd.Connection = sqlConnection;

                    Log.WriteCommand(cmd);
                    cmd.ExecuteScalar();

                    cmd.CommandText = "select @@IDENTITY";
                    
                    _jobid = (int)cmd.ExecuteScalar();
                    Int32 i;
                        
                    for (i= 0; i< this.joblegs.Count; i++) {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "INSERT INTO JobLegs(JobID, LegID, DriverID, DestinationStartID, DestinationEndID, JobPickUpTime, JobAppointmentTime, EnteredBy) SELECT @var1, @var2, @var3, @var4, @var5, @var6, @var7, @var8";
                        cmd.Parameters.Add(new OleDbParameter("@var1", _jobid));
                        cmd.Parameters.Add(new OleDbParameter("@var2", i+1));
                        cmd.Parameters.Add(new OleDbParameter("@var3", joblegs[i].DriverID));
                        cmd.Parameters.Add(new OleDbParameter("@var4", joblegs[i].PickUpDestinationID));
                        cmd.Parameters.Add(new OleDbParameter("@var5", joblegs[i].DropDestinationID));
                        cmd.Parameters.Add(new OleDbParameter("@var6", joblegs[i].PickUpTime));
                        
                        cmd.Parameters.Add(new OleDbParameter("@var7", joblegs[i].AppointmentTime));
                        cmd.Parameters.Add(new OleDbParameter("@var8", (User.CurrentUserName == null ? "Unknown" : User.CurrentUserName)));
                        Log.WriteCommand(cmd);
                        cmd.ExecuteScalar();
                    }

                    //If job is sourced by driver we will need to record contacts for both
                    //driver and client to bring status up to date.
                    if (_sourceid == 2) {
                        JobContact jobcontact = new JobContact();
                        jobcontact.JobID = _jobid;
                        jobcontact.LinkID = joblegs[0].DriverID;
                        jobcontact.AttributeID = 21;
                        jobcontact.Note = "Driver phoned this job through.";
                        jobcontact.PhoneUsed = "*";
                        jobcontact.AddJobContact();

                        //add the client contact.
                        jobcontact.LinkID = _clientid;
                        jobcontact.AttributeID = 26;
                        jobcontact.Note = "Driver phoned this job through - already arranged with client.";
                        jobcontact.PhoneUsed = "*";
                        jobcontact.AddJobContact();

                    }
                }
            }
            catch(SystemException e)
            {
                return e.Message;
            }

            return "Successfully added job";

        }

        public string UpdateJob(bool bApptChange)
        {

            try
            {
                OleDbConnection sqlConnection = new OleDbConnection();

                sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

                using (sqlConnection)
                {

                    sqlConnection.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "UPDATE Jobs SET Notes = @var1, JobDate = @var2, DVCWheelchairNeeded = @var3, JobSourceID = @var4 WHERE JobID = @var5";
                    
                    cmd.Parameters.Add(new OleDbParameter("@var1", _notes));
                    cmd.Parameters.Add(new OleDbParameter("@var2", _jobdate));
                    cmd.Parameters.Add(new OleDbParameter("@var3", _DVCwheelchair));
                    cmd.Parameters.Add(new OleDbParameter("@var4", _sourceid));
                    cmd.Parameters.Add(new OleDbParameter("@var5", _jobid));
                    cmd.Connection = sqlConnection;
                    Log.WriteCommand(cmd);
                    cmd.ExecuteScalar();

                    for (Int32 i = 0; i < this.joblegs.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        if (joblegs[i].JobSequenceID == 0)
                        {
                            cmd.CommandText = "INSERT INTO JobLegs(JobID, LegID, DriverID, DestinationStartID, DestinationEndID, JobPickUpTime, JobAppointmentTime, EnteredBy) SELECT @var1, @var2, @var3, @var4, @var5, @var6, @var7, @var8";
                            cmd.Parameters.Add(new OleDbParameter("@var1", _jobid));
                            cmd.Parameters.Add(new OleDbParameter("@var2", i + 1));
                            cmd.Parameters.Add(new OleDbParameter("@var3", joblegs[i].DriverID));
                            cmd.Parameters.Add(new OleDbParameter("@var4", joblegs[i].PickUpDestinationID));
                            cmd.Parameters.Add(new OleDbParameter("@var5", joblegs[i].DropDestinationID));
                            cmd.Parameters.Add(new OleDbParameter("@var6", joblegs[i].PickUpTime));

                            cmd.Parameters.Add(new OleDbParameter("@var7", joblegs[i].AppointmentTime));
                            cmd.Parameters.Add(new OleDbParameter("@var8", (User.CurrentUserName == null ? "Unknown" : User.CurrentUserName)));
                            cmd.ExecuteScalar();
                        }
                        else
                        {
                            cmd.CommandText = "UPDATE JobLegs SET LegID = @var1, DriverID=@var2, DestinationStartID =@var3, DestinationEndID = @var4, JobPickUpTime = @var5, JobAppointmentTime = @var6 WHERE JobSequenceId = @var7";
                            cmd.Parameters.Add(new OleDbParameter("@var1", i + 1));
                            cmd.Parameters.Add(new OleDbParameter("@var2", joblegs[i].DriverID));
                            cmd.Parameters.Add(new OleDbParameter("@var3", joblegs[i].PickUpDestinationID));
                            cmd.Parameters.Add(new OleDbParameter("@var4", joblegs[i].DropDestinationID));
                            cmd.Parameters.Add(new OleDbParameter("@var5", joblegs[i].PickUpTime));

                            cmd.Parameters.Add(new OleDbParameter("@var6", joblegs[i].AppointmentTime));
                            cmd.Parameters.Add(new OleDbParameter("@var7", joblegs[i].JobSequenceID));
                            Log.WriteCommand(cmd);
                            cmd.ExecuteScalar();
                        }
                        //update job status to 8 if appt change
                        if (bApptChange && i==0) {
                            JobContact jobcontact = new JobContact();
                            jobcontact.JobID = _jobid;
                            jobcontact.LinkID = _clientid;
                            jobcontact.AttributeID = 49;
                            jobcontact.Note = "Appointment Time Changed - Driver needs to be informed";

                            string msg = jobcontact.AddJobContact();

                            if (msg != "Successfully updated job")
                            {
                                throw new Exception("Failed to update job status");
                            }
                        }
                    }
                }
            }
            catch (SystemException e)
            {
                return e.Message;
            }

            return "Successfully updated job";

        }
        public int SourceID {
            get { return _sourceid; }
            set { _sourceid = value;  }
        }
        public string Notes {
            get { return _notes; }
            set { _notes = value; }
        }
        public string ClientName
        {
            get { return _clientname; }
            set { _clientname = value; }
        }
        public string ClientSurname
        {
            get { return _clientsurname; }
            set { _clientsurname = value; }
        }
        public int ClientID
        {
            get { return _clientid; }
            set { _clientid = value; }
        }
        public string ClientAddressLine1
        {
            get { return _clientAddressLine1; }
            set { _clientAddressLine1 = value; }
        }
        public string ClientAddressLine2
        {
            get { return _clientAddressLine2; }
            set { _clientAddressLine2 = value; }
        }
        public string ClientTown
        {
            get { return _clientTown; }
            set { _clientTown = value; }
        }
        public string ClientPostCode
        {
            get { return _clientPostCode; }
            set { _clientPostCode = value; }
        }
        public string DriverName
        {
            get { return _driverFullName; }
            set { _driverFullName = value; }
        }
        public bool HasLinkedJob {
            get { return _hasLinkedJob; }
            set { _hasLinkedJob = value; }
        }
        public DateTime JobDate {
            get { return _jobdate; }
            set { _jobdate = value;  }
        }
        public DateTime PickUpTime
        {
            get { return _pickuptime; }
            set { _pickuptime = value; }
        }
        public int JobID {
            get { return _jobid; }
            set { _jobid = value;  }
        }
        public int LegCount {
            get { return _legcount; }
            set { _legcount = value;  }
        }
        public int LinkedJobID
        {
            get { return _linkedjobid; }
            set { _linkedjobid = value; }
        }
        public int LastAttributeID {
            get { return _lastattribute;  }
            set { _lastattribute = value;  }
        }
        public int StatusID
        {
            get { return _statusid; }
            set { _statusid = value; }
        }
        public int PriorityLevel
        {
            get { return _prioritylevel; }
            set { _prioritylevel = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string PendingStatus
        {
            get { return _pendingstatus; }
            set { _pendingstatus = value; }
        }
        public string LinkedMessage
        {
            get { return _linkedMessage; }
            set { _linkedMessage = value; }
        }
        public Boolean DVCWheelchair {
            get { return _DVCwheelchair; }
            set { _DVCwheelchair = value; }
        }

        public DateTime EnteredAt
        {
            get { return _enteredat; }
            set { _enteredat = value; }
        }

        public string EnteredBy
        {
            get { return _enteredby; }
            set { _enteredby = value; }

        }
    }

        

            

    }

