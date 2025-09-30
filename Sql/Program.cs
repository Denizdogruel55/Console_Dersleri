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
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From TBLPerson", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {


                Console.WriteLine(reader[0]+ " " + reader[1]+ " " + reader[2]);
              
            }
            Console.ReadLine();

            conn.Close();
        }
    }
}
