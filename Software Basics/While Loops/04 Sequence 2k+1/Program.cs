using System;

namespace _04_Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currentNum = 1;

            while (currentNum <= n)
            {
                Console.WriteLine(currentNum);

                currentNum = currentNum * 2 + 1;
            }
        }
    }
}
