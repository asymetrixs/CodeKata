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
        // Second block
        [InlineData(0, 1, new int[] { 1, 3, 5 })]
        [InlineData(1, 3, new int[] { 1, 3, 5 })]
        [InlineData(2, 5, new int[] { 1, 3, 5 })]
        [InlineData(-1, 0, new int[] { 1, 3, 5 })]
        [InlineData(-1, 2, new int[] { 1, 3, 5 })]
        [InlineData(-1, 4, new int[] { 1, 3, 5 })]
        [InlineData(-1, 6, new int[] { 1, 3, 5 })]
        // Third block
        [InlineData(0, 1, new int[] { 1, 3, 5, 7 })]
        [InlineData(1, 3, new int[] { 1, 3, 5, 7 })]
        [InlineData(2, 5, new int[] { 1, 3, 5, 7 })]
        [InlineData(3, 7, new int[] { 1, 3, 5, 7 })]
        [InlineData(-1, 0, new int[] { 1, 3, 5, 7 })]
        [InlineData(-1, 2, new int[] { 1, 3, 5, 7 })]
        [InlineData(-1, 4, new int[] { 1, 3, 5, 7 })]
        [InlineData(-1, 6, new int[] { 1, 3, 5, 7 })]
        [InlineData(-1, 8, new int[] { 1, 3, 5, 7 })]
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
