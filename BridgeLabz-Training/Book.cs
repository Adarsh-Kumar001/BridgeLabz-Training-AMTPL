using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public string Isbn { get; set; }

        public void DisplayBook()
        {
            Console.WriteLine(Id+Name+Author+Isbn);
        }

    
    }
}
