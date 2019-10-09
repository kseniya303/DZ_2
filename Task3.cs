using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace DZ_2
{
    public static class Task3
    {
        public static void Boo()
        { 
            Console.WriteLine("Enter your string:");
            string S = Console.ReadLine(); 
            char[] C = S.ToCharArray(); 
            for(int i = 0; i<C.Length; i++)
            { 
                if(char.IsLower(C[i]))
                {
                    Console.Write(char.ToUpper(C[i]));
                }
                else if(char.IsUpper(C[i]))
                {
                    Console.Write(char.ToLower(C[i]));
                }
                else if(C[i] == ' ')
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();

           // Console.WriteLine(S_new);
            
        }
    }
}
