using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizilerUcBoyutlu3
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetUpperBound en yuksek index uzunlugunu hedef alıyor
            //GetLongLength 

            Array d = Array.CreateInstance(typeof(int), 5, 4, 3);

            for (int i = 0; i < d.GetLongLength(0); i++) //GetUpperBound(0) ta kullanılabilir 
            {
                for (int j = 0; j < d.GetLongLength(1); j++)
                {
                    for (int k = 0; k < d.GetLongLength(2); k++)
                    {
                        d.SetValue(i + j + k, i, j, k);
                    }
                }
            }

            for (int i = 0; i < d.GetLongLength(0); i++)// GetUpperBound(0)+1 yapmak gerekir 
            {
                for (int j = 0; j < d.GetLongLength(1); j++)
                {
                    for (int k = 0; k < d.GetLongLength(2); k++)
                    {
                        Console.Write(d.GetValue(i,j,k)+" - ");
                    }
                    Console.Write("\t");   
                }
                Console.WriteLine("");
            }


            Console.WriteLine("\n"+d.GetValue(4, 0, 2));

            Console.ReadKey();
        }
    }
}
