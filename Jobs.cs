using System;
using System.Collections.ObjectModel;
using System.Data.OleDb;
using System.Configuration;


namespace TransManager
{
    public class Jobs : Collection<Job>
    {
        

        public Jobs(ContactView contactview) {
            PopulateJobs(contactview);
        }
        public Jobs(ContactView contactview, DateTime dt)
        {
            PopulateJobs(contactview, dt);
        }

        public enum ContactView{ Current , CurrentLinker, Cancelled, ExpiredNoDriver, All, NonCurrent }

        public void PopulateJobs(ContactView contactview) {
            PopulateJobs(contactview, new DateTime());
        }

        public void PopulateJobs(ContactView contactview, DateTime dt)
        {
            base.Clear();

            OleDbConnection sqlConnection1 = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            sqlConnection1.Open();

            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr;


            cmd.CommandType = System.Data.CommandType.Text;
            switch (contactview) {
                case ContactView.Cancelled:
                    cmd.CommandText = "Select * from vwJobsCancelled";
                    break;
                case ContactView.Current:
                    cmd.CommandText = "Select * from vwJobsCurrent";
                    break;
                case ContactView.CurrentLinker:
                    cmd.CommandText = "Select * from vwJobsCurrentLinker where LinkJobDate = @var1";
                    break;
                case ContactView.ExpiredNoDriver:
                    cmd.CommandText = "Select * from vwJobsExpiredNoDriver";
                    break;
                case ContactView.NonCurrent:
                    cmd.CommandText = "Select * from vwJobsNonCurrent";
                    break;
                case ContactView.All:
                    cmd.CommandText = "Select * from vwJobs";
                    break;
            
                
            }

            cmd.Connection = sqlConnection1;
            Log.WriteCommand(cmd);
            if(dt != null)
            {
                cmd.Parameters.Add(new OleDbParameter("@var1", dt));
            }


            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Job x = new Job();
                x.JobID = dr.GetInt32(dr.GetOrdinal("JobID"));
                x.ClientID = dr.GetInt32(dr.GetOrdinal("ClientID"));
                x.ClientName = dr.GetValue(dr.GetOrdinal("ClientName")).ToString();
                x.ClientSurname = dr.GetValue(dr.GetOrdinal("ClientSurname")).ToString();
                x.ClientAddressLine1 = dr.GetValue(dr.GetOrdinal("AddressLine1")).ToString();
                x.ClientAddressLine2 = dr.GetValue(dr.GetOrdinal("AddressLine2")).ToString();
                x.ClientTown = dr.GetValue(dr.GetOrdinal("Town")).ToString();
                x.ClientPostCode = dr.GetValue(dr.GetOrdinal("Postcode")).ToString();
                x.Notes = dr.GetValue(dr.GetOrdinal("Notes")).ToString();
                if (contactview == ContactView.CurrentLinker)
                {
                    x.JobDate = dr.GetDateTime(dr.GetOrdinal("JobDatep"));
                    x.PickUpTime = dr.GetDateTime(dr.GetOrdinal("JobAppointmentTime"));
                }
                else
                {
                    x.JobDate = dr.GetDateTime(dr.GetOrdinal("JobDate"));
                }
                x.PriorityLevel = dr.GetInt32(dr.GetOrdinal("PriorityLevel"));
                x.DVCWheelchair = dr.GetBoolean(dr.GetOrdinal("DVCWheelchairNeeded"));
                x.StatusID = dr.GetInt32(dr.GetOrdinal("StatusID"));
                x.Status = dr.GetValue(dr.GetOrdinal("Status")).ToString();
                x.PendingStatus = dr.GetValue(dr.GetOrdinal("PendingStatus")).ToString();
                x.DriverName = dr.GetValue(dr.GetOrdinal("DriverName")).ToString();
                x.LastAttributeID = dr.GetInt32(dr.GetOrdinal("AttributeID"));
                x.HasLinkedJob = Convert.ToBoolean(dr.GetInt32(dr.GetOrdinal("HasLinkedJob")));
                x.LinkedJobID = dr.GetInt32(dr.GetOrdinal("LinkedJobID"));
                
                base.Add(x);
            }
            sqlConnection1.Close();
        }

    }
}
