using System;

namespace _05_Godzilla_vs_KingKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            double numberOfStatists = double.Parse(Console.ReadLine());
            double priceOfStatist = double.Parse(Console.ReadLine());

            double decor = movieBudget - (movieBudget * 0.10)

;           double clothing = numberOfStatists * priceOfStatist;

            double moviePrice = decor + clothing;

            double finalPrice = movieBudget - moviePrice;

            if (numberOfStatists > 150 )
            {
                numberOfStatists = numberOfStatists - (numberOfStatists * 0.10);
            }

            else if (moviePrice > movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {finalPrice} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {finalPrice} leva left.");
            }
        }
    }
}
