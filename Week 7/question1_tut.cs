using System;

namespace Week7_samples
{
    // Parent Class 
    class Letter
    {
        // Fields
        protected string name;
        protected string date;

        // Constructor
        public Letter(string name, string date)
        {
            this.name = name;
            this.date = date; 
        }

        // Method
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Letter {name} Date sent {date}");
        }
    }

    // Child Class 
    class CertifiedLetter : Letter
    {
        private int tracking_number;

        // Constructor
        public CertifiedLetter(string name, string date, int number) : base(name, date)
        {
            tracking_number = number; 
        }

        // Method

        public override void DisplayInfo()
        {
            Console.WriteLine($"Certified Letter {name} Date sent {date} Tracking Number {tracking_number}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Letter first_letter = new Letter("Don Tree", "21/01/0012");
            CertifiedLetter second_letter = new CertifiedLetter("Luke Tree", "21/12/2024", 1);

            first_letter.DisplayInfo();
            second_letter.DisplayInfo(); 
        }

    }
}
