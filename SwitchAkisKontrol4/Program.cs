using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchAkisKontrol4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangi ay");


            int ay = Convert.ToInt32(Console.ReadLine());

            switch (ay)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("kis mevsimi");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Ilkbahar mevsimi");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimi");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimi");
                    break;

                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
