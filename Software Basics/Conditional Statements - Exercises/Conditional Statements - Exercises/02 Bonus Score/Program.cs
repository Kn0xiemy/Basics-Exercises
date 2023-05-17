using System;

namespace _02_Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Reading a number from the console

            int num = int.Parse(Console.ReadLine());

            double bonus = 0;
            // 2. First checks to find the diapazon of the number
            if (num <= 100)
            {
                bonus = 5;
            }
            else if (num > 1000)
            {
                bonus = num * 0.10;
            }
            else
            {
                bonus = num * 0.20;
            }

            if (num % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if (num % 10 == 5)
            {
                bonus = bonus + 2;
            }
            // => num <= 100 = Bonus is 5 points
            // => num > 1000 = bonus = 10% of the number
            // => else  => num is between 100 and 1000 = 20% of the number 

            // 3. Making a couple of if statements for the additional bonus
            // - When we have even numbers - + 1 point
            // - When we have numbers ending on 5 - + 2 points

            // 4. Writing the result on the console:
            // Bonus
            // bonus + number
            Console.WriteLine(bonus);
            Console.WriteLine(bonus + num);
        }
    }
}
