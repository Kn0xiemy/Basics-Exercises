using System;

namespace _03_Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read data from the console (Deposited amount, length of the deposit, yearly tax percentage)

            double deposit = double.Parse(Console.ReadLine());

            int term = int.Parse(Console.ReadLine());

            double rate = double.Parse(Console.ReadLine());

            // 2. Calculating the sum by the formula given in the exercise - deposited sum  + length of deposit * ((deposited sum * yearly tax percentage ) / 12)

            double sum = deposit + term * (deposit * rate / 100 / 12);

            // 3. Writing the amount on the console

            Console.WriteLine(sum);

        }
    }
}
