using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario
{
    class Program
    {

        static void Main(string[] args)
        {
            int pyramidHeight;
            do
            {

                Console.Write("How tall would you like your pyramid?");
                string userEntry = Console.ReadLine();
                pyramidHeight = int.Parse(userEntry);

            }
            while (pyramidHeight >= 23);

            // print the pyramid
            
            

            for (int i = 0; i < pyramidHeight + 1; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write("*");
                        
                for (int k = 0; k < i; k++)
                       Console.Write(" ");
                    Console.Write("\n");

                
                
                
            }
            Console.ReadLine();
                
        }

        
    }
        
}
