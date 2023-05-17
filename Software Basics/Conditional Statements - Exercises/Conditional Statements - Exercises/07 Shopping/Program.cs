using System;

namespace _07_Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rigBudget = double.Parse(Console.ReadLine());
            double gpu = int.Parse(Console.ReadLine());
            double cpu = int.Parse(Console.ReadLine());
            double ram = int.Parse(Console.ReadLine());

            double gpuPrice = gpu * 250;
            double cpuPrice = cpu * (gpuPrice - (gpuPrice * 0.65));
            double ramPrice = ram * (gpuPrice - (gpuPrice * 0.90));

            double totalPrice = gpuPrice + cpuPrice + ramPrice;

            if (gpu > cpu)
            {
                totalPrice = totalPrice - totalPrice * 0.15;
            }

            if (rigBudget >= totalPrice)
            {
               Console.WriteLine($"You have {rigBudget - totalPrice:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(rigBudget - totalPrice):F2} leva more!");
            }
        }
    }
}
