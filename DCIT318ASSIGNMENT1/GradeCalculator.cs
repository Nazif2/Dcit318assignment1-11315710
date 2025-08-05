using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Grade Calculator");
        Console.Write("Enter a numerical grade (0-100): ");

        // Get input and validate
        if (double.TryParse(Console.ReadLine(), out double grade))
        {
            // Check if grade is within valid range
            if (grade >= 0 && grade <= 100)
            {
                // Determine letter grade
                string letterGrade = grade switch
                {
                    >= 90 => "A",
                    >= 80 => "B",
                    >= 70 => "C",
                    >= 60 => "D",
                    _ => "F"
                };

                Console.WriteLine($"Your letter grade is: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Error: Grade must be between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}