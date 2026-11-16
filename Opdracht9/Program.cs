namespace Opdracht9
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("1. small\n2. medium\n3. large");
            int size = int.Parse(Console.ReadLine());
            switch (size)
            {
                case 1:
                    Console.WriteLine("smal kost €2,00");
                    break;
                case 2:
                    Console.WriteLine("medium kost €2,50");
                    break;
                case 3:
                    Console.WriteLine("larg kost €3,00");
                    break;
                default:
                    Console.WriteLine("Keuze is niet beschikbaar");
                    break;
            }
            Console.ReadLine();
        }
    }
}
