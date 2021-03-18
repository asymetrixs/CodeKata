using System.IO;
using Xunit;

namespace CodeKata.Kata06.Tests
{
    public class UnitTests
    {
        [Fact]
        public void SearchForAnagrams()
        {
            // Arrange
            var fileContentLines = File.ReadAllLines("wordlist.txt");
            string crepitus = "ceiprstu";

            // Act
            Kata.SearchForAnagrams(fileContentLines);

            // Assert
            Assert.Contains(Kata.Words, w => w.Value.Count > 1);
            Assert.Contains(Kata.Words, w => w.Key == crepitus);
            Assert.Equal(4, Kata.Words[crepitus].Count);
        }
    }
}
