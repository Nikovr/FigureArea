using FigureArea.Exceptions;

namespace FigureArea.Entities
{
    public class Square : Figure
    {
        public Square(double side)
        {
            Validate(side);
            Side = side;
        }
        public double Side { get; private set; }

        public override double GetArea()
        {
            return Side * Side;
        }

        private void Validate(double side)
        {
            if (side <= 0)
            {
                throw new InvalidFigureException("square side length must be positive");
            }
        }
    }
}
