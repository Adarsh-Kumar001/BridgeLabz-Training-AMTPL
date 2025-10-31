using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.abstraction.MultipleInterfaces
{
    internal class DemoMultipleInterface
    {
        static void Main(string[] args) {
            Frog f1 = new Frog();
            f1.Region();
            f1.NumberOfLegs();
        }
    }
}
