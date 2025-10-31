using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.polymorphism.Overriding
{
    internal class Dog : Animal
    {
        public override void Eats()       //exact same function as parent, gets overriden and this is executed not parent one.
        {
            Console.WriteLine("Dog eats dog food");
        }
    }
}
