using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.events.BuiltInEvent
{
    internal class Subscriber
    {
        public void WorkComplete(object sender, EventArgs e)       //after the work gets completed  //matches EventHandler's signature   //object sender is used to know who raised the event 
        {
            Console.WriteLine("Listener: Work completed!");
        }
    }
}
