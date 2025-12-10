using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.lambda
{
    internal class LambdaExpressions
    {
        //an anonymous function..i.e. function without a name. short clean functions. --->  "(parameters) => expression_or_block"
        //internally the lambda function acts a delegate, the compiler makes it for us, Func<int, int> square = x => x * x;

        //x => x * x (means a function takes x and returns x square)

        //(x, y) =>    (means a function takes x and y and returns the sum x+y, this type must have a return)
        //{
        //  int sum = x + y;
        //  return sum;
        //};

        //() => Console.WriteLine("Hello"); (no parameneter lambda expresison) 


    }
}
