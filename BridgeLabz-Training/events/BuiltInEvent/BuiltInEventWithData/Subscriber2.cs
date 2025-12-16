using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.events.BuiltInEvent.BuiltInEventWithData
{
    internal class Subscriber2
    {
        public void DownloadLog(object sender, DownloadEventArgs e)
        {
            Console.WriteLine("Download logged for "+e.FileName);
        }
    }
}
