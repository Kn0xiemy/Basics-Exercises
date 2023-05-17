using System;

namespace _06_Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            int vowelsSum = 0;
            // sums must always be set before the loop

            // Default values = always 0 for sum
            // products always start at 1
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (currentChar =='a')
                {
                    vowelsSum += 1;
                }
                else if(currentChar == 'e')
                {
                    vowelsSum += 2;
                }
                else if (currentChar == 'i')
                {
                    vowelsSum += 3;
                }
                else if (currentChar == 'o')
                {
                    vowelsSum += 4;
                }
                else if (currentChar == 'u')
                {
                    vowelsSum += 5;
                }
            }
            Console.WriteLine(vowelsSum);
        }
    }
}
