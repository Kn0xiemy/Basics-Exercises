using System;

namespace _07_Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            string dayOfTheWeek = Console.ReadLine();

            if (time >= 10 && time <= 18)
            {
                if (dayOfTheWeek == "Monday" || dayOfTheWeek == "Tuesday" || dayOfTheWeek == "Wednesday" || dayOfTheWeek == "Thursday" || dayOfTheWeek == "Friday" || dayOfTheWeek == "Saturday")
                {
                    Console.WriteLine("open");
                }
            }
            else if (time < 10 && time > 18)
            {
                if (dayOfTheWeek == "Friday")
                {
                    Console.WriteLine("closed");
                }
            }
        }
    }
}
