using System;

namespace _05_School_Supplies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Packet of Pens - 5.80 lv
            // 2. Packet of Markers - 7.20 lv
            // 3. Cleaner - 1.20 per liter

            double pens = double.Parse(Console.ReadLine());
            double markers = double.Parse(Console.ReadLine());
            double litresOfCleaner = double.Parse(Console.ReadLine());

            double penPrice = pens * 5.80;
            double markerPrice = markers * 7.20;
            double cleanerPrice = litresOfCleaner *1.20;

            double sumOfMaterials = penPrice + markerPrice + cleanerPrice;

            double discountedPrice = sumOfMaterials - (sumOfMaterials * 0.25);

            Console.WriteLine(discountedPrice);


        }
    }
}
