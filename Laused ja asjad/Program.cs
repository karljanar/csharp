using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Laused_ja_asjad
{
    class Program
    {
        static string lisaFaili(List<String> laused)
        {
            
            FileStream f = new FileStream("/home/karljanar/csharp/Solution1/Laused ja asjad/sonad.txt", 
                FileMode.Append, FileAccess.Write);
            StreamWriter valja = new StreamWriter(f);

            foreach (string lause in laused)
            {
                valja.WriteLine(lause);
            }
            valja.Close();
            


            return "done";
        }

        static string loeFaili(int r)
        {
            String sisu = File.ReadLines("/home/karljanar/csharp/Solution1/Laused ja asjad/sonad.txt").ElementAt(r);
            return sisu;
        }
        
        static void Main(string[] args)
        {
            List<String> vanas = new List<string>()
            {
                "Põrsast kotis ei osteta.",
                "Tee tööd töö ajal, aja juttu jutu ajal.",
                "Tühi kott ei seisa püsti.",
                "Vana karu tantsima ei õpi.",
                "Amet ei riku meest, kui mees ametit ei riku."
            };
            Random r=new Random();
            int pikkus = vanas.Count;
            Console.WriteLine(loeFaili(r.Next(pikkus)));
            //Console.WriteLine(lisaFaili(vanas));
            
        }
    }
}