using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Configuration;
using System.Windows.Forms;

namespace TransManager
{
    public class Combo
    {
        public enum ComboName
        {
            Attributes = 1, CarsAll, CarMake, CarType, Clients, Destination, DestinationCategory, DestinationType, Drivers, Hours, InsuranceExpiry, Jobs, JobStatus, LicenceExpiry, Minutes, Title, Users, UserAccess, Venue
        }
                
        private string _command;
        private DateTime _enteredat;

        public Combo() { }

        public OleDbDataReader GetCombo(ComboName combo, int ordercolumn)
        {
            OleDbConnection connCombo = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            connCombo.Open();
            _command = "Select * from " + GetTableName(combo);
            if (ordercolumn > 0)
            {
                _command+= " order by " + ordercolumn.ToString() + " ASC";
            }

            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr;
            
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = _command;
            cmd.Connection = connCombo;
            Log.WriteCommand(cmd);
            dr = cmd.ExecuteReader();

            return dr;
        }

        private class select
        {
            public string Text { get; set; }
            public int Value { get; set; }
        }

        private ComboBox Populatecbo(ComboBox cboBox, Combo.ComboName comboname, string headertext, int ordercolumn) {

            OleDbDataReader dr;

            dr = GetCombo(comboname, ordercolumn);

            List<select> sl = new List<select>();

            if (headertext != string.Empty) {
                sl.Add(new select() { Text = headertext, Value = -1});
            }

            while (dr.Read())
            {

                sl.Add(new select() { Text = dr.GetValue(1).ToString(), Value = dr.GetInt32(0) });

            }

            cboBox.DataSource = sl;
            cboBox.DisplayMember = "Text";
            cboBox.ValueMember = "Value";
            
            return cboBox;
        
    }

        public bool UpdateComboItem(Combo.ComboName comboname, int ID, string Description) {
            
            OleDbCommand cmd = new OleDbCommand();

            OleDbConnection connCombo = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());
            
            using (connCombo)
            {
                _enteredat = System.DateTime.Now;
                connCombo.Open();
                cmd.Connection = connCombo;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE " + GetTableName(comboname) + " SET [Description] = @var1, [EnteredAt] = @var2, [EnteredBy] = @var3 WHERE ID = @var4";
                //cmd.CommandText = "UPDATE " + GetTableName(comboname) + " SET [Description] = @var1, [EnteredBy] = @var3 WHERE ID = @var4";
                cmd.Parameters.Add(new OleDbParameter("@var1", Description));
                cmd.Parameters.Add(new OleDbParameter("@var2", System.DateTime.Now.Date));
                cmd.Parameters.Add(new OleDbParameter("@var3", (User.CurrentUserName == null ? "Unknown" : User.CurrentUserName)));
                cmd.Parameters.Add(new OleDbParameter("@var4", ID));
                Log.WriteCommand(cmd);
                cmd.ExecuteNonQuery();
                connCombo.Close();
            }
            return true;
        }

        public string RemoveItem(int itemid, Combo.ComboName comboname){
            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection connCombo = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            using (connCombo)
            {
                connCombo.Open();
                cmd.Connection = connCombo;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE FROM " + GetTableName(comboname) + " WHERE id = @var1";
                cmd.Parameters.Add(new OleDbParameter("@var1", itemid));
                Log.WriteCommand(cmd);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OleDbException e) {
                    if (e.Errors[0].SQLState == "3200")
                    {
                        return "This record cannot be deleted as there are related entries with this value.  Remove/reassign these records and then try again.";
                    }
                    else
                    {
                        return "Delete failed : " + e.Message;
                    }
                }
                connCombo.Close();
            }
            return "Item has been successfully deleted";
        }
        
        public string AddItemToCombo(Combo.ComboName comboname, string description)
        {
            return AddItemToCombo(comboname, description, string.Empty);
        }

        public string AddItemToCombo(Combo.ComboName comboname, string description, string additionalcolumn) {
            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection connCombo = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

            using (connCombo)
            {
                _enteredat = System.DateTime.Now;
                connCombo.Open();
                cmd.Connection = connCombo;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO " + GetTableName(comboname) + "(Description, EnteredBy) SELECT @var1, @var2";
                cmd.Parameters.Add(new OleDbParameter("@var1", description));
                cmd.Parameters.Add(new OleDbParameter("@var2", (User.CurrentUserName == null ? "Unknown" : User.CurrentUserName)));

                if (additionalcolumn != string.Empty){
                    cmd.Parameters.Add(new OleDbParameter("@var3", additionalcolumn));
                    cmd.CommandText.Replace(")", "," + additionalcolumn + ")");
                }


                Log.WriteCommand(cmd);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OleDbException err)
                {
                    return err.Message;
                }

                connCombo.Close();
            }
            return "Successfully added item";    
        }

        private string GetTableName(ComboName comboname)
        {
            string str="";

            switch (comboname) {
                case ComboName.Attributes:
                    str = "Attributes";
                    break;
                case ComboName.Title:
                    str = "Title";
                    break;
                case ComboName.CarsAll:
                    str = "comboCars";
                    break;
                case ComboName.CarMake:
                    str = "CarMake";
                    break;
                case ComboName.CarType:
                    str = "CarType";
                    break;
                case ComboName.Clients:
                    str = "comboClients";
                    break;
                case ComboName.Destination:
                    str = "comboDestination";
                    break;
                case ComboName.DestinationCategory:
                    str = "DestinationCategory";
                    break;
                case ComboName.DestinationType:
                    str = "DestinationType";
                    break;
                case ComboName.Drivers:
                    str = "comboDrivers";
                    break;
                case ComboName.Hours:
                    str = "comboHours";
                    break;
                case ComboName.InsuranceExpiry:
                    str = "comboInsuranceExpiry";
                    break;
                case ComboName.Jobs:
                    str = "comboJobs";
                    break;
                case ComboName.JobStatus:
                    str = "JobStatus";
                    break;
                case ComboName.LicenceExpiry:
                    str = "comboLicenceExpiry";
                    break;
                case ComboName.Minutes:
                    str = "comboMinutes";
                    break;
                case ComboName.UserAccess:
                    str = "UserAccessLevel";
                    break;
                case ComboName.Users:
                    str = "Users";
                    break;
                case ComboName.Venue:
                    str = "Venue";
                    break;
            }

            return str;
        }

        public ComboBox PopulateCombo(ComboBox cboBox, Combo.ComboName comboname)
        {
            Populatecbo(cboBox, comboname, string.Empty, 2);

            return cboBox;

        }

        public ComboBox PopulateCombo(ComboBox cboBox, Combo.ComboName comboname, bool AddHeaderRow)
        {

            Populatecbo(cboBox, comboname, AddHeaderRow ? "<Choose Item to Edit or Delete>" : string.Empty, 2);

            return cboBox;

        }

        public ComboBox PopulateCombo(ComboBox cboBox, Combo.ComboName comboname, string headerrow){
            
            Populatecbo(cboBox, comboname, headerrow, 0);

            return cboBox;

        }

        public ComboBox PopulateCombo(ComboBox cboBox, Combo.ComboName comboname, string headerrow, int ordercolumn)
        {

            Populatecbo(cboBox, comboname, headerrow, ordercolumn);

            return cboBox;

        }

    }
}