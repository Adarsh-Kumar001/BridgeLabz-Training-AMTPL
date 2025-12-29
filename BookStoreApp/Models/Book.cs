using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreApp.Models
{
    [Table("Books")] // Tells Entity Framework to look for a table named 'Books' in SQL
    public class Book
    {
        [Key] // Tells EF that this is the Primary Key (Auto-Increment)
        public int BookId { get; set; }

        [Required] // Validation: Title cannot be empty
        public string Title { get; set; }

        [Required] // Validation: Author cannot be empty
        public string Author { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }
    }
}