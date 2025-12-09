using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.nunittesting     //right click the sln and add a new nunit project inside this project and write test cases for this code there
{
    public class calculator
    {
        public int Add(int x, int y) => x + y;
        public int Sub(int x, int y) => x - y;
        public int Mul(int x, int y) => x * y;
        public double Div(int x, int y) 
            {
            if (y == 0) throw new System.DivideByZeroException();
            return (double)x / y;
            }
    }
}
