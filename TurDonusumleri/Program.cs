using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 1;

            //sayi = int.Parse(Console.ReadLine());

            //sayi = Convert.ToInt32(Console.ReadLine());

            byte b = 1;

            b = (byte)sayi;

            //bilincli tur donusumu
            string a = b.ToString();

            a = sayi.ToString();

            float toplam =(float)(byte) b + sayi;

            float sayi2 = 5.2235422f;
            float sayi3 = 4.22542F;

            Console.WriteLine("{0:F3}", sayi2);
            Console.WriteLine(sayi3.ToString("0.###"));

            sayi = (int)sayi2 + (int)sayi3;
            Console.WriteLine(sayi.GetType());

            Console.WriteLine("sayi 4 degeri "+sayi3+" "+sayi3.GetType());

            Console.WriteLine(b.GetType());

            float ondalikli;
            double dSayi;
            char c = 'a';

            sayi = (int)c;
            Console.WriteLine(sayi+"\n");

            for (char i = 'a'; i < 'f'; i++)
            {
                sayi = (int)i;
                Console.WriteLine(sayi);
                sayi = sayi +i;
            }
            Console.WriteLine(sayi);


            // boxing unboxing islemleri
            string metin = "demo";
            object nesne = sayi;

            nesne = sayi2;
            Console.WriteLine(nesne.GetType());
            nesne = metin;
            Console.WriteLine(nesne.GetType());
            nesne = b;
            Console.WriteLine(nesne.GetType());
            nesne = sayi;
            Console.WriteLine(nesne.GetType());
            nesne = c;
            Console.WriteLine(nesne.GetType());

            nesne = sayi + sayi2;
            Console.WriteLine(nesne);
            Console.WriteLine(nesne.GetType());

            // sadece true ya da false 0 - 1 döndürür

            bool durum = false;

            for (int i = 0; i < 10; i++)
            {

                if(i==4)
                {
                    durum = true;
                }

                if (durum)
                {
                    Console.WriteLine(durum);
                    Console.WriteLine(durum.GetType());
                }

            }

            Console.ReadKey();
        }
    }
}
