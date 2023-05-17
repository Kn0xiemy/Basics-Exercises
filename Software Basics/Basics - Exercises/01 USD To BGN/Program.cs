using System;

namespace _01_USD_To_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Read USD from the console

            double usd = double.Parse(Console.ReadLine());


            //2. Convert USD to BGN - 1 USD = 1.79549 BGN

            double bgn = usd * 1.79549;

            //3. Writing the result into the console

            Console.WriteLine(bgn);
        }
    }
}
