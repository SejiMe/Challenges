using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingEggs
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hi Welcome to Jivan-Router Entertainment Program");
            Console.WriteLine("Please enter the number of eggs :: ");
            string eggs = Console.ReadLine();

            int egg = Int32.Parse(eggs);
            int Nob;
            int Rob;
            int Tob;
            
            for (int box = 0; egg >= 400; egg-= 50)
            {
                box++;
                Console.WriteLine("Processed {0} box of eggs" , box);
                Nob = box;
            }

            for (int racks = 0; egg >= 70; egg -= 32)
            {
                racks++;
                Console.WriteLine("Processed {0} rack of eggs :: {0}", racks);
                Rob = racks;
            }
            for (int tray = 0; egg >= 15; egg -= 12)
            {

                tray++;
               Tob = tray;
                Console.WriteLine("Processed {0} tray of eggs {0}", tray);
            }
            


            int excess = egg;
            
            Console.WriteLine("Excess eggs :: {0}", excess);
            Console.WriteLine("-------------------");
            Console.WriteLine("Type any key to exit the program");
            Console.ReadKey();

            // not error must fix unaassgined variable to print out clean the number of box racks etc...
        }
    }
}
