using System;
using System.Collections.ObjectModel;
using System.Data.OleDb;
using System.Configuration;

namespace TransManager
{
    public class Donations : Collection<Donation>
    {
        private int _clientID;
        OleDbConnection sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

        public Donations(int clientID) {
            _clientID = clientID;
            LoadDonations(_clientID);
        }
        public Donations() { }


        public string AddDonation(int clientID, DateTime paymentdate, decimal amount, string reference)
        {

            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();
            _clientID = clientID;
            using (sqlConnection)
            {
                try
                {
                    sqlConnection.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "INSERT INTO Donations(ClientID, Amount, PaymentDate, Reference, EnteredBy) SELECT @var1 as var1, @var2 as var2, @var3 as var3, @var4 as var4, @var5 as var5";
                    
                    cmd.Parameters.Add(new OleDbParameter("@var1", clientID));
                    cmd.Parameters.Add(new OleDbParameter("@var2", Convert.ToDouble(amount)));
                    cmd.Parameters.Add(new OleDbParameter("@var3", paymentdate.ToShortDateString()));
                    cmd.Parameters.Add(new OleDbParameter("@var4", reference));
                    cmd.Parameters.Add(new OleDbParameter("@var5", (User.CurrentUserName == null ? "Unknown" : User.CurrentUserName)));
                    cmd.Connection = sqlConnection;
                    Log.WriteCommand(cmd);
                    cmd.ExecuteNonQuery();
                }
                catch (System.Exception e)
                {
                    return "Donation not saved: " + e.Message.ToString();
                }
            }

            ReloadDonations();

            return "Successfully saved donation";
        }

        public string UpdateDonation(int donationID, DateTime paymentdate, decimal amount, string reference)
        {
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            using (sqlConnection)
            {
                try
                {
                    sqlConnection.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "UPDATE Donations SET Amount=@var1, PaymentDate=@var2, Reference=@var3 WHERE DonationID=@var4";

                    cmd.Parameters.Add(new OleDbParameter("@var1", amount));
                    cmd.Parameters.Add(new OleDbParameter("@var2", paymentdate));
                    cmd.Parameters.Add(new OleDbParameter("@var3", reference));
                    cmd.Parameters.Add(new OleDbParameter("@var4", donationID));
                    cmd.Connection = sqlConnection;
                    Log.WriteCommand(cmd);
                    cmd.ExecuteScalar();

                }
                catch (System.Exception e)
                {
                    return "Donation not saved: " + e.Message.ToString();
                }
            }

            ReloadDonations();

            return "Successfully updated donation";
        }


        public string DeleteDonation(int donationID)
        {
            try {
                sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

                using (sqlConnection)
                {

                    sqlConnection.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "DELETE FROM Donations WHERE DonationID=@var1";
                    
                    cmd.Parameters.Add(new OleDbParameter("@var1", donationID));
                    cmd.Connection = sqlConnection;

                    try
                    {
                        Log.WriteCommand(cmd);
                        cmd.ExecuteScalar();
                    }
                    catch (OleDbException err)
                    {
                        return "Donation not deleted: " + err.Message;
                    }


                }

                ReloadDonations();

                return "Successfully deleted donation";

            }
            catch(System.Exception e)
            {
                return "Donation not deleted: " + e.Message;
            }
        }

        public void ReloadDonations()
        {
            LoadDonations(_clientID);
        }

        public void LoadDonations(int clientid)
        {
            base.Clear();

            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            using (sqlConnection)
            {
                sqlConnection.Open();

                OleDbCommand cmd = new OleDbCommand();
                OleDbDataReader dr;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM Donations WHERE [ClientID] = @var1";
                
                cmd.Parameters.Add(new OleDbParameter("@var1", clientid));
                cmd.Connection = sqlConnection;
                Log.WriteCommand(cmd);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Donation donation = new Donation();
                    donation.DonationID = dr.GetInt32(dr.GetOrdinal("DonationID"));
                    donation.Amount = dr.GetDecimal(dr.GetOrdinal("Amount"));
                    donation.Reference = dr.GetValue(dr.GetOrdinal("Reference")).ToString();
                    donation.PaymentDate = dr.GetDateTime(dr.GetOrdinal("PaymentDate"));
                    donation.EnteredAt = dr.GetDateTime(dr.GetOrdinal("EnteredAt"));
                    donation.EnteredBy = dr.GetValue(dr.GetOrdinal("EnteredBy")).ToString();
                    donation.ClientID = dr.GetInt32(dr.GetOrdinal("ClientID"));
                
                    base.Add(donation);
                }

                sqlConnection.Close();


            }


        }

    }
}
