using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.delegates
{
    internal class BuiltinDelegates
    {

        public static void run()
        {
            //ACTION --> retruns void and can be used to do a action like print 
            Action<string> logMessage = msg =>
            {
                Console.WriteLine(msg);
            };

            logMessage("Hi, this is built in delegate called action");


            //another action with multiple parameters
            Action<int, int> printSum = (a, b) =>
               Console.WriteLine($"Sum = {a + b}");

            printSum(5, 7);




            //FUNC<T1, ..., TResult> → RETURNS a value and the Last parameter is always the RETURN TYPE
            Func<int, int, int> add = (x, y) =>
            {
                int z = x + y;
                return z;
            };

            Console.WriteLine(add(5, 6));

            //func with no parameters
            Func<string> greet = () => "Hello from Func!";
            Console.WriteLine(greet());






            // PREDICATE<T> → returns TRUE/FALSE ,  Predicate<T> ≡ Func<T, bool>
            Predicate<int> isEven = number => number % 2 == 0;

            Console.WriteLine("Is 10 even? " + isEven(10));
            Console.WriteLine("Is 7 even? " + isEven(7));

        }

        static void Main(string[] args)
        {
            BuiltinDelegates.run();
           
        }
    }
}
