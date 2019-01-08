using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifakiskontol3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Ad_Soyad;
            //string _adSoyad;
            //string ad_Soyad;
            //string SoyadAd;

            int sayi1 = 0;

            Console.WriteLine("Sayi Giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            int deger = 10;

            if (sayi1 == deger)
            {
                Console.WriteLine("deger "+ sayi1 +" "+ deger + "'a esit");
            }
            else 
            {
                //ön tanımlı bunu kullanalım
                Console.WriteLine("sayi {0}'a {1} esit degil ",sayi1, deger);
            }
            

            Console.ReadLine();
        }
    }
}
