using System;
using System.Data.OleDb;
using System.Configuration;
using System.Data;
using System.Collections.ObjectModel;

namespace TransManager
{
    public class Client
    {
        private int _id;
        private string _title;
        private int _titleid;
        private string _firstname;
        private string _middlename;
        private string _surname;
        private string _addressline1;
        private string _addressline2;
        private string _town;
        private string _postcode;
        private string _homephone;
        private string _mobilephone;
        private string _email;
        private DateTime _dob;
        private bool _isactive;
        private bool _iswheelchair;

        public Notes ClientNotes;

        public Collection<Attribute> Attributes = new Collection<Attribute>();
        //public Collection<Donation> Donations = new Collection<Donation>();
        public Donations Donations;


        OleDbConnection sqlConnection1;

        public Client()
        {

        }
        public Client(int clientID, Boolean loadNotes)
        {
            LoadClient(clientID, loadNotes, false);
        }
        public Client(int clientID, Boolean loadNotes, Boolean loadDonations)
        {
            LoadClient(clientID, loadNotes, loadDonations);
        }

        private void LoadClient (int clientID, Boolean loadNotes, Boolean loadDonations)
        {
            sqlConnection1 = new OleDbConnection();
            sqlConnection1.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            ClientNotes = new Notes(clientID, Notes.NoteType.Client);

            using(sqlConnection1){
                sqlConnection1.Open();
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataReader dr;

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM vwClient WHERE [ClientID] = @var1";
                cmd.Parameters.Add(new OleDbParameter("@var1", clientID));
                cmd.Connection = sqlConnection1;
                Log.WriteCommand(cmd);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    _id = dr.GetInt32(dr.GetOrdinal("ClientID"));
                    _title = dr.GetValue(dr.GetOrdinal("Title")).ToString();
                    _titleid = dr.GetInt32(dr.GetOrdinal("TitleID"));
                    _firstname = dr.GetValue(dr.GetOrdinal("ForeName")).ToString();
                    _middlename = dr.GetValue(dr.GetOrdinal("MiddleName")).ToString();
                    _surname = dr.GetValue(dr.GetOrdinal("Surname")).ToString();
                    _addressline1 = dr.GetValue(dr.GetOrdinal("AddressLine1")).ToString();
                    _addressline2 = dr.GetValue(dr.GetOrdinal("AddressLine2")).ToString();
                    _town = dr.GetValue(dr.GetOrdinal("Town")).ToString();
                    _postcode = dr.GetValue(dr.GetOrdinal("Postcode")).ToString();
                    _mobilephone = dr.GetValue(dr.GetOrdinal("MobilePhone")).ToString();
                    _homephone = dr.GetValue(dr.GetOrdinal("HomePhone")).ToString();
                    _email = dr.GetValue(dr.GetOrdinal("EMail")).ToString();
                    _dob = dr.GetDateTime(dr.GetOrdinal("DateOfBirth"));
                    _iswheelchair = Convert.ToBoolean(dr.GetValue(dr.GetOrdinal("isWheelchair")));
                    _isactive = dr.GetBoolean(dr.GetOrdinal("isActive"));
                }

                sqlConnection1.Close();
            }

            if (loadNotes)
            {
                ClientNotes.LoadClientNotes(clientID);
            }
            if (loadDonations) {
                LoadDonations();
            }
        }

        public void LoadDonations() {
            Donations = new Donations(_id);
            
        }

