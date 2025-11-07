using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.genericclass
{
    internal class DemoGenericClass
    {

        static void Main(string[] args)
        {
            GenericClass<int> obj1 = new GenericClass<int>(100);
            obj1.DisplayValue();

            GenericClass<string> obj2 = new GenericClass<string>("Hey");
            obj2.DisplayValue();
        }

    }
}
