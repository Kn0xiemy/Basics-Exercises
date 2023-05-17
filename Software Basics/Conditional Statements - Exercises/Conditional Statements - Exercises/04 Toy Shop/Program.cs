using System;

namespace _04_Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double money = puzzles * 2.60 + dolls * 3.00 + bears * 4.10 + minions * 8.20 + trucks * 2.00;

            int toysQuantity = puzzles + dolls + bears + minions + trucks;

            if (toysQuantity >= 50)
            {
                money = money - money * 0.25;
            }

            money = money - money * 0.10;

            if (money >= tripPrice)
            {
                Console.WriteLine($"Yes! {Math.Abs(money - tripPrice):f2} lv left.");
            }

            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(money- tripPrice):f2} lv needed.");
            }
        }
    }
}
