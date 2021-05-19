using System;

namespace Tehtava20
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo syote;
            char merkki;

            syote = Console.ReadKey();
            merkki = syote.KeyChar;

            Console.WriteLine();

            if (Char.IsNumber(merkki))
            {
                Console.WriteLine("Annoit numeron " + Char.GetNumericValue(merkki));
            }
            else if (Char.IsUpper(merkki))
            {
                Char.IsUpper(merkki);
                Console.WriteLine("Kirjoitit merkin isolla");
            }
            else if (Char.IsLower(merkki))
            {
                Char.IsLower(merkki);
                Console.WriteLine("Kirjoitit merkin pienellä");
            }
            else if (Char.IsWhiteSpace(merkki))
            {
                Console.WriteLine("Painoit välilyöntiä");
            }
            else if (Char.IsSymbol(merkki))
            {
                Console.WriteLine("Annoit erikoismerkin");
            }
        }
    }
}
