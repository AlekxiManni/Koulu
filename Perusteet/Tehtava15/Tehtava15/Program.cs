using System;

namespace Tehtava15
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            try
            {
                Console.WriteLine("Anna jakaja ja jaettava");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x / y);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Yritit jakaa 0");
            }
            catch (FormatException)
            {
                Console.WriteLine("Anna numero!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Et antanut numeroa");
            }
            finally
            {
                Console.WriteLine("Kiitos ohjelman käytöstä!");
            }

        }
    }
}
