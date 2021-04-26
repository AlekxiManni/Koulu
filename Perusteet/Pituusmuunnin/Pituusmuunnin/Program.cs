using System;

namespace Pituusmuunnin
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;            //x=senttejä
            float a = 100f;      //a=metrejä
            float b = 160934.4f; //b=maileja
            float c = 91.44f;   //c=jaardeja
            float d = 2.54f;    //d=tuumia
            Console.WriteLine("Hei, miten pitkä olet senttimetreinä?");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Sinun pituutesi metreinä: ");
            Console.WriteLine(Math.Round(x / a,2));
            Console.WriteLine("Sinun pituutesi maileina ");
            Console.WriteLine(Math.Round(x / b,2));
            Console.WriteLine("Sinun pituutesi jaardeina ");
            Console.WriteLine(Math.Round(x / c,2));
            Console.WriteLine("Sinun pituutesi tuumina ");
            Console.WriteLine(Math.Round(x / d,2));
        }
    }
}
