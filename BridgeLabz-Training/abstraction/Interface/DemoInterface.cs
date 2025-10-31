using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.abstraction.Interface
{
    internal class DemoInterface
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.Eat();
            d1.Colour();
        }
    }
}
