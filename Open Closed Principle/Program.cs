using System;

namespace Open_Closed_Principle
{
    public class Program
    {
        /* Open/Closed Principle (OCP)
         * Problem: You have a class Shape with methods to calculate area. Now you need to add support for calculating the perimeter of shapes. How can you extend the functionality without modifying the existing Shape class?
         */
        static void Main(string[] args)
        {
            //Create Rectangle
            Rectangle rectangle = new Rectangle(5, 4);
            Console.WriteLine("Rectangle");
            Console.WriteLine("Area: " + rectangle.CalculateArea());
            Console.WriteLine("Perimeter: " + rectangle.CalculatePerimeter());

            //Create Circle
            Circle circle = new Circle(3);
            Console.WriteLine("Circle");
            Console.WriteLine("Area: " + circle.CalculateArea());
            Console.WriteLine("Perimeter: " + circle.CalculatePerimeter());

            Console.ReadLine();
        }
    }
}
