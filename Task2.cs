using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2
{
    public static class Task2
    {
        public static void Boo()
        {

            //            Ввести с клавиатуры номер трамвайного билета(6 - значное
            //число) и про-верить является ли данный билет счастливым
            //(если на билете напечатано шестизначное число, и сумма
            //первых трёх цифр равна сумме последних трёх, то этот
            //билет считается счастливым).

            Console.WriteLine("Enter 6 number:");
            string S = Console.ReadLine();
            char[] Str = S.ToCharArray(); ;
            if(Str.Length == 6)
            {
                if(Str[0] == Str[5] && Str[1] == Str[4] && Str[2] == Str[3])
                {
                    Console.WriteLine("Lucky ticket!");
                }
                else
                {
                    Console.WriteLine("Unlucky ticket!");
                }
            }
            else
            {
                Console.WriteLine("Errore number!");
            } 
        }
    }
}
