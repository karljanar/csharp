using System;

namespace tarnid
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine("Tarnid");
                int arv1 = int.Parse(Console.ReadLine());
                for (int i = 0; i < arv1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");

            }
        }
    }
}