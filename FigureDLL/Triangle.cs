namespace ShapeDLL
{
    public class Triangle : IFigure
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }
        public double Accuracy { get; }

        public Triangle(double side1, double side2, double side3, double accuracy = 10e-12) 
        {
            if (!ValidTriangle(side1, side2, side3, accuracy))
            {
                throw new ArgumentException("Invalid triangle sides or accuracy.");
            }

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Accuracy = accuracy;
        }

        private static bool ValidTriangle(double side1, double side2, double side3, double accuracy)
        {
            return side1 > 0 && side2 > 0 && side3 > 0 && accuracy >= 0 &&
                   side1 + side2 > side3 &&
                   side2 + side3 > side1 &&
                   side1 + side3 > side2;
        }

        public virtual double Area()
        {
            var semiperimeter = Perimeter() / 2;

            return Math.Sqrt(semiperimeter * 
                (semiperimeter - Side1) * 
                (semiperimeter - Side2) * 
                (semiperimeter - Side3));

        }

        public virtual double Perimeter() => Side1 + Side2 + Side3;

        public virtual bool RightAngledTriangle()
        {
            var sides = new[] { Side1, Side2, Side3 }.OrderBy(s => s).ToArray();
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < Accuracy;
        }
    }
}