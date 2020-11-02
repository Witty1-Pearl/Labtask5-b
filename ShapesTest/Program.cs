using System;

namespace ShapesTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter name of Figure: ");
            string naming = Console.ReadLine();
            string name = naming.ToUpper();

            

            if(name == "SQUARE")
            {
                Console.Write("Enter the value for X: ");
                double x = double.Parse(Console.ReadLine());

                Square square = new Square(x,x,"square");
                Console.Write($"\nThe area of the rectangle is {square.Area()}");
               
            }
            else if(name == "CUBE")
            {
                Console.Write("Enter the value for X: ");
                double x = double.Parse(Console.ReadLine());

                Cube cube = new Cube(x,x,"cube");
                Console.Write($"\nThe area of the cube is {cube.Area()}");
            }
             else if(name == "TRIANGLE")
            {
                Console.Write("Enter the value for X: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Enter the value for Y: ");
                double y = double.Parse(Console.ReadLine());

                Triangle triangle = new Triangle(x, y, "triangle");
                Console.Write($"\nThe area of the triangle is {triangle.Area()}");
            }
             else if(name == "RECTANGLE")
            {
                Console.Write("Enter the value for X: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Enter the value for Y: ");
                double y = double.Parse(Console.ReadLine());

                Rectangle rectangle = new Rectangle(x, y, "rectangle");
                Console.Write($"\nThe area of the rectangle is {rectangle.Area()}");
            }

        }
    }
}
