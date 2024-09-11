using System;

namespace Lab2t
{
    public class Point
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Figure
    {
        private string name;
        private Point[] points;

        public string Name
        {
            get { return name; }
        }

        public Figure(Point p1, Point p2, Point p3)
            : this("Треугольник", p1, p2, p3)
        {
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
            : this("Четырехугольник", p1, p2, p3, p4)
        {
        }

        public Figure(string name, Point p1, Point p2, Point p3)
        {
            this.name = name;
            points = new Point[] { p1, p2, p3 };
        }

        public Figure(string name, Point p1, Point p2, Point p3, Point p4)
        {

            this.name = name;
            points = new Point[] { p1, p2, p3, p4 };
        }

        private double LengthSide(Point a, Point b)
        {
            double dx = a.X - b.X;
            double dy = a.Y - b.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public double PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                int j = (i + 1) % points.Length;
                perimeter += LengthSide(points[i], points[j]);
            }
            return perimeter;
        }
    }

    class Program
    {
        static void main(string[] args)
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 0);
            Point p3 = new Point(3, 4);
            Point p4 = new Point(0, 4);

            Figure triangle = new Figure(p1, p2, p3);
            Figure rectangle = new Figure(p1, p2, p3, p4);

            Console.WriteLine($"Название фигуры: {triangle.Name}");
            Console.WriteLine($"Периметр фигуры: {triangle.PerimeterCalculator()}");

            Console.WriteLine($"Название фигуры: {rectangle.Name}");
            Console.WriteLine($"Периметр фигуры: {rectangle.PerimeterCalculator()}");
        }
    }
}