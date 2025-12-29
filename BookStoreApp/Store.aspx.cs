using BookStoreApp.Data;
using BookStoreApp.Models;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace BookStoreApp
{
    public partial class Store : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] == null) Response.Redirect("Login.aspx");
            if (!IsPostBack) LoadBooks();
        }

        private void LoadBooks()
        {
            using (var db = new BookStoreContext())
            {
                gvBooks.DataSource = db.Books.ToList();
                gvBooks.DataBind();
            }
        }

        protected void gvBooks_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "AddToCart")
            {
                int bookId = Convert.ToInt32(e.CommandArgument);
                int userId = Convert.ToInt32(Session["UserId"]);

                using (var db = new BookStoreContext())
                {
                    // Check if already in cart
                    var existingItem = db.CartItems.FirstOrDefault(c => c.UserId == userId && c.BookId == bookId);
                    if (existingItem != null)
                    {
                        existingItem.Quantity++; // Increase qty if exists
                    }
                    else
                    {
                        db.CartItems.Add(new CartItem { UserId = userId, BookId = bookId, Quantity = 1 });
                    }
                    db.SaveChanges();
                    lblMsg.Text = "Item added to cart!";
                }
            }
        }
    }
}