using System;

namespace massiiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[4] {3, 12, 2, 40};
            int suurim = 0;
            foreach (int arv in mas)
            {
                if (arv > suurim)
                {
                    suurim = arv;
                }
            }
            Console.WriteLine(suurim);
        }
    }
}