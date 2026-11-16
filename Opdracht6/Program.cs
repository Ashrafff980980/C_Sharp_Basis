namespace Opdracht6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string geboortejaar;
            Console.WriteLine("Wat is geboortejaar?");
            geboortejaar = Console.ReadLine();

            int geboortejaarInt = int.Parse(geboortejaar);
            int leeftijd = 2026 - geboortejaarInt;
            Console.WriteLine("Je bent {0} jaar oud", leeftijd);

        }         
    }
}
