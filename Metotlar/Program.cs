using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    topla();
            //    Console.ReadLine();
            //    void topla()
            //    {

            //        int s1 = 20;
            //        int s2 = 20;
            //        int s3 = s1 + s2;
            //        Console.WriteLine(s3);

            //    }
            //yazdir("merhaba");
            //yaz("ahmet", "kaya ", 25);

            //void yazdir(string p)
            //{
            //    Console.WriteLine(p);
            //}
            //void yaz(string ad,string soyad,int yas)
            //{
            //    Console.WriteLine(ad + " " + soyad + " " + yas);
            //}
            //void toplam(int s1, int s2) { 
            //int sonuc=s1+s2;
            //    Console.WriteLine(sonuc);


            //}
            //toplam(60, 80);
            //void dersortalama(string ad,string soyad,double s1,double s2,double s3)
            //{
            //  double  ortalama = (s1 + s2 + s3) / 3;
            //    Console.WriteLine(ad + " " + soyad + " ortalamanız:" + ortalama);
            //}
            //dersortalama("ali", "çınar", 50, 40, 70);
            //int topla(int s1, int s2) { 

            //int sonuc=s1+s2;
            //    return sonuc;


            //}
            //Console.WriteLine(topla(1, 2));
            void Selamla(string ad)
            {
                int saat = DateTime.Now.Hour;
                if (saat > 8 && saat <= 12)
                {
                    Console.WriteLine("Merhaba Günaydin " + ad);
                }
                else if (saat >= 12 && saat <= 15)
                {
                    Console.WriteLine("iyi Günler " + ad);
                }

            }
            Selamla("ali");
            Console.ReadLine();
        }


    }
}
