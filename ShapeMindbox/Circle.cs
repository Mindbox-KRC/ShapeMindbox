namespace ShapeMindbox
{
    /// <summary>
    /// Represents a circle shape.
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Gets or sets the radius of the circle.
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class with the specified radius.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Calculates the area of the circle.
        /// </summary>
        /// <returns>The area of the circle.</returns>
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
