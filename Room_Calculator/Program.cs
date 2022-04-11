using System;

namespace Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of the room: ");
            string lengthInput = Console.ReadLine();
            double length = double.Parse(lengthInput);

            Console.WriteLine("Please enter the width of the room: ");
            string widthInput = Console.ReadLine();
            double width = double.Parse(widthInput);

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("The area of your room is " + area);
            Console.WriteLine("The perimeter of your room is " + perimeter);

            if (area <= 250)
                Console.WriteLine("The room is a small room");
            else if (area >= 650)
                Console.WriteLine("This room is a large room");
            else
                Console.WriteLine("This room is a medium room");

            Console.WriteLine("Would you like to know the volume and surface area of the room? Please enter the height of the room.");
            string heightInput = Console.ReadLine();
            double height = double.Parse(heightInput);

            double volume = length * height * width;
            double surfaceArea = 2 * ((length * width) + (length * height) + (width * height));
            Console.WriteLine("The volume of your room is " + volume);
            Console.WriteLine("The surface area of your room is " + surfaceArea);
        }
    }
}
