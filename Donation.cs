using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransManager
{
    public class Donation
    {
        private int _id;
        private int _clientid;
        private string _reference;
        private decimal _amount;
        private DateTime _paymentdate;
        private DateTime _enteredat;
        private string _enteredby;

        public Donation() {

        }

        public int DonationID
        {
            get { return _id; }
            set { _id = value; }
        }
        public int ClientID
        {
            get { return _clientid; }
            set { _clientid = value; }
        }
        public string Reference
        {
            get { return _reference; }
            set { _reference = value; }
        }

        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public DateTime PaymentDate
        {
            get { return _paymentdate; }
            set { _paymentdate = value; }
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
