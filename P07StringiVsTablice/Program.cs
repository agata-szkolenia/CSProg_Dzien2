using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07StringiVsTablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dane = "Ala ma kota i psa";

            Console.WriteLine(dane[5]);
            var tab = dane.Split(' ');
            string polaczenie = string.Join("/", tab);

            string a = "KOT";
            string b = "KOT";

            Console.WriteLine(a == b);

            char[] c = { 'K', 'O', 'T' };
            char[] d = { 'K', 'O', 'T' };

            Console.WriteLine(c == d);

            c = d;  // wskazanie na to samo miejsce w pamięci
            Console.WriteLine(c == d);

            c[1] = 'X';
            Console.WriteLine(d[1]);

            d.CopyTo(c, 0);  // kopia 
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }

            // zadanie: sprawdzenie czy CopyTo jest płytkie czy głębokie
            // utwórz tablicę tablic
            // zrób kopię za pomocą CopyTo
            // zmień element w kopii
            // sprawdź czy w pierwotnej zmiennej widzisz zmianę
            string[][] oryginal = new string[2][];
            oryginal[0] = new string[3] { "Ala", "Ola", "Zuzia"};
            oryginal[1] = new string[4] { "Franek", "Karol", "Marek", "Rafał" };

            string[][] kopia = new string[6][]; // miejsce docelowe może być większe niż oryginał, nie może być mniejsze
            oryginal.CopyTo(kopia, 2);

            kopia[2][1] = "Karolina";

            foreach (var wiersz in oryginal)
            {
                foreach (var item in wiersz)
                {
                    Console.WriteLine(item);
                }
            }
            // wniosek: to jest płytka kopia, tylko 1 warstwa jest faktycznie kopiowana

            string e = "Dominika";
            string f = e;

            f.Replace("i", "e"); // tu jest bezpiecznie, tworzona jest kopia
            Console.WriteLine(e);

            // reguła kciuka: w fizycznej pamięci stringi pozostają niezmienne
            // jak cokolwiek trzeba zmienić to tworzona jest kopia ze zmianami
            Console.ReadKey();
        }
    }
}
