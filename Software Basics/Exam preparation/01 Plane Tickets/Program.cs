using System;

namespace _01_Plane_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string airline = Console.ReadLine();
            int adultTicket = int.Parse(Console.ReadLine());
            int childTicket = int.Parse(Console.ReadLine());

            double adultTicketPrice = double.Parse(Console.ReadLine());
            double processFee = double.Parse(Console.ReadLine());

            double childTicketPrice = adultTicketPrice - (0.7 * adultTicketPrice);

            adultTicketPrice += processFee;
            childTicketPrice += processFee;

            double totalTicketsPrice = (childTicket * childTicketPrice) + (adultTicket * adultTicketPrice);

            double totalProfit = 0.2 * totalTicketsPrice;

            Console.WriteLine($"The profit of your agency from {airline} tickets is {totalProfit:F2} lv.");

        }
    }
}
