using System;

namespace _01_Mining_Rig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gpuPrice = int.Parse(Console.ReadLine()); // card price
            int cablePrice = int.Parse(Console.ReadLine());// cable price
            double usedElectricityPerDay = double.Parse(Console.ReadLine()); // electrict cost for the day
            double profitPerCardDaily = double.Parse(Console.ReadLine()); // profit at EOD after subtracting the eletricity cost
                                                                          //Fixed 13 gpus and cables
            int gpuCost = gpuPrice * 13;
            int cableCost = cablePrice * 13;

            const int otherComponents = 1000;

            int totalCost = gpuCost + cableCost + otherComponents;

            // 13 cards mining at an example rate of 1,80
            double profitPerDay = (profitPerCardDaily - usedElectricityPerDay) * 13;

            double daysToRecoverFunds = Math.Ceiling(totalCost / profitPerDay);

            Console.WriteLine(totalCost);
            Console.WriteLine(daysToRecoverFunds);

        }
    }
}
