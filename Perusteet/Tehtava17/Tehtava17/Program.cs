

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Tehtava17
{

    class Program
    {


        static string TulostaValikko()
        {

            string valinta = "";
            bool onnistui = false;
            int palautettavaLuku = 0;

            while (!onnistui)
            {
                Console.WriteLine("0. Lisää nimi");
                Console.WriteLine("1. Lisää ikä");
                Console.WriteLine("2. Näytä nimi");
                Console.WriteLine("3. Näytä ikä");
                Console.WriteLine("4. poistu ohjelmasta");
                valinta = Console.ReadLine();
                onnistui = int.TryParse(valinta, out palautettavaLuku);
            }
            return valinta;
        }

        static bool Tarkista(string valinta)
        {
                bool jatkuu = true;
                int ika;
            
                switch (valinta)
                {
                    case "0":
                        Console.WriteLine("Lisätään nimesi");
                        string nimi = Console.ReadLine();
                        Console.WriteLine("Tervehdys " + nimi);
                        break;
                    

                    case "1":
                        Console.WriteLine("Lisätään ikäsi");
                        ika = int.Parse(Console.ReadLine());
                        Console.WriteLine("Olet " + ika + " vuotias");
                        break;

                         case "2":
                         Console.WriteLine("Näytetään nimi");
                         break;

                    case "3":
                        Console.WriteLine("Näytetään ikä");
                        break;

                    case "4":
                        Console.WriteLine("poistutaan ohjelmasta");
                        break;
                }
                return jatkuu;
        }




        static void Main(string[] args)
        {
            bool jatkuu = true;
            while (jatkuu)
            {
                string syote = TulostaValikko();
                jatkuu = Tarkista(syote);

            }
        }
      

    }

}