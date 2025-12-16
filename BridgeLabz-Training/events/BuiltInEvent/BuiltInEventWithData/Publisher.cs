using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.events.BuiltInEvent.BuiltInEventWithData
{
    internal class Publisher
    {
        public event EventHandler<DownloadEventArgs> DownloadCompleted;   //eventhandler with downloadeventargs as data type, its defined in another class which inherits from EventArgs
   
        public void StartDownload()
        {
            Console.WriteLine("Downloading...");
            DownloadFinished(new DownloadEventArgs
            {
                FileName = "test.doc",
                sizeMB = 200
            });
        }

        public void DownloadFinished(DownloadEventArgs e)
        {
            DownloadCompleted?.Invoke(this, e);
        }

    }
}
