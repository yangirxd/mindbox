namespace ShapeDLL
{
    public class Triangle(double side1, double side2, double side3, double accuracy = 10e-12) : IFigure
    {

        public double Side1 { get; } = ValidTriangle(side1, side2, side3, accuracy) 
            ? side1 
            : throw new ArgumentException("Any side of the triangle cannot be negative or sum of the two sides of the triangle cannot be less than the third side.");

        public double Side2 { get; } = ValidTriangle(side1, side2, side3, accuracy) 
            ? side2 
            : throw new ArgumentException("Any side of the triangle cannot be negative or sum of the two sides of the triangle cannot be less than the third side.");

        public double Side3 { get; } = ValidTriangle(side1, side2, side3, accuracy) 
            ? side3 
            : throw new ArgumentException("Any side of the triangle cannot be negative or sum of the two sides of the triangle cannot be less than the third side.");

        public double Accuracy { get; } = ValidTriangle(side1, side2, side3, accuracy) 
            ? accuracy 
            : throw new ArgumentException("The accuracy cannot be negative.");

        private static bool ValidTriangle(double side1, double side2, double side3, double accuracy)
        {
            if (side1 <= 0 ||
                side2 <= 0 ||
                side3 <= 0) return false;

            if (accuracy < 0) return false;

            if (side1 + side2 <= side3 ||
                side2 + side3 <= side1 ||
                side1 + side3 <= side2) return false;

            return true;
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
            var legs1 = Side1 < Side2 ? Side1 : Side2;
            var hypotenuse = Side1 > Side2 ? Side1 : Side2;
            var legs2 = hypotenuse < Side3 ? hypotenuse : Side3;
            hypotenuse = hypotenuse > Side3 ? hypotenuse : Side3;

            return Math.Abs(hypotenuse * hypotenuse - legs1 * legs1 - legs2 * legs2) < Accuracy;
        }
    }
}