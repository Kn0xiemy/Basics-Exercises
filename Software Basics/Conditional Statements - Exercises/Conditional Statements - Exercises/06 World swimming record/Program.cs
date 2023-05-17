using System;
using System.Diagnostics.Tracing;

namespace _06_World_swimming_record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Reading from the console ( record, distance, time for swimming throgh 1m)
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            // 2. Calculating the time in which Ivan swam the distance.
            double delay = Math.Floor(distance / 15) * 12.5;

            // 3. Calculating the slow-down ( every 15m, slowed by 12.5s)
            double recordByIvan = distance * timePerMeter + delay;

            if (recordByIvan < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {recordByIvan:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(worldRecord - recordByIvan):F2} seconds slower.");
            }

            // Number of slowdowns has to be rounded down to the next number - Math.Floor

            // 4. Towards the time of Ivan, we add the slowdown

            // 5. Checking if he managed to beat the record.
            
        }
    }
}
