using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud-->Create-Read-Update-Delete

            Console.WriteLine("***** Menu Siparis Islem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("----------------------------------");

            #region Add Category
            //Console.WriteLine("Eklemek Istediginiz Kategori Adi: ");
            //string categoryName = Console.ReadLine();
            //SqlConnection connection = new SqlConnection("Data Source=DORUKDUMAN;Initial Catalog=DB_EgitimCampi;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("INSERT INTO Tbl_Categories (CategoryName) VALUES (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori basariyla eklendi!");
            #endregion

            #region Add Product
            //string productName;
            //decimal productPrice;
            ////bool productStatus;
            //Console.WriteLine("Add Product: ");
            //productName = Console.ReadLine();
            //Console.WriteLine("Product Price: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DORUKDUMAN; initial catalog=DB_EgitimCampi; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("INSERT INTO Tbl_Products (ProductName,ProductPrice,ProductStatus) VALUES (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productStatus",true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Product Added Successfully!");
            #endregion

            #region Product List

            //SqlConnection connection = new SqlConnection("Data Source=DORUKDUMAN; initial catalog=DB_EgitimCampi; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("SELECT * FROM Tbl_Products", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    foreach (var item in dr.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();

            #endregion

            #region Delete Product
            //Console.WriteLine("Silinecek Urun Id");
            //int productId=int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=DORUKDUMAN; initial catalog=DB_EgitimCampi; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("DELETE FROM Tbl_Products Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Product Deleted Successfully!");
            #endregion

            #region Update Product
            //Console.Write("Guncellenecek Urun Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Guncellenecek Urun Ad: ");
            //string productName = Console.ReadLine();

            //Console.Write("Guncellenecek Urun Fiyati: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DORUKDUMAN; initial catalog=DB_EgitimCampi; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("UPDATE Tbl_Products Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Prodcut Updated Successfully!");
            #endregion


            Console.Read();
        }
    }
}

