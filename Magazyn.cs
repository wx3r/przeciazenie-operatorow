using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przeciazenie_operatorow
{
    public class Magazyn
    {
        public string Nazwa { get; set; }
        public List<Produkt> Produkty { get; set; }

        public Magazyn(string nazwa)
        {
            Nazwa = nazwa;
            Produkty = new List<Produkt>();
        }

        public void DodajProdukt(Produkt produkt)
        {
            Produkty.Add(produkt);
        }

        public void WyswietlProdukty()
        {
            Console.WriteLine($"Magazyn: {Nazwa}");
            foreach (var produkt in Produkty)
            {
                produkt.WyświetlInfo();
            }
        }
        public void SortujProdukty()
        {
            Produkty.Sort((p1,p2) => p1.Cena.CompareTo(p2.Cena));
        }
    }
}