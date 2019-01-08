using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizilerCokBoyutlu2
{
    class Program
    {
        static void Main(string[] args)
        {
            //   0      1       2       3
            //0 100     80      70      60
            //1 50      40      70      60
            //2 30      20      10      5


            int[,] not = new int[3, 4];

            //ilk satira 4 tane not girildi
            not[0, 0] = 100;
            not[0, 1] = 80;
            not[0, 2] = 70;
            not[0, 3] = 60;
            //ikinci satira 4 tane not girildi
            not[1, 0] = 50;
            not[1, 1] = 40;
            not[1, 2] = 70;
            not[1, 3] = 60;
            //ucuncu satira 4 tane not girildi
            not[2, 0] = 30;
            not[2, 1] = 20;
            not[2, 2] = 10;
            not[2, 3] = 5;

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Console.Write("{0} \t",not[i,k]);
                }
                Console.WriteLine("");
            }

            


            Console.ReadLine();
        }
    }
}
