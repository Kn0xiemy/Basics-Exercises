using System;

namespace _08_Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dogFoodCost = 2.50;
            int catFoodCost = 4;

            int dogFoodAmount = int.Parse(Console.ReadLine());
            int catFoodAmount = int.Parse(Console.ReadLine());

            double dogfoodSum = dogFoodAmount * dogFoodCost;
            double catFoodSum = catFoodAmount * catFoodCost;

            double totalSum = dogfoodSum + catFoodSum;

            Console.WriteLine($"{totalSum} lv.");


        }
    }
}
