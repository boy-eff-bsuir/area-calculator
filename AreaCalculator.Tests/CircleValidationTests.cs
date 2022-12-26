using AreaCalculator.Core.Models;

namespace AreaCalculator.Tests
{
    public class CircleValidationTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void ShouldThrowExceptionForNonPositiveRadius(double radius)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }
    }
}