using System;

namespace LambdaExpressionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter two double values
            Console.Write("Enter the first double value: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second double value: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Lambda expression to add the numbers
            var sum = (double x, double y) => x + y;

            // Lambda expression to multiply the numbers
            var multiplyNumbers = (double x, double y) => x * y;

            // Lambda statement to compare and return the smaller value
            var getSmallerValue = (double x, double y) =>
            {
                if (x < y)
                    return x;
                else
                    return y;
            };
            Console.WriteLine("");

            // Using each lambda expression in Console.WriteLine statements
            Console.WriteLine($"Sum of {num1} and {num2} is: {sum(num1, num2)}");
            Console.WriteLine("");
            Console.WriteLine($"Product of {num1} multiply by {num2} is: {multiplyNumbers(num1, num2)}");
            Console.WriteLine("");
            Console.WriteLine($"Smaller value between {num1} and {num2} is: {getSmallerValue(num1, num2)}");
        }
    }
}
