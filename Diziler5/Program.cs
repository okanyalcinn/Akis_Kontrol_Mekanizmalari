using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehir = new string[]
            {
                   "Ankara",
                   "Istanbul",
                   "Izmir",
                   "Adana"
            };

            string s = "Izmir";
            int sira = Array.IndexOf(sehir, s);

            if (sira!=-1) // dizi indexine ait elemani bulursa index numarasini degilse olmadigini isaret -1 doner
            {
                Console.WriteLine("deger bulundu {0}",sira);
                Console.WriteLine(sehir[sira]);
            }
            else
            {
                Console.WriteLine("deger bulunamadi ");
            }


            Console.ReadKey();
        }
    }
}
