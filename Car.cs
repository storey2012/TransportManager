using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

namespace TransManager
{
    public class Car
    {
        private int _carid;
        private int _driverid;
        private string _regno;
        private string _make;
        private string _model;
        private string _type;
        private string _carcolour;
        private int _seats;
        private int _makeid;
        private int _typeid;
        
        private int _insid;
        private string _inspolicy;
        private string _inscompany;
        private string _inspolicyholder;
        private DateTime _insstartdate;
        private DateTime _insexpiry;
        private bool _hascar = false;
        private bool _iswheelchair = false;
        private OleDbConnection sqlConnection;

        public Car(int driverid) {
              
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr;
            
            sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            _driverid = driverid;
            
            sqlConnection.Open();

            using (sqlConnection)
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT TOP 1 * FROM vwCarDetails WHERE [DriverID] = @var1 ORDER BY RegNo ASC";
                cmd.Parameters.Add(new OleDbParameter("@var1", driverid));
                cmd.Connection = sqlConnection;
                Log.WriteCommand(cmd);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    _hascar = true;
                    _carid = dr.GetInt32(dr.GetOrdinal("CarID"));
                    _makeid = dr.GetInt32(dr.GetOrdinal("MakeID"));
                    _typeid = dr.GetInt32(dr.GetOrdinal("TypeID"));
                    _seats = dr.GetInt32(dr.GetOrdinal("Seats"));

                    _make = dr.GetString(dr.GetOrdinal("Make")).ToString();
                    _model = dr.GetValue(dr.GetOrdinal("Model")).ToString();
                    _type = dr.GetValue(dr.GetOrdinal("Type")).ToString();
                    _regno = dr.GetValue(dr.GetOrdinal("RegNo")).ToString();
                    _carcolour = dr.GetValue(dr.GetOrdinal("Colour")).ToString();


                    _insid = dr.GetInt32(dr.GetOrdinal("InsID"));
                    _inspolicy = dr.GetString(dr.GetOrdinal("PolicyNum")).ToString();
                    _inscompany = dr.GetString(dr.GetOrdinal("Comp")).ToString();
                    _inspolicyholder = dr.GetString(dr.GetOrdinal("PolHolder")).ToString();
                    _insstartdate = dr.GetDateTime(dr.GetOrdinal("sDate"));
                    _insexpiry = dr.GetDateTime(dr.GetOrdinal("Exp"));
                    _iswheelchair = dr.GetBoolean(dr.GetOrdinal("IsWheelchair"));
                }
            }
        }

        public Car() { 
        
        }

        public string Update(){
        
            sqlConnection = new OleDbConnection();

            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            using (sqlConnection)
            {

                sqlConnection.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE Car SET [RegNo] = @var1, [MakeID] = @var2 ,[Model] = @var3, [TypeID] = @var4, [Seats] = @var5, [isWheelchair] = @var6, [Colour] = @var7 WHERE [CarID] = @var8";

                cmd.Parameters.Add(new OleDbParameter("@var1", _regno.ToUpper()));
                cmd.Parameters.Add(new OleDbParameter("@var2", _makeid));
                cmd.Parameters.Add(new OleDbParameter("@var3", _model));
                cmd.Parameters.Add(new OleDbParameter("@var4", _typeid));
                cmd.Parameters.Add(new OleDbParameter("@var5", _seats));
                cmd.Parameters.Add(new OleDbParameter("@var6", _iswheelchair));
                cmd.Parameters.Add(new OleDbParameter("@var7", _carcolour));
                cmd.Parameters.Add(new OleDbParameter("@var8", _carid));

                cmd.Connection = sqlConnection;
                Log.WriteCommand(cmd);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OleDbException err) {
                    return "Failed to update car: " + err.Message;
                }

                //Update of Car Details that PREVIOUSLY didnt have any current insurance details.
                if (_insid == 0 && _inspolicy != string.Empty)
                {
                    //Now make an entry to the insurance table
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO Insurance(CarID, PolicyNo, Company, PolicyHolder, StartDate, ExpiryDate, EnteredBy) SELECT @var1 as var1, @var2  as var2, @var3 as var3, @var4 as var4, @var5 as var5, @var6  as var6, @var7 as var7";

                    cmd.Parameters.Add(new OleDbParameter("@var1", _carid));
                    cmd.Parameters.Add(new OleDbParameter("@var2", _inspolicy.ToUpper()));
                    cmd.Parameters.Add(new OleDbParameter("@var3", _inscompany));
                    cmd.Parameters.Add(new OleDbParameter("@var4", _inspolicyholder));
                    cmd.Parameters.Add(new OleDbParameter("@var5", _insstartdate));
                    cmd.Parameters.Add(new OleDbParameter("@var6", _insexpiry));
                    cmd.Parameters.Add(new OleDbParameter("@var7", User.CurrentUserName));
                    Log.WriteCommand(cmd);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "select @@IDENTITY";

                    
                    try
                    {
                        _insid = (int)cmd.ExecuteScalar();
                    }
                    catch (OleDbException err)
                    {
                        return "Failed to add insurance details: " + err.Message;
                    }

                    
                }
                else if(_insid>0){
                    //Here we know that there is an insurance policy already in force.
                    cmd.Parameters.Clear();
                    cmd.CommandText = "UPDATE Insurance SET PolicyNo = @var1, Company = @var2, PolicyHolder = @var3, StartDate = @var4, ExpiryDate = @var5 WHERE InsuranceID = @var6";

                    cmd.Parameters.Add(new OleDbParameter("@var1", _inspolicy.ToUpper()));
                    cmd.Parameters.Add(new OleDbParameter("@var3", _inscompany));
                    cmd.Parameters.Add(new OleDbParameter("@var2", _inspolicyholder));
                    cmd.Parameters.Add(new OleDbParameter("@var4", _insstartdate));
                    cmd.Parameters.Add(new OleDbParameter("@var5", _insexpiry));
                    cmd.Parameters.Add(new OleDbParameter("@var6", _insid));

                    Log.WriteCommand(cmd);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (OleDbException err)
                    {
                        return "Failed to update insurance details: " + err.Message;
                    }
                    

                    }

                        
            }

            return "Successfully updated details";
        }

        public string Add(int driverid)
        {
            int id = 0;
            _driverid = driverid;
            sqlConnection = new OleDbConnection();

            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            using (sqlConnection)
            {

                sqlConnection.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Car(RegNo, MakeID, Model, TypeID, Seats, isWheelchair, Colour, EnteredBy) SELECT @var1, @var2, @var3, @var4, @var5, @var6, @var7, @var8";

                cmd.Parameters.Add(new OleDbParameter("@var1", _regno.ToUpper()));
                cmd.Parameters.Add(new OleDbParameter("@var2", _makeid));
                cmd.Parameters.Add(new OleDbParameter("@var3", _model));
                cmd.Parameters.Add(new OleDbParameter("@var4", _typeid));
                cmd.Parameters.Add(new OleDbParameter("@var5", _seats));
                cmd.Parameters.Add(new OleDbParameter("@var6", _iswheelchair));
                cmd.Parameters.Add(new OleDbParameter("@var7", _carcolour));
                cmd.Parameters.Add(new OleDbParameter("@var8", User.CurrentUserName));
                Log.WriteCommand(cmd);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OleDbException e)
                {
                    if (e.Errors[0].SQLState == "3200")
                    {
                        return "This car registration is already in use.";
                    }
                    else
                    {
                        return e.Message;
                    }
                }


                cmd.CommandText = "select @@IDENTITY";
                
                id = (int)cmd.ExecuteScalar();
                _carid = id;

                if (id > 0 && _inspolicy != string.Empty) { 
                //Now make an entry to the insurance table
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO Insurance(CarID, PolicyNo, Company, PolicyHolder, StartDate, ExpiryDate, EnteredBy) SELECT @var1 as var1, @var2  as var2, @var3 as var3, @var4 as var4, @var5 as var5, @var6  as var6, @var7 as var7";

                    cmd.Parameters.Add(new OleDbParameter("@var1", _carid));
                    cmd.Parameters.Add(new OleDbParameter("@var2", _inspolicy.ToUpper()));
                    cmd.Parameters.Add(new OleDbParameter("@var3", _inspolicyholder));
                    cmd.Parameters.Add(new OleDbParameter("@var4", _inscompany));
                    cmd.Parameters.Add(new OleDbParameter("@var5", _insstartdate));
                    cmd.Parameters.Add(new OleDbParameter("@var6", _insexpiry));
                    cmd.Parameters.Add(new OleDbParameter("@var7", User.CurrentUserName));
                    Log.WriteCommand(cmd);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "select @@IDENTITY";

                    id = (int)cmd.ExecuteScalar();
                    _insid = id;
                    
                    //now the 3rd part to the process populating the DriverCar table.
                    
                }
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new OleDbParameter("@var1", _carid));
                cmd.Parameters.Add(new OleDbParameter("@var2", _driverid));
                cmd.Parameters.Add(new OleDbParameter("@var3", User.CurrentUserName));

                cmd.CommandText = "INSERT INTO DriverCar(CarID, DriverId, EnteredBy) SELECT @var1 as var1, @var2  as var2, @var3 as var3";
                Log.WriteCommand(cmd);
                cmd.ExecuteNonQuery();
                

            }
            _hascar = true;
            return "Car successfully added";
        }

        public bool HasCar {
            get { return _hascar;}
        }

        public bool IsWheelchair
        {
            get { return _iswheelchair; }
            set { _iswheelchair = value; }
        }

        public string RegNo {
            get { return _regno; }
            set { _regno = value; }
        }
        public int CarID
        {
            get { return _carid; }
            set { _carid = value; }
        }

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        public int MakeID
        {
            get { return _makeid; }
            set { _makeid = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string Colour
        {
            get { return _carcolour; }
            set { _carcolour = value; }
        }
        public int TypeID
        {
            get { return _typeid; }
            set { _typeid = value; }
        }
        public int Seats
        {
            get { return _seats; }
            set { _seats = value; }
        }
        public int InsuranceID
        {
            get { return _insid; }
            set { _insid = value;  }
        }
        public string InsurancePolicyNo
        {
            get { return _inspolicy; }
            set { _inspolicy = value; }
        }

        public string InsuranceCompany
        {
            get { return _inscompany; }
            set { _inscompany = value; }
        }
        public string InsurancePolicyHolder 
        {
            get { return _inspolicyholder; }
            set { _inspolicyholder = value; }
        }
        public DateTime InsuranceStart {
            get { return _insstartdate; }
            set { _insstartdate = value; }
        }
        public DateTime InsuranceExpire {
            get { return _insexpiry; }
            set { _insexpiry = value; }
        }

    }
}