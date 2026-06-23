using System;

class SumArray
{
    static void Main()
    {
        int[] arr = new int[20];
        int sum = 0;

        Console.WriteLine("Enter 20 numbers:");

        // Input 20 numbers
        for (int i = 0; i < 20; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Calculate sum
        for (int i = 0; i < 20; i++)
        {
            sum += arr[i];
        }

        // Display result
        Console.WriteLine("Sum of 20 numbers = " + sum);

        Console.ReadLine();
    }
}