using System;

namespace _08_Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Reading from the console (name of the show, episode length, length of break)

            string seriesName = Console.ReadLine();
            int seriesTime = int.Parse(Console.ReadLine());
            int lunchTime = int.Parse(Console.ReadLine());

            // 2. Calculating the time that we have left for watching the show

            double timeForSeries = (double)lunchTime * 5 / 8;

            // = > 1/8th for eating and 1/4 for resting
            // = > 1/8 + 1/4
            // = > 8/8 - (1/8 + 2/8)
            // = > 8/8 - 3/8
            // = > 5/8  is left for the show

            // 3. Checking if the length of the episode is bigger than the time we have
            // = > If we have time:
            // You have enough time to watch
            // = < You do not have enough time to watch
            double difference = Math.Abs(timeForSeries - seriesTime);

            if (timeForSeries > seriesTime)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(difference)} minutes free time.");
            }
            else
            {
                Console.WriteLine($" You don't have enough time to watch {seriesName}, you need {Math.Ceiling(difference)} more minutes.");
            }
        }
    }
}
