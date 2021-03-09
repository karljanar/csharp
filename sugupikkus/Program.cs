using System;

namespace sugupikkus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teie pikkus ");
            string tekst1 = Console.ReadLine();
            double pikkus = double.Parse(tekst1);
            Console.WriteLine("Sugu (m/n)");
            string sugu = Console.ReadLine();
           
            if (sugu.Equals("m"))
            {
                if (pikkus <= 170.0)
                {
                    Console.WriteLine("Luhike");
                }
                else
                {
                    if (pikkus > 170.0 || pikkus <= 190.0)
                    {
                        Console.WriteLine("Keskmine");
                    }
                    else
                    {
                        Console.WriteLine("pikk");
                    }
                }
            }
            else
            {
                if (pikkus <= 165.0)
                {
                    Console.WriteLine("Luhike");
                }
                else
                {
                    if (pikkus > 165.0 || pikkus <= 178.0)
                    {
                        Console.WriteLine("Keskmine");
                    }
                    else
                    {
                        Console.WriteLine("pikk");
                    }
                }
            }
            
        }
    }
}