using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net
            Console.WriteLine("***** C# Ürün Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-----------------------------------");
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    // SqlConnection ile veritabanina baglama islemi
                    //SqlConnection connection = new SqlConnection("Data Source=yourdatasource;Initial Catalog=DB_EgitimCampi;Integrated Security=True");
                    connection.Open(); // Baglantiyi ac

                    // SqlCommand ile baglanilan veritabanina sql sorgusu yazarak istenilen veriyi cekme islemi
                    SqlCommand command = new SqlCommand("SELECT * FROM Tbl_Categories", connection); // SQL sorgusu
                    // SqlDataAdapter keywordu ile RAM'de DataTable olusturarak istenilen SQL query sonucunu doldurma islemi
                    SqlDataAdapter adapter = new SqlDataAdapter(command); // Veriyi almak icin adapter kullan
                    DataTable dataTable = new DataTable(); // RAM'de bir DataTable olustur
                    adapter.Fill(dataTable); // Adapter ile DataTable'i doldur
                    connection.Close(); // Baglantiyi kapat

                    // Dongu kullanarak DataTable'daki satirlari gezinme
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // İc ice dongu ile de DataTable'daki sutunlardaki istenilen verileri getirme
                        foreach (var item in row.ItemArray)
                        {
                            Console.WriteLine(item.ToString()); // Her bir ogeyi yazdır
                        }
                        Console.WriteLine(); // Satir sonu
                    }
                }

                Console.Read();
            }
        }
    }


