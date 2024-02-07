using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insur.model
{
    internal class Policy
    {
        
            public int PolicyId { get; set; }
            public string PolicyName { get; set; }

            public Policy() { }
            public Policy(int policyId, string policyName)
            {
                PolicyId = policyId;
                PolicyName = policyName;
            }

            public void ShowDetails()
            {
                Console.WriteLine($"Policy Id:{PolicyId}\tPolicy Name{PolicyName}.\n\n");
            }
    }
}
