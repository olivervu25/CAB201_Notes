using System;

namespace Week7_samples
{
    // Parent Class (Superclass/Base class): A class that is inherited from
    // Child Class (Subclass/Derived class): A class that inherits from the parent class 

    // Parent Class 
    class Animal
    {
        // Fields
        private string name;
        private int age;

        // Constructor
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age; 
        }

        // Method
        public void Eat()
        {
            Console.WriteLine($"{name} is eating."); 
        }
    }

    // Child class
    // We use the colon (:) to inherit from a parent class
    class Cat : Animal
    {
        // Field
        // Unique field for the Cat class. We don't need to declare the fields from the parent class
        private string breed;

        // Constructor
        // We use the base keyword to call the constructor of the parent class
        public Cat (string name, int age, string breed) : base(name, age)
        {
            this.breed = breed; 
        }
    }

    // Child class
    class Dog : Animal
    {

        // There is no unique field for the Dog class so we don't need to declare any fields

        // Constructor
        public Dog(string name, int age) : base(name, age)
        {
                // We don't need to do anything here
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // We can create an object cat from the Cat class
            Cat my_cat = new Cat("Kitty", 3, "British Shorthair");

            my_cat.Eat();

            // We cannot create an object of Cat from the Animal class 
            // Cat second_cat = new Animal("Kitty", 3);

            Animal my_animal = new Cat("Hello", 3, "Brithish Shorthair");

            Dog my_dog = new Dog("Mic", 4);

            my_dog.Eat();

        }
    }
}
