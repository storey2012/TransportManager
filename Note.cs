using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Collections.ObjectModel;
using System.Configuration;


namespace TransManager
{
    public class Note
    {
        private int _id;
        private int _itemid;
        private string _item;
        private DateTime _enteredat;
        private string _enteredby;
        
        
        //OleDbConnection sqlConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["TransManager"].ToString());

        public Note() {
        }

        
        public Note(int ownerid)
        {
            _id = ownerid;
        
        }

        
        

        public int OwnerID
        {
            get { return _id; }
            set { _id = value; }
        }

        public int NoteID
        {
            get { return _itemid; }
            set { _itemid = value; }
        }

        public string NoteText
        {
            get { return _item; }
            set { _item = value; }
        }

        public DateTime EnteredAt
        {
            get { return _enteredat; }
            set { _enteredat = value; }
        }

        public string EnteredBy
        {
            get { return _enteredby; }
            set { _enteredby = value; }
      
        }
        
    }
}
