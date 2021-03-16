using Xunit;

namespace CodeKata.Kata02.Tests
{
    public class UnitTests
    {
        [Theory]
        // First block
        [InlineData(-1, 3, new int[] { })]
        [InlineData(-1, 3, new int[] { 1 })]
        [InlineData(0, 0, new int[] { 0 })]
        public void Tests(int expectedResult, int lookFor, int[] source)
        {
            // Arrange

            // Act
            int actualResult = Kata.Chop(lookFor, source);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
