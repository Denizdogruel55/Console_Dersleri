using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlişlemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=DENIZ\\SQLEXPRESS;Initial Catalog=DbVisit;Integrated Security=True;Encrypt=False");
            void Listele()
            {
              
                SqlCommand komut = new SqlCommand("Select *From TBLPerson", conn);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {

                    Console.WriteLine(oku[0] + " " + oku[1] + " " + oku[2]);

                }

            }
            //Ekleme işlemi
            conn.Open();
            //SqlCommand komut2 = new SqlCommand("insert into TBLPerson(Name,City)values(@p1,@p2)", conn);
            //komut2.Parameters.AddWithValue("@p1", "Deniz Doğruel");
            //komut2.Parameters.AddWithValue("@p2", "Hatay");
            //komut2.ExecuteNonQuery();
            ////Silme işlemi@p
            //SqlCommand komut3 = new SqlCommand("Delete From TBLPerson where Id=@p1", conn);
            //komut3.Parameters.AddWithValue("@p1",7);
            //komut3.ExecuteNonQuery();
            //SqlCommand komut4 = new SqlCommand("Update TBLPerson set Name=@p1,City=@p2 where Id=@p3", conn);
            //komut4.Parameters.AddWithValue("@p1", "ozan");
            //komut4.Parameters.AddWithValue("@p2", "Hatay");
            //komut4.Parameters.AddWithValue("@p3", 3);
            //komut4.ExecuteNonQuery();
                 
            Listele();
            
            conn.Close();
            Console.ReadLine();
        }
    }
}
