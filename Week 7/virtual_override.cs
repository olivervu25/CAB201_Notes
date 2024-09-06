using System;

namespace Week7_samples
{
    // Virtual methods: A method that can be overridden in a child class
    // Override: A method that is redefined in a child class

    // Parent Class
    class Animal
    {
        protected string name;
        private int age;

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Virtual method
        // We use the virtual keyword to allow the method to be overridden in a child class
        public virtual void MakeSound()
        {
            Console.WriteLine($"{name} is making a sound"); 
        }
    }

    // Child class
    class Cat : Animal
    {
        private string breed;

        public Cat(string name, int age, string breed) : base(name, age)
        {
            this.breed = breed; 
        }

        // Override method
        // It needs to have the same name as the parent class method
        // We use the override keyword to override the method
        public override void MakeSound()
        {
            Console.WriteLine($"{name} says: Meow!"); 
        }
    }

    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
            // We don't need to do anything here
        }

        // If we don't override the method, the parent class method will be used
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat my_cat = new Cat("Kitty", 2, "British Shorthair");

            // The MakeSound method in the Cat class will be called
            my_cat.MakeSound();

            Animal my_animal = new Animal("Mic", 3);

            // The MakeSound method in the Animal class will be called
            my_animal.MakeSound(); 

        }

    }
}
