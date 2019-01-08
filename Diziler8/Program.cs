using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler8
{
    class Program
    {
        static void Main(string[] args)
        {
            //rastgele tutulan 20 sayinin icerisindeki tek ve cift sayilari
            //ayri dizilerde tutup bunlari ayri ayri ekrana yazdiran program

            int[] sayilar = new int[20];
            Random rast = new Random();
            int[] tSayilar = new int [20] ;
            int[] cSayilar = new int [20] ;

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rast.Next(1, 100);
            }

            for (int i = 0; i < sayilar.Length; i++)
            {
   
                if (sayilar[i]%2==0) //tek sayilar icin
                {
                    tSayilar[i] = sayilar[i];                   
                }
                else
                {
                    cSayilar[i] = sayilar[i];                    
                }
            }
            foreach (var item in tSayilar)
            {
                if (item!=0)
                {
                    Console.WriteLine("tek sayilar " + item);
                }          
            }

            foreach (var item in cSayilar)
            {
                if (item != 0)
                {
                    Console.WriteLine("Cift sayilar " + item);
                }
            }

            Console.ReadKey();
        }
    }
}
