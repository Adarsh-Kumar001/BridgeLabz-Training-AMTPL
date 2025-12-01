using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.collections.nongeneric
{
    internal class QueueDemoNonGeneric
    {
        static void Main(string[] args)
        {
            var queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);   
            queue.Enqueue(3);
            queue.Enqueue(4);

            queue.Dequeue();

            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }


        }
    }
}
