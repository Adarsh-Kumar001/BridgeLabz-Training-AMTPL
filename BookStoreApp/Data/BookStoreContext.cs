using System.Data.Entity;
using BookStoreApp.Models;

namespace BookStoreApp.Data
{
    public class BookStoreContext : DbContext
    {
        // Pass the name of the connection string from Web.config
        public BookStoreContext() : base("name=BookStoreContext")
        {
        }

        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
    }
}