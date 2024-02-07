using Insur;
using Insur.Exceptions;
using Insur.model;
using Insur.Repository;
using Insur.Service;
IInsuranceManagementSystemService userService = new InsuranceManagementSystemService();
namespace InsuranceManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IInsuranceManagementSystemService service = new InsuranceManagementSystemService();
            while (true)
            {
                Console.WriteLine("Enter Your Choice:\n1.Create Policy\t2.Get Policy\t3.Get All Policies\t4.Update Policy\t5.Delete Policy\t6.Get Clients by PolicyName\n7.Exit\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        service.CreatePolicy();
                        break;
                    case 2:
                        service.GetPolicy();
                        break;
                    case 3:
                        service.GetAllPolicies();
                        break;
                    case 4:
                        service.UpdatePolicy();
                        break;
                    case 5:
                        service.DeletePolicy();
                        break;
                    case 6:
                        service.GetClientsByPolicyName();
                        break;
                    case 7:
                        return;
                        break;
                    default:
                        Console.WriteLine("Wrong Choice.Try Again...");
                        break;

                }
            }
        }
    }
}