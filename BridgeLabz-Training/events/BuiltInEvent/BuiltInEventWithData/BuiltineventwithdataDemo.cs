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

            p.DownloadCompleted += s.DownloadComplete;
            p.StartDownload();
            p.DownloadCompleted -= s.DownloadComplete;
        }
    }
}
