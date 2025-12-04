using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.collections.generic
{
    internal class QueueDemo
    {
        public static void Main(string[] args)
        {
            Queue<string> q1 = new Queue<string>();

            q1.Enqueue("1");       //Adds element at last..1
            q1.Enqueue("2");      //Adds element at last...1,2
            q1.Enqueue("3");     //Adds element at last....1,2,3

            Console.WriteLine(q1.Dequeue()); //Removes and returns the element as start...=> 1

        }
    }
}
