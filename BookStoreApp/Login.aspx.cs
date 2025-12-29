using System;
using System.Linq;
using BookStoreApp.Models;
using BookStoreApp.Data;

namespace BookStoreApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = new BookStoreContext())
            {
                
                var user = db.Users.FirstOrDefault(u => u.Username == txtUsername.Text && u.Password == txtPassword.Text);

                if (user != null)
                {
                    Session["User"] = user.Username;
                    Session["UserId"] = user.UserId; // IMPORTANT: Store UserId for Cart logic
                    Session["Role"] = user.Role;

                    if (user.Role == "Admin")
                    {
                        Response.Redirect("Dashboard.aspx");
                    }
                    else
                    {
                        Response.Redirect("Store.aspx"); // We will create this next
                    }
                }
                else
                {
                    lblMessage.Text = "Invalid Username or Password";
                }
            }
        }
    }
}