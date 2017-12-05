using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Configuration;
using System.Data;

namespace TransManager
{
    public class Driver
    {
        private int _id;
        private int _currentcarid;
        private int _daysessioncount;
        private string _title;
        private int _titleid;
        private string _firstname;
        private string _surname;
        private string _addressline1;
        private string _addressline2;
        private string _town;
        private string _postcode;
        private string _homephone;
        private string _mobilephone;
        private string _email;
        private string _licenceno;
        private DateTime _licenceexpiry;
        private DateTime _insuranceexpiry;
        private DateTime _dob;
        private bool _isactive;
        public Notes DriverNotes;
        private int _carmakeid;
        private bool _hascar=false;
        private bool _wheelchairenabled = false;
        private bool _walkerenabled = false;
        private bool _localdrives = false;
        private bool _isabsent = false;
        private bool _hasdeclined = false;
        private bool _isclientexcluded = false;
        private int _otherjob;

        public Dictionary<int, bool> Sessions = new Dictionary<int, bool>();
        

        public System.Collections.ObjectModel.Collection<Absence> Absences = new System.Collections.ObjectModel.Collection<Absence>();
        public System.Collections.ObjectModel.Collection<Attribute> Attributes = new System.Collections.ObjectModel.Collection<Attribute>();
        //public System.Collections.ObjectModel.Collection<Notes> DriverNotes = new System.Collections.ObjectModel.Collection<Notes>();


        public Cars cars = new Cars();
        public ClientExclusions exclusions = new ClientExclusions();

        public void LoadClientExclusions() {
            exclusions.LoadClientExclusions(_id);
        }



