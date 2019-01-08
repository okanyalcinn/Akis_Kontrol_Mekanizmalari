using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizilerUcBoyutlu4
{
    class Program
    {
        static void Main(string[] args)
        {
            //şoför osman, ali | şehir Ankara İstanbul | yemek turu soguk sıcak

            string[,,] otobus = new string[1, 3, 2];
            //{
            //    { {1, 1}, {1, 2}, {1,1} },
            //};

            Random rd = new Random();
            string sofor = "";
            string sehir = "";
            string yemek = "";

            Console.WriteLine("Sehir Yemek Sofor ");

            for (int i = 0; i <= otobus.GetUpperBound(0); i++)
            {
                switch (i)
                {
                    case 0 : sehir = "Ankara"; break;
                    case 1: sehir = "Istanbul"; break;
                }
                for (int j = 0; j <= otobus.GetUpperBound(1) ; j++)
                {
                    switch (j)
                    {
                        case 0: yemek = "sicak"; break;
                        case 1: yemek = "soguk"; break;
                    }
                    for (int k = 0; k <= otobus.GetUpperBound(2); k++)
                    {
                        switch (k)
                        {
                            case 0: sofor = "Ali"; break;
                            case 1: sofor = "Osman"; break;
                        }
                        otobus[i, j, k] = sehir + yemek + sofor;
                        Console.WriteLine(otobus[i,j,k]+"\t");
                        Console.WriteLine("");
                    }
                    Console.Write("");
                }
                Console.WriteLine("");
            }

             
            Console.ReadKey();
        }
    }
}
