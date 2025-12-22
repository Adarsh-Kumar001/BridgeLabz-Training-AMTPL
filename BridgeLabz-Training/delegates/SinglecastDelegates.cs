using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.delegates
{
    internal class SinglecastDelegates       //singlecast delegates point to a single function
    {

        //delegates are a type safe pointer to functions       //anonymous functions are cretaed using delegats
        //holds references to a function, their signatures must match.
        //we can invoke the method through the delegate
        //it helps treat function as variable 


        public delegate int MathOperations(int x, int y);   //MathOperations is a delegate which takes x and y and returns int


        //functions matching the delegate 
        static int Add(int a, int b) => a + b;
        static int Sub(int a, int b) => a - b;
        static int Mul(int a, int b) => a * b;
        static int Div(int a, int b) => a / b;


        static void Main(string[] args)
        {

            MathOperations operation;

         
            operation = Add;
            Console.WriteLine(operation(10, 20));

            operation = Sub;
            Console.WriteLine(operation(20, 10));
                  
            operation = Mul;
            Console.WriteLine(operation(20, 10));

            operation = Div;
            Console.WriteLine(operation(10, 10));
        }
    }
}
   