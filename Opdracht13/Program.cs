using System;

namespace Opdracht13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = new int[5];

            for (int i = 0; i < getallen.Length; i++)
            {
                int nummer = 0;
                bool isGeldig = false;

                while (!isGeldig)
                {
                    Console.WriteLine($"Voer getal {i + 1} in:");
                    string invoer = Console.ReadLine();

                    if (int.TryParse(invoer, out nummer))
                    {
                        isGeldig = true;
                    }
                    else
                    {
                        Console.WriteLine("Dat is geen getal, probeer het opnieuw.");
                    }
                }

                getallen[i] = nummer;
            }

            Console.WriteLine("\nResultaat van je invoer:");

            for (int i = 0; i < getallen.Length; i++)
            {
                Console.WriteLine($"Nummer {i + 1} is: {getallen[i]}");
            }

            Console.ReadLine();
        }
    }
}