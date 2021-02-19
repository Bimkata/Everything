using System;

namespace Дефиниране_на_прост_клас___правоъгълник
{
    class Program
    {
        class Rectangle
        {
            public double a;
            public double b;
            public double FaceSolving()
            {
                return a * b;
            }
            public double PerimeterSolving()
            {
                return 2 * a + 2 * b;
            }
        }
        static void Main(string[] args)
        {
            Rectangle A = new Rectangle();
            Console.Write("a = ");
            A.a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            A.b = double.Parse(Console.ReadLine());
            double rectangleFace;
            rectangleFace = A.FaceSolving();
            Console.WriteLine("Face: " + Math.Round(rectangleFace, 2));
            double rectanglePerimeter;
            rectanglePerimeter = A.PerimeterSolving();
            Console.WriteLine("Perimeter: " + Math.Round(rectanglePerimeter, 2));
            Console.ReadLine();
        }
    }
}
