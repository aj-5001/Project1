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
            //journey to the castle
            Console.WriteLine("You begin walking.. and you walk for some time.. then you walk some more");
            Console.WriteLine("Suddenly, you come across three bandits attacking a carriage! Will you attack, or hide and watch?");
            Console.WriteLine("Press 1 to attack | Press 2 to watch");
            bool checkAnswer = false;
            string answer = null;
            answer = Console.ReadLine();
            while (checkAnswer == false)
            {
                if (answer == "1")
                {
                    //do something
                    Console.WriteLine("test complete");
                    checkAnswer = true;
                }
                else if (answer == "2")
                {
                    // do something else
                    Console.WriteLine("test compelete");
                    checkAnswer = true;
                }
                else if (answer != "1" || answer != "2")
                {
                    Console.WriteLine("Give a proper answer, 1 or 2: ");
                    Console.Write("Current Answer: ");
                    Console.Write(answer);
                    answer = Console.ReadLine();
                }
            }
            
        }
        
    }
}