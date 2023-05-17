using System;

namespace _09_Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1л=1 дм3
            int lengthOfAquarium = int.Parse(Console.ReadLine());
            int widthOfAquarium = int.Parse(Console.ReadLine());
            int heightOfAquarium = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double dimensions = lengthOfAquarium * widthOfAquarium * heightOfAquarium;

            double volume = dimensions / 1000;

            double occupiedSpace = volume * (1 -  percent / 100);

            Console.WriteLine(occupiedSpace);
        }
    }
}
