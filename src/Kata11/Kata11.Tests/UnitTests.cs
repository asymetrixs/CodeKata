using System;
using Xunit;

namespace CodeKata.Kata11.Tests
{
    public class UnitTests
    {
        [Fact]
        public void SortBallsAddNothingTest()
        {
            // Arrange
            var sortedList = new int[] { };
            var expectedSorted = new int[] { };

            // Act
            var actualSorted = Kata11.AddAndSort(sortedList, null);

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
            var actualSorted = Kata11.AddAndSort(sortedList, 20);

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
            var actualSorted = Kata11.AddAndSort(sortedList, 10);

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
            var actualSorted = Kata11.AddAndSort(sortedList, 30);

            // Assert
            Assert.Equal(expectedSorted, actualSorted);
        }
    }
}
