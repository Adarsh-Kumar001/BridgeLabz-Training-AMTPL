using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.delegates
{
    internal class MulticastDelegates      //multicast delegates reference multiple methods. += and -= used to add and remove methods.
                                           //when called all methods are invoked in order
    {
        public delegate void Notify(string message);

        void handlerA(string m) => Console.WriteLine("A: "+m);

        void handlerB(string m) => Console.WriteLine("B: "+m);


        public void run()
        {
            //create delegate instance with handler A as starting 
            Notify n = handlerA;

            //add another function, so now first handler A then handler B
            n += handlerB;

            n("hello"); //prints both handler A and B

            n -= handlerA; //remove function A

            n("hi");   //prints handler B only
        }

    }
}
