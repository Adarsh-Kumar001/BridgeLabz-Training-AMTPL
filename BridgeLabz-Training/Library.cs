using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training
{
    internal class Library : Book
    {
        List<Book> MyLibrary = new List<Book>();

        
        public void AddBook(Book book1)   
        {
            if(MyLibrary.Count == 0)
            {
                MyLibrary.Add(book1);
            }
            else
            {
                bool contains = false;

                foreach(Book b in MyLibrary)
                {
                    if(b.Id == book1.Id)
                    {
                        contains = true;
                    }  
                }

                if(contains == true)
                {
                    Console.WriteLine("Book already present");
                }
                else
                {
                    MyLibrary.Add(book1);
                }

                //if (MyLibrary.Contains(book1))
                //{
                //    Console.WriteLine("Book already present");
                //}
                //else
                //{
                //    MyLibrary.Add(book1);
                //}
            }
        }

        public void RemoveBook(Book book1)
        {
            if (MyLibrary.Contains(book1)) 
            { 
                MyLibrary.Remove(book1);
            }
            else
            {
                Console.WriteLine("Book not present");
            }
        }

        public void DisplayBooks()
        {
            foreach(Book b in MyLibrary)
            {
                Console.WriteLine("ID: "+ b.Id);
                Console.WriteLine("Name: " + b.Name);
                Console.WriteLine("Author: " + b.Author);
                Console.WriteLine("Isbn: " + b.Isbn);
            }
        }

        public void UpdateBook(Book book1)
        {
            if (MyLibrary.Contains(book1))
            {
                MyLibrary.Remove(book1);
                MyLibrary.Add(book1);
            }
            else
            {
                Console.WriteLine("Book not present");
            }
        }

    }
}
