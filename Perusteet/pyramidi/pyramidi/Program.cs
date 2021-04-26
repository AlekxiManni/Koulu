using System;

namespace pyramidi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, rows;

            Console.Write("Enter number of rows");
            rows = Convert.ToInt16(Console.ReadLine());

            for (a = 1; a <= rows; a++)
            {
                for (b = 1; b <= a; b++)
                {
                    Console.Write(rows);
                }
                Console.WriteLine();
            }




        }
    }
}
