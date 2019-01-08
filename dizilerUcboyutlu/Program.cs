using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizilerUcboyutlu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tek = new int[5]; // uzulugu  - eleman sayisi

                                  // satir , sutun // [y,x]
            int[,] iki = new int[2, 3] 
            { 
              /*satir1*/  {1,2,2 }, 
              /*satir2*/  {4,3,5 }
            };
            // (0,0) 1 | (0,1) 2 | (0,2) 2
            // (1,0) 4 | (1,1) 3 | (1,2) 5

            //uc boyutlu
            int[,,] uc = new int[2, 2, 4] //2satir 2sutun 4 eleman
            {
                             //sutun1       sutun2
               /*satir1*/ { {1,2,3,4 }, {1,2,3,6 } },
               /*satir2*/ { {2,3,5,4 }, {5,2,3,5 } }
            };
            //      sutun1                   |           sutun2
            // (0,0,0) 1 (0,0,1) 2 (0,0,2) 3 (0,0,3) | (0,1,0) 1 (0,1,1) 2 (0,1,2) 3 (0,1,3) 
            // (1,0,0) 1 (1,0,1) 2 (1,0,2) 3 (0,0,3) | (1,1,0) 1 (1,1,1) 2 (1,1,2) 3 (1,1,3)



            Console.ReadKey();
        }
    }
}
