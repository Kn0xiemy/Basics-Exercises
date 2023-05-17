using System;

namespace _05_Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double productPrice = 0;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    productPrice = 0.5;
                }
                else if (product =="water")
                {
                    productPrice = 0.8;
                }
                else if (product =="beer")
                {
                    productPrice = 1.2;
                }
                else if (product == "sweets")
                {
                    productPrice = 1.45;
                }
                else if (product == "peanuts")
                {
                    productPrice = 1.6;
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    productPrice = 0.4;
                }
                else if (product =="water")
                {
                    productPrice = 0.7;
                }
                else if (product == "beer")
                {
                    productPrice = 1.15;
                }
                else if(product =="sweets")
                {
                    productPrice = 1.3;
                }
                else if (product == "peanuts")
                {
                    productPrice = 1.5;
                }

            }
            else if (town =="Varna")
            {
                if (product == "coffee")
                {
                    productPrice = 0.45;
                }
                else if (product == "water")
                {
                    productPrice = 0.7;
                }
                else if (product == "beer")
                {
                    productPrice = 1.1;
                }
                else if (product == "sweets")
                {
                    productPrice = 1.35;
                }
                else if (product == "peanuts")
                {
                    productPrice = 1.55;
                }
            }
            double totalPrice = productPrice * quantity;
            Console.WriteLine(totalPrice);
        }
    }
}
