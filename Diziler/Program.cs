using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    // dizi ayni tipli degerlerin bir arada tutuldugu bir temsilcinin bulunduğu referans tipli bir yapidir.
    //diziler -- ayni turden degerler alabilirler.
    //-- dizi uzunluklari sabit degismez.
    //-- dizinin ilk index numarası 0 -son eleman sayısı -1 şeklindedir. 
    // dizi elemanlarina index numaralarina gore erisim saglanır.
    // diziler referans tiplidir. Diziye atilan veriler bellegin heap kısmında tutulur, diziye erisim icin olusturulan degisken bellegin stacks bolgesinde tutulur.
    // dizi deger IndexOf ile arama yapildiginda eger ifade varsa ilgili indexi dondurur, yok ise - 1 degerini dondurur.
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi1 = new int[10];

            int[] dizi2;

            Array dizi3 = Array.CreateInstance(typeof(int),3);

            int[] dizi4 = { 1, 2, 3, 4 };

            Console.WriteLine("dizi uzunlugu giriniz");

            int a = Convert.ToInt32(Console.ReadLine());

            dizi2 = new int[a]; //dizi2 = new int[a+2];

            // diziye deger girme
            dizi2[5] = 20;



            Console.ReadKey();
        }
    }
}
