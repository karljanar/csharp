using System;

namespace arvutamine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esimene arv: ");
            string tekst1 = Console.ReadLine();
            int arv1 = int.Parse(tekst1);
            Console.WriteLine("Teine arv: ");
            string tekst2 = Console.ReadLine();
            int arv2 = int.Parse(tekst2);
            Console.WriteLine("Arvude {0} ja {1} korrutis on {2}", arv1, arv2, arv1*arv2);
            
        }
    }
}