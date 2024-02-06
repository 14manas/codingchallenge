using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insur.model
{
    internal class Payment
    {
        private int claimId;
        private string claimNumber;
        private DateTime dateFiled;
        private double claimAmount;
        private string status;
        private string policy;
        private int clientId;

        public int PaymentId
        {
            get { return PaymentId; }
            set { PaymentId = value; }
        }

        public DateTime PaymentDate
        {
            get { return PaymentDate; }
            set { PaymentDate = value; }
        }

        public double PaymentAmount
        {
            get { return PaymentAmount; }
            set { PaymentAmount = value; }
        }

        public Client Client
        {
            get { return Client; }
            set { Client = value; }
        }

    }
}
