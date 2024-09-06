using System;

namespace Week7_samples
{

    class Photo
    {
        // Fields
        protected double length;
        protected double width;

        // Constructor
        public Photo(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        // Method
        public virtual void DisplayPhoto()
        {
            Console.WriteLine($"Photo Length: {length}, Width: {width}");
        }
    }

    // Child classes 
    class MattedPhoto : Photo
    {
        // Field
        private string colour;

        // Constructor
        public MattedPhoto(double length, double width, string colour) : base(length, width)
        {
            this.colour = colour; 
        }

        // Method
        public override void DisplayPhoto()
        {
            Console.WriteLine($"Matted Photo Length: {length}, Width: {width}, Color: {colour}");

        }
    }

    class FramedPhoto : Photo
    {
        // Field
        private string material;
        private string style; 

        // Constructor
        public FramedPhoto(double length, double width, string material, string style) : base(length, width)
        {
            this.material = material;
            this.style = style; 
        }

        // Method
        public override void DisplayPhoto()
        {
            Console.WriteLine($"Framed Photo Length: {length}, Width: {width}, Material: {material}, Style: {style}");

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MattedPhoto first_photo = new MattedPhoto(10, 5, "black");

            FramedPhoto second_photo = new FramedPhoto(100, 500, "Silver", "Modern");

            first_photo.DisplayPhoto();

            second_photo.DisplayPhoto(); 
        }

    }
}
