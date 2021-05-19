using System;
using System.Linq;

namespace Nopanheitto
{
    class Program
    {

        static void Main(string[] args)
        {
           
            Random noppa = new Random();
            
            int summa = 0;
            int[] luku = new int[5];
            int[] luku2 = new int[5];
            Console.ReadKey(true);

            for (int i = 0; i < 5; i++)
            {
                

                //int luku = noppa.Next(1, 7);
                //int luku2 = noppa.Next(1, 7);

                luku[i] = noppa.Next(1, 7);
                luku2[i] = noppa.Next(1, 7);

                Console.WriteLine("Noppa 1: " + luku[i]);
                Console.WriteLine("Noppa 2: " + luku2[i]);
                Console.WriteLine();

                summa = luku.Sum() + luku2.Sum();
                

                //Console.WriteLine(luku[i] + luku2[i]);

                //Console.WriteLine("Noppa 1: " + luku);
                //Console.WriteLine("Noppa 2: " + luku2);


            }
            Console.WriteLine("Nopanheittojen tulosten summa = " + summa);


        }
    }
}
