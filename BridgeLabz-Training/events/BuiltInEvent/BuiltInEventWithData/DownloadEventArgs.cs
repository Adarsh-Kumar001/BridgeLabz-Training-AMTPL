using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.events.BuiltInEvent.BuiltInEventWithData
{
    internal class DownloadEventArgs : EventArgs    //inherits from EventArgs 
    {
        public string FileName {  get; set; }
        public int sizeMB { get; set; }
    }
}
