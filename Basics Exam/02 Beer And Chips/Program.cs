using System;

namespace _02_Beer_And_Chips
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fanName = Console.ReadLine();
            double foodBudget = double.Parse(Console.ReadLine());
            int numberOfBeers = int.Parse(Console.ReadLine());
            int packetsOfChips = int.Parse(Console.ReadLine());

            double beerPrice = numberOfBeers * 1.20;
            double priceOfChips = beerPrice * 0.45;
            double totalChipsPrice = Math.Ceiling(priceOfChips * packetsOfChips);

            double shoppingPrice = totalChipsPrice + beerPrice;

            if (foodBudget >= shoppingPrice)
            {
                double result = Math.Abs(foodBudget - shoppingPrice);
                Console.WriteLine($"{fanName} bought a snack and has {result:f2} leva left.");
            }
            else
            {
                double result = Math.Abs(foodBudget - shoppingPrice);
                Console.WriteLine($"{fanName} needs {result:f2} more leva!");
            }
        }
    }
}

