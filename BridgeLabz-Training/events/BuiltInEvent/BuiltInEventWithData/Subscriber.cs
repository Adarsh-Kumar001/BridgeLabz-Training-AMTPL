using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.events.BuiltInEvent.BuiltInEventWithData
{
    internal class Subscriber
    {
        public void DownloadComplete(object sender, DownloadEventArgs e)
        {
            Console.WriteLine("Download Complete of the file " + e.FileName + " of size " + e.sizeMB + " mb. ");
        }
    }
}
