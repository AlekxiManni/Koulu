using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tehtava17_2
{
    enum Valikko {  lisaaNimi=0 , syntymaPaiva, naytaNimi, naytaIka, poistuOhjelmasta }
    class Program
    {

        static bool Valinta(int kayttajanValinta)
        {

            int x, kayttajaIka, y, m, d;
            bool valintaOhjelma = true;
            string kayttajaNimi = "";
            string ika = "" ;
            var pvm = DateTime.Today;

            

                valintaOhjelma = true;
                switch (kayttajanValinta)
                {
                    case (int)Valikko.lisaaNimi:
                        Console.WriteLine("Lisätään nimi");
                        kayttajaNimi = Console.ReadLine();
                        Console.WriteLine("Nimesi on tallennettu");
                        break;

                    case (int)Valikko.syntymaPaiva:
                        Console.WriteLine("Milloin olet syntynyt");
                        Console.WriteLine("Syntymävuosi");
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Kuukausi");
                        m = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Päivä");
                        d = Convert.ToInt32(Console.ReadLine());

                        var syntymapaiva = new DateTime(y, m, d);
                        int age = pvm.Year - syntymapaiva.Year;

                        if (syntymapaiva > pvm.AddYears(-age))
                        age--;
                        Console.WriteLine("Olet "+ age + " vuotias");
                        break;
                    //Tehtävän tarkastuksen kannalta jätin iän tulokstuksen tähän että näkee ohjelman toimivan.
                    //Käyttäjä lisää vuoden, kuukauden ja päivän erikseen jonka jälkeen ohjelma laskee ja tulostaa iän.


                    case (int)Valikko.naytaNimi:
                        Console.WriteLine("Näytetään nimi");
                        Console.WriteLine(kayttajaNimi);
                        break;

                    case (int)Valikko.naytaIka:
                        Console.WriteLine("Näytetään ikä");
                        Console.WriteLine(ika);
                        break;

                    case (int)Valikko.poistuOhjelmasta:
                        Console.WriteLine("Poistutaan ohjelmasta");
                        valintaOhjelma = false;
                        break;

                }
                
            return valintaOhjelma;
        }


        static int Testi()
        {
            int i = 0;

            Console.WriteLine("Valitse seuraavista vaihtoehdoista");
            foreach (string valinta in Enum.GetNames(typeof(Valikko)))
            {
                Console.WriteLine(i + ". " + valinta);
                i++;

            }
            int x = int.Parse(Console.ReadLine());
            return x;
        }



        static void Main(string[] args)
        {
            int i = 0;
            int x;
            bool toimiiko;

            do
            {
                x = Testi();
                toimiiko = Valinta(x);

            } while (toimiiko);

        }

    }
}
