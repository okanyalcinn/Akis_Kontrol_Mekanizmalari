using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematikselFonksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi = 5.6;
            double kkok = Math.Sqrt(sayi);
            Console.WriteLine(kkok);

            // mutlak deger nasil alirsiniz
            double abbs = Math.Abs(sayi);
            Console.WriteLine(abbs);

            double aci = 50;
            sayi = Math.Sin(aci);
            sayi = Math.Cos(aci);




            Random sira = new Random();
            int sirasayi = sira.Next(1,10);
            Console.WriteLine(sirasayi);




            Console.ReadKey();
        }
    }
}
