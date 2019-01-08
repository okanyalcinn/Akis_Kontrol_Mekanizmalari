using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAkisKontrol4
{
    class Program
    {
        static void Main(string[] args)
        {
            int enBuyuk = 0;
            int enKucuk = 0;
            int sayi = 0;


            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i + ". sayi gir");
                sayi = Convert.ToInt32(Console.ReadLine());

                if ((enBuyuk==0 && enKucuk==0) || (i==1))
                {
                    enKucuk = sayi;
                    enBuyuk = sayi;
                }

                //En buyuk sayi girilen ilk deger olarak kalbul edilir 
                //sonraki girilen sayilar var olan en buyuk sayi ile kiyaslanir
                if (enBuyuk < sayi)
                {
                    enBuyuk = sayi;
                }

                if (enKucuk > sayi)
                {
                    enKucuk = sayi;
                }
            }

            Console.WriteLine("En Kucuk Sayiniz {0} \nEn Buyuk Sayiniz {1}",enKucuk, enBuyuk);

            Console.ReadKey();
        }
    }
}
