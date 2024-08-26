using System;

class Student
{
    // Public field
    public string Name;

    // Private field
    private int ID;

    // Constructor
    public Student(string name, int id)
    {
        Name = name;
        ID = id;
    }

    // Static method to display a welcome message
    // A static method belongs to the class itself, not to any specific object (or instance) of the class.
    // This means you can call a static method using the class name without needing to create an instance of the class. 
    // In contrast, non-static methods are associated with objects (instances) and can only be called on those specific objects.


    public static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Student Management System!");
    }

    // Instance method to display student info
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, ID: {ID}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Call the static method without creating an object
        Student.DisplayWelcomeMessage();

        // Create a Student object
        Student student = new Student("Alice", 123456);

        // Access public field and instance method
        Console.WriteLine($"Student Name: {student.Name}");
        student.DisplayInfo();

        // Note: Cannot access private field ID directly
        // Console.WriteLine(student.ID); // Error: 'Student.ID' is inaccessible due to its protection level
    }
}
