using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20181224_ikiBoyutluDiziOgrenciNotOrtalamasi
{
    class Program
    {
        static void Main(string[] args)
        {                               //satir,sutun
            string[,] ogrenciler = new string[2, 3];
            double[,] matematik = new double[2, 2];
            double[,] kimya = new double[2, 2];
            for (int x = 0; x < ogrenciler.GetLength(0); x++)
            {
                Console.Write("\n Notlarini girecegin ogrencinin ismini yaz     ");
                ogrenciler[x, 0] = Console.ReadLine();
                for (int y = 0; y < matematik.GetLength(1); y++)
                {
                    Console.Write("     Matematik {0} notunu gir        ", y + 1);
                    matematik[x, y] = Convert.ToInt32(Console.ReadLine());
                }
                for (int w = 0; w < kimya.GetLength(1); w++)
                {
                    Console.Write("     kimya {0} notunu gir        ", w + 1);
                    kimya[x, w] = Convert.ToInt32(Console.ReadLine());
                }
                //kimya ve matematik dizisinden veri cekip ortalamasini alip ogrenciler tablosuna aktarma
                ogrenciler[x, 1] = Convert.ToString((kimya[x, 0] + kimya[x, 1]) / 2).ToString();
                ogrenciler[x, 2] = Convert.ToString((matematik[x, 0] + matematik[x, 1]) / 2).ToString();
            }
            Console.WriteLine("\nogrenciler tablosu");
            Console.WriteLine("Adi  |kimya   |mat");
            for (int l = 0; l < ogrenciler.GetLength(0); l++)
            {
                for (int k = 0; k < ogrenciler.GetLength(1); k++)
                {
                    Console.Write(ogrenciler[l, k] + "     ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\nkimya tablosu");
            Console.WriteLine("not1  |not2");
            for (int l = 0; l < kimya.GetLength(0); l++)
            {
                for (int k = 0; k < kimya.GetLength(1); k++)
                {
                    Console.Write(kimya[l, k] + "       ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\nmatematik tablosu");
            Console.WriteLine("not1  |not2");
            for (int l = 0; l < matematik.GetLength(0); l++)
            {
                for (int k = 0; k < matematik.GetLength(1); k++)
                {
                    Console.Write(matematik[l, k] + "       ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Hangi ogrencinin bilgisini cekmek istersin?");
            bool ogrencivarmi = false;
            string aranan = Console.ReadLine();
            for (int i = 0; i < ogrenciler.GetLength(0); i++)
            {
                ogrencivarmi = ogrenciler[i, 0].Contains(aranan);    //contains() true ya da false geri gonderir. ilgili dizide ogrenci var mi ? soruyoruz 
                if (ogrencivarmi == true)
                {
                    Console.WriteLine("{0}'nin \n   kimya ortalamasi:{1} \n   matematik ortalamasi:{2} ", aranan, ogrenciler[i, 1], ogrenciler[i, 2]);
                    break;
                }
            }
            if (ogrencivarmi == false)
            {
                Console.WriteLine("{0} isimli ogrenci yok", aranan);
            }


            Console.ReadKey();
        }
    }
}
