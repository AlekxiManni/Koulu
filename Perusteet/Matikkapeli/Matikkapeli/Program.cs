using System;


namespace Matikkapeli
{
    class Program
    {
        static void MatikkapeliLoop(int[] taulukko)
        {
            
            int a, b, c, d;
            a = 2;
            b = 2;
            c = 2;
            d = 2;
            ConsoleKeyInfo syote;
            char valinta;
            
            Console.WriteLine();
            bool peli = true;
            do
            {
                Valikko(a, b, c, d);
                syote = Console.ReadKey();
                valinta = syote.KeyChar;
                Console.WriteLine();
                peli = true;
                switch (valinta)
                {
                    case '1':
                        Console.WriteLine("Valitsit yhteenlaskun");
                        a = YhteenLasku(taulukko);
                        break;
                    
                    case '2':
                        Console.WriteLine("Valitsit vähennyslaskun");
                        b = VahennusLasku(taulukko);
                        break;

                    case '3':
                        Console.WriteLine("Valitsit kertolaskun");
                        c = KertoLasku(taulukko);
                        break;

                    case '4':
                        Console.WriteLine("Valitsit jakolaskun");
                        d = JakoLasku(taulukko);
                        break;

                    case 'q':
                    case 'Q':
                        Console.WriteLine("Lopetat pelaamisen");
                        peli = false;
                        break;

                    default:
                        Console.WriteLine("Et valinnut mitään, yritä uudelleen");
                        Console.WriteLine();
                        break;
                }
                if (a <= 1 && b <= 1 && c <= 1 && d <= 1)
                {
                    peli = false;
                }
            } while (peli);

            if (peli == false)
            {
                int pisteet = a + b + c + d;
                Console.WriteLine();
                if (pisteet == 4)
                {
                    Console.WriteLine("Pisteesi: " + pisteet + ", Onneksi olkoon, sait parhaaan palkinnon! :-)");
                }
                else if (pisteet == 3)
                {
                    Console.WriteLine("Pisteesi: " + pisteet + ", Onneksi olkoon, sait toisiksi parhaimman palkinnon!");
                }
                else if (pisteet < 3)
                {
                    Console.WriteLine("Pisteesi: " + pisteet + ", Valitettavasti jäit tällä kertaa ilman palkintoa :-(");
                }
            }
        }
            
        /// <summary>
        /// Valitsee mihin laskutoimitukseen halutaan mennä
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        static void Valikko(int a, int b, int c, int d) 
        {
            Console.WriteLine();
            Console.WriteLine("Valitse peli kirjoittamalla vastaava numero");
            Console.WriteLine("Paina Q jos haluat lopettaa");
            Console.WriteLine();
            if (a == 2)
            {
                Console.WriteLine("1. Yhteenlasku"); 
            }
            if (b == 2)
            {
                Console.WriteLine("2. Vähennyslasku"); 
            }
            if (c == 2)
            {
                Console.WriteLine("3. Kertolasku"); ;
            }
            if (d == 2)
            {
                Console.WriteLine("4. Jakolasku"); 
            }
        }

       


        static int YhteenLasku(int[] taulukko)
        {


            int vastaus;
            Console.WriteLine();
            Console.WriteLine("Paljonko on " + taulukko[0] + " + " + taulukko[1] + "  ? ");
            Console.Write("> ");

                try
                {

                    vastaus = int.Parse(Console.ReadLine());
                    if (vastaus == taulukko[0] + taulukko[1])
                    {
                        Console.WriteLine("Oikea vastaus!");
                        return 1;
                    }
                    else
                    {
                        Console.WriteLine("Väärä vastaus!");
                        return 0;
                    }



                }
                catch (FormatException)
                {
                    Console.WriteLine("Et antanut numeroa, yritä uudelleen");
                    return 2;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Et antanut mitään, yritä uudelleen");
                    return 2;
                }
            
        }

