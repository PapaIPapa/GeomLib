using System;

namespace GeomLibrary
{
    public enum FigureType
    {
        Circle,
        Triangle
    }

    public interface IFigure
    {
        double CalculateArea();
    }

    public class Circle : IFigure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Triangle : IFigure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public bool IsRightAngled()
        {
            // Используем теорему Пифагора для проверки
            return Math.Abs(Math.Pow(SideA, 2) + Math.Pow(SideB, 2) - Math.Pow(SideC, 2)) < double.Epsilon ||
                   Math.Abs(Math.Pow(SideA, 2) + Math.Pow(SideC, 2) - Math.Pow(SideB, 2)) < double.Epsilon ||
                   Math.Abs(Math.Pow(SideB, 2) + Math.Pow(SideC, 2) - Math.Pow(SideA, 2)) < double.Epsilon;
        }
    }

    public static class GeometryCalculator
    {
        public static double CalculateArea(IFigure figure)
        {
            return figure.CalculateArea();
        }

        public static FigureType GetFigureType(IFigure figure)
        {
            if (figure is Circle)
            {
                return FigureType.Circle;
            }
            else if (figure is Triangle)
            {
                return FigureType.Triangle;
            }
            else
            {
                throw new ArgumentException("Неизвестный тип фигуры");
            }
        }
    }
}