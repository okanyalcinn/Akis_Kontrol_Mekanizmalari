using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAkisKontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            string mesaj = "Gunaydin";

            int sayi = 0;

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(mesaj);
                Console.WriteLine(i);

                sayi += i;
            }

            Console.WriteLine(sayi);

            Console.ReadKey();
        }
    }
}
