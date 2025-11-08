using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.collections
{
    internal class ListDemo        //dynamic and type safe
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>();

            l1.Add(2);
            l1.Add(3);
            l1.Add(1);

            l1.Remove(2);

            //l1.Clear(); //removes all element

            l1.Sort();

            l1.Insert(0, 5); //insert 5 at index 0

            l1.Reverse();

            bool isContainsTwo = l1.Contains(3); //checks if list contains 3
            Console.WriteLine(isContainsTwo);



        }
    }
}