        public void LoadAttributes()
        {
            Attributes.Clear();
            sqlConnection1 = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            using (sqlConnection1)
            {

                sqlConnection1.Open();

                OleDbCommand cmd = new OleDbCommand();

                OleDbDataReader dr;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "vwClientAttributes";
                cmd.Parameters.Add(new OleDbParameter("[ClientID]", _id));
                Log.WriteCommand(cmd);
                cmd.Connection = sqlConnection1;

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Attribute attribute = new Attribute();
                    attribute.AttributeID = dr.GetInt32(dr.GetOrdinal("AttributeID"));
                    attribute.Checked = dr.GetInt32(dr.GetOrdinal("Checked")) == 1 ? true : false;
                    attribute.Description = dr.GetValue(dr.GetOrdinal("Description")).ToString();
                    attribute.LinkAttributeID = dr.GetInt32(dr.GetOrdinal("ClientAttrID"));
                    attribute.LinkID = _id;
                    Attributes.Add(attribute);
                 }
            }

        }

        public void LoadNotes() {
            ClientNotes.LoadClientNotes(_id);
        }




        public string Add()
        {
            sqlConnection1 = new OleDbConnection();

            sqlConnection1.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();
            
            using(sqlConnection1){
            
                sqlConnection1.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Client(TitleID, Forename, Middlename, Surname, AddressLine1, AddressLine2, Town, PostCode, HomePhone, MobilePhone, Email, isWheelchair, DateOfBirth, EnteredBy) SELECT @var1 as var1, @var2  as var2, @var3 as var3, @var4 as var4, @var5 as var5, @var6  as var6, @var7 as var7, @var8 as var8, @var9 as var9, @var10 as var10, @var11 as var11, @var12 as var12, @var13 as var13, @var14 as var14";
                //cmd.CommandText = "INSERT INTO Client(TitleID, Forename, Middlename, Surname, AddressLine1, AddressLine2, Town, PostCode, HomePhone, MobilePhone, Email, isWheelchair, EnteredBy) SELECT @var1 as var1, @var2  as var2, @var3 as var3, @var4 as var4, @var5 as var5, @var6  as var6, @var7 as var7, @var8 as var8, @var9 as var9, @var10 as var10, @var11 as var11, @var12 as var12, @var14 as var14";

                cmd.Parameters.Add(new OleDbParameter("@var1", _titleid));
                cmd.Parameters.Add(new OleDbParameter("@var2", _firstname));
                cmd.Parameters.Add(new OleDbParameter("@var3", _middlename));
                cmd.Parameters.Add(new OleDbParameter("@var4", _surname));
                cmd.Parameters.Add(new OleDbParameter("@var5", _addressline1));
                cmd.Parameters.Add(new OleDbParameter("@var6", _addressline2));
                cmd.Parameters.Add(new OleDbParameter("@var7", _town));
                cmd.Parameters.Add(new OleDbParameter("@var8", _postcode.ToUpper()));
                cmd.Parameters.Add(new OleDbParameter("@var9", _homephone));
                cmd.Parameters.Add(new OleDbParameter("@var10", _mobilephone));
                cmd.Parameters.Add(new OleDbParameter("@var11", _email));
                cmd.Parameters.Add(new OleDbParameter("@var12", _iswheelchair));
                cmd.Parameters.Add(new OleDbParameter("@var13", _dob));
                cmd.Parameters.Add(new OleDbParameter("@var14", Environment.UserName));
                

                cmd.Connection = sqlConnection1;
                Log.WriteCommand(cmd);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select @@IDENTITY";

                try
                {
                    _id = (int)cmd.ExecuteScalar();
                }
                catch (OleDbException err)
                {
                    return "Failed to add client: " + err.Message;
                }

                sqlConnection1.Close();

            }

            return "Successfully added client";
        }







        public string Update()
        {
            sqlConnection1 = new OleDbConnection();

            sqlConnection1.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();
            
            using(sqlConnection1){

                sqlConnection1.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE Client SET [TitleID] = @var1, [ForeName] = @var2 ,[MiddleName] = @var3, [Surname] = @var4, [AddressLine1] = @var5, [AddressLine2] = @var6 , [Town] = @var7, [PostCode] = @var8, [HomePhone] = @var9, [MobilePhone] = @var10, [EMail] = @var11, [IsActive] = @var12, [IsWheelchair] = @var13, [DateOfBirth] = @var14  WHERE [ClientID] = @var15";

                cmd.Parameters.Add(new OleDbParameter("@var1", _titleid));
                cmd.Parameters.Add(new OleDbParameter("@var2", _firstname));
                cmd.Parameters.Add(new OleDbParameter("@var3", _middlename));
                cmd.Parameters.Add(new OleDbParameter("@var4", _surname));
                cmd.Parameters.Add(new OleDbParameter("@var5", _addressline1));
                cmd.Parameters.Add(new OleDbParameter("@var6", _addressline2));
                cmd.Parameters.Add(new OleDbParameter("@var7", _town));
                cmd.Parameters.Add(new OleDbParameter("@var8", _postcode.ToUpper()));
                cmd.Parameters.Add(new OleDbParameter("@var9", _homephone));
                cmd.Parameters.Add(new OleDbParameter("@var10", _mobilephone));
                cmd.Parameters.Add(new OleDbParameter("@var11", _email));
                cmd.Parameters.Add(new OleDbParameter("@var12", _isactive));
                cmd.Parameters.Add(new OleDbParameter("@var13", _iswheelchair));
                cmd.Parameters.Add(new OleDbParameter("@var14", _dob));
                cmd.Parameters.Add(new OleDbParameter("@var15", _id));

                cmd.Connection = sqlConnection1;
                Log.WriteCommand(cmd);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OleDbException e) {
                    return e.Message.ToString();
                }

                sqlConnection1.Close();

            }

            return "Successfully updated Client";

        }



        public int ClientID

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



        public string MiddleName

        {

            get { return _middlename; }

            set { _middlename = value; }

        }



        public string Surname

        {

            get { return _surname; }

            set { _surname = value; }

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



        public bool isWheelchair

        {

            get { return _iswheelchair; }

            set { _iswheelchair = value; }

        }



        public bool isActive

        {

            get { return _isactive; }

            set { _isactive = value; }

        }









    }

}
