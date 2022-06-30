using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ObsługaBłędów
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // błędy kompilacji
            // błędy czasu wykonania (runtime)
            // - sytuacje wyjątkowe (brak połączenia, dzielenie przez zero, brak pliku na dysku)
            // - błędy "ciche" - błędy w algorytmie (testy jednostkowe)

            int a = 0;
            int b;
            //b = Convert.ToInt32("ala ma kota");
            //b = 10 / a;
            try
            {
                Console.WriteLine("blok try przed błędem");
                b = 10 / a;
                Console.WriteLine("blok try po pierwszym błędzie");
                b = Convert.ToInt32("ala ma kota");
                Console.WriteLine("blok try po drugim błędzie");
            }
            // kolejnosć catch ma znaczenie (od najbardziej szczegółowych do najbardziej ogólnych)
            catch (DivideByZeroException)
            {
                Console.WriteLine("złapany wyjątek dzielenie przez 0");
                b = 123;
                //throw;
            }
            catch (FormatException)
            {
                Console.WriteLine("złapany wyjątek zły format danych");
                b = 456;
                //throw;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("złapany wyjątek poza zakresem");
                b = 789;
                //throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("zapisz w logach: \n" + e.Message + "\n"+ e.StackTrace);
                throw; // rzuca ten sam błąd jeszcze raz i wychodzi z programu
            }
            Console.WriteLine($"dalsza część programu {b}");
            Console.ReadKey();
        }
    }
}
