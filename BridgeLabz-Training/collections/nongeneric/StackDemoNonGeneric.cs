using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.collections.nongeneric
{
    internal class StackDemoNonGeneric
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();   //its better to use generic one - Stack<data type> 

            st.Push(1);
            st.Push(2);
            st.Push(3);

            st.Pop();

            foreach(var item in st)
            {
                Console.WriteLine(item);
            }
        }
    }
}
