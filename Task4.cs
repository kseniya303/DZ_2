using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2
{
    public static class Task4
    {
        public static void Arr()
        {
            Console.WriteLine("Enter two numbers A, B (A<B):");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = B - A + 1;
           
            int[][] arr = new int[C][];
            
            for (int i = 0; i < arr.Length; i++)
            { 
                arr[i] = new int[A + i];
                arr[i] = Enumerable.Repeat(A++, arr[i].Length).ToArray(); 
                Console.WriteLine(string.Join(" ", arr[i])); 
            } 
        }  
    }
}