using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;    //use this namespace for SqlConnection. install this from Packages
using System.Data;                //for storing procedures, transactions etc..

namespace BridgeLabz_Training.adodotnet
{
    internal class AdoDotnetDemo     //Bridge between c# and database, allows us to open db connections and execute sql queries 
    {

        static void Main(string[] args) {
            //the connection string
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=test;Trusted_Connection=True;TrustServerCertificate=True;"; //connection string from sql server


            //establishing connection
            using SqlConnection conn = new SqlConnection(connectionString);         //using -> auto closes the connection.
            
            conn.Open();
            Console.WriteLine("Connection Opened");



            //Create table        //@ for multiline string
            string createTableQuery = @"                                              
              IF NOT EXISTS (SELECT * FROM sys.tables WHERE name='Employee')
              CREATE TABLE Employee (
              Id INT IDENTITY PRIMARY KEY,
              Name NVARCHAR(50),
              Salary FLOAT
              );";

            using (SqlCommand cmd = new SqlCommand(createTableQuery, conn))
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table created successfully");
            }
         

           

            //add data in table 
            string insertQuery = @"
              INSERT INTO Employee(Name, Salary) 
              VALUES('Adarsh', 20000);";

            using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
            {
                cmd.ExecuteNonQuery();
            }


            //display the data

            string displayQuery = @"
              SELECT * FROM Employee;
             ";

            using (SqlCommand cmd = new SqlCommand(displayQuery, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(
                        $"{reader["Id"]} | {reader["Name"]} | {reader["Salary"]}"
                    );
                }
            }

        }
    }
}
