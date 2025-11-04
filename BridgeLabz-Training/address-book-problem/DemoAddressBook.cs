using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.address_book_problem
{
    internal class DemoAddressBook
    {
        static void Main(string[] args)
        {
            AddressBook addressbook = new AddressBook();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===== Address Book Menu =====");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display All Contacts");
                Console.WriteLine("3. Search Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        ContactInfo c = new ContactInfo();
                        Console.Write("Enter Name: ");
                        c.Name = Console.ReadLine();
                        Console.Write("Enter Phone: ");
                        c.Phone = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Email: ");
                        c.Email = Console.ReadLine();
                        Console.Write("Enter Address: ");
                        c.Address = Console.ReadLine();
                        addressbook.AddContact(c);
                        break;

                    case "2":
                        addressbook.DisplayContacts();
                        break;

                    case "3":
                        Console.Write("Enter name to search: ");
                        addressbook.SearchContact(Console.ReadLine());
                        break;

                    case "4":
                        Console.Write("Enter name to delete: ");
                        addressbook.DeleteContact(Console.ReadLine());
                        break;

                    case "5":
                        exit = true;
                        Console.WriteLine("Exiting Address Book...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
            
        }
    }
}
