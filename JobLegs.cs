//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Collections.ObjectModel;
//using System.Data.OleDb;
//using System.Configuration;


//namespace TransManager
//{
//    public class JobLegs : Collection<JobLeg>
//    {

//        OleDbConnection sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());
//        private int _ownerID;
//        private JobLegType _JobLegtype;

//        public JobLegs(int ownerid, JobLegType JobLegtype)
//        {
//            _ownerID = ownerid;
//            _JobLegtype = JobLegtype;
//            LoadClientJobLegs(ownerid);
//        }

//        public bool AddJobLeg(int ownerID, string JobLegText)
//        {

//            JobLeg JobLeg = new JobLeg(ownerID);
//            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

//            using (sqlConnection)
//            {

//                sqlConnection.Open();

//                OleDbCommand cmd = new OleDbCommand();
//                cmd.CommandType = System.Data.CommandType.Text;
//                if (_JobLegtype == JobLegs.JobLegType.Client)
//                {
//                    cmd.CommandText = "INSERT INTO ClientJobLegs(ClientID, [JobLeg], EnteredBy) SELECT @var1, @var2, @var3";
//                }
//                else if (_JobLegtype == JobLegs.JobLegType.Driver)
//                {
//                    cmd.CommandText = "INSERT INTO DriverJobLegs(DriverID, [JobLeg], EnteredBy) SELECT @var1, @var2, @var3";
//                }

//                cmd.Parameters.Add(new OleDbParameter("@var1", ownerID));
//                cmd.Parameters.Add(new OleDbParameter("@var2", JobLegText));
//                cmd.Parameters.Add(new OleDbParameter("@var3", (Environment.UserName.ToString() == null ? "Unknown" : Environment.UserName.ToString())));
//                cmd.Connection = sqlConnection;

//                cmd.ExecuteScalar();
//            }

//            ReloadClientJobLegs();

//            return true;
//        }

//        public bool UpdateJobLeg(int JobLegID, string JobLegText)
//        {
//            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

//            using (sqlConnection)
//            {

//                sqlConnection.Open();

//                OleDbCommand cmd = new OleDbCommand();
//                cmd.CommandType = System.Data.CommandType.Text;
//                if (_JobLegtype == JobLegs.JobLegType.Client)
//                {
//                    cmd.CommandText = "UPDATE ClientJobLegs SET [JobLeg] = @var1 WHERE JobLegID=@var2";
//                }
//                else if (_JobLegtype == JobLegs.JobLegType.Driver)
//                {
//                    cmd.CommandText = "UPDATE DriverJobLegs SET [JobLeg] = @var1 WHERE JobLegID=@var2";
//                }
//                cmd.Parameters.Add(new OleDbParameter("@var1", JobLegText));
//                cmd.Parameters.Add(new OleDbParameter("@var2", JobLegID));
//                cmd.Connection = sqlConnection;

//                cmd.ExecuteScalar();


//            }

//            ReloadClientJobLegs();

//            return true;
//        }

//        public string DeleteJobLeg(int JobLegID)
//        {
//            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

//            using (sqlConnection)
//            {

//                sqlConnection.Open();

//                OleDbCommand cmd = new OleDbCommand();
//                cmd.CommandType = System.Data.CommandType.Text;
//                if (_JobLegtype == JobLegs.JobLegType.Client)
//                {
//                    cmd.CommandText = "DELETE FROM ClientJobLegs WHERE JobLegID=@var1";
//                }
//                else if (_JobLegtype == JobLegs.JobLegType.Driver)
//                {
//                    cmd.CommandText = "DELETE FROM DriverJobLegs WHERE JobLegID=@var1";
//                }

//                cmd.Parameters.Add(new OleDbParameter("@var1", JobLegID));
//                cmd.Connection = sqlConnection;

//                try
//                {
//                    cmd.ExecuteScalar();
//                }
//                catch (OleDbException err)
//                {
//                    return err.Message;
//                }


//            }

//            ReloadClientJobLegs();

//            return "Successfully deleted JobLeg";
//        }

//        public void ReloadClientJobLegs()
//        {
//            LoadClientJobLegs(_ownerID);
//        }

//        public void LoadClientJobLegs(int clientid)
//        {
//            base.Clear();

//            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

//            using (sqlConnection)
//            {
//                sqlConnection.Open();

//                OleDbCommand cmd = new OleDbCommand();
//                OleDbDataReader dr;
//                cmd.CommandType = System.Data.CommandType.Text;
//                if (_JobLegtype == JobLegType.Client)
//                {
//                    cmd.CommandText = "SELECT * FROM ClientJobLegs WHERE [ClientID] = @var1";
//                }
//                if (_JobLegtype == JobLegType.Driver)
//                {
//                    cmd.CommandText = "SELECT * FROM DriverJobLegs WHERE [DriverID] = @var1";
//                }
//                cmd.Parameters.Add(new OleDbParameter("@var1", clientid));
//                cmd.Connection = sqlConnection;

//                dr = cmd.ExecuteReader();

//                while (dr.Read())
//                {
//                    JobLeg JobLeg = new JobLeg();
//                    JobLeg.JobLegID = dr.GetInt32(dr.GetOrdinal("JobLegID"));
//                    JobLeg.JobLegText = dr.GetValue(dr.GetOrdinal("JobLeg")).ToString();
//                    JobLeg.EnteredAt = dr.GetDateTime(dr.GetOrdinal("EnteredAt"));
//                    JobLeg.EnteredBy = dr.GetValue(dr.GetOrdinal("EnteredBy")).ToString();
//                    if (_JobLegtype == JobLegType.Client)
//                    {
//                        JobLeg.OwnerID = dr.GetInt32(dr.GetOrdinal("ClientID"));
//                    }
//                    if (_JobLegtype == JobLegType.Driver)
//                    {
//                        JobLeg.OwnerID = dr.GetInt32(dr.GetOrdinal("DriverID"));

//                    }

//                    base.Add(JobLeg);
//                }

//                sqlConnection.Close();


//            }


//        }

//        public void LoadDriverJobLegs(int driverid)
//        {
//            base.Clear();
//            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();
//            using (sqlConnection)
//            {
//                sqlConnection.Open();

//                OleDbCommand cmd = new OleDbCommand();
//                OleDbDataReader dr;
//                cmd.CommandType = System.Data.CommandType.Text;
//                cmd.CommandText = "SELECT * FROM DriverJobLegs WHERE [DriverID] = @var1";
//                cmd.Parameters.Add(new OleDbParameter("@var1", driverid));
//                cmd.Connection = sqlConnection;

//                dr = cmd.ExecuteReader();

//                while (dr.Read())
//                {
//                    JobLeg JobLeg = new JobLeg();
//                    JobLeg.JobLegID = dr.GetInt32(dr.GetOrdinal("JobLegID"));
//                    JobLeg.JobLegText = dr.GetString(dr.GetOrdinal("JobLeg"));
//                    JobLeg.EnteredAt = dr.GetDateTime(dr.GetOrdinal("EnteredAt"));
//                    JobLeg.EnteredBy = dr.GetString(dr.GetOrdinal("EnteredBy"));
//                    base.Add(JobLeg);
//                }

//                sqlConnection.Close();
//            }


//        }
//    }
//}
