using Lab2t;

namespace Lab2t.Tests
{
    [TestFixture]
    public class PointTests
    {
        [Test]
        public void Point_StoresCoordinatesCorrectly()
        {
          
            int x = 5;
            int y = 10;

            
            Point point = new Point(x, y);

          
            //Assert.AreEqual(x, point.X, "Координата X была сохранена неправильно.");
            Assert.That(y==point.Y, "Координата Y была сохранена неправильно.");
        }
    }

    //[TestFixture]
    //public class FigureTests
    //{
    //    [Test]
    //    public void Figure_ConstructorWithThreePoints_CreatesTriangle()
    //    {
    //        // Arrange
    //        Point p1 = new Point(0, 0);
    //        Point p2 = new Point(3, 0);
    //        Point p3 = new Point(0, 4);

    //        // Act
    //        Figure triangle = new Figure(p1, p2, p3);

    //        // Assert
    //        Assert.AreEqual("Треугольник", triangle.Name, "Название фигуры должно быть 'Треугольник'.");
    //    }

    //    [Test]
    //    public void Figure_ConstructorWithFourPoints_CreatesQuadrilateral()
    //    {
    //        // Arrange
    //        Point p1 = new Point(0, 0);
    //        Point p2 = new Point(3, 0);
    //        Point p3 = new Point(3, 4);
    //        Point p4 = new Point(0, 4);

    //        // Act
    //        Figure rectangle = new Figure(p1, p2, p3, p4);

    //        // Assert
    //        Assert.AreEqual("Четырехугольник", rectangle.Name, "Название фигуры должно быть 'Четырехугольник'.");
    //    }

    //    [Test]
    //    public void PerimeterCalculator_Triangle_ReturnsCorrectPerimeter()
    //    {
    //        // Arrange
    //        Point p1 = new Point(0, 0);
    //        Point p2 = new Point(3, 0);
    //        Point p3 = new Point(0, 4);
    //        Figure triangle = new Figure(p1, p2, p3);

    //        // Act
    //        double perimeter = triangle.PerimeterCalculator();

    //        // Assert
    //        Assert.AreEqual(12, perimeter, "Периметр треугольника рассчитан неправильно.");
    //    }

    //    [Test]
    //    public void PerimeterCalculator_Quadrilateral_ReturnsCorrectPerimeter()
    //    {
    //        // Arrange
    //        Point p1 = new Point(0, 0);
    //        Point p2 = new Point(3, 0);
    //        Point p3 = new Point(3, 4);
    //        Point p4 = new Point(0, 4);
    //        Figure rectangle = new Figure(p1, p2, p3, p4);

    //        // Act
    //        double perimeter = rectangle.PerimeterCalculator();

    //        // Assert
    //        Assert.AreEqual(14, perimeter, "Периметр четырехугольника рассчитан неправильно.");
    //    }
    //}
}
