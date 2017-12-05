using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Data.OleDb;
using System.Configuration;


namespace TransManager
{
    public class Notes : Collection<Note>
    {

        OleDbConnection sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());
        private int _ownerID;
        private NoteType _notetype;

        public enum NoteType
        {
            Client = 1, Driver
        }

        public Notes(int ownerid, NoteType notetype)
        {
            _ownerID = ownerid;
            _notetype = notetype;
            LoadClientNotes(ownerid);
        }

        public bool AddNote(int ownerID, string noteText)
        {

            Note note = new Note(ownerID);
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            using (sqlConnection)
            {

                sqlConnection.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                if (_notetype == Notes.NoteType.Client)
                {
                    cmd.CommandText = "INSERT INTO ClientNotes(ClientID, [Note], EnteredBy) SELECT @var1, @var2, @var3";
                }
                else if (_notetype == Notes.NoteType.Driver)
                {
                    cmd.CommandText = "INSERT INTO DriverNotes(DriverID, [Note], EnteredBy) SELECT @var1, @var2, @var3";
                }

                cmd.Parameters.Add(new OleDbParameter("@var1", ownerID));
                cmd.Parameters.Add(new OleDbParameter("@var2", noteText));
                cmd.Parameters.Add(new OleDbParameter("@var3", (User.CurrentUserName == null ? "Unknown" : User.CurrentUserName)));
                cmd.Connection = sqlConnection;
                Log.WriteCommand(cmd);
                cmd.ExecuteScalar();
            }

            ReloadClientNotes();

            return true;
        }

        public bool UpdateNote(int noteID, string noteText)
        {
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();
            
            using (sqlConnection)
            {

                sqlConnection.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                if (_notetype == Notes.NoteType.Client)
                {
                    cmd.CommandText = "UPDATE ClientNotes SET [Note] = @var1 WHERE NoteID=@var2";
                }
                else if (_notetype == Notes.NoteType.Driver)
                {
                    cmd.CommandText = "UPDATE DriverNotes SET [Note] = @var1 WHERE NoteID=@var2";
                }
                cmd.Parameters.Add(new OleDbParameter("@var1", noteText));
                cmd.Parameters.Add(new OleDbParameter("@var2", noteID));
                cmd.Connection = sqlConnection;
                Log.WriteCommand(cmd);
                cmd.ExecuteScalar();

                
            }

            ReloadClientNotes();

            return true;
        }

        public string DeleteNote(int noteID)
        {
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            using (sqlConnection)
            {

                sqlConnection.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                if (_notetype == Notes.NoteType.Client)
                {
                    cmd.CommandText = "DELETE FROM ClientNotes WHERE NoteID=@var1";
                }
                else if (_notetype == Notes.NoteType.Driver)
                {
                    cmd.CommandText = "DELETE FROM DriverNotes WHERE NoteID=@var1";
                }
                
                cmd.Parameters.Add(new OleDbParameter("@var1", noteID));
                cmd.Connection = sqlConnection;
                Log.WriteCommand(cmd);
                try
                {
                    cmd.ExecuteScalar();
                }
                catch (OleDbException err) {
                    return err.Message;
                }


            }

            ReloadClientNotes();

            return "Successfully deleted note";
        }

        public void ReloadClientNotes() {
            LoadClientNotes(_ownerID);
        }

        public void LoadClientNotes(int clientid)
        {
            base.Clear();

            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();

            using(sqlConnection)
            {
                sqlConnection.Open();

                OleDbCommand cmd = new OleDbCommand();
                OleDbDataReader dr;
                cmd.CommandType = System.Data.CommandType.Text;
                if (_notetype == NoteType.Client)
                {
                    cmd.CommandText = "SELECT * FROM ClientNotes WHERE [ClientID] = @var1";
                }
                if (_notetype == NoteType.Driver)
                {
                    cmd.CommandText = "SELECT * FROM DriverNotes WHERE [DriverID] = @var1";
                }
                cmd.Parameters.Add(new OleDbParameter("@var1", clientid));
                cmd.Connection = sqlConnection;
                Log.WriteCommand(cmd);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Note note = new Note();
                    note.NoteID = dr.GetInt32(dr.GetOrdinal("NoteID"));
                    note.NoteText = dr.GetValue(dr.GetOrdinal("Note")).ToString();
                    note.EnteredAt = dr.GetDateTime(dr.GetOrdinal("EnteredAt"));
                    note.EnteredBy = dr.GetValue(dr.GetOrdinal("EnteredBy")).ToString();
                    if (_notetype == NoteType.Client)
                    {
                        note.OwnerID = dr.GetInt32(dr.GetOrdinal("ClientID"));
                    }
                    if (_notetype == NoteType.Driver)
                    {
                        note.OwnerID = dr.GetInt32(dr.GetOrdinal("DriverID"));

                    }
                    
                    base.Add(note);
                }

                sqlConnection.Close();

                
            }
            
            
        }

        public void LoadDriverNotes(int driverid)
        {
            base.Clear();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["TransManager"].ToString();
            using (sqlConnection)
                {
                    sqlConnection.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    OleDbDataReader dr;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "SELECT * FROM DriverNotes WHERE [DriverID] = @var1";
                    cmd.Parameters.Add(new OleDbParameter("@var1", driverid));
                    cmd.Connection = sqlConnection;
                    Log.WriteCommand(cmd);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Note note = new Note();
                        note.NoteID = dr.GetInt32(dr.GetOrdinal("NoteID"));
                        note.NoteText = dr.GetString(dr.GetOrdinal("Note"));
                        note.EnteredAt = dr.GetDateTime(dr.GetOrdinal("EnteredAt"));
                        note.EnteredBy = dr.GetString(dr.GetOrdinal("EnteredBy"));
                        base.Add(note);
                    }

                    sqlConnection.Close();
                }
                

        }
    }
}
