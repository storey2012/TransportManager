using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Data.OleDb;
using System.Configuration;


namespace TransManager
{
    public class ClientExclusions : Collection<ClientExclusion>
    {

        OleDbConnection sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());
        private int _driverid;



        public ClientExclusions(int driverid)
        {
            _driverid = driverid;
            LoadClientExclusions(driverid);
        }

        public ClientExclusions()
        {
        }

        public string AddExclusion(int driverid, int clientid, string reason)
        {

            ClientExclusion exclusion = new ClientExclusion(driverid);
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString(); ;

            using (sqlConnection)
            {

                sqlConnection.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO DriverClientExclusion(DriverID, ClientID, ExclusionReason, EnteredBy) SELECT @var1, @var2, @var3, @var4";

                cmd.Parameters.Add(new OleDbParameter("@var1", driverid));
                cmd.Parameters.Add(new OleDbParameter("@var2", clientid));
                cmd.Parameters.Add(new OleDbParameter("@var3", reason));
                cmd.Parameters.Add(new OleDbParameter("@var4", (User.CurrentUserName == null ? "Unknown" : User.CurrentUserName)));
                cmd.Connection = sqlConnection;
                Log.WriteCommand(cmd);
                try
                {
                    cmd.ExecuteScalar();
                }
                catch (OleDbException e) {
                    if (e.Errors[0].SQLState == "3022") {
                        return "This client is already excluded";
                    }
                    else{
                        return e.Message;
                    }
                }
            }

            ReloadClientExclusions();

            return "Successfully added exclusion";

        }

        public string RemoveExclusion(int driverexclusionid)
        {

            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString(); ;

            using (sqlConnection)
            {

                sqlConnection.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE FROM DriverClientExclusion WHERE DriverClientExclusionID = @var1";

                cmd.Parameters.Add(new OleDbParameter("@var1", driverexclusionid));
                
                cmd.Connection = sqlConnection;
                Log.WriteCommand(cmd);
                try
                {
                    cmd.ExecuteScalar();
                }
                catch (OleDbException e) {
                    return e.Message;
                }
            }

            ReloadClientExclusions();

            return "Successfully removed exclusion";
        }

        public bool UpdateExclusion(int clientexclusionid, string reason)
        {
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString(); ;

            using (sqlConnection)
            {

                sqlConnection.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE DriverClientExclusion SET Reason = @var1 WHERE DriverClientExclusionID=@var2";

                cmd.Parameters.Add(new OleDbParameter("@var1", reason));
                cmd.Parameters.Add(new OleDbParameter("@var2", clientexclusionid));
                cmd.Connection = sqlConnection;
                Log.WriteCommand(cmd);
                cmd.ExecuteScalar();


            }

            ReloadClientExclusions();

            return true;
        }

        public void ReloadClientExclusions()
        {
            LoadClientExclusions(_driverid);
        }

        public void LoadClientExclusions(int driverid)
        {
            base.Clear();

            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString(); ;

            using (sqlConnection)
            {
                sqlConnection.Open();

                OleDbCommand cmd = new OleDbCommand();
                OleDbDataReader dr;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM vwClientExclusions WHERE [DriverID] = @var1";
                cmd.Parameters.Add(new OleDbParameter("@var1", driverid));
                cmd.Connection = sqlConnection;
                Log.WriteCommand(cmd);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ClientExclusion exclusion = new ClientExclusion();
                    exclusion.DriverClientExclusionID = dr.GetInt32(dr.GetOrdinal("DriverClientExclusionID"));
                    exclusion.DriverID = driverid;
                    exclusion.ClientID = dr.GetInt32(dr.GetOrdinal("ClientID"));
                    exclusion.ClientName = dr.GetValue(dr.GetOrdinal("ClientName")).ToString();
                    exclusion.Reason = dr.GetValue(dr.GetOrdinal("Reason")).ToString();
                    exclusion.EnteredAt = dr.GetDateTime(dr.GetOrdinal("EnteredAt"));
                    exclusion.EnteredBy = dr.GetString(dr.GetOrdinal("EnteredBy"));

                    base.Add(exclusion);
                }

                sqlConnection.Close();


            }


        }

    }
}        

