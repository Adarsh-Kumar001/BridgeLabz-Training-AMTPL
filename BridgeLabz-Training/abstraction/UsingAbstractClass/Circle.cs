using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.abstraction.UsingAbstractClass
{
    internal class Circle : Area
    {

        private float _radius;

        public Circle(float radius)
        {
            _radius = radius;
        }

        public override void CalcArea()
        {
            Console.WriteLine("The area of the circle is: "+(3.14*_radius*_radius));
        }
    }
}
