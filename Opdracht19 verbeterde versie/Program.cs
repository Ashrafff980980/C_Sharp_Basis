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
            Console.WriteLine();

            var nummers = klanten.Where(k => k.Telefoonnummer.StartsWith("0612345"));
            foreach (Klant klant in nummers)
            {
                Console.WriteLine(klant.Naam + " - " + klant.Telefoonnummer);
            }

            Console.WriteLine();
            Console.WriteLine("Totaal aantal klanten: " + klanten.Count());

            Klant eerste = gesorteerd.First();
            Console.WriteLine("Eerste klant: " + eerste.Naam);
            Console.ReadLine();
        }
    }
}