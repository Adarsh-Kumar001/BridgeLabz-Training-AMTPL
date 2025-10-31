using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.iheritance.MultiLevel
{
    internal class MultiLevelInheritanceDemo
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            a1.Eat();

            Dog d1 = new Dog();
            d1.Eat();
            d1.Bark();

            GermanShepherd g1 = new GermanShepherd();
            g1.Eat();
            g1.Bark();
            g1.Color();


        }
    }
}
