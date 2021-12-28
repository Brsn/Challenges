using System;

namespace Challenge
{
    abstract class Shape  // Base class (parent) 
    {
        public abstract double Area { get; }

        public abstract string Name { get; }

        public abstract double Size { get; }

        public static double GetArea(Shape shape) => shape.Area;

        public string GetName(Shape shape) => GetType().Name.ToString();

        public double IncreaseSize(Shape shape, double percentage) => shape.Size * percentage;
        /*
        public double IncreaseSize(Shape shape)
        {
            
        }
        */
    }

    class Square : Shape  // Derived class (child) 

    {
        /* Default Constructor will set side = 1
         */
        public Square()
        {
            side = 1.0;
        }

        public Square(double side)
        {
            this.side = side;
        }

        public double side { get; set; }

        public override double Area => Math.Pow(side, 2);

        public override string Name => GetType().Name.ToString();

        public override double Size => side = side + (side * 0.10);
    }
    class Circle : Shape  // Derived class (child) 
    {
        /* Default Constructor will set radius = 1
         */
        public Circle()
        {
            radius = 1.0;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double radius { get; set; }

        public override double Area => Math.Round(Math.PI * Math.Pow(radius, 2), 2);

        public override string Name => GetType().Name.ToString();

        public override double Size => radius = radius + (radius * 0.10);
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Instance with default square value of 1
            Square mySquare = new Square();

            Square mySquareTwo = new Square(3);

            //Instance with default radius value of 1
            Circle myCircle = new Circle();

            Circle myCircleTwo = new Circle(2);

            Shape[] shapes = { mySquare, mySquareTwo, myCircle, myCircleTwo };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Name of the shape: " + shape.Name + " and the area of the shape: " + shape.Area);
                Console.WriteLine("Increasing the sizes of the shape by 10%");
                var temp = shape.Size;
                Console.WriteLine("Name of the shape: " + shape.Name + " and the area of the shape: " + " {0:0.00} ", shape.Area);
                Console.WriteLine("");

            }

        }
    }
}