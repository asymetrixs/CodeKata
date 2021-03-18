using System.Collections.Generic;
using System.IO;
using Xunit;

namespace CodeKata.Kata06.Tests
{
    public class UnitTests
    {
        [Fact]
        public void RepresentLetterCount()
        {
            // Arrange

            // Act
            var actualRepresentation = "hallo".CalculateLetterCount();

            // Assert
            Assert.Equal("a=1,h=1,l=2,o=1", actualRepresentation);
        }

        [Fact]
        public void GetStringRepresentation()
        {
            // Arrange
            var list = new List<LetterCount>
            {
                new LetterCount(){ Count = 4, Letter = 'a' },
                new LetterCount(){ Count = 1, Letter = 'b' },
                new LetterCount(){ Count = 2, Letter = 'c' },
            };

            // Act
            var actualRepresentation = list.GetStringRepresentation();

            // Assert
            Assert.Equal("a=4,b=1,c=2", actualRepresentation);
        }

        [Fact]
        public void SearchForAnagrams()
        {
            // Arrange
            var fileContentLines = File.ReadAllLines("wordlist.txt");
            string crepitus = "crepitus".CalculateLetterCount();

            // Act
            Kata.SearchForAnagrams(fileContentLines);

            // Assert
            Assert.Contains(Kata.Words, w => w.Value.Count > 1);
            Assert.Contains(Kata.Words, w => w.Key == crepitus);
            Assert.Equal(4, Kata.Words[crepitus].Count);
        }
    }
}
