using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generatewindowsidentifiers
{
    class Program
    {
        static void gentheserial()
        {
            Random rd = new Random();
            string[] words = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            string firstkey = rd.Next(11111, 99999) + "-";
            string secondkey = rd.Next(11111, 99999) + "-";
            string thirdkey = rd.Next(11111, 99999) + "-";

            int firstltr = rd.Next(0, 25);
            int secondltr = rd.Next(0, 25);
            int thirdltr = rd.Next(0, 25);
            int fourthltr = rd.Next(0, 25);
            int fifthltr = rd.Next(0, 25);

            string frthwrd = words[firstltr] + words[secondltr] + words[thirdltr] + words[fourthltr] + words[fifthltr];

            
            Console.WriteLine("\n1st line - " + firstkey);
            Console.WriteLine("\n2nd line - " + secondkey);
            Console.WriteLine("\n3rd line - " + thirdkey);
            Console.WriteLine("\n4th letters - " + frthwrd);

            string productid = firstkey + secondkey + thirdkey + frthwrd;

            Console.WriteLine("\nCombined: " +  firstkey + secondkey + thirdkey + frthwrd);
        }

        static void Main(string[] args)
        {
            gentheserial();
            Console.ReadLine();
        }
    }
}
