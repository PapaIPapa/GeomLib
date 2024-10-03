using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeomLibrary;

namespace GeomMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(5);
            var triangle = new Triangle(3, 4, 5);

            var circleArea = GeometryCalculator.CalculateArea(circle);
            var triangleArea = GeometryCalculator.CalculateArea(triangle);

            Console.WriteLine($"Площадь круга: {circleArea}");
            Console.WriteLine($"Площадь треугольника: {triangleArea}");

            if (triangle.IsRightAngled())
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            else
            {
                Console.WriteLine("Треугольник не прямоугольный");
            }
        }
    }
}
