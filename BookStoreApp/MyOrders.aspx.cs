using BookStoreApp.Data;
using BookStoreApp.Models;
using System;
using System.Linq;

namespace BookStoreApp
{
    public partial class MyOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] == null) Response.Redirect("Login.aspx");

            using (var db = new BookStoreContext())
            {
                int userId = Convert.ToInt32(Session["UserId"]);
                gvOrders.DataSource = db.Orders.Where(o => o.UserId == userId).OrderByDescending(o => o.OrderDate).ToList();
                gvOrders.DataBind();
            }
        }
    }
}