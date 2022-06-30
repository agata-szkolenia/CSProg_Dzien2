using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09ZadanieListy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<int> liczby = new List<int>();
            int licznik = 0;
            Console.WriteLine("Wpisz dowolnie dużo liczb. Naciśnij 2 razy enter żeby skończyć.");
            while (true)
            {
                input = Console.ReadLine();
                if (input == "")
                    break;
                try
                {
                    liczby.Add(Convert.ToInt32(input));
                }
                catch (Exception)
                {
                }
            }
            foreach (var i in liczby)
            {
                // wersja 1
                if (i % 2 == 0) licznik++;

                //licznik += i % 2; // zliczanie nieparzystych

                // wersja 2
                //licznik += 1 - (i % 2); // zliczanie parzystych
            }

            Console.WriteLine($"Znaleziono {licznik} liczb parzystych");
            Console.ReadKey();
        }
    }
}
