using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizilerUcboyutlu2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,,] sinif = new string[4, 2, 2]
            {
                { {"samet","asli" }, {"kursat","mehmet" } },
                { {"okan","ugur" }, {"metin","ahmet" } },
                { {"fatih","halis" }, {"eda","fatma" } },
                { {"volkan","bos" }, {"emre","yildirim" } },
            };

            foreach (var item in sinif)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < sinif.GetLength(0); i++)
            {
                for (int k = 0; k < sinif.GetLength(1); k++)
                {
                    for (int m = 0; m < sinif.GetLength(2); m++)
                    {
                        Console.Write(sinif[i,k,m]+" ");
                    }
                    Console.Write(" | ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
