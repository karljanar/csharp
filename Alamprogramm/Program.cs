using System;

namespace Alamprogramm
{
    class Program
    {
        static int Korrutaja(int arv1, int arv2)
        {
            return arv1 * arv2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Esimene arv: ");
            string tekst1 = Console.ReadLine();
            int arv1 = int.Parse(tekst1);
            Console.WriteLine("Teine arv: ");
            string tekst2 = Console.ReadLine();
            int arv2 = int.Parse(tekst2);
            Console.WriteLine("{0} ja {1} korrutis on {2}.", arv1, arv2, Korrutaja(arv1, arv2));
        }
    }
}