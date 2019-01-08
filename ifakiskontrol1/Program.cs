using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifakiskontrol1
{
    class Program
    {
        //ana metod

        /// <summary>
        /// ana metodumuz
        /// if(sart)
        /// {
        /// sartlar...
        /// }
        /// else
        /// {
        /// şartlar
        /// }
        /// değişken tipler
        /// 
        /// object i = null;
        /// var i;
        /// 
        /// int i= 0;
        /// float i = 3.2F;
        /// double i = 3.5;
        /// decimal i = 123;
        /// byte i = 255;
        /// char i = 'a';
        /// string i = "yazi";
        /// long i i = 1231241242....
        /// short i = 127;
        /// 
        /// Operatörler
        /// + - * / 
        /// %, <, >, = , ==, <=, >=, ++, --, +=, -=, *=, /=
        /// <> ,  !=
        /// ||, &&, |, &
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int sart = 1;

            ++ sart;
            if(sart == 4)
            {
                Console.WriteLine("Merhaba");
            }
            else if (true) 
            {
                Console.WriteLine("Gunaydin");
            }
            else
            {
                Console.WriteLine("sart3");
            }

            Console.WriteLine("sart4");
            Console.ReadKey();
        }
    }
}
