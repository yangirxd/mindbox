namespace ShapeDLL
{
    public sealed class Circle(double radius) : IFigure
    {
        public double Radius { get; } = ValidRadius(radius) 
            ? radius 
            : throw new ArgumentException("The radius cannot be negative or equal to zero.");

        private static bool ValidRadius(double radius) => radius > 0;

        public double Area() => Math.PI * Radius * Radius;

        public double Perimeter() => 2 * Math.PI * Radius;
    }
}
