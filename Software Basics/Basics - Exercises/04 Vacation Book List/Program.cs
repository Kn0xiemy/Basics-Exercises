using System;

namespace _04_Vacation_Book_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read data from the console
            // Pages - int
            // PagesPerHour - int
            // Days - int
            int page = int.Parse(Console.ReadLine());
            int pagePerHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            // 2. Find total time: number of pages/ pages per hour

            int totalHours = page / pagePerHours;

            // 3. Find how many hours per day needs to be spend reading: total time reading

            int hoursPerDay = totalHours / days;

            // Result

            Console.WriteLine(hoursPerDay);
        }
    }
}
