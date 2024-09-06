using System;

namespace Week7_samples
{
    // protected: accessible within class and derived classes
    // private: accessible only within the class
    // public: acessible from anywhere
    class Parent
    {
        // Fields
        private int privateNumber = 10;
        protected int protectedNumber = 20;
        public int publicNumber = 30; 
    }

    class Child : Parent
    {
        // Method
        public void AccessTest()
        {
            // We are unable to access privateNumber in Parent Class  because it is private 
            // Console.WriteLine(privateNumber);

            // We can access protectedNumber in Parent Class because it is protected    
            Console.WriteLine(protectedNumber);

            // We can access publicNumber in Parent Class because it is public
            Console.WriteLine(publicNumber); 

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Child class
            Parent first_object = new Parent();

            // We cannot access privateNumber and protectedNumber here
            Console.WriteLine(first_object.publicNumber); 
        }
    }
}
