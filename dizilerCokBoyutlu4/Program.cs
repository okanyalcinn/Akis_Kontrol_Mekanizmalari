using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizilerCokBoyutlu4
{
    class Program
    {
        static void Main(string[] args)
        {   
                            //satir , sutun
            int[,] dizi = new int[4, 2]; // 4 ve 2'ye derinlik diyoruz

            //GetLenth dizi uzunlugu alma
            //dizi.GetLength(0) [0,1] atiri yani ilk degeri alir 
            //dizi.GetLength(1) [0,1] sutun yani ikinci degeri alir 

            for (int i = 0; i < dizi.GetLength(0); i++) //satır arttirma 
            {
                for (int k = 0; k < dizi.GetLength(1); k++)// sutun arttirma
                {
                    dizi[i, k] = i + k + 5;
                }
            }

            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int k = 0; k < dizi.GetLength(1); k++)
                {
                    Console.Write("- " + dizi[i, k]);
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
