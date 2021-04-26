

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace funktiot

{
    class Program
    {


        private static int Tervehdys(string kayttaja)

        {

            

            Console.WriteLine("Anna ikäsi");
            int ikaan = Convert.ToInt32(Console.ReadLine());
            return ikaan;



        }



        static void Main(string[] args)
        {
            string sukupuoli;
            int age;

            Console.WriteLine("Oletko mies vai nainen");
            sukupuoli = Console.ReadLine();
            age = Tervehdys(sukupuoli);
            
            if (sukupuoli == "mies")
            {
                if (age <= 13)
                {
                    Console.WriteLine("Mitä poitsu");
                }
                else if (age == 14 || age <= 25)
                {
                    Console.WriteLine("Mitä nuorimies");
                }
                else if (age == 26 || age <= 56)
                {
                    Console.WriteLine("Olet mies parhaassa iässä");
                }
                else if (age > 56)
                {
                    Console.WriteLine("Kunnioitettava ikä");
                }
            }
            else if (sukupuoli == "nainen")
            {
                if (age <= 13)
                {
                    Console.WriteLine("Mitä tyttö");
                }
                else if (age == 14 || age <= 25)
                {
                    Console.WriteLine("Mitä nuorinainen");
                }
                else if (age == 26 || age <= 56)
                {
                    Console.WriteLine("Olet nainen parhaassa iässä");
                }
                else if (age > 56)
                {
                    Console.WriteLine("Kunnioitettava ikä");
                }
            }
        }
    }
}