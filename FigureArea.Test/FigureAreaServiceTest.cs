using FigureArea.Exceptions;
using FigureArea.Services;

namespace FigureArea.Test
{
    public class FigureAreaServiceTest
    {
        private readonly IFigureAreaService _figureArea;

        public FigureAreaServiceTest()
        {
            _figureArea = new FigureAreaService();
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(1, 0, 0)]
        [InlineData(0, 1, 0)]
        [InlineData(0, 0, 1)]
        [InlineData(-2, -3, -4)]
        [InlineData(-1, -2, -2)]
        [InlineData(100, 1, 2)]
        [InlineData(1, 2, 3)]
        public void CreateInvalidTriangle_ThrowsException(double sideA, double sideB, double sideC)
        {
            Assert.Throws<InvalidFigureException>(() => _figureArea.CreateTriangle(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 2, 2)]
        [InlineData(4, 6, 8)]
        [InlineData(1.1, 2.1, 2.1)]
        [InlineData(1.1, 1.5, 2.1)]
        [InlineData(double.MaxValue, double.MaxValue, double.MaxValue)]
        public void CreateValidTriangle_DoesntThrowException(double sideA, double sideB, double sideC)
        {
            var exception = Record.Exception(() => _figureArea.CreateTriangle(sideA, sideB, sideC));
            Assert.Null(exception);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-2.5)]
        public void CreateInvalidCircle_ThrowsException(double radius)
        {
            Assert.Throws<InvalidFigureException>(() => _figureArea.CreateCircle(radius));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2.5)]
        [InlineData(4)]
        [InlineData(0.2)]
        [InlineData(double.MaxValue)]
        public void CreateValidCircle_DoesntThrowException(double radius)
        {
            var exception = Record.Exception(() => _figureArea.CreateCircle(radius));
            Assert.Null(exception);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-2.5)]
        public void CreateInvalidSquare_ThrowsException(double side)
        {
            Assert.Throws<InvalidFigureException>(() => _figureArea.CreateSquare(side));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2.5)]
        [InlineData(4)]
        [InlineData(0.2)]
        [InlineData(double.MaxValue)]
        public void CreateValidSquare_DoesntThrowException(double side)
        {
            var exception = Record.Exception(() => _figureArea.CreateSquare(side));
            Assert.Null(exception);
        }

        [Theory]
        [InlineData(4, 3, 5)]
        [InlineData(3, 5, 4)]
        [InlineData(5, 3, 4)]
        [InlineData(8, 6, 10)]
        public void RightAngleTriangle_True(double sideA, double sideB, double sideC)
        {
            Assert.True(_figureArea.CreateTriangle(sideA, sideB, sideC).GetIsRightAngled());
        }

        [Theory]
        [InlineData(3, 3, 4.243)]
        [InlineData(4, 7, 8)]
        [InlineData(3.1, 3.1, 4.384)]
        public void RightAngleTriangle_False(double sideA, double sideB, double sideC)
        {
            Assert.False(_figureArea.CreateTriangle(sideA, sideB, sideC).GetIsRightAngled());
        }

        [Theory]
        [InlineData(1, 1, 1, 0.4330127018922193)]
        [InlineData(4, 7, 8, 13.997767679169419)]
        [InlineData(8, 6, 10, 24)]
        [InlineData(3, 3, 4, 4.47213595499958)]
        public void TriangleArea_Correct(double sideA, double sideB, double sideC, double expected)
        {
            var figure = _figureArea.CreateTriangle(sideA, sideB, sideC);
            Assert.Equal(_figureArea.CalculateArea(figure), expected);
        }

        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(2.5, 19.634954084936208)]
        [InlineData(0.2, 0.12566370614359174)]
        [InlineData(5, 78.53981633974483)]
        public void CircleArea_Correct(double radius, double expected)
        {
            var figure = _figureArea.CreateCircle(radius);
            Assert.Equal(_figureArea.CalculateArea(figure), expected);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(3, 9)]
        [InlineData(2.5, 6.25)]
        [InlineData(1.12, 1.2544000000000002)]
        public void SquareArea_Correct(double side, double expected)
        {
            var figure = _figureArea.CreateSquare(side);
            Assert.Equal(_figureArea.CalculateArea(figure), expected);
        }
    }
}