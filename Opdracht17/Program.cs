namespace Opdracht17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namen = { "Akram", "Mohammed", "Ali", "Hassan", "Ahmed" };

            Console.WriteLine("Voer een getal in:");
            string invoer = Console.ReadLine();
            try
            {
                int waarde = int.Parse(invoer);
                string[] gekozenNamen = new string[waarde];

                for (int i = 0; i < gekozenNamen.Length; i++)
                {
                    gekozenNamen[i] = namen[i];
                    Console.WriteLine(gekozenNamen[i]);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Dat is geen geldig getal.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Dat getal is te groot of te klein.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Zoveel namen zijn er niet in de lijst.");
            }
            catch (Exception)
            {
                Console.WriteLine("Er ging iets anders mis.");
            }

            Console.ReadLine();
        }
    }
}