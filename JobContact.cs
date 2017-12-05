using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;

namespace TransManager
{
    public class JobContact
    {
        private int _id;
        private int _jobid;
        private int _linkid;
        private int _attribid;
        private int _attriblevel;
        private string _note;
        private string _action;
        private string _linkname;
        private string _linktype;
        private string _enteredby;
        private string _PhoneUsed = "*";
        private DateTime _enteredat;


        public JobContact() { }

        public string AddJobContact() {

            try
            {
                OleDbConnection sqlConnection = new OleDbConnection();
                Int32 _jobattributeid;

                sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

                using (sqlConnection)
                {

                    sqlConnection.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = sqlConnection;

                    if (_attribid > 50 && _attribid < 57)
                    {
                        cmd.CommandText = "DELETE JobAttribute.JobID, JobAttribute.AttributeID " +
                            " FROM JobAttribute " +
                            " WHERE(((JobAttribute.JobID) = @var1" +
                            " ) AND((JobAttribute.AttributeID) Between 50 And 57))";

                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new OleDbParameter("@var1", _jobid));
                        cmd.Connection = sqlConnection;
                        Log.WriteLine("About to remove previous cancellations");
                        Log.WriteCommand(cmd);
                        cmd.ExecuteScalar();
                    }


                    //Reset if previously set to Complete/cancelled
                    cmd.CommandText = "UPDATE JobAttribute SET AttributeLevel = 0 WHERE JobAttribute.JobID = @var1 and AttributeLevel>18";
                    cmd.Parameters.Add(new OleDbParameter("@var1", _jobid));
                    Log.WriteCommand(cmd);
                    cmd.ExecuteScalar();

                    cmd.CommandText = "INSERT INTO JobAttribute(JobID, AttributeID, AttributeLevel, LinkID, Notes, PhoneUsed, EnteredBy) " + 
                        "SELECT @var1, @var2, [DefaultValue], @var3, @var4, @var5, @var6" +
                        " FROM Attributes " +
                        " WHERE Attributes.ID = @var2";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new OleDbParameter("@var1", _jobid));
                    cmd.Parameters.Add(new OleDbParameter("@var2", _attribid));
                    cmd.Parameters.Add(new OleDbParameter("@var3", _linkid));
                    cmd.Parameters.Add(new OleDbParameter("@var4", _note));
                    cmd.Parameters.Add(new OleDbParameter("@var5", _PhoneUsed));
                    cmd.Parameters.Add(new OleDbParameter("@var6", (User.CurrentUserName == null ? "Unknown" : User.CurrentUserName)));

                    Log.WriteCommand(cmd);
                    cmd.ExecuteScalar();

                    //cmd.CommandText = "select @@IDENTITY";
                    //cmd.Parameters.Clear();
                    //_jobattributeid = (int)cmd.ExecuteScalar();



                    //Update Job for Driver Acceptance
                    if (_attribid == 21  || _attribid==20) {
                        cmd.CommandText = "UPDATE JobLegs SET DriverID=@var1 " +
                            "WHERE JobID = @var2";
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new OleDbParameter("@var1", _attribid==20 ? -1 : _linkid));
                        cmd.Parameters.Add(new OleDbParameter("@var2", _jobid));
                        cmd.Connection = sqlConnection;
                        Log.WriteCommand(cmd);
                        cmd.ExecuteScalar();
                     }

                    //Reset Attributes if it is a Driver Cancellation
                    if (_attribid == 20)
                    {
                        cmd.CommandText = "UPDATE JobAttribute SET AttributeLevel=0 " +
                            "WHERE JobID = @var1";
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new OleDbParameter("@var1", _jobid));
                        cmd.Connection = sqlConnection;
                        Log.WriteCommand(cmd);
                        cmd.ExecuteScalar();
                    }

                    //Reset Attributes LEvel 9 (appt time change) to level 5 if it is a Driver Acceptance
                    if (_attribid == 21)
                    {
                        cmd.CommandText = "UPDATE JobAttribute SET AttributeLevel=5 " +
                            "WHERE JobID = @var1 AND AttributeLevel = 8";
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new OleDbParameter("@var1", _jobid));
                        cmd.Connection = sqlConnection;
                        Log.WriteCommand(cmd);
                        cmd.ExecuteScalar();
                    }

                    //Client Cancels Job - promote to completely cancelled if NO Driver
                    if (_attribid == 27 || _attribid == 28 || _attribid == 29 || _attribid == 30)
                    {
                        cmd.CommandText = "UPDATE JobAttribute " +
                            " INNER JOIN JobLegs " +
                            " ON JobLegs.JobID = JobAttribute.JobID " +
                            " SET JobAttribute.AttributeLevel = 19 " +
                            " WHERE JobAttribute.AttributeLevel = 6 " +
                            " AND JobAttribute.JobID = @var1" +
                            " AND JobLegs.DriverID = -1 ";
                    
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new OleDbParameter("@var1", _jobid));
                        cmd.Connection = sqlConnection;
                        Log.WriteCommand(cmd);
                        cmd.ExecuteScalar();
                    }

                    
                    if (_attribid == 27 || _attribid == 28 || _attribid == 29 || _attribid == 30 || _attribid == 31)
                    {
                        cmd.CommandText = "UPDATE Jobs " +
                            " SET Notes = [Notes] & ' - Cancellation notes: " + _note +
                            "' WHERE JobID = @var1";

                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new OleDbParameter("@var1", _jobid));
                        cmd.Connection = sqlConnection;
                        Log.WriteCommand(cmd);
                        cmd.ExecuteScalar();
                    }

                }
            }
            catch (SystemException e)
            {
                return e.Message;
            }

            return "Successfully updated job";
        }


        public int ContactID
        {
            get { return _id; }
            set { _id = value; }
        }

        public int JobID
        {
            get { return _jobid; }
            set { _jobid = value; }
        }

        public int AttributeID
        {
            get { return _attribid; }
            set { _attribid = value; }
        }
        public int AttributeLevel
        {
            get { return _attriblevel; }
            set { _attriblevel = value; }
        }

        public int LinkID
        {
            get { return _linkid; }
            set { _linkid = value; }
        }
        
        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }
        public string LinkName
        {
            get { return _linkname; }
            set { _linkname = value; }
        }
        public string LinkType
        {
            get { return _linktype; }
            set { _linktype = value; }
        }
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }
        public string PhoneUsed
        {
            get { return _PhoneUsed; }
            set { _PhoneUsed = value; }
        }
        public string EnteredBy
        {
            get { return _enteredby; }
            set { _enteredby = value; }
        }
        public DateTime EnteredAt
        {
            get { return _enteredat; }
            set { _enteredat = value; }
        }
    }
}
