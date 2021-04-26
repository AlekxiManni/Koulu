using System;

namespace forloop7._4
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, arvonta;

            Random arvottu = new Random();

            for (x = 1; x <= 5; x++)
            {
                arvonta = arvottu.Next(1, 11);
                Console.WriteLine("Anna luku");
                int arvaus = int.Parse(Console.ReadLine());

                if (arvaus == arvonta)
                {
                    Console.WriteLine("Onneksi olkoon, sama luku!");break;
                }
                else if (x == 5)
                {
                    Console.WriteLine("Kierroksia 5, lopetetaan ohjelma");
                }

            }
        
        }
    }
}
