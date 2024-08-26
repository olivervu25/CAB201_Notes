using System;

class Student
{
    // Public field that can be null
    public string? Name;

    // Constructor
    public Student(string? name)
    {
        Name = name;
    }

    // Method to display student's name with null checking
    public void DisplayInfo()
    {
        // Null check using if statement
        if (Name != null)
        {
            Console.WriteLine($"Student Name: {Name}");
        }
        else
        {
            Console.WriteLine("Student Name is not provided.");
        }
    }

    // Static method demonstrating null coalescing operator
    public static void PrintWelcomeMessage(string? message)
    {
        // Null coalescing: if message is null, use default value
        string welcomeMessage = message ?? "Welcome, student!";
        Console.WriteLine(welcomeMessage);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a Student object with a null name
        Student student1 = new Student(null);
        student1.DisplayInfo(); // Outputs: "Student Name is not provided."

        // Creating a Student object with a non-null name
        Student student2 = new Student("Alice");
        student2.DisplayInfo(); // Outputs: "Student Name: Alice"

        // Using the static method with a null value
        Student.PrintWelcomeMessage(null); // Outputs: "Welcome, student!"

        // Using the static method with a non-null value
        Student.PrintWelcomeMessage("Hello, Alice!"); // Outputs: "Hello, Alice!"
    }
}
