using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenci ={ "okan","fatih","ugur","asli", "samet","kursat","mehmet","halis","metin"};
            int[] not1 = new int [9];
            int[] not2 = new int [9];
            int[] ortalama = new int[9];
            int[] durum = new int[9];

            for (int i = 0; i < ogrenci.Length; i++)
            {
                Console.WriteLine("{0}'nın 1.Notunu giriniz",ogrenci[i]);
                int not1gir = Convert.ToInt32( Console.ReadLine() );
                not1[i] = not1gir;

                Console.WriteLine("{0}'nın 2.Notunu giriniz", ogrenci[i]);
                int not2gir = Convert.ToInt32(Console.ReadLine());
                not1[i] = not2gir;

                int notOrtalama = (not1gir + not2gir) / 2;
                ortalama[i] = notOrtalama;

                if (ortalama[i] >75)
                {
                    durum[i] = 1;
                }
                else if (ortalama[i] > 50 && durum[i] <75)
                {
                    durum[i] = 2;
                }
                else if (ortalama[i] > 25 && durum[i] < 50)
                {
                    durum[i] = 3;
                }
                else if(ortalama[i] >0 && durum[i] < 25)
                {
                    durum[i] = 4;
                }   
            }

            Console.WriteLine("\nCok iyiler grubu");
            for (int i = 0; i < ogrenci.Length; i++)
            {
                if (durum[i]==1)
                {
                    Console.Write(" "+ogrenci[i] + "ortalamasi "+ ortalama[i]);
                }
            }
            Console.WriteLine("\n Iyiler grubu");
            for (int i = 0; i < ogrenci.Length; i++)
            {
                if (durum[i] == 2 )
                {
                    Console.Write(" " + ogrenci[i] + "ortalamasi " + ortalama[i]);
                }
            }
            Console.WriteLine("\n Kotuler grubu");
            for (int i = 0; i < ogrenci.Length; i++)
            {
                if (durum[i] == 3)
                {
                    Console.Write(" " + ogrenci[i] + "ortalamasi " + ortalama[i]);
                }
            }
            Console.WriteLine("\n Cok kotuler grubu");
            for (int i = 0; i < ogrenci.Length; i++)
            {
                if (durum[i] == 4)
                {
                    Console.Write(" " + ogrenci[i] + "ortalamasi " + ortalama[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
