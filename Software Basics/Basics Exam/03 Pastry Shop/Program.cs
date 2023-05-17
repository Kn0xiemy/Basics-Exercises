using System;

namespace _03_Pastry_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sweets = Console.ReadLine();
            int orderedSweets = int.Parse(Console.ReadLine());
            int dayOfDecember = int.Parse(Console.ReadLine());

            double pricePerSweet = 0;

            if (sweets == "Cake")
            {
                if (dayOfDecember <= 15)
                {
                    pricePerSweet = 24.00;
                }
                else if (dayOfDecember > 15)
                {
                    pricePerSweet = 28.70;
                }
            }


            else if (sweets == "Souffle")
            {
                if (dayOfDecember <= 15)
                {
                    pricePerSweet = 6.66;
                }
                else
                {
                    pricePerSweet = 9.80;
                }
            }

            else if (sweets == "Baklava")
            {
                if (dayOfDecember <= 15)
                {
                    pricePerSweet = 12.60;
                }
                else
                {
                    pricePerSweet = 16.98;
                }
            }
            double priceOfOrder = orderedSweets * pricePerSweet;

            if (dayOfDecember <= 22)
            {

                if (priceOfOrder >= 100 && priceOfOrder <= 200)
                {
                    priceOfOrder *= 0.85;
                }
                else if (priceOfOrder > 200)
                {
                    priceOfOrder *= 0.75;
                }
            }

            if (dayOfDecember <= 15)
            {
                priceOfOrder *= 0.90;
            }
            Console.WriteLine($"{priceOfOrder:f2}");

        }
    }
}
