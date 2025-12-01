using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BridgeLabz_Training.collections.generic
{
    internal class HashSetDemo
    {
        //A HashSet<T> is a collection of unique elements.It does not allow duplicates and does not maintain any particular order.
        //Implemented using hash table internally. 
        //Provides fast lookup, addition and deletion (average O(1) time complexity).

        static void Main(string[] args)
        {
            HashSet<int> hs = new HashSet<int>();

            hs.Add(10);
            hs.Add(20);
            hs.Add(hs.Count);
            hs.Remove(10);

            if (hs.Contains(20))
            {
                foreach(int i in hs)
                {
                    Console.Write(i+" ");
                }
            }

        }


}
}
