using System;

namespace Tehtava16
{
    class Program
    {
        


        static void Main(string[] args)
        {
            bool outofrange = true;

            do
            {

                Console.WriteLine("Anna numero 1-7 niin kerron sinulle vastaavan viikonpäivän");
                string syote = Console.ReadLine();
                outofrange = true;
                switch (syote)
                {

                    case "1":
                        Console.WriteLine("Maantai");
                        break;

                    case "2":
                        Console.WriteLine("Tiistai");
                        break;

                    case "3":
                        Console.WriteLine("Keskiviikko");
                        break;

                    case "4":
                        Console.WriteLine("Torstai");
                        break;

                    case "5":
                        Console.WriteLine("Perjantai");
                        break;

                    case "6":
                        Console.WriteLine("Lauantai");
                        break;

                    case "7":
                        Console.WriteLine("Sunnuntai");
                        break;

                    default:
                        Console.WriteLine("Anna numero 1-7");
                        outofrange = false;
                        break;
                }
            
            } while (!outofrange);



        }
    }
}
