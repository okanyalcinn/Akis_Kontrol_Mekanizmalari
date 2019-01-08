using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizilerCokBoyutlu
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi.lenght kullanilmiyor
            //int[,] dizi = new int[x,y];  x=satir y=sutun

            //0 ile 100 arasindaki sayilardan 3,5,7,9 a bolunen sayilari listele

            int[,] sayilar = new int[4,100]; //sayilar dizisi iki boyutlu birincil uzunluk 4 elemanli ikincil uzunluk seklinde

            for (int i = 0; i < 100; i++)// sutun sayisini arttirsin diye, yani x i
            {                                 
                for (int k = 0; k < 4; k++) // satir sayisini arttirsin diye, yani y i
                {
                    if (i % 3 == 0)
                    {
                        sayilar[k, i] = i;
                    }
                    if (i % 5 == 0)
                    {
                        sayilar[k, i] = i;
                    }
                    if (i % 7 == 0)
                    {
                        sayilar[k, i] = i;
                    }
                    if (i % 9 == 0)
                    {
                        sayilar[k, i] = i;
                    }
                }
            }


            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i + "\t" + sayilar[0, i] + " - - " + sayilar[1, i] + " - - " + sayilar[2, i] + " - - " + sayilar[3, i]);
            }


            Console.ReadKey();
        }
    }
}
