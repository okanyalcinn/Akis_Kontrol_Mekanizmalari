using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifAkisKontrol2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mesaj Yazınız:");

            string deger = Console.ReadLine();

            // Ayni tip degiskenler ve ifadeler karsilastirabilirsiniz
            if (deger == "merhaba")
            {
                Console.WriteLine("Dogru giris");
            }
            else
            {
                Console.WriteLine("giris yanlis");
            }

            Console.ReadKey();
        }
    }
}
