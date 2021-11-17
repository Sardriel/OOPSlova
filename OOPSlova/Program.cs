using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPSlova
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> slova = new List<string>();
            string slovo = "";
            
            while (slovo !="konec")
            {
                Console.Write("Zadej slovo: ");
                slovo = Console.ReadLine().ToLower();
                if (slovo != "konec")
                { 
                    slova.Add(slovo);
                }
            }
            Console.Write("Zadal jsi tato slova: {0}", string.Join(", ", slova.Distinct().ToArray()));
            Console.ReadKey();
        }
    }
}
