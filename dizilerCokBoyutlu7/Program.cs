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
            Console.WriteLine("Kac kisiniz");
            int kSayisi = Convert.ToInt32(Console.ReadLine());
            string[,] yolcu_bilgileri = new string[kSayisi,4]; //no , ad, toplam fiyat, bilet turu
                                                              //0                   1
                                                          //0        1          0      1 
            string[,] bilet_turu = new string[2, 2] { {"business","economy" },{"700","300" } }; // tur,fiyat economy = 300 ₺ bussiness = 700 ₺
            for (int i = 0; i < yolcu_bilgileri.GetLength(0); i++)
            {
                yolcu_bilgileri[i, 0] = i.ToString();
            }

            for (int k = 0; k < yolcu_bilgileri.GetLength(0); k++)
                {
                int kac = Convert.ToInt32( yolcu_bilgileri[k, 0]);
                    Console.WriteLine("{0}. yolcunun adini giriniz", kac+1);
                    yolcu_bilgileri[k, 1] = Console.ReadLine().ToString();
                biletsecim:
                    Console.WriteLine("hangi siniftan istersiniz ? \n [1] bussines \n [2] economy");
                    int sec = Convert.ToInt32(Console.ReadLine());
                    switch (sec)
                    {
                        case 1:
                            Console.WriteLine("{0} TL'lik bileti satin almak istiyor musun?", bilet_turu[1, 0]);
                        evethayir:
                            string biletiAl = Console.ReadLine().ToString();
                            if (biletiAl == "evet")
                            {
                                yolcu_bilgileri[k, 3] = bilet_turu[0, 0];// turu
                                yolcu_bilgileri[k, 2] = bilet_turu[1, 0];// fiyati
                                break;
                            }
                            else if (biletiAl == "hayir")
                                goto biletsecim;
                            else
                            {
                                Console.WriteLine("Yanlis deger girdiniz lutfen evet veya hayir yaziniz");
                                goto evethayir;
                            }
                            break;
                        case 2:
                            Console.WriteLine("{0} TL'lik bileti satin almak istiyor musun?", bilet_turu[1, 1]);
                        evethayir2:
                            string biletiAl2 = Console.ReadLine().ToString();
                            if (biletiAl2 == "evet")
                            {
                                yolcu_bilgileri[k, 3] = bilet_turu[0, 1]; // turu
                                yolcu_bilgileri[k, 2] = bilet_turu[1, 1]; // fiyati
                                break;
                            }
                            else if (biletiAl2 == "hayir")
                                goto biletsecim;
                            else
                            {
                                Console.WriteLine("Yanlis deger girdiniz lutfen evet veya hayir yaziniz");
                                goto evethayir2;
                            }
                            break;
                        default:
                            Console.WriteLine("bir sey oldu");
                            break;
                    }
                }



            Console.WriteLine("kimsin");
            bool ara = false;
            string aranan = Console.ReadLine();
            for (int i = 0; i < yolcu_bilgileri.GetLength(0) ; i++)
            {
                ara = yolcu_bilgileri[i, 1].Contains(aranan);
                if (ara==true)
                {
                    Console.WriteLine("{0} bileti {1} TL'ye te gecen gun almistin hatirlarsan",yolcu_bilgileri[i,3], yolcu_bilgileri[i,2]);
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
