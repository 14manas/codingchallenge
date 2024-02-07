using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Insur.Exceptions;
using Insur.model;
using Insur.Utility;
using static Insur.Exceptions.PolicyEXp;

namespace Insur.Repository
{
    internal class InsuranceManagmentSystemRepository : IInsuranceManagementSystemRepository
    {
        public string connectionString;
        SqlConnection sqlconnection = null;
        SqlCommand cmd = null;

        public InsuranceManagmentSystemRepository()
        {
            sqlconnection = new SqlConnection(DBConnectionUtil.GetConnectionString());
            cmd = new SqlCommand();
        }
        public Policy GetPolicy(int policyId)
        {
            try
            {
                sqlconnection.Open();
                cmd.CommandText = "select * from Policy where PolicyId= @policyId";
                cmd.Connection = sqlconnection;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@policyId", policyId);
                Policy policy = new Policy();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        policy.PolicyId = (int)reader["policyId"];
                        policy.PolicyName = (string)reader["policyName"];
                        sqlconnection.Close();
                        return policy;
                    }
                    else
                    {
                        sqlconnection.Close();

                        throw new PolicyNotFoundException("No Such Policy Found");

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public List<Policy> GetAllPolicies()
        {
            try
            {
                sqlconnection.Open();
                cmd.CommandText = "Select * from Policy";
                cmd.Connection = sqlconnection;
                cmd.Parameters.Clear();
                List<Policy> policies = new List<Policy>();
                SqlDataReader reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    Policy policy = new Policy();
                    policy.PolicyId = (int)reader["policyId"];
                    policy.PolicyName = (string)reader["policyName"];
                    policies.Add(policy);
                    count++;
                }
                sqlconnection.Close();
                if (count == 0)
                {
                    throw new PolicyNotFoundException("No  Policy Found");
                }
                return policies;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public bool UpdatePolicy(Policy policy)
        {
            try
            {
                sqlconnection.Open();
                cmd.CommandText = "Update Policy set policyName=@policyName where policyId=@policyId";
                cmd.Connection = sqlconnection;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@policyName", policy.PolicyName);
                cmd.Parameters.AddWithValue("@policyId", policy.PolicyId);
                int updatePolicyStatus = cmd.ExecuteNonQuery();
                sqlconnection.Close();
                if (updatePolicyStatus > 0) { return true; }
                else
                {
                    throw new PolicyNotFoundException("No Such Policy Found");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool DeletePolicy(int policyId)
        {
            try
            {
                sqlconnection.Open();
                cmd.CommandText = "delete from  Policy where policyId=@policyId";
                cmd.Connection = sqlconnection;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@policyId", policyId);
                int deletePolicyStatus = cmd.ExecuteNonQuery();
                sqlconnection.Close();
                if (deletePolicyStatus > 0) { return true; }
                else
                {
                    throw new PolicyNotFoundException("No Such Policy Found");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool CreatePolicy(Policy policy)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetClientByPolicyName(string policyName)
        {
            throw new NotImplementedException();
        }
    }
}
