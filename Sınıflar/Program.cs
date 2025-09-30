using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Country country = new Country();
            //country.CountryId = 1;
            //country.Name = "Ukrayna";
            //country.Capital = "Kiev";
            //Console.WriteLine(country.CountryId);
            //Console.WriteLine(country.Name);
            //Console.WriteLine(country.Capital);
            Visitor visitor = new Visitor();
            visitor.VisitorId = 1;
            visitor.Name = "Ali";
            visitor.City = "istanbul";
            Console.WriteLine(visitor.VisitorId);
            Console.WriteLine(visitor.Name);
            Console.WriteLine(visitor.City);
            visitor.mesaj("merhaba");
            visitor.VisitorId = 2;
            visitor.Name = "George";
            visitor.City = "ingiltere";

            Console.ReadLine();
            
        }
    }
}
