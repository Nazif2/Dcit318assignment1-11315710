using System;

class TriangleTypeIdentifier
{
    // Check if sides form a valid triangle using the triangle inequality theorem
    static bool IsValidTriangle(double a, double b, double c)
    {
        return (a + b > c) && (b + c > a) && (a + c > b) && (a > 0) && (b > 0) && (c > 0);
    }

    // Determine triangle type
    static string GetTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
            return "Equilateral";
        else if (a == b || b == c || a == c)
            return "Isosceles";
        else
            return "Scalene";
    }

    static void Main(string[] args)
    {
        try
        {
            // Prompt user for three sides
            Console.Write("Enter the length of first side: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of second side: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of third side: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Check if it's a valid triangle
            if (IsValidTriangle(a, b, c))
            {
                // Determine and display triangle type
                Console.WriteLine($"The triangle is {GetTriangleType(a, b, c)}");
            }
            else
            {
                Console.WriteLine("Invalid triangle: The sides cannot form a triangle.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input: Please enter valid numbers for the sides.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}