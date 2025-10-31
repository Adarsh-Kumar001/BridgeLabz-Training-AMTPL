using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.EnumExample
{
    internal class DemoEnum
    {
        static void Main(string[] args)
        {
            EnumExample.Months LastMonth = EnumExample.Months.Dec;
            Console.WriteLine($"The last month is : {LastMonth}");
        }
    }
}
