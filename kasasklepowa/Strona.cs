using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasasklepowa
{
    public class InterfejsUzytkownika
    {
        private Koszyk koszyk = new Koszyk();
        private Dictionary<string, Produkt> produkty = new Dictionary<string, Produkt>
    {
        { "001", new Produkt { KodKreskowy = "001", Nazwa = "Masło extra", CenaNetto = 6.50m } },
        { "002", new Produkt { KodKreskowy = "002", Nazwa = "Chleb wiejski", CenaNetto = 4.50m } },
        { "003", new Produkt { KodKreskowy = "003", Nazwa = "Makaron babuni", CenaNetto = 9.20m } },
        { "004", new Produkt { KodKreskowy = "004", Nazwa = "Dżem truskawkowy", CenaNetto = 8.10m } },
        { "005", new Produkt { KodKreskowy = "005", Nazwa = "Kiełbasa myśliwska", CenaNetto = 29.00m } },
        { "006", new Produkt { KodKreskowy = "006", Nazwa = "Szynka konserwowa", CenaNetto = 22.00m } },
        { "007", new Produkt { KodKreskowy = "007", Nazwa = "Chipsy paprykowe", CenaNetto = 6.00m } },
        { "008", new Produkt { KodKreskowy = "008", Nazwa = "Serek wiejski", CenaNetto = 3.50m } },
        { "009", new Produkt { KodKreskowy = "009", Nazwa = "Sól kuchenna", CenaNetto = 2.70m } },
        { "010", new Produkt { KodKreskowy = "010", Nazwa = "Cukier kryształ", CenaNetto = 3.20m } },
    };

        public void Uruchom()
        {
            Console.WriteLine("Kasa sklepowa");
            Console.WriteLine("Lista lista dostępnych produktów:");
            foreach (var produkt in produkty.Values)
            {
                Console.WriteLine(produkt.KodKreskowy + " - " + produkt.Nazwa);
            }
            Console.WriteLine("Aby dodać produkt do koszyka, wpisz kod kreskowy i naciśnij ENTER.");
            Console.WriteLine("Aby zakończyć zakupy, wpisz P i naciśnij ENTER.");
            string kodKreskowy;
            while ((kodKreskowy = Console.ReadLine()) != "P")
            {
                if (produkty.TryGetValue(kodKreskowy, out Produkt produkt))
                {
                }
            }
        }
    }
}