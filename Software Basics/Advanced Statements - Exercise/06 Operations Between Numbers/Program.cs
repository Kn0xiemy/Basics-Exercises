using System;
using System.ComponentModel.Design;

namespace _06_Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            string operation = Console.ReadLine();

            if (operation == "+" || operation == "-" || operation == "*")
            {
                int result = 0;
                string condition = "even";

                if (operation == "+")
                {   
                    result = numberOne + numberTwo; 
                }
                else if (operation == "-")
                {
                    result = numberOne - numberTwo;
                }
                else if (operation == "*")
                {
                    result = numberOne * numberTwo;
                }
                if (result % 2 != 0)
                {
                    condition = "odd";
                }
                Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result} - {condition}");
            }
            else
            {
                if (numberTwo == 0)
                {
                    Console.WriteLine($"Cannot divide {numberOne} by zero");
                }
                else if (operation == "/")
                {
                    double result = (double) numberOne / numberTwo;
                    Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result:F2}");
                }
                else if (operation == "%")
                {
                    int result =  numberOne % numberTwo;
                    Console.WriteLine($"{numberOne} {operation} {numberTwo} = {result}");
                }
            }
        }
    }
}
