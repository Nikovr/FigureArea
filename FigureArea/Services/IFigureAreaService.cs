using FigureArea.Entities;

namespace FigureArea.Services
{
    public interface IFigureAreaService
    {
        Circle CreateCircle(double radius);
        Triangle CreateTriangle(double sideA, double sideB, double sideC);
        Square CreateSquare(double side);
        double CalculateArea(Figure figure);
    }
}
