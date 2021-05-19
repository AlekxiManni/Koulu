using System;

namespace Tehtava18
{
    class Program
    {

        static void Vaihe1()
        {

            string virtanen;

            virtanen = Console.ReadLine();

            Console.WriteLine(virtanen);

            char[] merkkijono = virtanen.ToCharArray();

            for (int i = 0; i <= virtanen.Length; i += 1)
            {
                virtanen = virtanen.Insert(i, " ");
                i++;
            }
            Console.WriteLine(virtanen);
            Array.Reverse(merkkijono);
            foreach (char merkki in merkkijono)
            {
                Console.Write(merkki + " ");
            }

        }


        //static void Vaihe2()

        //{

        //    string virtanen = "Virtanen";
        //    Console.WriteLine(virtanen);

        //    Console.WriteLine("ensimmäinen a -kirjaimen on merkkijonossa paikalla " + virtanen.IndexOf("a"));

        //}


        //static void Vaihe3()
        
        
        //{

        //    string syote =  "Mikko Virtanen";
        //    string[] sanat = syote.Split(" ");


        //    foreach (string sana in sanat)
        //    {
        //        Console.WriteLine(sana);
        //    }

        //    foreach (string sana in sanat)
        //    {
        //        foreach (char merkki in sana)
        //        {
        //            Console.Write(merkki + " ");
        //        }
        //        Console.WriteLine();
        //    }


        //    char[] merkkijono = syote.ToCharArray();

        //    for (int i = merkkijono.Length-1; i >= 0; i--)
        //    {
        //        if (merkkijono[i] == ' ')
        //        {
        //            Console.WriteLine();
        //        }
        //        else
        //        {
        //            Console.Write(merkkijono[i] + " ");
        //        }
                    
                
        //    }


        //}







        static void Main(string[] args)
        {
        Vaihe1();
        //Vaihe2();
        //Vaihe3();
    }
    }
}
