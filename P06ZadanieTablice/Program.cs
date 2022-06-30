using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06ZadanieTablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] imiona = new string[5];
            Console.WriteLine("Podaj 5 imion:");
            for (int i = 0; i < 5; i++)
            {
                imiona[i] = Console.ReadLine();
            }

            Console.WriteLine("------------ posortowane -----------");
            Array.Sort(imiona);
            Array.Reverse(imiona);
            
            foreach (var item in imiona)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
