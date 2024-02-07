using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insur.Exceptions;
using Insur.model;
using Insur.Repository;
using static Insur.Exceptions.PolicyEXp;

namespace Insur.Service
{
    internal class InsuranceManagementSystemService :IInsuranceManagementSystemService
    {
        readonly IInsuranceManagementSystemRepository _insuranceManagement;
        public InsuranceManagementSystemService()
        {
            _insuranceManagement = new InsuranceManagmentSystemRepository();
        }
        public void CreatePolicy()
        {
            Console.WriteLine("Enter Policy Id:");
            int policyId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Policy Name:");
            string policyName = Console.ReadLine();
            Policy policy = new Policy(policyId, policyName);
            bool addpolicystatus = _insuranceManagement.CreatePolicy(policy);
            if (addpolicystatus)
            {
                Console.WriteLine("Policy Added.");
            }
            else { Console.WriteLine("Couldn't Add Policy"); }


        }
        public void GetPolicy()
        {
            try
            {
                Console.WriteLine("Enter Policy Id :");
                int policyId = Convert.ToInt32(Console.ReadLine());

                Policy policy = _insuranceManagement.GetPolicy(policyId);
                if (policy != null)
                {
                    Console.WriteLine($"Policy Id:{policy.PolicyId}\tPolicy Name:{policy.PolicyName}");
                }
            }
            catch (PolicyNotFoundException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

        }
        public void GetAllPolicies()
        {
            try
            {
                List<Policy> policies = _insuranceManagement.GetAllPolicies();
                if (policies != null)
                {
                    Console.WriteLine("Getting Policies...\n");

                    foreach (Policy policy in policies)
                    {
                        Console.WriteLine($"Policy Id:{policy.PolicyId}\tPolicy Name:{policy.PolicyName}.\n");
                    }
                }
            }
            catch (PolicyNotFoundException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
        public void UpdatePolicy()
        {
            try
            {
                Console.WriteLine("Enter Id of Policy You want to update:");
                int policyId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter new Policy Name:");
                string policyName = Console.ReadLine();
                Policy policy = new Policy(policyId, policyName);
                bool updatePolicyStatus = _insuranceManagement.UpdatePolicy(policy);
                if (updatePolicyStatus)
                {
                    Console.WriteLine("Policy Updated.");
                }
            }
            catch (PolicyNotFoundException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

        }
        public void DeletePolicy()
        {
            try
            {
                Console.WriteLine("Enter Id of Policy You want to delete:");
                int policyId = Convert.ToInt32(Console.ReadLine());

                bool deletePolicyStatus = _insuranceManagement.DeletePolicy(policyId);
                if (deletePolicyStatus)
                {
                    Console.WriteLine("Policy Deleted.");
                }
            }
            catch (PolicyNotFoundException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
        public void GetClientsByPolicyName()
        {
            try
            {
                Console.WriteLine("Enter  Policy Name:");
                string policyName = Console.ReadLine();
                List<Client> clients = _insuranceManagement.GetClientByPolicyName(policyName);

                if (clients != null)
                {
                    Console.WriteLine($"Listing Clients with policyname {policyName}...\n");
                    foreach (Client client in clients)
                    {
                        Console.WriteLine($"Client Id:{client.ClientId}\nClient Name:{client.ClientName}\nContact Info:{client.ContactInfo}\n\n\n");
                    }
                }
            }
            catch (PolicyNotFoundException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

        }
    }
}
