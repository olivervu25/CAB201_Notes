using System;

// A class in C# is a blueprint or template for creating objects. 
// It defines a set of properties (fields) and methods (functions) 
// that describe the behavior and characteristics of the objects created from the class. 
// A class can include fields, properties, methods, constructors, and other members.
class Student
{
    // Fields
    public int ID;
    public string Name;
    public double GPA;

    // Constructor 1: Parameterless constructor
    public Student()
    {
        ID = 0;
        Name = "Unknown";
        GPA = 0.0;
    }

    // Constructor 2: Constructor with parameters
    public Student(int id, string name, double gpa)
    {
        ID = id;
        Name = name;
        GPA = gpa;
    }

    // Method: Display information
    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {ID}, Name: {Name}, GPA: {GPA}");
    }
}

// An object in C# is an instance of a class. 
// When a class is defined, no memory is allocated until an object is created from the class. 
class Program
{
    static void Main(string[] args)
    {
        // Creating the first object using the parameterless constructor
        Student student1 = new Student();
        student1.DisplayInfo();

        // Creating the second object using the constructor with parameters
        Student student2 = new Student(123456, "Alice", 7.0f);
        student2.DisplayInfo();
    }
}
