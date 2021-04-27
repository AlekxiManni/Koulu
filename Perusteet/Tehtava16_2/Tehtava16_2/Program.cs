using System;

namespace Tehtava16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int arvosana;

            Console.WriteLine("Anna arvosana 4-10");
            arvosana = Convert.ToInt32(Console.ReadLine());

            switch(arvosana)
            {
                case 4:
                    Console.WriteLine("Hylätty");
                    break;

                case 5:
                    Console.WriteLine("Huono");
                    break;

                case 6:
                    Console.WriteLine("Välttävä");
                    break;

                case 7:
                    Console.WriteLine("Tyydyttävä");
                    break;

                case 8:
                    Console.WriteLine("Hyvä");
                    break;

                case 9:
                    Console.WriteLine("Kiitettävä");
                    break;

                case 10:
                    Console.WriteLine("Erinomainen");
                    break;

                default:
                    Console.WriteLine("Annoit virheellisen arvosanan, ohjelma suljetaan");
                    break;

            }

            
        }
    }
}
