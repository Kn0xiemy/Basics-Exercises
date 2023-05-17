using System;

namespace _09_Fruit_Or_Vegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string groceries = Console.ReadLine();

            switch (groceries)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
