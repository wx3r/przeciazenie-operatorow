using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przeciazenie_operatorow
{
    public class Produkt
    {
        public string Nazwa {  get; set; }
        public decimal  Cena { get; set;}
        public int Ilość {  get; set; }

        public Produkt(string nazwa, decimal cena, int ilość)
        {
            Nazwa = nazwa;
            Cena = cena;
            Ilość = ilość;
        }

        public void WyświetlInfo()
        {
            Console.WriteLine($"Nazwa: {Nazwa}, Cena: {Cena}, Ilość: {Ilość}");
        }

        //przeciążenie operatora ==
        public static bool operator ==(Produkt p1, Produkt p2)
        {
            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
            {
                return false;
            }
            return p1.Cena == p2.Cena;
        }

        //przeciążenie operatora !=
        public static bool operator !=(Produkt p1, Produkt p2)
        {
            return !(p1 == p2);
        }

        //przeciążenie operatora <
        public static bool operator <(Produkt p1, Produkt p2)
        {
            return p1.Cena < p2.Cena;
        }

        //przeciążenie operatora >
        public static bool operator >(Produkt p1, Produkt p2)
        {
            return p1.Cena > p2.Cena;
        }

        //przeciążenie operatora ++
        public static Produkt operator ++(Produkt p)
        {
            p.Ilość++;
            return p;
        }

        //przeciążenie operatora --
        public static Produkt operator --(Produkt p)
        {
            p.Ilość--;
            return p;
        }

        //equals porownanie na podstawie ceny
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Produkt p = (Produkt)obj;
            return Cena == p.Cena;
        }

        //przeciazanie GetHashCode do gen. hasha na podstawie ceny
        public override int GetHashCode()
        {
            return Cena.GetHashCode();
        }
    }
}
