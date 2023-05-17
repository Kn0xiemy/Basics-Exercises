using System;

namespace _02_Radians_To_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Reading Radians from the console HOMEWORK

            // 2. Converting Radians to Degrees (   Degrees = Radian * 180 / PI)

            // 3. Writing the degrees on the console

            double radians = double.Parse(Console.ReadLine());

            double degrees = radians * 180 / Math.PI;

            Console.WriteLine(degrees);
        }
    }
}
