using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabz_Training.closures
{
    internal class Closures
    {
        // A closure is created when a lambda expression or anonymous method captures variables from its outer scope and remembers them even after the outer method has finished execution.
        //A closure = function + captured variables
        //closures captures variables not its values, the values can be changed if its re declared.

        static void Main(string[] args)
        {
            int number = 10;

            Func<int, int> multiply = x => x * number; //number is outside lambda but it remembers it

        }
    }
}
