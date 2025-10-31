using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.polymorphism.Overriding
{
    internal class Animal
    {
        public virtual void Eats()
        {
            Console.WriteLine("Animal is eating");
        }
    }
}
