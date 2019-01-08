using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizilerCokBoyutlu7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int say1 = 0;
            int say2 = 0;
            char[] ucakKoltuk = new char[40]; // 40 satir 2 sutun sutunlar sol taraf sag taraf gibi ayrilacak
            for (int i = 0; i < ucakKoltuk.Length; i++)
            {
                ucakKoltuk[i] = Convert.ToChar(i);

            }
            Console.WriteLine("\n\n\t\t  Kod Ucagı Simulasyonuna Hosgeldiniz");
            Console.WriteLine("\t---------------------------------------------------------");
            Console.Write("\t  ");
            for (int i = 0; i < ucakKoltuk.Length; i++)
            {
                if (ucakKoltuk[i] % 2 == 0 )
                {
                    Console.Write(i + " ");
                }
                else if(ucakKoltuk[i] == '_')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(i + " ");
                }                
            }
            Console.WriteLine("");
            Console.Write("\t ");
            for (int i = 0; i < ucakKoltuk.Length; i++)
            { 
                if (ucakKoltuk[i] % 2 == 1)
                {
                    Console.Write(i + " ");
                }
                
               
            }
             Console.WriteLine("");

            Console.WriteLine("Kac kisiniz");
            int kSayisi = Convert.ToInt32(Console.ReadLine());
            string[,] yolcu_bilgileri = new string[kSayisi, 5]; //no , ad, fiyat, bilet turu, koltuk no
                                                                //0                   1
                                                                //0          1            0      1 
            string[,] bilet_turu = new string[2, 2] { { "business", "economy" }, { "700", "300" } }; // tur,fiyat economy = 300 ₺ bussiness = 700 ₺

            int busSay = 0;
            int ecoSay = 0;

            for (int i = 0; i < yolcu_bilgileri.GetLength(0); i++)
            {
                yolcu_bilgileri[i, 0] = i.ToString();
            }

            int koltukNo = random.Next(1, 40);
            int koltuksec = 0;
            for (int k = 0; k < yolcu_bilgileri.GetLength(0); k++)
            {
                int kac = Convert.ToInt32(yolcu_bilgileri[k, 0]);
                Console.WriteLine("{0}. yolcunun adini giriniz", kac + 1);
                yolcu_bilgileri[k, 1] = Console.ReadLine().ToString();
                Console.WriteLine("hangi siniftan istersiniz ? \n [1] bussines 700 TL \n [2] economy 300 TL");
                int sec = Convert.ToInt32(Console.ReadLine());
                switch (sec)
                {
                    case 1:
                        yolcu_bilgileri[k, 3] = bilet_turu[0, 0];// turu
                        yolcu_bilgileri[k, 2] = bilet_turu[1, 0];// fiyati
                        busSay++;
                        break;
                    case 2:
                        yolcu_bilgileri[k, 3] = bilet_turu[0, 1]; // turu
                        yolcu_bilgileri[k, 2] = bilet_turu[1, 1]; // fiyati
                        ecoSay++;
                        break;
                    default:
                        Console.WriteLine("bir sey oldu ");
                        break;
                }


                Console.WriteLine("Koltuk seciniz ?");
            secim:
                koltuksec = Int32.Parse(Console.ReadLine());
                    if (ucakKoltuk[koltuksec] != '_')
                    {
                        Console.WriteLine("Koltuk seciminiz basarili");
                        ucakKoltuk[koltuksec] = '_';
                    }
                    else if(ucakKoltuk[koltuksec] == '_')
                    {
                        Console.WriteLine("Dolu koltuk sectiniz. Tekrar deneyiniz");
                        goto secim;
                    }
                    else
                    {
                        Console.WriteLine("Bir şey oldu");
                    }  
            }
            int biletToplam = (busSay * Int32.Parse(bilet_turu[1, 0])) + (ecoSay * Int32.Parse(bilet_turu[1, 1])); // Int32.Parse integer a cevirsin diye
            Console.WriteLine("Tebrikler satin alma isleminiz gerceklesmistir");
            Console.WriteLine("\t{0} adet Business \n\t{1} adet Economy \n\tToplam tutar: {2} TL", busSay, ecoSay, biletToplam);

            Console.Write("\t  ");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < ucakKoltuk.Length; i++)
            {
                if (ucakKoltuk[i] % 2 == 0 && ucakKoltuk[i] != 0)
                {
                    Console.Write(i + " ");
                }
                else if (ucakKoltuk[i] == '_')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(i + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.WriteLine("");
            Console.Write("\t ");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < ucakKoltuk.Length; i++)
            {
                if (ucakKoltuk[i] % 2 == 1)
                {                  
                    Console.Write(i + " ");
                }
                
            }
            Console.WriteLine("");
            Console.WriteLine("kimsin");
            bool ara = false;
            string aranan = Console.ReadLine();
            for (int i = 0; i < yolcu_bilgileri.GetLength(0); i++)
            {
                ara = yolcu_bilgileri[i, 1].Contains(aranan);
                if (ara == true)
                {
                    Console.WriteLine("{0} sinifli {1} no'lu koltuk {2} TL tutarli bilet almissiniz", yolcu_bilgileri[i, 3].ToUpper(), yolcu_bilgileri[i, 4], yolcu_bilgileri[i, 2]);
                    break;
                }
            }
            if (ara == false)
            {
                Console.WriteLine("bilet almamissin cik disari");
            }
            Console.ReadKey();
        }
    }
}
