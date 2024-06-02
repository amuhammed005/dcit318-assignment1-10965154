using System;

namespace ConsoleApplications
{
    public class TicketPriceCalculator
    {
        public void Run()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            int ticketPrice = 10;

            if (age >= 65 || age <= 12)
            {
                ticketPrice = 7;
            }

            Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
        }
    }
}
