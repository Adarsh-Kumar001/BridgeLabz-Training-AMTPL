using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.events.SimpleEvents
{
    internal class EventsDemo    //events are delegates internally //Events enable a class or object to notify other classes or objects when something of action occurs
    {                           //events are used since direct delegate from this purpose may be angerous as data can be accessed by subscribers

        static void Main(string[] args)
        {
            Publisher p = new Publisher();
            Subscriber s = new Subscriber();

            p.ProcessCompleted += s.Handle;
            
            p.Start();

            p.ProcessCompleted -= s.Handle;  //unsusbcribeing from event

        }





    }
}
