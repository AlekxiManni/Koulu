using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei, mikä sinun nimesi on?");
            string input = Console.ReadLine();
            Console.WriteLine("Hei " + input);
            Console.WriteLine("Minkä ikäinen olet?");
            string intParse = Console.ReadLine();
            Console.WriteLine("Hei " + input + "," + intParse + " !");
            
        }
    }
}
