// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApplications
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select the application you want to run:");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        GradeCalculator gradeCalculator = new GradeCalculator();
                        gradeCalculator.Run();
                        break;
                    case 2:
                        TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();
                        ticketPriceCalculator.Run();
                        break;
                    case 3:
                        TriangleTypeIdentifier triangleTypeIdentifier = new TriangleTypeIdentifier();
                        triangleTypeIdentifier.Run();
                        break;
                    case 4:
                        Console.WriteLine("Exiting the application. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
