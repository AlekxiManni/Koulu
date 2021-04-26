using System;

namespace Tehtava9
{
    class Program
    {


        static void Main(string[] args)
        {
            double summa=0;
            int[] luvut = new int[5];
            Console.WriteLine("Anna 5 kokonaislukua");
            for (int i = 0; i <= 4; i++)
            {
                luvut[i] = int.Parse(Console.ReadLine());
            }
                foreach (int luku in luvut)
                {
                    summa = summa + luku;
                }
            Console.WriteLine(summa / 5);
        }
    }
}
