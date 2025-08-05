using System;

class TicketPriceCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ticket Price Calculator");

        while (true)
        {
            Console.Write("Enter your age (or 'q' to quit): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
                break;

            if (int.TryParse(input, out int age))
            {
                if (age >= 0 && age <= 120) // Added upper bound for realistic age
                {
                    double ticketPrice = (age <= 12 || age >= 65) ? 7.00 : 10.00;
                    Console.WriteLine($"Ticket Price: GHC {ticketPrice:F2}");
                    break; // Exit after successful calculation
                }
                else
                {
                    Console.WriteLine("Error: Age must be between 0 and 120.");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid number or 'q' to quit.");
            }
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}