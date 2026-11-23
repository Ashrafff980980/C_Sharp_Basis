using System.Collections.Generic;

namespace Opdracht19
{
    public class Klant
    {
        private int id;
        private string naam;
        private string telefoonnummer;

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

        public string Telefoonnummer
        {
            get { return telefoonnummer; }
            set { telefoonnummer = value; }
        }

        public Klant(int klantId, string klantNaam, string klantTelefoon)
        {
            id = klantId;
            naam = klantNaam;
            telefoonnummer = klantTelefoon;
        }

        public static List<Klant> Initialiseer()
        {
            List<Klant> klanten = new List<Klant>();
            klanten.Add(new Klant(1, "Marijke", "0612345678"));
            klanten.Add(new Klant(2, "Jan", "0612345677"));
            klanten.Add(new Klant(3, "Tim", "0612345666"));
            klanten.Add(new Klant(4, "Matt", "0612345555"));
            klanten.Add(new Klant(5, "Jeff", "0612344444"));
            return klanten;
        }
    }
}
