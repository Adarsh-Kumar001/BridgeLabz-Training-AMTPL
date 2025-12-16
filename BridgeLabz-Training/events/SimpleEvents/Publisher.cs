using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.events.SimpleEvents
{

    public delegate void Notify(string str);    //declare delegate


    internal class Publisher   //classes that sends or raises the event
    {

        public event Notify ProcessCompleted;       //declare event, Notify is the delegate and ProcessCompleted is event name

        public void Start()
        {

            Console.WriteLine("Processing");
            ProcessCompleted?.Invoke(" Done, Process completed!");    //?. is null safe operator. Invoke calls subscribed methods and sends data to subscriber
                                                                      //if no one subscribes its null and can crash so we use ?.
        }
    }
}
