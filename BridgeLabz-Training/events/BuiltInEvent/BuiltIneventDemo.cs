using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.events.BuiltInEvent
{
    internal class BuiltIneventDemo  
    {
        static void Main(string[] args)
        {
            Publisher p = new Publisher();
            Subscriber s = new Subscriber();

            p.ProcessCompleted += s.WorkComplete;     //event subscription 
            p.Dowork();
        }
    }
}
