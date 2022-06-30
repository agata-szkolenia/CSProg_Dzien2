using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P03Pliki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dane;
            // każdy \ musi być pisany podwójnie
            // ścieżka globalna
            Console.WriteLine("---------- wersja 1 -------------");
            dane = File.ReadAllText("C:\\Users\\kurs\\source\\repos\\Dzień02\\P03Pliki\\dane_do_odczytu.txt");
            Console.WriteLine(dane);

            // ścieżka względna
            Console.WriteLine("---------- wersja 2 -------------");
            dane = File.ReadAllText("..\\..\\dane_do_odczytu.txt");
            Console.WriteLine(dane);

            // raw string @ - nie interpretuj znaków, czytaj dosłownie
            Console.WriteLine("---------- wersja 3 -------------");
            dane = File.ReadAllText(@"..\..\dane_do_odczytu.txt");
            Console.WriteLine(dane);

            // użyj notacji unixowej (zamiast \ użyj /)
            Console.WriteLine("---------- wersja 4 -------------");
            dane = File.ReadAllText("../../dane_do_odczytu.txt");
            Console.WriteLine(dane);

            // gdzie jestem? (materiały str 78, albo 34 w drugiej części)
            DirectoryInfo dirInfo =
                new DirectoryInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Console.WriteLine(dirInfo.FullName); // ścieżka do mnie
            Console.WriteLine(dirInfo.Parent.FullName); // ścieżka do mojego katalogu

            // czytanie z sieci www
            dane = new WebClient()
                    .DownloadString("http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt");
            Console.WriteLine(dane);

            //dane = new WebClient().DownloadString("http://www.alx.pl");
            //Console.WriteLine(dane);

            Console.ReadKey();
        }
    }
}
