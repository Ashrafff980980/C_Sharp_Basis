using System;
using System.Collections.Generic;
using System.Linq;

namespace Opdracht20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> lijst = new List<double>();
            string tekst = "";

            while (tekst != "stop")
            {
                Console.WriteLine("Geef een cijfer (of typ stop):");
                tekst = Console.ReadLine();

                if (double.TryParse(tekst, out double getal))
                {
                    if (getal >= 1.0 && getal <= 10.0)
                    {
                        lijst.Add(getal);
                    }
                    else
                    {
                        Console.WriteLine("Cijfer moet tussen 1,0 en 10,0 zijn.");
                    }
                }
                else if (tekst != "stop")
                {
                    Console.WriteLine("Geen geldig cijfer.");
                }
            }

            if (lijst.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Gemiddelde: " + lijst.Average());
                Console.WriteLine("Hoogste: " + lijst.Max());
                Console.WriteLine("Laagste: " + lijst.Min());
                Console.WriteLine("Voldoendes: " + lijst.Where(cijfer => cijfer >= 5.5).Count());
                Console.WriteLine("Van hoog naar laag:");

                var volgorde = lijst.OrderByDescending(cijfer => cijfer);
                foreach (double cijfer in volgorde)
                {
                    Console.WriteLine(cijfer);
                }
            }
            Console.ReadLine();
        }
    }
}