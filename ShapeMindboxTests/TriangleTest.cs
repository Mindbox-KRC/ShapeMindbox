using ShapeMindbox;

namespace ShapeMindboxTests
{
    /// <summary>
    /// Contains unit tests for the <see cref="Triangle"/> class.
    /// </summary>
    [TestClass]
    public class TriangleTest
    {
        /// <summary>
        /// Tests the <see cref="Triangle.CalculateArea"/> method to ensure it returns the correct area.
        /// </summary>
        [TestMethod]
        public void CalculateAreaTest()
        {
            // Arrange: Create a triangle with sides 5, 4, and 3.
            Triangle triangle = new Triangle(5, 4, 3);

            // The expected area is calculated using Heron's formula.
            double expected = 6.0;

            // Act: Calculate the actual area using the Triangle's CalculateArea method.
            double actual = triangle.CalculateArea();

            // Assert: Verify that the actual area is equal to the expected area within a tolerance of 1e-10.
            Assert.AreEqual(expected, actual, 1e-10);
        }

        /// <summary>
        /// Tests the <see cref="Triangle.IsRightTriangle"/> method to ensure it correctly identifies a right triangle.
        /// </summary>
        [TestMethod]
        public void IsRightTriangleTestTrue()
        {
            // Arrange: Create a triangle with sides 5, 4, and 3.
            Triangle triangle = new Triangle(5, 4, 3);

            // Act: Check if the triangle is a right triangle.
            bool isRight = triangle.IsRightTriangle();

            // Assert: Verify that the triangle is correctly identified as a right triangle.
            Assert.IsTrue(isRight);
        }

        /// <summary>
        /// Tests the <see cref="Triangle.IsRightTriangle"/> method to ensure it correctly identifies a non-right triangle.
        /// </summary>
        [TestMethod]
        public void IsRightTriangleTestFalse()
        {
            // Arrange: Create a triangle with sides 6, 4, and 3.
            Triangle triangle = new Triangle(6, 4, 3);

            // Act: Check if the triangle is a right triangle.
            bool isRight = triangle.IsRightTriangle();

            // Assert: Verify that the triangle is correctly identified as a non-right triangle.
            Assert.IsFalse(isRight);
        }
    }
}
