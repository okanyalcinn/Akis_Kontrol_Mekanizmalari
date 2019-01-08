using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileAkisKontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = false;
            int i = 3;

            Console.WriteLine("sayi gir");
            int s = int.Parse(Console.ReadLine());

            if (s==i)
            {
                kontrol = true;
            }

            do
            {
                for (int k = 0; i < 5; k++)
                {
                    Console.WriteLine("Merhaba");
                }
                kontrol = false;
                
                
            }
            while (kontrol);





            Console.ReadKey();
        }
    }
}
