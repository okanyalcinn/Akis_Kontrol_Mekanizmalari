using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchAkisKontrol5
{
    class Program
    {
        static void Main(string[] args)
        {
            float uAdet = 0;
            float tutar = 0;
            float Brut = 0;
            string urun = "";

            float birimFiyat = 0;
            float kitap = 10;
            float defter = 5;
            float silgi = 1;
            float kalem = 2;

            Console.WriteLine("Elimdeki Urunler Bunlar \n kitap \n defter \n silgi \n kalem");
            Console.WriteLine("Hangi urunu almak istersiniz?");
        tekrar:
            urun = Console.ReadLine();

            if ((urun == "kitap") || (urun == "defter") || (urun == "silgi") || (urun == "kalem"))
            {
                Console.WriteLine(urun + "'den kac adet istiyorsun ?");
                uAdet = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Yanlis secim. tekrar dene. kitap, detfer, silgi, kalem var elimde");
                goto tekrar;
            }

            switch (urun)
            {
                case "kitap":
                    tutar = uAdet * kitap;
                    birimFiyat = kitap;
                    break;
                case "defter":
                    tutar = uAdet * defter;
                    birimFiyat = defter;
                    break;
                case "silgi":
                    tutar = uAdet * silgi;
                    birimFiyat = silgi;
                    break;
                case "kalem":
                    tutar = uAdet * kalem;
                    birimFiyat = kalem;
                    break;

                default:
                    break;
            }

            Brut = tutar+ (tutar * 18 / 100);
            Console.WriteLine("urun {0} Birim fiyatı {1} TL Adet {2} Tutar {3} ",urun,birimFiyat,uAdet,tutar);

            Console.WriteLine("Alisverise devam mi F2? çıkış esc");
            ConsoleKeyInfo tus = Console.ReadKey(true);

            if (tus.Key==ConsoleKey.Escape)
            {
                Environment.Exit(1);
            }
            else if (tus.Key == ConsoleKey.F2)
            {
                goto tekrar;
            }

            Console.ReadKey();
        }
    }
}
