using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = "hava soğuk";

            int hSayisi = metin.Length;
            Console.WriteLine(hSayisi);

            int h = "deneme".Length;
            Console.WriteLine(h);

            // IndexOF / bir metinin aranan harfinin index numarasını dondurur. Yoksa geriye -1 dondurur
            int indexOF = metin.IndexOf('v'); 
            Console.WriteLine(indexOF);

            int lstIndexOF = metin.LastIndexOf('u');
            Console.WriteLine(lstIndexOF);

            //remove(); // iki turlu kullanimi var. ondan sonrakileri siler 
            //2.kullanim secenekte verdigin araligi siler

            string rm = metin.Remove(3);
            Console.WriteLine(rm);
            string rm2 = metin.Remove(0,1); // 0  baslangic ondan sonraki silinecek karakter sayisi 1
            Console.WriteLine(rm2);

            //subString(); // 2turlu kullanimi var. birinde diger verinin ondan sonraki kısmını alir tamamini kullanir
            //baslangic bitis degerlerini kullanir

            string kelime = "Merhaba Nasilsin";
            string sbString = kelime.Substring(8);
            Console.WriteLine(sbString);
            string sbString1 = kelime.Substring(3,6); // 3 dahil + 6 dahil
            Console.WriteLine(sbString1);

            //replace() // degisim sagliyor.
            string kelime1 = kelime.Replace("Nasilsin","iyiyim");
            Console.WriteLine(kelime1);

            //ToLower TuUpper // buyuk kucuk harf donusumu saglar
            string kelime3 = kelime1.ToUpper();
            Console.WriteLine(kelime3);
            string kelime4 = kelime1.ToLower();
            Console.WriteLine(kelime4);

            //trim bosluk silme
            string trm = "  odalar ";
            string tr = trm.Trim();
            Console.WriteLine(tr);


            string trmSyart = trm.TrimStart(); // bastaki bosluklari siler
            Console.WriteLine(trmSyart);
            string trmEnd = trm.TrimEnd(); //sondaki bosluklari siler
            Console.WriteLine(trmEnd);

            //Compare() //kelime9 onundeki kelime 10 siralama duzenine gore -1 
            //kelime 9 ayni konumda kelime 10 siralama duzeninde ise 0 sonucunu verir
            //kelime 9 geriye dogru kelime10 siralama duzeninde ise 1 sonucunu verir
            string kelime9 = "wereer";
            string kelime10 = "wereer";

            string kelime11 = String.Compare(kelime9, kelime10).ToString();
            Console.WriteLine(kelime11);

            //Concat() kelime birlestirme

            string a = "Metin";
            string b = "TASLIK";
            Console.WriteLine(String.Concat(a, b));

            Console.WriteLine("Yeni ad gir"); ;
            //string yeni = Console.ReadLine();
            //a = String.Copy(yeni);

            //Equals iki ifadeyi karsilastirip geri donus var true yoksa false degerini dondurur
            string e = "mekan";
            string e1 = "mekan";
            bool eq = String.Equals(e, e1);

            if(eq)
            {
                Console.WriteLine(e);

            }
            else
            {
                Console.WriteLine("deger yok");
            }


            //insert 
            string i = "hava";
            string i2 = "da";

            string butun = i.Insert(4,i2);
            Console.WriteLine(butun);




            Console.ReadKey();
        }
    }
}
