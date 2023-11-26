using System;

namespace Uppgift_5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in tal du vill multiplicera. (sepparera dem med *)");
            string talenLista = Console.ReadLine();
            string[] talenText = talenLista.Split('*');
            int faktor = 1;
            foreach (string tal in talenText)
            {
                int faktor2 = int.Parse(tal);
                faktor = faktor2 * faktor;
            }
            Console.WriteLine($"Produkten är {faktor}.");
            Console.ReadKey();
        }
    }
}