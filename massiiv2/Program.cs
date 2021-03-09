using System;
using System.Linq;
using System.Collections.Generic;

namespace massiiv2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            int pikkus = list.Count;
            for(int i = pikkus-1; i>=0; i--)
            {
                Console.Write(list[i] + " ");
            }
            List<int> reverse = Enumerable.Reverse(list).ToList();
            Console.WriteLine(" ");
            Console.WriteLine(String.Join(',', reverse));
        }
    }
}