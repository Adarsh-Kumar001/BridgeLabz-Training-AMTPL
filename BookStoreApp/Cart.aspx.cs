using BookStoreApp.Data;
using BookStoreApp.Models;
using System;
using System.Linq;

namespace BookStoreApp
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] == null) Response.Redirect("Login.aspx");
            if (!IsPostBack) LoadCart();
        }

        private void LoadCart()
        {
            int userId = Convert.ToInt32(Session["UserId"]);
            using (var db = new BookStoreContext())
            {
                // Join CartItems with Books to get Title/Price
                var cartData = (from c in db.CartItems
                                join b in db.Books on c.BookId equals b.BookId
                                where c.UserId == userId
                                select new { b.Title, b.Price, c.Quantity, Total = b.Price * c.Quantity }).ToList();

                gvCart.DataSource = cartData;
                gvCart.DataBind();

                decimal total = cartData.Sum(x => x.Total);
                lblTotal.Text = total.ToString("C");
            }
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Session["UserId"]);

            using (var db = new BookStoreContext())
            {
                // 1. Get Cart Items joined with Book data
                var cartItems = (from c in db.CartItems
                                 join b in db.Books on c.BookId equals b.BookId
                                 where c.UserId == userId
                                 select new { c, b }).ToList();

                if (cartItems.Count == 0)
                {
                    lblMsg.Text = "Cart is empty!";
                    return;
                }

                // 2. Create Order Header
                Order newOrder = new Order
                {
                    UserId = userId,
                    OrderDate = DateTime.Now,
                    TotalAmount = cartItems.Sum(x => x.b.Price * x.c.Quantity)
                };

                db.Orders.Add(newOrder);
                db.SaveChanges(); // Save to get the new OrderId

                // 3. Process each item: Add to OrderDetails AND Deduct Stock
                foreach (var item in cartItems)
                {
                    // A. Create Order Detail
                    OrderDetail detail = new OrderDetail
                    {
                        OrderId = newOrder.OrderId,
                        BookId = item.b.BookId,
                        BookTitle = item.b.Title,
                        Quantity = item.c.Quantity,
                        Price = item.b.Price
                    };
                    db.OrderDetails.Add(detail);

                    // B. UPDATE STOCK (The Missing Piece!)
                    var bookToUpdate = db.Books.Find(item.b.BookId);
                    if (bookToUpdate != null)
                    {
                        bookToUpdate.Stock -= item.c.Quantity;

                        // Optional: Prevent negative stock
                        if (bookToUpdate.Stock < 0) bookToUpdate.Stock = 0;
                    }

                    // C. Remove from Cart
                    db.CartItems.Remove(item.c);
                }

                // 4. Save all changes (OrderDetails, Stock updates, Cart removal)
                db.SaveChanges();

                lblMsg.Text = "Order placed successfully!";
                LoadCart(); // Refresh the grid (it should be empty now)
            }
        }
    }
}