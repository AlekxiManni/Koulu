using System;

namespace Tehtava8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] hero = 
                {
                
                { "Ana", "Bastion",  "Brigitte",   "D.Va(Mech)"},
                { "Support", "Defense",   "Support",   "Tank" },
                { "200", "200",  "200",   "400" },
                { "0", "100",   "50",   "200" } 
                };

            Console.WriteLine("Valitse Hero");
            Console.WriteLine("1. Ana, 2. Bastion, 3. Brigitte, 4. D.Va(Mech)");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine(hero[0, 0] + "  " + hero[1, 0] + "  " + hero[2, 0] + "  " + hero[3, 0]);
            }
            else if (x == 2)
            {
                Console.WriteLine(hero[0, 1] + "  " + hero[1, 1] + "  " + hero[2, 1] + "  " + hero[3, 1]);
            }
            else if (x == 3)
            {
                Console.WriteLine(hero[0, 2] + "  " + hero[1, 2] + "  " + hero[2, 2] + "  " + hero[3, 2]);
            }
            else if (x == 4)
            {
                Console.WriteLine(hero[0, 3] + "  " + hero[1, 3] + "  " + hero[2, 3] + "  " + hero[3, 3]);
            }
            

        }

    }
}
