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
    public class Cars : Collection<Car>
    {

        int _driverid;

        public Cars(int driverID)
        {
            _driverid = driverID;
            PopulateCars(_driverid);
        }

        public Cars() { }

        
        public void PopulateCars(int driverid)
        {
            base.Clear();

            OleDbConnection sqlConnection1 = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            sqlConnection1.Open();

            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr;


            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Select * from vwCarDetails WHERE DriverID = @var1 ORDER BY RegNo";
            cmd.Connection = sqlConnection1;
            cmd.Parameters.Add(new OleDbParameter("@var1", driverid));
            Log.WriteCommand(cmd);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Car x = new Car();
                
                x.CarID = dr.GetInt32(dr.GetOrdinal("CarID"));
                x.MakeID = dr.GetInt32(dr.GetOrdinal("MakeID"));
                x.Make = dr.GetValue(dr.GetOrdinal("Make")).ToString();
                x.TypeID = dr.GetInt32(dr.GetOrdinal("TypeID"));
                x.Type = dr.GetValue(dr.GetOrdinal("Type")).ToString();
                x.RegNo = dr.GetValue(dr.GetOrdinal("RegNo")).ToString();
                x.Model = dr.GetValue(dr.GetOrdinal("Model")).ToString();
                x.Colour = dr.GetValue(dr.GetOrdinal("Colour")).ToString();
                x.Seats = dr.GetInt32(dr.GetOrdinal("Seats"));
                x.InsuranceCompany = dr.GetValue(dr.GetOrdinal("Comp")).ToString();
                x.InsuranceID = dr.GetInt32(dr.GetOrdinal("InsID"));
                x.InsurancePolicyHolder = dr.GetValue(dr.GetOrdinal("PolHolder")).ToString();
                x.InsurancePolicyNo = dr.GetValue(dr.GetOrdinal("PolicyNum")).ToString();
                x.InsuranceStart = dr.GetDateTime(dr.GetOrdinal("sDate"));
                x.InsuranceExpire = dr.GetDateTime(dr.GetOrdinal("Exp"));
                x.IsWheelchair = dr.GetBoolean(dr.GetOrdinal("isWheelchair"));
                
                base.Add(x);
            }
            sqlConnection1.Close();
        }




    }
}