using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchAkisKotrol2
{
    class Program
    {
        static void Main(string[] args)
        {
            int vize = 0, final = 0, ort = 0;
            string h="";

        baslangic:

            Console.WriteLine("vize notunuzu giriniz");
            vize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("final notunuzu giriniz");
            final = Convert.ToInt32(Console.ReadLine());
            ort = (vize + final) / 2;

            if ((vize > 100) || (final > 100))
                {
                Console.WriteLine("Yanlis puanlama girisi yaptiniz");
                goto baslangic;
            }
            else
            {
                if (ort < 24)
                {
                    h = "FF";
                }
                else if ((ort > 25) && (ort < 49))
                {
                    h = "FD";
                }
                else if ((ort > 50) && (ort < 100))
                {
                    h = "DD";
                }
            }    

            switch (h)
            {
                case "FF" :
                    Console.WriteLine("Harf Notunuz: {0} Ortalamaniz: {1} Sartsiz Kaldiniz", h,ort);
                    break;
                case "FD":
                    Console.WriteLine("Harf Notunuz: {0} Ortalamaniz: {1} Sartli gectiniz", h, ort);
                    break;
                case "DD":
                    Console.WriteLine("Harf Notunuz: {0} Ortalamaniz: {1} gectiniz", h, ort); ;
                    break;

                default:
                    break;
            }


            Console.ReadKey();
        }
    }
}
