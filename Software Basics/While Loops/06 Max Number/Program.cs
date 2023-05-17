using System;

namespace _06_Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;

            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                int currentNumber = int.Parse(input);
                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
