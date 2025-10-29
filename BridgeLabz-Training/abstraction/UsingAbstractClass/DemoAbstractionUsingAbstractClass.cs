using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.abstraction.UsingAbstractClass
{
    internal class DemoAbstractionUsingAbstractClass
    {
        static void Main(string[] args)
        {
            //Area a1 = new Area();  //object of abstract class cannot be cretaed as it's meant to be inherited not instiantinated

            Circle c1 = new Circle(7);
            c1.CalcArea();
            Rectangle r1 = new Rectangle(3, 7);
            r1.CalcArea();
        }
    }
}
