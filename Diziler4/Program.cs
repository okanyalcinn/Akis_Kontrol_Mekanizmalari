using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar1 = new int[5];
            int[] sayilar2 = new int[5];
            int[] toplamdizi = new int[5];

            #region deger_blogu

            for (int i = 0; i < sayilar1.Length; i++)
            {
                Console.Write("1. dizinin {0}. sayiyi gir ", i);
                sayilar1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < sayilar2.Length; i++)
            {
                Console.Write("2. dizinin {0}. sayiyi gir ", i);
                sayilar2[i] = Convert.ToInt32(Console.ReadLine());
            }

            #endregion

            #region islemler
            for (int i = 0; i < toplamdizi.Length; i++)
            {
                //toplamdizi dizisine sayilar1 ve sayilar2 dizinin index numaralarini karsilik gelen degerleri toplatıp. 
                //toplamdizi dizisin i'ninci indexine yukleme islemi yapiyoruz
                toplamdizi[i] = sayilar1[i] + sayilar2[i];
                Console.WriteLine(sayilar2[i] + " + " + sayilar2[i]+ " = " +toplamdizi[i]);
            }
            #endregion

            Console.ReadKey();
        }
    }
}
