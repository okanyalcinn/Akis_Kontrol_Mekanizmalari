using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAkisKontol2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            int faktor = 1;

            Console.WriteLine("Bir Sayi Giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= sayi; i++)
            {
                faktor *= i; // faktor = faktor * i;

            }

            Console.WriteLine("{0} sayısının faktoriyeli: {1}",sayi,faktor);

            Console.ReadKey();
        }
    }
}
