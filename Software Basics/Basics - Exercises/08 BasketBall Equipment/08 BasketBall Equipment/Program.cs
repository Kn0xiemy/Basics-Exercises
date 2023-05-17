using System;

namespace _08_BasketBall_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yearlyPrice = double.Parse(Console.ReadLine());

            double shoes = yearlyPrice - (yearlyPrice * 0.40);

            double basketballSet = shoes - (shoes * 0.20);

            double ball = basketballSet / 4;

            double accessories = ball / 5;

            double cost = shoes + basketballSet + accessories + ball + yearlyPrice;

            Console.WriteLine(cost);
        }
    }
}
