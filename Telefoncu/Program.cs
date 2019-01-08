using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20181221_Telefoncu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] telefon = new string[10];
            int[] garantiSorgu = new int[10];
            int[] piyasaDeger = new int[10];
            int[] yeniDeger = new int[10];
            int[] alisDeger = new int[10];
            int[] karDeger = new int[10];
            int para = 5000;


            #region Telefon secimi
            Console.WriteLine("Hangi marka telefonlar almak istersiniz?");
            Console.WriteLine(" sony \n lenovo \n samsung \n asus\n");
            Console.WriteLine("[1] Garantili \n[2] Garantisiz \n[3] Kapali kutu mu istersiniz?");
            Console.WriteLine("Sirasiyla once marka, garanti secimi, alis fiyati");

            for (int i = 0; i < telefon.Length; i++)
            {


                Console.WriteLine("{0}. telefon bilgisini gir", i + 1);
                Console.Write("Marka : ");
                string alTelefon = Convert.ToString(Console.ReadLine());
                telefon[i] = alTelefon; //telefonu diziye ekleme 

                #region Piyasa degeri atama
                string eTelelefon = telefon[i];
                int eGranti = garantiSorgu[i];
                if (eTelelefon == "sony")
                {
                    piyasaDeger[i] = 2000;
                }
                else if (eTelelefon == "samsung")
                {
                    piyasaDeger[i] = 3000;
                }
                else if (eTelelefon == "asus")
                {
                    piyasaDeger[i] = 1500;
                }
                else if (eTelelefon == "lenovo")
                {
                    piyasaDeger[i] = 2500;
                }
                else
                {
                    piyasaDeger[i] = 1000;
                }
            #endregion

            gIstegiSecim:
                Console.Write("Garanti : ");
                int gIstegi = Convert.ToInt32(Console.ReadLine());
                garantiSorgu[i] = gIstegi;//garantiyi diziye ekleme

                if (gIstegi == 1)
                {
                    alisDeger[i] = piyasaDeger[i] - ((piyasaDeger[i] * 40) / 100);
                    yeniDeger[i] = alisDeger[i] + ((alisDeger[i] * 10) / 100);
                    karDeger[i] = yeniDeger[i] - alisDeger[i];
                    garantiSorgu[i] = gIstegi;
                }
                else if (gIstegi == 2)
                {
                    yeniDeger[i] = piyasaDeger[i] - ((piyasaDeger[i] * 50) / 100);
                    alisDeger[i] = piyasaDeger[i] - ((piyasaDeger[i] * 70) / 100);
                    karDeger[i] = yeniDeger[i] - alisDeger[i];
                    garantiSorgu[i] = gIstegi;
                }
                else if (gIstegi == 3)
                {
                    alisDeger[i] = piyasaDeger[i] - ((piyasaDeger[i] * 20) / 100);
                    yeniDeger[i] = piyasaDeger[i];
                    karDeger[i] = yeniDeger[i] - alisDeger[i];
                    garantiSorgu[i] = gIstegi;
                }
                else
                {
                    Console.WriteLine("yanlis secim tekrar seciniz.");
                    goto gIstegiSecim;
                }

                if (para < alisDeger[i]) //yeterli para var mi kontrolu
                {
                    Console.WriteLine("Yeterli paran yok");
                    break;
                }

                #endregion


                #region Kar orani hesaplama

                if (garantiSorgu[i] == 1)
                {
                    //garantili
                    Console.WriteLine("-Piyasa degeri {0} TL. {1} marka telefonu ", piyasaDeger[i], telefon[i]);
                    Console.WriteLine("\tgaranti devam ediyor {0} TL'ye alindi. {1} kârla {2} TL'ye sattı", alisDeger[i], karDeger[i], yeniDeger[i]);
                    para += karDeger[i];
                    Console.WriteLine("  Cepte kalan para {0}", para);
                }

                if (garantiSorgu[i] == 2)
                {
                    //garantisiz
                    Console.WriteLine("-Piyasa degeri {0} TL. {1} marka telefonu ", piyasaDeger[i], telefon[i]);
                    Console.WriteLine("\tgarantisi yok {0} TL'ye alindi. {1} kârla {2} TL'ye sattı", alisDeger[i], karDeger[i], yeniDeger[i]);
                    para = para - alisDeger[i];
                    para += yeniDeger[i];
                    Console.WriteLine("  Cepte kalan para {0}", para);
                }

                if (garantiSorgu[i] == 3)
                {
                    //kapali kutu              
                    Console.WriteLine("-Piyasa degeri {0} TL. {1} marka telefonu ", piyasaDeger[i], telefon[i]);
                    Console.WriteLine("\tkapali kutu {0} TL'ye alindi. {1} kârla {2} TL'ye sattı", alisDeger[i], karDeger[i], yeniDeger[i]);
                    para = para - alisDeger[i];
                    para += yeniDeger[i];
                    Console.WriteLine("  Cepte kalan para {0}", para);
                }

                #endregion
            }

            Console.ReadKey();

        }
    }
}
