using System;

namespace elevant
{
    class Program
    {
        static void Main(string[] args)
        {
            string ele;
            do
            {
                Console.WriteLine("Osta elevant");
                ele = Console.ReadLine();
            } while (!ele.Equals("elevant"));

        }
    }
}