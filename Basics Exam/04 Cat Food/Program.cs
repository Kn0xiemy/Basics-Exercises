using System;

namespace _04_Cat_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int catCount = int.Parse(Console.ReadLine());

            const double kilogramFood = 12.45;

            int groupOne = 0;
            int groupTwo = 0;
            int groupThree = 0;

            double totalFoodGrams = 0;

            for (int i = 0; i < catCount; i++)
            {
                double gramsOfFood = double.Parse(Console.ReadLine());

                if (gramsOfFood >= 100 && gramsOfFood < 200)
                {
                    groupOne++;
                }
                else if (gramsOfFood >= 200 && gramsOfFood < 300)
                {
                    groupTwo++;
                }
                else if (gramsOfFood >=300 && gramsOfFood <= 400)
                {
                    groupThree++;
                }


                totalFoodGrams += gramsOfFood;

            }

           
            double totalPrice = Math.Round(totalFoodGrams / 1000 * kilogramFood, 2);

            Console.WriteLine($"Group 1: {groupOne} cats.");
            Console.WriteLine($"Group 2: {groupTwo} cats.");
            Console.WriteLine($"Group 3: {groupThree} cats.");
            Console.WriteLine($"Price for food per day: {totalPrice:F2} lv.");
        }
    }
}

