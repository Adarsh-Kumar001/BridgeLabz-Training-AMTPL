using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.abstraction.Interface
{
    interface IAnimal                 //as a good practise interface's first letter should be I to represent its an interface
                                     // an interface is a complete abstract class, meant to be inherited not implemented 
    {
        void Eat();                //does not have implementation

        void Colour();

    }
}
