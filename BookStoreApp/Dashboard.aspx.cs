using BookStoreApp.Data;
using BookStoreApp.Models; // Import your Models namespace
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace BookStoreApp
{
    public partial class Dashboard : System.Web.UI.Page
    {
        // 1. Page Load Event
        protected void Page_Load(object sender, EventArgs e)
        {
            // Security Check: If no user in session, go to Login
            if (Session["User"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            // Display Username
            lblUser.Text = Session["User"].ToString();

            // Load data only on first visit (not when clicking buttons)
            if (!IsPostBack)
            {
                LoadBooks();
            }
        }

        // 2. Helper Method to Load Data
        private void LoadBooks()
        {
            using (var db = new BookStoreContext())
            {
                gvBooks.DataSource = db.Books.ToList();
                gvBooks.DataBind();
            }
        }

        // 3. Add New Book
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BookStoreContext())
                {
                    var book = new Book
                    {
                        Title = txtTitle.Text,
                        Author = txtAuthor.Text,
                        Price = decimal.Parse(txtPrice.Text), // Convert text to decimal
                        Stock = int.Parse(txtStock.Text)      // Convert text to int
                    };

                    db.Books.Add(book);
                    db.SaveChanges(); // Save to SQL
                }

                // Clear inputs and refresh grid
                txtTitle.Text = ""; txtAuthor.Text = ""; txtPrice.Text = ""; txtStock.Text = "";
                lblMessage.Text = "";
                LoadBooks();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: Please check your input (Price/Stock must be numbers).";
            }
        }

        // 4. Enable Edit Mode
        protected void gvBooks_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvBooks.EditIndex = e.NewEditIndex;
            LoadBooks();
        }

        // 5. Cancel Edit Mode
        protected void gvBooks_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvBooks.EditIndex = -1;
            LoadBooks();
        }

        // 6. Update Existing Book
        protected void gvBooks_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            // Get the ID of the book being edited
            int id = Convert.ToInt32(gvBooks.DataKeys[e.RowIndex].Value);

            // Get new values from the input boxes in the Grid
            // Cells[1] is Title, [2] is Author, [3] is Price, [4] is Stock
            string title = (gvBooks.Rows[e.RowIndex].Cells[1].Controls[0] as TextBox).Text;
            string author = (gvBooks.Rows[e.RowIndex].Cells[2].Controls[0] as TextBox).Text;
            string priceStr = (gvBooks.Rows[e.RowIndex].Cells[3].Controls[0] as TextBox).Text;
            string stockStr = (gvBooks.Rows[e.RowIndex].Cells[4].Controls[0] as TextBox).Text;

            using (var db = new BookStoreContext())
            {
                var book = db.Books.Find(id); // Find book in DB
                if (book != null)
                {
                    book.Title = title;
                    book.Author = author;
                    book.Price = decimal.Parse(priceStr);
                    book.Stock = int.Parse(stockStr);
                    db.SaveChanges(); // Update SQL
                }
            }

            gvBooks.EditIndex = -1; // Exit edit mode
            LoadBooks();
        }

        // 7. Delete Book
        protected void gvBooks_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(gvBooks.DataKeys[e.RowIndex].Value);

            using (var db = new BookStoreContext())
            {
                var book = db.Books.Find(id);
                if (book != null)
                {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
            }
            LoadBooks();
        }

        // 8. Logout
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("Login.aspx");
        }
    }
}