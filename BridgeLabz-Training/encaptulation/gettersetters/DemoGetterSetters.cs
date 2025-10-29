using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.encaptulation.gettersetters
{
    internal class DemoGetterSetters
    {
        static void Main(string[] args)
        {
           GetterSetter person1 = new GetterSetter();
           person1.Name = "Adarsh";
           person1.Name1 = "Kumar";
           person1.Age = 21;

          Console.WriteLine(person1.Name);
          Console.WriteLine(person1.Name1);
          Console.WriteLine(person1.Age);
        }
    }
}
