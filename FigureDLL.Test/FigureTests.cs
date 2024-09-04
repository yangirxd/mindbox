namespace ShapeDLL.Test
{
    public class FigureTests
    {
        [Fact]
        public void CalculateFigureAreaWithoutFigureType()
        {
            IFigure figure1 = new Triangle(12, 13, 14);
            IFigure figure2 = new Circle(123);
            Assert.True(figure1.Area() > 0);
            Assert.True(figure2.Area() > 0);
            Assert.True(figure1.Perimeter() > 0);
            Assert.True(figure2.Perimeter() > 0);
        }
    }
}