        static int VahennusLasku(int[] taulukko)
        {
            

            int vastaus;
            Console.WriteLine();
            Console.WriteLine("Paljonko on " + taulukko[0] + " - " + taulukko[1] + "  ? ");
            Console.Write("> ");

            try
            {
                vastaus = int.Parse(Console.ReadLine());
                if (taulukko[0] - taulukko[1] == vastaus)
                {
                    Console.WriteLine("Oikea vastaus!");
                    return 1;
                }
                else
                {
                    Console.WriteLine("Väärä vastaus!");
                    return 0;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Et antanut numeroa, yritä uudelleen");
                return 2;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Et antanut mitään, yritä uudelleen");
                return 2;
            }
        }

        static int KertoLasku(int[] taulukko)
        {

            

            int vastaus;
            Console.WriteLine();
            Console.WriteLine("Paljonko on " + taulukko[0] + " * " + taulukko[1] + "  ? ");
            Console.Write("> ");

            try
            {
                vastaus = int.Parse(Console.ReadLine());
                if (taulukko[0] * taulukko[1] == vastaus)
                {
                    Console.WriteLine("Oikea vastaus!");
                    return 1;
                }
                else
                {
                    Console.WriteLine("Väärä vastaus!");
                    return 0;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Et antanut numeroa, yritä uudelleen");
                return 2;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Et antanut mitään, yritä uudelleen");
                return 2;
            }

        }

        static int JakoLasku(int[] taulukko)
        {
            

            int vastaus;
            Console.WriteLine();
            Console.WriteLine("Paljonko on " + taulukko[0] + " / " + taulukko[1] + "  ? ");
            Console.Write("> ");

            try
            {
                vastaus = int.Parse(Console.ReadLine());
                if (taulukko[0] / taulukko[1] == vastaus)
                {
                    Console.WriteLine("Oikea vastaus!");
                    return 1;
                }
                else
                {
                    Console.WriteLine("Väärä vastaus!");
                    return 0;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Et antanut numeroa, yritä uudelleen");
                return 2;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Et antanut mitään, yritä uudelleen");
                return 2;
            }

        }

        static string VaikeusTaso()
        {
            string pelivalinta = "";
            string helppo = "";
            string keskivaikea = "";
            string vaikea = "";
            Console.WriteLine("Tervetuloa matikkapeliin");
            Console.WriteLine();
            Console.WriteLine("Valitse vaikeustaso");
            Console.WriteLine("1. HELPPO");
            Console.WriteLine("2. KESKIVAIKEA");
            Console.WriteLine("3. VAIKEA");
            ConsoleKeyInfo syote;
            char valinta;
            syote = Console.ReadKey();
            valinta = syote.KeyChar;
            Console.WriteLine();
            bool peli = true;

            do
            {
                peli = true;
                switch (valinta)
                {
                    case '1':
                        helppo = "helppo";
                        return helppo;
                    case '2':
                        keskivaikea = "keskivaikea";
                        return keskivaikea;
                    case '3':
                        vaikea = "vaikea";
                        return vaikea;
                    default:
                        Console.WriteLine("Yritä uudelleen");
                        peli = false;
                        //VaikeusTaso();
                        continue;
                }
                

            } while (peli);
            return pelivalinta;
        }

        /// <summary>
        /// Metodin idea on se että ottaa vastaan vaikeustason ja vaikeustason perusteella arvotaan erikokoisia random -lukuja riippuen siitä miten vaikea se on. 
        /// Tallennetaan luvut taulukkon. Arvotut luvut palautetaan taulukossa
        /// </summary>
        /// <param name="vaikeustaso"></param>
        static int[] VaikeustasoValittu(string vaikeustaso)
        {
            Random numero1 = new Random();
            int[] taulukko = new int[2];

            

            switch (vaikeustaso)
            {

                case "helppo":
                    Console.WriteLine("VALITSIT HELPON VAIKEUSASTEEN");
                
                taulukko[0] = numero1.Next(12, 17);
                taulukko[1] = numero1.Next(1, 11);
                    return taulukko;

                case "keskivaikea":
                    Console.WriteLine("VALITSIT KESKIVAIKEAN VAIKEUSASTEEN");
                    taulukko[0] = numero1.Next(1, 20);
                    taulukko[1] = numero1.Next(-10, 21);
                    return taulukko;

                case "vaikea":
                    Console.WriteLine("VALITSIT VAIKEAN VAIKEUSASTEEN");
                    taulukko[0] = numero1.Next(1, 101);
                    taulukko[1] = numero1.Next(-101, 101);
                    return taulukko;

                //default:
                //    VaikeusTaso();
                //    break;


            }
            return taulukko;
                
        }

        


        static void Main(string[] args)

        {
            int[] taulukko = new int[2];
            string vaikeustaso = VaikeusTaso();
            taulukko = VaikeustasoValittu(vaikeustaso);
            MatikkapeliLoop(taulukko);
            
        }
    }
}
