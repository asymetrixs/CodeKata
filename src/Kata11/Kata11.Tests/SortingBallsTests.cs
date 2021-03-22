using Xunit;

namespace CodeKata.Kata11.Tests
{
    public class SortingBallsTests
    {
        [Fact]
        public void SortBallsAddNothingTest()
        {
            // Arrange
            var sortedList = new int[] { };
            var expectedSorted = new int[] { };

            // Act
            var actualSorted = SortingBalls.AddAndSort(sortedList, null);

            // Assert
            Assert.Equal(expectedSorted, actualSorted);
        }

        [Fact]
        public void SortBallsAdd20Test()
        {
            // Arrange
            var sortedList = new int[] { };
            var expectedSorted = new int[] { 20 };

            // Act
            var actualSorted = SortingBalls.AddAndSort(sortedList, 20);

            // Assert
            Assert.Equal(expectedSorted, actualSorted);
        }

        [Fact]
        public void SortBallsAdd10Test()
        {
            // Arrange
            var sortedList = new int[] { 20 };
            var expectedSorted = new int[] { 10, 20 };

            // Act
            var actualSorted = SortingBalls.AddAndSort(sortedList, 10);

            // Assert
            Assert.Equal(expectedSorted, actualSorted);
        }

        [Fact]
        public void SortBallsAdd30Test()
        {
            // Arrange
            var sortedList = new int[] { 10, 20 };
            var expectedSorted = new int[] { 10, 20, 30 };

            // Act
            var actualSorted = SortingBalls.AddAndSort(sortedList, 30);

            // Assert
            Assert.Equal(expectedSorted, actualSorted);
        }

        [Fact]
        public void SortBallsAdd25Test()
        {
            // Arrange
            var sortedList = new int[] { 10, 20, 30 };
            var expectedSorted = new int[] { 10, 20, 25, 30 };

            // Act
            var actualSorted = SortingBalls.AddAndSort(sortedList, 25);

            // Assert
            Assert.Equal(expectedSorted, actualSorted);
        }

        [Fact]
        public void SortBallsAdd27Test()
        {
            // Arrange
            var sortedList = new int[] { 10, 20, 30, 40 };
            var expectedSorted = new int[] { 10, 20, 27, 30, 40 };

            // Act
            var actualSorted = SortingBalls.AddAndSort(sortedList, 27);

            // Assert
            Assert.Equal(expectedSorted, actualSorted);
        }
    }
}
