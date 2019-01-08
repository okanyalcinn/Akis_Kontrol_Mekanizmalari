using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            
           string[] isimler = new string[5];
           int[] not1 = new int[5];
           int[] not2 = new int[5];
           int[] not3 = new int[5];
           int[] ortalama = new int[5];
           string b = "";

           for (int i = 0; i < isimler.Length; i++)
           {
               Console.WriteLine("Ogrenci isimlerini sirayla giriniz");
               isimler[i] = Console.ReadLine();
           }

           for (int i = 0; i < isimler.Length; i++)
           {
               b = isimler[i]; 
               Console.WriteLine("{0} ogrencinin 1. notunu giriniz",b);
               not1[i] = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("{0} ogrencinin 2. notunu giriniz", b);
               not2[i] = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("{0} ogrencinin 3. notunu giriniz", b);
               not3[i] = Convert.ToInt32(Console.ReadLine());
           }

           for (int i = 0; i < isimler.Length; i++)
           {
               b = isimler[i];
               ortalama[i] = (not1[i] + not2[i] + not3[i]) / 3;
               int c = ortalama[i];
               Console.WriteLine("{0} ogrencinin 3 notununun ortalamasi {1}", b, c);

           }
           

            Console.ReadKey();
        }
    }
}
