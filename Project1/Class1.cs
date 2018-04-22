using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Timers;

namespace HelloWorld
{
    class Hello
    {
        static private int timerCount = 0;
       

        
        
        static void Main()
        {
            
            Console.WriteLine("The adventure world:");
            
            // Keep the console window open in debug mode.
            Console.WriteLine("Press the any key to continue.");
            String a = Console.ReadLine();

            if (a == "Any key")
            {
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
                bool checkanswer2 = false;

                while (checkanswer2 == false)
                {


                    if (answer == "Y" || answer == "y")
                    {
                        checkanswer2 = true;
                        Console.WriteLine("Great job! It's time to start your trek to the castle!");
                        Console.WriteLine("Press any key to begin!");
                        if (Console.KeyAvailable == false)
                        {
                            castleTrek();
                        }

                    }
                    else
                    {
                        Console.WriteLine("Give a proper answer: ");
                        answer = Console.ReadLine();
                        checkanswer2 = false;

                    }
                    
                }
            }
      
            
        }

        static private void castleTrek()
        {
            //journey to the castle
            Console.WriteLine("You begin walking.. and you walk for some time.. then you walk some more");
            hitSpaceToContinue();
            Console.WriteLine("Suddenly, you come across three bandits attacking a carriage! Will you attack, or hide and watch?");
            hitSpaceToContinue();
            Console.WriteLine("Press 1 to attack | Press 2 to watch");
            bool checkAnswer = false;
            string answer = null;
            answer = Console.ReadLine();
            while (checkAnswer == false)
            {
                if (answer == "1")
                {
                    //Begins the attack sequence 
                    Console.WriteLine("You jump out of the bushes, and the first one charges!");
                    hitSpaceToContinue();
                    Console.WriteLine("You have 5 seconds to answer!");
                    Console.WriteLine("Press 1 - Slash!");
                    Console.WriteLine("Press 2 - Dogde!");
                    //Timer timer = new Timer(Hello.timerCallback, null, 1000, Timeout.Infinite);
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(i);
                    }

                    

                    
                    checkAnswer = true;
                }
                else if (answer == "2")
                {
                    // Watch her get slaughtered and restart the game
                    Console.WriteLine("test compelete - still need to restart the game");
                    checkAnswer = true;
                }
                else if (answer != "1" || answer != "2")
                {
                    Console.Write("Give a proper answer, 1 or 2: ");
                    answer = Console.ReadLine();
                }
            }
            
        }

        static public void hitSpaceToContinue()
        {
            // function to ease hitting space to continue
            Console.WriteLine("Hit space to continue..");
            bool checkanswer = false;
            string answer = Console.ReadLine();
            while (checkanswer == false)
            {
                if (answer == " ")
                {
                    checkanswer = true;
                    return;
                }
                else
                {
                    Console.WriteLine("Hit the spacebar..");
                    answer = Console.ReadLine();
                }
            }

        }

        static public void timerCallback(Object _)
        {
            if (timerCount > 5)
            {
                
            }
            timerCount++;
            
        }
        
    }
}