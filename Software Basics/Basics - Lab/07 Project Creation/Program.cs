using System;

namespace _07_Project_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int buildTime = 3;

            int totalTime = numberOfProjects * buildTime;
            Console.WriteLine($"The architect {architectName} will need {totalTime} hours to complete {numberOfProjects} project/s.");
        }
    }
}
