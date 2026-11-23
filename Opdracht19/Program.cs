using System;
using System.Collections.Generic;
using System.Linq;

namespace Opdracht19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Klant> klanten = new List<Klant>
            {
                new Klant(1, "Marijke", "0612345678"),
                new Klant(2, "Jan", "0612345677"),
                new Klant(3, "Tim", "0612345666"),
                new Klant(4, "Matt", "0612345555"),
                new Klant(5, "Jeff", "0612344444")
            };

            // 1) Sorteren op naam
            var gesorteerd = klanten.OrderBy(k => k.Naam);
            foreach (Klant k in gesorteerd)
            {
                Console.WriteLine(k.Naam);
            }

            Console.WriteLine();

            // 2) Telefoonnummer begint met "0612345"
            var nummers = klanten.Where(k => k.Telefoonnummer.StartsWith("0612345"));
            foreach (Klant k in nummers)
            {
                Console.WriteLine(k.Naam + " " + k.Telefoonnummer);
            }

            Console.WriteLine();

            // 3) Totaal aantal klanten
            Console.WriteLine("Aantal: " + klanten.Count());

            // 4) Eerste klant in de gesorteerde lijst
            Console.WriteLine("Eerste: " + gesorteerd.First().Naam);

            Console.ReadLine();
        }
    }

    class Klant
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Telefoonnummer { get; set; }

        public Klant(int id, string naam, string telefoonnummer)
        {
            Id = id;
            Naam = naam;
            Telefoonnummer = telefoonnummer;
        }
    }
}