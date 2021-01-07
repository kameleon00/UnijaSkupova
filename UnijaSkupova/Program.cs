using System;
using System.Collections.Generic;
using System.Linq;

namespace UnijaSkupova
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> gradovi = new HashSet<string>() { "Beograd", "Nis", "Kragujevac", "Subotica", "Novi Sad"};
            Console.WriteLine("HashSet<string> gradovi Pre UnionWith");
            foreach (var grad in gradovi)
            {
                Console.WriteLine(grad);
            }
            Console.WriteLine("==============================================");

            string[] gradoviNaSeveru = {"Kraljevo", "Novi Sad", "Cacak"};
            var noviGradovi = gradovi.Union(gradoviNaSeveru);
            Console.WriteLine("var noviGradovi, nakon Union");
            foreach (var grad in noviGradovi)
            {
                Console.WriteLine(grad);
            }
            Console.WriteLine("==============================================");
            
            Console.WriteLine("HashSet<string> gradovi Nakon Union");
            foreach (var grad in gradovi)
            {
                Console.WriteLine(grad);
            }
            Console.WriteLine("==============================================");

            gradovi.UnionWith(gradoviNaSeveru);
            Console.WriteLine("HashSet<string> gradovi Nakon UnionWith");
            foreach (var grad in gradovi)
            {
                Console.WriteLine(grad);
            }
            Console.WriteLine("==============================================");
        }
    }
}