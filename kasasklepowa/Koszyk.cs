using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasasklepowa
{
    public class Koszyk
    {
        private List<Produkt> produkty = new List<Produkt>();

        public void DodajProdukt(Produkt produkt)
        {
            produkty.Add(produkt);
        }

        public void UsunProdukt(Produkt produkt)
        {
            produkty.Remove(produkt);
        }

        public decimal Suma()
        {
            return produkty.Sum(p => p.CenaBrutto);
        }

        public decimal PodatekVat()
        {
            return produkty.Sum(p => p.CenaNetto * 0.23m);
        }

        public void GenerujParagon()
        {
            Console.WriteLine("Paragon:");
            Console.WriteLine("Data zakupu: " + DateTime.Now);
            Console.WriteLine("Lista produktów:");
            foreach (var produkt in produkty)
            {
                Console.WriteLine("- " + produkt.Nazwa + " (" + produkt.CenaBrutto + " zł)");
            }
            Console.WriteLine("Łączna kwota do zapłaty: " + Suma() + " zł");
            Console.WriteLine("Łączny podatek VAT: " + PodatekVat() + " zł");
        }
    }
}