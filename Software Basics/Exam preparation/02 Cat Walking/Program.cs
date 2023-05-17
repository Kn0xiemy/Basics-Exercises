using System;

namespace _02_Cat_Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutesPerWalk = int.Parse(Console.ReadLine());
            int walksPerDay = int.Parse(Console.ReadLine());
            int caloriesTaken = int.Parse(Console.ReadLine());

            int totalMinutesWalked = walksPerDay * minutesPerWalk;
            int totalCaloriesBurned = minutesPerWalk * 5;

            double halfCalories = caloriesTaken * 0.5;

            if (totalCaloriesBurned >= halfCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCaloriesBurned}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCaloriesBurned}.");
            }
        }
    }
}
