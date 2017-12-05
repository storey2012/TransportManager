using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;
using System.Data.OleDb;
using System.Configuration;

namespace TransManager
{
    public class Clients : Collection<Client>
    {

        

        public Clients() {
            //pick up the 
            PopulateClients();
        }

        

        
        public void PopulateClients(){
            base.Clear();

            OleDbConnection sqlConnection1 = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            sqlConnection1.Open();
           
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr;


            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Select * from vwClient";
            cmd.Connection = sqlConnection1;
            Log.WriteCommand(cmd);
            dr = cmd.ExecuteReader();

            while (dr.Read()) {
                Client x = new Client();
                x.ClientID = dr.GetInt32(dr.GetOrdinal("ClientID"));
                x.Title = dr.GetValue(dr.GetOrdinal("Title")).ToString();
                x.TitleID = dr.GetInt32(dr.GetOrdinal("TitleID"));
                x.FirstName = dr.GetValue(dr.GetOrdinal("ForeName")).ToString();
                x.MiddleName = dr.GetValue(dr.GetOrdinal("MiddleName")).ToString();
                x.Surname = dr.GetValue(dr.GetOrdinal("Surname")).ToString();
                x.AddressLine1 = dr.GetValue(dr.GetOrdinal("AddressLine1")).ToString();
                x.AddressLine2 = dr.GetValue(dr.GetOrdinal("AddressLine2")).ToString();

                x.Town = dr.GetValue(dr.GetOrdinal("Town")).ToString();
                x.Postcode = dr.GetValue(dr.GetOrdinal("Postcode")).ToString();
                x.MobilePhone = dr.GetValue(dr.GetOrdinal("MobilePhone")).ToString();
                x.HomePhone = dr.GetValue(dr.GetOrdinal("HomePhone")).ToString();
                x.Email = dr.GetValue(dr.GetOrdinal("EMail")).ToString();
                x.DateOfBirth = dr.GetDateTime(dr.GetOrdinal("DateOfBirth"));
                x.isWheelchair = Convert.ToBoolean(dr.GetValue(dr.GetOrdinal("isWheelchair")));
                x.isActive = dr.GetBoolean(dr.GetOrdinal("isActive"));
                base.Add(x);
            }
            sqlConnection1.Close();
        }
        

        

        }
    }
