using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.events.BuiltInEvent.BuiltInEventWithData
{
    internal class BuiltineventwithdataDemo   
    {
        static void Main(string[] args)
        {
            Publisher p = new Publisher();
            Subscriber s = new Subscriber();
            Subscriber2 s2 = new Subscriber2();

            p.DownloadCompleted += s.DownloadComplete;           //subscriber 1 subscribes
            p.DownloadCompleted += s2.DownloadLog;              //subscriber 2 subscribes 
            p.StartDownload();                                  //function call
            p.DownloadCompleted -= s.DownloadComplete;         //subscriber unsubscribes after function call
            p.DownloadCompleted -= s2.DownloadLog;
        }
    }
}
