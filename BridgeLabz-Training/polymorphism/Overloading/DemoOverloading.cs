using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.polymorphism.Overloading
{

    internal class Class1
    {
        public Class1()
        {
            Console.WriteLine("No parameters");
        }

        public Class1(string name)
        {
            Console.WriteLine("Hey " + name);
        }

        public Class1(int n, int m)
        {
            Console.WriteLine("Sum is " + (n + m));
        }
    }
    internal class DemoOverloading
    {
        static void Main(string[] args)
        {
            Class1 o1 = new Class1();             //constructor is called based on 
            Class1 o2 = new Class1("Adarsh");
            Class1 o3 = new Class1(3, 4);
        }
    }
}
