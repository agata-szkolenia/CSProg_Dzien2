using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablicaLiczb;  // deklaracja
            tablicaLiczb = new int[20]; // allokowanie miejsca w pamięci

            tablicaLiczb[0] = 12;   // uzupełnianie danymi
            tablicaLiczb[19] = 213;

            foreach (int item in tablicaLiczb)
            {
                Console.WriteLine(item);
            }

            int[] b = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            int[] c = { 1, 2, 3 };

            // wielowymiarowe
            int[,] kostka2d = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            kostka2d[0, 0] = 100;
            foreach (var item in kostka2d)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(kostka2d.Length) ; // liczba elementów (tu 6)
            Console.WriteLine(kostka2d.Rank); // liczba wymiarów (tu 2)

            // jak sprawdzić wysokość / szerokość kostki2d?
            Console.WriteLine($"pierwszy wymiar kostki ma {kostka2d.GetLength(0)} element/y/ów");
            Console.WriteLine($"drugi wymiar kostki ma {kostka2d.GetLength(1)} element/y/ów");

            Console.WriteLine($"pierwszy wymiar ma indeksy " +
                $"od {kostka2d.GetLowerBound(0)} do {kostka2d.GetUpperBound(0)}");

            Console.WriteLine($"drugi wymiar ma indeksy " +
                $"od {kostka2d.GetLowerBound(1)} do {kostka2d.GetUpperBound(1)}");

            // wypisujemy kostkę w formie wierszy i kolumn
            for (int i = kostka2d.GetLowerBound(0); i <= kostka2d.GetUpperBound(0); i++)
            {
                for (int j = kostka2d.GetLowerBound(1); j <= kostka2d.GetUpperBound(1); j++)
                {
                    // ',3' to ustawienie szerokości pola na wypisanie liczby w {}
                    Console.Write($"|{kostka2d[i,j], 3}"); 
                }
                Console.WriteLine("|");
            }

            // tablice tablic
            int[][] tabTablic = new int[3][];
            tabTablic[0] = new int[5];
            tabTablic[1] = new int[10];
            tabTablic[2] = new int[2];

            tabTablic[1][0] = 300;
            tabTablic[2][1] = 222;

            foreach (var tab in tabTablic)
            {
                foreach (var item in tab)
                {
                    Console.WriteLine(item);
                }               
            }

            Console.ReadKey();

            // zadanie z gwiazdką (tylko jeśli ktoś już umie pisać rekurencyjne procedury):
            // napisać rekurencyjną procedurę przechodzenia przez macierz,
            // której nie znamy liczby wymiarów
        }
    }
} 
