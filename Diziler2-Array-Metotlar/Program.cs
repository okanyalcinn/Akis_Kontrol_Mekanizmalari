using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler2_Array_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("index metodu");

            int[] dizi = { 1, 2, 3, 4, 5 };

            int sira = Array.IndexOf(dizi, 2);
            Console.WriteLine(sira);

            char[] c = new char[27];
            int e = 0 ;

            for (char i = 'a'; i <= 'z'; i++)
            {
                e++;
                c[e] = i;
                Console.WriteLine(c[e]);
			}

            Console.WriteLine("Aranan harf");
            char arananKelime = Convert.ToChar(Console.ReadLine());

            int b = Array.LastIndexOf(c, arananKelime);

            if (b!=-1)
            {
                Console.WriteLine("Aranan harf bulundu {0}",b+1);
            }
            else
            {
                Console.WriteLine("ilgili harf yok");
            }
            
            //short() metodu dizi icerisinde numerik ya da alfanumerik siralama yapar
            // 1...n - a...z

            Console.WriteLine("short metodu");
            Random rd = new Random();

            int[] sayilar = new int[5];

            //diziye deger aktarma
            for (int i = 0; i < sayilar.Length; i++)
            {
                //dizi referans adi [dizinin ilgili index numarasi] 
                sayilar[i] = rd.Next(0, 100);
            }

            Array.Sort(sayilar); // kucukten buyuge dogru sirala 

            Console.WriteLine("For ile gosterimi");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            Console.WriteLine("Foreach ile gosterimi");
            foreach(int sayi in sayilar)  //int var object
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine(sayilar.Length+" adet sayi var ");


            Console.WriteLine("reverse metodu");

            char[] harfler = new char[5] {'a','b', 'c', 'd', 'e'};

            for (int i = 0; i < harfler.Length; i++)
            {
                Console.WriteLine(harfler[i]);

            }

            Console.WriteLine("Foreach ile gosterimi");
            Array.Reverse(harfler);

            foreach (char item in harfler)
            {
                Console.WriteLine(item);
            }

            //Copy metodu
            Console.WriteLine("Copy Metodu");

            int[] sayidizi1 = { 1, 2, 3, 4, 5, 6 };

            int[] sayidizi2 = new int[sayidizi1.Length];

            //Array.Copy(sayidizi1,sayidizi2,sayidizi1.Length);

            foreach (var item in sayidizi2)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\nKacinci indexe kadar kopyalayalim");
            int no = Convert.ToInt32(Console.ReadLine());
            Array.Copy(sayidizi1, sayidizi2,no); // istenilen index numarasına kadar kopyalar

            foreach (var item in sayidizi2)
            {
                Console.WriteLine(item);
            }

            //coptTo()

            Console.WriteLine("copyTo();");
            int[] cT1 = { 2, 3, 4, 5, 6, 4, 5 };
            int[] cT2 = new int[cT1.Length + 3];

            cT1.CopyTo(cT2, 2);

            foreach (var item in cT2)
            {
                Console.WriteLine(item);

            }
            */
            Console.WriteLine("--------------------------------------");
            Array d = Array.CreateInstance(typeof(int), 3);
            Random rd1 = new Random();
            int sayi;

            for (int i = 0; i < d.Length; i++)
            {
                sayi = rd1.Next(10, 30);
                d.SetValue(sayi, i);
                //d[i] = sayi;
            }

            foreach (var item in d)
            {
                Console.WriteLine(item);
            }

            //contains() , dizide arama yapmak icin kullanilir
            //druma gore ture ya da false doner

            string[] ad = { "asli", "samet", "metin", "yildirim", "kursat","ayse" };
            
            Console.WriteLine("aradiginiz isim?");
            string aranan = Console.ReadLine();

            int sira = Array.IndexOf(ad, aranan);

            if (ad.Contains(aranan))
            {
                
                Console.WriteLine("Aranan isim bulundu");
                Console.WriteLine(ad[sira]);

            }
            else
            {
                Console.WriteLine("kayit yok");
            }


            // dizi girisi
            string[] girisdizi = new string[5];

            girisdizi[0] = "ali";
            girisdizi[1] = "serkan";
            girisdizi[2] = "metin";
            girisdizi[3] = "tunc";
            //girisdizi[4] = "hakan";

            for (int i = 0; i < girisdizi.Length; i++)
            {
                girisdizi[i] = "demo";
            }

            for (int i = 0; i < girisdizi.Length; i++)
            {
                Console.WriteLine(girisdizi[i]);
            }

            Console.ReadKey();
        }
    }
}
