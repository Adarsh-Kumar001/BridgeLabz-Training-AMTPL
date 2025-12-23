using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;


namespace BridgeLabz_Training.adodotnet.BillingProblem
{
    internal class BillingProblemAdoDotNet
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=test;Trusted_Connection=True;TrustServerCertificate=True;");

            conn.Open();

            Console.WriteLine("Connection established");      

            //string createTableQuery = "CREATE TABLE BILLS(Id Int, Name Char, Age Int, BillAmount int);";

            //using (SqlCommand cmd1 = new SqlCommand(createTableQuery, conn))
            //{
            //    cmd1.ExecuteNonQuery();
            //}

            string InsertDataQuery = "INSERT INTO BILLS( Name, Age, BillAmount) VALUES('test', 19, 5040);";

            using (SqlCommand cmd2 = new SqlCommand(InsertDataQuery, conn))
            {
                cmd2.ExecuteNonQuery();
            }

            string displayQuery = @"
              SELECT * FROM BILLS;
             ";

            using (SqlCommand cmd = new SqlCommand(displayQuery, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(
                        $"{reader["Id"]} {reader["Name"]} {reader["Age"]} {reader["BillAmount"]}"
                    );
                }
            }

            string CreateTable2Query = "CREATE TABLE BillItems(BillId Int,ProductId Int,Quantity int, Price int);";

            //using (SqlCommand cmd3 = new SqlCommand(CreateTable2Query, conn))
            //{
            //    cmd3.ExecuteNonQuery();
            //}

            string CreateTable3Query = "CREATE TABLE Inventory(ProductId Int Primary Key,Stock int, Price int);";

            //using (SqlCommand cmd4 = new SqlCommand(CreateTable3Query, conn))
            //{
            //    cmd4.ExecuteNonQuery();
            //}

           

            SqlTransaction transaction = conn.BeginTransaction();

            try
            {

                //SqlCommand billCmd = new SqlCommand(
                //    "INSERT INTO BILLS (Id, Name, Age, BillAmount) " +
                //    "VALUES (3,'Adarsh',22, 5530); SELECT SCOPE_IDENTITY();",
                //    conn, transaction);


                int billId = 5;

                // Sample items (ProductId, Quantity, Price)
                var items = new List<(int productId, int qty, int price)>
                {
                    (1, 2, 100),
                    (2, 1, 300)
                };

                foreach (var item in items)
                {
                    // Check stock
                    SqlCommand stockCmd = new SqlCommand(
                        "SELECT Stock FROM Inventory WHERE ProductId = @pid",
                        conn, transaction);

                    stockCmd.Parameters.AddWithValue("@pid", item.productId);

                    int stock = Convert.ToInt32(stockCmd.ExecuteScalar());

                    if (stock < item.qty)
                        throw new Exception("Insufficient stock for ProductId: " + item.productId);

                    
                    SqlCommand itemCmd = new SqlCommand(
                        "INSERT INTO BillItems (BillId, ProductId, Quantity, Price) " +
                        "VALUES (@billId, @pid, @qty, @price)",
                        conn, transaction);

                    itemCmd.Parameters.AddWithValue("@billId", billId);
                    itemCmd.Parameters.AddWithValue("@pid", item.productId);
                    itemCmd.Parameters.AddWithValue("@qty", item.qty);
                    itemCmd.Parameters.AddWithValue("@price", item.price);

                    itemCmd.ExecuteNonQuery();

                    // Reduce stock
                    SqlCommand updateStockCmd = new SqlCommand(
                        "UPDATE Inventory SET Stock = Stock - @qty WHERE ProductId = @pid",
                        conn, transaction);

                    updateStockCmd.Parameters.AddWithValue("@qty", item.qty);
                    updateStockCmd.Parameters.AddWithValue("@pid", item.productId);

                    updateStockCmd.ExecuteNonQuery();
                }

              
                transaction.Commit();
                Console.WriteLine("Billing transaction successful!");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Transaction failed: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }





        }
    }
}
