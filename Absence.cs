using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Configuration;

namespace TransManager
{
    public class Absence
    {
        private int _driverabsenceid;
        private DateTime _start;
        private DateTime _end;
        private string _reason;
        private OleDbConnection sqlConnection;


        public Absence() { }

        public Absence(int driverabsenceid, DateTime start, DateTime end, string reason)
        {
            _driverabsenceid = driverabsenceid;
            _start = start;
            _end = end;
            _reason = reason;
        }

        public string Update()
        {

            sqlConnection = new OleDbConnection();

            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();


            using (sqlConnection)
            {

                sqlConnection.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE DriverAbsence SET DateFrom = @var1, DateTo = @var2, AbsenceReason = @var3 WHERE DriverAbsenceID = @var4";

                cmd.Parameters.Add(new OleDbParameter("@var1", _start));
                cmd.Parameters.Add(new OleDbParameter("@var2", _end));
                cmd.Parameters.Add(new OleDbParameter("@var3", _reason));
                cmd.Parameters.Add(new OleDbParameter("@var4", _driverabsenceid));

                cmd.Connection = sqlConnection;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OleDbException e)
                {

                    return e.Errors[0].Message;
                    

                }
                sqlConnection.Close();
            }
            
            return "Successfully updated absence.";
        }

        public string Add(int driverid)
        {
            sqlConnection = new OleDbConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            using (sqlConnection)
            {

                sqlConnection.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO DriverAbsence(DriverID, DateFrom, DateTo, AbsenceReason, EnteredBy) SELECT @var1, @var2, @var3, @var4, @var5";

                cmd.Parameters.Add(new OleDbParameter("@var1", driverid));
                cmd.Parameters.Add(new OleDbParameter("@var2", _start));
                cmd.Parameters.Add(new OleDbParameter("@var3", _end));
                cmd.Parameters.Add(new OleDbParameter("@var4", _reason));
                cmd.Parameters.Add(new OleDbParameter("@var5", Environment.UserName));

                cmd.Connection = sqlConnection;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OleDbException e)
                {
                    return e.Errors[0].Message;
                }
                sqlConnection.Close();
            }

            return "Successfully entered absence.";
        }

        public string Delete()
        {

            sqlConnection = new OleDbConnection();

            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();


            using (sqlConnection)
            {

                sqlConnection.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE FROM DriverAbsence WHERE DriverAbsenceID = @var1";

                cmd.Parameters.Add(new OleDbParameter("@var1", _driverabsenceid));

                cmd.Connection = sqlConnection;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OleDbException e)
                {
                    return e.Errors[0].Message;
                }
                sqlConnection.Close();
            }

            return "Successfully deleted absence.";
        }

        public int DriverAbsenceID
        {
            get { return _driverabsenceid; }
            set { _driverabsenceid = value; }
        }
        public DateTime Start
        {
            get { return _start; }
            set { _start = value; }
        }

        public DateTime End
        {
            get { return _end; }
            set { _end = value; }
        }

        public string Reason
        {
            get { return _reason; }
            set { _reason = value; }
        }
    }
        
}
