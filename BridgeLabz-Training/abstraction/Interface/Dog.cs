using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.abstraction.Interface
{
        internal class Dog : IAnimal
        {
            public void Eat()                           //does not needs override keyword in interface
            {
                Console.WriteLine("Dog eats dog food");
            }

            public void Colour()
            {
                Console.WriteLine("Dog has multiple colours like brown, black, white..etc");
            }
        }
    
}
