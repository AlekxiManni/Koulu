using System;
using System.IO;

namespace Tehtava19
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"rrrrrrrrrrr.txt");
            Console.WriteLine("Alkuperäinen");
            char[] tehtava = text.ToCharArray();
            Console.WriteLine(tehtava);
            Console.WriteLine();
            Console.WriteLine("Uusi");
            bool pilkku = true;
            bool isolla = true;



            for (int i = 0 ; i < tehtava.Length; i++)
            {
                string kirjain = tehtava[i].ToString();

                switch (kirjain)
                {
                    
                    case ",":
                        if (pilkku == true)
                        {
                            Console.Write(kirjain);
                            pilkku = false;
                        }
                        else
                        {
                            pilkku = true;
                        }
                        break;

                    case "{":
                        break;
                    
                    case "]":
                        isolla = true;
                        pilkku = true;

                        break;
                    case "[":
                        isolla = false;
                        Console.WriteLine();
                        break;
                    case "}":
                    Console.WriteLine();
                        break;

                    default:
                        if (isolla == true)
                        {
                            Console.Write(kirjain.ToUpper());
                        }
                        else
                        {
                            Console.Write(kirjain);
                        }
                        break;
                }
            }

        }
    }
}
