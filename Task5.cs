using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2
{
    public static class Task5
    {
        public static void Num()
        { 
            Console.WriteLine("Enter the number (n>0):"); 
            string S = Console.ReadLine();
            char[] Str = S.ToCharArray(); ;
            string A;
            Console.WriteLine("Reverce number:");
            for (int i = Str.Length - 1; i > -1; i--)
            {
                A = Convert.ToString(Str[i]);
                Console.Write(A);
            }
            Console.WriteLine(); 
        }
    }
}
