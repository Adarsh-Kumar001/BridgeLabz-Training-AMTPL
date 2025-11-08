using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.collections
{
    internal class DictionaryDemo
    {
        static void Main(string[] args)
        {

            // count freq of chars in string


            Dictionary<char, int> dict = new Dictionary<char, int>();

            string str = "adcdab";

            foreach(char c in str)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c] += 1;
                }
                else
                {
                    dict[c] = 1;
                }
                    
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
