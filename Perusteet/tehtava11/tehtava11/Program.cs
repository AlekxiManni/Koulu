using System;
using System.Collections.Generic;


namespace tehtava11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> oppilaat = new List<string>();
            string nimi;
            Console.WriteLine("Anna oppilaiden nimiä ja lopeta syöttämällä L");
            nimi = Console.ReadLine();
            while (nimi != "L")
            {
                oppilaat.Add(nimi);
                nimi = Console.ReadLine();
            }
            
            {
            Console.WriteLine("Haluatko listan aakkosten alku- (A) vai loppupäästä? (L)");
            string valinta = Console.ReadLine();
            if (valinta.Contains("a", StringComparison.CurrentCultureIgnoreCase))
            {
                    Console.WriteLine("Monta oppilasta haluat nähdä?");
                    int y = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < y; i++)
                    {
                        oppilaat.Sort();
                        Console.WriteLine(oppilaat[i]);
                    }
            }
            else if (valinta.Contains("l", StringComparison.CurrentCultureIgnoreCase))
            {
                    Console.WriteLine("Monta oppilasta haluat nähdä?");
                    int y = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < y; i++)
                    {
                        oppilaat.Sort();
                        oppilaat.Reverse();
                        Console.WriteLine(oppilaat[i]);
                    }
            }
            }
        }
    }
}
