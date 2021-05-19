using System;

namespace Matikkapeli_2
{
    class Program
    {
        
        
      




       



        static void Main(string[] args)
        {
            bool asd = true;

            do
            {
                

                Console.WriteLine("Valitse vaikeustaso:");
                Console.WriteLine("1: HELPPO. Laskut ovat helppoja kokonaislukuja ilman negatiivisa lukuja");
                Console.WriteLine("2: KESKIVAIKEA. Laskuissa voi olla mukana negatiivisa lukuja");
                Console.WriteLine("3: VAIKEA. Laskut ovat desimaaleja ja voi olla mukana myös negatiivisa lukuja");
                int k = int.Parse(Console.ReadLine());

                if (k == 1)
                {


                    Random numero1 = new Random();
                    int x = numero1.Next(1, 11);
                    int y = numero1.Next(1, 11);
                    int vastaus;
                    Console.WriteLine();
                    Console.WriteLine("Paljonko on " + x + " + " + y + "  ? ");
                    Console.Write("> ");

                    try
                    {
                        vastaus = int.Parse(Console.ReadLine());
                        if (x + y == vastaus)
                        {
                            Console.WriteLine("Oikea vastaus!");
                        }
                        else
                        {
                            Console.WriteLine("Väärä vastaus!");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Et antanut numeroa, yritä uudelleen");
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Et antanut mitään, yritä uudelleen");
                    }
                }
                if (k == 2)
                {
                    Random numero1 = new Random();
                    int x = numero1.Next(-10, 21);
                    int y = numero1.Next(-10, 21);
                    int vastaus;
                    Console.WriteLine();
                    Console.WriteLine("Paljonko on " + x + " + " + y + "  ? ");
                    Console.Write("> ");

                    try
                    {
                        vastaus = int.Parse(Console.ReadLine());
                        if (x + y == vastaus)
                        {
                            Console.WriteLine("Oikea vastaus!");
                        }
                        else
                        {
                            Console.WriteLine("Väärä vastaus!");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Et antanut numeroa, yritä uudelleen");
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Et antanut mitään, yritä uudelleen");
                    }
                }
                if (k == 3)
                {
                    Random numero1 = new Random();
                    decimal x = numero1.Next(-10, 21);
                    decimal y = numero1.Next(-10, 21);
                    int vastaus;
                    Console.WriteLine();
                    Console.WriteLine("Paljonko on " + x + " + " + y + "  ? ");
                    Console.Write("> ");

                    try
                    {
                        vastaus = int.Parse(Console.ReadLine());
                        if (x + y == vastaus)
                        {
                            Console.WriteLine("Oikea vastaus!");
                        }
                        else
                        {
                            Console.WriteLine("Väärä vastaus!");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Et antanut numeroa, yritä uudelleen");
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Et antanut mitään, yritä uudelleen");
                    }
                }

            } while (asd = false);


        }



    }
}
