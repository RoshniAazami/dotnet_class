using System;

class ArithmeticOperation
{
    static void Main()
    {
        double num1, num2;

        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n--- Results ---");

        Console.WriteLine("Addition: " + (num1 + num2));
        Console.WriteLine("Subtraction: " + (num1 - num2));
        Console.WriteLine("Multiplication: " + (num1 * num2));

        if (num2 != 0)
            Console.WriteLine("Division: " + (num1 / num2));
        else
            Console.WriteLine("Division: Cannot divide by zero");
    }
}
// output
Addition: 5
Subtraction: 1
Multiplication: 6
Division: 1.5