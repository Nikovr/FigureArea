using FigureArea.Exceptions;

namespace FigureArea.Entities
{
    public class Triangle : Figure
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            Validate(sideA, sideB, sideC);
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public bool GetIsRightAngled()
        {
            double hypotenuse;
            double otherA;
            double otherB;

            if (SideA >= SideB && SideA >= SideC)
            {
                hypotenuse = SideA;
                otherA = SideB;
                otherB = SideC;
            }
            else if (SideB >= SideA && SideB >= SideC)
            {
                hypotenuse = SideB;
                otherA = SideC;
                otherB = SideA;
            }
            else
            {
                hypotenuse = SideC;
                otherA = SideA;
                otherB = SideB;
            }

            return new Square(hypotenuse).GetArea() == new Square(otherA).GetArea() + new Square(otherB).GetArea(); 
        }

        public override double GetArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }


        private void Validate(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new InvalidFigureException("triangle side(s) length has to be positive");
            }

            if (sideA >= sideB + sideC || sideB >= sideA + sideC || sideC >= sideA + sideB)
            {
                throw new InvalidFigureException("triangle can't exist, refer to triangle inequality");
            }
        }
    }
}
