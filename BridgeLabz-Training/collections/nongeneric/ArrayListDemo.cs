using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.collections.nongeneric
{
    internal class ArrayListDemo
    {

        static void Main(string[] args)
        {

           //datatype not defined, can have any data unlike generic where data typed is defined - its typesafe, it isint.

            // Explicitly typed
            ArrayList arrlst1 = new ArrayList();

            // Implicitly typed using 'var'
            var arrlst2 = new ArrayList();

            arrlst1.Add(1);
            arrlst1.Add("Bill");
            arrlst1.Add(" ");
            arrlst1.Add(true);
            arrlst2.Add(4.5);
            arrlst2.Add(null);

            arrlst2.Insert(1, "Second Item"); //insert at a position

            arrlst2.AddRange(arrlst1);   //adds arraylist1 into arraylist2

            arrlst2.Remove(null); //Removes first occurance of null
            arrlst2.RemoveAt(4); //Removes element at index 4

            arrlst2.Sort();

            arrlst2.Reverse();

            for (int i = 0; i < arrlst2.Count; i++)
            {
                Console.Write(arrlst2[i] + " ");
            }

        }
    }
}
