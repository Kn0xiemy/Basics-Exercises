using System;

namespace _04_Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());

            int musalaHikersCount = 0;
            int monblanHikersCount = 0;
            int kilimanjaroHikersCount = 0;
            int k2HikersCount = 0;
            int everestHikersCount = 0;

            for (int i = 1; i <= groupsCount; i++)
            {
                int groupPeople = int.Parse(Console.ReadLine());

                if (groupPeople <= 5)
                {
                    musalaHikersCount += groupPeople;
                }
                else if (groupPeople <= 12)
                {
                    monblanHikersCount += groupPeople;
                }
                else if (groupPeople <= 25)
                {
                    kilimanjaroHikersCount += groupPeople;
                }
                else if (groupPeople <= 40)
                {
                    k2HikersCount += groupPeople;
                }
                else
                {
                    everestHikersCount += groupPeople;
                }
            }
            double totalHikersCount = musalaHikersCount + monblanHikersCount + kilimanjaroHikersCount + k2HikersCount + everestHikersCount;

            Console.WriteLine($"{musalaHikersCount / totalHikersCount * 100:F2}%");
            Console.WriteLine($"{monblanHikersCount / totalHikersCount * 100:F2}%");
            Console.WriteLine($"{kilimanjaroHikersCount / totalHikersCount * 100:F2}%");
            Console.WriteLine($"{k2HikersCount / totalHikersCount * 100:F2}%");
            Console.WriteLine($"{everestHikersCount / totalHikersCount * 100:F2}%");
        }
    }
}
