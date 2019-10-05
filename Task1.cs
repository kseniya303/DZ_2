using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2
{
    public static class Task1
    {
        public static void Bobo()
        {
            Console.WriteLine("Enter some words with dot: ");
            char input;
            int spaceCount = 0;
            do
            {
                input = Console.ReadKey().KeyChar;

                if (input == ' ')
                    spaceCount++;
            }
            while (input != '.');

            Console.WriteLine("\nCount spaces: " + spaceCount); 

        }
    }
}
