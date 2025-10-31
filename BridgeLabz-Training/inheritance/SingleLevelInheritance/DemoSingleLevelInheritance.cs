using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.iheritance.SingleLevelInheritance
{
    internal class DemoSingleLevelInheritance
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            a1.Eat();
            Dog d1 = new Dog();
            d1.Eat();
            d1.Bark();
            Animal a2 = new Dog();
            a2.Eat();
            //a2.Bark(); //reference is of parent and object is of child, parent cant access child's properties
        }
    }
}
