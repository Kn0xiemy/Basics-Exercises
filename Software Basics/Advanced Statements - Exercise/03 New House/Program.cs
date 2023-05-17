using System;

namespace _03_New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double priceOfRoses = 5;
            double priceOfDahlias = 3.80;
            double priceOfTulips = 2.80;
            double priceOfNarcissus = 3;
            double priceOfGladiolus = 2.50;

            double finalPrice = 0;

            if (flower == "Roses")
            {
                if (countOfFlowers > 80)
                {
                    //priceOfRoses = PriceOfRoses - (PriceOfRoses * 0.1);
                    priceOfRoses *= 0.9;
                }
                finalPrice = countOfFlowers * priceOfRoses;
            }
            else if (flower == "Dahlias")
            {
                if (countOfFlowers > 90)
                {
                    priceOfDahlias *= 0.85;
                }
                finalPrice = countOfFlowers * priceOfDahlias;
            }
            else if (flower == "Tulips")
            {
                if (countOfFlowers > 80)
                {
                    priceOfTulips *= 0.85;
                }
                finalPrice = countOfFlowers * priceOfTulips;
            }
            else if (flower == "Narcissus")
            {
                if (countOfFlowers < 120)
                {
                    priceOfNarcissus *= 1.15;
                }
                finalPrice = countOfFlowers * priceOfNarcissus;
            }
            else if (flower == "Gladiolus")
            {
                if (countOfFlowers < 80)
                {
                    priceOfGladiolus *= 1.20;
                }
                finalPrice = countOfFlowers * priceOfGladiolus;
            }
            if (budget >= finalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {flower} and {budget - finalPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(budget - finalPrice):F2} leva more.");
            }

        }
    }
}
