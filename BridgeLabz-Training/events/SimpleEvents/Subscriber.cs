using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.events.SimpleEvents
{
    internal class Subscriber           //classes that recieve or handle the event //subscribers cant raise the event, only publisher can. hence p.processcompleted
    {                                  //subscribers recieve event when the event has occured. Publsihers handles the event and when its occured subscribers get info
        public void Handle(string str)         //matches delegate signature 
        { 
            Console.WriteLine("Message recieved" + str);
        }
    }
}
