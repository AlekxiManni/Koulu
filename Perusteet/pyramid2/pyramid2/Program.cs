using System;

namespace pyramid2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int y = Convert.ToInt32(Console.ReadLine());
            for (int x=0; x <= y; x++)
            {
                for (int i=1;i<=x;i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            
        }
    }
}
