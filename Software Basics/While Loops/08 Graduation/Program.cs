using System;
using System.Dynamic;

namespace _08_Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int currentGrade = 1;
            int totalGrade = 0;
            bool isExcluded = false;
            double marksSum = 0;
            int repeats = 0;

            while (currentGrade <=12)
            {
                double currentMark = double.Parse(Console.ReadLine());

                if (currentMark < 4)
                {
                    repeats++;
                    if (repeats > 1)
                    {
                        isExcluded = true;
                        break;
                    }
                    continue;
                }
                marksSum += currentMark;
                currentGrade++;
            }
            if (isExcluded)
            {
                Console.WriteLine($"{name} has been excluded at {currentGrade} grade");
            }
            else
            {
                double average = marksSum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
            }

        }
    }
}
