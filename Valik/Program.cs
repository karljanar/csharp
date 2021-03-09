using System;

namespace Valik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun nimi:");
            string eesnimi=Console.ReadLine();
            if(eesnimi=="Mari"){
                Console.WriteLine("Tule homme minu juurde!");
            } else {
                Console.WriteLine("Mind pole homme kodus.");
            }
        }
    }
}