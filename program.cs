using System;

class LogisticsEstimator
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user to input the weight of the item
        Console.WriteLine("Please enter the package weight:");
        if (!double.TryParse(Console.ReadLine(), out double massValue))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return;
        }

        // Check if the item exceeds weight restrictions
        if (massValue > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Ask for the first dimension (width)
        Console.WriteLine("Please enter the package width:");
        if (!double.TryParse(Console.ReadLine(), out double edgeOne))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return;
        }

        // Ask for the second dimension (height)
        Console.WriteLine("Please enter the package height:");
        if (!double.TryParse(Console.ReadLine(), out double edgeTwo))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return;
        }

        // Ask for the third dimension (length)
        Console.WriteLine("Please enter the package length:");
        if (!double.TryParse(Console.ReadLine(), out double edgeThree))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return;
        }

        // Sum up dimensions to validate against max size rule
        double combinedEdges = edgeOne + edgeTwo + edgeThree;
        if (combinedEdges > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Apply pricing formula based on dimensional and weight factors
        double finalPrice = (edgeOne * edgeTwo * edgeThree * massValue) / 100;

        // Display final cost to the customer
        Console.WriteLine("Your estimated total for shipping this package is: ${0:0.00}", finalPrice);
        Console.WriteLine("Thank you!");
    }
}
