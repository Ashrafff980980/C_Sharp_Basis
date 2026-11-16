namespace Opdracht7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is je geluks getal");
            ConsoleKeyInfo geluksGetal = Console.ReadKey();
            char geluksGetalChar = geluksGetal.KeyChar;

            if (geluksGetalChar == '5')
            {
                Console.WriteLine("correct mijn geluks getal is 5");
            }
            else
            {
                Console.WriteLine("fout mijn geluks getal is 5");
            }
        }
    }
}
