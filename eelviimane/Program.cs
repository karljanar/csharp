using System;

namespace eelviimane
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage oma nimi");
            string nimi = Console.ReadLine();
            int pikkus = nimi.Length;
            Console.WriteLine(nimi.Substring(pikkus-2, 1));
        }
    }
}