using System.Collections.Generic;
using System.IO;
using Xunit;

namespace CodeKata.Kata08.Tests
{
    public class UnitTests
    {
        [Fact]
        public void TestSimple()
        {
            // Arrange
            IEnumerable<string> list = new List<string>() { "abc", "def", "word1", "word2", "abcdef", "hijklm", "nopqr" };

            // Act
            var actualWords = Kata.GetSixOfTwo(list);

            // Assert
            Assert.Contains(actualWords, aw => aw.Item1 == "abc" && aw.Item2 == "def" || aw.Item2 == "abc" && aw.Item1 == "def");
            Assert.Single(actualWords);
        }

        [Fact]
        public void TestComlex()
        {
            // Arrange
            IEnumerable<string> list = File.ReadAllLines("wordlist.txt");

            // Act
            var actualWords = Kata.GetSixOfTwo(list);

            // Assert
            Assert.Contains(actualWords, aw => aw.Item1 == "al" && aw.Item2 == "bums" || aw.Item2 == "al" && aw.Item1 == "bums");
            Assert.Contains(actualWords, aw => aw.Item1 == "bar" && aw.Item2 == "ely" || aw.Item2 == "bar" && aw.Item1 == "ely");
            Assert.Contains(actualWords, aw => aw.Item1 == "be" && aw.Item2 == "foul" || aw.Item2 == "be" && aw.Item1 == "foul");
            Assert.Contains(actualWords, aw => aw.Item1 == "con" && aw.Item2 == "vex" || aw.Item2 == "con" && aw.Item1 == "vex");
            Assert.Contains(actualWords, aw => aw.Item1 == "here" && aw.Item2 == "by" || aw.Item2 == "here" && aw.Item1 == "by");
            Assert.Contains(actualWords, aw => aw.Item1 == "jig" && aw.Item2 == "saw" || aw.Item2 == "jig" && aw.Item1 == "saw");
            Assert.Contains(actualWords, aw => aw.Item1 == "tail" && aw.Item2 == "or" || aw.Item2 == "tail" && aw.Item1 == "or");
            Assert.Contains(actualWords, aw => aw.Item1 == "we" && aw.Item2 == "aver" || aw.Item2 == "we" && aw.Item1 == "aver");
        }
    }
}
