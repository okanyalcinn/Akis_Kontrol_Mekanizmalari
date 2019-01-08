using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAkisKontrol3
{
    class Program
    {
        static void Main(string[] args)
        {
            char harf;

            for (int i = 'A'; i <= 'Z'; i++)
            {
                harf =(char) i;
                Console.WriteLine("{0} ın ASCI kodu: {1}",harf,i); 
            }

            Console.ReadKey();
        }
    }
}
