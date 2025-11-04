using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.address_book_problem
{
    internal class ContactInfo : Person
    {

        public string Address { get; set; } 

        public string Email { get; set;  }

   

            internal void DisplayInfo()
            {
               Console.WriteLine("The info of the Person: ");
               Console.WriteLine($"The name of the person is : {base.Name}");
               Console.WriteLine($"The phone number of the person is : {base.Phone}");
               Console.WriteLine($"The Email of the person is : {this.Email}");
               Console.WriteLine($"The address of the person is : {this.Address}");
            }

        
    }
}
