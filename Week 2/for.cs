using System;

class Program
{
    static void Main()
    {
        // Print numbers from 1 to 1000
        Console.WriteLine("Numbers from 1 to 1000:");
        for (int i = 1; i <= 1000; i++)
        {
            Console.WriteLine(i);
        }

        // Print numbers from 1000 to 1
        Console.WriteLine("\nNumbers from 1000 to 1:");
        for (int i = 1000; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        //IMPORTANT NOTE: You NEED to define the data type for i (iterating variable in the for loop).
    }
}
