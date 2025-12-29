using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BookStoreApp.Models;
using BookStoreApp.Data;

namespace BookStoreApp
{
    public partial class Register : System.Web.UI.Page
    {

        protected void RegisterUser(object sender, EventArgs e)
        {
            using (var db = new BookStoreContext())
            {
                var user = new User
                {
                    Username = txtUser.Text,
                    Password = txtPass.Text
                };

                db.Users.Add(user);
                db.SaveChanges();
            }

            lblMsg.Text = "Registration successful!";
        }
    }
}