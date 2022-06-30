using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02KalkulatorOdpornyNaUżyszkodnika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dane;
            double a, b, retValue;

            // ustawienia regionalne, na potrzeby wczytywania/wyświetlania danych
            CultureInfo unvC = CultureInfo.InvariantCulture; // "uniwersalny"
            CultureInfo plPl = new CultureInfo("pl-PL");     // po polsku

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Podaj dwie liczby rodzielone znakiem /");
                dane = Console.ReadLine();
                if (dane == "")
                {
                    Console.WriteLine("wpisz help, żeby uzyskać pomoc do programu");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    return; // wyjście z gry jak użytkownik nic nie wpisze
                }
                
                if (! dane.Contains('/') )
                {
                    Console.WriteLine("rozdziel liczby znakiem /");
                    continue;
                }

                try
                {
                     a = Convert.ToDouble(dane.Substring(0, dane.IndexOf('/')), unvC);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("pierwsza liczba jest nieczytelna :P ");
                    continue;
                }

                try
                {
                    b = Convert.ToDouble(dane.Substring(dane.IndexOf('/')+1));
                }
                catch (FormatException e)
                {
                    Console.WriteLine("druga liczba jest nieczytelna :P ");
                    continue;
                }

                try
                {
                    retValue = a/b;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("nie możesz dzielić przez 0");
                    continue; ;
                }
                // uwaga: double "rozumie" w nieskończoności, więc nie rzuca błędem dzielenia przez zero :)
                Console.WriteLine($"Wynik dzielenia to: {retValue}");
                break;
            }


            Console.ReadKey();

        }
    }
}
