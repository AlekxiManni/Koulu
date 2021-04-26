using System;

namespace tehtava7
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            Console.WriteLine("Anna luku");
            int x = int.Parse(Console.ReadLine());
            for (i = x; x - i < x; i--)
            {
                Console.WriteLine(i-1);
            }
        }
    }
}
