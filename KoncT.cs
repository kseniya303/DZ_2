using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2
{
    public class Pencil
    {  
        private int weight = 15;
        private string color = "Red";
        private byte num = 9; 
        private bool sharpened = true;
        private double count = 47.5;

        static int Kol;
        static int Knop;

        public Pencil(int _weight)
        {
            _weight = weight;
        }

        public Pencil(int _weight, string _color)
        {
            _weight = weight;
            _color = color;
        }
          
        public Pencil ()
        {
            Console.WriteLine("Ne static konstruktor");
        }

        static Pencil()
        {
            Console.WriteLine("Static konstruktor");
        }
         
        static void Text()
        {
            Console.WriteLine("This is class Pencil!");
        }

        void Characteristics_Pencil()
        {

            Console.Write("Weight: ", weight, "\n Color: ", color, "\n Num: ", num, "\n Sharpened: ", sharpened, "\n Count: ", count);
        }

        public double Count_Change()
        {

            return count - 100;
        }
        
        public string Change_Color(string new_color)
        {
            return color = new_color;
        }
         

        public double Count_Min(ref double c, double mp)
        {
            return c -= mp;
        }


        

    }
}
