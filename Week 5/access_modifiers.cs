using System;

class Person
{
    // Private field
    private string socialSecurityNumber;

    // Public field
    public string name;

    // Constructor
    public Person(string name, string ssn)
    {
        this.name = name;
        this.socialSecurityNumber = ssn;
    }

    // Public method to display info
    public void DisplayInfo()
    {
        // Accessing both public and private fields inside the class
        Console.WriteLine($"Name: {name}, SSN: {socialSecurityNumber}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a new Person object
        Person person = new Person("John Doe", "123-45-6789");

        // Accessing the public field
        Console.WriteLine($"Name: {person.name}");

        // Attempting to access the private field (will cause an error)
        // Console.WriteLine($"SSN: {person.socialSecurityNumber}"); // Error: 'Person.socialSecurityNumber' is inaccessible due to its protection level

        // Accessing private field via public method
        person.DisplayInfo();
    }
}
