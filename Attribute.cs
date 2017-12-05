using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Configuration;

namespace TransManager
{
    public class Attribute
    {
        private int _attributeid;
        private int _linkattributeid=0;
        private int _linkid;
        private int _accesslevel = 1;
        private string _description;
        private bool _checked;
        private bool _checkednew;
        private OleDbConnection sqlConnection;

        public enum AttributeType { driver=1, client=2}
        public enum ExpiryType { insurance, licence}

        public Attribute() { }

        private string GetAttributeName(AttributeType attributetype)
        {
            string str = "";

            switch (attributetype)
            {
                case AttributeType.client:
                    str = "Client";
                    break;
                case AttributeType.driver:
                    str = "Driver";
                    break;
                
            }

            return str;
        }

        public string Update(AttributeType type)
        {
            if (_checked != _checkednew)
            {
                sqlConnection = new OleDbConnection();

                sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();


                using (sqlConnection)
                {

                    sqlConnection.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = System.Data.CommandType.Text;

                    if (_linkattributeid == 0)
                    {

                        cmd.CommandText = "INSERT INTO " + GetAttributeName(type) + "Attribute(" + GetAttributeName(type) + "ID, AttributeID, EnteredBy) SELECT @var1, @var2, @var3";
                        cmd.Parameters.Add(new OleDbParameter("@var1", _linkid));
                        cmd.Parameters.Add(new OleDbParameter("@var2", _attributeid));
                        cmd.Parameters.Add(new OleDbParameter("@var3", Environment.UserName));
                    }
                    else
                    {
                        cmd.CommandText = "DELETE FROM  " + GetAttributeName(type) + "Attribute WHERE  " + GetAttributeName(type) + "AttributeID = @var1";
                        cmd.Parameters.Add(new OleDbParameter("@var1", _linkattributeid));
                    }

                    cmd.Connection = sqlConnection;
                    Log.WriteCommand(cmd);
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
            }

            return "Successfully updated attribute";
        }

        public int AccessLevel
        {
            get { return _accesslevel; }
            set { _accesslevel = value; }
        }
        public int AttributeID
        {
            get { return _attributeid; }
            set { _attributeid = value; }
        }
        public int LinkAttributeID
        {
            get { return _linkattributeid; }
            set { _linkattributeid = value; }
        }
        public int LinkID
        {
            get { return _linkid; }
            set { _linkid = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public Boolean Checked {
            get { return _checked; }
            set { _checked = value; }
        }
        public Boolean CheckedNew
        {
            get { return _checkednew; }
            set { _checkednew = value; }
        }
    }
        
}
