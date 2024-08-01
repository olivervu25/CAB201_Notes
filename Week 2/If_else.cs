using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");

        //IMPORTANT NOTE: Console.ReadLine() only returns a string. 
        string input = Console.ReadLine();

        int number = Int32.Parse(input);
        //IMPORTANT NOTE: Int32.Parse() can only convert a (number) STRING to an integer.
        // Convert.ToInt32() can convert a string, double, or float to an integer.
        
        // Check if the number is positive, zero, or negative
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number == 0)
        {
            Console.WriteLine("The number is zero.");
        }
        else
        {
            Console.WriteLine("The number is negative.");
        }
    }
}
