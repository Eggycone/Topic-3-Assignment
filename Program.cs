using System.Reflection.Metadata;

namespace Topic_3_Assignment
{
    internal class Program;
    internal class Math
    {
        static void Main(string[] args)
            
        {
            // Constants
            const double Pi = float.Pi;
            const double sideA = 1;
            const double sideB = 8;
            // Ints
            int graduationYear;
            int roomNumber;
            // Doubles
            double circleArea;
            double circleRadius;
            double price;
            double hypotenuseLength;
            // Strings
            string className;
            string myName;
            // Assigning Variables
            circleRadius = 5;
            roomNumber = 29;
            price = 2.99;
            className = "Computer Science";
            myName = "Jack Moscrop";
            graduationYear = 2027;
            // Area of a circle
            circleArea = (Pi * (circleRadius * circleRadius));
            // Pythagorean Theorum
            hypotenuseLength = ((sideA * sideA) + (sideB * sideB));
            hypotenuseLength = double.Sqrt(hypotenuseLength);
            
            // Writing The Variables
            // Part 1
            Console.WriteLine($"This is room #{roomNumber}");
            Console.WriteLine($"The price is ${price}");
            Console.WriteLine($"This class is {className}");
            Console.WriteLine("");
            // Part 2
            Console.WriteLine("Name and graduation year");
            Console.WriteLine($"My name is {myName} and I will graduate in {graduationYear}.");
            Console.WriteLine("");
            // Part 3
            Console.WriteLine("Area of a circle");
            Console.WriteLine($"The area of a cicle with a radius of " + circleRadius + " will be " + double.Round(circleArea, 2) + " when rounded to 2 decimal places.");
            Console.WriteLine("");
            // Part 4
            Console.WriteLine("Pythagorean Theorum");
            Console.WriteLine("If a triangle with the side lengths of:");
            Console.WriteLine($"Side A: {sideA}");
            Console.WriteLine($"Side B: {sideB}");
            Console.WriteLine("Will have a hypotenuse length of " + double.Round(hypotenuseLength, 2) + " when rounded to 2 decimal places.");

            
            


        }
    }
}
