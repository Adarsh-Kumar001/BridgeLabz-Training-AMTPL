using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.events.SimpleEvents
{
    internal class Subscriber         //classes that recieve or handle the event //subscribers cant raise the event, only publisher can. hence p.processcompleted
    {
        public void Handle(string str)         //matches delegate signature 
        { 
            Console.WriteLine("Message recieved" + str);
        }
    }
}
