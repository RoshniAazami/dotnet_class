using System;

class Calculator
{
    static void Main()
    {
        int a, b, result;
        char op;

        Console.WriteLine("Enter first number:");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter operator (+, -, *, /):");
        op = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        b = Convert.ToInt32(Console.ReadLine());

        switch(op)
        {
            case '+':
                result = a + b;
                Console.WriteLine("Result = " + result);
                break;

            case '-':
                result = a - b;
                Console.WriteLine("Result = " + result);
                break;

            case '*':
                result = a * b;
                Console.WriteLine("Result = " + result);
                break;

            case '/':
                if(b != 0)
                {
                    result = a / b;
                    Console.WriteLine("Result = " + result);
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                break;

            default:
                Console.WriteLine("Invalid operator");
                break;
        }

        Console.ReadLine();
    }
}