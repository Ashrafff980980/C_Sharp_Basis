using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht18
{
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

        public Klant(int klantId, string klantNaam, int klantTelefoon)
        {
            id = klantId;
            naam = klantNaam;
            telefoonnummer = klantTelefoon;
        }
        public static List<Klant> Initialiseer()
        {
            List<Klant> klanten = new List<Klant>();
            klanten.Add(new Klant(1, "Akram", 0612345678));
            klanten.Add(new Klant(2, "Mohammed", 0612345679));
            klanten.Add(new Klant(3, "Ali", 0612345680));
            klanten.Add(new Klant(4, "Hassan", 0612345681));
            klanten.Add(new Klant(5, "Ahmed", 0612345682));
            return klanten;
        }
    }
}
