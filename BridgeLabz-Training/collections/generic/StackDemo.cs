using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.collections.generic
{
    internal class StackDemo
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>();

            for(int i = 0; i < 5; i++)
            {
                l1.Add(i);
            }

            for(int i = 1; i <= 2; i++)
            {
                l1.Remove(i);
            }

            for(int i = 0; i < l1.Count; i++)
            {
                Console.WriteLine(l1[i]+" ");
            }
        }


    }
}
