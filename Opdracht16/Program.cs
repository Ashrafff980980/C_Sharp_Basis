namespace KlassenEnMethoden
{
    class Program
    {
        static void Main(string[] args)
        {
            double getal1 = 0;
            bool geldigGetal1 = false;
            while (geldigGetal1 == false)
            {
                Console.WriteLine("Voer het eerste getal in:");
                string invoer1 = Console.ReadLine();
                geldigGetal1 = double.TryParse(invoer1, out getal1);

                if (!geldigGetal1)
                {
                    Console.WriteLine("Ongeldige invoer. Voer een geldig getal in.");
                }
            }

            double getal2 = 0;
            bool geldigGetal2 = false;
            while (geldigGetal2 == false)
            {
                Console.WriteLine("Voer het tweede getal in:");
                string invoer2 = Console.ReadLine();
                geldigGetal2 = double.TryParse(invoer2, out getal2);

                if (!geldigGetal2)
                {
                    Console.WriteLine("Ongeldige invoer. Voer een geldig getal in.");
                }
            }

            bool juistKeuze = false;
            while (juistKeuze == false)
            {
                Console.WriteLine("Wat wil je doen?");
                Console.WriteLine("1 = optellen & aftrekken");
                Console.WriteLine("2 = optellen & vermenigvuldigen");
                Console.WriteLine("3 = optellen & delen");

                string keuze = Console.ReadLine();

                switch (keuze)
                {
                    case "1":
                        double som = calculator.Optellen(getal1, getal2);
                        double verschil = calculator.Aftrekken(getal1, getal2);
                        Console.WriteLine($"De som is: {som}");
                        Console.WriteLine($"Het verschil is: {verschil}");
                        juistKeuze = true;
                        break;

                    case "2":
                        double som2 = calculator.Optellen(getal1, getal2);
                        double product = calculator.Vermenigvuldigen(getal1, getal2);
                        Console.WriteLine($"De som is: {som2}");
                        Console.WriteLine($"Het product is: {product}");
                        juistKeuze = true;
                        break;

                    case "3":
                        double som3 = calculator.Optellen(getal1, getal2);
                        try
                        {
                            double quotient = calculator.Delen(getal1, getal2);
                            Console.WriteLine($"De som is: {som3}");
                            Console.WriteLine($"Het quotiënt is: {quotient}");
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        juistKeuze = true;
                        break;

                    default:
                        Console.WriteLine("Ongeldige keuze. Voer 1, 2 of 3 in");
                        break;
                }
            }
            Console.WriteLine("Druk op een random toets om af te sluiten.");
            Console.ReadKey();
        }
    }

    public class calculator
    {
        public static double Optellen(double getal1, double getal2)
        {
            return getal1 + getal2;
        }
        public static double Aftrekken(double getal1, double getal2)
        {
            return getal1 - getal2;
        }
        public static double Vermenigvuldigen(double getal1, double getal2)
        {
            return getal1 * getal2;
        }
        public static double Delen(double getal1, double getal2)
        {
            if (getal2 == 0)
            {
                throw new DivideByZeroException("Delen door nul is niet toegestaan.");
            }
            return getal1 / getal2;
        }
    }
}