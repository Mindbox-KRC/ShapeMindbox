namespace ShapeMindbox
{
    /// <summary>
    /// Represents a triangle shape.
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Gets or sets the length of side A of the triangle.
        /// </summary>
        public double SideA { get; set; }

        /// <summary>
        /// Gets or sets the length of side B of the triangle.
        /// </summary>
        public double SideB { get; set; }

        /// <summary>
        /// Gets or sets the length of side C of the triangle.
        /// </summary>
        public double SideC { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class with the specified side lengths.
        /// </summary>
        /// <param name="sideA">The length of side A.</param>
        /// <param name="sideB">The length of side B.</param>
        /// <param name="sideC">The length of side C.</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Calculates the area of the triangle using Heron's formula.
        /// </summary>
        /// <returns>The area of the triangle.</returns>
        public double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        /// <summary>
        /// Determines whether the triangle is a right triangle.
        /// </summary>
        /// <returns><c>true</c> if the triangle is a right triangle; otherwise, <c>false</c>.</returns>
        public bool IsRightTriangle()
        {
            double[] sides = { SideA, SideB, SideC };
            double tolerance = 1e-10;
            Array.Sort(sides);
            return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < tolerance;
        }
    }
}
