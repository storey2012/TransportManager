using System;

using System.Collections.Generic;

using System.Collections;

using System.Linq;

using System.Text;

using System.Data.OleDb;

using System.Configuration;





namespace TransManager

{

    public class Destination

    {

        private int _destinationid;
        private int _destinationtypeid;
        private string _name;
        private string _addressline1;
        private string _addressline2;
        private string _town;
        private string _postcode;
        

             
        OleDbConnection sqlConnection1;
        
        public Destination()
        {
            
        }
        public Destination(int destinationid)
        {
            _destinationid = destinationid;
            Load();
        }

        public void Load() { 
            sqlConnection1 = new OleDbConnection();
            OleDbDataReader dr;

            sqlConnection1.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            using (sqlConnection1)
            {

                sqlConnection1.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM Destination WHERE destinationID = @var1";

                cmd.Parameters.Add(new OleDbParameter("@var1", _destinationid));
                cmd.Connection = sqlConnection1;
                Log.WriteCommand(cmd);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    _destinationid = dr.GetInt32(dr.GetOrdinal("DestinationID"));
                    _destinationtypeid = dr.GetInt32(dr.GetOrdinal("DestinationTypeID"));
                    _name = dr.GetValue(dr.GetOrdinal("DestName")).ToString();
                    _addressline1 = dr.GetValue(dr.GetOrdinal("AddressLine1")).ToString();
                    _addressline2 = dr.GetValue(dr.GetOrdinal("AddressLine2")).ToString();
                    _town = dr.GetValue(dr.GetOrdinal("Town")).ToString();
                    _postcode = dr.GetValue(dr.GetOrdinal("PostCode")).ToString();
                }
            }  
        }

        public string Add()
        {
            sqlConnection1 = new OleDbConnection();

            sqlConnection1.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();
            
            using(sqlConnection1){
            
                sqlConnection1.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Destination(DestinationTypeID, DestName, AddressLine1, AddressLine2, Town, PostCode, EnteredBy) SELECT @var1, @var2, @var3, @var4, @var5, @var6, @var7";
        
                cmd.Parameters.Add(new OleDbParameter("@var1", _destinationtypeid));
                cmd.Parameters.Add(new OleDbParameter("@var2", _name));
                cmd.Parameters.Add(new OleDbParameter("@var3", _addressline1));
                cmd.Parameters.Add(new OleDbParameter("@var4", _addressline2));
                cmd.Parameters.Add(new OleDbParameter("@var5", _town));
                cmd.Parameters.Add(new OleDbParameter("@var6", _postcode.ToUpper()));
                cmd.Parameters.Add(new OleDbParameter("@var7", Environment.UserName));
                

                cmd.Connection = sqlConnection1;
                Log.WriteCommand(cmd);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OleDbException e) {
                    return e.Message;
                }

                sqlConnection1.Close();

            }

            return "Successfully added destination";
        }

        public string AddDestinationType()
        {
            sqlConnection1 = new OleDbConnection();

            sqlConnection1.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            using (sqlConnection1)
            {

                sqlConnection1.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO DestinationType(CategoryID, Description, EnteredBy) SELECT @var1, @var2, @var3";

                cmd.Parameters.Add(new OleDbParameter("@var1", _destinationtypeid));
                cmd.Parameters.Add(new OleDbParameter("@var2", _name));
                cmd.Parameters.Add(new OleDbParameter("@var3", Environment.UserName));

                cmd.Connection = sqlConnection1;
                Log.WriteCommand(cmd);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OleDbException e)
                {
                    return e.Message;
                }

                sqlConnection1.Close();

            }

            return "Successfully added destination type";
        }

        public string Update()
        {
            sqlConnection1 = new OleDbConnection();

            sqlConnection1.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString(); 
            
            using(sqlConnection1){

                sqlConnection1.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE Destination SET [DestinationTypeID] = @var1, [DestName] = @var2, [AddressLine1] = @var3, [AddressLine2] = @var4, [Town] = @var5, [PostCode] = @var6 WHERE [DestinationID] = @var7";

                cmd.Parameters.Add(new OleDbParameter("@var1", _destinationtypeid));
                cmd.Parameters.Add(new OleDbParameter("@var2", _name));
                cmd.Parameters.Add(new OleDbParameter("@var3", _addressline1));
                cmd.Parameters.Add(new OleDbParameter("@var4", _addressline2));
                cmd.Parameters.Add(new OleDbParameter("@var5", _town));
                cmd.Parameters.Add(new OleDbParameter("@var6", _postcode.ToUpper()));
                cmd.Parameters.Add(new OleDbParameter("@var7", _destinationid));
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

            return "Successfully updated destination";

        }

        public string Delete()
        {
            sqlConnection1 = new OleDbConnection();

            sqlConnection1.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            using (sqlConnection1)
            {

                sqlConnection1.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE FROM Destination WHERE [DestinationID] = @var1";

                cmd.Parameters.Add(new OleDbParameter("@var1", _destinationid));
                cmd.Connection = sqlConnection1;
                Log.WriteCommand(cmd);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OleDbException e)
                {
                    return e.Message.ToString();
                }

                sqlConnection1.Close();

            }

            return "Successfully deleted destination";

        }

        public int DestinationID

        {
            get { return _destinationid; }
            set { _destinationid = value; }
        }

        public int DestinationTypeID
        {
            get { return _destinationtypeid; }
            set { _destinationtypeid = value; }
        }


        public string Name

        {

            get { return _name; }

            set { _name = value; }

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

        
    }

}
