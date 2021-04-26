using System;

namespace valuuttalaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal luku;
            decimal dollari= 1.1919m;
            decimal punta = 0.8610m;
            Start:
            Console.WriteLine("Hei, muunnetaan valuuttaa");
            Console.WriteLine("1 euro = 1,19 dollaria, 1 euro = 0,86 puntaa ");
            Console.WriteLine("Haluatko muuttaa eurot (1) dollareiksi vai (2) punniksi?");
            string valinta = Console.ReadLine();

            if (valinta == "1")
            {
                Console.WriteLine("Anna luku mikä muunnetaan euroista dollareiksi ");
                luku=decimal.Parse(Console.ReadLine());
                Console.WriteLine(luku + " Euroa = " + "{0:0.00$}", + luku * dollari);
                Console.WriteLine("Haluatko kokeilla uudestaan? k/e? ");
                string kokeile = Console.ReadLine();
                if (kokeile == "k")
                    goto Start;
            }
            else if(valinta=="2")
            {
                Console.WriteLine("Anna luku mikä muunnetaan euroista puntiin ");
                luku = decimal.Parse(Console.ReadLine());
                Console.WriteLine(luku + " Euroa = " + "{0:0.00£}", +luku * punta);
                Console.WriteLine("Haluatko kokeilla uudestaan? k/e? ");
                string kokeile = Console.ReadLine();
                if (kokeile == "k")
                    goto Start;
            }
        }
    }
}
