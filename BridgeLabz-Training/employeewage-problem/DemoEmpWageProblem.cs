using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.employeewage_problem
{
    internal class DemoEmpWageProblem
    {
        static void Main(string[] args)
        {
            Company c1 = new Company("CompanyXYZ", 5, 20, 100, true);
            Console.WriteLine($"The wage of employee in the company {c1.CompanyName} is : {c1.CalcWage()} per person");

        }
    }
}
