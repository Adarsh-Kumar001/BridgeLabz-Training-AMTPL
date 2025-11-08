using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.collections
{
    internal class ArraysDemo
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for(int i = 0; i < 10; i++)
            {
                arr[i] = i+1;
            }

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Array.Sort(arr);      // Sort
            Array.Reverse(arr);   // Reverse order

            Console.WriteLine("Index of 8: " + Array.IndexOf(arr, 8));

            Array.Clear(arr, 0, 2);  // Clear first two elements
        }
    }
}
