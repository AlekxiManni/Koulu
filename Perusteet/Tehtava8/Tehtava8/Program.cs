using System;

namespace Tehtava8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruit = {"","Mandariini", "Omena", "Banaani",};
            Start:
            Console.WriteLine("Montako hedelmää haluat nähdä?");
            int maara = int.Parse(Console.ReadLine());
            if (maara > 3)
            {
                Console.WriteLine("Ei ole kuin kolme hedelmää, yritä uudelleen!"); goto Start;
            }
            else if (maara <= 3) ;
            for(int f = 0; f <= maara; f++)
            {
                Console.WriteLine(fruit[f]);
            }
        }
    }
}
