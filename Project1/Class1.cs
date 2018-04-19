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

            if a == "Any key" {
                Console.WriteLine("Wow, you hit the any key!, now type anything to leave.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You failed!");
                Console.ReadKey();
            }
      
            

            
        }
    }
}