using System;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                Console.WriteLine("Laskenta");
                int x = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(x + " * " + i + " = " + x * i + "    ");
                    Console.Write(x + " / " + i + " = " + x / i + "    ");
                    Console.WriteLine(x + " % " + i + " = " + x % i + "    ");
                }
            }
        }
    }
}