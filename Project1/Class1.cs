using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HelloWorld
{
    class Hello
    {
        static void Main()
        {
            Console.WriteLine("The adventure world:");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press the any key to continue.");
            String a = Console.ReadLine();

            if (a == "Any key") {
                Console.WriteLine("Wow, you hit the any key!, now type anything to leave.");
                Console.WriteLine("Would you like to start your adventure now? Y/N");
                string answer = Console.ReadLine();
                if (answer == "Y" || answer == "y")
                {
                    castleTrek();
                }
                else
                {
                    Console.WriteLine("Oh okay then, bye!");
                    Console.ReadKey();
                }
               
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You failed!");
                Console.WriteLine("I'll give you another try, do you wish to begin your adventure? Y/N:");
                String answer = Console.ReadLine();
                if (answer == "Y" || answer == "y")
                {
                    Console.WriteLine("Great job! It's time to start your trek to the castle!");
                    Console.WriteLine("Press any key to begin!");
                    if (Console.KeyAvailable == false)
                    {
                        castleTrek();
                    }

                }
                Console.ReadKey();
            }
      
            
        }

        static public void castleTrek()
        {
            Console.WriteLine("You begin walking.. and you walk for some time.. then you walk some more");
        }
        
    }
}