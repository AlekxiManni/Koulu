using System;

namespace Tehtava_10
{
    class Program
    {
        static void Main(string[] args)
        {

            int laskuri = 0;
            Console.WriteLine("Arvaa numero tai paina 'l' lopettaaksesi");

            while (laskuri != 45)
            {
                string input = Console.ReadLine();
                int numero;
                int.TryParse(input, out numero);
                if (numero == 45) break;
                else if (input == "l" || input == "L") break;
            }
        }
    }
}
