namespace ShapeDLL.Test
{
    public class TriangleTests
    {
        private readonly double _accuracy = 10e-12;

        [Fact]
        public void ValidTriangle()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(11, 0, 20));
            Assert.Throws<ArgumentException>(() => new Triangle(11, 15, 17, -1));
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 100));
        }

        [Fact]
        public void Area()
        {
            Assert.True(72.3079 - new Triangle(13, 14, 15).Area() < _accuracy);
        }

        [Fact]
        public void Perimeter()
        {
            var a = 13; 
            var b = 14; 
            var c = 15;

            Assert.True(a + b + c - new Triangle(a, b, c).Perimeter() < _accuracy);
        }

        [Fact]
        public void NotRightTriangle()
        {
            Assert.False(new Triangle(123, 123, 123).RightAngledTriangle());
        }

        [Fact]
        public void RightAngledTriangle() 
        {

            Assert.True(new Triangle(3, 4, 5).RightAngledTriangle());
        }

    }
}
