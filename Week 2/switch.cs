using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a grade (1 to 7):");

        string input = Console.ReadLine();

        int grade = Int32.Parse(input);

        // Use switch to classify the grade
        // IMPORTANT NOTE: The switch statement can accept different data types, such as int, char, string, etc.
        switch (grade)
        {
            case 7:
                Console.WriteLine("High Distinction");
                break;
            case 6:
                Console.WriteLine("Distinction");
                break;
            case 5:
                Console.WriteLine("Credit");
                break;
            case 4:
                Console.WriteLine("Pass");
                break;
            case 3:
            case 2:
            case 1:
                Console.WriteLine("Fail");
                break;
            default:
                Console.WriteLine("Invalid grade. Please enter a number between 1 and 7.");
                break;
        }
        
    }
}
