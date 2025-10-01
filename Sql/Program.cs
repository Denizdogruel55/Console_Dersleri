using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Sql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=DENIZ\\SQLEXPRESS;Initial Catalog=DbVisit;Integrated Security=True;Encrypt=False");
            //void Listele()
            //{

            //    SqlCommand komut = new SqlCommand("Select *From TBLPerson", conn);
            //    SqlDataReader oku = komut.ExecuteReader();
            //    while (oku.Read())
            //    {

            //        Console.WriteLine(oku[0] + " " + oku[1] + " " + oku[2]);

            //    }

            //}
            //Ekleme işlemi

            //SqlCommand komut2 = new SqlCommand("insert into TBLPerson(Name,City)values(@p1,@p2)", conn);
            //komut2.Parameters.AddWithValue("@p1", "Deniz Doğruel");
            //komut2.Parameters.AddWithValue("@p2", "Hatay");
            //komut2.ExecuteNonQuery();
            ////Silme işlemi@p
            //SqlCommand komut3 = new SqlCommand("Delete From TBLPerson where Id=@p1", conn);
            //komut3.Parameters.AddWithValue("@p1",7);
            //komut3.ExecuteNonQuery();
            //Guncelleme
            //SqlCommand komut4 = new SqlCommand("Update TBLPerson set Name=@p1,City=@p2 where Id=@p3", conn);
            //komut4.Parameters.AddWithValue("@p1", "ozan");
            //komut4.Parameters.AddWithValue("@p2", "Hatay");
            //komut4.Parameters.AddWithValue("@p3", 3);
            //komut4.ExecuteNonQuery();@
            //string name, city;
            //Console.Write("Kişi Adi Giriniz: ");
            //name = Console.ReadLine();
            //Console.Write("Şehir Giriniz: ");
            //city = Console.ReadLine();
            //SqlCommand komut5 = new SqlCommand("insert into TBLPerson(Name,City) values (@p1,@p2)", conn);
            //komut5.Parameters.AddWithValue("@p1", name);
            //komut5.Parameters.AddWithValue("@p2", city);
            //komut5.ExecuteNonQuery();

            //Listele();
            //conn.Open();
            //SqlCommand komut6 = new SqlCommand("Select * From TBLPerson where City=@p1 ", conn);
            //Console.Write("Sehir Giriniz:");
            //string sehir=Console.ReadLine();

            //komut6.Parameters.AddWithValue("@p1", sehir);
            //SqlDataReader oku= komut6.ExecuteReader();
            //while (oku.Read()) {

            //    Console.WriteLine(oku[0] + " " + oku[1] + " " + oku[2]);
            
            //}
       
            //conn.Close();


            Console.ReadLine();

            }
           
        }
    }

