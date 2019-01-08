using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            //kelime tahmin oyunu -do while 
            // 5 kelime var bu kelimeyi hafizada tutacak bize soracak bunu 
            //hakkimiz sinirlari icerisinde tekrarlayacak bilemez isek yanacagiz
            // kelime, soru, cevap, hak

            bool kontrol = false;
            string kelime = "";
            string cevap = "";
            byte hak = 3;
            int soruSirasi;
            Random sira = new Random();
            soruSirasi = sira.Next(1, 5);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Dort ana elementten birini tahmin et \n Hava\n Ateş\n Su\n Toprak ");

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Tahmin et dostum");
                cevap = Console.ReadLine();

                switch (soruSirasi)
                {
                    case 1:
                        kelime = "hava";
                        break;
                    case 2:
                        kelime = "su";
                        break;
                    case 3:
                        kelime = "topral";
                        break;
                    case 4:
                        kelime = "ates";
                        break;
                }

                if (cevap == kelime)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Dogru bildin paşam :)");
                    kontrol = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("yanlis bildin !!!!!!!!!!!!!!!!!!!!!!!!! \n {0} Hakkin kaldi",hak);
                    hak--;
                    if (hak > 0)
                    {
                        kontrol = true;
                    }
                    else
                    {
                        break;
                    }
                }

            } while (kontrol);


            Console.ReadKey();
        }
    }
}
