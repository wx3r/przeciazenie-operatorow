using przeciazenie_operatorow;

class Program
{
    static void Main(string[] args)
    {
        Produkt produkt1 = new Produkt("Bluza", 129.99m, 5);
        Produkt produkt2 = new Produkt("Czapka", 50.00m, 3);
        Produkt produkt3 = new Produkt("Żonobijka", 100.20m, 7);

        Magazyn magazyn = new Magazyn("Magazyn Raków");
        magazyn.DodajProdukt(produkt1);
        magazyn.DodajProdukt(produkt2);
        magazyn.DodajProdukt(produkt3);

        Console.WriteLine("Przed sortowaniem:");
        magazyn.WyswietlProdukty();

        magazyn.SortujProdukty();

        Console.WriteLine("\nPo sortowaniu:");
        magazyn.WyswietlProdukty();
    }
}