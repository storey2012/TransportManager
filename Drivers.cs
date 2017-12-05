using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using System.Data.OleDb;
using System.Configuration;

namespace TransManager
{
    public class Drivers : Collection<Driver>
    {
        

        public Drivers(string connection)
        {
            PopulateDrivers(connection);
        }

        public Drivers()
        {
            //pick up the 
        }

        public void PopulateDrivers(string connectionString)
        {
            base.Clear();

            OleDbConnection sqlConnection1 = new OleDbConnection(connectionString);

            sqlConnection1.Open();

            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr;


            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Select * from vwDriver";
            cmd.Connection = sqlConnection1;
            Log.WriteCommand(cmd);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Driver x = new Driver();
                x.DriverID = dr.GetInt32(dr.GetOrdinal("DriverID"));
                x.Title = dr.GetValue(dr.GetOrdinal("DriverTitle")).ToString();
                x.TitleID = dr.GetInt32(dr.GetOrdinal("TitleID"));
                x.FirstName = dr.GetValue(dr.GetOrdinal("ForeName")).ToString();
                
                x.Surname = dr.GetValue(dr.GetOrdinal("Surname")).ToString();
                x.AddressLine1 = dr.GetValue(dr.GetOrdinal("AddressLine1")).ToString();
                x.AddressLine2 = dr.GetValue(dr.GetOrdinal("AddressLine2")).ToString();

                x.Town = dr.GetValue(dr.GetOrdinal("Town")).ToString();
                x.Postcode = dr.GetValue(dr.GetOrdinal("Postcode")).ToString();
                x.MobilePhone = dr.GetValue(dr.GetOrdinal("MobilePhone")).ToString();
                x.HomePhone = dr.GetValue(dr.GetOrdinal("HomePhone")).ToString();
                x.Email = dr.GetValue(dr.GetOrdinal("EMail")).ToString();
                x.DateOfBirth = dr.GetDateTime(dr.GetOrdinal("DateOfBirth"));
                x.LicenceNo = dr.GetValue(dr.GetOrdinal("LicenceNo")).ToString();
                x.LicenceExpiry = dr.GetDateTime(dr.GetOrdinal("LicenceExpiry"));
                try
                {
                    x.InsuranceExpiry = dr.GetDateTime(dr.GetOrdinal("InsuranceExpiry"));
                }
                catch {
                    //dont throw error - allow variable to remain null
                }

                x.isActive = dr.GetBoolean(dr.GetOrdinal("isActive"));
                x.IsWalkerEnabled = dr.GetInt32(dr.GetOrdinal("WalkerEnabled")) == 0 ? false : true;
                x.IsWheelchairEnabled = dr.GetInt32(dr.GetOrdinal("WheelchairEnabled")) == 0 ? false : true;

                base.Add(x);
            }
            sqlConnection1.Close();
        }

        public void PopulateDriversForJobs(int jobid)
        {
            base.Clear();

            OleDbConnection sqlConnection1 = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            sqlConnection1.Open();

            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr;


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "vwDriverJob";
            cmd.Parameters.Add(new OleDbParameter("[JobID]", jobid));
            cmd.Connection = sqlConnection1;
            Log.WriteCommand(cmd);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Driver x = new Driver();
                x.DriverID = dr.GetInt32(dr.GetOrdinal("DriverID"));
                x.Title = dr.GetValue(dr.GetOrdinal("Title")).ToString();
                x.TitleID = dr.GetInt32(dr.GetOrdinal("TitleID"));
                x.FirstName = dr.GetValue(dr.GetOrdinal("ForeName")).ToString();

                x.Surname = dr.GetValue(dr.GetOrdinal("Surname")).ToString();
                x.AddressLine1 = dr.GetValue(dr.GetOrdinal("AddressLine1")).ToString();
                x.AddressLine2 = dr.GetValue(dr.GetOrdinal("AddressLine2")).ToString();

                x.Town = dr.GetValue(dr.GetOrdinal("Town")).ToString();
                x.Postcode = dr.GetValue(dr.GetOrdinal("Postcode")).ToString();
                x.MobilePhone = dr.GetValue(dr.GetOrdinal("MobilePhone")).ToString();
                x.HomePhone = dr.GetValue(dr.GetOrdinal("HomePhone")).ToString();
                x.Email = dr.GetValue(dr.GetOrdinal("EMail")).ToString();
                x.DateOfBirth = dr.GetDateTime(dr.GetOrdinal("DateOfBirth"));
                x.LicenceNo = dr.GetValue(dr.GetOrdinal("LicenceNo")).ToString();
                x.LicenceExpiry = dr.GetDateTime(dr.GetOrdinal("LicenceExpiry"));

                x.isActive = dr.GetBoolean(dr.GetOrdinal("isActive"));
                x.IsWalkerEnabled = dr.GetInt32(dr.GetOrdinal("WalkerEnabled")) == 0 ? false : true;
                x.IsWheelchairEnabled = dr.GetInt32(dr.GetOrdinal("WheelchairEnabled")) == 0 ? false : true;
                x.IsLocalDrivesOnly = dr.GetInt32(dr.GetOrdinal("LocalDrivesOnly")) == 0 ? false : true;
                x.IsAbsent = dr.GetInt32(dr.GetOrdinal("IsAbsent")) == 0 ? false : true;
                x.HasDeclined = dr.GetInt32(dr.GetOrdinal("HasDeclined")) == 0 ? false : true;
                x.IsClientExcluded = dr.GetInt32(dr.GetOrdinal("IsClientExcluded")) == 0 ? false : true;
                x.OtherJob = dr.GetInt32(dr.GetOrdinal("HasJob"));
                x.InsuranceExpiry = dr.GetDateTime(dr.GetOrdinal("InsuranceExpiry"));

                x.JobSessionCount = dr.GetInt32(dr.GetOrdinal("SUCount"));

                base.Add(x);
            }
            sqlConnection1.Close();
        }

    }
}
