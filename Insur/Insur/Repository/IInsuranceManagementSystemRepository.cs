using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insur.Repository
{
    internal interface IInsuranceManagementSystemRepository
    {
        bool CreatePolicy(string policy);
        bool GetPolicy(int policyId);
        ICollection<Policy> GetAllPolicies();
        bool UpdatePolicy(string policy);
        bool DeletePolicy(int policyId);
    }
}
