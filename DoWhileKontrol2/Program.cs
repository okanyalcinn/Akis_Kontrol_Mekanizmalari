using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileKontrol2
{
    class Program
    {
        static void Main(string[] args)
        {
            //girilen sayinin asal olup olmadigini bulma
            int sayi = 0;
            int i = 2;
            bool kontrol = true;

            Console.WriteLine("sayi giriniz");
            sayi = int.Parse(Console.ReadLine());

            do
            {

                if (sayi % i == 0)
                {
                    kontrol = false;
                    Console.WriteLine("Asal sayi degil");
                    break;
                }
                else
                {
                    Console.WriteLine("Asal sayidir");
                    break;
                }
                
            }
            while (kontrol);

            

            Console.ReadKey();
        }
    }
}
