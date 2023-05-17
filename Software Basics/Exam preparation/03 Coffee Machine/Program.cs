using System;

namespace _03_Coffee_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string drinkType = Console.ReadLine();
            string sugarSelect = Console.ReadLine();
            int drinksCount = int.Parse(Console.ReadLine());

            double pricePerDrink = 0;
            if (drinkType == "Espresso")
            { 
                if (sugarSelect == "Without")
                {
                    pricePerDrink = 0.9;
                }
                else if (sugarSelect == "Normal")
                {
                    pricePerDrink = 1.0;
                }
                else if (sugarSelect == "Extra")
                {
                    pricePerDrink = 1.20;
                }
            }
            else if (drinkType == "Cappucino")
            {
                if (sugarSelect == "Without")
                {
                    pricePerDrink = 1.0;
                }
                else if (sugarSelect == "Normal")
                {
                    pricePerDrink = 1.20;
                }
                else if (sugarSelect == "Extra")
                {
                    pricePerDrink = 1.60;
                }
            }
            else if (drinkType == "Tea")
            {
                if (sugarSelect == "Without")
                {
                    pricePerDrink = 0.50;
                }
                else if (sugarSelect == "Normal")
                {
                    pricePerDrink = 0.60;
                }
                else if (sugarSelect == "Extra")
                {
                    pricePerDrink = 0.70;
                }
            }
            double totalPrice = drinksCount * pricePerDrink;
            
            if (sugarSelect == "Without")
            {
                totalPrice -= totalPrice * 0.35;
            }
            if (drinkType == "Espressp" && drinksCount >= 5)
            {
                totalPrice -= totalPrice * 0.25;
            }
            if (totalPrice > 15 )
            {
                totalPrice -= totalPrice * 0.20;
            }
            Console.WriteLine($"You bought {drinksCount} cups of {drinkType} for {totalPrice} lv.");
        }
    }
}
