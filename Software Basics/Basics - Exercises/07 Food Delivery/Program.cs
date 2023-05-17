using System;

namespace _07_Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fish Menu - 12.40 BGN
            // Chicken Menu - 10.35 BGN
            // Vegetarion Menu - 8.15 BGN

            double chickenMenu = double.Parse(Console.ReadLine());
            double fishMenu = double.Parse(Console.ReadLine());
            double vegetarianMenu = double.Parse(Console.ReadLine());

            // Giving value to the menus
            double chickenPrice = chickenMenu * 10.35;
            double fishPrice = fishMenu * 12.40;
            double vegetarianPrice = vegetarianMenu * 8.15;

            // Food total alone
            double deliveryTotal = chickenPrice + fishPrice + vegetarianPrice;

            // Desert cost = 20% of total amount
            double desert = deliveryTotal + (deliveryTotal * 0.20);

            // Delivery charge = 2.50BGN
            double deliveryCharge = desert + 2.50;

            Console.WriteLine(deliveryCharge);
        }
    }
}
