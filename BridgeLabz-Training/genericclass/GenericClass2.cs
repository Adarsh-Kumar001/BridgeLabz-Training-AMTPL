using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.genericclass
{
    internal class GenericClass2<T1,T2>
    {
        public T1 data1 {  get; set; }

        public T2 data2 { get; set; }
        
        public void DisplayValue()
        {
            Console.WriteLine("Value 1 is : " + data1+" and data 2 is "+ data2);
        }


    }
}
