using ShapeMindbox;
namespace UserApp;

/// <summary>
/// The main entry point for the application.
/// </summary>
public class Program
{
    /// <summary>
    /// The main method, which is the entry point of the application.
    /// </summary>
    static void Main(string[] args)
    {
       

        // Create a circle with a radius of 10
        IShape circle = new Circle(10);

        // Create a triangle with sides 5, 4, and 3
        IShape triangle = new Triangle(5, 4, 3);

        // Output the area of the circle
        Console.WriteLine($"Area of the circle: {circle.CalculateArea()}");

        // Output the area of the triangle and bool if is Right
        Console.WriteLine($"Area of the triangle: {triangle.CalculateArea()}");

        // Check if the triangle is a right triangle
        if (triangle is Triangle triangl)
        {
            bool isRightTriangle = triangl.IsRightTriangle();
            Console.WriteLine($"Is the triangle right-angled? {isRightTriangle}");
        }
    }
}
