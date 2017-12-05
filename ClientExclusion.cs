using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Collections.ObjectModel;
using System.Configuration;


namespace TransManager
{
    public class ClientExclusion

    {
        private int _driverclientexclusionid;
        private int _driverid;
        private int _clientid;
        private string _reason;
        private string _clientname;
        private DateTime _enteredat;
        private string _enteredby;
        
        
        public ClientExclusion() {
        }

        
        public ClientExclusion(int driverclientexclusionid)
        {
            _driverclientexclusionid = driverclientexclusionid;
        
        }

        public int DriverClientExclusionID
        {
            get { return _driverclientexclusionid; }
            set { _driverclientexclusionid = value; }
        }

        public int ClientID
        {
            get { return _clientid; }
            set { _clientid = value; }
        }

        public int DriverID
        {
            get { return _driverid; }
            set { _driverid = value; }
        }

        public string Reason
        {
            get { return _reason; }
            set { _reason = value; }
        }

        public string ClientName
        {
            get { return _clientname; }
            set { _clientname = value; }
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
