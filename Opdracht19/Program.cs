using System;
using System.Collections.Generic;
using System.Linq;

namespace Opdracht19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Klant> klanten = Klant.Initialiseer();

            var gesorteerd = klanten.OrderBy(k => k.Naam);
            foreach (Klant klant in gesorteerd)
            {
                Console.WriteLine(klant.Naam);
            }
            var nummers = klanten.Where(k => k.Telefoonnummer.ToString().StartsWith("612345"));
            foreach (Klant klant in nummers)
            {
                Console.WriteLine(klant.Naam + " 0" + klant.Telefoonnummer);
            }
            Console.WriteLine(klanten.Count())

            var eerste = gesorteerd.First();
            Console.WriteLine(eerste.Naam);
            Console.ReadLine();
        }
    }

    public class Klant
    {

        private int id;
        private string naam;
        private int telefoonnummer;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
        public int Telefoonnummer
        {
            get { return telefoonnummer; }
            set { telefoonnummer = value; }
        } 
        public Klant(int id, string naam, int telefoonnummer)
        {
            this.id = id;
            this.naam = naam;
            this.telefoonnummer = telefoonnummer;
        }

        public static List<Klant> Initialiseer()
        {
            List<Klant> klanten = new List<Klant>();
            klanten.Add(new Klant(1, "Jan", 612345678));
            klanten.Add(new Klant(2, "Piet", 612345679));
            klanten.Add(new Klant(3, "Klaas", 612345680));
            klanten.Add(new Klant(4, "Henk", 612345681));
            klanten.Add(new Klant(5, "Joris", 612345682));
            klanten.Add(new Klant(6, "Sander", 612345683));
            klanten.Add(new Klant(7, "Tom", 612345684));
            klanten.Add(new Klant(8, "Tim", 612345685));
            klanten.Add(new Klant(9, "Timo", 612345686));
            klanten.Add(new Klant(10, "Tijn", 612345687));
            return klanten;
        }

    }

        
    }
}
