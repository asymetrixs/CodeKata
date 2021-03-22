using Xunit;

namespace CodeKata.Kata11.Tests
{
    public class SortingCharactersTests
    {
        [Fact]
        public void SortCharactersTest()
        {
            // Arrange
            var text = "When not studying nuclear physics, Bambi likes to play\r\n beach volleyball.";

            var expectedSorted = "aaaaabbbbcccdeeeeeghhhiiiiklllllllmnnnnooopprsssstttuuvwyyyy";

            // Act
            var actualSorted = SortingCharacters.SortedCharacters(text);

            // Assert
            Assert.Equal(expectedSorted, actualSorted);
        }

        [Fact]
        public void SortedCharactersTest()
        {
            // Arrange
            var text = "When not studying nuclear physics, Bambi likes to play\r\n beach volleyball.";

            var expectedSorted = "aaaaabbbbcccdeeeeeghhhiiiiklllllllmnnnnooopprsssstttuuvwyyyy";

            // Act
            var actualSorted = SortingCharacters.SortedCharactersWithLinq(text);

            // Assert
            Assert.Equal(expectedSorted, actualSorted);
        }
    }
}
