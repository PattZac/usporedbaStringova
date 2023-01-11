using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usporedbaStringova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst1 = "Ovo je neki tekst";
            string tekst2 = "Ovo je NEKI tekst";
            string tekst3 = "ovo je neki tekst";
            string tekst4 = "Ovo je neki tekst";

            // Korištenje compare
            // Različiti stringova
            Console.WriteLine(string.Compare(tekst1, tekst2));
            Console.WriteLine(string.Compare(tekst1, tekst3));
            // Jednaki stringovi
            Console.WriteLine(string.Compare(tekst1, tekst4));
            
            if (string.Compare(tekst1, tekst2) != 0)
            {
                Console.WriteLine("tekst1 i tekst2 nisu isti.");
            }
            else
            {
                Console.WriteLine("tekst1 i tekst2 su isti");
            }
            if (string.Compare(tekst1, tekst3) != 0)
            {
                Console.WriteLine("tekst1 i tekst3 nisu isti.");
            }
            else
            {
                Console.WriteLine("tekst1 i tekst3 su isti");
            }
            if (string.Compare(tekst1, tekst4) != 0)
            {
                Console.WriteLine("tekst1 i tekst4 nisu isti.");
            }
            else
            {
                Console.WriteLine("tekst1 i tekst4 su isti");
            }

            // Korištenje bool
            // Različiti stringova
            Console.WriteLine(tekst1 == tekst2);
            Console.WriteLine(tekst1 == tekst3);
            // Jednaki stringovi
            Console.WriteLine(tekst1 == tekst4);

            if (tekst1 != tekst2)
            {
                Console.WriteLine("tekst1 i tekst2 nisu isti.");
            }
            else
            {
                Console.WriteLine("tekst1 i tekst2 su isti");
            }
            if (tekst1 != tekst3)
            {
                Console.WriteLine("tekst1 i tekst3 nisu isti.");
            }
            else
            {
                Console.WriteLine("tekst1 i tekst3 su isti");
            }
            if (tekst1 != tekst4)
            {
                Console.WriteLine("tekst1 i tekst4 nisu isti.");
            }
            else
            {
                Console.WriteLine("tekst1 i tekst4 su isti");
            }

            Console.ReadLine();

        }
    }
}
