using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insur.model
{
    internal class Claim
    {

        private int claimId;
        private string claimNumber;
        private DateTime dateFiled;
        private double claimAmount;
        private string status;
        private string policy;
        private Client client;
        public int ClaimId
        {
            get { return claimId; }
            set { claimId = value; }
        }

        public string ClaimNumber
        {
            get { return claimNumber; }
            set { claimNumber = value; }
        }

        public DateTime DateFiled
        {
            get { return dateFiled; }
            set { dateFiled = value; }
        }

        public double ClaimAmount
        {
            get { return claimAmount; }
            set { claimAmount = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Policy
        {
            get { return policy; }
            set { policy = value; }
        }

        public Client Client
        {
            get { return client; }
            set { client = value; }
        }


    }
}
