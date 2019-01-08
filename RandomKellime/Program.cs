using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomKellime
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            char[] alfabe = new char[26];
            string[] kelimeler = new string[5];
            char hAt;
            int index = 0;

            //alfabeyi diziye aktarma
            for (char k = 'a'; k <= 'z'; k++)
            {
                hAt = k;
                alfabe[index] = hAt;
                index++;
            }

            //kelime olusturma
            for (int i = 0; i < kelimeler.Length; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Random hAtama = new Random();
                    index = hAtama.Next(1,26);
                    kelimeler[i] += index;
                }
                
            }



            foreach (var item in alfabe)
            {
                Console.WriteLine(item);
            }
            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
