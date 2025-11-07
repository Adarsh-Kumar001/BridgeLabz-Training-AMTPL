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

            GenericClass2<string, int> obj3 = new GenericClass2<string, int>();
            obj3.data1 = "hey";
            obj3.data2 = 7;
            obj3.DisplayValue();
        }

    }
}
