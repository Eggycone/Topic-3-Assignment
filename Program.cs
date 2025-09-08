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
            // Ints
            int graduationYear;
            int roomNumber;
            // Doubles
            double circleArea;
            double circleRadius;
            double price;
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
            circleArea = (Pi * (circleRadius * circleRadius));
            // Writing The Variables
            Console.WriteLine($"This is room #{roomNumber}");
            Console.WriteLine($"The price is ${price}");
            Console.WriteLine($"This class is {className}");
            Console.WriteLine("");
            Console.WriteLine($"My name is {myName} and I will graduate in {graduationYear}.");
            Console.WriteLine("");
            Console.WriteLine($"The area of a cicle with a radius of {circleRadius} will be {float.Round(circleArea, 2)} when rounded to 2 decimal places.");
            


        }
    }
}
