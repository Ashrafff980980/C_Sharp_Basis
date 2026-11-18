namespace Opdracht15
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int uitkomst = Optellen(4, 7);
           Console.WriteLine("De som is: " + uitkomst);
           Console.ReadLine();
        }
        public static int Optellen(int getal1, int getal2)
        {
           return getal1 + getal2;
        }
    } 
}