using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.address_book_problem
{
    internal class AddressBook : ContactInfo
    {
        List<ContactInfo> Contacts = new List<ContactInfo>();

        public void AddContact(ContactInfo contact)
        {
            Contacts.Add(contact);
        }

        public void RemoveContact(ContactInfo contact)
        {
            Contacts.Remove(contact);
        }

        public void DisplayContacts()
        {

            if (Contacts.Count == 0)
            {
                Console.WriteLine("No Contacts found!");
                return;
            }

            foreach (ContactInfo c in Contacts)
            {
                c.DisplayInfo();
            }
        }

        public void SearchContact(string name)
        {
            var found = Contacts.Find(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (found != null)
            {
                Console.WriteLine("Contact found");
                found.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Contact not found");
            }
        }

        public void DeleteContact(string name)
        {
            var found = Contacts.Find(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (found != null)
            {
                Contacts.Remove(found);
                Console.WriteLine("Contact Deleted");
            }
            else
            {
                Console.WriteLine("Contact not exists");
            }
        }
    }
}
