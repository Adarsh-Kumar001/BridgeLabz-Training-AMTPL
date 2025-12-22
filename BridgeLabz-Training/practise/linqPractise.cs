using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.practise
{

    internal class EmployeeDetails
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        public int Salary {  get; set; }

        public string Dept { get; set;}
    }
    internal class linqPractise
    {
        static void Main(string[] args)
        {
            List<EmployeeDetails> l = new List<EmployeeDetails>();

            EmployeeDetails emp1 = new EmployeeDetails();
            emp1.Name = "Adarsh";
            emp1.Dept = "IT";
            emp1.Age = 21;
            emp1.Salary = 20000;

            EmployeeDetails emp2 = new EmployeeDetails();
            emp1.Name = "A";
            emp1.Dept = "IT";
            emp1.Age = 20;
            emp1.Salary = 25000;

            EmployeeDetails emp3 = new EmployeeDetails();
            emp1.Name = "AK";
            emp1.Dept = "IT";
            emp1.Age = 20;
            emp1.Salary = 20000;

            l.Add(emp1);
            l.Add(emp2);
            l.Add(emp3);


            var avgSalary = l.Average(e => e.Salary);

            Console.WriteLine(avgSalary);

            var result = l.Where(e => e.Salary > avgSalary).ToList();

            foreach(var v in result)
            {
                Console.WriteLine(v); 
            }
        }
    }
}
