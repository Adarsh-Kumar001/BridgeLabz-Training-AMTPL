using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.collections
{
    internal class StringsDemo   //strings are immutable, stringbuilder created from the string to perform operations.
    {
        static void Main(string[] args)
        {
            string s1 = "";

            s1 = Console.ReadLine();

            string s2 = s1.ToUpper();      //converts to all upper case
             
            string s3 = s2.ToLower();    //convers to all lower case

            string name = "   Adarsh   ";

            Console.WriteLine(name.Trim());     // "Adarsh"
            Console.WriteLine(name.TrimStart()); // "Adarsh   "
            //Console.WriteLine(name.TrimEnd());   // "   Adarsh"

            Console.WriteLine(name.Contains('r'));   //True

            Console.WriteLine(name.Substring(0,3));  //ada


            //SPLIT AND JOIN
            string str2 = "apple,banana,cherry";
            string[] fruits = str2.Split(',');

            string joined = string.Join(" | ", fruits);
            Console.WriteLine(joined); // "apple | banana | cherry"


            //COMPARISON
            string a = "hello";
            string b = "Hello";

            Console.WriteLine(a.Equals(b));                   // false
            Console.WriteLine(a.Equals(b, StringComparison.OrdinalIgnoreCase)); // true //case ignored


            //STRINGBUILDER

            String str = "adarsh";

            StringBuilder sb = new StringBuilder(str);

            sb.Append(" ");
            sb.Append("KUmar");
            sb.Append("!");
            sb.Insert(6, "C# ");
            sb.Replace("Kumar", "K");


            Console.WriteLine(sb.ToString());   //adarshC#  KUmar!


        }
    }
}
