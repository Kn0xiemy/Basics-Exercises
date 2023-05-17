using System;

namespace _01_Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();

            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());


            double income = 0.0;

            if (projection == "Premiere")
            {
                income = rows * columns * 12.00;
            }
            else if (projection == "Normal")
            {
                income = rows * columns * 7.50;
            }
            else if (projection == "Discount")
            {
                income = rows * columns * 5.00;
            }
            Console.WriteLine($"{income:F2} leva");
        }
    }
}
