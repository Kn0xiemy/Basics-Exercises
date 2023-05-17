    using System;

    class Program
    {
        static void Main()
        {

            //Settings some variables that we can have used later down the code
            int adults = 0;
            int kids = 0;
            int toysPrice = 0;
            int sweatersPrice = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Christmas")
                {
                    break;
                }

                int age = int.Parse(input);
                if (age <= 16)
                {
                    kids++;
                    toysPrice += 5;
                }
                else
                {
                    adults++;
                    sweatersPrice += 15;
                }
            }


            //printing the result after loop
            Console.WriteLine($"Number of adults: {adults}");
            Console.WriteLine($"Number of kids: {kids}");
            Console.WriteLine($"Money for toys: {toysPrice}");
            Console.WriteLine($"Money for sweaters: {sweatersPrice}");
        }
    }
