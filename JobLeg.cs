using System;
using System.Data.OleDb;
using System.Configuration;

namespace TransManager

{

    public class JobLeg

    {

        private int _jobid;
        private int _joblegid;
        private int _jobsequenceid;
        private int _driverid;
        private int _pickupdestinationid;
        private int _dropdestinationid;

        private string _driverName;

        private string      _pickupName;
        private string      _pickupAddressLine1;
        private string      _pickupAddressLine2;
        private string      _pickupTown;
        private string      _pickupPostCode;
        private DateTime    _pickupTime;

        private string      _dropName;
        private string      _dropAddressLine1;
        private string      _dropAddressLine2;
        private string      _dropTown;
        private string      _dropPostCode;
        private DateTime    _apptTime;
       
        public JobLeg()
        {

        }
        public int JobID
        {
            get { return _jobid; }
            set { _jobid = value; }
        }
        public int JobLegID
        {
            get { return _joblegid; }
            set { _joblegid = value; }
        }
        public int JobSequenceID
        {
            get { return _jobsequenceid; }
            set { _jobsequenceid = value; }

        }
        public int PickUpDestinationID
        {
            get { return _pickupdestinationid; }
            set { _pickupdestinationid = value; }
        }
        public int DropDestinationID
        {
            get { return _dropdestinationid; }
            set { _dropdestinationid = value; }
        }
        
        public int DriverID
        {
            get { return _driverid; }
            set { _driverid = value; }
        }
        public string DriverName
        {
            get { return _driverName; }
            set { _driverName = value; }
        }
        public string PickUpName
        {
            get { return _pickupName; }
            set { _pickupName = value; }
        }
        public string PickUpAddressLine1
        {
            get { return _pickupAddressLine1; }
            set { _pickupAddressLine1 = value; }
        }
        public string PickUpAddressLine2
        {
            get { return _pickupAddressLine2; }
            set { _pickupAddressLine2 = value; }
        }
        public string PickUpTown
        {
            get { return _pickupTown; }
            set { _pickupTown = value; }
        }
        public string PickUpPostCode
        {
            get { return _pickupPostCode; }
            set { _pickupPostCode = value; }
        }
        public DateTime PickUpTime
        {
            get { return _pickupTime; }
            set { _pickupTime = value; }
        }


        public string DropName
        {
            get { return _dropName; }
            set { _dropName = value; }
        }
        public string DropAddressLine1
        {
            get { return _dropAddressLine1; }
            set { _dropAddressLine1 = value; }
        }
        public string DropAddressLine2
        {
            get { return _dropAddressLine2; }
            set { _dropAddressLine2 = value; }
        }
        public string DropTown
        {
            get { return _dropTown; }
            set { _dropTown = value; }
        }
        public string DropPostCode
        {
            get { return _dropPostCode; }
            set { _dropPostCode = value; }
        }

        public DateTime AppointmentTime
        {
            get { return _apptTime; }
            set { _apptTime = value; }
        }



    }

}
