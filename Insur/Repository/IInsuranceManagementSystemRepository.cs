using Insur.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Insur.Repository
{
    internal interface IInsuranceManagementSystemRepository
    {
        public bool CreatePolicy(Policy policy);
        public Policy GetPolicy(int policyId);
        public List<Policy> GetAllPolicies();
        public bool UpdatePolicy(Policy policy);

        public bool DeletePolicy(int policyId);

        public List<Client> GetClientByPolicyName(string policyName);
    }
}