        public void LoadDriverAttributes()
        {

            Attributes.Clear();

            sqlConnection1 = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            using (sqlConnection1)
            {

                sqlConnection1.Open();

                OleDbCommand cmd = new OleDbCommand();

                OleDbDataReader dr;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "vwDriverAttributes";
                cmd.Parameters.Add(new OleDbParameter("[DriverID]", _id));
                
                cmd.Connection = sqlConnection1;
                Log.WriteCommand(cmd);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Attribute attribute = new Attribute();
                    attribute.AttributeID = dr.GetInt32(dr.GetOrdinal("AttributeID"));
                    attribute.Checked = dr.GetInt32(dr.GetOrdinal("Checked")) == 1 ? true : false;
                    attribute.Description = dr.GetValue(dr.GetOrdinal("Description")).ToString();
                    attribute.LinkAttributeID = dr.GetInt32(dr.GetOrdinal("DriverAttrID"));
                    attribute.AccessLevel = dr.GetInt32(dr.GetOrdinal("AccessLevel"));
                    attribute.LinkID = _id;
                    Attributes.Add(attribute);
                    if (attribute.Description.ToLower() == "wheelchair enabled") {
                        _wheelchairenabled = attribute.Checked;
                    }
                    if (attribute.Description.ToLower() == "walker enabled")
                    {
                        _walkerenabled = attribute.Checked;
                    }
                    if (attribute.Description.ToLower() == "Local drives")
                    {
                        _localdrives = attribute.Checked;
                    }
                }
            }

        }
        public void LoadDriverSessions() {
            LoadDriverSessions(_id);
        }
        public void LoadDriverSessions(int driverid) {

                
                    Sessions.Clear();
                    
                    _id = driverid;

                    sqlConnection1 = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

                    using (sqlConnection1)
                    {

                        sqlConnection1.Open();

                        OleDbCommand cmd = new OleDbCommand();

                        OleDbDataReader dr;

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "GetDriverSession";
                        cmd.Parameters.Add(new OleDbParameter("[Driver]", _id));
                        cmd.Connection = sqlConnection1;
                        Log.WriteCommand(cmd);
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            Sessions.Add(dr.GetInt32(dr.GetOrdinal("SessionID")), dr.GetInt32(dr.GetOrdinal("Active")) == 0 ? false : true);
                        }
                    }
                
            }
        
        OleDbConnection sqlConnection1 = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

        public Driver()
        {

        }

        public Driver(int DriverID, Boolean loadNotes)
        {
            
            sqlConnection1.Open();

            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM vwDriver WHERE [DriverID] = @var1";
            cmd.Parameters.Add(new OleDbParameter("@var1", DriverID));
            cmd.Connection = sqlConnection1;
            Log.WriteCommand(cmd);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                _id = dr.GetInt32(dr.GetOrdinal("DriverID"));
                _titleid = dr.GetInt32(dr.GetOrdinal("TitleID"));
                _title = dr.GetValue(dr.GetOrdinal("DriverTitle")).ToString();
                _firstname = dr.GetValue(dr.GetOrdinal("ForeName")).ToString();
                _surname = dr.GetValue(dr.GetOrdinal("Surname")).ToString();
                _addressline1 = dr.GetValue(dr.GetOrdinal("AddressLine1")).ToString();
                _addressline2 = dr.GetValue(dr.GetOrdinal("AddressLine2")).ToString();
                _town = dr.GetValue(dr.GetOrdinal("Town")).ToString();
                _postcode = dr.GetValue(dr.GetOrdinal("Postcode")).ToString();
                _mobilephone = dr.GetValue(dr.GetOrdinal("MobilePhone")).ToString();
                _homephone = dr.GetValue(dr.GetOrdinal("HomePhone")).ToString();
                _email = dr.GetValue(dr.GetOrdinal("EMail")).ToString();
                _dob = dr.GetDateTime(dr.GetOrdinal("DateOfBirth"));
                _licenceno = dr.GetValue(dr.GetOrdinal("LicenceNo")).ToString();
                _licenceexpiry = dr.GetDateTime(dr.GetOrdinal("LicenceExpiry"));
                try {
                    _insuranceexpiry = dr.GetDateTime(dr.GetOrdinal("InsuranceExpiry"));
                }
                catch
                {
                    //allow variable to remain null
                }
            }

            

            sqlConnection1.Close();

            if (loadNotes)
            {
                DriverNotes = new Notes(DriverID, Notes.NoteType.Driver);
                DriverNotes.LoadDriverNotes(DriverID);
            }

               
            
        }

        //public void LoadClientExclusions

        public void LoadAbsence(){
            

            sqlConnection1 = new OleDbConnection();

            sqlConnection1.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            using (sqlConnection1)
            {
                Absences.Clear();

                sqlConnection1.Open();

                OleDbCommand cmd = new OleDbCommand();
                OleDbDataReader dr;

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM DriverAbsence WHERE DriverID = @var1 ORDER BY DateFrom ASC";
                
                cmd.Parameters.Add(new OleDbParameter("@var1", _id));
                
                cmd.Connection = sqlConnection1;
                Log.WriteCommand(cmd);
                dr = cmd.ExecuteReader();

                while (dr.Read()) {
                    Absence abs = new Absence(dr.GetInt32(dr.GetOrdinal("DriverAbsenceID")), dr.GetDateTime(dr.GetOrdinal("DateFrom")), dr.GetDateTime(dr.GetOrdinal("DateTo")), dr.GetValue(dr.GetOrdinal("AbsenceReason")).ToString());

                    Absences.Add(abs);
                }

                sqlConnection1.Close();

            }
            
        }

        public bool Add()
        {
            sqlConnection1 = new OleDbConnection();

            sqlConnection1.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            using (sqlConnection1)
            {

                sqlConnection1.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Driver(TitleID, Forename, Surname, AddressLine1, AddressLine2, Town, PostCode, HomePhone, MobilePhone, Email, DateOfBirth, LicenceNo, LicenceExpiry, IsActive, EnteredBy) SELECT @var1 as var1, @var2  as var2, @var3 as var3, @var4 as var4, @var5 as var5, @var6  as var6, @var7 as var7, @var8 as var8, @var9 as var9, @var10 as var10, @var11 as var11, @var12 as var12, @var13 as var13, @var14 as var14, @var15 as var15";
                //cmd.CommandText = "INSERT INTO Driver(TitleID, Forename, Surname, AddressLine1, AddressLine2, Town, PostCode, HomePhone, MobilePhone, Email, LicenceNo, EnteredBy) SELECT @var1 as var1, @var2  as var2, @var3 as var3, @var4 as var4, @var5 as var5, @var6  as var6, @var7 as var7, @var8 as var8, @var9 as var9, @var10 as var10, @var12 as var12, @var14 as var14";

                cmd.Parameters.Add(new OleDbParameter("@var1", _titleid));
                cmd.Parameters.Add(new OleDbParameter("@var2", _firstname));
                cmd.Parameters.Add(new OleDbParameter("@var3", _surname));
                cmd.Parameters.Add(new OleDbParameter("@var4", _addressline1));
                cmd.Parameters.Add(new OleDbParameter("@var5", _addressline2));
                cmd.Parameters.Add(new OleDbParameter("@var6", _town));
                cmd.Parameters.Add(new OleDbParameter("@var7", _postcode.ToUpper()));
                cmd.Parameters.Add(new OleDbParameter("@var8", _homephone));
                cmd.Parameters.Add(new OleDbParameter("@var9", _mobilephone));
                cmd.Parameters.Add(new OleDbParameter("@var10", _email));
                cmd.Parameters.Add(new OleDbParameter("@var11", _dob));
                cmd.Parameters.Add(new OleDbParameter("@var12", _licenceno));
                cmd.Parameters.Add(new OleDbParameter("@var13", _licenceexpiry));
                cmd.Parameters.Add(new OleDbParameter("@var14", true));
                cmd.Parameters.Add(new OleDbParameter("@var15", User.CurrentUserName));
                
                cmd.Connection = sqlConnection1;
                Log.WriteCommand(cmd);
                cmd.ExecuteNonQuery();

                
                //get the newly created driver id
                cmd.CommandText = "select @@IDENTITY";
                _id = (int)cmd.ExecuteScalar();

                sqlConnection1.Close();

                Attribute att = new Attribute();
                att.LinkID = _id;
                att.AttributeID = 2;
                att.Checked = false;
                att.CheckedNew = true;
                att.Update(Attribute.AttributeType.driver);
                

            }
            return true;
        }

        public void LoadCars() 
        {
            cars.PopulateCars(_id);
            this.hasCar = cars.Count > 0;
        }

        public string AssignCar(int carid) {
            
            sqlConnection1 = new OleDbConnection();

            sqlConnection1.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            
            using (sqlConnection1)
            {

                sqlConnection1.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO DriverCar(DriverID, CarID) SELECT @var1, @var2";

                cmd.Parameters.Add(new OleDbParameter("@var1", _id));
                cmd.Parameters.Add(new OleDbParameter("@var2", carid));
                
                cmd.Connection = sqlConnection1;
                Log.WriteCommand(cmd);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OleDbException e)
                {
                    
                        if (e.Errors[0].SQLState == "3022")
                        {
                            return "Driver and Car are already linked!";

                        }
                        else { 
                            return e.Errors[0].Message;
                        }
            
                }
                    sqlConnection1.Close();
            }

            LoadCars();
            _currentcarid = carid;
            return "Successfully assigned car.";

 
        }

        public string UnassignCar(int carid)
        {

            sqlConnection1 = new OleDbConnection();

            sqlConnection1.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();


            using (sqlConnection1)
            {

                sqlConnection1.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE FROM DriverCar WHERE DriverID = @var1 AND CarID = @var2";

                cmd.Parameters.Add(new OleDbParameter("@var1", _id));
                cmd.Parameters.Add(new OleDbParameter("@var2", carid));

                cmd.Connection = sqlConnection1;
                Log.WriteCommand(cmd);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OleDbException e)
                {
                    return e.Errors[0].Message;
                }
                sqlConnection1.Close();
            }

            LoadCars();

            return "Successfully unassigned car.";


        }

        public bool Update()
        {

            sqlConnection1 = new OleDbConnection();

            sqlConnection1.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            using (sqlConnection1)
            {

                sqlConnection1.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE Driver SET [TitleID] = @var1, [ForeName] = @var2 ,[Surname] = @var3, [AddressLine1] = @var4, [AddressLine2] = @var5 , [Town] = @var6, [PostCode] = @var7, [HomePhone] = @var8, [MobilePhone] = @var9, [EMail] = @var10, [IsActive] = @var11, [DateOfBirth] = @var12, [LicenceNo] = @var13, [LicenceExpiry] = @var14, [EnteredBy] = @var15 WHERE [DriverID] = @var16";

                cmd.Parameters.Add(new OleDbParameter("@var1", _titleid));
                cmd.Parameters.Add(new OleDbParameter("@var2", _firstname));
                cmd.Parameters.Add(new OleDbParameter("@var3", _surname));
                cmd.Parameters.Add(new OleDbParameter("@var4", _addressline1));
                cmd.Parameters.Add(new OleDbParameter("@var5", _addressline2));
                cmd.Parameters.Add(new OleDbParameter("@var6", _town));
                cmd.Parameters.Add(new OleDbParameter("@var7", _postcode.ToUpper()));
                cmd.Parameters.Add(new OleDbParameter("@var8", _homephone));
                cmd.Parameters.Add(new OleDbParameter("@var9", _mobilephone));
                cmd.Parameters.Add(new OleDbParameter("@var10", _email));
                cmd.Parameters.Add(new OleDbParameter("@var11", _isactive));
                cmd.Parameters.Add(new OleDbParameter("@var12", _dob));
                cmd.Parameters.Add(new OleDbParameter("@var13", _licenceno));
                cmd.Parameters.Add(new OleDbParameter("@var14", _licenceexpiry));
                cmd.Parameters.Add(new OleDbParameter("@var15", User.CurrentUserName));
                cmd.Parameters.Add(new OleDbParameter("@var16", _id));

                cmd.Connection = sqlConnection1;
                Log.WriteCommand(cmd);
                cmd.ExecuteNonQuery();

                sqlConnection1.Close();
            }
            
            UpdateSessions();

            return true;

        }

        private void UpdateSessions() {
            sqlConnection1 = new OleDbConnection();

            sqlConnection1.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            using (sqlConnection1)
            {

                sqlConnection1.Open();
                
                string include = string.Empty;
                string exclude = string.Empty;

                foreach (KeyValuePair<int, bool> entry in Sessions) {
                    if (entry.Value)
                    {
                        include += entry.Key.ToString() + ",";
                    }
                    else {
                        exclude += entry.Key.ToString() + ",";
                    }
                }

                include = (include.Length == 0) ? include : include.Substring(0, include.Length - 1);
                exclude = (exclude.Length == 0) ? exclude : exclude.Substring(0, exclude.Length -1);

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                //Firstly remove any exclusions as they will be repopulated at the next step.
                cmd.CommandText = "DELETE FROM DriverSessionExclusion WHERE DriverID = @var1";

                cmd.Parameters.Add(new OleDbParameter("@var1", _id));
                cmd.Parameters.Add(new OleDbParameter("@var2", User.CurrentUserName));

                cmd.Connection = sqlConnection1;
                Log.WriteCommand(cmd);
                cmd.ExecuteNonQuery();

                //Now add the Excluded Sessions
                if(!(exclude==String.Empty)){
                    cmd.CommandText = "INSERT INTO DriverSessionExclusion(DriverID, SessionID, EnteredBy) SELECT @var1, Session.SessionId, @var2 FROM [Session] WHERE Session.SessionID IN(" + exclude + ");";
                    Log.WriteCommand(cmd);
                    cmd.ExecuteNonQuery();
                }

                sqlConnection1.Close();
            }
        }

        public int DriverID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public int TitleID
        {
            get { return _titleid; }
            set { _titleid = value; }
        }
        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public string FullName
        {
            get { return (_title==string.Empty ? string.Empty : _title + " ") + _firstname + " " + _surname; }
         
        }
        public string AddressLine1
        {
            get { return _addressline1; }
            set { _addressline1 = value; }
        }
        public string AddressLine2
        {
            get { return _addressline2; }
            set { _addressline2 = value; }
        }
        public string Town
        {
            get { return _town; }
            set { _town = value; }
        }
        public string Postcode
        {
            get { return _postcode; }
            set { _postcode = value; }
        }
        public string HomePhone
        {
            get { return _homephone; }
            set { _homephone = value; }
        }
        public string MobilePhone
        {
            get { return _mobilephone; }
            set { _mobilephone = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public DateTime DateOfBirth
        {
            get { return _dob; }
            set { _dob = value; }
        }
        
        public string LicenceNo
        {
            get { return _licenceno; }
            set { _licenceno = value; }
        }
        public DateTime LicenceExpiry
        {
            get { return _licenceexpiry; }
            set { _licenceexpiry = value; }
        }

        public DateTime InsuranceExpiry
        {
            get { return _insuranceexpiry; }
            set { _insuranceexpiry = value; }
        }

        public bool isActive
        {
            get { return _isactive; }
            set { _isactive = value; }
        }

        public bool hasCar
        {
            get { return _hascar; }
            set { _hascar = value; }
        }
        public bool IsWheelchairEnabled
        {
            get { return _wheelchairenabled; }
            set { _wheelchairenabled = value; }
        }
        public bool IsWalkerEnabled
        {
            get { return _walkerenabled; }
            set { _walkerenabled = value; }
        }

        public bool IsLocalDrivesOnly
        {
            get { return _localdrives; }
            set { _localdrives = value; }
        }

        public bool IsAbsent
        {
            get { return _isabsent; }
            set { _isabsent = value; }
        }

        public bool HasDeclined
        {
            get { return _hasdeclined; }
            set { _hasdeclined = value; }
        }

        public int OtherJob
        {
            get { return _otherjob; }
            set { _otherjob = value; }
        }

        public bool IsClientExcluded
        {
            get { return _isclientexcluded; }
            set { _isclientexcluded = value; }
        }

        public int CarMakeID {
            get { return _carmakeid; }
            set { _carmakeid = value; }
        }

        public int CurrentCarID
        {
            get { return _currentcarid; }
            set { _currentcarid = value; }
        }
        public int JobSessionCount
        {   get { return _daysessioncount;  }
            set { _daysessioncount = value; }
        }


    }
}