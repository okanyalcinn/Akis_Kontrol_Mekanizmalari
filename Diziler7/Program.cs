using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler7
{
    class Program
    {
        static void Main(string[] args)
        {
            // rastgele uretilen 20 sayidan 30 a en yakin olan sayiyi bulunuz
            int[] sayilar = new int [20];
            int[] yakin = new int[5];
            Random rast = new Random();
            int tanpon = 0;
            int t = 0;


            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rast.Next(1, 100);
            }

            foreach (var item in sayilar)
            {
                Console.Write(item + " - ");
            }
            Console.WriteLine();// \n gorevinde alt satira gecsin diye

            for (int i = 0; i < sayilar.Length; i++)
            {
                int sy = sayilar[i] - 30; // farkini buluyoruz
                sy = Math.Abs(sy); //mutlak deger eksili degerleri artiya ceviriyoruz

                if (i==0) // for dongusunun ilk degerini aliyoruz
                {
                    tanpon = sayilar[i] - 30; // tanpon = sy; yazilabilir
                    tanpon = Math.Abs(tanpon);
                }
                if (sy <=tanpon)// en kucuk farktan daha kucuk ise 
                {
                    tanpon = sy;
                    t = i;
                }
            }

            Console.WriteLine(sayilar[t] + " - " + t);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(yakin[i]);
            }

            Console.ReadKey();
        }
    }
}
