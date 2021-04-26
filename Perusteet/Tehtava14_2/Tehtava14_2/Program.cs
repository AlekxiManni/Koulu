

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace funktiot

{

    class Program

    {


        private static int Pienin(int eka, int toka, int kolmas)

        {
            int[] pienin = new int[] { eka, toka, kolmas };
            Array.Sort(pienin);
            Array.Reverse(pienin);
            return pienin[pienin.Length - 1];



        }

        private static int Suurin(int eka, int toka, int kolmas)

        {

            int[] suurin = new int[] { eka, toka, kolmas };
            Array.Sort(suurin);
            return suurin[suurin.Length - 1];



        }



        static void Main(string[] args)

        {
            int luku1, luku2, luku3, suurinLuku, pieninLuku;

            string syote;

            int numero = 0;

            bool tarkistus = true;


        pos1: Console.WriteLine("Anna eka luku:");

            syote = Console.ReadLine();
            tarkistus = int.TryParse(syote, out numero);
            if (tarkistus == false)
            {
                Console.WriteLine("Anna numero"); goto pos1;
            }
            luku1 = numero;

        pos2: Console.WriteLine("Anna toka luku:");

            syote = Console.ReadLine();
            tarkistus = int.TryParse(syote, out numero);
            if (tarkistus == false)
            {
                Console.WriteLine("Anna numero"); goto pos2;
            }
            luku2 = numero;

        pos3: Console.WriteLine("Anna kolmas luku:");

            syote = Console.ReadLine();
            tarkistus = int.TryParse(syote, out numero);
            if (tarkistus == false)
            {
                Console.WriteLine("Anna numero"); goto pos3;
            }
            luku3 = numero;




            Pienin(luku1, luku2, luku3);
            Suurin(luku1, luku2, luku3);

            pieninLuku = Pienin(luku1, luku2, luku3);
            suurinLuku = Suurin(luku1, luku2, luku3);

            Console.WriteLine("<><><><><><><><><><><><><><>");
            Console.WriteLine("     Pienin luku on  " + pieninLuku);
            Console.WriteLine("     Suurin luku on  " + suurinLuku);
            Console.WriteLine("<><><><><><><><><><><><><><>");

            //Kutsu tässä Pienin ja Suurin ohjelmia ja anna niille parametreina luku1, luku2 ja luku3. 

            // Ota aliohjelmien tulokset talteen suurinLuku ja pieninLuku muuttujiin. Tulosta lopuksi tulokset 





        }

    }

}
