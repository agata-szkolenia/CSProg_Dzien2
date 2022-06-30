using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace P04ZadanieKursyWalut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string URL = "http://api.nbp.pl/api/exchangerates/rates/A/";
            Console.WriteLine("Podaj kod waluty: ");
            string code = Console.ReadLine();
            string data;
            try
            {
                data = new WebClient().DownloadString(URL + code);
            }
            catch (WebException e)
            {
                Console.WriteLine("This program is expected to throw WebException on successful run." +
                        "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    Console.WriteLine("Status Code : {0}", ((HttpWebResponse)e.Response).StatusCode);
                    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);// grube założenie, że to jedyny błąd jaki może wystąpić ;)
                }
                Console.WriteLine("Nie ma takiej waluty");
                Console.ReadKey();
                return;
            }

            //Console.WriteLine(data);
            //{
            //"table":"A",
            //"currency":"euro",
            //"code":"EUR",
            //"rates":[
            //          {
            //          "no":"125 / A / NBP / 2022",
            //          "effectiveDate":"2022 - 06 - 30",
            //          "mid":4.6806
            //          }
            //        ]
            //}


            // wersja 1 - brutal force
            int pos = data.IndexOf("mid");

            string rate_s = data.Substring(pos + 5, data.IndexOf(".", pos) - pos); // -5 na mid": +5 na kropkę i 4 miejsca dziesiętne
            //Console.WriteLine(rate_s);

            CultureInfo invC = CultureInfo.InvariantCulture; // kropka w miewjscu dziesiętnym
            double rate = Convert.ToDouble(rate_s, invC);

            // wersja 2 - używając dedykowanego narzędzia do dokumentów w formacie json
            JsonDocument jd = JsonDocument.Parse(data); //zasilenie danymi maszynki do obróbki dokumentu json
            double rate2 = jd.RootElement.GetProperty("rates")[0].GetProperty("mid").GetDouble();
            Console.WriteLine(rate2);

            // wersja 3 - dedykowane narzędzie, trochę prostsza nawigacja
            double rate3 = Convert.ToDouble( JObject.Parse(data)["rates"][0]["mid"]);
            var date = JObject.Parse(data)["rates"][0]["effectiveDate"];
            Console.WriteLine(rate3);

            Console.ReadKey();
            
        }
    }
}
