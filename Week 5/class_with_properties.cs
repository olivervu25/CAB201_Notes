using System;

class Student
{
    // Private fields
    private int id;
    private string name;
    private float gpa;

    // Property for ID
    public int ID
    {
        get { return id; }
        set
        {
            id = value; // value is a keyword that represents the value assigned to the property
        }
    }

    // Property for Name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Property for GPA
    public float GPA
    {
        get { return gpa; }
        set
        {
            if (value >= 0.0f && value <= 7.0f)
            {
                gpa = value;
            }
            else
            {
                Console.WriteLine("GPA must be between 0.0 and 7.0.");
            }
        }
    }

    // Method: Display information
    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {ID}, Name: {Name}, GPA: {GPA}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a new Student object
        Student student = new Student();

        // Setting properties using the set accessor
        student.ID = 123456;
        student.Name = "Alice";
        student.GPA = 7.0f;

        // Displaying student information
        student.DisplayInfo();
    }
}
