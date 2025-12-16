using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.events.BuiltInEvent
{

    internal class Publisher
    {
        public event EventHandler ProcessCompleted;    //built in delegate to handle evenets 
                                                       //subscriber or any mothod can use this signature to handle evenet -> void Method(object sender, EventArgs e)


        public void Dowork()        //does the work and calls onworkcomplete() after doing work
        {
            Console.WriteLine("Processing!");
            OnWorkComplete();
        }

        public virtual void OnWorkComplete()
        {
            ProcessCompleted?.Invoke(this, EventArgs.Empty);       //invoke the event with no data. //only this class(publisher) can raise event, outside can subscribe(+=) or unsusbcribe(-=)
        }                                                         //this is publisher who raised event 
    }
}
