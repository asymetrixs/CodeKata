using Xunit;

namespace CodeKata.Kata11.Tests
{
    public class SortingCharactersTests
    {
        [Fact]
        public void SortBallsAddNothingTest()
        {
            // Arrange
            var text = "When not studying nuclear physics, Bambi likes to play\r\n beach volleyball.";

            var expectedSorted = "aaaaabbbbcccdeeeeeghhhiiiiklllllllmnnnnooopprsssstttuuvwyyyy";

            // Act
            var actualSorted = SortingCharacters.SortedCharacters(text);

            // Assert
            Assert.Equal(expectedSorted, actualSorted);
        }
    }
}
