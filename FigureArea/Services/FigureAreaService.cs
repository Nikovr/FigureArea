using FigureArea.Entities;

namespace FigureArea.Services
{
    public class FigureAreaService : IFigureAreaService
    {
        public double CalculateArea(Figure figure)
        {
            return figure.GetArea();
        }

        public Circle CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        public Square CreateSquare(double side)
        {
            return new Square(side);
        }

        public Triangle CreateTriangle(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC);
        }
    }
}
