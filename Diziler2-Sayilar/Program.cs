using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler2_Sayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[15];
            Random rd = new Random();

            int sayac = 0;

            for (int i = 0; i < sayilar.Length; i++) //sayilar.Length dizinin uzunlugu kadar al diyoruz
            {
                int sayi = rd.Next(1,15);

                if(sayilar.Contains(sayi))
                {
                    sayac++;
                    i--;
                }
                else
                {
                    sayilar[i] = sayi;
                }
            }

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            Console.WriteLine("Ayni sayidan {0} defa uretildi",sayac);

            Console.ReadKey();
        }
    }
}
