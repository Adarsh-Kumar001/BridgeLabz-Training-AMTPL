using BridgeLabz_Training;
using System;

class Program 
{ 

    static void Main(string[] args)
    {
        Library library = new Library();

        Book b1 = new Book();
        b1.Id = 1;
        b1.Name = "Book 1";
        b1.Author = "adarsh";
        b1.Isbn = "123D";

        library.AddBook(b1);
        

        Book b2 = new Book();
        b2.Id = 2;
        b2.Name = "Book 2";
        b2.Author = "Adarsh";
        b2.Isbn = "12345";

        library.AddBook(b2);

        library.DisplayBooks();

        //library.RemoveBook(b2);
          
 

        library.DisplayBooks();

        Book b3 = new Book();
        b2.Id = 2;
        b2.Name = "Book 2";
        b2.Author = "Adarsh Kumar";
        b2.Isbn = "1234566666";

        library.UpdateBook(b2);

        library.DisplayBooks();


    }
}
