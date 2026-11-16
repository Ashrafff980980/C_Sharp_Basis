namespace Opdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string invoer = "42";//maak je tekst variable en geef je nummer 42 aan
            int getal = int.Parse(invoer);// zet je die tekst in echte getallen
            int resultaat = getal * 2;//nu heb je getal gemaakt dus kan je dan die ding verdubbelen 
            Console.WriteLine("Het dubbele is: " + resultaat);//en dan kan je resultaat zien met console
            Console.ReadLine();
        }
    }
}
