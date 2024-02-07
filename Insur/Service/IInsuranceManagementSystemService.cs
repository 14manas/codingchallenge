using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insur.Service
{
    internal interface IInsuranceManagementSystemService
    {
        void CreatePolicy();
        void GetPolicy();
        void GetAllPolicies();
        void UpdatePolicy();
        void DeletePolicy();
        void GetClientsByPolicyName();
    }
}
