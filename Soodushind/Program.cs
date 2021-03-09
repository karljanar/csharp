using System;

namespace Soodushind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hind: ");
            string tekst1 = Console.ReadLine();
            double arv1 = double.Parse(tekst1);
            Console.WriteLine(arv1 * 100 /70);
        }
    }
}