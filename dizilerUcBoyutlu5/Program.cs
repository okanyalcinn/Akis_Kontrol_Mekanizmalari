using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_cokboyutlu_3boyutlu5_dogrusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir okul oluşturuyoruz sınıflar belirleniyor kaç kişilik belirleniyor sonra dizi oluşturuluyor 
            //öğrenci ekleniyor ve siliniyor

            Console.WriteLine("Okulda kaç kişi var");
            int sOgrenci = Convert.ToInt32(Console.ReadLine());
            int sinifN;
            int sinifA;
            int[] bossira = new int[10];
            int bos = 0;
            int sayac = 0;
            string[][] sinif = new string[sOgrenci][];

            for (int i = 0; i < sOgrenci; i++)
            {
                Console.WriteLine(i + 1 + "Okulda kaç sınıf var");
                sinifN = Convert.ToInt32(Console.ReadLine());

                sinif[i] = new string[sinifN];
            }

            for (int i = 0; i < sinif.GetLength(0); i++)
            {
                Console.WriteLine(i + 1 + "Sınıfta kaç kişi var");
                sinifA = Convert.ToInt32(Console.ReadLine());

                sinif[i] = new string[sinifA];
            }

            for (int i = 0; i < sinif.GetLength(0); i++)
            {
                for (int j = 0; j < sinif.GetLength(1); j++)
                {
                    sinif[i][j] = "Boş";
                }

            }

            Console.WriteLine("");
            int talep = Convert.ToInt32(Console.ReadLine());

            // ekleme , silme

            if (talep == 1)
            {
                Console.WriteLine("Kayıt Listeleme");
                for (int i = 0; i < sinif[i].Length; i++)
                {
                    Console.WriteLine(i + 1 + ".Sınıf");
                    for (int j = 0; j < sinif[j].Length; j++)
                    {
                        Console.WriteLine(sinif[i][j] + "\t");
                    }
                }
                Console.WriteLine("Öğrenci hangi sınıfa eklensin");
                int kayitSinifi = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Öğrenci Hangi Sıraya Kaydolacak");

                int kayitSira = Convert.ToInt32(Console.ReadLine());

                kayitSinifi += kayitSinifi;
                kayitSira += kayitSira;

                if (sinif[kayitSinifi][kayitSira] == "Boş")
                {
                    Console.WriteLine("Kaydolacak öğrenciyi girin");
                    string ogrenciAd = Console.ReadLine();
                    sinif[kayitSinifi][kayitSira] = ogrenciAd;

                }
                else
                {
                    Console.WriteLine("O sıra dolu");
                    for (int i = 0; i < sinif[kayitSinifi].Length; i++)
                    {
                        if (true)
                        {
                            bos++;
                            bossira[sayac] = i;

                        }


                    }
                }

            }
	//program eksik olabilir hoca tamamen bitirmemisti
            Console.ReadKey();
        }
    }
}
