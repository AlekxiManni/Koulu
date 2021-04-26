using System;

namespace Tehtava8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            Console.WriteLine("Monta tuotetta haluat lisätä? ");
            int x = int.Parse(Console.ReadLine());
            decimal[] tuoteHinta = new decimal[x];
            int[] tuoteLkm = new int[x];
            string[] tuoteNimi = new string[x];

            Console.WriteLine("Anna tuotteet ");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(i + 1 + ". tuote ");
                tuoteNimi[i] = Console.ReadLine();
                Console.WriteLine("Anna tuotteen hinta ");
                tuoteHinta[i] = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Anna tuotteiden lukumäärä ");
                tuoteLkm[i] = int.Parse(Console.ReadLine());
            }
                for (int y = 0; y < x; y++)
                {
                Console.WriteLine(tuoteNimi[y] + "  " + tuoteLkm[y] * tuoteHinta[y] + "€.");
                }
        }
    }
}

