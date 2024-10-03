using NUnit.Framework;
using GeomLibrary;
using System;

namespace GeomLibTest
{
    [TestFixture]
    public class GeometryCalculatorTests
    {
        [Test]
        public void CalculateCircleArea_()
        {
            // Arrange
            var circle = new Circle(5);

            // Act
            var area = GeometryCalculator.CalculateArea(circle);

            // Assert
            Assert.That(area, Is.EqualTo(Math.PI * 25));
        }

        [Test]
        public void CalculateTriangleArea_()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var area = GeometryCalculator.CalculateArea(triangle);

            // Assert
            Assert.That(area, Is.EqualTo(6));
        }

        [Test]
        public void IsRightAngled_True()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.That(isRightAngled, Is.True);
        }

        [Test]
        public void IsRightAngled_False()
        {
            // Arrange
            var triangle = new Triangle(3, 10, 6);

            // Act
            var isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.That(isRightAngled, Is.False);
        }

        [Test]
        public void GetFigureType_()
        {
            // Arrange
            var circle = new Circle(5);
            var triangle = new Triangle(3, 4, 5);

            // Act
            var circleType = GeometryCalculator.GetFigureType(circle);
            var triangleType = GeometryCalculator.GetFigureType(triangle);

            // Assert
            Assert.That(circleType, Is.EqualTo(FigureType.Circle));
            Assert.That(triangleType, Is.EqualTo(FigureType.Triangle));
        }
    }
}