using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.OleDb;

namespace TransManager
{
    public class Utils
    {
        
        public Utils() {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr;

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Select * from Metadata";
            cmd.Connection = conn;

            Log.WriteCommand(cmd);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Sizer.xscale = (dr.GetInt32(dr.GetOrdinal("scaleWidth"))) / (float)100.0;
                Sizer.yscale = dr.GetInt32(dr.GetOrdinal("scaleHeight")) / (float)100.0;
                Sizer.fscale = dr.GetInt32(dr.GetOrdinal("scaleFont")) / (float)100.0;
            }
            
        }
        public bool SetScale(int x, int y, int fontscale) {
             
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Update Metadata set ScaleWidth=@var1, ScaleHeight=@var2, ScaleFont=@var3;";
            cmd.Connection = conn;

            cmd.Parameters.Add(new OleDbParameter("@var1", x));
            cmd.Parameters.Add(new OleDbParameter("@var2", y));
            cmd.Parameters.Add(new OleDbParameter("@var3", fontscale));
            Log.WriteCommand(cmd);
            cmd.ExecuteNonQuery();

            return true;
        }
    }
}
