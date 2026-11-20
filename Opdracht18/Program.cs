using Opdracht18;

namespace Opdracht18
{
    internal class Klanten
    {
        static void Main(string[] args)
        {
            List<Klant> klanten = Klant.Initialiseer();

            foreach (Klant klant in klanten)
            {
                Console.WriteLine(klant.Id + " " + klant.Naam + " 0" + klant.Telefoonnummer);
            }

            Console.ReadLine();
        }
    }
}