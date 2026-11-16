namespace Opdracht8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vul hier een een woord: ");
            string invoer = Console.ReadLine();
            string woord = invoer.ToLower();

            string resultaat = (woord=="lucky") ? "correct mijn geluks woord is lucky" : "fout mijn geluks woord is lucky";
            Console.WriteLine(resultaat);
        }
    }
}
