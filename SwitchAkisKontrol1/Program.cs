using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchAkisKontrol1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi gir");
            int giris_degeri = Convert.ToInt32(Console.ReadLine());

            switch (giris_degeri)
            {
                //eger switch sartimiz tam sayi ise, case degerlerini tam sayi ifadeler olarak yazariz
                case 1:
                    Console.WriteLine("girilensayi {0}", giris_degeri);
                    break;
                case 2:
                    Console.WriteLine("girilensayi {0}", giris_degeri);
                    break;
                case 3:
                    Console.WriteLine("girilensayi {0}", giris_degeri);
                    break;
                default:
                    Console.WriteLine("girilensayi {0}", giris_degeri);
                    break;
            }


            Console.ReadKey();
        }
    }
}
