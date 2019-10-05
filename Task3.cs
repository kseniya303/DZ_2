using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Числовые значения символов нижнего регистра в коде ASCII
//отличаются от значений символов верхнего регистра на
//величину 32. Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует
//Домашнее задание №1 Домашнее задание №<Номер дз>
//все символы нижнего регистра в символы верхнего регистра и наоборот
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
