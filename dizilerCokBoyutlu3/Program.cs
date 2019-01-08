using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizilerCokBoyutlu3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = new int[4, 2] { { 1, 22 }, { 25, 3}, { 49, 21}, { 31, 47} };

            string[,] dizi2 = new string[3,2] { { "bir", "iki" }, { "3", "4" }, { "a", "true" } };

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.Write(dizi2[i, k] + " -");
                }
                Console.WriteLine(" ");
            }
            //dizideki deger degistirme
            //dizi[0, 1] = 55;
            //Console.WriteLine(dizi[0, 1]);


            Console.ReadKey();            
        }
    }
}
