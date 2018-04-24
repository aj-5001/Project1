using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Timers;
using AdventureGame;
namespace AdventureGame
{
    class MainAdventure
    {
        static private int timerCount = 1;
       

        
        
        static void Main()
        {
            
            Console.WriteLine("The adventure world:");
            hitKeyToContinue.hitSpaceToContinue();
            
            // Keep the console window open in debug mode.
            Console.WriteLine("Press the any key to continue.");
            String a = Console.ReadLine();

            if (a == "Any key" || a == "any key")
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

                        Console.WriteLine("Great job! It's time to start your trek to the castle!");

                        hitKeyToContinue.hitAnyKeyToContinue();
                        castleTrek();
                        checkanswer2 = true;

                    }
                    if (answer == "N" || answer == "n")
                    {
                        Console.WriteLine("Okay, have a nice day!");
                        return;
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
            hitKeyToContinue.hitSpaceToContinue();
            Console.WriteLine("Suddenly, you come across three bandits attacking a carriage! Will you attack, or hide and watch?");
            hitKeyToContinue.hitSpaceToContinue();
            Console.Write("Will you attack or watch? 1 - Attack | 2 - Watch: ");
            // prompt for user
           

            bool checkAnswer = false;
            string answer = null;
            answer = Console.ReadLine(); 
            while (checkAnswer == false)
            {
                if (answer == "1")
                {
                    //Begins the attack sequence 
                    Console.WriteLine("You jump out of the bushes, and the first one charges!");
                    hitKeyToContinue.hitSpaceToContinue();
                    Console.WriteLine("You have 5 seconds to answer!");
                    Console.WriteLine("Press 1 - Slash!");
                    Console.WriteLine("Press 2 - Dogde!");

                 // creates a timer and sets intervals to 1 seconds
                    System.Timers.Timer timer = new System.Timers.Timer();
                    timer.Elapsed += new ElapsedEventHandler(timerCallback);
                    timer.Interval = 1000;
                    timer.Enabled = true; // starts timer

                    bool newCheckanswer = false;
                    char newanswer = 'a';
                    //checking the answer is correct
                    while (timerCount <= 5 && !newCheckanswer)
                    {
                        if (Console.KeyAvailable)
                        {
                            ConsoleKeyInfo key = Console.ReadKey(true);
                            switch (key.Key)
                            {
                                case ConsoleKey.D1:
                                    Console.WriteLine("You pressed one");
                                    break;
                                default:
                                    break;

                            }
                        }
                        if (newanswer == '1' || newanswer == '2')
                        {
                            Console.WriteLine("You slash and cut and point and prode! The man falls, dead!");
                            newCheckanswer = true;
                        }
                        if (newanswer == '2')
                        {
                            Console.WriteLine("You slip the attack, and pop out from behind him!");
                            hitKeyToContinue.hitAnyKeyToContinue();
                            Console.WriteLine("Will you stab in the back? Or cut his legs out and disable him?");
                            hitKeyToContinue.hitAnyKeyToContinue();
                            Console.WriteLine("Quick, you have 5 seconds to answer!");
                            Console.WriteLine("Press 1 - Stab | Press 2 - Cut legs");

                        }
                        else
                        {
                            //Console.WriteLine("Quick! Give a proper answer: ");
                        }
                    }
                    timer.Stop();

                    if (newCheckanswer == true)
                    {
                        Console.WriteLine("ya didn't die");
                    }
                    else
                    {
                        Console.WriteLine("ya died bitch");
                    }
                    
                    Console.WriteLine("implement next battle sequence");
                    Console.ReadKey();
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



        static public void timerCallback(Object _, ElapsedEventArgs e)
        {
            Console.WriteLine(timerCount);
            timerCount++;
          
        }


        
    }
}