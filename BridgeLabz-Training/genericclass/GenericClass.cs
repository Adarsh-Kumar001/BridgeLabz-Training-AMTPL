using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.genericclass
{
    internal class GenericClass<T>
    {
        private T data;
        public GenericClass(T value)
        {
            data = value;
        }

        public void DisplayValue()
        {
            Console.WriteLine("The value is :" +  data);
        }
    }
}
