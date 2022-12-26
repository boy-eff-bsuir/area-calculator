using AreaCalculator.Core.Models;

namespace AreaCalculator.Tests
{
    public class TriangleValidationTests
    {
        [Theory]
        [InlineData(-1,1,1)]
        [InlineData(1,-1,1)]
        [InlineData(1,1,-1)]
        [InlineData(0,0,0)]
        public void ShouldThrowExceptionForNonPositiveSides(int a, int b, int c)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(a, b, c));
        }

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(1,2,1)]
        [InlineData(2,1,1)]
        public void ShouldThrowExceptionForNotValidTriangle(int a, int b, int c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }
    }
}