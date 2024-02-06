using static Insur.Service.InsuranceManagementSystemService;

namespace Insur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            IPolicyService policyService = new PolicyService();
            bool usercontinue = true;
            while (usercontinue)
            {
               
                Console.WriteLine("1.CreatePolicy");
                Console.WriteLine("2.GetPolicyById");
                Console.WriteLine("3.GetAllPolicies");
                Console.WriteLine("4.UpdatePolicy");
                Console.WriteLine("5.DeletePolicy");
              
                Console.WriteLine("Enter option");

                int userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:

                        policyService.CreatePolicy();
                        break;
                    case 2:
                        policyService.GetPolicyById();
                        break;
                    case 3:
                        policyService.GetAllPolicies();
                        break;
                    case 4:
                        policyService.UpdatePolicy();
                        break;
                    case 5:
                        policyService.DeletePolicy();
                        break;
                    
                    default:
                        Console.WriteLine("You selected Wrong Choice ");
                        break;
                }
            }
        }
    }
}
   

