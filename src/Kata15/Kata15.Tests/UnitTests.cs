using Xunit;

namespace CodeKata.Kata15.Tests
{
    public class UnitTests
    {
        [Fact]
        public void GenerateSequence3()
        {
            // Arrange
            const int digits = 3;
            var expectedResult = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };

            // Act
            var actualResult = Kata.GenerateSequence(digits);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void GenerateSequence4()
        {
            // Arrange
            const int digits = 4;
            var expectedResult = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            // Act
            var actualResult = Kata.GenerateSequence(digits);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void FindWithoutTwoAdjacent1BitsIn3Bits()
        {
            // Arrange
            var list = Kata.GenerateSequence(3);
            var expectedResult = new int[] { 0, 1, 2, 4, 5 };

            // Act
            var actualResult = Kata.FindWithoutTwoAdjacent1Bits(list);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void FindWithoutTwoAdjacent1BitsIn4Bits()
        {
            // Arrange
            var list = Kata.GenerateSequence(4);
            var expectedResult = new int[] { 0, 1, 2, 4, 5, 8, 9, 10 };

            // Act
            var actualResult = Kata.FindWithoutTwoAdjacent1Bits(list);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
