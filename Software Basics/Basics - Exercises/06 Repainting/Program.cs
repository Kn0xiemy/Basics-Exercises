using System;

namespace _06_Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read data from the console
            // Amount of nilon per square meter - whole number - int (1.50 BGN) + 2 square meters
            // Paint - int - litres (14.50 per litre) + 10% cost
            // Разредител (5 BGN per litre)
            // Hours spent working - int
            int nylonQuantity = int.Parse(Console.ReadLine())+2;

            double paintLitres = double.Parse(Console.ReadLine());
            paintLitres = paintLitres + paintLitres * 0.1;

            int thinnerLitres = int.Parse(Console.ReadLine());
            int workingTime = int.Parse(Console.ReadLine());



            // 2. How much each material costs

            double nylonPrice = nylonQuantity * 1.50;

            double paintPrice = paintLitres * 14.50;
            double thinnerPrice = thinnerLitres * 5;
            // 3. Total cost for materials (+ 0.40 for a bag)

            double materialsCost = nylonPrice + paintPrice + thinnerPrice + 0.40;

            // 4. Calculating the total price for the work of the employees (30% from the materials cost)
            double workingPrice = materialsCost * 0.3 * workingTime;

            // 6. Finding the total cost for materials + work
            double totalSum = materialsCost + workingPrice;
            Console.WriteLine(totalSum);
        }
    }
}
