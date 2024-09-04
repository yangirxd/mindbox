namespace ShapeDLL.Test
{
    public class CircleTests
    {
        private readonly double _accuracy = 10e-12;


        [Fact]
        public void ValidCircle()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.Throws<ArgumentException>(() => new Circle(-100));

        }

        [Fact]
        public void Area()
        {
            var radius = 100;
            var area = new Circle(radius).Area();

            Assert.True(Math.PI * radius * radius - area < _accuracy);
        }

        [Fact]
        public void Perimeter()
        {
            var radius = 100;
            var perimeter = new Circle(radius).Perimeter();

            Assert.True(2 * Math.PI * radius - perimeter < _accuracy);
        }

    }
}