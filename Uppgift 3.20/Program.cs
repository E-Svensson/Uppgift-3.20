using System;
using System.Collections.Immutable;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in ett ord: "); string ord1 = Console.ReadLine();
            Console.WriteLine(" ");

            Console.Write("Skriv in ett till ord: "); string ord2 = Console.ReadLine();
            Console.WriteLine(" ");

            Console.Write("Skriv in ett tredje ord: "); string ord3 = Console.ReadLine();
            Console.WriteLine(" ");

            string[] ord = { ord1, ord2, ord3 };

            Array.Sort(ord);

            Console.WriteLine($"Det ordet som kommer först i bokstavsordning ordning blir då \"{ord[0]}\".");
        }
    }
}
