using System; // Allows use of Console for input/output

// Create a class called MathOperations
class MathOperations
{
    // Create a void method that takes two integers as parameters
    public void DoMath(int firstNumber, int secondNumber)
    {
        // Perform a math operation on the first integer (multiply by 2)
        int result = firstNumber * 2;

        // Display the result of the math operation
        Console.WriteLine("Result of first number * 2: " + result);

        // Display the second integer
        Console.WriteLine("Second number is: " + secondNumber);
    }
}

// Main program class
class Program
{
    // Entry point of the application
    static void Main(string[] args)
    {
        // Instantiate the MathOperations class
        MathOperations mathObj = new MathOperations();

        // Call the method with two numbers (normal way)
        mathObj.DoMath(5, 10);

        // Call the method using named parameters
        mathObj.DoMath(firstNumber: 7, secondNumber: 20);

        // Keep the console open so you can see the output
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
