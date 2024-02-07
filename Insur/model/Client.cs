using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insur.model
{
    internal class Client
    {
        private int clientId;
        private string clientName;
        private string contactInfo;
        private string policy;
        private string policyName;

        public int ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }

        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }

        public string Policy
        {
            get { return policy; }
            set { policy = value; }
        }
        public string PolicyName
        {
            get { return policyName; }
            set { policyName = value; }
        }

    }
}
