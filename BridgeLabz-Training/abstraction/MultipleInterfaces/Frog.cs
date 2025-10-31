using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.abstraction.MultipleInterfaces
{
    internal class Frog : IAquaticAnimals, ILandAnimals    //since multiple interitance not supported in C#, it can be implemented using interfaces
    {
        public void Region()
        {
            Console.WriteLine("Frogs commonly inhabit the shallow regions of freshwater bodies");
        }

        public void NumberOfLegs()
        {
            Console.WriteLine("Frog has 4 legs");
        }
    }
}
