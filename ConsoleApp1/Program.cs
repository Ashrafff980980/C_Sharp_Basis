namespace opdracht11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char keuze;

            do
            {
               Console.WriteLine("\n MENU ");
                Console.WriteLine("1.menu 1");
                Console.WriteLine("2.menu2");
                Console.WriteLine("3.menu3");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                keuze = keyInfo.KeyChar;
                Console.WriteLine();

                switch (keuze)
                {
                    case '1':
                        Console.WriteLine("U heeft menu 1 gekozen");
                        break;
                    case '2':
                        Console.WriteLine("U heeft menu 2 gekozen");
                        break;
                    case '3':
                        Console.WriteLine("U heeft menu 3 gekozen");
                        break;
                    default:


                }

            }
        }
    }
}
