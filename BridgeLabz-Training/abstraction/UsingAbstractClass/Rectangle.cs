using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.abstraction.UsingAbstractClass
{
    internal class Rectangle : Area
    {
        private float _length;
        private float _width;

        public Rectangle(float length, float width)
        {
            _length = length;
            _width = width;
        }


        public override void CalcArea()
        {
            Console.WriteLine("The area of the reactable is " + (_length * _width));
        }

    }
}
