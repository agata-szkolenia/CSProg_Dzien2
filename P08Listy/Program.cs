using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08Listy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // listy mogą zmieniać swoją długość

            List<string> imiona = new List<string>();
            imiona.Add("Karolina");
            imiona.Add("Zenon");
            imiona.Add("Ola");
            imiona.Add("Karolina");

            imiona.Remove("Karolina");
            imiona.Remove("Gucio");

            Console.WriteLine(imiona[2]);
            for (int i = 0; i < imiona.Count; i++)
            {
                Console.WriteLine($"{i} {imiona[i]}");
            }

            foreach (var imie in imiona)
            {
                Console.WriteLine(imie);
            }

            imiona.ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
