using System;
using System.Collections.Generic;

namespace lapid
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random r = new Random();
            lapid.riidelapid l1;
            l1.pikkus = r.Next(20);
            l1.laius = r.Next(20);
            l1.toon = "hele";
            
            lapid.riidelapid l2;
            l2.pikkus = r.Next(20);
            l2.laius = r.Next(20);
            l2.toon = "hele";
            
            lapid.riidelapid l3;
            l3.pikkus = r.Next(20);
            l3.laius = r.Next(20);
            l3.toon = "tume";
            
            
        }
    }
}