using System;
using System.Configuration;
using System.Data.OleDb;

namespace TransManager
{
    public class User
    {
        public int AccessLevel;
        public int UserID;
        public string AccessMessage;
        public string UserName;
        public string Password;
        public static string CurrentUserName;
        public static int CurrentAccessLevel;

        private static OleDbConnection sqlConnection;

        public User() { }

        public string Login(string username, string password)
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr;
            OleDbConnection sqlConnection;

            sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            sqlConnection.Open();

            using (sqlConnection)
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "qryLogin";
                cmd.Parameters.Add(new OleDbParameter("@uname", username));
                cmd.Parameters.Add(new OleDbParameter("@pwd", password));
                cmd.Connection = sqlConnection;
                Log.WriteCommand(cmd);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    AccessMessage = dr.GetValue(dr.GetOrdinal("Result")).ToString();
                    CurrentAccessLevel = dr.GetInt32(dr.GetOrdinal("AccessLevel"));
                    CurrentUserName = dr.GetValue(dr.GetOrdinal("UserName")).ToString();
                }

                return AccessMessage;
            }
        }

        public void LoadUser(int userid)
        {
            sqlConnection = new OleDbConnection();

            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            using (sqlConnection)
            {

                sqlConnection.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from Users where userid = @userid";

                cmd.Parameters.Add(new OleDbParameter("@userID", userid));

                cmd.Connection = sqlConnection;
                Log.WriteCommand(cmd);
                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    UserName = dr.GetValue(dr.GetOrdinal("Username")).ToString();
                    Password = dr.GetValue(dr.GetOrdinal("password")).ToString();
                    AccessLevel = dr.GetInt32(dr.GetOrdinal("accesslevel"));
                    UserID = userid;
                }
            }
        }

        public string Update(int userid, string username, string password, int accesslevel)
        {
            sqlConnection = new OleDbConnection();

            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            using (sqlConnection)
            {

                sqlConnection.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "qryUpdUser";

                cmd.Parameters.Add(new OleDbParameter("@username", username));
                cmd.Parameters.Add(new OleDbParameter("@password", password));
                cmd.Parameters.Add(new OleDbParameter("@accesslevel", accesslevel));
                cmd.Parameters.Add(new OleDbParameter("@userid", userid));

                cmd.Connection = sqlConnection;
                Log.WriteCommand(cmd);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OleDbException err)
                {
                    return "Failed to update user: " + err.Message;
                }

                sqlConnection.Close();

            }

            return "Successfully updated user";
        }

        public string Delete(int userid)
        {
            sqlConnection = new OleDbConnection();

            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            using (sqlConnection)
            {

                sqlConnection.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "qryDelUser";

                cmd.Parameters.Add(new OleDbParameter("@userid", userid));


                cmd.Connection = sqlConnection;
                Log.WriteCommand(cmd);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OleDbException err)
                {
                    return "Failed to delete user: " + err.Message;
                }

                sqlConnection.Close();

            }

            return "Successfully deleted user";
        }


        public string Add(string username, string password, int accesslevel)
        {
            sqlConnection = new OleDbConnection();

            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            using (sqlConnection)
            {

                sqlConnection.Open();

                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "qryInsUser";
                //cmd.CommandText = "INSERT INTO Client(TitleID, Forename, Middlename, Surname, AddressLine1, AddressLine2, Town, PostCode, HomePhone, MobilePhone, Email, isWheelchair, EnteredBy) SELECT @var1 as var1, @var2  as var2, @var3 as var3, @var4 as var4, @var5 as var5, @var6  as var6, @var7 as var7, @var8 as var8, @var9 as var9, @var10 as var10, @var11 as var11, @var12 as var12, @var14 as var14";

                cmd.Parameters.Add(new OleDbParameter("@username", username));
                cmd.Parameters.Add(new OleDbParameter("@password", password));
                cmd.Parameters.Add(new OleDbParameter("@accesslevel", accesslevel));

                cmd.Connection = sqlConnection;
                Log.WriteCommand(cmd);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OleDbException err)
                {
                    return "Failed to add user: " + err.Message;
                }

                sqlConnection.Close();

            }

            return "Successfully added user";
        }

    }
}
