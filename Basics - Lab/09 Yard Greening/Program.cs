using System;

namespace _09_Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double pricePerSqMeter = 7.61; 
            double discountRate = 0.18;

            double totalPrice = area * pricePerSqMeter; 
            double discount = totalPrice * discountRate;
            double finalPrice = totalPrice - discount; 

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
