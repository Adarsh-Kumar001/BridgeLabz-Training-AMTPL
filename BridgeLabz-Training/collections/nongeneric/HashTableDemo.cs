using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.collections.nongeneric
{
    internal class HashTableDemo
    {
        static void Main(string[] args)
        {
            //similar to dictionary in generic, stores in key value pairs.
            //keys must be unique and not null, values can be duplicate and null


            Hashtable ht = new Hashtable();

            ht.Add(1, "One"); 
            ht.Add(2, "Two");
            ht.Add(3, "Three");

            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
            }

            var cities = new Hashtable(){
              {"UK", "London, Manchester, Birmingham"},
              {"USA", "Chicago, New York, Washington"},
              {"India", "Mumbai, New Delhi, Pune"}
            };

            foreach (DictionaryEntry de in cities)
            {
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
            }
        }
    }
}
