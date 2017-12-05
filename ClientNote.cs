using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransManager
{
    public class ClientNote
    {
        private string _note;
        private int _id;
        private string _enteredby;

        public ClientNote() { }
        public ClientNote(int clientid, string note)
        {

            _id = clientid;
            _note = note;
        }

        public int ClientID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }

        public string EnteredBy {
            get { return _enteredby; }
            set { _enteredby = value; }
        }
    }
}
