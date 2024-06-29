using ShapeMindbox;
namespace ShapeMindboxTests
{
    /// <summary>
    /// Contains unit tests for the <see cref="Circle"/> class.
    /// </summary>
    [TestClass]
    public class CircleTest
    {
        /// <summary>
        /// Tests the <see cref="Circle.CalculateArea"/> method to ensure it returns the correct area.
        /// </summary>
        [TestMethod]
        public void CalculateAreaTest()
        {
            // Arrange: Create a circle with a radius of 10.
            Circle circle = new Circle(10);

            // The expected area is ? * radius^2 = ? * 10^2 = 100?.
            double expected = Math.PI * 100;

            // Act: Calculate the actual area using the Circle's CalculateArea method.
            double actual = circle.CalculateArea();

            // Assert: Verify that the actual area is equal to the expected area within a tolerance of 1e-10.
            Assert.AreEqual(expected, actual, 1e-10);
        }
    }
}
