using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AdventureGame
{
    class hitKeyToContinue
    {

        static public void hitSpaceToContinue()
        {
            // function to ease hitting space to continue
            Console.WriteLine("Hit space to continue..");
            bool checkanswer = false;
            char answer = Console.ReadKey().KeyChar;
            while (checkanswer == false)
            {
                if (answer == ' ')
                {
                    Console.WriteLine();
                    checkanswer = true;
                    return;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Hit the spacebar..");
                    answer = Console.ReadKey().KeyChar;
                }
            }

        }

        static public void hitAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue..");

            while (Console.KeyAvailable == false)
            {
                Thread.Sleep(250);
            }

            Console.ReadKey();
            Console.WriteLine();
        }



    }
}
