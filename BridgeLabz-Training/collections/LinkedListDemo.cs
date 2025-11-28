using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.collections
{
    internal class LinkedListDemo
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();

            ll.AddLast(1);      //add node at last
            ll.AddLast(3);     //add node at last
            ll.AddFirst(0);   //add node at head

            var node = ll.Find(1);      //finds the position 
            ll.AddAfter(node, 2);      //adds elemt after the position of 1
            ll.AddBefore(node, 0);    // adds before the position of 1

            ll.Remove(0);  //removes first occurence of the element

            ll.RemoveLast(); //removes last element of ll

            Console.WriteLine("Elements in linked list are : ");

            foreach(int i in ll)
            {
                Console.WriteLine(i);
            }
        }
    }
}
