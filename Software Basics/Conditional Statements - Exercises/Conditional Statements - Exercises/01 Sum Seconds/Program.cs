using System;

namespace _01_Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Reading data from the console - What is the time for each contestant(seconds)
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine()); 

            // 2. Find out what is the total time for all three contestans

            int totalTime = first + second + third;

            // 3. Finding how many seconds and how many minutes is the total time.

            int min = totalTime / 60;   
            int seconds = totalTime % 60; 

            // 4. Writing result on console(Minutes:seconds => leading 0 if they are less than 10 seconds)

            if (seconds < 10)
            {
                Console.WriteLine($"{min}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{min}:{seconds}");
            }
        }
    }
}
