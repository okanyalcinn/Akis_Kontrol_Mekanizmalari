using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizilerCokBoyutlu5_turler
{
    class Program
    {
        static void Main(string[] args)
        {
            //rectangle
            int[,] rdizi = new int[2, 5] { { 1, 2, 3, 5, 6 }, { 1, 5, 9, 5, 6 } };

            //jagged dizi = her bir satir icin new int[] referans tanimlamasi yeniden kullanilir
            int[][] jdizi =
            {
                new int[] {1,2,3},
                new int[] {2,3,4}
            };

            //bos ve derinlikleri verilmis
            int[,] rdizi2 = new int[2, 5];

            //createInstance
            Array.CreateInstance(typeof(int), 4,4);


            Console.ReadKey();
        }
    }
}
