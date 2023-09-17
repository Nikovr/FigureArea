using FigureArea.Exceptions;

namespace FigureArea.Entities
{
    public class Circle : Figure
    {
        public Circle(double radius)
        {
            Validate(radius);
            Radius = radius;
        }

        public double Radius { get; private set; }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        private void Validate(double radius)
        {
            if (radius <= 0)
            {
                throw new InvalidFigureException("circle radius has to be positive");
            }
        }
    }
}
