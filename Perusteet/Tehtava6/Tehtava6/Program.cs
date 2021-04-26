using System;

namespace Tehtava6
{
    class Program
    {
        static void Main(string[] args)
        {
            //KKK, EKK, EEK/KEK, EEE, KKE, EKE,
            
            string aurinko, vesi, temp;
            Console.WriteLine("Vastaa kysymyksiin Kyllä (K) tai Ei (E)");
            Console.WriteLine("Paistaako aurinko?");
            aurinko=Console.ReadLine();
            Console.WriteLine("Sataako ulkona vettä?");
            vesi = Console.ReadLine();
            Console.WriteLine("Onko lämpötila >0?");
            temp = Console.ReadLine();

            if (aurinko == "K" && vesi == "K" && temp == "K")
            {
                Console.WriteLine("Aurinko paistaa ja vettä sataa taitaa tulla kesä");
            }
            else if (aurinko == "E" && vesi == "K" && temp == "K")
            {
                Console.WriteLine("Syksy saapui lehdet vei tuuli mennessään");
            }
            else if (aurinko == "K" | aurinko == "E" && vesi == "E" && temp == "K") 
            {
                Console.WriteLine("Jo joutui armas aika ja suvi suloinen");
            }
            else if (aurinko== "E" && vesi == "E" && temp == "E") 
            {
                Console.WriteLine("Talvella ei aurinko aina tahdo paistaa");
            }
            else if (aurinko == "K" && vesi == "K" && temp == "E")
            {
                Console.WriteLine("Tätä se ilmastonmuutos teettää");
            }
            else if (aurinko == "E" && vesi == "K" && temp == "E")
            {
                Console.WriteLine("Pimeä ja lumisateinen pakkaspäivä");
            }
        }
    }
}
